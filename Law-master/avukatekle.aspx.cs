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
    public partial class WebForm2 : System.Web.UI.Page
    {
        string id;
        string name;
        string surname;
        MySqlConnection connection;
        string server;
        string database;
        string uid;
        string password;
        string gender;
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
            string instruct = "INSERT INTO avukatliste(id,name,surname,gender)Values('" + id + "', '" + name + "','" + surname + "','" + gender + "')";
            MySqlCommand instr = new MySqlCommand(instruct, connection);
            instr.ExecuteNonQuery();
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Operation completed.');</script>");


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            id = TextBox1.Text;

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            name = TextBox2.Text;

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            surname = TextBox3.Text;
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "kadın";
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "erkek";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/avukattanım.aspx");

        }
    }
}