using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Net.Mail;
using System.Text;
using System.Data.SqlClient;


namespace AvukatTakip
{
    public partial class WebForm4 : System.Web.UI.Page
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
        bool tickled = false;
        public static int number = 5;
        string userPassword = "null";
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox6.Visible = false;
            Label2.Visible = false;
            TextBox5.Visible = false;
            Button2.Visible = false;
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
            if (TextBox2.Text == TextBox3.Text)
            {
               
                    TextBox6.Text = TextBox2.Text;

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Please type the code sent to your mail!.');</script>");
                    Random random = new Random();
                    number = random.Next(100000, 999999);
                    MailMessage mailMessage = new MailMessage();



                    mailMessage.From = new MailAddress("borakurucu11y@gmail.com");
                    mailMessage.To.Add(TextBox4.Text);
                    mailMessage.Subject = "StratekLaw Kayıt";
                    mailMessage.Body = "You access code is \n" + number + "\n type it in the sign up screen";
                    mailMessage.IsBodyHtml = true;





                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = new System.Net.NetworkCredential("borakurucu11y@gmail.com", "bulbul70");


                    smtp.Send(mailMessage);
                



                Label2.Visible = true;
                TextBox5.Visible = true;
                Button2.Visible = true;
                Button1.Visible = false;
                tickled = true;
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Passwords does not match!');</script>");

            }


        }
        public void sendEmail(string body)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {


            if (TextBox5.Text == number + "")
            {
                string instruct = "INSERT INTO users(username,password)Values('" + TextBox1.Text + "', '" + TextBox6.Text + "')";
                MySqlCommand instr = new MySqlCommand(instruct, connection);
                instr.ExecuteNonQuery();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('You succesfully signep up!.');</script>");
                Response.Redirect("~/login.aspx");

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Verification code is wrong');</script>");
            }

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}