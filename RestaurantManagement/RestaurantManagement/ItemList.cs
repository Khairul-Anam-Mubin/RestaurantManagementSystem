using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.IO;
namespace RestaurantManagement
{
    public partial class ItemList : Form
    {
        string Query = "Select item_image , item_price ,item_name from items";
        public ItemList()
        {
            InitializeComponent();
            LoadDataIntoGridView();

        }

        private void ItemList_Load(object sender, EventArgs e)
        {

        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm managerForm = new ManagerForm();
            managerForm.Show();
        }

        private void Label_Heading_Click(object sender, EventArgs e)
        {
            Query = "Select item_image , item_price ,item_name from items";
            LoadDataIntoGridView();
        }



        private void LoadDataIntoGridView()
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = Query;

            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dataGridView1.DataSource = dtRecords;

            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[0];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.RowTemplate.Height = 80;
            con.Close();
        }

        private void Button_Beriyani_Click(object sender, EventArgs e)
        {
            //string Beriyani = "Beriyani"; 
            Query = "select item_image , item_price , item_name from items where item_type = 'Beriyani'";
            LoadDataIntoGridView();
        }

        private void Button_Kacchi_Click(object sender, EventArgs e)
        {
            Query = "select item_image , item_price , item_name from items where item_type = 'Kacchi'";
            LoadDataIntoGridView();
        }

        private void Button_Rice_Click(object sender, EventArgs e)
        {
            Query = "select item_image , item_price , item_name from items where item_type = 'Rice'";
            LoadDataIntoGridView();
        }

        private void Button_Chicken_Click(object sender, EventArgs e)
        {
            Query = "select item_image , item_price , item_name from items where item_type = 'Chicken'";
            LoadDataIntoGridView();
        }

        private void Button_Beef_Click(object sender, EventArgs e)
        {
            Query = "select item_image , item_price , item_name from items where item_type = 'Beef'";
            LoadDataIntoGridView();
        }

        private void Button_Drinks_Click(object sender, EventArgs e)
        {
            Query = "select item_image , item_price , item_name from items where item_type = 'Drinks'";
            LoadDataIntoGridView();
        }
    }
}
