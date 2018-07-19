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

    public class GetWorkingTime
    {
        public List<Working_time> Execute()
        {
            List<Working_time> _working_time= new List<Working_time>();
            string text = string.Empty;
            var request = WebRequest.Create("http://localhost:3000/SelectRadnoVrijemeAll");
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic item = serializer.Deserialize<object>(text);
            foreach (dynamic it in item)
            {
                _working_time.Add(new Working_time { ID = it["ID_Radno_vrijeme"], Odd_Even = it["Parni/Neparni"], Morning_Afternoon = it["Jutro/Posljepodne"] });
            }
            return _working_time;
        }
    }
}
