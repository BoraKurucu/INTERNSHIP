using System;
using System.Collections.Generic;
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
    public partial class WebForm3 : System.Web.UI.Page
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
            TextBox3.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
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

            String query;
            query = "SELECT * FROM users WHERE username ='" + TextBox1.Text + "' AND password='" + TextBox2.Text + "' ";
            MySqlCommand instr = new MySqlCommand(query, connection);
            MySqlDataReader reader = instr.ExecuteReader();

            int counter = 0;
            while(reader.Read())
            {
                counter = counter + 1;
            }
            if(counter >= 1)
            {
                connection.Close();
                connection.Open();
                string Text = "DELETE FROM current";
                MySqlCommand caro = new MySqlCommand(Text, connection);
                caro.ExecuteNonQuery();

                connection.Close();
                connection.Open();

                string instruct = "INSERT INTO current(id,username,password)Values('" + "1" + "','" + TextBox1.Text + "','" + TextBox2.Text + "')";
                MySqlCommand second = new MySqlCommand(instruct, connection);
                second.ExecuteNonQuery();


                Response.Redirect("~/userpage.aspx");

            }
            connection.Close();
            connection = new MySqlConnection(connectionString);
            connection.Open();

            String adminQuery;
            adminQuery = "SELECT * FROM admins WHERE adminName ='" + TextBox1.Text + "' AND adminPass='" + TextBox2.Text + "' ";
            MySqlCommand adminInstr = new MySqlCommand(adminQuery, connection);
            MySqlDataReader adminReader = adminInstr.ExecuteReader();


            int adminCounter = 0;
            while (adminReader.Read())
            {
                adminCounter = adminCounter + 1;
            }
            if (adminCounter >= 1)
            {
                Response.Redirect("~/adminpage.aspx");

            }


            if(counter < 1 && adminCounter < 1)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Wrong password or username');</script>");

            }



        }
        public string GetName()
        {

            return "";
        }
    }
}