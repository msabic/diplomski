package com.example.cornetmijo.appdiplomski;

import android.content.Intent;
import android.provider.ContactsContract;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.ImageButton;
import android.widget.Spinner;

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
import java.util.ArrayList;
import java.util.Date;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class TermActivity extends AppCompatActivity {
    int pYear;
    int pDay;
    int pMonth;
    public String IPAddress;
    public int userID;
    public   DatePicker datePicker;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_term);
        IPAddress=getIntent().getStringExtra("IPAddress");
        userID= Integer.parseInt(getIntent().getStringExtra("userID"));
        Button btnChooseTime= (Button) findViewById(R.id.btnChooseTime);
        datePicker=(DatePicker)findViewById(R.id.simpleDatePicker);
        btnChooseTime.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                pDay=datePicker.getDayOfMonth();
                pMonth=datePicker.getMonth();
                pYear=datePicker.getYear();
                Date date=new Date(pYear,pMonth,pDay);
                Intent i = new Intent(TermActivity.this, ConfirmTermActivity.class);
                i.putExtra("date",""+pYear+","+pMonth+","+pDay);
                i.putExtra("userID",""+userID+"");
                i.putExtra("IPAddress",IPAddress);
                startActivity(i);



            }
        });

    }

}
