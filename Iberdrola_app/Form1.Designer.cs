namespace Iberdrola_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnBills);
            this.panelMenu.Controls.Add(this.btnContracts);
            this.panelMenu.Controls.Add(this.btnUsers);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 634);
            this.panelMenu.TabIndex = 0;
            // 
            // btnBills
            // 
            this.btnBills.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBills.FlatAppearance.BorderSize = 0;
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBills.ForeColor = System.Drawing.Color.White;
            this.btnBills.Image = global::Iberdrola_app.Properties.Resources.factura_s;
            this.btnBills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBills.Location = new System.Drawing.Point(0, 220);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(220, 60);
            this.btnBills.TabIndex = 3;
            this.btnBills.Text = "Facturación";
            this.btnBills.UseVisualStyleBackColor = true;
            this.btnBills.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnContracts
            // 
            this.btnContracts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContracts.FlatAppearance.BorderSize = 0;
            this.btnContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContracts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnContracts.ForeColor = System.Drawing.Color.White;
            this.btnContracts.Image = global::Iberdrola_app.Properties.Resources.contrato_s1;
            this.btnContracts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContracts.Location = new System.Drawing.Point(0, 160);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(220, 60);
            this.btnContracts.TabIndex = 2;
            this.btnContracts.Text = "Contratos";
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::Iberdrola_app.Properties.Resources.Users_s;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 100);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(220, 60);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Usuarios";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(88, 35);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(109, 30);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Iberdrola";
            this.lblLogo.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(868, 100);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(404, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Iberdrola_app.Properties.Resources.Iberdrola_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 60);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(220, 100);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(868, 534);
            this.panelDesktopPanel.TabIndex = 2;
            this.panelDesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 634);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button btnUsers;
        private Panel panelLogo;
        private Button btnBills;
        private Button btnContracts;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label lblLogo;
        private PictureBox pictureBox1;
        private Panel panelDesktopPanel;
    }
}