namespace RestaurantManagement
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_AdminForm = new System.Windows.Forms.Panel();
            this.Button_ManageUsers = new System.Windows.Forms.Button();
            this.Button_SalesandInfo = new System.Windows.Forms.Button();
            this.Button_ManageItems = new System.Windows.Forms.Button();
            this.Button_AdminLogout = new System.Windows.Forms.Button();
            this.Panel_AdminForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_AdminForm
            // 
            this.Panel_AdminForm.BackgroundImage = global::RestaurantManagement.Properties.Resources.one;
            this.Panel_AdminForm.Controls.Add(this.Button_ManageUsers);
            this.Panel_AdminForm.Controls.Add(this.Button_SalesandInfo);
            this.Panel_AdminForm.Controls.Add(this.Button_ManageItems);
            this.Panel_AdminForm.Controls.Add(this.Button_AdminLogout);
            this.Panel_AdminForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_AdminForm.Location = new System.Drawing.Point(0, 0);
            this.Panel_AdminForm.Name = "Panel_AdminForm";
            this.Panel_AdminForm.Size = new System.Drawing.Size(754, 450);
            this.Panel_AdminForm.TabIndex = 1;
            // 
            // Button_ManageUsers
            // 
            this.Button_ManageUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ManageUsers.Location = new System.Drawing.Point(240, 121);
            this.Button_ManageUsers.Name = "Button_ManageUsers";
            this.Button_ManageUsers.Size = new System.Drawing.Size(113, 87);
            this.Button_ManageUsers.TabIndex = 5;
            this.Button_ManageUsers.Text = "Manage Users";
            this.Button_ManageUsers.UseVisualStyleBackColor = true;
            this.Button_ManageUsers.Click += new System.EventHandler(this.Button_ManageUsers_Click);
            // 
            // Button_SalesandInfo
            // 
            this.Button_SalesandInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_SalesandInfo.Location = new System.Drawing.Point(51, 121);
            this.Button_SalesandInfo.Name = "Button_SalesandInfo";
            this.Button_SalesandInfo.Size = new System.Drawing.Size(113, 87);
            this.Button_SalesandInfo.TabIndex = 3;
            this.Button_SalesandInfo.Text = "Sales and Info";
            this.Button_SalesandInfo.UseVisualStyleBackColor = true;
            this.Button_SalesandInfo.Click += new System.EventHandler(this.Button_SalesandInfo_Click);
            // 
            // Button_ManageItems
            // 
            this.Button_ManageItems.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ManageItems.Location = new System.Drawing.Point(418, 121);
            this.Button_ManageItems.Name = "Button_ManageItems";
            this.Button_ManageItems.Size = new System.Drawing.Size(111, 87);
            this.Button_ManageItems.TabIndex = 2;
            this.Button_ManageItems.Text = "Manage Items";
            this.Button_ManageItems.UseVisualStyleBackColor = true;
            this.Button_ManageItems.Click += new System.EventHandler(this.Button_ManageItems_Click);
            // 
            // Button_AdminLogout
            // 
            this.Button_AdminLogout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_AdminLogout.Location = new System.Drawing.Point(604, 121);
            this.Button_AdminLogout.Name = "Button_AdminLogout";
            this.Button_AdminLogout.Size = new System.Drawing.Size(111, 87);
            this.Button_AdminLogout.TabIndex = 1;
            this.Button_AdminLogout.Text = "Log out";
            this.Button_AdminLogout.UseVisualStyleBackColor = true;
            this.Button_AdminLogout.Click += new System.EventHandler(this.Button_AdminLogout_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.Panel_AdminForm);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Panel_AdminForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_AdminForm;
        private System.Windows.Forms.Button Button_ManageUsers;
        private System.Windows.Forms.Button Button_SalesandInfo;
        private System.Windows.Forms.Button Button_ManageItems;
        private System.Windows.Forms.Button Button_AdminLogout;
    }
}