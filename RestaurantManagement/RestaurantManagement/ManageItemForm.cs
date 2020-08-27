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
    public partial class ManageItemForm : Form
    {
        string Query = "Select * from items";
        public ManageItemForm()
        {
            InitializeComponent();
            LoadDataIntoGridView();
        }

        private void Button_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image File (*.png;*.jpg;*.bmp;*.gif) | *.png;*.jpg;*.bmp;*.gif";  
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBox_Image.Image = Image.FromFile(ofd.FileName);
            } //else
            //{
            //    PictureBox_Image.Image = Properties.Resources.Foodicon;
            //}
        }

        private void Button_Insert_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            PictureBox_Image.Image.Save(ms, PictureBox_Image.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());

            string query = "insert into restaurant.items(item_name , item_price , item_type , item_image) values(@itname,@itprice,@itype,@img)";

            con.Open();

            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.Add("@itname", MySqlDbType.VarChar,100);
            cmd.Parameters.Add("@itprice", MySqlDbType.Int16);
            cmd.Parameters.Add("@itype", MySqlDbType.VarChar,100);
            cmd.Parameters.Add("@img", MySqlDbType.Blob);

            cmd.Parameters["@itname"].Value = TextBox_ItemName.Text;
            cmd.Parameters["@itprice"].Value = TextBox_Price.Text;
            cmd.Parameters["@itype"].Value = ComboBox_ItemType.Text;
            cmd.Parameters["@img"].Value = img;

            //cmd.ExecuteNonQuery();
            int a = cmd.ExecuteNonQuery();
            if(a == 1)
            {
                TextBox_ItemName.Clear();
                TextBox_Price.Clear();
                //ComboBox_ItemType.Clear();
                PictureBox_Image.Image = Properties.Resources.Foodicon;
                MessageBox.Show("Item Inserted !!");
                LoadDataIntoGridView();
                //this.Hide();
                //ManageItemForm ok = new ManageItemForm() ;
                //ok.Show();
            } else
            {
                MessageBox.Show("Item Not Inserted !!");
            }

            con.Close();

        }

        private void ManageItemPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void LoadDataIntoGridView()
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            con.Open();
            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = Query ;

            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dataGridView1.DataSource = dtRecords;

            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[4];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.RowTemplate.Height = 80;
            con.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ComboBox_ItemType.Text == "Select Item")
                return;
            TextBox_ItemName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            TextBox_Price.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            ComboBox_ItemType.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            PictureBox_Image.Image = GetPhoto((byte [])dataGridView1.SelectedRows[0].Cells[4].Value);
        }

        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            PictureBox_Image.Image.Save(ms, PictureBox_Image.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());

            string query = "update items set item_name = @itname ,item_price = @itprice , item_type = @itype ,item_image = @img where item_id = @id";

            con.Open();

            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.Add("@id", MySqlDbType.Int16);
            cmd.Parameters.Add("@itname", MySqlDbType.VarChar, 100);
            cmd.Parameters.Add("@itprice", MySqlDbType.Int16);
            cmd.Parameters.Add("@itype", MySqlDbType.VarChar, 100);
            cmd.Parameters.Add("@img", MySqlDbType.Blob);
            
            cmd.Parameters["@id"].Value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() ;
            cmd.Parameters["@itname"].Value = TextBox_ItemName.Text;
            cmd.Parameters["@itprice"].Value = TextBox_Price.Text;
            cmd.Parameters["@itype"].Value = ComboBox_ItemType.Text;
            cmd.Parameters["@img"].Value = img;

            //cmd.ExecuteNonQuery();
            int a = cmd.ExecuteNonQuery();
            if (a == 1)
            {
                TextBox_ItemName.Clear();
                TextBox_Price.Clear();
                //TextBox_ItemType.Clear();
                PictureBox_Image.Image = Properties.Resources.Foodicon;
                MessageBox.Show("Item Updated !!");
                LoadDataIntoGridView();
                //this.Hide();
                //ManageItemForm ok = new ManageItemForm() ;
                //ok.Show();
            }
            else
            {
                MessageBox.Show("Item Not Updated !!");
            }

            con.Close();
        }

        private void Button_Remove_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            PictureBox_Image.Image.Save(ms, PictureBox_Image.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());

            string query = "delete from items where item_id = @id";
            con.Open();

            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.Add("@id", MySqlDbType.Int16);
            cmd.Parameters["@id"].Value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();


            //cmd.ExecuteNonQuery();
            int a = cmd.ExecuteNonQuery();
            if (a == 1)
            {
                TextBox_ItemName.Clear();
                TextBox_Price.Clear();
                //TextBox_ItemType.Clear();
                PictureBox_Image.Image = Properties.Resources.Foodicon;
                MessageBox.Show("Item Updated !!");
                LoadDataIntoGridView();
                //this.Hide();
                //ManageItemForm ok = new ManageItemForm() ;
                //ok.Show();
            }
            else
            {
                MessageBox.Show("Item Not Updated !!");
            }

            con.Close();
        }

        private void ComboBox_ItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query = "Select * from items where item_type = '" + ComboBox_ItemType.Text + "'";
            LoadDataIntoGridView();
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm af = new AdminForm();
            af.Show();
        }
    }
}
