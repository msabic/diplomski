package com.example.cornetmijo.appdiplomski;

import java.sql.Time;
import java.util.Date;

public class AgreedTerm {
    private int ID_Zakazani_termin;
    private Date Datum;
    private Time Vrijeme;
    private int Pacijent_ID_Pacijent;
    private int Pacijent_Doktor_ID_Doktor;

    public int getID_Zakazani_termin() {
        return ID_Zakazani_termin;
    }

    public void setID_Zakazani_termin(int ID_Zakazani_termin) {
        this.ID_Zakazani_termin = ID_Zakazani_termin;
    }

    public Date getDatum() {
        return Datum;
    }

    public void setDatum(Date datum) {
        Datum = datum;
    }

    public Date getVrijeme() {
        return Vrijeme;
    }

    public void setVrijeme(Time vrijeme) {
        Vrijeme = vrijeme;
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

    public AgreedTerm(int ID_Zakazani_termin, Date datum, Time vrijeme, int pacijent_ID_Pacijent, int pacijent_Doktor_ID_Doktor) {
        this.ID_Zakazani_termin = ID_Zakazani_termin;
        Datum = datum;
        Vrijeme = vrijeme;
        Pacijent_ID_Pacijent = pacijent_ID_Pacijent;
        Pacijent_Doktor_ID_Doktor = pacijent_Doktor_ID_Doktor;
    }
    public AgreedTerm() {
        this.ID_Zakazani_termin =0;
        Datum = new Date(2018,01,01);
        Vrijeme = new Time(10,10,10);
        Pacijent_ID_Pacijent = 0;
        Pacijent_Doktor_ID_Doktor = 0;
    }
}
