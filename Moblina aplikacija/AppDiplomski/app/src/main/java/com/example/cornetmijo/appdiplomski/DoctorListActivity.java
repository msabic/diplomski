package com.example.cornetmijo.appdiplomski;

import android.content.Intent;
import android.os.Parcelable;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;
import android.widget.Toast;

import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.Volley;
import com.example.cornetmijo.appdiplomski.DoctorList;
import com.google.gson.Gson;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;


public class DoctorListActivity extends AppCompatActivity {

    public String IPAddress;
    public int userID;
    ListView list;
    public  DoctorList adapter;
    public DoctorListActivity activity_doctor;
    String[] itemname = new String[1] ;
    private boolean temp=false;
    public static ArrayList<Doctor> _doctor_list=new ArrayList<>();
    Integer[] imgid = new Integer[1];
    @Override

    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_doctor_list);
        itemname[0]="a";
        imgid[0]=R.drawable.ic_person;
        IPAddress=getIntent().getStringExtra("IPAddress");
        userID= Integer.parseInt(getIntent().getStringExtra("userID"));
        activity_doctor=this;
        Select_Doctor();




    }
    private void Select_Doctor()
    {
        RequestQueue queue = Volley.newRequestQueue(this);
        String url = "http://"+IPAddress+":3000/SelectDoktorAll";
        JsonArrayRequest jsonObjReq = new JsonArrayRequest(Request.Method.GET,
                url, null,
                new Response.Listener<JSONArray>() {
                    @Override
                    public void onResponse(JSONArray response) {
                        itemname=new String[response.length()];
                        imgid=new Integer[response.length()];
                        for(int i=0; i<response.length(); i++)
                        {
                            Gson gson = new Gson();
                            try {

                                JSONObject objectjson=response.getJSONObject(i);
                                Doctor doctor = new Gson().fromJson(objectjson.toString(), Doctor.class);
                                String name=doctor.getIme().toString()+" "+doctor.getPrezime().toString();
                                itemname[i]=name;
                                imgid[i]=R.drawable.ic_person;
                                _doctor_list.add(doctor);
                            }
                            catch (JSONException ex)
                            {

                            }
                            finally {
                                adapter=new DoctorList(activity_doctor, itemname, imgid);
                                AddListeners();
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
                });




        queue.add(jsonObjReq);



    }
    public void AddListeners(){
        list=(ListView)findViewById(R.id.list);
        list.setAdapter(adapter);

        list.setOnItemClickListener(new AdapterView.OnItemClickListener() {

            @Override
            public void onItemClick(AdapterView<?> parent, View view,
                                    int position, long id) {

                Doctor dr=(Doctor)_doctor_list.get(+position);
                String Slecteditem= itemname[+position];
                Toast.makeText(getApplicationContext(), Slecteditem, Toast.LENGTH_SHORT).show();
                Intent i = new Intent( DoctorListActivity.this, DoctorViewActivity.class);
                i.putExtra("Doctor", dr.getID_Doktor());
                i.putExtra("IPAddress",IPAddress);
                startActivity(i);
            }
        });
    }
}