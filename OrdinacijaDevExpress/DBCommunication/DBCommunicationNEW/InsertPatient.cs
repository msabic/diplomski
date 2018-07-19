using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    class InsertPatient
    {
        public bool Execute(Patient patient)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/InsertPacijent");
                request.Headers["name"] = patient.Name;
                request.Headers["surname"] = patient.Surname;
                request.Headers["email"] = patient.Email;
                request.Headers["contact"] = patient.Contact;
                request.Headers["doktor"] = patient.Doctor.ToString();
                request.GetResponse();
                return true;
            }
            catch (Exception ex)
            {
                
                return false;
                throw ex;
            }
        }
    }
}
