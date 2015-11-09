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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLoadSaveToDB = new System.Windows.Forms.Button();
            this.lblTxtBox = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(392, 170);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnLoadSaveToDB
            // 
            this.btnLoadSaveToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSaveToDB.Location = new System.Drawing.Point(420, 38);
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
            this.lblTxtBox.Location = new System.Drawing.Point(12, 18);
            this.lblTxtBox.Name = "lblTxtBox";
            this.lblTxtBox.Size = new System.Drawing.Size(160, 17);
            this.lblTxtBox.TabIndex = 2;
            this.lblTxtBox.Text = "Text from text-file below:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 214);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(215, 35);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back To Main Form";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // PayPalTextFileTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 261);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTxtBox);
            this.Controls.Add(this.btnLoadSaveToDB);
            this.Controls.Add(this.richTextBox1);
            this.Name = "PayPalTextFileTranslator";
            this.Text = "PayPalTextFileTranslator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnLoadSaveToDB;
        private System.Windows.Forms.Label lblTxtBox;
        private System.Windows.Forms.Button btnBack;
    }
}