namespace RestaurantManagement
{
    partial class FormBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBill));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboBox_Discount = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Button_NewBill = new System.Windows.Forms.Button();
            this.Button_Print = new System.Windows.Forms.Button();
            this.Button_Receipt = new System.Windows.Forms.Button();
            this.Button_Total = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Back = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TextBox_ReciptNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DataGridView_ItemList = new System.Windows.Forms.DataGridView();
            this.ComboBox_ItemType = new System.Windows.Forms.ComboBox();
            this.TextBox_TotalPrice = new System.Windows.Forms.TextBox();
            this.TextBox_Price = new System.Windows.Forms.TextBox();
            this.TextBox_PPUnit = new System.Windows.Forms.TextBox();
            this.TextBox_Quantity = new System.Windows.Forms.TextBox();
            this.TextBox_ItemName = new System.Windows.Forms.TextBox();
            this.TextBox_Mobile = new System.Windows.Forms.TextBox();
            this.TextBox_CusName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_UserType = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RestaurantManagement.Properties.Resources.one;
            this.panel1.Controls.Add(this.ComboBox_Discount);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.Button_NewBill);
            this.panel1.Controls.Add(this.Button_Print);
            this.panel1.Controls.Add(this.Button_Receipt);
            this.panel1.Controls.Add(this.Button_Total);
            this.panel1.Controls.Add(this.Button_Add);
            this.panel1.Controls.Add(this.Button_Back);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.TextBox_ReciptNo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.DataGridView_ItemList);
            this.panel1.Controls.Add(this.ComboBox_ItemType);
            this.panel1.Controls.Add(this.TextBox_TotalPrice);
            this.panel1.Controls.Add(this.TextBox_Price);
            this.panel1.Controls.Add(this.TextBox_PPUnit);
            this.panel1.Controls.Add(this.TextBox_Quantity);
            this.panel1.Controls.Add(this.TextBox_ItemName);
            this.panel1.Controls.Add(this.TextBox_Mobile);
            this.panel1.Controls.Add(this.TextBox_CusName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Label_UserType);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 497);
            this.panel1.TabIndex = 0;
            // 
            // ComboBox_Discount
            // 
            this.ComboBox_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Discount.FormattingEnabled = true;
            this.ComboBox_Discount.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.ComboBox_Discount.Location = new System.Drawing.Point(181, 408);
            this.ComboBox_Discount.Name = "ComboBox_Discount";
            this.ComboBox_Discount.Size = new System.Drawing.Size(137, 28);
            this.ComboBox_Discount.TabIndex = 36;
            this.ComboBox_Discount.Text = "0";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label12.Location = new System.Drawing.Point(68, 408);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 33);
            this.label12.TabIndex = 35;
            this.label12.Text = "Discount";
            // 
            // Button_NewBill
            // 
            this.Button_NewBill.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_NewBill.Location = new System.Drawing.Point(711, 77);
            this.Button_NewBill.Name = "Button_NewBill";
            this.Button_NewBill.Size = new System.Drawing.Size(95, 36);
            this.Button_NewBill.TabIndex = 34;
            this.Button_NewBill.Text = "New Bill";
            this.Button_NewBill.UseVisualStyleBackColor = true;
            this.Button_NewBill.Click += new System.EventHandler(this.Button_NewBill_Click);
            // 
            // Button_Print
            // 
            this.Button_Print.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Print.Location = new System.Drawing.Point(850, 77);
            this.Button_Print.Name = "Button_Print";
            this.Button_Print.Size = new System.Drawing.Size(95, 36);
            this.Button_Print.TabIndex = 33;
            this.Button_Print.Text = "Print";
            this.Button_Print.UseVisualStyleBackColor = true;
            this.Button_Print.Click += new System.EventHandler(this.Button_Print_Click);
            // 
            // Button_Receipt
            // 
            this.Button_Receipt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Receipt.Location = new System.Drawing.Point(887, 135);
            this.Button_Receipt.Name = "Button_Receipt";
            this.Button_Receipt.Size = new System.Drawing.Size(93, 36);
            this.Button_Receipt.TabIndex = 32;
            this.Button_Receipt.Text = "Receipt";
            this.Button_Receipt.UseVisualStyleBackColor = true;
            this.Button_Receipt.Click += new System.EventHandler(this.Button_Receipt_Click);
            // 
            // Button_Total
            // 
            this.Button_Total.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Total.Location = new System.Drawing.Point(789, 134);
            this.Button_Total.Name = "Button_Total";
            this.Button_Total.Size = new System.Drawing.Size(92, 36);
            this.Button_Total.TabIndex = 31;
            this.Button_Total.Text = "Total";
            this.Button_Total.UseVisualStyleBackColor = true;
            this.Button_Total.Click += new System.EventHandler(this.Button_Total_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.Location = new System.Drawing.Point(688, 135);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(95, 36);
            this.Button_Add.TabIndex = 30;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Back.Location = new System.Drawing.Point(925, 3);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(64, 36);
            this.Button_Back.TabIndex = 29;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(688, 176);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(292, 279);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "";
            // 
            // TextBox_ReciptNo
            // 
            this.TextBox_ReciptNo.Location = new System.Drawing.Point(471, 74);
            this.TextBox_ReciptNo.Multiline = true;
            this.TextBox_ReciptNo.Name = "TextBox_ReciptNo";
            this.TextBox_ReciptNo.Size = new System.Drawing.Size(84, 29);
            this.TextBox_ReciptNo.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label11.Location = new System.Drawing.Point(375, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 29);
            this.label11.TabIndex = 26;
            this.label11.Text = "Recipt No";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label10.Location = new System.Drawing.Point(423, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 29);
            this.label10.TabIndex = 25;
            this.label10.Text = "Item Lists";
            // 
            // DataGridView_ItemList
            // 
            this.DataGridView_ItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_ItemList.Location = new System.Drawing.Point(349, 176);
            this.DataGridView_ItemList.Name = "DataGridView_ItemList";
            this.DataGridView_ItemList.Size = new System.Drawing.Size(324, 279);
            this.DataGridView_ItemList.TabIndex = 24;
            this.DataGridView_ItemList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView_ItemList_MouseDoubleClick);
            // 
            // ComboBox_ItemType
            // 
            this.ComboBox_ItemType.FormattingEnabled = true;
            this.ComboBox_ItemType.Items.AddRange(new object[] {
            "Beriyani",
            "Kacchi",
            "Rice",
            "Chicken",
            "Beef",
            "Drinks"});
            this.ComboBox_ItemType.Location = new System.Drawing.Point(181, 216);
            this.ComboBox_ItemType.Name = "ComboBox_ItemType";
            this.ComboBox_ItemType.Size = new System.Drawing.Size(137, 21);
            this.ComboBox_ItemType.TabIndex = 23;
            this.ComboBox_ItemType.Text = "Select";
            this.ComboBox_ItemType.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ItemType_SelectedIndexChanged);
            // 
            // TextBox_TotalPrice
            // 
            this.TextBox_TotalPrice.Location = new System.Drawing.Point(181, 459);
            this.TextBox_TotalPrice.Multiline = true;
            this.TextBox_TotalPrice.Name = "TextBox_TotalPrice";
            this.TextBox_TotalPrice.Size = new System.Drawing.Size(137, 29);
            this.TextBox_TotalPrice.TabIndex = 22;
            // 
            // TextBox_Price
            // 
            this.TextBox_Price.Location = new System.Drawing.Point(181, 366);
            this.TextBox_Price.Multiline = true;
            this.TextBox_Price.Name = "TextBox_Price";
            this.TextBox_Price.Size = new System.Drawing.Size(137, 29);
            this.TextBox_Price.TabIndex = 21;
            // 
            // TextBox_PPUnit
            // 
            this.TextBox_PPUnit.Location = new System.Drawing.Point(181, 292);
            this.TextBox_PPUnit.Multiline = true;
            this.TextBox_PPUnit.Name = "TextBox_PPUnit";
            this.TextBox_PPUnit.Size = new System.Drawing.Size(137, 29);
            this.TextBox_PPUnit.TabIndex = 20;
            // 
            // TextBox_Quantity
            // 
            this.TextBox_Quantity.Location = new System.Drawing.Point(181, 251);
            this.TextBox_Quantity.Multiline = true;
            this.TextBox_Quantity.Name = "TextBox_Quantity";
            this.TextBox_Quantity.Size = new System.Drawing.Size(137, 29);
            this.TextBox_Quantity.TabIndex = 19;
            this.TextBox_Quantity.TextChanged += new System.EventHandler(this.TextBox_Quantity_TextChanged);
            // 
            // TextBox_ItemName
            // 
            this.TextBox_ItemName.Location = new System.Drawing.Point(181, 176);
            this.TextBox_ItemName.Multiline = true;
            this.TextBox_ItemName.Name = "TextBox_ItemName";
            this.TextBox_ItemName.Size = new System.Drawing.Size(137, 29);
            this.TextBox_ItemName.TabIndex = 18;
            // 
            // TextBox_Mobile
            // 
            this.TextBox_Mobile.Location = new System.Drawing.Point(181, 117);
            this.TextBox_Mobile.Multiline = true;
            this.TextBox_Mobile.Name = "TextBox_Mobile";
            this.TextBox_Mobile.Size = new System.Drawing.Size(164, 29);
            this.TextBox_Mobile.TabIndex = 17;
            // 
            // TextBox_CusName
            // 
            this.TextBox_CusName.Location = new System.Drawing.Point(181, 77);
            this.TextBox_CusName.Multiline = true;
            this.TextBox_CusName.Name = "TextBox_CusName";
            this.TextBox_CusName.Size = new System.Drawing.Size(164, 29);
            this.TextBox_CusName.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label9.Location = new System.Drawing.Point(76, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 27);
            this.label9.TabIndex = 15;
            this.label9.Text = "=";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Location = new System.Drawing.Point(68, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 33);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Price";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Location = new System.Drawing.Point(25, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "Price";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(25, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 27);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price Per Unit";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(25, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(25, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Item Type";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(25, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(25, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mobile";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer Name";
            // 
            // Label_UserType
            // 
            this.Label_UserType.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Label_UserType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_UserType.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Label_UserType.Location = new System.Drawing.Point(25, 45);
            this.Label_UserType.Name = "Label_UserType";
            this.Label_UserType.Size = new System.Drawing.Size(59, 20);
            this.Label_UserType.TabIndex = 6;
            this.Label_UserType.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 497);
            this.Controls.Add(this.panel1);
            this.Name = "FormBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ItemList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_UserType;
        private System.Windows.Forms.DataGridView DataGridView_ItemList;
        private System.Windows.Forms.ComboBox ComboBox_ItemType;
        private System.Windows.Forms.TextBox TextBox_TotalPrice;
        private System.Windows.Forms.TextBox TextBox_Price;
        private System.Windows.Forms.TextBox TextBox_PPUnit;
        private System.Windows.Forms.TextBox TextBox_Quantity;
        private System.Windows.Forms.TextBox TextBox_ItemName;
        private System.Windows.Forms.TextBox TextBox_Mobile;
        private System.Windows.Forms.TextBox TextBox_CusName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox TextBox_ReciptNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Receipt;
        private System.Windows.Forms.Button Button_Total;
        private System.Windows.Forms.Button Button_Print;
        private System.Windows.Forms.Button Button_NewBill;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ComboBox_Discount;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}