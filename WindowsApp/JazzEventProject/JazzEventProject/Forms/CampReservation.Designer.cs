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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Camping_Reservation_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Camp_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event_Account_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnCheckIN = new System.Windows.Forms.Button();
            this.btnCheckOUT = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.Group_ID,
            this.E_mail,
            this.Event_Account_ID,
            this.RFID});
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 150);
            this.dataGridView1.TabIndex = 0;
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
            // Group_ID
            // 
            this.Group_ID.HeaderText = "Group ID";
            this.Group_ID.Name = "Group_ID";
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
            // RFID
            // 
            this.RFID.HeaderText = "RFID";
            this.RFID.Name = "RFID";
            // 
            // btnScan
            // 
            this.btnScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.Location = new System.Drawing.Point(483, 190);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(123, 38);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnCheckIN
            // 
            this.btnCheckIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIN.Location = new System.Drawing.Point(622, 190);
            this.btnCheckIN.Name = "btnCheckIN";
            this.btnCheckIN.Size = new System.Drawing.Size(106, 38);
            this.btnCheckIN.TabIndex = 2;
            this.btnCheckIN.Text = "Check IN";
            this.btnCheckIN.UseVisualStyleBackColor = true;
            // 
            // btnCheckOUT
            // 
            this.btnCheckOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOUT.Location = new System.Drawing.Point(748, 190);
            this.btnCheckOUT.Name = "btnCheckOUT";
            this.btnCheckOUT.Size = new System.Drawing.Size(107, 38);
            this.btnCheckOUT.TabIndex = 3;
            this.btnCheckOUT.Text = "Check OUT";
            this.btnCheckOUT.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(483, 246);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(372, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back To Main Form";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // CampReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 402);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCheckOUT);
            this.Controls.Add(this.btnCheckIN);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CampReservation";
            this.Text = "CampReservation";
            this.Load += new System.EventHandler(this.CampReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Camping_Reservation_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Camp_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn E_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event_Account_ID;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFID;
        private System.Windows.Forms.Button btnCheckIN;
        private System.Windows.Forms.Button btnCheckOUT;
        private System.Windows.Forms.Button btnBack;
    }
}