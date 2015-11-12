namespace JazzEventProject.Forms
{
    partial class FoodLists
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
            this.dataGridViewFoodList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoodList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFoodList
            // 
            this.dataGridViewFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFoodList.Location = new System.Drawing.Point(12, 29);
            this.dataGridViewFoodList.Name = "dataGridViewFoodList";
            this.dataGridViewFoodList.Size = new System.Drawing.Size(578, 177);
            this.dataGridViewFoodList.TabIndex = 0;
            // 
            // FoodLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 301);
            this.Controls.Add(this.dataGridViewFoodList);
            this.Name = "FoodLists";
            this.Text = "List of food";
            this.Load += new System.EventHandler(this.FoodLists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFoodList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFoodList;
    }
}