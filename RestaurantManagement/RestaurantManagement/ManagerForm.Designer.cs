namespace RestaurantManagement
{
    partial class ManagerForm
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
            this.Panel_ManagerForm = new System.Windows.Forms.Panel();
            this.Button_Bill = new System.Windows.Forms.Button();
            this.Button_ItemList = new System.Windows.Forms.Button();
            this.Button_ManagerLogout = new System.Windows.Forms.Button();
            this.Panel_ManagerForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_ManagerForm
            // 
            this.Panel_ManagerForm.BackgroundImage = global::RestaurantManagement.Properties.Resources.one;
            this.Panel_ManagerForm.Controls.Add(this.Button_Bill);
            this.Panel_ManagerForm.Controls.Add(this.Button_ItemList);
            this.Panel_ManagerForm.Controls.Add(this.Button_ManagerLogout);
            this.Panel_ManagerForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_ManagerForm.Location = new System.Drawing.Point(0, 0);
            this.Panel_ManagerForm.Name = "Panel_ManagerForm";
            this.Panel_ManagerForm.Size = new System.Drawing.Size(800, 450);
            this.Panel_ManagerForm.TabIndex = 0;
            // 
            // Button_Bill
            // 
            this.Button_Bill.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Bill.Location = new System.Drawing.Point(359, 121);
            this.Button_Bill.Name = "Button_Bill";
            this.Button_Bill.Size = new System.Drawing.Size(113, 87);
            this.Button_Bill.TabIndex = 3;
            this.Button_Bill.Text = "Bill";
            this.Button_Bill.UseVisualStyleBackColor = true;
            this.Button_Bill.Click += new System.EventHandler(this.Button_Bill_Click);
            // 
            // Button_ItemList
            // 
            this.Button_ItemList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ItemList.Location = new System.Drawing.Point(104, 121);
            this.Button_ItemList.Name = "Button_ItemList";
            this.Button_ItemList.Size = new System.Drawing.Size(111, 87);
            this.Button_ItemList.TabIndex = 2;
            this.Button_ItemList.Text = "Item List";
            this.Button_ItemList.UseVisualStyleBackColor = true;
            this.Button_ItemList.Click += new System.EventHandler(this.Button_ItemList_Click);
            // 
            // Button_ManagerLogout
            // 
            this.Button_ManagerLogout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ManagerLogout.Location = new System.Drawing.Point(615, 121);
            this.Button_ManagerLogout.Name = "Button_ManagerLogout";
            this.Button_ManagerLogout.Size = new System.Drawing.Size(111, 87);
            this.Button_ManagerLogout.TabIndex = 1;
            this.Button_ManagerLogout.Text = "Log out";
            this.Button_ManagerLogout.UseVisualStyleBackColor = true;
            this.Button_ManagerLogout.Click += new System.EventHandler(this.Button_ManagerLogout_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel_ManagerForm);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            this.Panel_ManagerForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_ManagerForm;
        private System.Windows.Forms.Button Button_ManagerLogout;
        private System.Windows.Forms.Button Button_ItemList;
        private System.Windows.Forms.Button Button_Bill;
    }
}