namespace JazzEventProject_V1
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
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
            this.button1.Location = new System.Drawing.Point(489, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update Table Data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Back To Main Form";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(489, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(273, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Print Report";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // EventStatusReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 265);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EventStatusReport";
            this.Text = "EventStatusReport";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}