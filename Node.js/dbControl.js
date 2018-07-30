const mysql = require('mysql');
const md5 = require('md5');
const generator = require('generate-password');
const bodyParser = require('body-parser')
const http = require('http');
const base64 = require('base-64');
var connection = mysql.createConnection({
  host     : 'localhost',
  user     : 'root',
  password : '',
  database :'ordinacija',
  port : '3309'
});


connection.connect();
////////////////////////////////___________DOKTOR____________//////////////////////////////////////////////////////
let SelectDoktor = function (email, password) {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM doktor where Email="+mysql.escape(email)+" and Lozinka="+mysql.escape(md5(password))+";", function (err, result, fiels) {

            resolve(result);
        })
    });
};
let SelectDoktorId = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM doktor where ID_Doktor="+mysql.escape(id)+";", function (err, result, fiels) {

            resolve(result);
        })
    });
};
let SelectDoktorAll = function () {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM doktor;", function (err, result, fiels) {
            resolve(result);
        })
    });
};

let DeleteDoktor = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("DELETE FROM `ordinacija`.`doktor` WHERE ID_Doktor="+mysql.escape(id)+";", function (err, result, fiels) {

            resolve(result);
        })
    });
};
let InsertDoktor = function (name,surname,email,password,contact,workinghours) {
 
    return new Promise((resolve, reject) => {
        connection.query("INSERT INTO `ordinacija`.`doktor`(`Ime`,`Prezime`,`Email`,`Lozinka`,`Kontakt`,`Radno_vrijeme_ID_Radno_vrijeme`) VALUES ("+mysql.escape(name)+", "+mysql.escape(surname)+", "+mysql.escape(email)+", "+mysql.escape(password)+", "+mysql.escape(contact)+","+mysql.escape(workinghours)+");", function (err, result, fiels) {
         resolve(result);
        })
    });
};

let UpdateDoktor = function (id,name,surname,email,contact,workinghours) {
 
    return new Promise((resolve, reject) => {
        connection.query("UPDATE `ordinacija`.`doktor` SET `Ime` = "+mysql.escape(name)+",`Prezime` = "+mysql.escape(surname)+",`Email` = "+mysql.escape(email)+", `Kontakt` ="+mysql.escape(contact)+",`Radno_vrijeme_ID_Radno_vrijeme` = "+mysql.escape(workinghours)+" WHERE `ID_Doktor` = "+mysql.escape(id)+";", function (err, result, fiels) {
         resolve(result);
        })
    });
};
////////////////////////////////___________DOKTOR____________//////////////////////////////////////////////////////


////////////////////////////////___________PACIJENT____________//////////////////////////////////////////////////////
let SelectPacijent = function (email, password) {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM pacijent where Email="+mysql.escape(email)+" and Lozinka="+mysql.escape(md5(password))+";", function (err, result, fiels) {

            resolve(result);
        })
    });
};
let SelectPacijentID = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM pacijent where ID_Pacijent="+mysql.escape(id)+";", function (err, result, fiels) {

            resolve(result);
        })
    });
};
let SelectPacijentAll = function () {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM pacijent;", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let DeletePacijent = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("DELETE FROM `ordinacija`.`pacijent` WHERE ID_Pacijent="+mysql.escape(id)+";", function (err, result, fiels) {

            resolve(result);
        })
    });
};
let InsertPacijent = function (name,surname,email,password,contact,doctor) {
 console.log("INSERT INTO `ordinacija`.`pacijent`(`Ime`,`Prezime`,`Email`,`Lozinka`,`Kontakt`,`Aktivan`,`Doktor_ID_Doktor`) VALUES ("+mysql.escape(name)+", "+mysql.escape(surname)+", "+mysql.escape(email)+", "+mysql.escape(password)+", "+mysql.escape(contact)+", '0',"+mysql.escape(doktor)+");")
    return new Promise((resolve, reject) => {
        connection.query("INSERT INTO `ordinacija`.`pacijent`(`Ime`,`Prezime`,`Email`,`Lozinka`,`Kontakt`,`Aktivan`,`Doktor_ID_Doktor`) VALUES ("+mysql.escape(name)+", "+mysql.escape(surname)+", "+mysql.escape(email)+", "+mysql.escape(password)+", "+mysql.escape(contact)+", '0',"+mysql.escape(doctor)+");", function (err, result, fiels) {
         resolve(result);
        })
    });
};

let UpdatePacijent = function (id,name,surname,email,contact,doctor,active) {
  console.log("INSERT INTO `ordinacija`.`pacijent`(`Ime`,`Prezime`,`Email`,`Lozinka`,`Kontakt`,`Aktivan`,`Doktor_ID_Doktor`) VALUES ("+mysql.escape(name)+", "+mysql.escape(surname)+", "+mysql.escape(email)+", "+mysql.escape(contact)+", '0',"+mysql.escape(doktor)+");")
       return new Promise((resolve, reject) => {
           connection.query("UPDATE  `ordinacija`.`pacijent` SET `Ime` = "+mysql.escape(name)+",`Prezime` = "+mysql.escape(surname)+",`Email` = "+mysql.escape(email)+", `Kontakt` = "+mysql.escape(contact)+",`Aktivan` = "+mysql.escape(active)+",`Doktor_ID_Doktor` = "+mysql.escape(doctor)+" WHERE `ID_Pacijent` = "+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
           })
       });
   };
////////////////////////////////___________PACIJENT____________//////////////////////////////////////////////////////

////////////////////////////////___________DIJAGNOZA____________//////////////////////////////////////////////////////
let SelectDijagnozaAll = function () {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.dijagnoza;", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let SelectDijagnoza= function (id) {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.dijagnoza where ID_Dijagnoza="+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let SelectDijagnozaForPatient = function (patientid) {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.dijagnoza where Pacijent_ID_Pacijent="+mysql.escape(patientid)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};

let DeleteDijagnoza = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("DELETE FROM ordinacija.dijagnoza where ID_Dijagnoza="+mysql.escape(id)+";", function (err, result, fiels) {

            resolve(result);
        })
    });
};
let InsertDijagnoza = function (name,description,patient,doctor) {
 console.log("INSERT INTO `ordinacija`.`dijagnoza`(`Naziv`,`Opis`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`) VALUES ("+mysql.escape(name)+", "+mysql.escape(description)+", "+mysql.escape(patient)+", "+mysql.escape(doctor)+");");
    return new Promise((resolve, reject) => {
        connection.query("INSERT INTO `ordinacija`.`dijagnoza`(`Naziv`,`Opis`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`) VALUES ("+mysql.escape(name)+", "+mysql.escape(description)+", "+mysql.escape(patient)+", "+mysql.escape(doctor)+");", function (err, result, fiels) {
         resolve(result);
        })
    });
};
let UpdateDijagnoza = function (id,name,description,patient,doctor) {
    console.log("UPDATE `ordinacija`.`dijagnoza` SET `Naziv` = "+mysql.escape(name)+", `Opis` = "+mysql.escape(description)+", `Pacijent_ID_Pacijent` = "+mysql.escape(patient)+", `Pacijent_Doktor_ID_Doktor` = "+mysql.escape(doctor)+" WHERE `ID_Dijagnoza` = "+mysql.escape(id)+";");
       return new Promise((resolve, reject) => {
           connection.query("UPDATE `ordinacija`.`dijagnoza` SET `Naziv` = "+mysql.escape(name)+", `Opis` = "+mysql.escape(description)+", `Pacijent_ID_Pacijent` = "+mysql.escape(patient)+", `Pacijent_Doktor_ID_Doktor` = "+mysql.escape(doctor)+" WHERE `ID_Dijagnoza` = "+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
           })
       });
   };
////////////////////////////////___________DIJAGNOZA____________//////////////////////////////////////////////////////


////////////////////////////////___________NERADNI_DANI____________//////////////////////////////////////////////////////
let SelectNeradniDaniAll = function () {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.neradni_dan;", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let SelectNeradniDani = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.neradni_dan where Id_Neradni_dani="+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let DeleteNeradniDani = function (id) {
    console.log("delete_neradni_Dan")
    return new Promise((resolve, reject) => {
        connection.query("DELETE FROM `ordinacija`.`neradni_dan` WHERE ID_Neradni_dan="+mysql.escape(id)+";", function (err, result, fiels) {

            resolve(result);
        })
    });
};
let InsertNeradniDan = function (name,date_time) {
    console.log("INSERT INTO `ordinacija`.`neradni_dan`(`Naziv`,`Datum`) VALUES ("+mysql.escape(name)+", "+mysql.escape(date_time)+");");
       return new Promise((resolve, reject) => {
           connection.query("INSERT INTO `ordinacija`.`neradni_dan`(`Naziv`,`Datum`) VALUES ("+mysql.escape(name)+", "+mysql.escape(date_time)+");", function (err, result, fiels) {
            resolve(result);
           })
       });
   };
   let UpdateNeradniDan = function (id,name,date_time) {
    console.log("UPDATE `ordinacija`.`neradni_dan` SET `Naziv` = "+mysql.escape(name)+",`Datum` ="+mysql.escape(date_time)+" WHERE `ID_Neradni_dan` = "+mysql.escape(id)+";");
       return new Promise((resolve, reject) => {
           connection.query("UPDATE `ordinacija`.`neradni_dan` SET `Naziv` = "+mysql.escape(name)+",`Datum` ="+mysql.escape(date_time)+" WHERE `ID_Neradni_dan` = "+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
           })
       });
   };
////////////////////////////////___________NERADNI_DANI____________//////////////////////////////////////////////////////


////////////////////////////////__________PACIJENT_DODATNO_____________//////////////////////////////////////////////////////
let SelectPacijentDodatnoAll = function () {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.pacijent_dodatno;", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let SelectPacijentDodatno = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.pacijent_dodatno where ID_Pacijent_dodatno="+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let DeletePacijentDodatno = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("DELETE FROM ordinacija.pacijent_dodatno where ID_Pacijent_dodatno="+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let InsertPacijentDodatno = function (father_name,mother_name,address,phone,mob,jmbg,relationship_status,smoker,patientid) {
    console.log("INSERT INTO `ordinacija`.`pacijent_dodatno` (`Ime_oca`,`Ime_majke`,`Adresa`,`Telefon`,`Mobitel`,`JMBG`,`Bracno_stanje`,`Pusac`,`Pacijent_ID_Pacijent`) VALUES ("+
    mysql.escape(father_name)+", "+mysql.escape(mother_name)+","+ mysql.escape(address)+","+ mysql.escape(phone)+","+ mysql.escape(mob)+","+ mysql.escape(jmbg)+","+ mysql.escape(relationship_status)+","+mysql.escape(smoker)+","+mysql.escape(patientid)+");");
       return new Promise((resolve, reject) => {
           connection.query("INSERT INTO `ordinacija`.`pacijent_dodatno` (`Ime_oca`,`Ime_majke`,`Adresa`,`Telefon`,`Mobitel`,`JMBG`,`Bracno_stanje`,`Pusac`,`Pacijent_ID_Pacijent`) VALUES ("+
           mysql.escape(father_name)+", "+mysql.escape(mother_name)+","+ mysql.escape(address)+","+ mysql.escape(phone)+","+ mysql.escape(mob)+","+ mysql.escape(jmbg)+","+ mysql.escape(relationship_status)+","+mysql.escape(smoker)+","+mysql.escape(patientid)+");", function (err, result, fiels) {
            resolve(result);
           })
       });
   };

   let UpdatePacijentDodatno = function (id,father_name,mother_name,address,phone,mob,jmbg,relationship_status,smoker) {
    console.log("UPDATE `ordinacija`.`pacijent_dodatno` SET `Ime_oca` = "+mysql.escape(father_name)+",`Ime_majke` = "+mysql.escape(mother_name)+",`Adresa` = "+mysql.escape(address)+",`Telefon` = "+mysql.escape(phone)+",`Mobitel` = "+mysql.escape(mob)+",`JMBG` = "+mysql.escape(jmbg)+",`Bracno_stanje` = "+mysql.escape(relationship_status)+",`Pusac` = "+mysql.escape(smoker)+" WHERE `ID_Pacijent_dodatno` = "+mysql.escape(id)+";");
       return new Promise((resolve, reject) => {
           connection.query("UPDATE `ordinacija`.`pacijent_dodatno` SET `Ime_oca` = "+mysql.escape(father_name)+",`Ime_majke` = "+mysql.escape(mother_name)+",`Adresa` = "+mysql.escape(address)+",`Telefon` = "+mysql.escape(phone)+",`Mobitel` = "+mysql.escape(mob)+",`JMBG` = "+mysql.escape(jmbg)+",`Bracno_stanje` = "+mysql.escape(relationship_status)+",`Pusac` = "+mysql.escape(smoker)+" WHERE `ID_Pacijent_dodatno` = "+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
           })
       });
   };
////////////////////////////////__________PACIJENT_DODATNO_____________//////////////////////////////////////////////////////


////////////////////////////////__________POSJET_____________//////////////////////////////////////////////////////
let SelectPosjetAll = function () {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.posjet;", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let SelectPosjet = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.posjet where ID_Posjet="+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let SelectPosjetForPatient = function (patient) {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.posjet where Pacijent_ID_Pacijent="+mysql.escape(patient)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let DeletePosjet = function (id) {
    return new Promise((resolve, reject) => {
        console.log("DELETE FROM `ordinacija`.`posjet` where ID_Posjet="+mysql.escape(id)+";")
        connection.query("DELETE FROM `ordinacija`.`posjet` where ID_Posjet="+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let InsertPosjet = function (date_time,reason,description,patient,doctor) {
    console.log("INSERT INTO `ordinacija`.`posjet`(`Datum`,`Razlog`,`Opis`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`) VALUES ("+mysql.escape(date_time)+", "+mysql.escape(reason)+","+mysql.escape(description)+","+mysql.escape(patient)+","+mysql.escape(doctor)+");");
       return new Promise((resolve, reject) => {
           connection.query("INSERT INTO `ordinacija`.`posjet`(`Datum`,`Razlog`,`Opis`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`) VALUES ("+mysql.escape(date_time)+", "+mysql.escape(reason)+","+mysql.escape(description)+","+mysql.escape(patient)+","+mysql.escape(doctor)+");"
           , function (err, result, fiels) {
            resolve(result);
           })
       });
   };
   let UpdatePosjet = function (id,date_time,reason,description,patient,doctor) {
    console.log("UPDATE `ordinacija`.`posjet` SET `Datum` = "+mysql.escape(date_time)+",`Razlog` ="+mysql.escape(reason)+",`Opis` = "+mysql.escape(description)+",`Pacijent_ID_Pacijent` ="+mysql.escape(patient)+",`Pacijent_Doktor_ID_Doktor` = "+mysql.escape(doctor)+" WHERE `ID_Posjet` ="+mysql.escape(id)+";");
       return new Promise((resolve, reject) => {
           connection.query("UPDATE `ordinacija`.`posjet` SET `Datum` = "+mysql.escape(date_time)+",`Razlog` ="+mysql.escape(reason)+",`Opis` = "+mysql.escape(description)+",`Pacijent_ID_Pacijent` ="+mysql.escape(patient)+",`Pacijent_Doktor_ID_Doktor` = "+mysql.escape(doctor)+" WHERE `ID_Posjet` ="+mysql.escape(id)+";"
           , function (err, result, fiels) {
            resolve(result);
           })
       });
   };
////////////////////////////////__________POSJET_____________//////////////////////////////////////////////////////


////////////////////////////////__________RADNO_VRIJEME_____________//////////////////////////////////////////////////////
let SelectRadnoVrijemeAll = function () {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.radno_vrijeme;", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let SelectRadnovrijeme = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.radno_vrijeme where ID_Radno_vrijeme="+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let SelectRadnovrijemeForPatient = function (patient) {
    //console.log("SELECT * FROM ordinacija.radno_vrijeme where ID_Radno_vrijeme="+mysql.escape(connection.query("select Radno_vrijeme_ID_Radno_vrijeme from ordinacija.doktor where  ID_Doktor="+mysql.escape(connection.query("select Doktor_ID_Doktor from ordinacija.pacijent where ID_Pacijent="+mysql.escape(patient))+";"))+";")+";");
    console.log("select * from radno_vrijeme where ID_Radno_vrijeme=(select Radno_vrijeme_ID_Radno_vrijeme from ordinacija.doktor where ID_Doktor=(select Doktor_ID_Doktor from ordinacija.pacijent where ID_Pacijent="+mysql.escape(patient)+"));");
    return new Promise((resolve, reject) => {
        connection.query("select * from radno_vrijeme where ID_Radno_vrijeme=(select Radno_vrijeme_ID_Radno_vrijeme from ordinacija.doktor where ID_Doktor=(select Doktor_ID_Doktor from ordinacija.pacijent where ID_Pacijent="+mysql.escape(patient)+"));", function (err, result, fiels) {
            resolve(result);
            
        })
       
    });
};
let DeleteRadnoVrijeme = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("DELETE FROM `ordinacija`.`radno_vrijeme`WHERE ID_Radno_vrijeme="+mysql.escape(id)+";", function (err, result, fiels) {

            resolve(result);
        })
    });
};
let InsertRadnoVrijeme = function (odd_even,morning_afternoon) {
    console.log("INSERT INTO `ordinacija`.`radno_vrijeme`(`Parni/Neparni`,`Jutro/Posljepodne`) VALUES ("+mysql.escape(odd_even)+", "+mysql.escape(morning_afternoon)+");");
       return new Promise((resolve, reject) => {
           connection.query("INSERT INTO `ordinacija`.`radno_vrijeme`(`Parni/Neparni`,`Jutro/Posljepodne`) VALUES ("+mysql.escape(odd_even)+", "+mysql.escape(morning_afternoon)+");", function (err, result, fiels) {
            resolve(result);
           })
       });
   };

   let UpdateRadnoVrijeme = function (id,odd_even,morning_afternoon) {
    console.log("UPDATE `ordinacija`.`radno_vrijeme` SET `Parni/Neparni` = "+mysql.escape(odd_even)+",`Jutro/Posljepodne` = "+mysql.escape(morning_afternoon)+" WHERE `ID_Radno_vrijeme` ="+mysql.escape(id)+";");
       return new Promise((resolve, reject) => {
           connection.query("UPDATE `ordinacija`.`radno_vrijeme` SET `Parni/Neparni` = "+mysql.escape(odd_even)+",`Jutro/Posljepodne` = "+mysql.escape(morning_afternoon)+" WHERE `ID_Radno_vrijeme` ="+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
           })
       });
   };
////////////////////////////////__________RADNO_VRIJEME_____________//////////////////////////////////////////////////////


////////////////////////////////__________RECEPT_____________//////////////////////////////////////////////////////
let SelectReceptAll = function () {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.recept;", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let SelectRecept = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.recept where ID_Recept="+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let SelectReceptForPatient = function (patientid) {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.recept where Pacijent_ID_Pacijent="+mysql.escape(patientid)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let DeleteRecept = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("DELETE FROM ordinacija.recept where ID_Recept="+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let InsertRecept = function (name, date_time,description,patient,doctor) {
    console.log("INSERT INTO `ordinacija`.`recept`(`Naziv`, Datum`,`Opis`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`) VALUES ("+mysql.escape(name)+", "+mysql.escape(date_time)+", "+mysql.escape(description)+","+mysql.escape(patient)+","+mysql.escape(doctor)+");");
       return new Promise((resolve, reject) => {
           connection.query("INSERT INTO `ordinacija`.`recept`(`Naziv`, `Datum`,`Opis`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`) VALUES ("+mysql.escape(name)+","+mysql.escape(date_time)+", "+mysql.escape(description)+","+mysql.escape(patient)+","+mysql.escape(doctor)+");", function (err, result, fiels) {
            resolve(result);
           })
       });
   };

   let UpdateRecept = function (id,date_time,description,patient,doctor) {
    console.log("UPDATE `ordinacija`.`recept`SET `Datum` = "+mysql.escape(date_time)+",`Opis` = "+mysql.escape(description)+",`Pacijent_ID_Pacijent` = "+mysql.escape(patient)+",`Pacijent_Doktor_ID_Doktor` = "+mysql.escape(doctor)+" WHERE `ID_Recept` = "+mysql.escape(id)+";");
       return new Promise((resolve, reject) => {
           connection.query("UPDATE `ordinacija`.`recept`SET `Datum` = "+mysql.escape(date_time)+",`Opis` = "+mysql.escape(description)+",`Pacijent_ID_Pacijent` = "+mysql.escape(patient)+",`Pacijent_Doktor_ID_Doktor` = "+mysql.escape(doctor)+" WHERE `ID_Recept` = "+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
           })
       });
   };
////////////////////////////////__________RECEPT_____________//////////////////////////////////////////////////////


////////////////////////////////__________SLIKA_____________//////////////////////////////////////////////////////
let SelectSlikaAll = function () {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.slika;", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let SelectSlika = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.slika where ID_Slika="+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let DeleteSlika = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("Delete * FROM ordinacija.slika where ID_Slika="+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
////////////////////////////////__________SLIKA_____________//////////////////////////////////////////////////////


////////////////////////////////__________UPUTNICA_____________//////////////////////////////////////////////////////
let SelectUputnicaAll = function () {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.uputnica;", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let SelectUputnica = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.uputnica where ID_Uputnica="+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let SelectUputnicaForPatient = function (patient) {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.uputnica where Pacijent_ID_Pacijent="+mysql.escape(patient)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let DeleteUputnica = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("DELETE FROM ordinacija.uputnica where ID_Uputnica="+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let InsertUputnica = function (name,description,patient,doctor) {
    console.log("INSERT INTO `ordinacija`.`uputnica`(`Naziv`,`Opis`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`) VALUES ("+mysql.escape(name)+", "+mysql.escape(description)+","+mysql.escape(patient)+","+mysql.escape(doctor)+");");
       return new Promise((resolve, reject) => {
           connection.query("INSERT INTO `ordinacija`.`uputnica`(`Naziv`,`Opis`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`) VALUES ("+mysql.escape(name)+", "+mysql.escape(description)+","+mysql.escape(patient)+","+mysql.escape(doctor)+");", function (err, result, fiels) {
            resolve(result);
           })
       });
   };

   let UpdateUputnica = function (id,name,description,patient,doctor) {
    console.log("UPDATE `ordinacija`.`uputnica`SET `Naziv` = "+mysql.escape(name)+",`Opis` = "+mysql.escape(description)+",`Pacijent_ID_Pacijent` = "+mysql.escape(patient)+",`Pacijent_Doktor_ID_Doktor` = "+mysql.escape(doctor)+" WHERE `ID_Uputnica` ="+mysql.escape(id)+";");
       return new Promise((resolve, reject) => {
           connection.query("UPDATE `ordinacija`.`uputnica` SET `Naziv` = "+mysql.escape(name)+",`Opis` = "+mysql.escape(description)+",`Pacijent_ID_Pacijent` = "+mysql.escape(patient)+",`Pacijent_Doktor_ID_Doktor` = "+mysql.escape(doctor)+" WHERE `ID_Uputnica` ="+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
           })
       });
   };
////////////////////////////////__________UPUTNICA_____________//////////////////////////////////////////////////////



////////////////////////////////__________ZAKAZANI_TERMIN_____________//////////////////////////////////////////////////////
let SelectZakazaniTerminAll = function () {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.zakazani_termin;", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let SelectZakazaniTermin = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.zakazani_termin where ID_Zakazani_termin="+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let SelectZakazaniTerminForDate = function (datum, doctor) {
    console.log("SELECT * FROM ordinacija.zakazani_termin where Pacijent_Doktor_ID_Doktor="+mysql.escape(doctor)+" and Datum="+mysql.escape(datum)+";");
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM ordinacija.zakazani_termin where Pacijent_Doktor_ID_Doktor="+mysql.escape(doctor)+" and Datum="+mysql.escape(datum)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let DeleteZakazaniTermin = function (id) {
    return new Promise((resolve, reject) => {
        connection.query("DELETE FROM ordinacija.zakazani_termin where ID_Zakazani_termin="+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
        })
    });
};
let InsertZakazaniTermini = function (date_time,time,patient,doctor) {
    console.log("INSERT INTO `ordinacija`.`zakazani_termin`(`Datum`,`Vrijeme`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`) VALUES ("+mysql.escape(date_time)+", "+mysql.escape(time)+","+mysql.escape(patient)+","+mysql.escape(doctor)+");");
       return new Promise((resolve, reject) => {
           connection.query("INSERT INTO `ordinacija`.`zakazani_termin`(`Datum`,`Vrijeme`,`Pacijent_ID_Pacijent`,`Pacijent_Doktor_ID_Doktor`) VALUES ("+mysql.escape(date_time)+", "+mysql.escape(time)+","+mysql.escape(patient)+","+mysql.escape(doctor)+");", function (err, result, fiels) {
            resolve(result);
           })
       });
   };
   let UpdateZakazaniTermini = function (id,date_time,time,patient,doctor) {
    console.log("UPDATE `ordinacija`.`zakazani_termin`SET `Datum` ="+mysql.escape(date_time)+",`Vrijeme` = "+mysql.escape(time)+",`Pacijent_ID_Pacijent` = "+mysql.escape(patient)+",`Pacijent_Doktor_ID_Doktor` = "+mysql.escape(doctor)+" WHERE `ID_Zakazani_termin` ="+mysql.escape(id)+";");
       return new Promise((resolve, reject) => {
           connection.query("UPDATE `ordinacija`.`zakazani_termin`SET `Datum` ="+mysql.escape(date_time)+",`Vrijeme` = "+mysql.escape(time)+",`Pacijent_ID_Pacijent` = "+mysql.escape(patient)+",`Pacijent_Doktor_ID_Doktor` = "+mysql.escape(doctor)+" WHERE `ID_Zakazani_termin` ="+mysql.escape(id)+";", function (err, result, fiels) {
            resolve(result);
           })
       });
   };
////////////////////////////////__________ZAKAZANI_TERMIN_____________//////////////////////////////////////////////////////

//////PRIJAVA/////
let Login = function (email, password) {
    console.log("SELECT * FROM `ordinacija`.`pacijent` where `Email`="+mysql.escape(email)+" and `Lozinka`="+mysql.escape(md5(password))+";");
    return new Promise((resolve, reject) => {
        connection.query("SELECT * FROM `ordinacija`.`pacijent` where `Email`="+mysql.escape(email)+" and `Lozinka`="+mysql.escape(md5(password))+";", function (err, result, fiels) {
            resolve(result);
            
        })
    });
};
/////PRIJAVA/////


let ChangePasswordPacijent = function (id,password) {
    console.log("INSERT INTO `ordinacija`.`pacijent`(`Ime`,`Prezime`,`Email`,`Lozinka`,`Kontakt`,`Aktivan`,`Doktor_ID_Doktor`) VALUES ("+mysql.escape(name)+", "+mysql.escape(surname)+", "+mysql.escape(email)+", "+mysql.escape(contact)+", '0',"+mysql.escape(doktor)+");")
         return new Promise((resolve, reject) => {
             connection.query("UPDATE  `ordinacija`.`pacijent` SET `Lozinka` = "+mysql.escape(md5(password))+",`Aktivan` = '1' WHERE `ID_Pacijent` = "+mysql.escape(id)+";", function (err, result, fiels) {
              resolve(result);
             })
         });
     };


module.exports = {
    SelectDoktor: SelectDoktor,
    SelectDoktorId:SelectDoktorId,
    SelectDoktorAll: SelectDoktorAll,
    DeleteDoktor: DeleteDoktor,
    InsertDoktor:InsertDoktor,
    UpdateDoktor:UpdateDoktor,

    SelectPacijent:SelectPacijent,
    SelectPacijentID:SelectPacijentID,
    SelectPacijentAll:SelectPacijentAll,
    DeletePacijent:DeletePacijent,
    InsertPacijent:InsertPacijent,
    UpdatePacijent:UpdatePacijent,

    SelectDijagnozaAll: SelectDijagnozaAll,
    SelectDijagnoza: SelectDijagnoza,
    SelectDijagnozaForPatient: SelectDijagnozaForPatient,
    DeleteDijagnoza: DeleteDijagnoza,
    InsertDijagnoza:InsertDijagnoza,
    UpdateDijagnoza:UpdateDijagnoza,

    SelectNeradniDaniAll: SelectNeradniDaniAll,
    SelectNeradniDani: SelectNeradniDani,
    DeleteNeradniDani:DeleteNeradniDani,
    InsertNeradniDan:InsertNeradniDan,
    UpdateNeradniDan:UpdateNeradniDan,

    SelectPacijentDodatnoAll:  SelectPacijentDodatnoAll,
    SelectPacijentDodatno: SelectPacijentDodatno,
    DeletePacijentDodatno: DeletePacijentDodatno,
    InsertPacijentDodatno:InsertPacijentDodatno,
    UpdatePacijentDodatno:UpdatePacijentDodatno,

    SelectPosjetAll: SelectPosjetAll,
    SelectPosjet: SelectPosjet,
    SelectPosjetForPatient: SelectPosjetForPatient,
    DeletePosjet: DeletePosjet,
    InsertPosjet:InsertPosjet,
    UpdatePosjet:UpdatePosjet,

    SelectRadnoVrijemeAll: SelectRadnoVrijemeAll,
    SelectRadnovrijeme:SelectRadnovrijeme,
    SelectRadnovrijemeForPatient:SelectRadnovrijemeForPatient,
    DeleteRadnoVrijeme: DeleteRadnoVrijeme,
    InsertRadnoVrijeme:InsertRadnoVrijeme,
    UpdateRadnoVrijeme:UpdateRadnoVrijeme,

    SelectReceptAll: SelectReceptAll,
    SelectRecept: SelectRecept,
    SelectReceptForPatient: SelectReceptForPatient,
    DeleteRecept: DeleteRecept,
    InsertRecept: InsertRecept,
    UpdateRecept:UpdateRecept,

    SelectSlikaAll: SelectSlikaAll,
    SelectSlika: SelectSlika,
    DeleteSlika: DeleteSlika,

    SelectUputnicaAll: SelectUputnicaAll,
    SelectUputnica: SelectUputnica,
    SelectUputnicaForPatient: SelectUputnicaForPatient,
    DeleteUputnica: DeleteUputnica,
    InsertUputnica: InsertUputnica,
    UpdateUputnica:UpdateUputnica,

    SelectZakazaniTerminAll: SelectZakazaniTerminAll,
    SelectZakazaniTermin: SelectZakazaniTermin,
    SelectZakazaniTerminForDate:SelectZakazaniTerminForDate,
    DeleteZakazaniTermin: DeleteZakazaniTermin,
    InsertZakazaniTermini:InsertZakazaniTermini,
    UpdateZakazaniTermini,UpdateZakazaniTermini,

    Login: Login,

    ChangePasswordPacijent:ChangePasswordPacijent
}

