using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    public class Patient
    {
        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private string _Surname;
        public string Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        private string _Contact;
        public string Contact
        {
            get { return _Contact; }
            set { _Contact = value; }
        }
        private bool _Active;
        public bool Active
        {
        get { return _Active; }
            set { _Active = value; }
        }
        private int _Doctor;
        public int Doctor
        {
            get { return _Doctor; }
            set { _Doctor = value; }
        }
    }
}
