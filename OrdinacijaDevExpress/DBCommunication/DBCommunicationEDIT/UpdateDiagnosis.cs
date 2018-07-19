using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    class UpdateDiagnosis
    {
        public bool Execute(Diagnosis diagnosis)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/UpdateDijagnoza");
                request.Headers["name"] = diagnosis.Name;
                request.Headers["description"] = diagnosis.Description;
                request.Headers["patient"] = diagnosis.Patient.ToString();
                request.Headers["doctor"] = diagnosis.Doctor.ToString();
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
