namespace Iberdrola_app.Forms
{
    partial class FormUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridUsers = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.lbladress = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.textAddres = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridUsers
            // 
            this.GridUsers.AllowUserToAddRows = false;
            this.GridUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GridUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridUsers.BackgroundColor = System.Drawing.Color.White;
            this.GridUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridUsers.GridColor = System.Drawing.Color.White;
            this.GridUsers.Location = new System.Drawing.Point(20, 475);
            this.GridUsers.Name = "GridUsers";
            this.GridUsers.RowTemplate.Height = 25;
            this.GridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridUsers.Size = new System.Drawing.Size(1017, 160);
            this.GridUsers.StandardTab = true;
            this.GridUsers.TabIndex = 0;
            this.GridUsers.VirtualMode = true;
            this.GridUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridUsers_RowHeaderMouseClick);
            // 
            // btnInsert
            // 
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnInsert.Location = new System.Drawing.Point(20, 23);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(182, 60);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Nuevo Usuario";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnUpdate.Location = new System.Drawing.Point(20, 89);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(182, 60);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnDelete.Location = new System.Drawing.Point(20, 155);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 60);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(227, 25);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(337, 23);
            this.textName.TabIndex = 4;
            this.textName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbladress
            // 
            this.lbladress.AutoSize = true;
            this.lbladress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbladress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbladress.Location = new System.Drawing.Point(0, 183);
            this.lbladress.Margin = new System.Windows.Forms.Padding(3, 20, 20, 0);
            this.lbladress.Name = "lbladress";
            this.lbladress.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lbladress.Size = new System.Drawing.Size(85, 61);
            this.lbladress.TabIndex = 5;
            this.lbladress.Text = "Domicilio";
            this.lbladress.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastname.Location = new System.Drawing.Point(0, 61);
            this.lblLastname.Margin = new System.Windows.Forms.Padding(3, 20, 20, 0);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblLastname.Size = new System.Drawing.Size(82, 61);
            this.lblLastname.TabIndex = 7;
            this.lblLastname.Text = "Apellidos";
            this.lblLastname.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(227, 79);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(337, 23);
            this.textLastName.TabIndex = 6;
            this.textLastName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 20, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.label1.Size = new System.Drawing.Size(80, 61);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombres";
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(227, 135);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(337, 23);
            this.textDni.TabIndex = 8;
            this.textDni.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(0, 122);
            this.lblDni.Margin = new System.Windows.Forms.Padding(3, 20, 20, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblDni.Size = new System.Drawing.Size(40, 61);
            this.lblDni.TabIndex = 10;
            this.lblDni.Text = "DNI";
            this.lblDni.Click += new System.EventHandler(this.lblDni_Click);
            // 
            // textAddres
            // 
            this.textAddres.Location = new System.Drawing.Point(227, 195);
            this.textAddres.Name = "textAddres";
            this.textAddres.Size = new System.Drawing.Size(337, 23);
            this.textAddres.TabIndex = 11;
            this.textAddres.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(230, 257);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(334, 23);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2024, 1, 7, 0, 0, 0, 0);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblData.Location = new System.Drawing.Point(0, 244);
            this.lblData.Margin = new System.Windows.Forms.Padding(3, 20, 20, 0);
            this.lblData.Name = "lblData";
            this.lblData.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblData.Size = new System.Drawing.Size(173, 61);
            this.lblData.TabIndex = 13;
            this.lblData.Text = "Fecha De Nacimiento";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textAddres);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lbladress);
            this.panel1.Controls.Add(this.textLastName);
            this.panel1.Controls.Add(this.lblDni);
            this.panel1.Controls.Add(this.lblLastname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textDni);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(473, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panel1.Size = new System.Drawing.Size(564, 455);
            this.panel1.TabIndex = 14;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 655);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.GridUsers);
            this.Name = "FormUsers";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView GridUsers;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox textName;
        private Label lbladress;
        private Label lblLastname;
        private TextBox textLastName;
        private Label label1;
        private TextBox textDni;
        private Label lblDni;
        private TextBox textAddres;
        private DateTimePicker dateTimePicker1;
        private Label lblData;
        private Panel panel1;
    }
}