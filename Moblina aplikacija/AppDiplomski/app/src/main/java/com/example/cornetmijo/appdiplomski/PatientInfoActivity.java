package com.example.cornetmijo.appdiplomski;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.Toast;

import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonObjectRequest;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;

import org.apache.http.HttpResponse;
import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.DefaultHttpClient;
import org.apache.http.util.EntityUtils;
import org.json.JSONObject;

import java.util.HashMap;
import java.util.Map;

public class PatientInfoActivity extends AppCompatActivity {

    public String IPAddress;
    public EditText fatherName;
    public EditText motherName;
    public EditText address;
    public EditText phone;
    public EditText mobile;
    public EditText UCID;
    public CheckBox inmarriage;
    public CheckBox smoker;
    public int userID;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_patient_info);
        SharedPreferences prefs = getSharedPreferences("MyPrefsFile", MODE_PRIVATE);

        userID=Integer.parseInt(prefs.getString("userID", "0"));
        IPAddress=prefs.getString("IPAddress", null);
        fatherName=(EditText)findViewById(R.id.FatherNameTE);
        motherName=(EditText)findViewById(R.id.MotherNameTE);
        address=(EditText)findViewById(R.id.AddressTE);
        phone=(EditText)findViewById(R.id.PhoneTE);
        mobile=(EditText)findViewById(R.id.MobileTE);
        UCID=(EditText)findViewById(R.id.UCIDTE);
        inmarriage=(CheckBox)findViewById(R.id.inmarriageCB);
        smoker=(CheckBox)findViewById(R.id.smokerCB);

        Button btn =(Button)findViewById(R.id.btnSave);
        btn.setOnClickListener(new View.OnClickListener()
        {

            @Override
            public void onClick(View v)
            {
        if(!fatherName.getText().toString().isEmpty() && !motherName.getText().toString().isEmpty()
                && !address.getText().toString().isEmpty() && !phone.getText().toString().isEmpty()
                && !mobile.getText().toString().isEmpty() && !UCID.getText().toString().isEmpty())
        {
               Insert();
        }
        else
        {
            Context context = getApplicationContext();
            CharSequence text = "Hello toast!";
            int duration = Toast.LENGTH_SHORT;

            Toast toast = Toast.makeText(context, text, duration);
            toast.show();
        } }
        });

    }
    private void Insert()
    {

       /* RequestQueue queue = Volley.newRequestQueue(this);
        String url = "http://192.168.31.146:3000/InsertPacijentDodatno";
        JsonObjectRequest jsonObjReq = new JsonObjectRequest(Request.Method.GET,
                url, null,
                new Response.Listener<JSONObject>() {
                    @Override
                    public void onResponse(JSONObject response) {

                        //Success Callback
                        System.out.println("RESPONESEEEE: " + response.toString());
                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {

                        //Failure Callback
                        System.out.println("FAILLL BABAC: " + error);
                    }
                })

        {

            *//** Passing some request headers* *//*
            @Override
            public Map<String,String> getHeaders() throws AuthFailureError {
                HashMap<String,String> headers = new HashMap();
                headers.put("father_name", fatherName.getText().toString());
                headers.put("mother_name", motherName.getText().toString());
                headers.put("address", address.getText().toString());
                headers.put("phone", phone.getText().toString());
                headers.put("mob", mobile.getText().toString());
                headers.put("jmbg", UCID.getText().toString());
                if(inmarriage.isChecked()) {
                    headers.put("relationship_status", "ozenjen");
                }else
                {
                    headers.put("relationship_status", "ne ozenjen");
                }
                if(smoker.isChecked()){
                headers.put("smoker", "1");}
                else
                {
                    headers.put("smoker", "0");
                }
                return headers;
            }
        };

// Adding the request to the queue along with a unique string tag
        queue.add(jsonObjReq);
        */
        RequestQueue queue = Volley.newRequestQueue(this);
        //String url = "http://192.168.31.146:3000/InsertPacijentDodatno";
        String url = "http://"+IPAddress+":3000/InsertPacijentDodatno";
        StringRequest postRequest = new StringRequest(Request.Method.GET, url,
                new Response.Listener<String>()
                {
                    @Override
                    public void onResponse(String response) {
                        // response
                        if(response.equalsIgnoreCase("true")){
                            fatherName.setText("");
                            motherName.setText("");
                            address.setText("");
                            phone.setText("");
                            mobile.setText("");
                            UCID.setText("");
                            inmarriage.setChecked(false);
                            smoker.setChecked(false);
                            Intent i = new Intent(PatientInfoActivity.this, ChangePassword.class);
                            i.putExtra("userID",""+userID+"");
                            i.putExtra("IPAddress",IPAddress);
                            startActivity(i);
                        }
                        Log.d("Response", response);
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
                params.put("father_name", fatherName.getText().toString());
                params.put("mother_name", motherName.getText().toString());
                params.put("address", address.getText().toString());
                params.put("phone", phone.getText().toString());
                params.put("mob", mobile.getText().toString());
                params.put("jmbg", UCID.getText().toString());
                params.put("patientID",""+userID+"");
                if(inmarriage.isChecked()) {
                    params.put("relationship_status", "ozenjen");
                }else
                {
                    params.put("relationship_status", "ne ozenjen");
                }
                if(smoker.isChecked()){
                    params.put("smoker", "1");}
                else
                {
                    params.put("smoker", "0");
                }

                return params;
            }
        };
        queue.add(postRequest);
    }
}
