<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Player.aspx.cs" Inherits="KA1_Engin.Tim.Kara.Player" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Football player Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left: 200px">
    
        <asp:Panel ID="PanelPlayer" runat="server" BackColor="#D6FFC1" 
            BorderColor="#009933" BorderStyle="Outset" HorizontalAlign="Center" 
            Height="550px" Width="450px">
            <br />
            <asp:Label ID="LabelPlayer" runat="server" Font-Bold="True" Font-Italic="True" 
                Font-Size="Large" Text="Football player Page"></asp:Label>
            <br />
            <br />
            <asp:Label ID="LabelMessage" runat="server" Font-Italic="True"></asp:Label>
            <br />
            <br />
            <asp:Label ID="LabelName" runat="server" Text="Name: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxName" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelAddress" runat="server" Text="Address: "></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxAddress" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelTelephone" runat="server" Text="Telephone: "></asp:Label>
            &nbsp;<asp:TextBox ID="TextBoxTelephone" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelPlayer_number" runat="server" Text="Player no: "></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBoxPlayer_number" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelHeight" runat="server" Text="Height: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxHeight" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelWeight" runat="server" Text="Weight: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxWeight" runat="server" Width="200px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelAge" runat="server" Text="Age: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxAge" runat="server" Width="200px"></asp:TextBox>
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
            &nbsp;&nbsp;
            <br />
            <asp:Button ID="ButtonChangePass" runat="server" 
                onclick="ButtonChangePass_Click" Text="Change Password" />
            <br />
            <br />
            <asp:Button ID="ButtonLogout" runat="server" onclick="ButtonLogout_Click" 
                Text="Log Out" />
            <br />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
