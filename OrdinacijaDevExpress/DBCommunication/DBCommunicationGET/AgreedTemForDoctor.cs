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
    public class AgreedTemForDoctor
    {

        public List<AgreedTerm> Execute(int doctor)
        {
            List<AgreedTerm> _agreedTerm = new List<AgreedTerm>();
            string text = string.Empty;
            var request = WebRequest.Create("http://localhost:3000/SelectZakazaniTerminForDoctor");
            request.Headers["doctor"] = doctor.ToString();
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic item = serializer.Deserialize<object>(text);
            foreach (dynamic it in item)
            {
                _agreedTerm.Add(new AgreedTerm { ID = it["ID_Zakazani_termin"], Date = DateTime.Parse(it["Datum"]), Time = it["Vrijeme"], Doctor = it["Pacijent_Doktor_ID_Doktor"], Patient = it["Pacijent_ID_Pacijent"] });
            }
            return _agreedTerm;
        }
    }
}
