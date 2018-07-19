using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class PatientInfo
    {
        public int ID { get; set; }
        public string Father_name { get; set; }
        public string Mother_name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string UCID { get; set; }
        public bool Relationship_status { get; set; }
        public bool Smoker { get; set; }
    }
}
