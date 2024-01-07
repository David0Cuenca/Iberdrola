namespace Iberdrola_app.Forms
{
    partial class FormContracts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridContracts = new System.Windows.Forms.DataGridView();
            this.lblDni = new System.Windows.Forms.Label();
            this.textDni = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearchDni = new System.Windows.Forms.Label();
            this.textSearchDni = new System.Windows.Forms.TextBox();
            this.btnUserContract = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textCont = new System.Windows.Forms.TextBox();
            this.lblCont = new System.Windows.Forms.Label();
            this.checkTarifa = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridContracts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridContracts
            // 
            this.GridContracts.AllowUserToAddRows = false;
            this.GridContracts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GridContracts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.GridContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridContracts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridContracts.BackgroundColor = System.Drawing.Color.White;
            this.GridContracts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridContracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.GridContracts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridContracts.GridColor = System.Drawing.Color.White;
            this.GridContracts.Location = new System.Drawing.Point(0, 428);
            this.GridContracts.Name = "GridContracts";
            this.GridContracts.RowTemplate.Height = 25;
            this.GridContracts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridContracts.Size = new System.Drawing.Size(1161, 168);
            this.GridContracts.StandardTab = true;
            this.GridContracts.TabIndex = 14;
            this.GridContracts.VirtualMode = true;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(37, 42);
            this.lblDni.Margin = new System.Windows.Forms.Padding(3, 20, 20, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblDni.Size = new System.Drawing.Size(40, 61);
            this.lblDni.TabIndex = 24;
            this.lblDni.Text = "DNI";
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(264, 55);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(337, 23);
            this.textDni.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.checkTarifa);
            this.panel1.Controls.Add(this.textCont);
            this.panel1.Controls.Add(this.lblCont);
            this.panel1.Controls.Add(this.textDni);
            this.panel1.Controls.Add(this.lblDni);
            this.panel1.Location = new System.Drawing.Point(548, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 422);
            this.panel1.TabIndex = 28;
            // 
            // lblSearchDni
            // 
            this.lblSearchDni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchDni.AutoSize = true;
            this.lblSearchDni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchDni.Location = new System.Drawing.Point(77, 334);
            this.lblSearchDni.Name = "lblSearchDni";
            this.lblSearchDni.Size = new System.Drawing.Size(105, 15);
            this.lblSearchDni.TabIndex = 35;
            this.lblSearchDni.Text = "Introduzca el DNI";
            this.lblSearchDni.Click += new System.EventHandler(this.lblSearchDni_Click);
            // 
            // textSearchDni
            // 
            this.textSearchDni.Location = new System.Drawing.Point(36, 361);
            this.textSearchDni.Name = "textSearchDni";
            this.textSearchDni.Size = new System.Drawing.Size(184, 23);
            this.textSearchDni.TabIndex = 34;
            this.textSearchDni.TextChanged += new System.EventHandler(this.textSearchDni_TextChanged);
            // 
            // btnUserContract
            // 
            this.btnUserContract.FlatAppearance.BorderSize = 0;
            this.btnUserContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserContract.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUserContract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnUserContract.Location = new System.Drawing.Point(12, 240);
            this.btnUserContract.Name = "btnUserContract";
            this.btnUserContract.Size = new System.Drawing.Size(220, 60);
            this.btnUserContract.TabIndex = 31;
            this.btnUserContract.Text = "Contratos de un usuario";
            this.btnUserContract.UseVisualStyleBackColor = true;
            this.btnUserContract.Click += new System.EventHandler(this.btnUserContract_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCreate.Location = new System.Drawing.Point(12, 45);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(220, 60);
            this.btnCreate.TabIndex = 32;
            this.btnCreate.Text = "Crear Contrato";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnDelete.Location = new System.Drawing.Point(12, 142);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(220, 60);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Eliminar Contrato";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // textCont
            // 
            this.textCont.Location = new System.Drawing.Point(264, 128);
            this.textCont.Name = "textCont";
            this.textCont.Size = new System.Drawing.Size(337, 23);
            this.textCont.TabIndex = 25;
            this.textCont.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCont
            // 
            this.lblCont.AutoSize = true;
            this.lblCont.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCont.Location = new System.Drawing.Point(37, 115);
            this.lblCont.Margin = new System.Windows.Forms.Padding(3, 20, 20, 0);
            this.lblCont.Name = "lblCont";
            this.lblCont.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblCont.Size = new System.Drawing.Size(81, 61);
            this.lblCont.TabIndex = 26;
            this.lblCont.Text = "Contador";
            this.lblCont.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkTarifa
            // 
            this.checkTarifa.BackColor = System.Drawing.SystemColors.Control;
            this.checkTarifa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkTarifa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkTarifa.FormattingEnabled = true;
            this.checkTarifa.HorizontalExtent = 1;
            this.checkTarifa.Items.AddRange(new object[] {
            "PVPC",
            "Privada"});
            this.checkTarifa.Location = new System.Drawing.Point(251, 204);
            this.checkTarifa.Name = "checkTarifa";
            this.checkTarifa.Size = new System.Drawing.Size(115, 96);
            this.checkTarifa.TabIndex = 27;
            this.checkTarifa.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // FormContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 596);
            this.Controls.Add(this.lblSearchDni);
            this.Controls.Add(this.textSearchDni);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUserContract);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GridContracts);
            this.Name = "FormContracts";
            this.Text = "FormContracts";
            this.Load += new System.EventHandler(this.FormContracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridContracts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private DataGridView GridContracts;
        private Label lblDni;
        private TextBox textDni;
        private Panel panel1;
        private Label lblSearchDni;
        private TextBox textSearchDni;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUserContract;
        private TextBox textCont;
        private Label lblCont;
        private CheckedListBox checkTarifa;
    }
}