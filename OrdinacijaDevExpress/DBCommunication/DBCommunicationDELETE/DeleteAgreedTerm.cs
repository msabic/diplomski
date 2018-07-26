using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    class DeleteAgreedTerm
    {
        public bool Execute(AgreedTerm agreedterm)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/DeleteZakazaniTermin");
                request.Headers["id"] = agreedterm.ID.ToString();
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
