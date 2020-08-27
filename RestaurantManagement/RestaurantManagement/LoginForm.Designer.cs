namespace RestaurantManagement
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Login = new System.Windows.Forms.Button();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.PictureBox_Password = new System.Windows.Forms.PictureBox();
            this.TextBox_UserName = new System.Windows.Forms.TextBox();
            this.PictureBox_UserName = new System.Windows.Forms.PictureBox();
            this.Label_UserType = new System.Windows.Forms.Label();
            this.ComboBox_SelectUser = new System.Windows.Forms.ComboBox();
            this.Label_Underline = new System.Windows.Forms.Label();
            this.Label_Login = new System.Windows.Forms.Label();
            this.Label_Heading = new System.Windows.Forms.Label();
            this.Panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_UserName)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Main
            // 
            this.Panel_Main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Main.BackgroundImage")));
            this.Panel_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Main.Controls.Add(this.Button_Exit);
            this.Panel_Main.Controls.Add(this.Button_Login);
            this.Panel_Main.Controls.Add(this.TextBox_Password);
            this.Panel_Main.Controls.Add(this.PictureBox_Password);
            this.Panel_Main.Controls.Add(this.TextBox_UserName);
            this.Panel_Main.Controls.Add(this.PictureBox_UserName);
            this.Panel_Main.Controls.Add(this.Label_UserType);
            this.Panel_Main.Controls.Add(this.ComboBox_SelectUser);
            this.Panel_Main.Controls.Add(this.Label_Underline);
            this.Panel_Main.Controls.Add(this.Label_Login);
            this.Panel_Main.Controls.Add(this.Label_Heading);
            this.Panel_Main.Location = new System.Drawing.Point(0, 0);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(800, 457);
            this.Panel_Main.TabIndex = 0;
            this.Panel_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.Design_Main_Paint);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Exit.Location = new System.Drawing.Point(624, 202);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(90, 67);
            this.Button_Exit.TabIndex = 30;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click_1);
            // 
            // Button_Login
            // 
            this.Button_Login.BackColor = System.Drawing.Color.Maroon;
            this.Button_Login.FlatAppearance.BorderSize = 0;
            this.Button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Login.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Button_Login.Location = new System.Drawing.Point(34, 377);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(376, 49);
            this.Button_Login.TabIndex = 10;
            this.Button_Login.Text = "Login";
            this.Button_Login.UseVisualStyleBackColor = false;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Password.Location = new System.Drawing.Point(112, 286);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '*';
            this.TextBox_Password.Size = new System.Drawing.Size(298, 35);
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
            this.TextBox_UserName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_UserName.Location = new System.Drawing.Point(112, 219);
            this.TextBox_UserName.Multiline = true;
            this.TextBox_UserName.Name = "TextBox_UserName";
            this.TextBox_UserName.Size = new System.Drawing.Size(298, 50);
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
            // 
            // Label_UserType
            // 
            this.Label_UserType.BackColor = System.Drawing.Color.Transparent;
            this.Label_UserType.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_UserType.ForeColor = System.Drawing.SystemColors.Window;
            this.Label_UserType.Location = new System.Drawing.Point(15, 158);
            this.Label_UserType.Name = "Label_UserType";
            this.Label_UserType.Size = new System.Drawing.Size(173, 45);
            this.Label_UserType.TabIndex = 5;
            this.Label_UserType.Text = "User Type";
            // 
            // ComboBox_SelectUser
            // 
            this.ComboBox_SelectUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_SelectUser.FormattingEnabled = true;
            this.ComboBox_SelectUser.Items.AddRange(new object[] {
            "Admin",
            "Manager"});
            this.ComboBox_SelectUser.Location = new System.Drawing.Point(187, 170);
            this.ComboBox_SelectUser.Name = "ComboBox_SelectUser";
            this.ComboBox_SelectUser.Size = new System.Drawing.Size(223, 33);
            this.ComboBox_SelectUser.TabIndex = 4;
            this.ComboBox_SelectUser.Text = "Select User";
            this.ComboBox_SelectUser.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectUser_SelectedIndexChanged);
            // 
            // Label_Underline
            // 
            this.Label_Underline.BackColor = System.Drawing.Color.White;
            this.Label_Underline.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Underline.ForeColor = System.Drawing.SystemColors.Window;
            this.Label_Underline.Location = new System.Drawing.Point(23, 142);
            this.Label_Underline.Name = "Label_Underline";
            this.Label_Underline.Size = new System.Drawing.Size(461, 10);
            this.Label_Underline.TabIndex = 2;
            this.Label_Underline.Text = "Login";
            // 
            // Label_Login
            // 
            this.Label_Login.AutoSize = true;
            this.Label_Login.BackColor = System.Drawing.Color.Transparent;
            this.Label_Login.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Login.ForeColor = System.Drawing.SystemColors.Window;
            this.Label_Login.Location = new System.Drawing.Point(12, 77);
            this.Label_Login.Name = "Label_Login";
            this.Label_Login.Size = new System.Drawing.Size(153, 65);
            this.Label_Login.TabIndex = 1;
            this.Label_Login.Text = "Login";
            // 
            // Label_Heading
            // 
            this.Label_Heading.AutoSize = true;
            this.Label_Heading.BackColor = System.Drawing.Color.Transparent;
            this.Label_Heading.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Heading.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Label_Heading.Location = new System.Drawing.Point(148, 0);
            this.Label_Heading.Name = "Label_Heading";
            this.Label_Heading.Size = new System.Drawing.Size(467, 65);
            this.Label_Heading.TabIndex = 0;
            this.Label_Heading.Text = "Khana\'s Restaurant";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.Panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Panel_Main.ResumeLayout(false);
            this.Panel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_UserName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.PictureBox PictureBox_UserName;
        private System.Windows.Forms.Label Label_UserType;
        private System.Windows.Forms.ComboBox ComboBox_SelectUser;
        private System.Windows.Forms.Label Label_Underline;
        private System.Windows.Forms.Label Label_Login;
        private System.Windows.Forms.Label Label_Heading;
        private System.Windows.Forms.TextBox TextBox_UserName;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.PictureBox PictureBox_Password;
        private System.Windows.Forms.Button Button_Exit;
    }
}