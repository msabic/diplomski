package com.example.cornetmijo.appdiplomski;

/**
 * Created by Mijo Šabić on 29.6.2018..
 */

public class Patient {
    private int ID_Pacijent;
    private String Ime;
    private String Prezime;
    private String Email;
    private String Lozinka;
    private String Kontakt;
    private int Aktivan;
    private int Doktor_ID_Doktor;

    public Patient(int id_pacijent, String ime, String prezime, String email, String lozinka, String kontakt, int aktivan, int doktor_id_doktor )
    {
        this.ID_Pacijent=id_pacijent;
        this.Ime=ime;
        this.Prezime=prezime;
        this.Email=email;
        this.Lozinka=lozinka;
        this.Kontakt=kontakt;
        this.Aktivan=aktivan;
        this.Doktor_ID_Doktor=doktor_id_doktor;
    }
    Patient()
    {
        this.ID_Pacijent=0;
        this.Ime="";
        this.Prezime="";
        this.Email="";
        this.Lozinka="";
        this.Kontakt="";
        this.Aktivan=0;
        this.Doktor_ID_Doktor=0;
    }
    public int getID_Pacijent(){return ID_Pacijent;}
    public void setID_Pacijent(int id_pacijent){this.ID_Pacijent=id_pacijent;}
    public String getIme(){return Ime;}
    public void setIme(String ime){this.Ime=ime;}
    public String getPrezime(){return Prezime;}
    public void setPrezime(String prezime){this.Prezime=prezime;}
    public String getEmail(){return Email;}
    public void setEmail(String email){this.Email=email;}
    public String getLozinka(){return Lozinka;}
    public void setLozinka(String lozinka){this.Lozinka=lozinka;}
    public String getKontakt(){return Kontakt;}
    public void setKontakt(String kontakt){this.Kontakt=kontakt;}
    public int getAktivan(){return Aktivan;}
    public void setAktivan(int aktivan){this.Aktivan=aktivan;}
    public int getDoktor_ID_Doktor(){return Doktor_ID_Doktor;}
    public void setDoktor_ID_Doktor(int doktor_id_doktor){this.Doktor_ID_Doktor=doktor_id_doktor;}
}
