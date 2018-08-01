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
    class GetPatientInfo
    {
        public List<PatientInfo> Execute()
        {
            List<PatientInfo> _patientInfo = new List<PatientInfo>();

            string text = string.Empty;
            var request = WebRequest.Create("http://localhost:3000/SelectPacijentDodatnoAll");
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic item = serializer.Deserialize<object>(text);
            foreach (dynamic it in item)
            {
                _patientInfo.Add(new PatientInfo { ID = it["ID_Pacijent_dodatno"], Father_name = it["Ime_oca"], Mother_name = it["Ime_majke"], Address = it["Adresa"], Phone = it["Telefon"], Mobile = it["Mobitel"], UCID = it["JMBG"], Relationship_status = (it["Bracno_stanje"] == "Ozenjen") ? true : false, Smoker = (it["Pusac"] == 1) ? true : false , Patient=int.Parse(it["Pacijent_ID_Pacijent"]) });
            }
            return _patientInfo;
        }
    }
}
