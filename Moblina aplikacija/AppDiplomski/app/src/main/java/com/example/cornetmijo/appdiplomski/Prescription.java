package com.example.cornetmijo.appdiplomski;

import java.security.Timestamp;
import java.sql.Time;
import java.text.DateFormat;
import java.util.Date;

public class Prescription {
    private int ID_Recept;
    private Date Datum;
    private String Opis;
    private int Pacijent_ID_Pacijent;
    private int Pacijent_Doktor_ID_Doktor;


    public int getID_Recept() {
        return ID_Recept;
    }

    public void setID_Recept(int ID_Recept) {
        this.ID_Recept = ID_Recept;
    }

    public Date getDatum() {
        return Datum;
    }

    public void setDatum(Date datum) {
        Datum = datum;
    }

    public String getOpis() {
        return Opis;
    }

    public void setOpis(String opis) {
        Opis = opis;
    }

    public int getPacijent_ID_Pacijent() {
        return Pacijent_ID_Pacijent;
    }

    public void setPacijent_ID_Pacijent(int pacijent_ID_Pacijent) {
        Pacijent_ID_Pacijent = pacijent_ID_Pacijent;
    }

    public int getPacijent_Doktor_ID_Doktor() {
        return Pacijent_Doktor_ID_Doktor;
    }

    public void setPacijent_Doktor_ID_Doktor(int pacijent_Doktor_ID_Doktor) {
        Pacijent_Doktor_ID_Doktor = pacijent_Doktor_ID_Doktor;
    }

    public Prescription(int ID_Recept, Date datum, String opis, int pacijent_ID_Pacijent, int pacijent_Doktor_ID_Doktor) {
        this.ID_Recept = ID_Recept;
        Datum = datum;
        Opis = opis;
        Pacijent_ID_Pacijent = pacijent_ID_Pacijent;
        Pacijent_Doktor_ID_Doktor = pacijent_Doktor_ID_Doktor;
    }
    public Prescription() {
        this.ID_Recept = 0;
        Datum = new Date(2018,12,15);
        Opis = "";
        Pacijent_ID_Pacijent = 0;
        Pacijent_Doktor_ID_Doktor = 0;
    }
}
