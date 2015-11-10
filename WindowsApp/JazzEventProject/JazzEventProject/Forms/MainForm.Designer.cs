namespace JazzEventProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.formButtonPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximine = new System.Windows.Forms.Button();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnCamp = new System.Windows.Forms.Button();
            this.btnEventEntrance = new System.Windows.Forms.Button();
            this.Headerpanel.SuspendLayout();
            this.formButtonPanel.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(155)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jazz Festival";
            // 
            // Headerpanel
            // 
            this.Headerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.Headerpanel.Controls.Add(this.formButtonPanel);
            this.Headerpanel.Controls.Add(this.label1);
            this.Headerpanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpanel.Location = new System.Drawing.Point(0, 0);
            this.Headerpanel.Name = "Headerpanel";
            this.Headerpanel.Size = new System.Drawing.Size(895, 84);
            this.Headerpanel.TabIndex = 2;
            this.Headerpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Headerpanel_MouseMove);
            // 
            // formButtonPanel
            // 
            this.formButtonPanel.Controls.Add(this.button1);
            this.formButtonPanel.Controls.Add(this.btnMinimize);
            this.formButtonPanel.Controls.Add(this.btnMaximine);
            this.formButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.formButtonPanel.Location = new System.Drawing.Point(758, 0);
            this.formButtonPanel.Name = "formButtonPanel";
            this.formButtonPanel.Size = new System.Drawing.Size(137, 84);
            this.formButtonPanel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(90, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 39);
            this.button1.TabIndex = 1;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(3, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(48, 39);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximine
            // 
            this.btnMaximine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMaximine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximine.FlatAppearance.BorderSize = 0;
            this.btnMaximine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximine.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMaximine.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximine.Image")));
            this.btnMaximine.Location = new System.Drawing.Point(48, 0);
            this.btnMaximine.Name = "btnMaximine";
            this.btnMaximine.Size = new System.Drawing.Size(45, 39);
            this.btnMaximine.TabIndex = 1;
            this.btnMaximine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaximine.UseVisualStyleBackColor = false;
            this.btnMaximine.Click += new System.EventHandler(this.btnMaximine_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.centerPanel.Controls.Add(this.btnPayment);
            this.centerPanel.Controls.Add(this.btnExit);
            this.centerPanel.Controls.Add(this.btnMaterial);
            this.centerPanel.Controls.Add(this.btnFood);
            this.centerPanel.Controls.Add(this.btnStatus);
            this.centerPanel.Controls.Add(this.btnCamp);
            this.centerPanel.Controls.Add(this.btnEventEntrance);
            this.centerPanel.Location = new System.Drawing.Point(40, 104);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(802, 358);
            this.centerPanel.TabIndex = 3;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnPayment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.Location = new System.Drawing.Point(611, 58);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(166, 113);
            this.btnPayment.TabIndex = 8;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(33, 190);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 113);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit event";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnMaterial.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaterial.FlatAppearance.BorderSize = 0;
            this.btnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterial.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMaterial.Image = ((System.Drawing.Image)(resources.GetObject("btnMaterial.Image")));
            this.btnMaterial.Location = new System.Drawing.Point(421, 190);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(166, 113);
            this.btnMaterial.TabIndex = 3;
            this.btnMaterial.Text = "Loan material";
            this.btnMaterial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMaterial.UseVisualStyleBackColor = false;
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnFood.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFood.Image = ((System.Drawing.Image)(resources.GetObject("btnFood.Image")));
            this.btnFood.Location = new System.Drawing.Point(421, 58);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(166, 107);
            this.btnFood.TabIndex = 4;
            this.btnFood.Text = "Food shop";
            this.btnFood.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFood.UseVisualStyleBackColor = false;
            // 
            // btnStatus
            // 
            this.btnStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnStatus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnStatus.Image")));
            this.btnStatus.Location = new System.Drawing.Point(612, 190);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(166, 113);
            this.btnStatus.TabIndex = 5;
            this.btnStatus.Text = "Status of event";
            this.btnStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStatus.UseVisualStyleBackColor = false;
            // 
            // btnCamp
            // 
            this.btnCamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnCamp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCamp.FlatAppearance.BorderSize = 0;
            this.btnCamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCamp.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCamp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCamp.Image = ((System.Drawing.Image)(resources.GetObject("btnCamp.Image")));
            this.btnCamp.Location = new System.Drawing.Point(225, 58);
            this.btnCamp.Name = "btnCamp";
            this.btnCamp.Size = new System.Drawing.Size(166, 245);
            this.btnCamp.TabIndex = 6;
            this.btnCamp.Text = "Camp managment";
            this.btnCamp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCamp.UseVisualStyleBackColor = false;
            this.btnCamp.Click += new System.EventHandler(this.btnCamp_Click);
            // 
            // btnEventEntrance
            // 
            this.btnEventEntrance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.btnEventEntrance.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEventEntrance.FlatAppearance.BorderSize = 0;
            this.btnEventEntrance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventEntrance.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventEntrance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEventEntrance.Image = ((System.Drawing.Image)(resources.GetObject("btnEventEntrance.Image")));
            this.btnEventEntrance.Location = new System.Drawing.Point(33, 58);
            this.btnEventEntrance.Name = "btnEventEntrance";
            this.btnEventEntrance.Size = new System.Drawing.Size(166, 107);
            this.btnEventEntrance.TabIndex = 7;
            this.btnEventEntrance.Text = "Event entrance";
            this.btnEventEntrance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEventEntrance.UseVisualStyleBackColor = false;
            this.btnEventEntrance.Click += new System.EventHandler(this.btnEventEntrance_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(895, 487);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.Headerpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Jazz Festival Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Headerpanel.ResumeLayout(false);
            this.Headerpanel.PerformLayout();
            this.formButtonPanel.ResumeLayout(false);
            this.centerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Headerpanel;
        private System.Windows.Forms.Button btnMaximine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel formButtonPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnCamp;
        private System.Windows.Forms.Button btnEventEntrance;
        private System.Windows.Forms.Button btnPayment;

    }
}