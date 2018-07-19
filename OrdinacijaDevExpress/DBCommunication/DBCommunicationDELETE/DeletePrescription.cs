using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    class DeletePrescription
    {
        public bool Execute(Prescription prescription)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/DeleteRecept");
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
