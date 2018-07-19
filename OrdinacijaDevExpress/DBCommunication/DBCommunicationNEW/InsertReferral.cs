using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    class InsertReferral
    {
        public bool Execute(Referral referal)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/InsertUputnica");
                request.Headers["name"] = referal.Name;
                request.Headers["description"] = referal.Description;
                request.Headers["patient"] = referal.Patient.ToString();
                request.Headers["doctor"] = referal.Doctor.ToString();
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
