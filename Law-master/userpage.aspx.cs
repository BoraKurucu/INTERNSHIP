using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data.SqlClient;
using System.Data;

namespace AvukatTakip
{
    public partial class WebForm5 : System.Web.UI.Page
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


            string instr = "SELECT username FROM current WHERE  id =  1";
            MySqlCommand cmd2 = new MySqlCommand(instr, connection);
            string name = cmd2.ExecuteScalar().ToString();

           

            connection.Close();
            connection.Open();



            string Text = "SELECT * FROM dosya WHERE ad = '" + name + "'";
            MySqlCommand cmd = new MySqlCommand(Text, connection);
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            Grid1.DataSource = dt;
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

            string Text = "DELETE FROM dosya WHERE id = @id1";
            MySqlCommand cmd = new MySqlCommand(Text, connection);
            cmd.Parameters.AddWithValue("@id1", l1.Text);
            cmd.ExecuteNonQuery();
            bindGrid();


        }

        protected void Grid1_RowEditing(Object sender, GridViewEditEventArgs e)
        {
          
        }
        protected void Grid1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
           
        }
        protected void Show()
        {
            
        }

        protected void Grid1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {

        }


    }
}