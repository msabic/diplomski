using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    class ChangePassword
    {
        public bool Execute(int id, string password)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/ChangePasswordDoctor");
                request.Headers["id"] = id.ToString();
                request.Headers["password"] = password;
                
                request.GetResponse();
                return true;
            }
            catch (Exception ex)
            {

                return false;
                throw ex;
            }
        }
    }
}
