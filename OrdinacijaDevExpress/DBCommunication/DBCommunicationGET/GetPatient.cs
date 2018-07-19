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
    class GetPatient
    {
        public List<Patient> Execute()
        {
            List<Patient> _patient = new List<Patient>();

            string text = string.Empty;
            var request = WebRequest.Create("http://localhost:3000/SelectPacijentAll");
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic item = serializer.Deserialize<object>(text);
            foreach (dynamic it in item)
            {
                _patient.Add(new Patient { ID = it["ID_Pacijent"], Name = it["Ime"], Surname = it["Prezime"], Email = it["Email"], Password = it["Lozinka"], Contact = it["Kontakt"], Active = (it["Aktivan"] == 1) ? true: false, Doctor = it["Doktor_ID_Doktor"] });
            }
            return _patient;
        }
    }
}
