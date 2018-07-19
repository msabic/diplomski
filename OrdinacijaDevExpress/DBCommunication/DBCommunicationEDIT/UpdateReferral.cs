using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Model;
using System.Net;

namespace DBCommunication
{
    class UpdateReferral
    {
        public bool Execute(Referral referral)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/UpdateUputnica");
                request.Headers["name"] = referral.Name;
                request.Headers["description"] = referral.Description;
                request.Headers["patient"] = referral.Patient.ToString();
                request.Headers["doctor"] = referral.Doctor.ToString();
                request.Headers["id"] = referral.ID.ToString();
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
