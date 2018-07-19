using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    class DeletePatient
    {
        public bool Execute(Patient patient)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/DeletePacijent");
                request.Headers["id"] = patient.ID.ToString();
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
