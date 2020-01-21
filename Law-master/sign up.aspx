<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sign up.aspx.cs" Inherits="AvukatTakip.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Sign up!"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
            Username&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Password&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox6_TextChanged" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            Retype the password&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            Email&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Enter the verification code"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Sign up" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign Up" />
        </p>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </form>
</body>
</html>
