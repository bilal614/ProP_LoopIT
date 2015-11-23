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
            this.lblTxtBox = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBackToMainForm = new System.Windows.Forms.Button();
            this.btnLoadFileAndSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 99);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(646, 215);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lblTxtBox
            // 
            this.lblTxtBox.AutoSize = true;
            this.lblTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtBox.Location = new System.Drawing.Point(6, 75);
            this.lblTxtBox.Name = "lblTxtBox";
            this.lblTxtBox.Size = new System.Drawing.Size(160, 17);
            this.lblTxtBox.TabIndex = 2;
            this.lblTxtBox.Text = "Text from text-file below:";
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
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.panel3);
            this.bottomPanel.Controls.Add(this.btnBackToMainForm);
            this.bottomPanel.Controls.Add(this.btnLoadFileAndSave);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 323);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(661, 114);
            this.bottomPanel.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 5);
            this.panel3.TabIndex = 16;
            // 
            // btnBackToMainForm
            // 
            this.btnBackToMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToMainForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainForm.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToMainForm.Image")));
            this.btnBackToMainForm.Location = new System.Drawing.Point(554, 11);
            this.btnBackToMainForm.Name = "btnBackToMainForm";
            this.btnBackToMainForm.Size = new System.Drawing.Size(95, 96);
            this.btnBackToMainForm.TabIndex = 1;
            this.btnBackToMainForm.Text = "Back";
            this.btnBackToMainForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBackToMainForm.UseVisualStyleBackColor = true;
            // 
            // btnLoadFileAndSave
            // 
            this.btnLoadFileAndSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFileAndSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFileAndSave.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadFileAndSave.Image")));
            this.btnLoadFileAndSave.Location = new System.Drawing.Point(361, 11);
            this.btnLoadFileAndSave.Name = "btnLoadFileAndSave";
            this.btnLoadFileAndSave.Size = new System.Drawing.Size(187, 96);
            this.btnLoadFileAndSave.TabIndex = 1;
            this.btnLoadFileAndSave.Text = "Load file and save to DB";
            this.btnLoadFileAndSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoadFileAndSave.UseVisualStyleBackColor = true;
            this.btnLoadFileAndSave.Click += new System.EventHandler(this.btnLoadFileAndSave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 5);
            this.panel2.TabIndex = 17;
            // 
            // PayPalTextFileTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 437);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.lblTxtBox);
            this.Controls.Add(this.richTextBox1);
            this.Name = "PayPalTextFileTranslator";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblTxtBox;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button btnBackToMainForm;
        private System.Windows.Forms.Button btnLoadFileAndSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}