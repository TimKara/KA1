<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Guest.aspx.cs" Inherits="KA1_Engin.Tim.Kara.Guest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Guest Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left: 200px;">
    
        <asp:Panel ID="PanelGuest" runat="server" BackColor="#E9D2FF" 
            BorderColor="#9966FF" BorderStyle="Outset" HorizontalAlign="Center" 
            Height="350px" Width="1050px">
            <asp:Label ID="LabelGuest" runat="server" Font-Bold="True" Font-Italic="True" 
                Font-Size="Large" Text="Guest Page"></asp:Label>
            <br />
            <br />
            <asp:Label ID="LabelPlayerlist" runat="server" 
                Text="List over Football player:"></asp:Label>
            <br />
            &nbsp;
            <asp:ListBox ID="ListBoxGuest" runat="server" Height="230px" Width="1000px">
            </asp:ListBox>
            <br />
            <br />
            <asp:Button ID="ButtonBack" runat="server" Text="Back" 
                onclick="ButtonBack_Click" />
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
