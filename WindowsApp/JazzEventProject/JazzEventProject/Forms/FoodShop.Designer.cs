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
            this.lbVAT = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.sub_rightPanel = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbFoodID = new System.Windows.Forms.TextBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.GreyPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelSubLeft = new System.Windows.Forms.Panel();
            this.btnSelectCoffee = new System.Windows.Forms.Button();
            this.btnSeletedCoca = new System.Windows.Forms.Button();
            this.btnSeletedSalad = new System.Windows.Forms.Button();
            this.btnSelectedBeer = new System.Windows.Forms.Button();
            this.btnSelectedFrenchFies = new System.Windows.Forms.Button();
            this.btSelectBurger = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pdoc = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFood)).BeginInit();
            this.sub_rightPanel.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
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
            this.dataGridViewFood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodId,
            this.FoodName,
            this.Quantity,
            this.Price,
            this.Total});
            this.dataGridViewFood.Location = new System.Drawing.Point(349, 110);
            this.dataGridViewFood.Name = "dataGridViewFood";
            this.dataGridViewFood.RowHeadersVisible = false;
            this.dataGridViewFood.RowHeadersWidth = 100;
            this.dataGridViewFood.Size = new System.Drawing.Size(507, 224);
            this.dataGridViewFood.TabIndex = 4;
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
            // lbVAT
            // 
            this.lbVAT.AutoSize = true;
            this.lbVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVAT.Location = new System.Drawing.Point(95, 35);
            this.lbVAT.Name = "lbVAT";
            this.lbVAT.Size = new System.Drawing.Size(43, 13);
            this.lbVAT.TabIndex = 6;
            this.lbVAT.Text = "€ 10.7";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(95, 58);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(43, 13);
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Text = "€ 61.6";
            // 
            // sub_rightPanel
            // 
            this.sub_rightPanel.Controls.Add(this.panel12);
            this.sub_rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sub_rightPanel.Location = new System.Drawing.Point(0, 0);
            this.sub_rightPanel.Name = "sub_rightPanel";
            this.sub_rightPanel.Size = new System.Drawing.Size(901, 456);
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
            this.panel12.Size = new System.Drawing.Size(901, 456);
            this.panel12.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.lbTotal);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.lbSubTotal);
            this.panel7.Controls.Add(this.lbVAT);
            this.panel7.Location = new System.Drawing.Point(737, 361);
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
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(560, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 96);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Sale";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(669, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 96);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print invoice";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbQuantity);
            this.panel2.Controls.Add(this.tbFoodID);
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
            this.tbQuantity.Enter += new System.EventHandler(this.tbQuantity_Enter);
            this.tbQuantity.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.tbQuantity_PreviewKeyDown);
            // 
            // tbFoodID
            // 
            this.tbFoodID.Location = new System.Drawing.Point(34, 16);
            this.tbFoodID.Name = "tbFoodID";
            this.tbFoodID.Size = new System.Drawing.Size(181, 20);
            this.tbFoodID.TabIndex = 9;
            this.tbFoodID.Text = "Typing food id here...";
            this.tbFoodID.Enter += new System.EventHandler(this.tbFoodID_Enter);
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
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainForm.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToMainForm.Image")));
            this.btnBackToMainForm.Location = new System.Drawing.Point(784, 15);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(95, 96);
            this.btnBackToMainForm.TabIndex = 1;
            this.btnBackToMainForm.Text = "Back";
            this.btnBackToMainForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBackToMainForm.UseVisualStyleBackColor = true;
            this.btnBackToMainForm.Click += new System.EventHandler(this.btnBackToMainForm_Click);
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
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.panel1);
            this.bottomPanel.Controls.Add(this.btnBackToMainForm);
            this.bottomPanel.Controls.Add(this.btnPrint);
            this.bottomPanel.Controls.Add(this.btnSave);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 525);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(901, 114);
            this.bottomPanel.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 5);
            this.panel1.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panelSubLeft);
            this.panel8.Controls.Add(this.sub_rightPanel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 69);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(901, 456);
            this.panel8.TabIndex = 15;
            // 
            // panelSubLeft
            // 
            this.panelSubLeft.Controls.Add(this.btnSelectCoffee);
            this.panelSubLeft.Controls.Add(this.btnSeletedCoca);
            this.panelSubLeft.Controls.Add(this.btnSeletedSalad);
            this.panelSubLeft.Controls.Add(this.btnSelectedBeer);
            this.panelSubLeft.Controls.Add(this.btnSelectedFrenchFies);
            this.panelSubLeft.Controls.Add(this.btSelectBurger);
            this.panelSubLeft.Controls.Add(this.panel2);
            this.panelSubLeft.Controls.Add(this.panel9);
            this.panelSubLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSubLeft.Location = new System.Drawing.Point(0, 0);
            this.panelSubLeft.Name = "panelSubLeft";
            this.panelSubLeft.Size = new System.Drawing.Size(311, 456);
            this.panelSubLeft.TabIndex = 15;
            // 
            // btnSelectCoffee
            // 
            this.btnSelectCoffee.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectCoffee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSelectCoffee.FlatAppearance.BorderSize = 0;
            this.btnSelectCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectCoffee.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCoffee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectCoffee.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectCoffee.Image")));
            this.btnSelectCoffee.Location = new System.Drawing.Point(166, 87);
            this.btnSelectCoffee.Name = "btnSelectCoffee";
            this.btnSelectCoffee.Size = new System.Drawing.Size(116, 110);
            this.btnSelectCoffee.TabIndex = 16;
            this.btnSelectCoffee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelectCoffee.UseVisualStyleBackColor = false;
            this.btnSelectCoffee.Click += new System.EventHandler(this.btnSelectCoffee_Click);
            // 
            // btnSeletedCoca
            // 
            this.btnSeletedCoca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeletedCoca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSeletedCoca.FlatAppearance.BorderSize = 0;
            this.btnSeletedCoca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeletedCoca.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeletedCoca.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeletedCoca.Image = ((System.Drawing.Image)(resources.GetObject("btnSeletedCoca.Image")));
            this.btnSeletedCoca.Location = new System.Drawing.Point(166, 330);
            this.btnSeletedCoca.Name = "btnSeletedCoca";
            this.btnSeletedCoca.Size = new System.Drawing.Size(116, 110);
            this.btnSeletedCoca.TabIndex = 16;
            this.btnSeletedCoca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeletedCoca.UseVisualStyleBackColor = false;
            this.btnSeletedCoca.Click += new System.EventHandler(this.btnSeletedCoca_Click);
            // 
            // btnSeletedSalad
            // 
            this.btnSeletedSalad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeletedSalad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSeletedSalad.FlatAppearance.BorderSize = 0;
            this.btnSeletedSalad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeletedSalad.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeletedSalad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeletedSalad.Image = ((System.Drawing.Image)(resources.GetObject("btnSeletedSalad.Image")));
            this.btnSeletedSalad.Location = new System.Drawing.Point(34, 330);
            this.btnSeletedSalad.Name = "btnSeletedSalad";
            this.btnSeletedSalad.Size = new System.Drawing.Size(116, 110);
            this.btnSeletedSalad.TabIndex = 16;
            this.btnSeletedSalad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeletedSalad.UseVisualStyleBackColor = false;
            this.btnSeletedSalad.Click += new System.EventHandler(this.btnSeletedSalad_Click);
            // 
            // btnSelectedBeer
            // 
            this.btnSelectedBeer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectedBeer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSelectedBeer.FlatAppearance.BorderSize = 0;
            this.btnSelectedBeer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectedBeer.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectedBeer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectedBeer.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectedBeer.Image")));
            this.btnSelectedBeer.Location = new System.Drawing.Point(166, 210);
            this.btnSelectedBeer.Name = "btnSelectedBeer";
            this.btnSelectedBeer.Size = new System.Drawing.Size(116, 110);
            this.btnSelectedBeer.TabIndex = 16;
            this.btnSelectedBeer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelectedBeer.UseVisualStyleBackColor = false;
            this.btnSelectedBeer.Click += new System.EventHandler(this.btnSelectedBeer_Click);
            // 
            // btnSelectedFrenchFies
            // 
            this.btnSelectedFrenchFies.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectedFrenchFies.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSelectedFrenchFies.FlatAppearance.BorderSize = 0;
            this.btnSelectedFrenchFies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectedFrenchFies.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectedFrenchFies.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectedFrenchFies.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectedFrenchFies.Image")));
            this.btnSelectedFrenchFies.Location = new System.Drawing.Point(34, 208);
            this.btnSelectedFrenchFies.Name = "btnSelectedFrenchFies";
            this.btnSelectedFrenchFies.Size = new System.Drawing.Size(116, 110);
            this.btnSelectedFrenchFies.TabIndex = 16;
            this.btnSelectedFrenchFies.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelectedFrenchFies.UseVisualStyleBackColor = false;
            this.btnSelectedFrenchFies.Click += new System.EventHandler(this.btnSelectedFrenchFies_Click);
            // 
            // btSelectBurger
            // 
            this.btSelectBurger.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSelectBurger.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSelectBurger.FlatAppearance.BorderSize = 0;
            this.btSelectBurger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelectBurger.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSelectBurger.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSelectBurger.Image = ((System.Drawing.Image)(resources.GetObject("btSelectBurger.Image")));
            this.btSelectBurger.Location = new System.Drawing.Point(34, 87);
            this.btSelectBurger.Name = "btSelectBurger";
            this.btSelectBurger.Size = new System.Drawing.Size(116, 110);
            this.btSelectBurger.TabIndex = 16;
            this.btSelectBurger.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSelectBurger.UseVisualStyleBackColor = false;
            this.btSelectBurger.Click += new System.EventHandler(this.btSelectBurger_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(306, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 456);
            this.panel9.TabIndex = 14;
            // 
            // FoodShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 639);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.GreyPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Name = "FoodShop";
            this.Load += new System.EventHandler(this.FoodShop_Load);
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
        private System.Windows.Forms.Label lbVAT;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Panel sub_rightPanel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBackToMainForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel GreyPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFoodID;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panelSubLeft;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchFood;
        private System.Windows.Forms.Button btSelectBurger;
        private System.Windows.Forms.Button btnSelectCoffee;
        private System.Windows.Forms.Button btnSeletedCoca;
        private System.Windows.Forms.Button btnSeletedSalad;
        private System.Windows.Forms.Button btnSelectedBeer;
        private System.Windows.Forms.Button btnSelectedFrenchFies;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Drawing.Printing.PrintDocument pdoc;
    }
}