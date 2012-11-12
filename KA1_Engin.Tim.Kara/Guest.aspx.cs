using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace KA1_Engin.Tim.Kara
{
    public partial class Guest : System.Web.UI.Page
    {
        private ArrayList playerlist;

        protected void Page_Load(object sender, EventArgs e)
        {
            playerlist = FileIO.ReadFile(Server.MapPath("~/App_Data/playerlistfile.ser"));
            for (int i = 0; i < playerlist.Count; i++)
            {
                ListBoxGuest.Items.Add(((Footballplayer)playerlist[i]).ToString());
            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}