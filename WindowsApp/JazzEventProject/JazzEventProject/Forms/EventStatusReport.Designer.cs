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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(750, 160);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(489, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update Table Data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Back To Main Form";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(489, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(273, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Print Report";
            this.button3.UseVisualStyleBackColor = true;
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
            // EventStatusReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 408);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EventStatusReport";
            this.Load += new System.EventHandler(this.EventStatusReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}