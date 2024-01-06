using Npgsql;
using System.Data;

namespace Iberdrola_app.Forms
{
    public partial class FormUsers : Form
    {

        public FormUsers()
        {
            InitializeComponent();
            MostrarUsuarios();
            LoadTheme();
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

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Iberdrola;User Id=postgres;Password=123456"))
            {
                conn.Open();

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

        private void GridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
