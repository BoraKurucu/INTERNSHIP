<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="AvukatTakip.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome to Stratek Law</div>
        <p>
            Username&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Password&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
        </p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/sign up.aspx">Dont have an account? Sign up!</asp:HyperLink>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </form>
</body>
</html>
