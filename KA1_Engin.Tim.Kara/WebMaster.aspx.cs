using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace KA1_Engin.Tim.Kara
{
    public partial class WebMaster : System.Web.UI.Page
    {
        // level 0 = guest, level 1 = footballplayer, level 2 = staffmember & level 3 = webmaster.
        private int userlevel;
        private ArrayList playerlist, stafflist;
        private Footballplayer fp;
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
                if (userlevel == 3)
                {
                    if (RadioButtonPlayer.Checked)
                    {
                        TextBoxPosition.Enabled = false;
                        TextBoxPlayer_number.Enabled = true;
                        TextBoxHeight.Enabled = true;
                        TextBoxWeight.Enabled = true;
                        TextBoxAge.Enabled = true;
                        RadioButtonUserlevel1.Checked = true;
                        RadioButtonUserlevel2.Checked = false;
                        RadioButtonUserlevel3.Checked = false;
                    }
                    else
                    {
                        TextBoxPosition.Enabled = true;
                        TextBoxPlayer_number.Enabled = false;
                        TextBoxHeight.Enabled = false;
                        TextBoxWeight.Enabled = false;
                        TextBoxAge.Enabled = false;
                        RadioButtonUserlevel2.Checked = true;
                        RadioButtonUserlevel1.Checked = false;
                    }

                    if (RadioButtonUserlevel3.Checked)
                    {
                        userlevel = 3;
                        LabelMessage.Text = "Info: Select only User Level 3 if the person must have access to Webmaster page";
                    }
                    else if (RadioButtonUserlevel2.Checked)
                    {
                        userlevel = 2;
                        LabelMessage.Text = "";
                    }
                    else
                    {
                        userlevel = 1;
                        LabelMessage.Text = "";
                    }

                    try
                    {
                        playerlist = (ArrayList)Application.Get("myplayerlist");
                        if (playerlist == null)
                        {
                            playerlist = FileIO.ReadFile(Server.MapPath("~/App_Data/playerlistfile.ser"));
                            Application.Set("myplayerlist", playerlist);
                        }

                        stafflist = (ArrayList)Application.Get("mystafflist");
                        if (stafflist == null)
                        {
                            stafflist = FileIO.ReadFile(Server.MapPath("~/App_Data/stafflistfile.ser"));
                            Application.Set("mystafflist", stafflist);
                            //Cowboy fix for the "personid" problem..
                            Person p = new Person("", "", 0, "", 0);
                            p.Personid = stafflist.Count + stafflist.Count;
                        }

                        LoadPlayerListBox();
                        LoadStaffListBox();
                    }
                    catch
                    {
                        if (playerlist == null)
                        {
                            playerlist = new ArrayList();
                        }

                        if (stafflist == null)
                        {
                            stafflist = new ArrayList();
                        }

                        LabelMessage.Text = "Error: NO Data to load!";
                    }
                }
                else
                {
                    Response.Redirect("403.aspx");
                }
            }
        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (RadioButtonPlayer.Checked)
                {
                    fp = new Footballplayer(TextBoxName.Text, TextBoxAddress.Text, Convert.ToInt32(TextBoxTelephone.Text), TextBoxPassword.Text, userlevel, Convert.ToInt32(TextBoxPlayer_number.Text), Convert.ToInt32(TextBoxHeight.Text), Convert.ToInt32(TextBoxWeight.Text), Convert.ToInt32(TextBoxAge.Text));
                    playerlist.Add(fp);

                    Application.Set("myplayerlist", playerlist);

                    ListBoxCreate.Items.Clear();
                    for (int i = 0; i < playerlist.Count; i++)
                    {
                        ListBoxCreate.Items.Add(((Footballplayer)playerlist[i]).ToString());
                    }

                    TextBoxName.Text = "";
                    TextBoxAddress.Text = "";
                    TextBoxTelephone.Text = "";
                    TextBoxPassword.Text = "";
                    TextBoxPlayer_number.Text = "";
                    TextBoxHeight.Text = "";
                    TextBoxWeight.Text = "";
                    TextBoxAge.Text = "";

                    LabelMessage.Text = "New Football player created";
                }
                else
                {                  
                    sm = new Staffmember(TextBoxName.Text, TextBoxAddress.Text, Convert.ToInt32(TextBoxTelephone.Text), TextBoxPassword.Text, userlevel, TextBoxPosition.Text);
                    stafflist.Add(sm);

                    Application.Set("mystafflist", stafflist);

                    ListBoxCreate.Items.Clear();
                    for (int i = 0; i < stafflist.Count; i++)
                    {
                        ListBoxCreate.Items.Add(((Staffmember)stafflist[i]).ToString());
                    }

                    TextBoxName.Text = "";
                    TextBoxAddress.Text = "";
                    TextBoxTelephone.Text = "";
                    TextBoxPassword.Text = "";
                    TextBoxPosition.Text = "";

                    LabelMessage.Text = "New Staff member created";
                }
            }
            catch
            {
                LabelMessage.Text = "New person NOT created!";
            }
        }

        public void LoadPlayerListBox()
        {
            ListBoxReadPlayer.Items.Clear();
            for (int i = 0; i < playerlist.Count; i++)
            {
                ListBoxReadPlayer.Items.Add(((Footballplayer)playerlist[i]).ToString());
            }
        }

        public void LoadStaffListBox()
        {
            ListBoxReadStaff.Items.Clear();
            for (int i = 0; i < stafflist.Count; i++)
            {
                ListBoxReadStaff.Items.Add(((Staffmember)stafflist[i]).ToString());
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            playerlist = (ArrayList)Application.Get("myplayerlist");
            FileIO.WriteFile(playerlist, Server.MapPath("~/App_Data/playerlistfile.ser"));
            stafflist = (ArrayList)Application.Get("mystafflist");
            FileIO.WriteFile(stafflist, Server.MapPath("~/App_Data/stafflistfile.ser"));
            LabelMessage.Text = "Data saved in App_Data/playerlistfile.ser & App_Data/stafflistfile.ser";

            LoadPlayerListBox();
            LoadStaffListBox();
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session["staff"] = null;
            Session["mylevel"] = 0;
            Response.Redirect("Index.aspx");
        }

        protected void ButtonGoToStaff_Click(object sender, EventArgs e)
        {
            Response.Redirect("Staff.aspx");
        }
    }
}