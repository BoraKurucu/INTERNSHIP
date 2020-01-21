<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="durumlar.aspx.cs" Inherits="AvukatTakip.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
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

                     <asp:Label ID = "stbl" runat ="server" Text ='<%# Eval("id") %>' />
                     </ItemTemplate>

                     </asp:TemplateField>

                 <asp:TemplateField HeaderText ="Status">
                 <ItemTemplate>

                     <asp:Label ID = "stbl2" runat ="server" Text ='<%# Eval("status") %>' />
                     </ItemTemplate>

                     </asp:TemplateField>
                 </Columns>
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back" />
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add New Status" />
        </p>
        <asp:TextBox ID="TextBox1" runat="server" Height="74px" Width="156px">Write the new status here</asp:TextBox>
        <asp:Button ID="Button3" runat="server" Text="Save the new status" OnClick="Button3_Click" />
    </form>
</body>
</html>
