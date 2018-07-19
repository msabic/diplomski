using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
   public  class VisitDoctor
    {
        public int ID { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
        public int Patient { get; set; }
        public int Doctor { get; set; }
        public DateTime Date { get; set; }
    }
}
