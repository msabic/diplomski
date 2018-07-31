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
    public class GetDoctorID
    {
        public List<Doctor> Execute(int doctor)
        {
            List<Doctor> _doctor = new List<Doctor>();

            string text = string.Empty;
            var request = WebRequest.Create("http://localhost:3000/SelectDoktorId");
            request.Headers["id"] = doctor.ToString();
            var response = (HttpWebResponse)request.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            dynamic item = serializer.Deserialize<object>(text);
            foreach (dynamic it in item)
            {
                _doctor.Add(new Doctor { ID = it["ID_Doktor"], Name = it["Ime"], Surname = it["Prezime"], Email = it["Email"], Password = it["Lozinka"], Contact = it["Kontakt"], Working_time = it["Radno_vrijeme_ID_Radno_vrijeme"] });
            }


            return _doctor;
        }
    }
}
