namespace JazzEventProject
{
    partial class FoodShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodShop));
            this.tbCurrentDate = new System.Windows.Forms.TextBox();
            this.dataGridViewFood = new System.Windows.Forms.DataGridView();
            this.FoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sub_rightPanel = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.GreyPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelSubLeft = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).BeginInit();
            this.sub_rightPanel.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelSubLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCurrentDate
            // 
            this.tbCurrentDate.Location = new System.Drawing.Point(78, 27);
            this.tbCurrentDate.Multiline = true;
            this.tbCurrentDate.Name = "tbCurrentDate";
            this.tbCurrentDate.ReadOnly = true;
            this.tbCurrentDate.Size = new System.Drawing.Size(181, 29);
            this.tbCurrentDate.TabIndex = 2;
            // 
            // dataGridViewFood
            // 
            this.dataGridViewFood.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridViewFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodId,
            this.FoodName,
            this.Quantity,
            this.Price,
            this.Total});
            this.dataGridViewFood.Location = new System.Drawing.Point(367, 170);
            this.dataGridViewFood.Name = "dataGridViewFood";
            this.dataGridViewFood.RowHeadersVisible = false;
            this.dataGridViewFood.RowHeadersWidth = 100;
            this.dataGridViewFood.Size = new System.Drawing.Size(507, 43);
            this.dataGridViewFood.TabIndex = 4;
            this.dataGridViewFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FoodId
            // 
            this.FoodId.HeaderText = "Food ID";
            this.FoodId.Name = "FoodId";
            // 
            // FoodName
            // 
            this.FoodName.HeaderText = "Food name";
            this.FoodName.Name = "FoodName";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price ";
            this.Price.Name = "Price";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sub-Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "VAT(21%):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total:";
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTotal.Location = new System.Drawing.Point(95, 11);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(47, 13);
            this.lbSubTotal.TabIndex = 6;
            this.lbSubTotal.Text = "€ 50.9 ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(95, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "€ 10.7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "€ 61.6";
            // 
            // sub_rightPanel
            // 
            this.sub_rightPanel.Controls.Add(this.panel12);
            this.sub_rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sub_rightPanel.Location = new System.Drawing.Point(0, 0);
            this.sub_rightPanel.Name = "sub_rightPanel";
            this.sub_rightPanel.Size = new System.Drawing.Size(901, 514);
            this.sub_rightPanel.TabIndex = 7;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel7);
            this.panel12.Controls.Add(this.dataGridViewFood);
            this.panel12.Controls.Add(this.panel11);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(901, 514);
            this.panel12.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.lbSubTotal);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(737, 419);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(152, 89);
            this.panel7.TabIndex = 8;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.tbCurrentDate);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Location = new System.Drawing.Point(349, 6);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(311, 79);
            this.panel11.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(170, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 96);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Sale";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(300, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 96);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print invoice";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearchFood.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchFood.FlatAppearance.BorderSize = 0;
            this.btnSearchFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFood.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchFood.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearchFood.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchFood.Image")));
            this.btnSearchFood.Location = new System.Drawing.Point(216, 6);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(77, 67);
            this.btnSearchFood.TabIndex = 8;
            this.btnSearchFood.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchFood.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.btnSearchFood);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 81);
            this.panel2.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 18);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 41);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Typing food id here...";
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBackToMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainForm.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToMainForm.Image")));
            this.btnBackToMainForm.Location = new System.Drawing.Point(435, 6);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(95, 96);
            this.btnBackToMainForm.TabIndex = 1;
            this.btnBackToMainForm.Text = "Back";
            this.btnBackToMainForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBackToMainForm.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(77, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "FOOD SHOP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Controls.Add(this.label2);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(901, 64);
            this.HeaderPanel.TabIndex = 12;
            // 
            // GreyPanel
            // 
            this.GreyPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GreyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GreyPanel.Location = new System.Drawing.Point(0, 64);
            this.GreyPanel.Name = "GreyPanel";
            this.GreyPanel.Size = new System.Drawing.Size(901, 5);
            this.GreyPanel.TabIndex = 13;
            this.GreyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.panel6);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 583);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(901, 114);
            this.bottomPanel.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnBackToMainForm);
            this.panel6.Controls.Add(this.btnSave);
            this.panel6.Controls.Add(this.btnPrint);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(349, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(552, 114);
            this.panel6.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panelSubLeft);
            this.panel8.Controls.Add(this.sub_rightPanel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 69);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(901, 514);
            this.panel8.TabIndex = 15;
            // 
            // panelSubLeft
            // 
            this.panelSubLeft.Controls.Add(this.panel2);
            this.panelSubLeft.Controls.Add(this.panel9);
            this.panelSubLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSubLeft.Location = new System.Drawing.Point(0, 0);
            this.panelSubLeft.Name = "panelSubLeft";
            this.panelSubLeft.Size = new System.Drawing.Size(341, 514);
            this.panelSubLeft.TabIndex = 15;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(336, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 514);
            this.panel9.TabIndex = 14;
            // 
            // FoodShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 697);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.GreyPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "FoodShop";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).EndInit();
            this.sub_rightPanel.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panelSubLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbCurrentDate;
        private System.Windows.Forms.DataGridView dataGridViewFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel sub_rightPanel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBackToMainForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel GreyPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panelSubLeft;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
    }
}