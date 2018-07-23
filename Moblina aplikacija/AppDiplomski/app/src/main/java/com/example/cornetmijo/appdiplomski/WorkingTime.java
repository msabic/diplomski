package com.example.cornetmijo.appdiplomski;

public class WorkingTime {
    private int ID_Radno_vrijeme;
    private String Parni_Neparni;
    private String Jutro_Posljepodne;

    public int getID_Radno_vrijeme() {
        return ID_Radno_vrijeme;
    }

    public void setID_Radno_vrijeme(int ID_Radno_vrijeme) {
        this.ID_Radno_vrijeme = ID_Radno_vrijeme;
    }

    public String getParni_Neparni() {
        return Parni_Neparni;
    }

    public void setParni_Neparni(String parni_Neparni) {
        Parni_Neparni = parni_Neparni;
    }

    public String getJutro_Posljepodne() {
        return Jutro_Posljepodne;
    }

    public void setJutro_Posljepodne(String jutro_Posljepodne) {
        Jutro_Posljepodne = jutro_Posljepodne;
    }

    public WorkingTime(int ID_Radno_vrijeme, String parni_Neparni, String jutro_Posljepodne) {
        this.ID_Radno_vrijeme = ID_Radno_vrijeme;
        Parni_Neparni = parni_Neparni;
        Jutro_Posljepodne = jutro_Posljepodne;
    }

    public WorkingTime() {
        this.ID_Radno_vrijeme = 0;
        Parni_Neparni = "";
        Jutro_Posljepodne = "";
    }
}
