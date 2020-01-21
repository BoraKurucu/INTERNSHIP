<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dosya.aspx.cs" Inherits="AvukatTakip.WebForm9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <asp:GridView ID="Grid1" runat="server" AutoGenerateColumns ="false" OnRowDeleting ="Grid1_RowDeleting" onRowEditing ="Grid1_RowEditing" onRowUpdating ="Grid1_RowUpdating" OnSelectedIndexChanged="Grid1_SelectedIndexChanged">
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
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back" />
        </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add File" />
         <br />
         <br />
         <br />
         <asp:TextBox ID="TextBox1" runat="server" Height="44px" Width="149px">Enter the new name</asp:TextBox>
         <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Save the new name" />
         <br />
         <br />
         <asp:TextBox ID="TextBox2" runat="server" Height="43px" Width="149px">Enter the new location</asp:TextBox>
         <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Save the new location" />
         <br />
         <br />
         <br />
&nbsp;
         <br />
         <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
         </asp:DropDownList>
         <asp:Button ID="Button5" runat="server" Text="Save the new lawyer" OnClick="Button5_Click" />
         <br />
         <br />
         <br />
         <br />
         <asp:DropDownList ID="DropDownList2" runat="server">
         </asp:DropDownList>
         <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Save the new status" />
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
         <br />
    </form>
</body>
</html>
