using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    class UpdatePrescription
    {
        public bool Execute(Prescription prescription)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/UpdateRecept");
                request.Headers["date_time"] = prescription.Date.ToString("yyyy-MM-dd");
                request.Headers["description"] = prescription.Description;
                request.Headers["patient"] = prescription.Patient.ToString();
                request.Headers["doctor"] = prescription.Doctor.ToString();
                request.Headers["id"] = prescription.ID.ToString();
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
