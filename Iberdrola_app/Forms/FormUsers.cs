using Npgsql;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Iberdrola_app.Forms
{
    public partial class FormUsers : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Iberdrola;User Id=postgres;Password=123456");
        private NpgsqlCommand cmd;
        private string OldDni;
        public FormUsers()
        {
            InitializeComponent();
            MostrarUsuarios();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            btnUpdate.BackColor = ThemeColor.PrimaryColor;
            btnDelete.BackColor = ThemeColor.PrimaryColor;
        }

        private void MostrarUsuarios()
        {
            try
            {
                DataTable dataTable = ObtenerDatosConsulta("select * from cliente natural join cliente_activo");

                if (dataTable.Rows.Count > 0)
                {
                    GridUsers.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private DataTable ObtenerDatosConsulta(string consulta)
        {
            DataTable dataTable = new DataTable();
            conn.Open();
            {
                

                using (NpgsqlCommand comm = new NpgsqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = consulta;

                    using (NpgsqlDataReader dr = comm.ExecuteReader())
                    {
                        dataTable.Load(dr);
                    }
                }

                conn.Close();
            }

            return dataTable;
        }

        private void AddUser()
        {
           conn.Open();
           cmd = new NpgsqlCommand("INSERT INTO Cliente (DNI, Nombre, Apellidos, Nacimiento, Domicilio) VALUES (@dni,@name,@lastname,@birth,@adress)", conn);
           
           cmd.Parameters.AddWithValue("@dni", textDni.Text);
           cmd.Parameters.AddWithValue("@name", textName.Text);
           cmd.Parameters.AddWithValue("@lastname", textLastName.Text);
           cmd.Parameters.AddWithValue("@birth", DateTime.Parse(dateTimePicker1.Text));
           cmd.Parameters.AddWithValue("@adress", textDni.Text);
           cmd.ExecuteNonQuery();
           conn.Close();
           MessageBox.Show("Los datos han sido introducidos de forma correcta");
           MostrarUsuarios();
           ClearControls();   
        }

        private void UpdateUser()
        {

            conn.Open();
            cmd = new NpgsqlCommand("UPDATE cliente " +
            "SET dni =@dni, nombre =@name, nacimiento=@birth, domicilio =@adress, apellidos=@lastname " +
            "WHERE dni=@olddni; ", conn);

            cmd.Parameters.AddWithValue("@dni", textDni.Text);
            cmd.Parameters.AddWithValue("@name", textName.Text);
            cmd.Parameters.AddWithValue("@lastname", textLastName.Text);
            cmd.Parameters.AddWithValue("@birth", DateTime.Parse(dateTimePicker1.Text));
            cmd.Parameters.AddWithValue("@adress", textAddres.Text);
            cmd.Parameters.AddWithValue("@olddni", OldDni);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Los datos han sido introducidos de forma correcta");
            MostrarUsuarios();
            ClearControls();
        }
        private void DeleteUser()
        {
            conn.Open();
            cmd = new NpgsqlCommand("DELETE FROM cliente_activo WHERE dni=@dni", conn);
            cmd.Parameters.AddWithValue("@dni", textDni.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("El usuario a sido eliminado");
            MostrarUsuarios();
            ClearControls();
        }

        private bool VerifyDni(string dni)
        {
            string patronDni = @"^\d{8}[A-HJ-NP-TV-Z]$";
            return Regex.IsMatch(dni, patronDni, RegexOptions.IgnoreCase);
        }

        private void ClearControls()
        {
            textDni.Text =string.Empty;
            textName.Text =string.Empty;
            textLastName.Text =string.Empty;
            textAddres.Text =string.Empty;
            dateTimePicker1.Value=DateTime.Today;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (textName.Text != "" && textLastName.Text != "" && textAddres.Text != "" && textDni.Text != "")
            {
                if (VerifyDni(textDni.Text))
                {
                    AddUser();
                }
                else
                {
                    MessageBox.Show("!El DNI no es valido¡");
                }
            }
            else
            {
                MessageBox.Show("!Introduzca todos los datos requeridos¡");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (textName.Text != "" && textLastName.Text != "" && textAddres.Text != "" && textDni.Text != "")
            {
                if (VerifyDni(textDni.Text))
                {
                    UpdateUser();
                }
                else
                {
                    MessageBox.Show("!El DNI no es valido¡");
                }
            }
            else
            {
                MessageBox.Show("!Introduzca todos los datos requeridos¡");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textDni.Text != "")
            {
                DeleteUser();
            }
            else
            {
                MessageBox.Show("Seleciona un usuario para eliminar");
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblDni_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void GridUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            OldDni = textDni.Text = GridUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
            textDni.Text = GridUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
            textName.Text = GridUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker1.Value = (DateTime)GridUsers.Rows[e.RowIndex].Cells[2].Value;
            textAddres.Text = GridUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
            textLastName.Text = GridUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
