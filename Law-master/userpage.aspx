<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userpage.aspx.cs" Inherits="AvukatTakip.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:GridView ID="Grid1" runat="server" AutoGenerateColumns ="false" OnRowDeleting ="Grid1_RowDeleting" onRowEditing ="Grid1_RowEditing" onRowUpdating ="Grid1_RowUpdating">
            <Columns>
                 <asp:TemplateField HeaderText ="ID">
                 <ItemTemplate>

                     <asp:Label ID = "stbl" runat ="server" Text ='<%# Eval("Id") %>' />
                     </ItemTemplate>

                     </asp:TemplateField>

                 <asp:TemplateField HeaderText ="Name">
                 <ItemTemplate>

                     <asp:Label ID = "namelbl" runat ="server" Text ='<%# Eval("Ad") %>' />
                     </ItemTemplate>

                     </asp:TemplateField>

                <asp:TemplateField HeaderText ="Location">
                 <ItemTemplate>

                     <asp:Label ID = "namelbl2" runat ="server" Text ='<%# Eval("Makam") %>' />
                     </ItemTemplate>

                     </asp:TemplateField>
                 <asp:TemplateField HeaderText ="Lawyer">
                 <ItemTemplate>

                     <asp:Label ID = "namelbl3" runat ="server" Text ='<%# Eval("Avukat") %>' />
                     </ItemTemplate>

                     </asp:TemplateField>

                 <asp:TemplateField HeaderText ="Status">
                 <ItemTemplate>

                     <asp:Label ID = "namelbl4" runat ="server" Text ='<%# Eval("Durum") %>' />
                     </ItemTemplate>

                     </asp:TemplateField>



            </Columns>
        </asp:GridView>
        </div>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
         
    </form>
             
</body>
</html>
