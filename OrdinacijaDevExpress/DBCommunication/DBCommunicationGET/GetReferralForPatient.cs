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
    public class GetReferralForPatient
    {
        public List<Referral> Execute(int patient)
        {
            List<Referral> _referral = new List<Referral>();
            string text = string.Empty;
            var request = WebRequest.Create("http://localhost:3000/SelectUputnicaForPatient");
            request.Headers["patient"] = patient.ToString();
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic item = serializer.Deserialize<object>(text);
            foreach (dynamic it in item)
            {
                _referral.Add(new Referral { ID = it["ID_Uputnica"], Description = it["Opis"], Name = it["Naziv"], Doctor = it["Pacijent_Doktor_ID_Doktor"], Patient = it["Pacijent_ID_Pacijent"] });
            }
            return _referral;
        }
    }
}
