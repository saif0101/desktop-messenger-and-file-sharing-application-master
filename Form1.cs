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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login loginform = new login();
            loginform.Show();        
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string username = usertextbox.Text;
                string password = passtextbox.Text;
                string email = emailtextbox.Text;
                string confirmpass = confirmtextbox.Text;

         /*       if (username == "dipto" && password == "12345")
                {
                    this.Hide();
                    
                    
                }
                else
                {
                    MessageBox.Show("Login failed");
                }*/
                   if (!email.Contains("@"))
            {
                emaillabel.ForeColor = Color.Red;
            }
            else
            {
                emaillabel.ForeColor = Color.Blue;
            }

            if (password != confirmpass)
            {
                passwordlabel.ForeColor = Color.Red;
                confirmpasslabel.ForeColor = Color.Red;
            }

            else
            {
                passwordlabel.ForeColor = Color.Blue;
                confirmpasslabel.ForeColor = Color.Blue;
            }
            if (password == confirmpass && email.Contains("@") && username != null)
            {
                SqlConnection connection = new SqlConnection("Data Source=DELL-PC\\SQLEXPRESS; Initial Catalog=RegistrationDb; Integrated Security=true");

                connection.Open();

                //Console.WriteLine(connection.State);

                String insertString = "insert into Rgtable(username,email,password,confirmpass) values ('" + username + "','" + email + "','" + password + "','"+confirmpass+"')";

                SqlCommand insertCommand = new SqlCommand(insertString, connection);

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("your registration is completed  ");



            }
        }
            
            }

        private void button3_Click(object sender, EventArgs e)
        {

        }
      



            }
        }
    

