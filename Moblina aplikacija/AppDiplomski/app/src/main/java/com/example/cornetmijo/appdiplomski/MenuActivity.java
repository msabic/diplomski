package com.example.cornetmijo.appdiplomski;

import android.app.FragmentManager;
import android.app.FragmentTransaction;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;

public class MenuActivity extends AppCompatActivity {
    public int userID;
    public String IPAddress;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        userID= Integer.parseInt(getIntent().getStringExtra("userID"));
        IPAddress=getIntent().getStringExtra("IPAddress");
        setContentView(R.layout.activity_menu);

        ImageButton btnDiagnoses = (ImageButton) findViewById(R.id.btnDiagnose);

        btnDiagnoses.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(MenuActivity.this, ListActivity.class);
                i.putExtra("userID",""+userID+"");
                i.putExtra("IPAddress",IPAddress);
                startActivity(i);
            }
        });
        ImageButton btnDoctor = (ImageButton) findViewById(R.id.btnDoctor);

        btnDoctor.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(MenuActivity.this, DoctorListActivity.class);
                i.putExtra("userID",""+userID+"");
                i.putExtra("IPAddress",IPAddress);
                startActivity(i);
            }
        });
        ImageButton btnPrescription= (ImageButton) findViewById(R.id.btnPrescription);

        btnPrescription.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(MenuActivity.this, PrescriptionsActivity.class);
                i.putExtra("userID",""+userID+"");
                i.putExtra("IPAddress",IPAddress);
                startActivity(i);
            }
        });
        ImageButton btnReferral= (ImageButton) findViewById(R.id.btnReferral);

        btnReferral.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(MenuActivity.this, ReferralActivity.class);
                i.putExtra("userID",""+userID+"");
                i.putExtra("IPAddress",IPAddress);
                startActivity(i);
            }
        });
        ImageButton btnVisitDoctor= (ImageButton) findViewById(R.id.btnVisitDoctor);

        btnVisitDoctor.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(MenuActivity.this, VisitDoctorActivity.class);
                i.putExtra("userID",""+userID+"");
                i.putExtra("IPAddress",IPAddress);
                startActivity(i);
            }
        });
        ImageButton btnTerm= (ImageButton) findViewById(R.id.btnTerm);

        btnTerm.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(MenuActivity.this, TermActivity.class);
               i.putExtra("userID",""+userID+"");
               i.putExtra("IPAddress",IPAddress);
                startActivity(i);
            }
        });
    }
}
