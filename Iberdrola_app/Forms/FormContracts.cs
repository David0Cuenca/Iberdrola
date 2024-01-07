using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iberdrola_app.Forms
{
    public partial class FormContracts : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Iberdrola;User Id=postgres;Password=123456");
        private NpgsqlCommand cmd;

        public FormContracts()
        {
            InitializeComponent();
            checkTarifa.SetItemChecked(0, true);
        }

        

        private void SearchDni(string dni)
        {
            try
            {
                conn.Open();
                string consulta = "SELECT * FROM Contrato WHERE dni_Cliente = @dni";
                cmd = new NpgsqlCommand(consulta, conn);
                cmd.Parameters.AddWithValue("@dni", dni);

                DataTable dataTable = new DataTable();

                using (NpgsqlDataReader dr = cmd.ExecuteReader())
                {
                    dataTable.Load(dr);
                }

                if (dataTable.Rows.Count > 0)
                {
                    // Asigna el resultado al DataGridView o cualquier otro control que estés utilizando
                    GridContracts.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No hay contratos para el DNI proporcionado.");
                    // Puedes limpiar el contenido del DataGridView o realizar otras acciones según tus necesidades.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener contratos: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
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
        }
        private bool VerifyDni(string dni)
        {
            string patronDni = @"^\d{8}[A-HJ-NP-TV-Z]$";
            return Regex.IsMatch(dni, patronDni, RegexOptions.IgnoreCase);
        }

        private void ClearControls()
        {
            textDni.Text = string.Empty;
            textCont.Text = string.Empty;
            
        }
        private void AddContract()
        {
            throw new NotImplementedException();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUserContract_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textSearchDni.Text))
            {
                SearchDni(textSearchDni.Text);
            }
            else
            {
                MessageBox.Show("Ingrese un DNI válido para mostrar los contratos.");
            }
        }

        private void FormContracts_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void lblSearchDni_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (textDni.Text != "" && textCont.Text != "")
            {
                if (VerifyDni(textDni.Text))
                {
                    AddContract();
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



        private void textSearchDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
