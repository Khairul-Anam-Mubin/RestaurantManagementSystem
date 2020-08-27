namespace RestaurantManagement
{
    partial class ManageItemForm
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
            this.ManageItemPanel = new System.Windows.Forms.Panel();
            this.Button_Back = new System.Windows.Forms.Button();
            this.ComboBox_ItemType = new System.Windows.Forms.ComboBox();
            this.Label_ItemLists = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PictureBox_Image = new System.Windows.Forms.PictureBox();
            this.Button_Remove = new System.Windows.Forms.Button();
            this.Button_Update = new System.Windows.Forms.Button();
            this.Button_Insert = new System.Windows.Forms.Button();
            this.Button_Upload = new System.Windows.Forms.Button();
            this.TextBox_Price = new System.Windows.Forms.TextBox();
            this.TextBox_ItemName = new System.Windows.Forms.TextBox();
            this.Label_ItemType = new System.Windows.Forms.Label();
            this.Label_Price = new System.Windows.Forms.Label();
            this.Label_ItemName = new System.Windows.Forms.Label();
            this.ManageItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageItemPanel
            // 
            this.ManageItemPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ManageItemPanel.BackgroundImage = global::RestaurantManagement.Properties.Resources.one;
            this.ManageItemPanel.Controls.Add(this.Button_Back);
            this.ManageItemPanel.Controls.Add(this.ComboBox_ItemType);
            this.ManageItemPanel.Controls.Add(this.Label_ItemLists);
            this.ManageItemPanel.Controls.Add(this.dataGridView1);
            this.ManageItemPanel.Controls.Add(this.PictureBox_Image);
            this.ManageItemPanel.Controls.Add(this.Button_Remove);
            this.ManageItemPanel.Controls.Add(this.Button_Update);
            this.ManageItemPanel.Controls.Add(this.Button_Insert);
            this.ManageItemPanel.Controls.Add(this.Button_Upload);
            this.ManageItemPanel.Controls.Add(this.TextBox_Price);
            this.ManageItemPanel.Controls.Add(this.TextBox_ItemName);
            this.ManageItemPanel.Controls.Add(this.Label_ItemType);
            this.ManageItemPanel.Controls.Add(this.Label_Price);
            this.ManageItemPanel.Controls.Add(this.Label_ItemName);
            this.ManageItemPanel.Location = new System.Drawing.Point(2, 0);
            this.ManageItemPanel.Name = "ManageItemPanel";
            this.ManageItemPanel.Size = new System.Drawing.Size(957, 449);
            this.ManageItemPanel.TabIndex = 0;
            this.ManageItemPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ManageItemPanel_Paint);
            // 
            // Button_Back
            // 
            this.Button_Back.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Back.Location = new System.Drawing.Point(853, 12);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(85, 48);
            this.Button_Back.TabIndex = 20;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // ComboBox_ItemType
            // 
            this.ComboBox_ItemType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_ItemType.FormattingEnabled = true;
            this.ComboBox_ItemType.Items.AddRange(new object[] {
            "Beriyani",
            "Kacchi",
            "Rice",
            "Chicken",
            "Beef",
            "Drinks"});
            this.ComboBox_ItemType.Location = new System.Drawing.Point(206, 138);
            this.ComboBox_ItemType.Name = "ComboBox_ItemType";
            this.ComboBox_ItemType.Size = new System.Drawing.Size(196, 33);
            this.ComboBox_ItemType.TabIndex = 19;
            this.ComboBox_ItemType.Text = "Select Item";
            this.ComboBox_ItemType.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ItemType_SelectedIndexChanged);
            // 
            // Label_ItemLists
            // 
            this.Label_ItemLists.BackColor = System.Drawing.Color.White;
            this.Label_ItemLists.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ItemLists.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Label_ItemLists.Location = new System.Drawing.Point(566, 30);
            this.Label_ItemLists.Name = "Label_ItemLists";
            this.Label_ItemLists.Size = new System.Drawing.Size(159, 45);
            this.Label_ItemLists.TabIndex = 18;
            this.Label_ItemLists.Text = "Item Lists";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(434, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 371);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // PictureBox_Image
            // 
            this.PictureBox_Image.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PictureBox_Image.BackgroundImage = global::RestaurantManagement.Properties.Resources.Foodicon;
            this.PictureBox_Image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_Image.Location = new System.Drawing.Point(38, 230);
            this.PictureBox_Image.Name = "PictureBox_Image";
            this.PictureBox_Image.Size = new System.Drawing.Size(152, 135);
            this.PictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Image.TabIndex = 12;
            this.PictureBox_Image.TabStop = false;
            // 
            // Button_Remove
            // 
            this.Button_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Remove.Location = new System.Drawing.Point(276, 319);
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.Size = new System.Drawing.Size(111, 46);
            this.Button_Remove.TabIndex = 16;
            this.Button_Remove.Text = "Remove";
            this.Button_Remove.UseVisualStyleBackColor = true;
            this.Button_Remove.Click += new System.EventHandler(this.Button_Remove_Click);
            // 
            // Button_Update
            // 
            this.Button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Update.Location = new System.Drawing.Point(276, 253);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(111, 46);
            this.Button_Update.TabIndex = 15;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = true;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // Button_Insert
            // 
            this.Button_Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Insert.Location = new System.Drawing.Point(276, 188);
            this.Button_Insert.Name = "Button_Insert";
            this.Button_Insert.Size = new System.Drawing.Size(111, 46);
            this.Button_Insert.TabIndex = 14;
            this.Button_Insert.Text = "Insert";
            this.Button_Insert.UseVisualStyleBackColor = true;
            this.Button_Insert.Click += new System.EventHandler(this.Button_Insert_Click);
            // 
            // Button_Upload
            // 
            this.Button_Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Upload.Location = new System.Drawing.Point(33, 188);
            this.Button_Upload.Name = "Button_Upload";
            this.Button_Upload.Size = new System.Drawing.Size(167, 36);
            this.Button_Upload.TabIndex = 13;
            this.Button_Upload.Text = "Browse Image";
            this.Button_Upload.UseVisualStyleBackColor = true;
            this.Button_Upload.Click += new System.EventHandler(this.Button_Upload_Click);
            // 
            // TextBox_Price
            // 
            this.TextBox_Price.Location = new System.Drawing.Point(206, 92);
            this.TextBox_Price.Multiline = true;
            this.TextBox_Price.Name = "TextBox_Price";
            this.TextBox_Price.Size = new System.Drawing.Size(196, 40);
            this.TextBox_Price.TabIndex = 10;
            // 
            // TextBox_ItemName
            // 
            this.TextBox_ItemName.Location = new System.Drawing.Point(206, 41);
            this.TextBox_ItemName.Multiline = true;
            this.TextBox_ItemName.Name = "TextBox_ItemName";
            this.TextBox_ItemName.Size = new System.Drawing.Size(196, 45);
            this.TextBox_ItemName.TabIndex = 9;
            // 
            // Label_ItemType
            // 
            this.Label_ItemType.BackColor = System.Drawing.SystemColors.Control;
            this.Label_ItemType.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ItemType.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Label_ItemType.Location = new System.Drawing.Point(31, 131);
            this.Label_ItemType.Name = "Label_ItemType";
            this.Label_ItemType.Size = new System.Drawing.Size(169, 45);
            this.Label_ItemType.TabIndex = 8;
            this.Label_ItemType.Text = "Item Type";
            // 
            // Label_Price
            // 
            this.Label_Price.BackColor = System.Drawing.SystemColors.Control;
            this.Label_Price.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Price.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Label_Price.Location = new System.Drawing.Point(31, 86);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(169, 45);
            this.Label_Price.TabIndex = 7;
            this.Label_Price.Text = "Price";
            // 
            // Label_ItemName
            // 
            this.Label_ItemName.BackColor = System.Drawing.SystemColors.Control;
            this.Label_ItemName.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ItemName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Label_ItemName.Location = new System.Drawing.Point(31, 41);
            this.Label_ItemName.Name = "Label_ItemName";
            this.Label_ItemName.Size = new System.Drawing.Size(169, 45);
            this.Label_ItemName.TabIndex = 6;
            this.Label_ItemName.Text = "Item Name";
            // 
            // ManageItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.ManageItemPanel);
            this.Name = "ManageItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageItemForm";
            this.ManageItemPanel.ResumeLayout(false);
            this.ManageItemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ManageItemPanel;
        private System.Windows.Forms.Label Label_ItemName;
        private System.Windows.Forms.Button Button_Remove;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.Button Button_Insert;
        private System.Windows.Forms.Button Button_Upload;
        private System.Windows.Forms.PictureBox PictureBox_Image;
        private System.Windows.Forms.TextBox TextBox_Price;
        private System.Windows.Forms.TextBox TextBox_ItemName;
        private System.Windows.Forms.Label Label_ItemType;
        private System.Windows.Forms.Label Label_Price;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Label_ItemLists;
        private System.Windows.Forms.ComboBox ComboBox_ItemType;
        private System.Windows.Forms.Button Button_Back;
    }
}