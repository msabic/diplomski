using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Model;
using System.Net;

namespace DBCommunication
{
    class DeleteReferral
    {
        public bool Execute(Referral referral)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/DeleteUputnica");
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
