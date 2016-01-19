namespace JazzEventProject
{
    partial class CampReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampReservation));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Camping_Reservation_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Camp_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event_Account_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Camping_Reservation_Number,
            this.End_Date,
            this.Start_Date,
            this.Camp_ID,
            this.E_mail,
            this.Event_Account_ID,
            this.CheckIn});
            this.dataGridView1.Location = new System.Drawing.Point(0, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(942, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.label20);
            this.HeaderPanel.Controls.Add(this.label19);
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Controls.Add(this.label2);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(942, 64);
            this.HeaderPanel.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(528, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(184, 20);
            this.label20.TabIndex = 26;
            this.label20.Text = "Please scan an RFID.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(377, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(133, 20);
            this.label19.TabIndex = 25;
            this.label19.Text = "Scanned RFID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(77, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "CAMPING RESERVATION";
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.panel3);
            this.bottomPanel.Controls.Add(this.btnBackToMainForm);
            this.bottomPanel.Controls.Add(this.btnCheckOut);
            this.bottomPanel.Controls.Add(this.btnCheckIn);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 271);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(942, 114);
            this.bottomPanel.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(942, 5);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 5);
            this.panel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 5);
            this.panel1.TabIndex = 15;
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainForm.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToMainForm.Image")));
            this.btnBackToMainForm.Location = new System.Drawing.Point(835, 11);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(95, 96);
            this.btnBackToMainForm.TabIndex = 1;
            this.btnBackToMainForm.Text = "Back";
            this.btnBackToMainForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBackToMainForm.UseVisualStyleBackColor = true;
            this.btnBackToMainForm.Click += new System.EventHandler(this.btnBackToMainForm_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.Location = new System.Drawing.Point(717, 11);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(105, 96);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "Check out";
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckIn.Image")));
            this.btnCheckIn.Location = new System.Drawing.Point(596, 11);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(105, 96);
            this.btnCheckIn.TabIndex = 1;
            this.btnCheckIn.Text = "Check in";
            this.btnCheckIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
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
            // Camping_Reservation_Number
            // 
            this.Camping_Reservation_Number.HeaderText = "Camp Reservation Number";
            this.Camping_Reservation_Number.Name = "Camping_Reservation_Number";
            // 
            // End_Date
            // 
            this.End_Date.HeaderText = "End Date";
            this.End_Date.Name = "End_Date";
            // 
            // Start_Date
            // 
            this.Start_Date.HeaderText = "Start Date";
            this.Start_Date.Name = "Start_Date";
            // 
            // Camp_ID
            // 
            this.Camp_ID.HeaderText = "Camp ID";
            this.Camp_ID.Name = "Camp_ID";
            // 
            // E_mail
            // 
            this.E_mail.HeaderText = "E-mail";
            this.E_mail.Name = "E_mail";
            // 
            // Event_Account_ID
            // 
            this.Event_Account_ID.HeaderText = "Event Account ID";
            this.Event_Account_ID.Name = "Event_Account_ID";
            // 
            // CheckIn
            // 
            this.CheckIn.HeaderText = "Check In";
            this.CheckIn.Name = "CheckIn";
            // 
            // CampReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 385);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CampReservation";
            this.Text = "CampReservation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CampReservation_FormClosed);
            this.Load += new System.EventHandler(this.CampReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button btnBackToMainForm;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Camping_Reservation_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Camp_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn E_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event_Account_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckIn;
    }
}