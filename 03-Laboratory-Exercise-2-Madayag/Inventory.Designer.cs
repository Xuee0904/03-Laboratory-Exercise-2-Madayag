namespace _03_Laboratory_Exercise_2_Madayag
{
    partial class Inventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ProductNameText = new System.Windows.Forms.TextBox();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.MfgDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ExpDatePicker = new System.Windows.Forms.DateTimePicker();
            this.QuantityText = new System.Windows.Forms.TextBox();
            this.SellPriceText = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ViewProductListGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ViewProductListGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Manufacturing date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Expiration date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(315, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sell price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Description";
            // 
            // ProductNameText
            // 
            this.ProductNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductNameText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameText.Location = new System.Drawing.Point(17, 78);
            this.ProductNameText.Name = "ProductNameText";
            this.ProductNameText.Size = new System.Drawing.Size(285, 23);
            this.ProductNameText.TabIndex = 8;
            // 
            // CategoryCB
            // 
            this.CategoryCB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(18, 130);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(286, 25);
            this.CategoryCB.TabIndex = 9;
            // 
            // MfgDatePicker
            // 
            this.MfgDatePicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MfgDatePicker.Location = new System.Drawing.Point(318, 78);
            this.MfgDatePicker.Name = "MfgDatePicker";
            this.MfgDatePicker.Size = new System.Drawing.Size(286, 24);
            this.MfgDatePicker.TabIndex = 10;
            // 
            // ExpDatePicker
            // 
            this.ExpDatePicker.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpDatePicker.Location = new System.Drawing.Point(319, 130);
            this.ExpDatePicker.Name = "ExpDatePicker";
            this.ExpDatePicker.Size = new System.Drawing.Size(285, 24);
            this.ExpDatePicker.TabIndex = 11;
            // 
            // QuantityText
            // 
            this.QuantityText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuantityText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityText.Location = new System.Drawing.Point(17, 181);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.Size = new System.Drawing.Size(285, 23);
            this.QuantityText.TabIndex = 12;
            // 
            // SellPriceText
            // 
            this.SellPriceText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SellPriceText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellPriceText.Location = new System.Drawing.Point(319, 181);
            this.SellPriceText.Name = "SellPriceText";
            this.SellPriceText.Size = new System.Drawing.Size(285, 23);
            this.SellPriceText.TabIndex = 13;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(17, 235);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(587, 109);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // AddProductButton
            // 
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddProductButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.Location = new System.Drawing.Point(472, 350);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(132, 37);
            this.AddProductButton.TabIndex = 15;
            this.AddProductButton.Text = "ADD PRODUCT";
            this.AddProductButton.UseVisualStyleBackColor = true;
            // 
            // ViewProductListGrid
            // 
            this.ViewProductListGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.ViewProductListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewProductListGrid.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.ViewProductListGrid.Location = new System.Drawing.Point(20, 404);
            this.ViewProductListGrid.Name = "ViewProductListGrid";
            this.ViewProductListGrid.Size = new System.Drawing.Size(584, 109);
            this.ViewProductListGrid.TabIndex = 16;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 540);
            this.Controls.Add(this.ViewProductListGrid);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SellPriceText);
            this.Controls.Add(this.QuantityText);
            this.Controls.Add(this.ExpDatePicker);
            this.Controls.Add(this.MfgDatePicker);
            this.Controls.Add(this.CategoryCB);
            this.Controls.Add(this.ProductNameText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inventory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewProductListGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ProductNameText;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.DateTimePicker MfgDatePicker;
        private System.Windows.Forms.DateTimePicker ExpDatePicker;
        private System.Windows.Forms.TextBox QuantityText;
        private System.Windows.Forms.TextBox SellPriceText;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.DataGridView ViewProductListGrid;
    }
}

