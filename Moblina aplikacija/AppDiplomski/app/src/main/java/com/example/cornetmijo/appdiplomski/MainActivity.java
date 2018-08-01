package com.example.cornetmijo.appdiplomski;

import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.util.Base64;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;

import java.nio.charset.StandardCharsets;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.HashMap;
import java.util.Map;

public class MainActivity extends AppCompatActivity {
    public String IPAddress ="192.168.31.87";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Button btn =(Button)findViewById(R.id.btnLogin);
        final EditText email =(EditText)findViewById(R.id.EmailTE);
        final EditText password = (EditText)findViewById(R.id.PasswordTE);

        btn.setOnClickListener(new View.OnClickListener()
        {

            @Override
            public void onClick(View v)
            {
                String userEmail="";userEmail=email.getText().toString();
                String userPassword="";userPassword=password.getText().toString();
                if(!userEmail.isEmpty() && !userPassword.isEmpty())
                {
                    Login(userEmail,userPassword);
                }
                else
                {
                    Context context = getApplicationContext();
                    CharSequence text = "Hello toast!";
                    int duration = Toast.LENGTH_SHORT;

                    Toast toast = Toast.makeText(context, text, duration);
                    toast.show();
                }
            }
        });
    }

    private void Login(final String email, final String password)
    {
        RequestQueue queue = Volley.newRequestQueue(this);
        //String url = "http://192.168.0.11:3000/Login";

        String url = "http://"+IPAddress+":3000/Login";

        StringRequest postRequest = new StringRequest(Request.Method.GET, url,
                new Response.Listener<String>()
                {
                    @Override
                    public void onResponse(String response) {
                        // response

                        String hashResult = md5("1950th"+email+";"+password);
                        byte[] data = hashResult.getBytes(StandardCharsets.UTF_8);
                        String base64 = Base64.encodeToString(data, Base64.DEFAULT);
                        hashResult=base64.replace("\n","");
                        String hashResponse=response.split(";")[0];
                        int id_user=Integer.parseInt(response.split(";")[1]);
                        int active=Integer.parseInt(response.split(";")[2]);
                        if(hashResponse.equalsIgnoreCase(hashResult) )
                        {
                            if(active==0){
                                SharedPreferences.Editor editor = getSharedPreferences("MyPrefsFile", MODE_PRIVATE).edit();
                                editor.putString("userID", ""+id_user+"");
                                editor.putString("IPAddress", IPAddress);
                                editor.apply();
                                Intent i = new Intent( MainActivity.this, PatientInfoActivity.class);
                               // i.putExtra("userID",""+id_user+"");
                               // i.putExtra("IPAddress",IPAddress);
                                startActivity(i);
                                finish();
                            finish();}
                            else
                            {
                                SharedPreferences.Editor editor = getSharedPreferences("MyPrefsFile", MODE_PRIVATE).edit();
                                editor.putString("userID", ""+id_user+"");
                                editor.putString("IPAddress", IPAddress);
                                editor.apply();
                                Intent i = new Intent( MainActivity.this, MenuActivity.class);
                                //i.putExtra("userID",""+id_user+"");
                                //i.putExtra("IPAddress",IPAddress);
                                startActivity(i);
                                finish();
                            }
                        }
                        else
                        {
                            Context context = getApplicationContext();
                            CharSequence text = "Hello toast!";
                            int duration = Toast.LENGTH_SHORT;

                            Toast toast = Toast.makeText(context, text, duration);
                            toast.show();
                        }

// Receiving side

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
                params.put("email",email);
                params.put("password",password);
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
