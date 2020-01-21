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
    public partial class WebForm7 : System.Web.UI.Page
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
                bindGrid();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/adminpage.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/durumekle.aspx");

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

            string Text = "SELECT * FROM durum";
            MySqlCommand cmd = new MySqlCommand(Text, connection);

            MySqlDataReader rd = cmd.ExecuteReader();
            Grid1.DataSource = rd;
            Grid1.DataBind();
            connection.Close();




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

            string Text = "DELETE FROM durum WHERE Id = @id1";
            MySqlCommand cmd = new MySqlCommand(Text, connection);
            cmd.Parameters.AddWithValue("@id1", l1.Text);
            cmd.ExecuteNonQuery();
            bindGrid();


        }

        protected void Grid1_RowEditing(Object sender, GridViewEditEventArgs e)
        {


            Grid1.EditIndex = e.NewEditIndex;
            TextBox1.Visible = true;
           
            Grid1.Visible = false;
            Button3.Visible = true;
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Enter the new name!');</script>");

            bindGrid();


        }
        protected void Grid1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
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

            MySqlDataAdapter adapt = new MySqlDataAdapter("SELECT id,status from durum", connection);
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
           
            Button2.Visible = true;


            //updating the record  
            MySqlCommand cmd = new MySqlCommand("Update durum set status='" + name +  "' where ID=" + Convert.ToInt32(l1.Text), connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            Grid1.EditIndex = -1;
            //Call ShowData method for displaying updated data  
            Show();


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Visible = false;

            Grid1.Visible = true;
            Button3.Visible = false;
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Click the update button!');</script>");

        }
    }
}