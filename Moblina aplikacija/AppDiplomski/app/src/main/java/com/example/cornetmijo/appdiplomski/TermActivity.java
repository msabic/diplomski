package com.example.cornetmijo.appdiplomski;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.Spinner;

public class TermActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_term);
        Button btnChooseTime= (Button) findViewById(R.id.btnChooseTime);

        btnChooseTime.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(TermActivity.this, ConfirmTermActivity.class);
                // i.putExtra("userID",""+userID+"");
                // i.putExtra("IPAddress",IPAddress);
                startActivity(i);
            }
        });

    }
}
