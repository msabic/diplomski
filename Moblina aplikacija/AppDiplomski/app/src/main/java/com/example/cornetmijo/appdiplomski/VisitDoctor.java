package com.example.cornetmijo.appdiplomski;

import java.util.Date;

public class VisitDoctor {
    private int ID_Posjet;
    private String Razlog;
    private Date Datum;
    private String Opis;
    private int Pacijent_ID_Pacijent;
    private int Pacijent_Doktor_ID_Doktor;

    public int getID_Posjet() {
        return ID_Posjet;
    }

    public void setID_Posjet(int ID_Posjet) {
        this.ID_Posjet = ID_Posjet;
    }

    public String getRazlog() {
        return Razlog;
    }

    public void setRazlog(String razlog) {
        Razlog = razlog;
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

    public VisitDoctor(int ID_Posjet, String razlog, Date datum, String opis, int pacijent_ID_Pacijent, int pacijent_Doktor_ID_Doktor) {
        this.ID_Posjet = ID_Posjet;
        Razlog = razlog;
        Datum = datum;
        Opis = opis;
        Pacijent_ID_Pacijent = pacijent_ID_Pacijent;
        Pacijent_Doktor_ID_Doktor = pacijent_Doktor_ID_Doktor;
    }
    public VisitDoctor() {
        this.ID_Posjet = 0;
        Razlog = "";
        Datum = new Date(2018,12,15);
        Opis = "";
        Pacijent_ID_Pacijent =0;
        Pacijent_Doktor_ID_Doktor = 0;
    }
}
