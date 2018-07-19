using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Models.Model;

namespace DBCommunication
{
    public class InsertNonWorkingDays
    {
        public bool Execute(NonWorkingDays nonWorkingDays)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/InsertNeradniDan");
                request.Headers["name"] = nonWorkingDays.Name;
                request.Headers["date_time"] = nonWorkingDays.Date.ToString("yyyy-MM-dd");
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
