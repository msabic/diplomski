using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class AgreedTerm
    {
        private int _ID;
        private DateTime _Date;
        private string _Time;
        private int _Patient;
        private int _Doctor;

        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return _Date;
            }

            set
            {
                _Date = value;
            }
        }

        public string Time
        {
            get
            {
                return _Time;
            }

            set
            {
                _Time = value;
            }
        }

        public int Patient
        {
            get
            {
                return _Patient;
            }

            set
            {
                _Patient = value;
            }
        }

        public int Doctor
        {
            get
            {
                return _Doctor;
            }

            set
            {
                _Doctor = value;
            }
        }
    }
}
