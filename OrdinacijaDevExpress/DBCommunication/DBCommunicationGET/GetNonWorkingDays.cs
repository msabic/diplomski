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
   public  class GetNonWorkingDays
    {
        public List<NonWorkingDays> Execute()
        {
            List<NonWorkingDays> _nonWorkingDays = new List<NonWorkingDays>();

            string text = string.Empty;
            var request = WebRequest.Create("http://localhost:3000/SelectNeradniDaniAll");
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic item = serializer.Deserialize<object>(text);
            foreach (dynamic it in item)
            {
                _nonWorkingDays.Add(new NonWorkingDays { ID = it["ID_Neradni_dan"], Name = it["Naziv"], Date = DateTime.Parse(it["Datum"]) });
            }
            return _nonWorkingDays;
        }
    }
}
