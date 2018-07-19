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
    public class GetPrescription
    {
        public List<Prescription> Execute()
        {
            List<Prescription> _prescription = new List<Prescription>();
            string text = string.Empty;
            var request = WebRequest.Create("http://localhost:3000/SelectReceptAll");
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic item = serializer.Deserialize<object>(text);
            foreach (dynamic it in item)
            {
                _prescription.Add(new Prescription { ID = it["ID_Recept"], Description = it["Opis"], Date = DateTime.Parse(it["Datum"]), Doctor = it["Pacijent_Doktor_ID_Doktor"], Patient = it["Pacijent_ID_Pacijent"] });
            }
            return _prescription;
        }
    }
}
