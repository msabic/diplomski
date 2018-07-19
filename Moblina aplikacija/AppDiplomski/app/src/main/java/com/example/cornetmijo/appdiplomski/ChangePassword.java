package com.example.cornetmijo.appdiplomski;

import android.app.Notification;
import android.app.ProgressDialog;
import android.content.Context;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.JsonWriter;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;
import com.example.cornetmijo.appdiplomski.Patient;
import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.JsonObjectRequest;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;
import com.google.gson.Gson;
import com.google.gson.JsonObject;

import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.HashMap;
import java.util.Map;

public class ChangePassword extends AppCompatActivity {
    public String IPAddress;
    public EditText oldPassword;
    public EditText newPassword;
    public EditText confirmPassword;
    public int userID;
    public static Patient patient_class=new Patient();
    ProgressDialog progressDialog;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        userID= Integer.parseInt(getIntent().getStringExtra("userID"));
        IPAddress=getIntent().getStringExtra("IPAddress");
        setContentView(R.layout.activity_change_password);
        oldPassword=(EditText)findViewById(R.id.OldPasswordTE) ;
        newPassword=(EditText)findViewById(R.id.NewPasswordTE);
        confirmPassword=(EditText)findViewById(R.id.NewPassword2TE);
        Select_user();
    Button btn = (Button)findViewById(R.id.btnChange);
        btn.setOnClickListener(new View.OnClickListener()
        {

            @Override
            public void onClick(View v)
            {
            if(!oldPassword.getText().toString().isEmpty() && !newPassword.getText().toString().isEmpty() && !confirmPassword.getText().toString().isEmpty())
                {
                    if(patient_class.getLozinka().toString().equalsIgnoreCase(md5(oldPassword.getText().toString())))
                    {
                        if(newPassword.getText().toString().equalsIgnoreCase(confirmPassword.getText().toString()))
                        {
                            ChangePassword(newPassword.getText().toString());
                        }
                        else
                        {
                            MessageText("Lozinke trebaju biti iste!");
                        }
                    }
                    else
                    {
                        MessageText("stara lozinka nije ispravna!");
                    }
                }
                else
                {
                        MessageText("sva polja trebaju biti popunjena!");
                } }
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
    private void Select_user()
    {

       RequestQueue queue = Volley.newRequestQueue(this);
        String url = "http://"+IPAddress+":3000/SelectPacijentID";
        JsonArrayRequest jsonObjReq = new JsonArrayRequest(Request.Method.GET,
                url, null,
                new Response.Listener<JSONArray>() {
                    @Override
                    public void onResponse(JSONArray response) {
                        Gson gson = new Gson();
                    try {

                        JSONObject objectjson=response.getJSONObject(0);
                        Patient pat = new Gson().fromJson(objectjson.toString(), Patient.class);
                        patient_class=pat;
                        //Patient[] pat= gson.fromJson(objectjson.toString(),Patient[].class);

                        //patient=new Patient();
                        //patient = gson.fromJson(objectjson.toString(), Patient.class);
                        //Success Callback
                        // System.out.println("RESPONESEEEE: " + response.toString());
                        }
                    catch (JSONException ex)
                        {

                        }
                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {

                        //Failure Callback
                        System.out.println("FAILLL BABAC: " + error);
                    }
                })

        { @Override
            public Map<String,String> getHeaders() throws AuthFailureError {
                HashMap<String,String> headers = new HashMap();
                headers.put("id", ""+userID+"");

                return headers;
            }
        };
        queue.add(jsonObjReq);
    }
    public void ChangePassword(final String newUserPassword)
    {
        RequestQueue queue = Volley.newRequestQueue(this);
        //String url = "http://192.168.31.146:3000/InsertPacijentDodatno";
        String url = "http://"+IPAddress+":3000/ChangePasswordPacijent";
        StringRequest postRequest = new StringRequest(Request.Method.GET, url,
                new Response.Listener<String>()
                {
                    @Override
                    public void onResponse(String response) {
                        // response
                        if(response.equalsIgnoreCase("true")){

                            Intent i = new Intent(ChangePassword.this, MainActivity.class);
                            i.putExtra("userID",""+userID+"");
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
                params.put("id", ""+patient_class.getID_Pacijent()+"");
                params.put("password", newUserPassword);

                return params;
            }
        };
        queue.add(postRequest);
    }
    public static final String md5(final String s) {
        final String MD5 = "MD5";
        try {
            // Create MD5 Hash
            MessageDigest digest = java.security.MessageDigest.getInstance(MD5);
            digest.update(s.getBytes());
            byte messageDigest[] = digest.digest();

            // Create Hex String
            StringBuilder hexString = new StringBuilder();
            for (byte aMessageDigest : messageDigest) {
                String h = Integer.toHexString(0xFF & aMessageDigest);
                while (h.length() < 2)
                    h = "0" + h;
                hexString.append(h);
            }
            return hexString.toString();

        } catch (NoSuchAlgorithmException e) {
            e.printStackTrace();
        }
        return "";
    }
}
