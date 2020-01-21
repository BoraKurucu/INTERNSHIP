using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace AvukatTakip
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        string id = "5";
        string name = "ali";
        MySqlConnection connection;
        string server;
        string database;
        string uid;
        string password;
        private string connectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Grid1.Visible = true;
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                DropDownList1.Visible = false;
                DropDownList2.Visible = false;
                Button3.Visible = false;
                Button4.Visible = false;
                Button5.Visible = false;
                Button6.Visible = false;
                Button2.Visible = true;


                bindGrid();
            }
        }
        private void bindGrid()
        {
           

            server = "localhost";
            database = "avukat";
            uid = "root";
            password = "haxorus1?asdas";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            string Text = "SELECT * FROM dosya";
            MySqlCommand cmd = new MySqlCommand(Text, connection);

            MySqlDataReader rd = cmd.ExecuteReader();
            Grid1.DataSource = rd;
            Grid1.DataBind();
       

            connection.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/adminpage.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/dosyaekle.aspx");

        }
        protected void Grid1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            Label l1 = Grid1.Rows[e.RowIndex].FindControl("stbl") as Label;

            server = "localhost";
            database = "avukat";
            uid = "root";
            password = "haxorus1?asdas";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            string Text = "DELETE FROM dosya WHERE id = @id1";
            MySqlCommand cmd = new MySqlCommand(Text, connection);
            cmd.Parameters.AddWithValue("@id1", l1.Text);
            cmd.ExecuteNonQuery();
            bindGrid();


        }

        protected void Grid1_RowEditing(Object sender, GridViewEditEventArgs e)
        {
            Grid1.EditIndex = e.NewEditIndex;

            
            Button2.Visible = false;

            Grid1.Visible = false;
            TextBox1.Visible = true;
            TextBox2.Visible = false;
            DropDownList1.Visible = false;
            DropDownList2.Visible = false;
            Button3.Visible = true;
            Button4.Visible = false;
            Button5.Visible = false;
            Button6.Visible = false;
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Enter the new name!');</script>");


            bindGrid();

        }
        protected void Grid1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            Grid1.EditIndex = -1;
            Show();
        }
        protected void Show()
        {
            server = "localhost";
            database = "avukat";
            uid = "root";
            password = "haxorus1?asdas";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
            connection.Open();

            DataTable dt = new DataTable();

            MySqlDataAdapter adapt = new MySqlDataAdapter("SELECT id,ad,makam,avukat,durum from dosya", connection);
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Grid1.DataSource = dt;
                Grid1.DataBind();
            }
            connection.Close();
        }

        protected void Grid1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {

            server = "localhost";
            database = "avukat";
            uid = "root";
            password = "haxorus1?asdas";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";



            Label l1 = Grid1.Rows[e.RowIndex].FindControl("stbl") as Label;

            connection = new MySqlConnection(connectionString);
            connection.Open();

            string name = TextBox1.Text;
            string location = TextBox2.Text;
            string avukat = DropDownList1.SelectedItem.Text;
            string durum = DropDownList2.SelectedItem.Text;


            Button2.Visible = true;


            //updating the record  
            MySqlCommand cmd = new MySqlCommand("Update dosya set ad='" + name + "',makam='" + location + "',avukat='" + avukat + "',durum='"+durum + "' where ID=" + Convert.ToInt32(l1.Text), connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            Grid1.EditIndex = -1;
            //Call ShowData method for displaying updated data  
            Show();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            server = "localhost";
            database = "avukat";
            uid = "root";
            password = "haxorus1?asdas";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);

            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT id,name FROM avukatliste", connection);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DropDownList1.DataSource = dt;
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
            }
            Grid1.Visible = false;
            TextBox1.Visible = false;
            TextBox2.Visible = true;
            DropDownList1.Visible = false;
            DropDownList2.Visible = false;
            Button3.Visible = false;
            Button4.Visible = true;
            Button5.Visible = false;
            Button6.Visible = false;
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Enter the new location!');</script>");

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            server = "localhost";
            database = "avukat";
            uid = "root";
            password = "haxorus1?asdas";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);

            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT id,status FROM durum", connection);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DropDownList2.DataSource = dt;
                DropDownList2.DataTextField = "status";
                DropDownList2.DataValueField = "id";
                DropDownList2.DataBind();
            }
            Grid1.Visible = false;
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            DropDownList1.Visible = true;
            DropDownList2.Visible = false;
            Button3.Visible = false;
            Button4.Visible = false;
            Button5.Visible = true;
            Button6.Visible = false;
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Enter the new lawyer!');</script>");

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Grid1.Visible = false;
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            DropDownList1.Visible = false;
            DropDownList2.Visible = true;
            Button3.Visible = false;
            Button4.Visible = false;
            Button5.Visible = false;
            Button6.Visible = true;
        }

        protected void Grid1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Button2.Visible = true;
            Grid1.Visible = true;
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            DropDownList1.Visible = false;
            DropDownList2.Visible = false;
            Button3.Visible = false;
            Button4.Visible = false;
            Button5.Visible = false;
            Button6.Visible = false;
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Press update!');</script>");

        }
    }
}