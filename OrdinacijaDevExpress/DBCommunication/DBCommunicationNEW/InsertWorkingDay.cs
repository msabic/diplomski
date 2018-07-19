using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    public class InsertWorkingDay
    {
        public bool Execute(Working_time workingTime)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/InsertRadnoVrijeme");
                request.Headers["odd_even"] = workingTime.Odd_Even;
                request.Headers["morning_afternoon"] = workingTime.Morning_Afternoon;
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
