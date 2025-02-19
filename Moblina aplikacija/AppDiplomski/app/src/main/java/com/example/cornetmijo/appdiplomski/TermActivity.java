package com.example.cornetmijo.appdiplomski;

import android.content.Context;
import android.content.Intent;
import android.graphics.PathEffect;
import android.provider.ContactsContract;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.ImageButton;
import android.widget.Spinner;
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

import java.security.cert.Extension;
import java.sql.Time;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import android.text.format.DateFormat;
public class TermActivity extends AppCompatActivity {
    int pYear;
    int pDay;
    int pMonth;
    public String IPAddress;
    public int userID;
    public   DatePicker datePicker;
    public static Patient patient;
    public static boolean f=true;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_term);
        IPAddress=getIntent().getStringExtra("IPAddress");
        userID= Integer.parseInt(getIntent().getStringExtra("userID"));
        patient = new Patient();
        SelectPatient();
        Button btnChooseTime= (Button) findViewById(R.id.btnChooseTime);
        datePicker=(DatePicker)findViewById(R.id.simpleDatePicker);
        btnChooseTime.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                pDay=datePicker.getDayOfMonth();
                pMonth=datePicker.getMonth();
                pYear=datePicker.getYear();
                NoWorkingDay(""+pYear+"-"+(pMonth+1)+"-"+pDay);
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
    public void NoWorkingDay(final String Datum)
    {


        RequestQueue queue = Volley.newRequestQueue(this);
        //String url = "http://192.168.31.146:3000/InsertPacijentDodatno";
        String url = "http://"+IPAddress+":3000/SelectNeradniDaniDate";
        StringRequest postRequest = new StringRequest(Request.Method.GET, url,
                new Response.Listener<String>()
                {
                    @Override
                    public void onResponse(String response) {
                        // response
                        try {
                            if (response.equalsIgnoreCase("true")) {


                                f = true;

                            } else {
                                f = false;
                            }
                            Log.d("Response", response);
                        }
                        catch (Exception e)
                        {
                            Log.d("Error", e.getMessage());
                        }
                        finally {
                            pDay=datePicker.getDayOfMonth();
                            pMonth=datePicker.getMonth();
                            pYear=datePicker.getYear();

                            Calendar calendar = Calendar.getInstance();
                            calendar.set(pYear, pMonth, pDay);
                            Date date = calendar.getTime();
                            int a=calendar.get(Calendar.DAY_OF_WEEK);
                            int iddoctor=patient.getDoktor_ID_Doktor();
                            if(new Date().before(date) && !f && calendar.get(Calendar.DAY_OF_WEEK)!=7 && calendar.get(Calendar.DAY_OF_WEEK)!=1){
                                Intent i = new Intent(TermActivity.this, ConfirmTermActivity.class);
                                i.putExtra("date", "" + pYear + "," + pMonth + "," + pDay);
                                i.putExtra("userID", "" + userID + "");
                                i.putExtra("IPAddress", IPAddress);
                                i.putExtra("doctorID", ""+iddoctor+"");
                                startActivity(i);
                            }
                            else
                            {
                                MessageText("The selected date is not available!");
                            }
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
                params.put("datum", Datum);


                return params;
            }
        };
        queue.add(postRequest);


    }
    public void SelectPatient()
    {

        RequestQueue queue = Volley.newRequestQueue(this);
        String url = "http://"+IPAddress+":3000/SelectPacijentID";
        JsonArrayRequest jsonObjReq = new JsonArrayRequest(Request.Method.GET,
                url, null,
                new Response.Listener<JSONArray>() {
                    @Override
                    public void onResponse(JSONArray response) {
                        for(int i=0; i<response.length(); i++)
                        {
                            Gson gson = new Gson();
                            try {

                                JSONObject objectjson=response.getJSONObject(i);
                                Patient p = new Gson().fromJson(objectjson.toString(), Patient.class);
                                patient=p;

                            }
                            catch (JSONException ex)
                            {
                                Log.d("Error:", ex.toString());
                            }

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
}
