package com.example.cornetmijo.appdiplomski;

/**
 * Created by Mijo Šabić on 10.7.2018..
 */

public class Doctor {
    public int ID_Doktor;
    public String Ime;
    public String Prezime;
    public String Email;
    public String Lozinka;
    public String Kontakt;
    public int Radno_vrijeme_ID_Radno_vrijeme;

    public Doctor(int ID_Doktor, String ime, String prezime, String email, String lozinka, String kontakt, int radno_vrijeme_ID_Radno_vrijeme) {
        this.ID_Doktor = ID_Doktor;
        Ime = ime;
        Prezime = prezime;
        Email = email;
        Lozinka = lozinka;
        Kontakt = kontakt;
        Radno_vrijeme_ID_Radno_vrijeme = radno_vrijeme_ID_Radno_vrijeme;
    }
    public Doctor() {
        this.ID_Doktor = 0;
        Ime = "";
        Prezime = "";
        Email = "";
        Lozinka = "";
        Kontakt = "";
        Radno_vrijeme_ID_Radno_vrijeme = 0;
    }

    public int getID_Doktor() {
        return ID_Doktor;
    }

    public void setID_Doktor(int ID_Doktor) {
        this.ID_Doktor = ID_Doktor;
    }

    public String getIme() {
        return Ime;
    }

    public void setIme(String ime) {
        Ime = ime;
    }

    public String getPrezime() {
        return Prezime;
    }

    public void setPrezime(String prezime) {
        Prezime = prezime;
    }

    public String getEmail() {
        return Email;
    }

    public void setEmail(String email) {
        Email = email;
    }

    public String getLozinka() {
        return Lozinka;
    }

    public void setLozinka(String lozinka) {
        Lozinka = lozinka;
    }

    public String getKontakt() {
        return Kontakt;
    }

    public void setKontakt(String kontakt) {
        Kontakt = kontakt;
    }

    public int getRadno_vrijeme_ID_Radno_vrijeme() {
        return Radno_vrijeme_ID_Radno_vrijeme;
    }

    public void setRadno_vrijeme_ID_Radno_vrijeme(int radno_vrijeme_ID_Radno_vrijeme) {
        Radno_vrijeme_ID_Radno_vrijeme = radno_vrijeme_ID_Radno_vrijeme;
    }
}
