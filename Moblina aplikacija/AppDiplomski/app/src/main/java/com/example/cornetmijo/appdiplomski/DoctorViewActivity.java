package com.example.cornetmijo.appdiplomski;

import android.content.Context;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Base64;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.MultiAutoCompleteTextView;
import android.widget.Toast;

import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.google.gson.Gson;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.nio.charset.StandardCharsets;
import java.util.HashMap;
import java.util.Map;

public class DoctorViewActivity extends AppCompatActivity {
    public static Doctor dr;
    public int ID_dr = 0;
    public String IPAddress = "";
    public EditText name;
    public EditText email;
    public EditText address;
    public EditText phone;
    public EditText subject;
    public MultiAutoCompleteTextView message;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_doctor_view);
        IPAddress = getIntent().getStringExtra("IPAddress");
        ID_dr = getIntent().getIntExtra("Doctor", 0);
        dr=new Doctor();
        Select_doctor();
        name=(EditText)findViewById(R.id.NameTE);
        email=(EditText)findViewById(R.id.EmailTE);
        address=(EditText)findViewById(R.id.AddressTE);
        phone=(EditText)findViewById(R.id.PhoneTE);
        subject=(EditText)findViewById(R.id.subjectTE);
        message=(MultiAutoCompleteTextView)findViewById(R.id.messageTE);
        Button btn = (Button)findViewById(R.id.sendEmailBTN);
        btn.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(!subject.getText().toString().isEmpty() && !message.getText().toString().isEmpty())
                {
                Send_Email();
                }
                else
                {
                    MessageText("Subject or message is empty!");

                }
            }
        });
    }
    private void MessageText(String message)
    {
        Context context = getApplicationContext();
        CharSequence text = message;
        int duration = Toast.LENGTH_SHORT;

        Toast toast = Toast.makeText(context, text, duration);
        toast.show();
    }
    private void Send_Email()
    {
        RequestQueue queue = Volley.newRequestQueue(this);

        String url = "http://"+IPAddress+":3000/SendEmail";

        StringRequest postRequest = new StringRequest(Request.Method.GET, url,
                new Response.Listener<String>()
                {
                    @Override
                    public void onResponse(String response) {
                        // response

                        if(response.equalsIgnoreCase("true"))
                                {
                                    subject.setText("");
                                    message.setText("");
                                    MessageText("Email is send!");
                                }
                    }
                },
                new Response.ErrorListener()
                {
                    @Override
                    public void onErrorResponse(VolleyError error) {

                        Log.d("ERROR","error => "+error.toString());
                    }
                }
        ) {
            @Override
            public Map<String, String> getHeaders() throws AuthFailureError {
                Map<String, String>  params = new HashMap<String, String>();
                params.put("subject", subject.getText().toString());
                params.put("message_email", message.getText().toString());
                params.put("email",dr.getEmail());
                return params;
            }
        };
        queue.add(postRequest);

    }
    private void Select_doctor() {

        RequestQueue queue = Volley.newRequestQueue(this);
        String url = "http://" + IPAddress + ":3000/SelectDoktorId";
        JsonArrayRequest jsonObjReq = new JsonArrayRequest(Request.Method.GET,
                url, null,
                new Response.Listener<JSONArray>() {
                    @Override
                    public void onResponse(JSONArray response) {

                        for (int i = 0; i < response.length(); i++) {
                            Gson gson = new Gson();
                            try {

                                JSONObject objectjson = response.getJSONObject(i);
                                Doctor doctor = new Gson().fromJson(objectjson.toString(), Doctor.class);
                                dr= doctor;
                            } catch (JSONException ex) {

                            } finally {
                                name.setText(dr.getIme()+" "+dr.getPrezime());
                                email.setText(dr.getEmail());
                                address.setText("bb");
                                phone.setText(dr.getKontakt());

                                String ime=dr.getIme();
                            }
                        }

                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {

                        //Failure Callback
                        System.out.println("FAILLL: " + error);
                    }
                })

        {
            @Override
            public Map<String, String> getHeaders() throws AuthFailureError {
                HashMap<String, String> headers = new HashMap();
                headers.put("id", "" + ID_dr + "");

                return headers;
            }
        };
        queue.add(jsonObjReq);
    }
}