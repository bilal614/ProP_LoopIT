namespace JazzEventProject
{
    partial class PayPalTextFileTranslator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayPalTextFileTranslator));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLoadSaveToDB = new System.Windows.Forms.Button();
            this.lblTxtBox = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 91);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(629, 170);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnLoadSaveToDB
            // 
            this.btnLoadSaveToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSaveToDB.Location = new System.Drawing.Point(496, 281);
            this.btnLoadSaveToDB.Name = "btnLoadSaveToDB";
            this.btnLoadSaveToDB.Size = new System.Drawing.Size(145, 81);
            this.btnLoadSaveToDB.TabIndex = 1;
            this.btnLoadSaveToDB.Text = "Load File and Save To DB ";
            this.btnLoadSaveToDB.UseVisualStyleBackColor = true;
            // 
            // lblTxtBox
            // 
            this.lblTxtBox.AutoSize = true;
            this.lblTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtBox.Location = new System.Drawing.Point(12, 71);
            this.lblTxtBox.Name = "lblTxtBox";
            this.lblTxtBox.Size = new System.Drawing.Size(160, 17);
            this.lblTxtBox.TabIndex = 2;
            this.lblTxtBox.Text = "Text from text-file below:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(253, 304);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(215, 35);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back To Main Form";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Controls.Add(this.label2);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(661, 64);
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
            this.label2.Size = new System.Drawing.Size(234, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "PAYPAL TRANSACTIONS";
            // 
            // PayPalTextFileTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 369);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTxtBox);
            this.Controls.Add(this.btnLoadSaveToDB);
            this.Controls.Add(this.richTextBox1);
            this.Name = "PayPalTextFileTranslator";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnLoadSaveToDB;
        private System.Windows.Forms.Label lblTxtBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}