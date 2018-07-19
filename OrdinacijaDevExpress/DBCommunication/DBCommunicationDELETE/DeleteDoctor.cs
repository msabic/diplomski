using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    public class DeleteDoctor
    {
        public bool Execute(Doctor dr)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/DeleteDoktor");
                request.Headers["id"] = dr.ID.ToString();
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
