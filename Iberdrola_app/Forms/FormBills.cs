using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iberdrola_app.Forms
{
    public partial class FormBills : Form
    {
        public FormBills()
        {
            InitializeComponent();
        }

        private void FormBills_Load(object sender, EventArgs e)
        {
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
    }
}
