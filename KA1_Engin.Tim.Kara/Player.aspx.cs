using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace KA1_Engin.Tim.Kara
{
    public partial class Player : System.Web.UI.Page
    {
        // level 0 = guest, level 1 = footballplayer, level 2 = staffmember & level 3 = webmaster.
        private int userlevel;
        private ArrayList playerlist;
        private Footballplayer fp;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            try
            {
                userlevel = (int)Session["mylevel"];
            }
            catch
            {
                userlevel = 0;
                Session["mylevel"] = userlevel;
            }
            finally
            {
                if (userlevel == 1)
                {
                    playerlist = FileIO.ReadFile(Server.MapPath("~/App_Data/playerlistfile.ser"));
                    Application.Set("playerlist", playerlist);
                    fp = (Footballplayer)Session["player"];

                    if (fp != null)
                    {
                        LabelMessage.Text = "Welcome Back " + fp.Name;
                        if (TextBoxName.Text == "")
                        {
                            TextBoxName.Text = fp.Name;
                            TextBoxAddress.Text = fp.Address;
                            TextBoxTelephone.Text = "" + fp.Telephone;
                            TextBoxPlayer_number.Text = "" + fp.Player_number;
                            TextBoxHeight.Text = "" + fp.Height;
                            TextBoxWeight.Text = "" + fp.Weight;
                            TextBoxAge.Text = "" + fp.Age;
                        }
                    }     
                }
                else
                {
                    Response.Redirect("403.aspx");
                }
            }
     
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            playerlist = (ArrayList)Application.Get("playerlist");
            for (int i = playerlist.Count - 1; i >= 0; i--)
            {
                if (((Footballplayer)playerlist[i]).Name == fp.Name && ((Footballplayer)playerlist[i]).Password == fp.Password)
                {
                    ((Footballplayer)playerlist[i]).Name = TextBoxName.Text;
                    ((Footballplayer)playerlist[i]).Address = TextBoxAddress.Text;
                    ((Footballplayer)playerlist[i]).Telephone = Convert.ToInt32(TextBoxTelephone.Text);
                    ((Footballplayer)playerlist[i]).Player_number = Convert.ToInt32(TextBoxPlayer_number.Text);
                    ((Footballplayer)playerlist[i]).Height = Convert.ToInt32(TextBoxHeight.Text);
                    ((Footballplayer)playerlist[i]).Weight = Convert.ToInt32(TextBoxWeight.Text);
                    ((Footballplayer)playerlist[i]).Age = Convert.ToInt32(TextBoxAge.Text);
                    Session["player"] = (Footballplayer)playerlist[i];
                }
            }
            Application.Set("playerlist", playerlist);
            FileIO.WriteFile(playerlist, Server.MapPath("~/App_Data/playerlistfile.ser"));
        }

        protected void ButtonChangePass_Click(object sender, EventArgs e)
        {
            bool passChanged = false;
            playerlist = (ArrayList)Application.Get("playerlist");
            for (int i = playerlist.Count - 1; i >= 0; i--)
            {
                if (((Footballplayer)playerlist[i]).Name == fp.Name && ((Footballplayer)playerlist[i]).Password == fp.Password)
                {
                    passChanged = ((Footballplayer)playerlist[i]).ChangePassword(TextBoxOldPass.Text, TextBoxNewPass.Text);
                    Session["player"] = (Footballplayer)playerlist[i];
                }
            }

            if (passChanged)
            {
                LabelMessage.Text = "You have successfully changed your password";
            }
            else
            {
                LabelMessage.Text = "Error: Your password was not changed: ";

                if (TextBoxOldPass.Text != fp.Password)
                {
                    LabelMessage.Text += "Current Password doesn't match! ";
                }
                if (TextBoxNewPass.Text.Length < 4)
                {
                    LabelMessage.Text += "Password must have at least 4 characters! ";
                }
            }            
            Application.Set("playerlist", playerlist);
            FileIO.WriteFile(playerlist, Server.MapPath("~/App_Data/playerlistfile.ser"));
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session["player"] = null;
            Session["mylevel"] = 0;
            Response.Redirect("Index.aspx");
        }
    }
}