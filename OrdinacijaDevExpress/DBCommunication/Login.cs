using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    public class Login
    {
        public string Execute(string email, string password)
        {
            string hash = string.Empty;

            string text = string.Empty;
            var request = WebRequest.Create("http://localhost:3000/LoginDoctor");
            request.Headers["email"] = email;
            request.Headers["password"] = password;
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }
            hash = text;
            return hash;
        }
    }
}
