package com.example.cornetmijo.appdiplomski;

public class Referral {
    private int ID_Uputnica;
    private String Naziv;
    private String Opis;
    private int Pacijent_ID_Pacijent;
    private int Pacijent_Doktor_ID_Doktor;

    public int getID_Uputnica() {
        return ID_Uputnica;
    }

    public void setID_Uputnica(int ID_Uputnica) {
        this.ID_Uputnica = ID_Uputnica;
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

    public Referral(int ID_Uputnica, String naziv, String opis, int pacijent_ID_Pacijent, int pacijent_Doktor_ID_Doktor) {
        this.ID_Uputnica = ID_Uputnica;
        Naziv = naziv;
        Opis = opis;
        Pacijent_ID_Pacijent = pacijent_ID_Pacijent;
        Pacijent_Doktor_ID_Doktor = pacijent_Doktor_ID_Doktor;
    }
    public Referral() {
        this.ID_Uputnica = 0;
        Naziv = "";
        Opis = "";
        Pacijent_ID_Pacijent = 0;
        Pacijent_Doktor_ID_Doktor = 0;
    }
}
