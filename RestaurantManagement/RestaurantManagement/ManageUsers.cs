using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RestaurantManagement
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();

            LoadDataIntoGridView();

        }

        private void LoadDataIntoGridView()
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from users";

            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);

            DataGridView_UserList.DataSource = dtRecords;
            con.Close();
        }

        private void Label_Heading_Click(object sender, EventArgs e)
        {

        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminform = new AdminForm();
            adminform.Show();
        }

        private void PictureBox_UserName_Click(object sender, EventArgs e)
        {

        }

        private void Button_Insert_Click(object sender, EventArgs e)
        {
            // These are the Text box and combobox stuffs...

            string username = TextBox_UserName.Text;
            string password = TextBox_Password.Text;
            string usertype = ComboBox_SelectUser.Text;


            // from here databse connection starts..

            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());

            con.Open();

            MySqlCommand cmd;

            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT into users(username , password , usertype)VALUES(@name,@pass,@type)";
            cmd.Parameters.AddWithValue("@name", username);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@type", usertype);
            cmd.ExecuteNonQuery();

            con.Close();
            // This is for show grid..
            LoadDataIntoGridView() ;
            ClearBoxes();
            MessageBox.Show("User is successfully inserted");

        }

        private void Label_UserType_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_Remove_Click(object sender, EventArgs e)
        {
            string username = TextBox_UserName.Text;
            string password = TextBox_Password.Text;
            string usertype = ComboBox_SelectUser.Text;


            // from here databse connection starts..

            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());

            con.Open();

            MySqlCommand cmd;

            cmd = con.CreateCommand();
            cmd.CommandText = "delete from users where username='"+username+"' and usertype='"+usertype+"'";
            //cmd.Parameters.AddWithValue("@name", username);
            //cmd.Parameters.AddWithValue("@pass", password);
            //cmd.Parameters.AddWithValue("@type", usertype);
            cmd.ExecuteNonQuery();

            con.Close();
            // This is for show grid..
            LoadDataIntoGridView();
            ClearBoxes();
            MessageBox.Show("User is successfully deleted!");
        }
        void ClearBoxes()
        {
            TextBox_UserName.Clear();
            TextBox_Password.Clear();
            //ComboBox_SelectUser.Clear();
        }

        private void DataGridView_UserList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TextBox_UserName.Text = DataGridView_UserList.SelectedRows[0].Cells[1].Value.ToString();
            ComboBox_SelectUser.Text = DataGridView_UserList.SelectedRows[0].Cells[3].Value.ToString();
            //ComboBox_ItemType.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
