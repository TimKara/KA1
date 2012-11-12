using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KA1_Engin.Tim.Kara
{
    interface IChangePassword
    {
        bool ChangePassword(string old_password, string new_password);
    }
}
