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
    public class GetVistiDoctorForPatient
    {
        public List<VisitDoctor> Execute(int patientID)
        {
            List<VisitDoctor> _visitDoctor = new List<VisitDoctor>();
            string text = string.Empty;
            var request = WebRequest.Create("http://localhost:3000/SelectPosjetForPatient");
            request.Headers["patient"] = patientID.ToString();
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic item = serializer.Deserialize<object>(text);
            foreach (dynamic it in item)
            {
                _visitDoctor.Add(new VisitDoctor { ID = it["ID_Posjet"], Description = it["Opis"], Reason = it["Razlog"], Date = DateTime.Parse(it["Datum"]), Doctor = it["Pacijent_Doktor_ID_Doktor"], Patient = it["Pacijent_ID_Pacijent"] });
            }
            return _visitDoctor;
        }
    }
}
