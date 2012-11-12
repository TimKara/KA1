using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace KA1_Engin.Tim.Kara
{
    public partial class Staff : System.Web.UI.Page
    {
        // level 0 = guest, level 1 = footballplayer, level 2 = staffmember & level 3 = webmaster.
        private int userlevel;
        private ArrayList playerlist, stafflist;
        private Staffmember sm;

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
                if (userlevel == 2 || userlevel == 3)
                {
                    if (userlevel == 3)
                    {
                        ButtonGoToWebmaster.Visible = true;
                    }
                    else
                    {
                        ButtonGoToWebmaster.Visible = false;
                    }

                    stafflist = FileIO.ReadFile(Server.MapPath("~/App_Data/stafflistfile.ser"));
                    Application.Set("stafflist", stafflist);
                    sm = (Staffmember)Session["staff"];

                    if (sm != null)
                    {
                        LabelMessage.Text = "Welcome Back " + sm.Name;
                        if (TextBoxName.Text == "")
                        {
                            TextBoxName.Text = sm.Name;
                            TextBoxAddress.Text = sm.Address;
                            TextBoxTelephone.Text = "" + sm.Telephone;
                            TextBoxPosition.Text = sm.Position;
                        }
                    }
                    playerlist = FileIO.ReadFile(Server.MapPath("~/App_Data/playerlistfile.ser"));
                    ListBoxReadPlayer.Items.Clear();
                    for (int i = 0; i < playerlist.Count; i++)
                    {
                        ListBoxReadPlayer.Items.Add(((Footballplayer)playerlist[i]).ToString());
                    }
                    ListBoxReadStaff.Items.Clear();
                    for (int i = 0; i < stafflist.Count; i++)
                    {
                        ListBoxReadStaff.Items.Add(((Staffmember)stafflist[i]).ToString());
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
            stafflist = (ArrayList)Application.Get("stafflist");
            for (int i = stafflist.Count - 1; i >= 0; i--)
            {
                if (((Staffmember)stafflist[i]).Name == sm.Name && ((Staffmember)stafflist[i]).Password == sm.Password)
                {
                    ((Staffmember)stafflist[i]).Name = TextBoxName.Text;
                    ((Staffmember)stafflist[i]).Address = TextBoxAddress.Text;
                    ((Staffmember)stafflist[i]).Telephone = Convert.ToInt32(TextBoxTelephone.Text);
                    ((Staffmember)stafflist[i]).Position = TextBoxPosition.Text;
                    Session["staff"] = (Staffmember)stafflist[i];
                }
            }
            Application.Set("stafflist", stafflist);
            FileIO.WriteFile(stafflist, Server.MapPath("~/App_Data/stafflistfile.ser"));
        }

        protected void ButtonChangePass_Click(object sender, EventArgs e)
        {
            bool passChanged = false;
            stafflist = (ArrayList)Application.Get("stafflist");
            for (int i = stafflist.Count - 1; i >= 0; i--)
            {
                if (((Staffmember)stafflist[i]).Name == sm.Name && ((Staffmember)stafflist[i]).Password == sm.Password)
                {
                    passChanged = ((Staffmember)stafflist[i]).ChangePassword(TextBoxOldPass.Text, TextBoxNewPass.Text);
                    Session["staff"] = (Staffmember)stafflist[i];
                }
            }

            if (passChanged)
            {
                LabelMessage.Text = "You have successfully changed your password";
            }
            else
            {
                LabelMessage.Text = "Error: Your password was not changed: ";

                if (TextBoxOldPass.Text != sm.Password)
                {
                    LabelMessage.Text += "Current Password doesn't match! ";
                }
                if (TextBoxNewPass.Text.Length < 8)
                {
                    LabelMessage.Text += "Password must have at least 8 characters! ";
                }
            }
            Application.Set("stafflist", stafflist);
            FileIO.WriteFile(stafflist, Server.MapPath("~/App_Data/stafflistfile.ser"));
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session["staff"] = null;
            Session["mylevel"] = 0;
            Response.Redirect("Index.aspx");
        }

        protected void ButtonGoToWebmaster_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebMaster.aspx");
        }
    }
}