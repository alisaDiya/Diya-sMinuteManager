using DiyasMinuteManagerApp.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DiyasMinuteManagerApp
{
    //Form 1 is inheriting from MaterialForm
    public partial class Form1 : MaterialForm

    {
        public Form1()
        {
            InitializeComponent();
            // Configure MaterialSkinManager for applying Material Design themes and colors
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Event handler for the "Capture Meeting" button click
        private void btnCaptureMeeting_Click(object sender, EventArgs e)
        {
            // Create an instance of the captureMeetingForm
            captureMeetingForm captureMeetingForm = new captureMeetingForm();
            MessageBox.Show("You will now be taken to the next screen to Capture a meeting", "Next screen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            captureMeetingForm.Show();
        }
        // Event handler for the "Manage Meeting Items" button click
        private void btnManageMeetingItem_Click(object sender, EventArgs e)
        {
            manageMeetingItemsForm manageMeetingItemsForm = new manageMeetingItemsForm();
            manageMeetingItemsForm.ShowDialog();

        }
        // Event handler for the "Exit" button click
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You will now exit the application ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }
    }
}
