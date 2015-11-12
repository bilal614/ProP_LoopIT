﻿namespace JazzEventProject
{
    partial class LoanMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanMaterial));
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelSubLeft = new System.Windows.Forms.Panel();
            this.btnSelectedUSB = new System.Windows.Forms.Button();
            this.btnSelectChanger = new System.Windows.Forms.Button();
            this.btnSelectUSBCable = new System.Windows.Forms.Button();
            this.btSelectCamera = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbMaterialID = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.sub_rightPanel = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tbCurrentDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.GreyPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panelSubLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sub_rightPanel.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(144, 60);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(257, 20);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodId,
            this.FoodName,
            this.Quantity,
            this.Price,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(327, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.Size = new System.Drawing.Size(507, 45);
            this.dataGridView1.TabIndex = 18;
            // 
            // FoodId
            // 
            this.FoodId.HeaderText = "Material ID";
            this.FoodId.Name = "FoodId";
            // 
            // FoodName
            // 
            this.FoodName.HeaderText = "Material name";
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
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Controls.Add(this.label8);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(872, 68);
            this.HeaderPanel.TabIndex = 19;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(77, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "LOANING MATERIAL";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panelSubLeft);
            this.panel8.Controls.Add(this.sub_rightPanel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 68);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(872, 462);
            this.panel8.TabIndex = 20;
            // 
            // panelSubLeft
            // 
            this.panelSubLeft.Controls.Add(this.btnSelectedUSB);
            this.panelSubLeft.Controls.Add(this.btnSelectChanger);
            this.panelSubLeft.Controls.Add(this.btnSelectUSBCable);
            this.panelSubLeft.Controls.Add(this.btSelectCamera);
            this.panelSubLeft.Controls.Add(this.panel2);
            this.panelSubLeft.Controls.Add(this.panel9);
            this.panelSubLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSubLeft.Location = new System.Drawing.Point(0, 0);
            this.panelSubLeft.Name = "panelSubLeft";
            this.panelSubLeft.Size = new System.Drawing.Size(311, 462);
            this.panelSubLeft.TabIndex = 15;
            // 
            // btnSelectedUSB
            // 
            this.btnSelectedUSB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectedUSB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSelectedUSB.FlatAppearance.BorderSize = 0;
            this.btnSelectedUSB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectedUSB.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectedUSB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectedUSB.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectedUSB.Image")));
            this.btnSelectedUSB.Location = new System.Drawing.Point(166, 87);
            this.btnSelectedUSB.Name = "btnSelectedUSB";
            this.btnSelectedUSB.Size = new System.Drawing.Size(116, 110);
            this.btnSelectedUSB.TabIndex = 16;
            this.btnSelectedUSB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelectedUSB.UseVisualStyleBackColor = false;
            // 
            // btnSelectChanger
            // 
            this.btnSelectChanger.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectChanger.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSelectChanger.FlatAppearance.BorderSize = 0;
            this.btnSelectChanger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectChanger.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectChanger.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectChanger.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectChanger.Image")));
            this.btnSelectChanger.Location = new System.Drawing.Point(166, 210);
            this.btnSelectChanger.Name = "btnSelectChanger";
            this.btnSelectChanger.Size = new System.Drawing.Size(116, 110);
            this.btnSelectChanger.TabIndex = 16;
            this.btnSelectChanger.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelectChanger.UseVisualStyleBackColor = false;
            // 
            // btnSelectUSBCable
            // 
            this.btnSelectUSBCable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectUSBCable.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSelectUSBCable.FlatAppearance.BorderSize = 0;
            this.btnSelectUSBCable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectUSBCable.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectUSBCable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectUSBCable.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectUSBCable.Image")));
            this.btnSelectUSBCable.Location = new System.Drawing.Point(34, 208);
            this.btnSelectUSBCable.Name = "btnSelectUSBCable";
            this.btnSelectUSBCable.Size = new System.Drawing.Size(116, 110);
            this.btnSelectUSBCable.TabIndex = 16;
            this.btnSelectUSBCable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelectUSBCable.UseVisualStyleBackColor = false;
            // 
            // btSelectCamera
            // 
            this.btSelectCamera.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSelectCamera.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSelectCamera.FlatAppearance.BorderSize = 0;
            this.btSelectCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelectCamera.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelectCamera.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSelectCamera.Image = ((System.Drawing.Image)(resources.GetObject("btSelectCamera.Image")));
            this.btSelectCamera.Location = new System.Drawing.Point(34, 87);
            this.btSelectCamera.Name = "btSelectCamera";
            this.btSelectCamera.Size = new System.Drawing.Size(116, 110);
            this.btSelectCamera.TabIndex = 16;
            this.btSelectCamera.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSelectCamera.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbQuantity);
            this.panel2.Controls.Add(this.tbMaterialID);
            this.panel2.Controls.Add(this.btnSearchFood);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 81);
            this.panel2.TabIndex = 9;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(34, 42);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(181, 20);
            this.tbQuantity.TabIndex = 9;
            this.tbQuantity.Text = "Typing quantity here...";
            // 
            // tbMaterialID
            // 
            this.tbMaterialID.Location = new System.Drawing.Point(34, 16);
            this.tbMaterialID.Name = "tbMaterialID";
            this.tbMaterialID.Size = new System.Drawing.Size(181, 20);
            this.tbMaterialID.TabIndex = 9;
            this.tbMaterialID.Text = "Typing material ID here...";
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
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(306, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 462);
            this.panel9.TabIndex = 14;
            // 
            // sub_rightPanel
            // 
            this.sub_rightPanel.Controls.Add(this.panel12);
            this.sub_rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sub_rightPanel.Location = new System.Drawing.Point(0, 0);
            this.sub_rightPanel.Name = "sub_rightPanel";
            this.sub_rightPanel.Size = new System.Drawing.Size(872, 462);
            this.sub_rightPanel.TabIndex = 7;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel3);
            this.panel12.Controls.Add(this.panel7);
            this.panel12.Controls.Add(this.dataGridView1);
            this.panel12.Controls.Add(this.panel11);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(872, 462);
            this.panel12.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.lbSubTotal);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(708, 367);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(152, 89);
            this.panel7.TabIndex = 8;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "€ 61.6";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "€ 10.7";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.tbCurrentDate);
            this.panel11.Controls.Add(this.label10);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Controls.Add(this.dateTimePicker2);
            this.panel11.Location = new System.Drawing.Point(327, 6);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(414, 96);
            this.panel11.TabIndex = 10;
            // 
            // tbCurrentDate
            // 
            this.tbCurrentDate.Location = new System.Drawing.Point(140, 6);
            this.tbCurrentDate.Multiline = true;
            this.tbCurrentDate.Name = "tbCurrentDate";
            this.tbCurrentDate.ReadOnly = true;
            this.tbCurrentDate.Size = new System.Drawing.Size(257, 29);
            this.tbCurrentDate.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Return Date:";
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.panel1);
            this.bottomPanel.Controls.Add(this.btnBackToMainForm);
            this.bottomPanel.Controls.Add(this.btnPrint);
            this.bottomPanel.Controls.Add(this.btnLoan);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 416);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(872, 114);
            this.bottomPanel.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 10);
            this.panel1.TabIndex = 14;
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainForm.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToMainForm.Image")));
            this.btnBackToMainForm.Location = new System.Drawing.Point(755, 15);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(95, 96);
            this.btnBackToMainForm.TabIndex = 1;
            this.btnBackToMainForm.Text = "Back";
            this.btnBackToMainForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBackToMainForm.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(640, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 96);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print invoice";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnLoan
            // 
            this.btnLoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoan.Image = ((System.Drawing.Image)(resources.GetObject("btnLoan.Image")));
            this.btnLoan.Location = new System.Drawing.Point(531, 15);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(103, 96);
            this.btnLoan.TabIndex = 1;
            this.btnLoan.Text = "Loan";
            this.btnLoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoan.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(713, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 89);
            this.panel3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sub-Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "VAT(21%):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(95, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "€ 61.6";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 58);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(95, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "€ 50.9 ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(95, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "€ 10.7";
            // 
            // GreyPanel
            // 
            this.GreyPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GreyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GreyPanel.Location = new System.Drawing.Point(0, 68);
            this.GreyPanel.Name = "GreyPanel";
            this.GreyPanel.Size = new System.Drawing.Size(872, 5);
            this.GreyPanel.TabIndex = 22;
            // 
            // LoanMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 530);
            this.Controls.Add(this.GreyPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "LoanMaterial";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panelSubLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.sub_rightPanel.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panelSubLeft;
        private System.Windows.Forms.Button btnSelectedUSB;
        private System.Windows.Forms.Button btnSelectChanger;
        private System.Windows.Forms.Button btnSelectUSBCable;
        private System.Windows.Forms.Button btSelectCamera;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.TextBox tbMaterialID;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel sub_rightPanel;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox tbCurrentDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBackToMainForm;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel GreyPanel;
    }
}