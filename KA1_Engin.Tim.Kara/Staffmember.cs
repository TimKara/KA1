using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KA1_Engin.Tim.Kara
{
    [Serializable]
    public class Staffmember : Person
    {
        // instance variable
        private string position;

        // constructor
        public Staffmember(string name, string address, int telephone, string password, int userlevel, string position)
            : base(name, address, telephone, password, userlevel)
        {
            this.position = position;
        }

        // Position property
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        // ChangePassword metode
        public override bool ChangePassword(string old_password, string new_password)
        {
            if (old_password.Equals(Password) && new_password.Length > 7)
            {
                Password = new_password;
                return true;
            }
            else
            {
                return false;
            }
        }

        // ToString
        public override string ToString()
        {
            return base.ToString() + " | Position: " + position;
        }
    }
}