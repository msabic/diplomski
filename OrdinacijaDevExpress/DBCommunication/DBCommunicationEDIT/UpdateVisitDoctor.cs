using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    public class UpdateVisitDoctor
    {
        public bool Execute(VisitDoctor visitDoctor)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/UpdatePosjet");
                request.Headers["reason"] = visitDoctor.Reason;
                request.Headers["date_time"] = visitDoctor.Date.ToString("yyyy-MM-dd");
                request.Headers["description"] = visitDoctor.Description;
                request.Headers["patient"] = visitDoctor.Patient.ToString();
                request.Headers["doctor"] = visitDoctor.Doctor.ToString();
                request.Headers["id"] = visitDoctor.ID.ToString();
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
