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
    public class GetNonWorkingDay
    {
        public bool Execute(string date)
        {
            List<NonWorkingDays> _nonWorkingDays = new List<NonWorkingDays>();

            string text = string.Empty;
            var request = WebRequest.Create("http://localhost:3000/SelectNeradniDaniAll");
            request.Headers["datum"] = date;
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }
            if (text == "true")
            {
                return true;
            }
            else
            {
                return false; 
            }
           
        }
    }
}
