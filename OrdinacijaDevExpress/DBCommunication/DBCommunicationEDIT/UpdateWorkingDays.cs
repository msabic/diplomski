using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    class UpdateWorkingDays
    {
        public bool Execute(Working_time workingtime)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/UpdateRadnoVrijeme");
                request.Headers["id"] = workingtime.ID.ToString();
                request.Headers["odd_even"] = workingtime.Odd_Even;
                request.Headers["morning_afternoon"] = workingtime.Morning_Afternoon;
               
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
