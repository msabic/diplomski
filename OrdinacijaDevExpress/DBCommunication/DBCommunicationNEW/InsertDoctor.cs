using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    class InsertDoctor
    {
       public bool Execute(Doctor dr)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/InsertDoktor");
                request.Headers["name"] = dr.Name;
                request.Headers["surname"] = dr.Surname;
                request.Headers["email"] = dr.Email;
                request.Headers["contact"] = dr.Contact;
                request.Headers["workinghours"] = dr.Working_time.ToString();
                request.GetResponse();
                return true;
            }
            catch(Exception ex)
            {
               
                return false;
                throw ex;
            }
        }
    }
}
