<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="KA1_Engin.Tim.Kara.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Index</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left: 200px" >
    
        <asp:Panel ID="PanelIndex" runat="server" BackColor="#99CCFF" 
            BorderColor="#3366FF" BorderStyle="Outset" HorizontalAlign="Center"
            Height="200px" Width="300px">
            <br />
            <asp:Label ID="LabelLogin" runat="server" Font-Bold="True" Font-Italic="True" 
                Font-Size="Large" Text="Index Page - Login"></asp:Label>
            <br />
            &nbsp; &nbsp;<br />
            <asp:Label ID="LabelName" runat="server" Font-Italic="False" Text="Name: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxName" runat="server" Width="160px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelPass" runat="server" Font-Italic="False" Text="Password: "></asp:Label>
            &nbsp;<asp:TextBox ID="TextBoxPass" runat="server" style="margin-bottom: 0px" 
                TextMode="Password" Width="160px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonLogin" runat="server" Text="Log In" Font-Bold="False" 
                Font-Italic="False" onclick="ButtonLogin_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonGuest" runat="server" Font-Bold="False" Font-Italic="False" 
                onclick="ButtonGuest_Click" Text="Guest" />
            <br />
            <asp:Label ID="LabelMessage" runat="server" Font-Bold="False" 
                Font-Italic="True" Font-Size="Medium" Font-Underline="True" ForeColor="#CC0000"></asp:Label>
            <br />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
