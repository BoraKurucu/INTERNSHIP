  <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="avukattanım.aspx.cs" Inherits="AvukatTakip.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Back" />
            <br />
            <br />
            <br />
            <br />
            </div>
        <asp:GridView ID="Grid1" runat="server" AutoGenerateColumns ="false" OnRowDeleting ="Grid1_RowDeleting" onRowEditing ="Grid1_RowEditing" onRowUpdating ="Grid1_RowUpdating">
            <Columns>
             <asp:TemplateField HeaderText ="İşem 1">
                 <ItemTemplate>

                     <asp:Button ID ="b1" runat ="server" CommandName ="Delete" Text ="Delete" />

                     </ItemTemplate>

                     </asp:TemplateField>

                 <asp:TemplateField>  
                    <ItemTemplate>  
                        <asp:Button ID="btn_Edit" runat="server" Text="Edit" CommandName="Edit" />  

                    </ItemTemplate>  
                    <EditItemTemplate>  
                           <asp:Button ID="btn_Update" runat="server" Text="Update" CommandName="Update"/> 
                         <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" CommandName="Cancel"/>  
                    </EditItemTemplate>  
                </asp:TemplateField>  

                 <asp:TemplateField HeaderText ="ID">
                 <ItemTemplate>

                     <asp:Label ID = "stbl" runat ="server" Text ='<%# Eval("Id") %>' />
                     </ItemTemplate>

                     </asp:TemplateField>

                 <asp:TemplateField HeaderText ="Name">
                 <ItemTemplate>

                     <asp:Label ID = "namelbl" runat ="server" Text ='<%# Eval("Name") %>' />
                     </ItemTemplate>

                     </asp:TemplateField>

                <asp:TemplateField HeaderText ="Surname">
                 <ItemTemplate>

                     <asp:Label ID = "namelbl2" runat ="server" Text ='<%# Eval("Surname") %>' />
                     </ItemTemplate>

                     </asp:TemplateField>
                 <asp:TemplateField HeaderText ="Cinsiyet">
                 <ItemTemplate>

                     <asp:Label ID = "namelbl3" runat ="server" Text ='<%# Eval("Gender") %>' />
                     </ItemTemplate>

                     </asp:TemplateField>

            </Columns>
        </asp:GridView>
            <p>
                &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add Lawyer" Height="40px" Width="79px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="79px" OnTextChanged="TextBox1_TextChanged1" style="margin-bottom: 0px" Width="188px">Enter the new name</asp:TextBox>
        &nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Save New Name" />
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" Height="78px" OnTextChanged="TextBox2_TextChanged1" style="margin-bottom: 0px" Width="192px">Enter the new surname</asp:TextBox>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Save New Surname" />
        </p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" Height="74px" OnTextChanged="TextBox3_TextChanged1" Width="184px">Enter the gender</asp:TextBox>
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Save New Gender" />
        </p>
    </form>
</body>
</html>


