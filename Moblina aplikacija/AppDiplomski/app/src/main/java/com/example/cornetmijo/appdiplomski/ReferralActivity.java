package com.example.cornetmijo.appdiplomski;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ExpandableListView;

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

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class ReferralActivity extends AppCompatActivity {
    ExpandableListAdapter listAdapter;
    ExpandableListView expListView;
    List<String> listDataHeader;
    HashMap<String, List<String>> listDataChild;
    public static Referral referral=new Referral();
    public static ArrayList<Referral> _referral_list=new ArrayList<>();
    public String IPAddress;
    public int userID;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_referral);
        userID= Integer.parseInt(getIntent().getStringExtra("userID"));
        IPAddress=getIntent().getStringExtra("IPAddress");
        referral=new Referral();
        _referral_list=new ArrayList<Referral>();

        SelectReferral();
    }
    public void SelectReferral()
    {

        RequestQueue queue = Volley.newRequestQueue(this);
        String url = "http://"+IPAddress+":3000/SelectUputnicaForPatient";
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
                                Referral ref = new Gson().fromJson(objectjson.toString(), Referral.class);
                                referral=ref;
                                _referral_list.add(ref);
                            }
                            catch (JSONException ex)
                            {

                            }
                            finally {
                                prepareListData();
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
            headers.put("patient", ""+userID+"");

            return headers;
        }
        };
        queue.add(jsonObjReq);
    }
    private void prepareListData() {
        listDataHeader = new ArrayList<String>();
        listDataChild = new HashMap<String, List<String>>();
        for(int i=0; i<_referral_list.size(); i++)
        {

            listDataHeader.add(_referral_list.get(i).getOpis().toString());
            List<String> diag_description = new ArrayList<String>();
            diag_description.add(_referral_list.get(i).getOpis().toString());
            listDataChild.put(listDataHeader.get(i),diag_description);
        }
        expListView = (ExpandableListView)findViewById(R.id.lvExpReferral);

        // preparing list data


        listAdapter = new ExpandableListAdapter(this, listDataHeader, listDataChild);

        // setting list adapter
        expListView.setAdapter(listAdapter);
    }

}
