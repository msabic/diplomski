using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    class InsertDiagnosis
    {
        public bool Execute(Diagnosis diagnosis)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/InsertDijagnoza");
                request.Headers["name"] = diagnosis.Name;
                request.Headers["description"] = diagnosis.Description;
                request.Headers["patient"] = diagnosis.Patient.ToString();
                request.Headers["doctor"] = diagnosis.Doctor.ToString();
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
