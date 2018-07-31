using Models.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DBCommunication
{
    public class GetDiagnosisForPatient
    {
        public List<Diagnosis> Execute(int patient)
        {
            List<Diagnosis> _diagnosis = new List<Diagnosis>();
            string text = string.Empty;
            var request = WebRequest.Create("http://localhost:3000/SelectDijagnozaForPatient");
            request.Headers["patientid"] = patient.ToString();
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic item = serializer.Deserialize<object>(text);
            foreach (dynamic it in item)
            {
                _diagnosis.Add(new Diagnosis { ID = it["ID_Dijagnoza"], Description = it["Opis"], Name = it["Naziv"], Doctor = it["Pacijent_Doktor_ID_Doktor"], Patient = it["Pacijent_ID_Pacijent"] });
            }
            return _diagnosis;
        }
    }
}
