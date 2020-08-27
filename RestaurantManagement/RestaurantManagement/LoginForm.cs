using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // for mysql databse connection..

namespace RestaurantManagement
{
    public partial class LoginForm : Form 
    {
       

        public LoginForm()
        {
            InitializeComponent();
            
            // turning off autosize of textbox_password...
            this.TextBox_Password.AutoSize = false;
            // define here the size of TextBox_Password manually..
            this.TextBox_Password.Size = new Size(this.TextBox_Password.Size.Width , 53) ;
        }

        private void Design_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        // This is the exit button of main page..
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ComboBox_SelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            // These are the Text box and combobox stuffs...

            string username = TextBox_UserName.Text;
            string password = TextBox_Password.Text;
            string usertype = ComboBox_SelectUser.Text;


            // from here databse connection starts..

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE username = @usn and password = @pass and usertype = @type" , db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = usertype;

            adapter.SelectCommand = command;

            adapter.Fill(table);
            // here ends database things.

            if (usertype == "Manager")
            {
                if (table.Rows.Count > 0)
                {
                   // MessageBox.Show("Manager Login Successful");
                    this.Hide();
                    ManagerForm managerform = new ManagerForm();
                    managerform.Show();
                    // from here we are going to manager page..
                }
                else
                {
                    MessageBox.Show("Manager Login Unsuccessful");
                    TextBox_UserName.Clear();
                    TextBox_Password.Clear();
                }
            }
            else if (usertype == "Admin")
            {
                if (table.Rows.Count > 0)
                {
                    //MessageBox.Show("Admin Login Successful");

                    this.Hide();
                    AdminForm adminform = new AdminForm();
                    adminform.Show();

                    // from here we are going to admin page..

                }
                else
                {
                    MessageBox.Show("Admin Login Unsuccessful");
                    TextBox_UserName.Clear();
                    TextBox_Password.Clear();
                }
            }
        }

        private void Button_Exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
