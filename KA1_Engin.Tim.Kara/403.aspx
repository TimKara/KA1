<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="403.aspx.cs" Inherits="KA1_Engin.Tim.Kara._403" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>403 - Error page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left: 200px; ">
    
        <asp:Panel ID="Panel403" runat="server" BackColor="#FFCC99" BorderColor="#CC0000" 
            BorderStyle="Outset"  style="margin-bottom: 4px" HorizontalAlign="Center"
            Height="120px" Width="520px">
            <br />
            <asp:Label ID="Label403" runat="server" Text="403 Error" 
                Font-Bold="True" Font-Italic="False" Font-Size="XX-Large" Font-Underline="False" 
                ForeColor="Black"></asp:Label>
            <br />
            <asp:Label ID="LabelErrorMessage" runat="server" Font-Bold="True" 
                Font-Italic="True" Font-Size="XX-Large" Font-Underline="False" 
                ForeColor="Black" Text="You don't have access to this page!"></asp:Label>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
