using Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBCommunication
{
    class DeleteWorkingDay
    {
        public bool Execute(Working_time working_time)
        {
            try
            {
                var request = WebRequest.Create("http://localhost:3000/DeleteRadnoVrijeme");
                request.Headers["id"] = working_time.ID.ToString();
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
