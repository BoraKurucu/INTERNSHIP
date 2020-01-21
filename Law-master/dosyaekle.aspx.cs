using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using MySql.Data;
namespace AvukatTakip
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        MySqlConnection connection;
        string server;
        string database;
        string uid;
        string password;
        
        protected void Page_Load(object sender, EventArgs e)
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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/dosya.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string instruct = "INSERT INTO durum(id,ad,makam,avukat,durum)Values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text+ "')";
            MySqlCommand instr = new MySqlCommand(instruct, connection);
            instr.ExecuteNonQuery();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Operation completed.');</script>");
        }
    }
}