using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    public class DeleteVisitDoctor
    {
        public bool Execute(VisitDoctor visitDoctor)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/DeletePosjet");
                request.Headers["id"] = visitDoctor.ID.ToString();
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
