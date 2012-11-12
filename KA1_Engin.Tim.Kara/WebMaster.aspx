<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebMaster.aspx.cs" Inherits="KA1_Engin.Tim.Kara.WebMaster" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Webmaster Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left: 200px; height: 864px;">
    
        <asp:Panel ID="PanelWebmaster" runat="server" BackColor="#CCCCCC" BorderColor="Gray" 
            BorderStyle="Outset" HorizontalAlign="Center"
            Height="850px" Width="1050px">
            <br />
            <asp:Label ID="LabelWebmaster" runat="server" Font-Bold="True" 
                Font-Italic="True" Font-Size="Large" Text="Webmaster Page"></asp:Label>
            <br />
            <br />
            <asp:Label ID="LabelNewPerson" runat="server" Text="Create new: "></asp:Label>
            &nbsp;&nbsp;<asp:RadioButton ID="RadioButtonPlayer" runat="server" 
                AutoPostBack="True" Checked="True" GroupName="Person" Text="Football player" />
            &nbsp;<asp:RadioButton ID="RadioButtonStaff" runat="server" AutoPostBack="True" 
                GroupName="Person" Text="Staff member" />
            <br />
            <asp:Label ID="LabelUserlevel" runat="server" Text="User level: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButtonUserlevel1" runat="server" AutoPostBack="True" 
                Font-Italic="False" GroupName="Level" Text="1" />
            &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:RadioButton ID="RadioButtonUserlevel2" runat="server" AutoPostBack="True" 
                Font-Italic="False" GroupName="Level" Text="2" />
            &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:RadioButton ID="RadioButtonUserlevel3" runat="server" AutoPostBack="True" 
                Font-Italic="False" GroupName="Level" Text="3" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <br />
            <asp:Label ID="LabelName" runat="server" Text="Name: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxName" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelAddress" runat="server" Text="Address: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxAddress" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelTelephone" runat="server" Text="Telephone: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxTelephone" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelPassword" runat="server" Text="Password: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBoxPassword" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelPlayer_number" runat="server" Text="Player no: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxPlayer_number" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelHeight" runat="server" Text="Height: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxHeight" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelWeight" runat="server" Text="Weight: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxWeight" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelAge" runat="server" Text="Age: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxAge" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelPosition" runat="server" Text="Position: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxPosition" runat="server" Width="200px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButtonCreate" runat="server" Text="Create" 
                onclick="ButtonCreate_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="ButtonSave" runat="server" onclick="ButtonSave_Click" 
                Text="Save" />
            <br />
            <br />
            <asp:Label ID="LabelMessage" runat="server" Font-Bold="False" 
                Font-Italic="True" Font-Size="Medium"></asp:Label>
            <br />
            <asp:ListBox ID="ListBoxCreate" runat="server" Width="1000px" Height="80px"></asp:ListBox>
            <br />
            <asp:Label ID="LabelReadPlayerlist" runat="server" 
                Text="List over Football player: "></asp:Label>
            <br />
            <asp:ListBox ID="ListBoxReadPlayer" runat="server" Width="1000px" 
                Height="100px"></asp:ListBox>
            <br />
            <asp:Label ID="LabelReadStafflist" runat="server" 
                Text="List over Staff member:"></asp:Label>
            <br />
            <asp:ListBox ID="ListBoxReadStaff" runat="server" Width="1000px" Height="100px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="ButtonGoToStaff" runat="server" onclick="ButtonGoToStaff_Click" 
                Text="Go to staff member page" />
            <br />
            <br />
            <asp:Button ID="ButtonLogout" runat="server" onclick="ButtonLogout_Click" 
                Text="Log Out" />
            <br />
            <br />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
