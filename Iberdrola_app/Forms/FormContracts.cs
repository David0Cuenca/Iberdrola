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
                    GridContracts.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No hay contratos para el DNI proporcionado.");
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
            textSearchDni.Text = string.Empty;
            textContActivity.Text = string.Empty;
            textContModel.Text = string.Empty;
            
        }
        private void AddContract()
        {
            try
            {
                int tarifa = (checkTarifa.GetItemChecked(0)) ? 14 : 16;

                conn.Open();
                int nuevoContador = NewCont();
                cmd = new NpgsqlCommand("INSERT INTO Contrato (DNI_Cliente, id_cont, id_tarifa) VALUES (@dni, @contador, @tarifa)", conn);
                cmd.Parameters.AddWithValue("@dni", textDni.Text);
                cmd.Parameters.AddWithValue("@contador", nuevoContador);
                cmd.Parameters.AddWithValue("@tarifa", tarifa);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Contrato agregado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el contrato: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                ClearControls();
            }
        }
        private void DeleteContract()
        {
                try
                {
                    if (GridContracts.SelectedRows.Count > 0)
                    {
                        int idContrato = Convert.ToInt32(GridContracts.SelectedRows[0].Cells["id_contrato"].Value);

                        conn.Open();
                        cmd = new NpgsqlCommand("DELETE FROM contrato WHERE id_contrato = @id_contract;", conn);
                        cmd.Parameters.AddWithValue("@id_contract", idContrato);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Contrato eliminado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un contrato para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el contrato: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                    ClearControls();
                }
            }


        private int NewCont()
        {
            try
            {
                cmd = new NpgsqlCommand("INSERT INTO contador (modelo, actividad) VALUES (@model, @activity) RETURNING id_cont;", conn);
                cmd.Parameters.AddWithValue("@model", textContModel.Text);
                cmd.Parameters.AddWithValue("@activity", textContActivity.Text);

                // Ejecutar la consulta y obtener el valor generado para id_cont
                int nuevoContador = Convert.ToInt32(cmd.ExecuteScalar());

                return nuevoContador;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el nuevo contador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
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
                if (VerifyDni(textSearchDni.Text))
                {
                    SearchDni(textSearchDni.Text);
                }
                else
                {
                    MessageBox.Show("El Formato del dni es incorrecto");
                }
                
            }
            else
            {
                MessageBox.Show("El campo DNI esta vacio para su busqueda");
            }
        }

        private void FormContracts_Load(object sender, EventArgs e)
        {
            LoadTheme();
            checkTarifa.SetItemChecked(0, true);
        }

        private void lblSearchDni_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (textDni.Text != "" && textContModel.Text != "" && textContActivity.Text != "")
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

        private void checkTarifa_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < checkTarifa.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkTarifa.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void GridContracts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textDni.Text = GridContracts.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
