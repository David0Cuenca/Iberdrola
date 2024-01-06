namespace Iberdrola_app
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form ActiveForm;
        public Form1()
        {
            InitializeComponent();
            random= new Random();   
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

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
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

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}