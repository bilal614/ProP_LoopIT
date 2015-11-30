namespace JazzEventProject
{
    partial class EventStatusReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventStatusReport));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NmbrOfReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketRev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CampingSitesRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CampingRev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodDrinkSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanMtrlRev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NmbrOfReg,
            this.TicketRev,
            this.CampingSitesRented,
            this.CampingRev,
            this.FoodDrinkSales,
            this.LoanMtrlRev,
            this.TotalRev});
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 226);
            this.dataGridView1.TabIndex = 0;
            //
            // NmbrOfReg
            // 
            this.NmbrOfReg.HeaderText = "Number Of Registrations";
            this.NmbrOfReg.Name = "NmbrOfReg";
            // 
            // TicketRev
            // 
            this.TicketRev.HeaderText = "Ticket Revenue";
            this.TicketRev.Name = "TicketRev";
            // 
            // CampingSitesRented
            // 
            this.CampingSitesRented.HeaderText = "Number of Camping Sites Rented";
            this.CampingSitesRented.Name = "CampingSitesRented";
            // 
            // CampingRev
            // 
            this.CampingRev.HeaderText = "Camping Revenue";
            this.CampingRev.Name = "CampingRev";
            // 
            // FoodDrinkSales
            // 
            this.FoodDrinkSales.HeaderText = "Food and Drink Sales";
            this.FoodDrinkSales.Name = "FoodDrinkSales";
            // 
            // LoanMtrlRev
            // 
            this.LoanMtrlRev.HeaderText = "Loan Material Revenue";
            this.LoanMtrlRev.Name = "LoanMtrlRev";
            // 
            // TotalRev
            // 
            this.TotalRev.HeaderText = "Total Revenue";
            this.TotalRev.Name = "TotalRev";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Controls.Add(this.label2);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(774, 64);
            this.HeaderPanel.TabIndex = 13;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(77, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "EVENT\'S REPORT";
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.btnPrint);
            this.bottomPanel.Controls.Add(this.panel3);
            this.bottomPanel.Controls.Add(this.btnBackToMainForm);
            this.bottomPanel.Controls.Add(this.btnUpdate);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 316);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(774, 114);
            this.bottomPanel.TabIndex = 17;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(541, 11);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(105, 96);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Print report";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(774, 5);
            this.panel3.TabIndex = 16;
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainForm.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToMainForm.Image")));
            this.btnBackToMainForm.Location = new System.Drawing.Point(667, 10);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(95, 96);
            this.btnBackToMainForm.TabIndex = 1;
            this.btnBackToMainForm.Text = "Back";
            this.btnBackToMainForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBackToMainForm.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(384, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 96);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update table data";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // EventStatusReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 430);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EventStatusReport";
            this.Load += new System.EventHandler(this.EventStatusReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NmbrOfReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketRev;
        private System.Windows.Forms.DataGridViewTextBoxColumn CampingSitesRented;
        private System.Windows.Forms.DataGridViewTextBoxColumn CampingRev;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodDrinkSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanMtrlRev;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRev;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBackToMainForm;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPrint;
    }
}