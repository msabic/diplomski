const express = require('express')
const app = express()
const md5 = require('md5');
const generator = require('generate-password');
const http = require('http');
const mysql      = require('mysql');
const db=require("./dbControl.js")
const bodyParser = require('body-parser')
const mailer=require("./mailer.js")
const base64 = require('base-64');
const generatedPassword = generator.generate({
  length: 10,
  numbers: true
});

////////////////////////////DOKTOR//////////////////////////////////////////
app.get('/SelectDoktor', function(req,res) {
  if(req.headers.email && req.headers.password){
  db.SelectDoktor(req.headers.email,req.headers.password).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectDoktorId', function(req,res) {
  if(req.headers.id ){
  db.SelectDoktorId(req.headers.id).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectDoktorAll', function(req,res) {
  db.SelectDoktorAll().then((resoult) => {
    res.send(resoult);
  });})
app.get('/DeleteDoktor', function(req,res) {
    if(req.headers.id){
    db.DeleteDoktor(req.headers.id).then((resoult) => {
      res.send(true);
    }).catch((err) => {
      console.log('Error: ', err);
      res.status(400).send('Bad Request');
  });} else {
  res.status(400).send('Bad Request');
  }})
app.get('/InsertDoktor', function(req,res) {
  
    if(req.headers.name && req.headers.surname && req.headers.email && req.headers.contact && req.headers.workinghours){
      const password=generatedPassword;
      console.log(password);
      console.log(md5(password));
    db.InsertDoktor(req.headers.name,req.headers.surname,req.headers.email,md5(password),req.headers.contact,req.headers.workinghours).then((resoult) => {
      mailer.sendMail(req.headers.email,
        'Kreiranje računa',
        `<h3>U aplikaciju se možete prijaviti pomoću lozinke ${password}<h3>`,
        `<h3>Kreiranje računa</h3>
        <p>U aplikaciju se možete prijaviti pomoću lozinke ${password}</p> `
        
    );
      res.send(resoult);
    }).catch((err) => {
      console.log('Error: ', err);
      res.status(400).send('Bad Request');
  });} else {
  res.status(400).send('Bad Request');
  }})
  app.get('/UpdateDoktor', function(req,res) {
  
    if(req.headers.id && req.headers.name && req.headers.surname && req.headers.email && req.headers.contact && req.headers.workinghours){
      
    db.UpdateDoktor(req.headers.id, req.headers.name,req.headers.surname,req.headers.email,req.headers.contact,req.headers.workinghours).then((resoult) => {
       res.send(resoult);
    }).catch((err) => {
      console.log('Error: ', err);
      res.status(400).send('Bad Request');
  });} else {
  res.status(400).send('Bad Request');
  }})
////////////////////////////DOKTOR//////////////////////////////////////////

///////////////////////////PACIJENT/////////////////////////////////////////
app.get('/SelectPacijent', function(req,res) {
  if(req.headers.email && req.headers.password){
  db.SelectPacijent(req.headers.email,req.headers.password).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectPacijentID', function(req,res) {
  if(req.headers.id){
  db.SelectPacijentID(req.headers.id).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectPacijentForDoctor', function(req,res) {
  if(req.headers.doctor){
  db.SelectPacijentForDoctor(req.headers.doctor).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectPacijentAll', function(req,res) {
  db.SelectPacijentAll().then((resoult) => {
    res.send(resoult);
  });
})
app.get('/DeletePacijent', function(req,res) {
  if(req.headers.id){
  db.DeletePacijent(req.headers.id).then((resoult) => {
    res.send(true);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/InsertPacijent', function(req,res) {
  if(req.headers.name && req.headers.surname && req.headers.email && req.headers.contact && req.headers.doktor){
    
    const password=generatedPassword;
    console.log(password);
    console.log(md5(password));
  db.InsertPacijent(req.headers.name,req.headers.surname,req.headers.email,md5(password),req.headers.contact,req.headers.doktor).then((resoult) => {
    mailer.sendMail(req.headers.email,
      'Kreiranje računa',
      `<h3>U aplikaciju se možete prijaviti pomoću lozinke ${password}<h3>`,
      `<h3>Kreiranje računa</h3>
      <p>U aplikaciju se možete prijaviti pomoću lozinke ${password}</p> `
  );
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})

app.get('/UpdatePacijent', function(req,res) {
  console.log(req.headers.id, req.headers.name,req.headers.surname, req.headers.email, req.headers.contact,req.headers.doctor,req.headers.active)
  if(req.headers.id && req.headers.name && req.headers.surname && req.headers.email && req.headers.contact && req.headers.doctor && req.headers.active){
    
   
  db.UpdatePacijent(req.headers.id, req.headers.name,req.headers.surname,req.headers.email,req.headers.contact,req.headers.doctor,req.headers.active).then((resoult) => {
    
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
///////////////////////////PACIJENT/////////////////////////////////////////

//////////////////DIJAGNOZA/////////////////////////////////////
app.get('/SelectDijagnoza', function(req,res) {
  if(req.headers.id ){
  db.SelectDijagnoza(req.headers.id).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectDijagnozaForPatient', function(req,res) {
  if(req.headers.patientid ){
  db.SelectDijagnozaForPatient(req.headers.patientid).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectDijagnozaAll', function(req,res) {
  db.SelectDijagnozaAll().then((resoult) => {
    res.send(resoult);
  });
})
app.get('/DeleteDijagnoza', function(req,res) {
  if(req.headers.id){
  db.DeleteDijagnoza(req.headers.id).then((resoult) => {
    res.send(true);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/InsertDijagnoza', function(req,res){
  if(req.headers.name && req.headers.description && req.headers.patient && req.headers.doctor ){
    db.InsertDijagnoza(req.headers.name,req.headers.description, req.headers.patient, req.headers.doctor ).then((resoult)=>{
      res.send(true);
    }).catch((err)=>{
  console.log('Error; ', err);
res.status(400).send('Bad Request');
});}else{
    res.status(400).send('Bad Request');
  }})
  app.get('/UpdateDijagnoza', function(req,res){
    if(req.headers.id && req.headers.name && req.headers.description && req.headers.patient && req.headers.doctor ){
      db.UpdateDijagnoza(req.headers.id,req.headers.name,req.headers.description, req.headers.patient, req.headers.doctor ).then((resoult)=>{
        res.send(true);
      }).catch((err)=>{
    console.log('Error; ', err);
  res.status(400).send('Bad Request');
  });}else{
      res.status(400).send('Bad Request');
    }})
//////////////////DIJAGNOZA/////////////////////////////////////

////////////////////NERADNI DANI ///////////////////////////////////////
app.get('/SelectNeradniDaniAll', function(req,res) {
    db.SelectNeradniDaniAll().then((resoult) => {
      res.send(resoult);
    });})
app.get('/DeleteNeradniDani', function(req,res) {
        if(req.headers.id){
        db.DeleteNeradniDani(req.headers.id).then((resoult) => {
          res.send(true);
        }).catch((err) => {
          console.log('Error: ', err);
          res.status(400).send('Bad Request');
      });} else {
      res.status(400).send('Bad Request');
      }})
app.get('/InsertNeradniDan', function(req,res){
  if(req.headers.name && req.headers.date_time){
    db.InsertNeradniDan(req.headers.name,req.headers.date_time).then((resoult)=>{
      res.send(true);
    }).catch((err)=>{
    console.log('Error; ', err);
    res.status(400).send('Bad Request');
  });}else{
    res.status(400).send('Bad Request');
  }})
  app.get('/UpdateNeradniDan', function(req,res){
    if(req.headers.id && req.headers.name && req.headers.date_time){
      db.UpdateNeradniDan(req.headers.id, req.headers.name,req.headers.date_time).then((resoult)=>{
        res.send(true);
      }).catch((err)=>{
      console.log('Error; ', err);
      res.status(400).send('Bad Request');
    });}else{
      res.status(400).send('Bad Request');
    }})
////////////////////NERADNI DANI ///////////////////////////////////////  


//////////////////PACIJENT_DODATNO/////////////////////////////////////
app.get('/SelectPacijentDodatno', function(req,res) {
  if(req.headers.patient ){
  db.SelectPacijentDodatno(req.headers.patient).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectPacijentDodatnoAll', function(req,res) {
  db.SelectPacijentDodatnoAll().then((resoult) => {
    res.send(resoult);
  });
})
app.get('/DeletePacijentDodatno', function(req,res) {
  if(req.headers.id){
  db.DeletePacijentDodatno(req.headers.id).then((resoult) => {
    res.send(true);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/InsertPacijentDodatno', function(req,res){
  console.log(req.headers.patientid);
  if(req.headers.father_name && req.headers.mother_name && req.headers.address && req.headers.phone 
    && req.headers.mob && req.headers.jmbg && req.headers.relationship_status && req.headers.smoker && req.headers.patientid){
    db.InsertPacijentDodatno(req.headers.father_name, req.headers.mother_name, req.headers.address, req.headers.phone, 
      req.headers.mob, req.headers.jmbg, req.headers.relationship_status, req.headers.smoker,req.headers.patientid).then((resoult)=>{
      res.send(true);
    }).catch((err)=>{
    console.log('Error; ', err);
    res.status(400).send('Bad Request');
  });}else{
    res.status(400).send('Bad Request1');
  }})

  app.get('/UpdatePacijentDodatno', function(req,res){
    if(req.headers.id && req.headers.father_name && req.headers.mother_name && req.headers.address && req.headers.phone 
      && req.headers.mob && req.headers.jmbg && req.headers.relationship_status && req.headers.smoker){
      db.UpdatePacijentDodatno(req.headers.id,req.headers.father_name, req.headers.mother_name, req.headers.address, req.headers.phone, 
        req.headers.mob, req.headers.jmbg, req.headers.relationship_status, req.headers.smoker).then((resoult)=>{
        res.send(true);
      }).catch((err)=>{
      console.log('Error; ', err);
      res.status(400).send('Bad Request');
    });}else{
      res.status(400).send('Bad Request');
    }})
//////////////////PACIJENT_DODATNO/////////////////////////////////////

//////////////////POSJET///////////////////////////////////////////////
app.get('/SelectPosjet', function(req,res) {
  if(req.headers.id ){
  db.SelectPosjet(req.headers.id).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectPosjetForPatient', function(req,res) {
  if(req.headers.patient ){
  db.SelectPosjetForPatient(req.headers.patient).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectPosjetAll', function(req,res) {
  db.SelectPosjetAll().then((resoult) => {
    res.send(resoult);
  });
})
app.get('/DeletePosjet', function(req,res) {
  if(req.headers.id){
  db.DeletePosjet(req.headers.id).then((resoult) => {
    res.send(true);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/InsertPosjet', function(req,res){
  if(req.headers.date_time && req.headers.reason && req.headers.description && req.headers.patient && req.headers.doctor){
    db.InsertPosjet(req.headers.date_time, req.headers.reason, req.headers.description, req.headers.patient, req.headers.doctor).then((resoult)=>{
      res.send(true);
    }).catch((err)=>{
    console.log('Error; ', err);
    res.status(400).send('Bad Request');
  });}else{
    res.status(400).send('Bad Request');
  }})
  app.get('/UpdatePosjet', function(req,res){
    if(req.headers.id && req.headers.date_time && req.headers.reason && req.headers.description && req.headers.patient && req.headers.doctor){
      db.UpdatePosjet(req.headers.id, req.headers.date_time, req.headers.reason, req.headers.description, req.headers.patient, req.headers.doctor).then((resoult)=>{
        res.send(true);
      }).catch((err)=>{
      console.log('Error; ', err);
      res.status(400).send('Bad Request');
    });}else{
      res.status(400).send('Bad Request');
    }})
//////////////////POSJET/////////////////////////////////////

//////////////////////////RADNO_VRIJEME////////////////////////////////////

app.get('/SelectRadnoVrijemeAll', function(req,res) {
  db.SelectRadnoVrijemeAll().then((resoult) => {
    res.send(resoult);
  });})
  app.get('/SelectRadnoVrijeme', function(req,res) {
    if(req.headers.id ){
    db.SelectRadnovrijeme(req.headers.id).then((resoult) => {
      res.send(resoult);
    }).catch((err) => {
      console.log('Error: ', err);
      res.status(400).send('Bad Request');
  });} else {
  res.status(400).send('Bad Request');
  }})
  app.get('/SelectRadnovrijemeForPatient', function(req,res) {
    if(req.headers.patient ){
    db.SelectRadnovrijemeForPatient(req.headers.patient).then((resoult) => {
      res.send(resoult);
    }).catch((err) => {
      console.log('Error: ', err);
      res.status(400).send('Bad Request1');
  });} else {
  res.status(400).send('Bad Request2');
  }})
  app.get('/DeleteRadnoVrijeme', function(req,res) {
    if(req.headers.id){
    db.DeleteRadnoVrijeme(req.headers.id).then((resoult) => {
      res.send(true);
    }).catch((err) => {
      console.log('Error: ', err);
      res.status(400).send('Bad Request');
  });} else {
  res.status(400).send('Bad Request');
  }})
  app.get('/InsertRadnoVrijeme', function(req,res){
    if(req.headers.odd_even && req.headers.morning_afternoon){
      db.InsertRadnoVrijeme(req.headers.odd_even, req.headers.morning_afternoon).then((resoult)=>{
        res.send(true);
      }).catch((err)=>{
      console.log('Error; ', err);
      res.status(400).send('Bad Request');
    });}else{
      res.status(400).send('Bad Request');
    }})


      app.get('/UpdateRadnoVrijeme', function(req,res){
        if(req.headers.id && req.headers.odd_even && req.headers.morning_afternoon){
          db.UpdateRadnoVrijeme(req.headers.id, req.headers.odd_even, req.headers.morning_afternoon).then((resoult)=>{
            res.send(true);
          }).catch((err)=>{
          console.log('Error; ', err);
          res.status(400).send('Bad Request');
        });}else{
          res.status(400).send('Bad Request');
        }})
//////////////////////////RADNO_VRIJEME////////////////////////////////////


///////////////////RECEPT/////////////////////////////////////
app.get('/SelectRecept', function(req,res) {
  if(req.headers.id ){
  db.SelectRecept(req.headers.id).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectReceptForPatient', function(req,res) {
  if(req.headers.patientid ){
  db.SelectReceptForPatient(req.headers.patientid).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectReceptAll', function(req,res) {
  db.SelectReceptAll().then((resoult) => {
    res.send(resoult);
  });
})
app.get('/DeleteRecept', function(req,res) {
  if(req.headers.id){
  db.DeleteRecept(req.headers.id).then((resoult) => {
    res.send(true);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/InsertRecept', function(req,res){
  if(req.headers.name, req.headers.date_time && req.headers.description && req.headers.patient && req.headers.doctor){
    db.InsertRecept(req.headers.name, req.headers.date_time,req.headers.description, req.headers.patient, req.headers.doctor).then((resoult)=>{
      res.send(true);
    }).catch((err)=>{
    console.log('Error; ', err);
    res.status(400).send('Bad Request1');
  });}else{
    res.status(400).send('Bad Request2');
  }})
  app.get('/UpdateRecept', function(req,res){
    if(req.headers.id && req.headers.date_time && req.headers.description && req.headers.patient && req.headers.doctor){
      db.UpdateRecept(req.headers.id, req.headers.date_time,req.headers.description, req.headers.patient, req.headers.doctor).then((resoult)=>{
        res.send(true);
      }).catch((err)=>{
      console.log('Error; ', err);
      res.status(400).send('Bad Request');
    });}else{
      res.status(400).send('Bad Request');
    }})
//////////////////RECEPT/////////////////////////////////////

//////////////////SLIKA/////////////////////////////////////
app.get('/SelectSlika', function(req,res) {
  if(req.headers.id ){
  db.SelectSlika(req.headers.id).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectSlikaAll', function(req,res) {
  db.SelectSlikaAll().then((resoult) => {
    res.send(resoult);
  });
})
app.get('/DeleteSlika', function(req,res) {
  if(req.headers.id){
  db.DeleteSlika(req.headers.id).then((resoult) => {
    res.send(true);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})

//////////////////SLIKA/////////////////////////////////////

//////////////////UPUTNICA/////////////////////////////////////
app.get('/SelectUputnica', function(req,res) {
  if(req.headers.id ){
  db.SelectUputnica(req.headers.id).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectUputnicaForPatient', function(req,res) {
  if(req.headers.patient ){
  db.SelectUputnicaForPatient(req.headers.patient).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectUputnicaAll', function(req,res) {
  db.SelectUputnicaAll().then((resoult) => {
    res.send(resoult);
  });
})
app.get('/DeleteUputnica', function(req,res) {
  if(req.headers.id){
  db.DeleteUputnica(req.headers.id).then((resoult) => {
    res.send(true);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/InsertUputnica', function(req,res){
  if(req.headers.name && req.headers.description && req.headers.patient && req.headers.doctor){
    db.InsertUputnica(req.headers.name,req.headers.description, req.headers.patient, req.headers.doctor).then((resoult)=>{
      res.send(true);
    }).catch((err)=>{
    console.log('Error; ', err);
    res.status(400).send('Bad Request');
  });}else{
    res.status(400).send('Bad Request');
  }})
  app.get('/UpdateUputnica', function(req,res){
    if(req.headers.id && req.headers.name && req.headers.description && req.headers.patient && req.headers.doctor){
      db.UpdateUputnica(req.headers.id,req.headers.name,req.headers.description, req.headers.patient, req.headers.doctor).then((resoult)=>{
        res.send(true);
      }).catch((err)=>{
      console.log('Error; ', err);
      res.status(400).send('Bad Request');
    });}else{
      res.status(400).send('Bad Request');
    }})
//////////////////UPUTNICA/////////////////////////////////////

//////////////////ZAKAZANI_TERMINI/////////////////////////////////////
app.get('/SelectZakazaniTermin', function(req,res) {
  if(req.headers.id ){
  db.SelectZakazaniTermin(req.headers.id).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectZakazaniTerminForPatient', function(req,res) {
  if(req.headers.patient ){
  db.SelectZakazaniTerminForPatient(req.headers.patient).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectZakazaniTerminForDoctor', function(req,res) {
  if(req.headers.doctor ){
  db.SelectZakazaniTerminForDoctor(req.headers.doctor).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectZakazaniTerminForDate', function(req,res) {
  if(req.headers.datum && req.headers.doctor ){
  db.SelectZakazaniTerminForDate(req.headers.datum, req.headers.doctor).then((resoult) => {
    res.send(resoult);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/SelectZakazaniTerminAll', function(req,res) {
  db.SelectZakazaniTerminAll().then((resoult) => {
    res.send(resoult);
  });
})
app.get('/DeleteZakazaniTermin', function(req,res) {
  if(req.headers.id){
  db.DeleteZakazaniTermin(req.headers.id).then((resoult) => {
    res.send(true);
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/InsertZakazaniTermin', function(req,res){
  if(req.headers.date_time && req.headers.time && req.headers.patient && req.headers.doctor){
    db.InsertZakazaniTermini(req.headers.date_time,req.headers.time, req.headers.patient, req.headers.doctor).then((resoult)=>{
      res.send(true);
    }).catch((err)=>{
    console.log('Error; ', err);
    res.status(400).send('Bad Request');
  });}else{
    res.status(400).send('Bad Request');
  }})
  app.get('/UpdateZakazaniTermin', function(req,res){
    if(req.headers.id && req.headers.date_time && req.headers.time && req.headers.patient && req.headers.doctor){
      db.UpdateZakazaniTermini(req.headers.id, req.headers.date_time,req.headers.time, req.headers.patient, req.headers.doctor).then((resoult)=>{
        res.send(true);
      }).catch((err)=>{
      console.log('Error; ', err);
      res.status(400).send('Bad Request');
    });}else{
      res.status(400).send('Bad Request');
    }})
//////////////////ZAKAZANI_TERMINI/////////////////////////////////////


//////////////////PRIJAVA//////////////////////////////////////////////
app.get('/Login', function(req,res) {
 
  if(req.headers.email && req.headers.password){
  db.Login(req.headers.email,req.headers.password).then((resoult,error) => {
    console.log(resoult)
     if(resoult[0].Email)
     {
       console.log(base64.encode(md5('1950th'+resoult[0].Email+';'+req.headers.password)));
       res.send(base64.encode(md5('1950th'+resoult[0].Email+';'+req.headers.password))+";"+resoult[0].ID_Pacijent+";"+resoult[0].Aktivan);
     }
     else{
       console.log('Error: ', error);
       res.status(404).send('No user');
     }
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})

app.get('/LoginDoctor', function(req,res) {
 
  if(req.headers.email && req.headers.password){
  db.LoginDoctor(req.headers.email,req.headers.password).then((resoult,error) => {
    console.log(resoult)
     if(resoult[0].Email)
     {
       console.log(base64.encode(md5('1950th'+resoult[0].Email+';'+req.headers.password)));
       res.send(base64.encode(md5('1950th'+resoult[0].Email+';'+req.headers.password))+";"+resoult[0].ID_Doktor);
     }
     else{
       console.log('Error: ', error);
       res.status(404).send('No user');
     }
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
/////////////////PRIJAVA//////////////////////////////////////////////


/////////////////Izmjena_lozinke///////////////////////////////////////

app.get('/ChangePasswordPacijent', function(req,res) {
  console.log(req.headers.id, req.headers.password)
  if(req.headers.id && req.headers.password){
  db.ChangePasswordPacijent(req.headers.id, req.headers.password).then((resoult) => {
    res.send("true");
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
app.get('/ChangePasswordDoctor', function(req,res) {
  console.log(req.headers.id, req.headers.password)
  if(req.headers.id && req.headers.password){
  db.ChangePasswordDoctor(req.headers.id, req.headers.password).then((resoult) => {
    res.send("true");
  }).catch((err) => {
    console.log('Error: ', err);
    res.status(400).send('Bad Request');
});} else {
res.status(400).send('Bad Request');
}})
//////////////////Izmjena_lozinke/////////////////////////////////////


//////////////////SEND EMAIL/////////////////////////////////////

app.get('/SendEmail', function(req,res) {mailer.sendMail(req.headers.email, req.headers.subject,req.headers.message_email);
  res.send("true");})

//////////////////SEND EMAIL/////////////////////////////////////
app.listen(3000, () => console.log('Example app listening on port 3000!'))