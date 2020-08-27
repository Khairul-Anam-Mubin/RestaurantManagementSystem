using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        
        private void Button_ManagerLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void Button_ItemList_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemList itemlist = new ItemList();
            itemlist.Show();
        }

        private void Button_Bill_Click(object sender, EventArgs e)
        {
            FormBill FB = new FormBill();
            this.Hide();
            FB.Show();

        }
    }
}
