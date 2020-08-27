namespace RestaurantManagement
{
    partial class ItemList
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
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Panle_Left = new System.Windows.Forms.Panel();
            this.Button_Drinks = new System.Windows.Forms.Button();
            this.Button_Beef = new System.Windows.Forms.Button();
            this.Button_Back = new System.Windows.Forms.Button();
            this.Button_Chicken = new System.Windows.Forms.Button();
            this.Button_Rice = new System.Windows.Forms.Button();
            this.Button_Kacchi = new System.Windows.Forms.Button();
            this.Button_Beriyani = new System.Windows.Forms.Button();
            this.Label_Heading = new System.Windows.Forms.Label();
            this.Panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panle_Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Main
            // 
            this.Panel_Main.BackColor = System.Drawing.Color.Navy;
            this.Panel_Main.Controls.Add(this.label1);
            this.Panel_Main.Controls.Add(this.dataGridView1);
            this.Panel_Main.Controls.Add(this.Panle_Left);
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(0, 0);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(909, 501);
            this.Panel_Main.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label1.Location = new System.Drawing.Point(542, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 45);
            this.label1.TabIndex = 19;
            this.label1.Text = "Items";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 430);
            this.dataGridView1.TabIndex = 18;
            // 
            // Panle_Left
            // 
            this.Panle_Left.BackColor = System.Drawing.Color.DarkGreen;
            this.Panle_Left.Controls.Add(this.Button_Drinks);
            this.Panle_Left.Controls.Add(this.Button_Beef);
            this.Panle_Left.Controls.Add(this.Button_Back);
            this.Panle_Left.Controls.Add(this.Button_Chicken);
            this.Panle_Left.Controls.Add(this.Button_Rice);
            this.Panle_Left.Controls.Add(this.Button_Kacchi);
            this.Panle_Left.Controls.Add(this.Button_Beriyani);
            this.Panle_Left.Controls.Add(this.Label_Heading);
            this.Panle_Left.Location = new System.Drawing.Point(0, 0);
            this.Panle_Left.Name = "Panle_Left";
            this.Panle_Left.Size = new System.Drawing.Size(330, 508);
            this.Panle_Left.TabIndex = 4;
            // 
            // Button_Drinks
            // 
            this.Button_Drinks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Drinks.Location = new System.Drawing.Point(72, 315);
            this.Button_Drinks.Name = "Button_Drinks";
            this.Button_Drinks.Size = new System.Drawing.Size(150, 31);
            this.Button_Drinks.TabIndex = 9;
            this.Button_Drinks.Text = "Drinks";
            this.Button_Drinks.UseVisualStyleBackColor = true;
            this.Button_Drinks.Click += new System.EventHandler(this.Button_Drinks_Click);
            // 
            // Button_Beef
            // 
            this.Button_Beef.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Beef.Location = new System.Drawing.Point(72, 268);
            this.Button_Beef.Name = "Button_Beef";
            this.Button_Beef.Size = new System.Drawing.Size(150, 31);
            this.Button_Beef.TabIndex = 8;
            this.Button_Beef.Text = "Beef";
            this.Button_Beef.UseVisualStyleBackColor = true;
            this.Button_Beef.Click += new System.EventHandler(this.Button_Beef_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Back.Location = new System.Drawing.Point(93, 388);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(100, 59);
            this.Button_Back.TabIndex = 2;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Button_Chicken
            // 
            this.Button_Chicken.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Chicken.Location = new System.Drawing.Point(72, 220);
            this.Button_Chicken.Name = "Button_Chicken";
            this.Button_Chicken.Size = new System.Drawing.Size(150, 31);
            this.Button_Chicken.TabIndex = 7;
            this.Button_Chicken.Text = "Chicken";
            this.Button_Chicken.UseVisualStyleBackColor = true;
            this.Button_Chicken.Click += new System.EventHandler(this.Button_Chicken_Click);
            // 
            // Button_Rice
            // 
            this.Button_Rice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Rice.Location = new System.Drawing.Point(72, 174);
            this.Button_Rice.Name = "Button_Rice";
            this.Button_Rice.Size = new System.Drawing.Size(150, 31);
            this.Button_Rice.TabIndex = 6;
            this.Button_Rice.Text = "Rice";
            this.Button_Rice.UseVisualStyleBackColor = true;
            this.Button_Rice.Click += new System.EventHandler(this.Button_Rice_Click);
            // 
            // Button_Kacchi
            // 
            this.Button_Kacchi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Kacchi.Location = new System.Drawing.Point(72, 126);
            this.Button_Kacchi.Name = "Button_Kacchi";
            this.Button_Kacchi.Size = new System.Drawing.Size(150, 31);
            this.Button_Kacchi.TabIndex = 5;
            this.Button_Kacchi.Text = "Kacchi";
            this.Button_Kacchi.UseVisualStyleBackColor = true;
            this.Button_Kacchi.Click += new System.EventHandler(this.Button_Kacchi_Click);
            // 
            // Button_Beriyani
            // 
            this.Button_Beriyani.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Beriyani.Location = new System.Drawing.Point(72, 78);
            this.Button_Beriyani.Name = "Button_Beriyani";
            this.Button_Beriyani.Size = new System.Drawing.Size(150, 31);
            this.Button_Beriyani.TabIndex = 4;
            this.Button_Beriyani.Text = "Beriyani";
            this.Button_Beriyani.UseVisualStyleBackColor = true;
            this.Button_Beriyani.Click += new System.EventHandler(this.Button_Beriyani_Click);
            // 
            // Label_Heading
            // 
            this.Label_Heading.AutoSize = true;
            this.Label_Heading.BackColor = System.Drawing.Color.Transparent;
            this.Label_Heading.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Heading.ForeColor = System.Drawing.Color.DarkKhaki;
            this.Label_Heading.Location = new System.Drawing.Point(64, 23);
            this.Label_Heading.Name = "Label_Heading";
            this.Label_Heading.Size = new System.Drawing.Size(155, 45);
            this.Label_Heading.TabIndex = 3;
            this.Label_Heading.Text = "Category";
            this.Label_Heading.Click += new System.EventHandler(this.Label_Heading_Click);
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 501);
            this.Controls.Add(this.Panel_Main);
            this.Name = "ItemList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemList";
            this.Load += new System.EventHandler(this.ItemList_Load);
            this.Panel_Main.ResumeLayout(false);
            this.Panel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panle_Left.ResumeLayout(false);
            this.Panle_Left.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Label Label_Heading;
        private System.Windows.Forms.Panel Panle_Left;
        private System.Windows.Forms.Button Button_Drinks;
        private System.Windows.Forms.Button Button_Beef;
        private System.Windows.Forms.Button Button_Chicken;
        private System.Windows.Forms.Button Button_Rice;
        private System.Windows.Forms.Button Button_Kacchi;
        private System.Windows.Forms.Button Button_Beriyani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}