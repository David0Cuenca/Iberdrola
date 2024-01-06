namespace Iberdrola_app
{
    public partial class FormMainMenu : Form
    {
        private Button? currentButton;
        private Random random;
        private int tempIndex;
        private Form ActiveForm;
        public FormMainMenu()
        {
            InitializeComponent();
            random= new Random();   
            /*btnCloseChildForm.Visible = false;*/
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnSender) {
            if(btnSender != null) 
            {
                if(currentButton != (Button)btnSender) 
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    panelTitleBar.BackColor= color;
                    panelLogo.BackColor= ThemeColor.ChangeColorBrightness(color,-0.3); 
                    ThemeColor.PrimaryColor= color;
                    ThemeColor.SecondaryColor= ThemeColor.ChangeColorBrightness(color, -0.3); 
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor= Color.FromArgb(51,51,76);
                    previousBtn.ForeColor= Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
        }
        
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(ActiveForm!=null)
            {
                ActiveForm.Close();
            }
            ActiveButton(btnSender);
            ActiveForm= childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text=childForm.Text;

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormUsers(), sender);
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBills(), sender);
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormContracts(), sender);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseChild_Click(object sender, EventArgs e)
        {
            if (ActiveForm != null) 
                ActiveForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "Home";
            panelTitleBar.BackColor= Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(50, 61, 100);
            currentButton = null;
           /* btnCloseChildForm.Visble = false;*/
        }

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}