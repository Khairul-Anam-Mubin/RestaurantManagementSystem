namespace RestaurantManagement
{
    partial class ManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.DataGridView_UserList = new System.Windows.Forms.DataGridView();
            this.Label_UserList = new System.Windows.Forms.Label();
            this.Button_Back = new System.Windows.Forms.Button();
            this.Button_Remove = new System.Windows.Forms.Button();
            this.Button_Insert = new System.Windows.Forms.Button();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.PictureBox_Password = new System.Windows.Forms.PictureBox();
            this.TextBox_UserName = new System.Windows.Forms.TextBox();
            this.PictureBox_UserName = new System.Windows.Forms.PictureBox();
            this.Label_UserType = new System.Windows.Forms.Label();
            this.ComboBox_SelectUser = new System.Windows.Forms.ComboBox();
            this.Label_Heading = new System.Windows.Forms.Label();
            this.Panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_UserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_UserName)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Main
            // 
            this.Panel_Main.BackColor = System.Drawing.Color.Brown;
            this.Panel_Main.BackgroundImage = global::RestaurantManagement.Properties.Resources.one;
            this.Panel_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Main.Controls.Add(this.DataGridView_UserList);
            this.Panel_Main.Controls.Add(this.Label_UserList);
            this.Panel_Main.Controls.Add(this.Button_Back);
            this.Panel_Main.Controls.Add(this.Button_Remove);
            this.Panel_Main.Controls.Add(this.Button_Insert);
            this.Panel_Main.Controls.Add(this.TextBox_Password);
            this.Panel_Main.Controls.Add(this.PictureBox_Password);
            this.Panel_Main.Controls.Add(this.TextBox_UserName);
            this.Panel_Main.Controls.Add(this.PictureBox_UserName);
            this.Panel_Main.Controls.Add(this.Label_UserType);
            this.Panel_Main.Controls.Add(this.ComboBox_SelectUser);
            this.Panel_Main.Controls.Add(this.Label_Heading);
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(0, 0);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(800, 450);
            this.Panel_Main.TabIndex = 1;
            this.Panel_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Main_Paint);
            // 
            // DataGridView_UserList
            // 
            this.DataGridView_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_UserList.Location = new System.Drawing.Point(399, 107);
            this.DataGridView_UserList.Name = "DataGridView_UserList";
            this.DataGridView_UserList.Size = new System.Drawing.Size(398, 340);
            this.DataGridView_UserList.TabIndex = 14;
            this.DataGridView_UserList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_UserList_MouseDoubleClick);
            // 
            // Label_UserList
            // 
            this.Label_UserList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label_UserList.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_UserList.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Label_UserList.Location = new System.Drawing.Point(527, 69);
            this.Label_UserList.Name = "Label_UserList";
            this.Label_UserList.Size = new System.Drawing.Size(138, 35);
            this.Label_UserList.TabIndex = 13;
            this.Label_UserList.Text = "User List";
            // 
            // Button_Back
            // 
            this.Button_Back.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Back.Location = new System.Drawing.Point(712, 3);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(85, 48);
            this.Button_Back.TabIndex = 12;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Button_Remove
            // 
            this.Button_Remove.BackColor = System.Drawing.Color.Maroon;
            this.Button_Remove.FlatAppearance.BorderSize = 0;
            this.Button_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Remove.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Remove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Remove.Location = new System.Drawing.Point(211, 377);
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.Size = new System.Drawing.Size(130, 49);
            this.Button_Remove.TabIndex = 11;
            this.Button_Remove.Text = "Remove";
            this.Button_Remove.UseVisualStyleBackColor = false;
            this.Button_Remove.Click += new System.EventHandler(this.Button_Remove_Click);
            // 
            // Button_Insert
            // 
            this.Button_Insert.BackColor = System.Drawing.Color.Maroon;
            this.Button_Insert.FlatAppearance.BorderSize = 0;
            this.Button_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Insert.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Insert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Insert.Location = new System.Drawing.Point(34, 377);
            this.Button_Insert.Name = "Button_Insert";
            this.Button_Insert.Size = new System.Drawing.Size(131, 49);
            this.Button_Insert.TabIndex = 10;
            this.Button_Insert.Text = "Insert";
            this.Button_Insert.UseVisualStyleBackColor = false;
            this.Button_Insert.Click += new System.EventHandler(this.Button_Insert_Click);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBox_Password.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Password.Location = new System.Drawing.Point(112, 286);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(252, 35);
            this.TextBox_Password.TabIndex = 9;
            this.TextBox_Password.UseSystemPasswordChar = true;
            // 
            // PictureBox_Password
            // 
            this.PictureBox_Password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox_Password.BackgroundImage")));
            this.PictureBox_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_Password.Location = new System.Drawing.Point(34, 286);
            this.PictureBox_Password.Name = "PictureBox_Password";
            this.PictureBox_Password.Size = new System.Drawing.Size(56, 55);
            this.PictureBox_Password.TabIndex = 8;
            this.PictureBox_Password.TabStop = false;
            // 
            // TextBox_UserName
            // 
            this.TextBox_UserName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBox_UserName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_UserName.Location = new System.Drawing.Point(112, 228);
            this.TextBox_UserName.Multiline = true;
            this.TextBox_UserName.Name = "TextBox_UserName";
            this.TextBox_UserName.Size = new System.Drawing.Size(252, 41);
            this.TextBox_UserName.TabIndex = 7;
            // 
            // PictureBox_UserName
            // 
            this.PictureBox_UserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox_UserName.BackgroundImage")));
            this.PictureBox_UserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_UserName.Location = new System.Drawing.Point(34, 219);
            this.PictureBox_UserName.Name = "PictureBox_UserName";
            this.PictureBox_UserName.Size = new System.Drawing.Size(56, 50);
            this.PictureBox_UserName.TabIndex = 6;
            this.PictureBox_UserName.TabStop = false;
            this.PictureBox_UserName.Click += new System.EventHandler(this.PictureBox_UserName_Click);
            // 
            // Label_UserType
            // 
            this.Label_UserType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label_UserType.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_UserType.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Label_UserType.Location = new System.Drawing.Point(12, 170);
            this.Label_UserType.Name = "Label_UserType";
            this.Label_UserType.Size = new System.Drawing.Size(147, 39);
            this.Label_UserType.TabIndex = 5;
            this.Label_UserType.Text = "User Type";
            this.Label_UserType.Click += new System.EventHandler(this.Label_UserType_Click);
            // 
            // ComboBox_SelectUser
            // 
            this.ComboBox_SelectUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_SelectUser.FormattingEnabled = true;
            this.ComboBox_SelectUser.Items.AddRange(new object[] {
            "Admin",
            "Manager"});
            this.ComboBox_SelectUser.Location = new System.Drawing.Point(187, 177);
            this.ComboBox_SelectUser.Name = "ComboBox_SelectUser";
            this.ComboBox_SelectUser.Size = new System.Drawing.Size(177, 33);
            this.ComboBox_SelectUser.TabIndex = 4;
            this.ComboBox_SelectUser.Text = "Select User";
            // 
            // Label_Heading
            // 
            this.Label_Heading.AutoSize = true;
            this.Label_Heading.BackColor = System.Drawing.Color.Transparent;
            this.Label_Heading.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Heading.ForeColor = System.Drawing.Color.Black;
            this.Label_Heading.Location = new System.Drawing.Point(200, 3);
            this.Label_Heading.Name = "Label_Heading";
            this.Label_Heading.Size = new System.Drawing.Size(321, 65);
            this.Label_Heading.TabIndex = 0;
            this.Label_Heading.Text = "Manage User";
            this.Label_Heading.Click += new System.EventHandler(this.Label_Heading_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel_Main);
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Panel_Main.ResumeLayout(false);
            this.Panel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_UserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_UserName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.Button Button_Insert;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.PictureBox PictureBox_Password;
        private System.Windows.Forms.TextBox TextBox_UserName;
        private System.Windows.Forms.PictureBox PictureBox_UserName;
        private System.Windows.Forms.Label Label_UserType;
        private System.Windows.Forms.ComboBox ComboBox_SelectUser;
        private System.Windows.Forms.Label Label_Heading;
        private System.Windows.Forms.Button Button_Remove;
        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.DataGridView DataGridView_UserList;
        private System.Windows.Forms.Label Label_UserList;
    }
}