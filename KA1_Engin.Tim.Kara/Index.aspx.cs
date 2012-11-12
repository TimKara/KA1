using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace KA1_Engin.Tim.Kara
{
    public partial class Index : System.Web.UI.Page
    {
        // level 0 = guest, level 1 = footballplayer, level 2 = staffmember & level 3 = webmaster.
        private int userlevel;
        private ArrayList playerlist;
        private ArrayList stafflist;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                userlevel = (int)Session["mylevel"];
                playerlist = FileIO.ReadFile(Server.MapPath("~/App_Data/playerlistfile.ser"));
                stafflist = FileIO.ReadFile(Server.MapPath("~/App_Data/stafflistfile.ser"));
            }
            catch
            {
                userlevel = 0;
                Session["mylevel"] = userlevel;
            }
            finally
            {
                TextBoxPass.TextMode = TextBoxMode.Password;
            }
        }

        public void LoadPage()
        {
            if (userlevel == 3)
            {
                LabelMessage.Text = "";
                Response.Redirect("Webmaster.aspx");
            }
            else if (userlevel == 2)
            {
                LabelMessage.Text = "";
                Response.Redirect("Staff.aspx");
            }
            else if (userlevel == 1)
            {
                LabelMessage.Text = "";
                Response.Redirect("Player.aspx");
            }
            else
            {
                LabelMessage.Text = "Error: Wrong name and password combination";
            }
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            userlevel = 0;
            int pwl = TextBoxPass.Text.Length;
            if (pwl < 4)
            {
                LabelMessage.Text = "Error: Password must have at least 4 characters";
            }
            else
            {
                for (int i = 0; i < playerlist.Count; i++)
                {
                    if (TextBoxName.Text.Equals(((Footballplayer)playerlist[i]).Name) && TextBoxPass.Text.Equals(((Footballplayer)playerlist[i]).Password))
                    {
                        Session["player"] = (Footballplayer)playerlist[i];
                        userlevel = 1;
                        break;
                    }
                }

                for (int i = 0; i < stafflist.Count; i++)
                {
                    if (TextBoxName.Text.Equals(((Staffmember)stafflist[i]).Name) && TextBoxPass.Text.Equals(((Staffmember)stafflist[i]).Password))
                    {

                        Session["staff"] = (Staffmember)stafflist[i];
                        userlevel = ((Staffmember)stafflist[i]).Userlevel;
                        break;
                    }
                }
             
                Session["mylevel"] = userlevel;
                LoadPage();
            }
        }

        protected void ButtonGuest_Click(object sender, EventArgs e)
        {
            LabelMessage.Text = "";
            Response.Redirect("Guest.aspx");
        }
    }
}