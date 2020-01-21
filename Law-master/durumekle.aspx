<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="durumekle.aspx.cs" Inherits="AvukatTakip.WebForm8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
        <br />
        <br />
        <div>
            <asp:TextBox ID="TextBox2" runat="server">Enter the new id</asp:TextBox>
            <br />
            <br />
        </div>
        <asp:TextBox ID="TextBox1" runat="server">Enter the new status</asp:TextBox>
        <br />
        <br />
        <br />
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
        </p>
    </form>
</body>
</html>
