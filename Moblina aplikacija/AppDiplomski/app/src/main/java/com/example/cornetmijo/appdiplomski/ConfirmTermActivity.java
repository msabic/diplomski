package com.example.cornetmijo.appdiplomski;

import android.content.Intent;
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
import com.google.gson.Gson;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.sql.Time;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class ConfirmTermActivity extends AppCompatActivity {
    public String IPAddress;
    public int userID;
    public Date date;
    public static boolean jutro=false;
    public static int pYear;
    public static int pDay;
    public static int pMonth;
    public static WorkingTime workingTime;
    ListView list;
    Doctor doctor;
    public static DoctorList adapter;
    public static ConfirmTermActivity confirmTermActivity;
    public static String[] itemname = new String[1] ;
    private boolean temp=false;
    public static ArrayList<Doctor> _doctor_list=new ArrayList<>();
    public static Integer[] imgid = new Integer[1];
    public static List<Time> timesAM ;
    public static List<Time> timesPM ;
    public static AgreedTerm agreedTerm;
    public static List<AgreedTerm> _agreedTerm;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_confirm_term);
        String d=getIntent().getStringExtra("date");
        _agreedTerm=new ArrayList<AgreedTerm>();
        agreedTerm= new AgreedTerm();
        pDay=Integer.parseInt(d.split(",")[2]);
        pMonth=Integer.parseInt(d.split(",")[1])+1;
        pYear=Integer.parseInt(d.split(",")[0]);
        date=new Date(Integer.parseInt(d.split(",")[0]),Integer.parseInt(d.split(",")[1])+1,Integer.parseInt(d.split(",")[1]));
        itemname[0]="a";
        imgid[0]=R.drawable.ic_menu_camera;
        IPAddress=getIntent().getStringExtra("IPAddress");
        userID= Integer.parseInt(getIntent().getStringExtra("userID"));
        confirmTermActivity=this;
        doctor=new Doctor();
        workingTime=new WorkingTime();
        timesAM=new ArrayList<Time>();
        timesAM.add(new Time(8,00,00));
        timesAM.add(new Time(8,15,00));
        timesAM.add(new Time(8,30,00));
        timesAM.add(new Time(8,45,00));
        timesAM.add(new Time(9,00,00));
        timesAM.add(new Time(9,15,00));
        timesAM.add(new Time(9,30,00));
        timesAM.add(new Time(9,45,00));

        timesAM.add(new Time(10,00,00));
        timesAM.add(new Time(10,15,00));
        timesAM.add(new Time(10,30,00));
        timesAM.add(new Time(10,45,00));
        timesAM.add(new Time(11,00,00));
        timesAM.add(new Time(11,15,00));
        timesAM.add(new Time(11,30,00));
        timesAM.add(new Time(11,45,00));

        timesAM.add(new Time(12,00,00));
        timesAM.add(new Time(12,15,00));
        timesAM.add(new Time(12,30,00));
        timesAM.add(new Time(12,45,00));
        timesAM.add(new Time(13,00,00));
        timesAM.add(new Time(13,15,00));
        timesAM.add(new Time(13,30,00));
        timesAM.add(new Time(13,45,00));

        timesPM =new ArrayList<Time>();

        timesPM.add(new Time(14,00,00));
        timesPM.add(new Time(14,15,00));
        timesPM.add(new Time(14,30,00));
        timesPM.add(new Time(14,45,00));
        timesPM.add(new Time(15,00,00));
        timesPM.add(new Time(15,15,00));
        timesPM.add(new Time(15,30,00));
        timesPM.add(new Time(15,45,00));

        timesPM.add(new Time(16,00,00));
        timesPM.add(new Time(16,15,00));
        timesPM.add(new Time(16,30,00));
        timesPM.add(new Time(16,45,00));
        timesPM.add(new Time(17,00,00));
        timesPM.add(new Time(17,15,00));
        timesPM.add(new Time(17,30,00));
        timesPM.add(new Time(17,45,00));

        timesPM.add(new Time(18,00,00));
        timesPM.add(new Time(18,15,00));
        timesPM.add(new Time(18,30,00));
        timesPM.add(new Time(18,45,00));
        timesPM.add(new Time(19,00,00));
        timesPM.add(new Time(19,15,00));
        timesPM.add(new Time(19,30,00));
        timesPM.add(new Time(19,45,00));
        SelectDoctor();

        SelectTermForDoctor();


    }
    public void PrintListForReervation()
    {
        if(!jutro)
        {
        for(int i=0; i<_agreedTerm.size(); i++)
        {
            for(int j =0 ; j<timesPM.size(); j++)
            {
                if(_agreedTerm.get(i).getVrijeme().equalsIgnoreCase(timesPM.get(j).toString()))
                {
                    timesPM.remove(j);
                }
            }

        }
            itemname=new String[timesPM.size()];
            imgid=new Integer[timesPM.size()];
            for(int j =0; j<timesPM.size(); j++)
            {
                itemname[j]=timesPM.get(j).toString();
                imgid[j]=R.drawable.ic_person;
            }
        }
        else {
            for(int i=0; i<_agreedTerm.size(); i++)
            {
                for(int j =0 ; j<timesAM.size(); j++)
                {
                    if(_agreedTerm.get(i).getVrijeme().equalsIgnoreCase(timesAM.get(j).toString()))
                    {
                        timesAM.remove(j);
                    }
                }
            }
            itemname=new String[timesAM.size()];
            imgid=new Integer[timesAM.size()];
            for(int j =0; j<timesAM.size(); j++)
            {
                itemname[j]=timesAM.get(j).toString();
                imgid[j]=R.drawable.ic_person;
            }
        }
        adapter=new DoctorList(confirmTermActivity, itemname, imgid);
        AddListeners();
    }
    public void SelectDoctor()
    {

        RequestQueue queue = Volley.newRequestQueue(this);
        String url = "http://"+IPAddress+":3000/SelectRadnoVrijemeForPatient";
        JsonArrayRequest jsonObjReq = new JsonArrayRequest(Request.Method.GET,
                url, null,
                new Response.Listener<JSONArray>() {
                    @Override
                    public void onResponse(JSONArray response) {

                            Gson gson = new Gson();
                            try {
                                workingTime=new WorkingTime();
                                JSONObject objectjson=response.getJSONObject(0);
                                WorkingTime wt = new Gson().fromJson(objectjson.toString(), WorkingTime.class);
                                workingTime=wt;
                            }
                            catch (JSONException ex)
                            {
                            }
                            finally {
                               // prepareListData();
                                boolean parni=false;
                                boolean neparni=false;
                                if(workingTime.getParni_Neparni().toString().equalsIgnoreCase("Parni") && workingTime.getJutro_Posljepodne().equalsIgnoreCase("Jutro"))
                                { parni=true; neparni=false;}
                                if(workingTime.getParni_Neparni().toString().equalsIgnoreCase("Neparni") && workingTime.getJutro_Posljepodne().equalsIgnoreCase("Jutro"))
                                {parni=false; neparni=true;}
                                if(workingTime.getParni_Neparni().toString().equalsIgnoreCase("Parni") && workingTime.getJutro_Posljepodne().equalsIgnoreCase("Posljepodne"))
                                {parni=false; neparni=true;}
                                if(workingTime.getParni_Neparni().toString().equalsIgnoreCase("Neparni") && workingTime.getJutro_Posljepodne().equalsIgnoreCase("Posljepodne"))
                                { parni=true; neparni=false;}
                                if(pDay%2==0)
                                {
                                    if(parni)
                                    {
                                        jutro=true;
//                                        itemname=new String[timesAM.size()];
//                                        imgid=new Integer[timesAM.size()];
//                                        for(int j =0; j<timesAM.size(); j++)
//                                        {
//                                            itemname[j]=timesAM.get(j).toString();
//                                            imgid[j]=R.drawable.ic_person;
//                                        }
                                    }
                                    else
                                    {
                                        jutro=false;
//                                        itemname=new String[timesPM.size()];
//                                        imgid=new Integer[timesPM.size()];
//                                        for(int j =0; j<timesPM.size(); j++)
//                                        {
//                                            itemname[j]=timesPM.get(j).toString();
//                                            imgid[j]=R.drawable.ic_person;
//                                        }
                                    }
                                }
                                else
                                {
                                    if(neparni)
                                    {
                                        jutro=true;
//                                        itemname=new String[timesAM.size()];
//                                        imgid=new Integer[timesAM.size()];
//                                        for(int j =0; j<timesAM.size(); j++)
//                                        {
//                                            itemname[j]=timesAM.get(j).toString();
//                                            imgid[j]=R.drawable.ic_person;
//                                        }
                                    }
                                    else
                                    {
                                        jutro=false;
//                                        itemname=new String[timesPM.size()];
//                                        imgid=new Integer[timesPM.size()];
//                                        for(int j =0; j<timesPM.size(); j++)
//                                        {
//                                            itemname[j]=timesPM.get(j).toString();
//                                            imgid[j]=R.drawable.ic_person;
//                                        }
                                    }
                                }
//                                adapter=new DoctorList(confirmTermActivity, itemname, imgid);
//                                AddListeners();
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
            headers.put("patient", ""+userID+"");

            return headers;
        }
        };
        queue.add(jsonObjReq);
    }
    public void SelectTermForDoctor()
    {
        RequestQueue queue = Volley.newRequestQueue(this);
        String url = "http://"+IPAddress+":3000/SelectZakazaniTerminForDate";
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
                                AgreedTerm agreedT= new Gson().fromJson(objectjson.toString(), AgreedTerm.class);
                                agreedTerm=agreedT;
                                _agreedTerm.add(agreedT);
                            }
                            catch (JSONException ex)
                            {

                            }
                            finally {
                                PrintListForReervation();
                            }
                        }
                        if(response.length()<=0)
                        {
                            if(jutro)
                            {
                                itemname=new String[timesAM.size()];
                                imgid=new Integer[timesAM.size()];
                                for(int j =0; j<timesAM.size(); j++)
                                {
                                    itemname[j]=timesAM.get(j).toString();
                                    imgid[j]=R.drawable.ic_person;
                                }
                            }
                            else
                            {
                                itemname=new String[timesPM.size()];
                                imgid=new Integer[timesPM.size()];
                                for(int j =0; j<timesPM.size(); j++)
                                {
                                    itemname[j]=timesPM.get(j).toString();
                                    imgid[j]=R.drawable.ic_person;
                                }
                            }
                                    adapter=new DoctorList(confirmTermActivity, itemname, imgid);
                                    AddListeners();
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
            headers.put("doctor", ""+30+"");
            headers.put("datum", ""+pYear+"-"+pMonth+"-"+pDay);
            return headers;
        }
        };
        queue.add(jsonObjReq);
    }
    public void AddListeners(){
        list=(ListView)findViewById(R.id.list);
        list.setAdapter(adapter);

        list.setOnItemClickListener(new AdapterView.OnItemClickListener() {

            @Override
            public void onItemClick(AdapterView<?> parent, View view,
                                    int position, long id) {

                //Doctor dr=(Doctor)_doctor_list.get(+position);
                //String Slecteditem= itemname[+position];
                //Toast.makeText(getApplicationContext(), Slecteditem, Toast.LENGTH_SHORT).show();
                //Intent i = new Intent( DoctorListActivity.this, DoctorViewActivity.class);
                //i.putExtra("Doctor", dr.getID_Doktor());
                //i.putExtra("IPAddress",IPAddress);
                //startActivity(i);
            }
        });
    }
}