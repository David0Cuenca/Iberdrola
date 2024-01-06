using Npgsql;
using System.Data;

namespace Iberdrola_app.Forms
{
    public partial class FormUsers : Form
    {
        private string connstring = "Host=localhost;Username=postgres;Password=123456;Database=Iberdrola";
        private NpgsqlConnection conn;

        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
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
            /*label1.ForeColor = ThemeColor.PrimaryColor;*/
            /*label2.ForeColor = ThemeColor.SecondaryColor;*/
        }

/*        private async void ShowClients()
        {
            try
            {
                var clientesActivos = await conexion.ObtenerClientesActivosAsync();
                GridUsers.AutoGenerateColumns = true;
                GridUsers.DataSource = clientesActivos;

                foreach (DataGridViewColumn column in GridUsers.Columns)
                {
                    column.HeaderText = column.HeaderText.Replace("_", " ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }*/
    }
}
