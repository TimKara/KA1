<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="KA1_Engin.Tim.Kara.Staff" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff member Page</title>
</head>
<body style="height: 838px; width: 1271px">
    <form id="form1" runat="server">
    <div style="margin-left: 200px; height: 770px;">
    
        <asp:Panel ID="PanelStaff" runat="server" BackColor="#FFEFBB" 
            BorderColor="#FF9900" BorderStyle="Outset" HorizontalAlign="Center" 
            Height="770px" Width="1050px">
            <br />
            <asp:Label ID="LabelStaff" runat="server" Font-Bold="True" Font-Italic="True" 
                Font-Size="Large" Text="Staff member Page"></asp:Label>
            <br />
            <br />
            <asp:Label ID="LabelMessage" runat="server" Font-Italic="True"></asp:Label>
            <br />
            <br />
            <asp:Label ID="LabelName" runat="server" Text="Name: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxName" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelAddress" runat="server" Text="Address: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxAddress" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelTelephone" runat="server" Text="Telephone: "></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxTelephone" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelPosition" runat="server" Text="Position: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxPosition" runat="server" Width="200px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButtonUpdate" runat="server" onclick="ButtonUpdate_Click" 
                Text="Update" />
            <br />
            <br />
            <asp:Label ID="LabelChangePass" runat="server" Text="Change Password: "></asp:Label>
            <br />
            <br />
            <asp:Label ID="LabelOldPass" runat="server" Text="Current Password: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxOldPass" runat="server" TextMode="Password" 
                Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelNewPass" runat="server" Text="Enter New Password: "></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="TextBoxNewPass" runat="server" TextMode="Password" 
                Width="200px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="ButtonChangePass" runat="server" 
                onclick="ButtonChangePass_Click" Text="Change Password" />
            <br />
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
            <asp:Button ID="ButtonGoToWebmaster" runat="server" 
                onclick="ButtonGoToWebmaster_Click" Text="Go to webmaster page" />
            <br />
            <br />
            <asp:Button ID="ButtonLogout" runat="server" onclick="ButtonLogout_Click" 
                Text="Log Out" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
