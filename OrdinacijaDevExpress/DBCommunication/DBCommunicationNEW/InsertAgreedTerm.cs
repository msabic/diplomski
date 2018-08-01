using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    class InsertAgreedTerm
    {
        public bool Execute(AgreedTerm agreedTerm)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/InsertZakazaniTermin");
                request.Headers["date_time"] = agreedTerm.Date.ToString("yyyy-MM-dd");
                request.Headers["time"] = agreedTerm.Time;
                request.Headers["patient"] = agreedTerm.Patient.ToString();
                request.Headers["doctor"] = agreedTerm.Doctor.ToString();
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
