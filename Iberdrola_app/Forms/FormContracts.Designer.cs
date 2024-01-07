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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridContracts = new System.Windows.Forms.DataGridView();
            this.lblDni = new System.Windows.Forms.Label();
            this.textDni = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textContActivity = new System.Windows.Forms.TextBox();
            this.lblContActivity = new System.Windows.Forms.Label();
            this.textContModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.checkTarifa = new System.Windows.Forms.CheckedListBox();
            this.lblSearchDni = new System.Windows.Forms.Label();
            this.textSearchDni = new System.Windows.Forms.TextBox();
            this.btnUserContract = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridContracts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridContracts
            // 
            this.GridContracts.AllowUserToAddRows = false;
            this.GridContracts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GridContracts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridContracts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridContracts.BackgroundColor = System.Drawing.Color.White;
            this.GridContracts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridContracts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.GridContracts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridContracts_RowHeaderMouseClick);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(28, 44);
            this.lblDni.Margin = new System.Windows.Forms.Padding(3, 20, 20, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblDni.Size = new System.Drawing.Size(40, 61);
            this.lblDni.TabIndex = 24;
            this.lblDni.Text = "DNI";
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(255, 57);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(289, 23);
            this.textDni.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textContActivity);
            this.panel1.Controls.Add(this.lblContActivity);
            this.panel1.Controls.Add(this.textContModel);
            this.panel1.Controls.Add(this.lblModel);
            this.panel1.Controls.Add(this.checkTarifa);
            this.panel1.Controls.Add(this.textDni);
            this.panel1.Controls.Add(this.lblDni);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(548, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 428);
            this.panel1.TabIndex = 28;
            // 
            // textContActivity
            // 
            this.textContActivity.Location = new System.Drawing.Point(255, 195);
            this.textContActivity.Name = "textContActivity";
            this.textContActivity.Size = new System.Drawing.Size(289, 23);
            this.textContActivity.TabIndex = 30;
            this.textContActivity.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblContActivity
            // 
            this.lblContActivity.AutoSize = true;
            this.lblContActivity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContActivity.Location = new System.Drawing.Point(28, 182);
            this.lblContActivity.Margin = new System.Windows.Forms.Padding(3, 20, 20, 0);
            this.lblContActivity.Name = "lblContActivity";
            this.lblContActivity.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblContActivity.Size = new System.Drawing.Size(184, 61);
            this.lblContActivity.TabIndex = 31;
            this.lblContActivity.Text = "Actividad del contador";
            this.lblContActivity.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // textContModel
            // 
            this.textContModel.Location = new System.Drawing.Point(255, 126);
            this.textContModel.Name = "textContModel";
            this.textContModel.Size = new System.Drawing.Size(289, 23);
            this.textContModel.TabIndex = 28;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModel.Location = new System.Drawing.Point(28, 113);
            this.lblModel.Margin = new System.Windows.Forms.Padding(3, 20, 20, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblModel.Size = new System.Drawing.Size(144, 61);
            this.lblModel.TabIndex = 29;
            this.lblModel.Text = "Modelo Contador";
            this.lblModel.Click += new System.EventHandler(this.label1_Click_1);
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
            this.checkTarifa.Location = new System.Drawing.Point(252, 336);
            this.checkTarifa.Name = "checkTarifa";
            this.checkTarifa.Size = new System.Drawing.Size(115, 48);
            this.checkTarifa.TabIndex = 27;
            this.checkTarifa.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkTarifa_ItemCheck);
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
        private CheckedListBox checkTarifa;
        private TextBox textContModel;
        private Label lblModel;
        private TextBox textContActivity;
        private Label lblContActivity;
    }
}