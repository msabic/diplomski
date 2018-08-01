using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    class InsertPatientInfo
    {
        public bool Execute(PatientInfo patient)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/InsertPacijentDodatno");
                request.Headers["father_name"] = patient.Father_name;
                request.Headers["mother_name"] = patient.Mother_name;
                request.Headers["address"] = patient.Address;
                request.Headers["phone"] = patient.Phone;
                request.Headers["mob"] = patient.Mobile;
                request.Headers["jmbg"] = patient.UCID;
                request.Headers["relationship_status"] =(patient.Relationship_status==true) ? "Ozenjen" : "Neozenjen";
                request.Headers["smoker"] = (patient.Smoker==true) ? "1":"0";
                request.Headers["patientid"] = patient.Patient.ToString();
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
