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
    public partial class FormBill : Form
    {
        // int[] recpt = new int[100];
        int recpt = 0;
        int[] item_id = new int[100];
        int[] quantity = new int[100];
        int[] aprice = new int[100];
        int[] uprice = new int[100];
        string[] iname = new string[100];
        string date = "";
        int cur = 0;

        string Query = "Select item_name , item_type , item_price , item_image from items";

        public FormBill()
        {
            InitializeComponent();
            LoadDataIntoGridView();
            CreateReceiptNo();
            TextBox_Quantity.Text = "0";
            TextBox_Price.Text = "0";
           // date = dateTimePicker1.Text.ToString();

        }

        private void label7_Click(object sender, EventArgs e)
        {

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
            DataGridView_ItemList.DataSource = dtRecords;

            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)DataGridView_ItemList.Columns[3];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView_ItemList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridView_ItemList.RowTemplate.Height = 80;
            con.Close();
        }

        private void ComboBox_ItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query = "Select item_name , item_type , item_price ,item_image from items where item_type = '" + ComboBox_ItemType.Text + "'";
            LoadDataIntoGridView();
        }

        private void DataGridView_ItemList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TextBox_ItemName.Text = DataGridView_ItemList.SelectedRows[0].Cells[0].Value.ToString();
            TextBox_PPUnit.Text = DataGridView_ItemList.SelectedRows[0].Cells[2].Value.ToString();
            
            ComboBox_ItemType.Text = DataGridView_ItemList.SelectedRows[0].Cells[1].Value.ToString();
            
            
            //PictureBox_Image.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[4].Value);
        }

        private void TextBox_Quantity_TextChanged(object sender, EventArgs e)
        {
            int prc = 0;
            if (TextBox_Quantity.Text != "0" && TextBox_Quantity.Text != "")
            {
                prc = Int16.Parse(TextBox_Quantity.Text) * Int16.Parse(TextBox_PPUnit.Text);
                TextBox_Price.Text = prc.ToString();
            }
   
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            ManagerForm MF = new ManagerForm();
            MF.Show();
            this.Hide();
        }


        private void CreateReceiptNo()
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            con.Open();

            string sqlquery = "select max(receipt_no) from customer";

            MySqlCommand cmd = new MySqlCommand(sqlquery, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            string now = "" ;
            while(dr.Read())
            {
                now = (dr.GetValue(0).ToString());
            }
            Int32 a = Int32.Parse(now) + 1 ;
            TextBox_ReciptNo.Text = a.ToString() ;
            date = dateTimePicker1.Text;
            recpt = a;
            //MessageBox.Show(now);

            con.Close();
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            con.Open();

            string sqlquery = "select item_id from items where item_name = '"+TextBox_ItemName.Text+"' and item_type = '"+ComboBox_ItemType.Text+"'";

            MySqlCommand cmd = new MySqlCommand(sqlquery, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            string now = "";
            while (dr.Read())
            {
                now = (dr.GetValue(0).ToString());
            }
            
            //MessageBox.Show(now);
            con.Close();

            if (TextBox_Quantity.Text == "0")
                return;

            Int32 a = Int32.Parse(now);
            item_id[cur] = a;
            iname[cur] = TextBox_ItemName.Text;
            uprice[cur] = Int16.Parse(TextBox_PPUnit.Text);
            // recpt = Int32.Parse(TextBox_ReciptNo.Text);
            quantity[cur] = Int32.Parse(TextBox_Quantity.Text);
            aprice[cur] = uprice[cur] * quantity[cur];
            cur++;
            MessageBox.Show("Added!");
            ///richTextBox1.AppendText("Reciept No: "+recpt.ToString() + "\t" + "Date : " + date.ToString() + "\n");
            //richTextBox1.AppendText("\n\n");
            //richTextBox1.AppendText(quantity[cur - 1].ToString());
            //richTextBox1.AppendText("\n\n");
            //richTextBox1.AppendText(item_id[cur-1].ToString());
            //richTextBox1.AppendText("\n\n");


            //con = new MySqlConnection(AppSettings.ConnectionString());
            // con.Open();

            //sqlquery = "select item_price , item_name from items where item_id = '" + item_id[cur-1] + "'";

            //MySqlCommand cmd = new MySqlCommand(sqlquery, con);
            //MySqlDataReader dr = cmd.ExecuteReader();
            //cmd = new MySqlCommand(sqlquery, con);
            //dr = cmd.ExecuteReader();
            /*
            string pr = "";
            string iname = "";
            while (dr.Read())
            {
                pr = (dr.GetValue(0).ToString());
                iname = (dr.GetValue(1).ToString());
            }

            //MessageBox.Show(now);
            con.Close();

            richTextBox1.AppendText(pr.ToString());
            richTextBox1.AppendText("\n\n");
            richTextBox1.AppendText(iname.ToString());
            */
            richTextBox1.Clear();
            date = dateTimePicker1.Text;
            //richTextBox1.AppendText(dateTimePicker1.Text);
            richTextBox1.AppendText("\t\tKHANA's Restaurant\n");
            richTextBox1.AppendText("Reciept No: " + recpt.ToString() + "\t" + "Date : " + date + "\n");
            richTextBox1.AppendText("\nCustomer Name : " + TextBox_CusName.Text + "\n");
            richTextBox1.AppendText("Mobile : " + TextBox_Mobile.Text + "\n");


            int n = cur - 1;
            // int tot = 0;
            richTextBox1.AppendText("\nS.NO  " + "Item.Name" + " Quantity " + " U.Price " + " Price \n");
            richTextBox1.AppendText("-------- " + "---------------- " + " -------------- " + " ------------" + " ------------- ");

            int tot = 0;
            for (int i = n, j = 1; i >= 0; i--, j++)
            {
                tot += aprice[i];
                richTextBox1.AppendText("\n" + j + ".  " + iname[i] + "  " + quantity[i] + "     " + "           " + uprice[i] + "      " + aprice[i] + "\n");
            }
            //double ans = tot - ((tot * Int32.Parse(ComboBox_Discount.Text)) / 100.0);



            TextBox_Quantity.Text = "0";
            TextBox_Price.Text = "0";
            TextBox_PPUnit.Text = "0";
        }

        private void Button_Total_Click(object sender, EventArgs e)
        {
            int n = cur - 1;
            int tot = 0;
            for (int i = n; i >= 0; i--)
            {
                tot += aprice[i];
            }
            double ans = tot - ((tot * Int32.Parse(ComboBox_Discount.Text)) / 100.0) ;

            //double ans = tot - ((tot * Int32.Parse(ComboBox_Discount.Text)) / 100.0);
            richTextBox1.AppendText("-------------------------------------------------------------------------------\n");
            richTextBox1.AppendText("Total                                                           " + ans);


            TextBox_TotalPrice.Text = ans.ToString();
        }

        private void Button_Receipt_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            date = dateTimePicker1.Text;
            //richTextBox1.AppendText(dateTimePicker1.Text);
            richTextBox1.AppendText("\t\tKHANA's Restaurant\n");
            richTextBox1.AppendText("Reciept No: "+recpt.ToString() + "\t" + "Date : " + date+ "\n");
            richTextBox1.AppendText("\nCustomer Name : " + TextBox_CusName.Text + "\n");
            richTextBox1.AppendText("Mobile : " + TextBox_Mobile.Text + "\n");


            int n = cur - 1;
            // int tot = 0;
            richTextBox1.AppendText("\nS.NO  " + "Item.Name" + " Quantity " + " U.Price " + " Price \n");
            richTextBox1.AppendText("-------- " + "---------------- " + " -------------- " + " ------------" + " ------------- ");

            int tot = 0;
            for (int i = n , j = 1 ; i >= 0 ; i-- , j++)
            {
                tot += aprice[i];
                richTextBox1.AppendText("\n"+j + ".  " + iname[i] +"  " + quantity[i] + "     " + "           " + uprice[i] + "      " + aprice[i] +"\n" );
            }
            double ans = tot - ((tot * Int32.Parse(ComboBox_Discount.Text)) / 100.0);
            richTextBox1.AppendText("-------------------------------------------------------------------------------\n");
            richTextBox1.AppendText("Total                                                           " + ans);

            database_add_cus_info();
            for (int i = cur - 1; i >= 0; i--)
            {
                database_add_sales_info(i);
            }
        }

        private void Button_NewBill_Click(object sender, EventArgs e)
        {
            FormBill ok = new FormBill();
            ok.Show();
            this.Hide();
        }

        private void database_add_cus_info()
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());

            string query = "insert into restaurant.customer(receipt_no , cus_name , mobile) values(@rcpt,@cname,@mob)";

            con.Open();

            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.Add("@rcpt", MySqlDbType.Int16);
            cmd.Parameters.Add("@cname", MySqlDbType.VarChar, 100);
            cmd.Parameters.Add("@mob", MySqlDbType.VarChar, 100);


            cmd.Parameters["@rcpt"].Value = recpt;
            cmd.Parameters["@cname"].Value = TextBox_CusName.Text;
            cmd.Parameters["@mob"].Value = TextBox_Mobile.Text;


            cmd.ExecuteNonQuery();
            /*
            int a = cmd.ExecuteNonQuery();
            if (a == 1)
            {
                //TextBox_ItemName.Clear();
                //TextBox_Price.Clear();
                //ComboBox_ItemType.Clear();
                //PictureBox_Image.Image = Properties.Resources.Foodicon;
                MessageBox.Show(" Inserted !!");
                //LoadDataIntoGridView();
                //this.Hide();
                //ManageItemForm ok = new ManageItemForm() ;
                //ok.Show();
            }
            else
            {
                MessageBox.Show("Item Not Inserted !!");
            }
            */
            con.Close();
        }
        private void database_add_sales_info(int i)
        {
            MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());

            string query = "insert into restaurant.sales(receipt_no , item_id , item_quantity , date) values(@rcpt,@id,@qunt,@dat)";

            con.Open();

            MySqlCommand cmd = new MySqlCommand(query, con);

            cmd.Parameters.Add("@rcpt", MySqlDbType.Int16);
            cmd.Parameters.Add("@id", MySqlDbType.Int16);
            cmd.Parameters.Add("@qunt", MySqlDbType.Int16);
            cmd.Parameters.Add("@dat", MySqlDbType.Date);

            cmd.Parameters["@rcpt"].Value = recpt;
            cmd.Parameters["@id"].Value = item_id[i];
            cmd.Parameters["@qunt"].Value = quantity[i];
            cmd.Parameters["@dat"].Value = dateTimePicker1.Value;


            cmd.ExecuteNonQuery();
            /*
            int a = cmd.ExecuteNonQuery();
            if (a == 1)
            {
                //TextBox_ItemName.Clear();
                //TextBox_Price.Clear();
                //ComboBox_ItemType.Clear();
                //PictureBox_Image.Image = Properties.Resources.Foodicon;
                MessageBox.Show(" Inserted !!");
                //LoadDataIntoGridView();
                //this.Hide();
                //ManageItemForm ok = new ManageItemForm() ;
                //ok.Show();
            }
            else
            {
                MessageBox.Show("Item Not Inserted !!");
            }
            */
            con.Close();
        }
        private void Button_Print_Click(object sender, EventArgs e)
        {
           
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial ", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }
    }
}
