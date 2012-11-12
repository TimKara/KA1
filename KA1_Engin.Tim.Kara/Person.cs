using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KA1_Engin.Tim.Kara
{
    [Serializable]
    public class Person : IChangePassword
    {
        // class variables ikke en instance variables.. (private static)
        private static int id = 1;

        // instance variables
        protected int personid;
        private string name;
        private string address;
        private int telephone;
        private string password;
        // level 1 = footballplayer, level 2 = staffmember & level 3 = webmaster.
        private int userlevel;

        // constructor
        public Person(string name, string address, int telephone, string password, int userlevel)
        {
            this.name = name;
            this.address = address;
            this.telephone = telephone;
            this.password = password;
            this.userlevel = userlevel;
            personid = id;
            id++;
        }

        // Personid property
        public int Personid
        {
            get { return personid; }
            set 
            {
                personid = value;
                id = value;
            }
        }

        // Name property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // Address property
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        // Telephone property
        public int Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        // Password property
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        // Userlevel property
        public int Userlevel
        {
            get { return userlevel; }
            set
            {
                if (value > 0 && value < 4)
                {
                    userlevel = value;
                }
            }
        }

        // ChangePassword metode
        public virtual bool ChangePassword(string old_password, string new_password)
        {
            if (old_password.Equals(password) && new_password.Length > 3)
            {
                password = new_password;
                return true;
            }
            else
            {
                return false;
            }
        }

        // ToString metode
        public override string ToString()
        {
            return "ID: " + personid + " | Name: " + name + " | Address: " + address + " | Telephone: " + telephone + " | User Level: " + userlevel;
        }
    }
}