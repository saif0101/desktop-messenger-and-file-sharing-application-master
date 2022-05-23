using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace projectMessenger
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;
            Console.WriteLine(username+", "+password);
             SqlConnection connection = new SqlConnection("Data Source=DELL-PC\\SQLEXPRESS;initial Catalog=RegistrationDb;Integrated Security=true");
            connection.Open();
            Console.WriteLine(connection.State);


            SqlCommand selectCommand = new SqlCommand("select * from  Rgtable where username = '"+username+"' and password = '"+password+"'",connection);

            SqlDataReader dataFromDb = selectCommand.ExecuteReader();


            if (dataFromDb.HasRows)
            {
                
                this.Hide();
                Console.Write("got");
                home homefor = new home();
                homefor.Show();
                
            }

            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        }
    }

