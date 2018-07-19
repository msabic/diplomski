using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    class DeleteDiagnosis
    {
        public bool Execute(Diagnosis diagnosis)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/DeleteDijagnoza");
                request.Headers["id"] = diagnosis.ID.ToString();
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
