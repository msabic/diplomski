package com.example.cornetmijo.appdiplomski;

/**
 * Created by Mijo Šabić on 5.7.2018..
 */

public class Diagnose {
    private int ID_Dijagnoza;
    private String Naziv;
    private String Opis;
    private int Pacijent_ID_Pacijent;
    private int Pacijent_Doktor_ID_Doktor;

    public Diagnose(int ID_Dijagnoza, String naziv, String opis, int pacijent_ID_Pacijent, int pacijent_Doktor_ID_Doktor) {
        this.ID_Dijagnoza = ID_Dijagnoza;
        Naziv = naziv;
        Opis = opis;
        Pacijent_ID_Pacijent = pacijent_ID_Pacijent;
        Pacijent_Doktor_ID_Doktor = pacijent_Doktor_ID_Doktor;
    }
    public Diagnose() {
        this.ID_Dijagnoza = 0;
        Naziv = "";
        Opis = "";
        Pacijent_ID_Pacijent = 0;
        Pacijent_Doktor_ID_Doktor = 0;
    }
    public int getID_Dijagnoza() {
        return ID_Dijagnoza;
    }

    public void setID_Dijagnoza(int ID_Dijagnoza) {
        this.ID_Dijagnoza = ID_Dijagnoza;
    }

    public String getNaziv() {
        return Naziv;
    }

    public void setNaziv(String naziv) {
        Naziv = naziv;
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
}
