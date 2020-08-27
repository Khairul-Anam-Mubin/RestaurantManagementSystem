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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void Button_AdminLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void Button_ManageUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUsers manageusers = new ManageUsers();
            manageusers.Show();
        }

        private void Button_ManageItems_Click(object sender, EventArgs e)
        {
            ManageItemForm ob = new ManageItemForm();
            this.Close();
            ob.Show();
        }

        private void Button_SalesandInfo_Click(object sender, EventArgs e)
        {
            SalesAndInfoForm ob = new SalesAndInfoForm();
            ob.Show();
            this.Hide();
        }
    }
}
