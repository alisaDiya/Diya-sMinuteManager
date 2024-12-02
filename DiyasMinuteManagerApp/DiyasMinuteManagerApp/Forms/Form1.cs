using DiyasMinuteManagerApp.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DiyasMinuteManagerApp
{
    public partial class Form1 : MaterialForm

    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCaptureMeeting_Click(object sender, EventArgs e)
        {
            captureMeetingForm cpnew = new captureMeetingForm();
            MessageBox.Show("You will now be taken to the next screen to Capture a meeting", "Next screen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cpnew.Show();
        }

        private void btnManageMeetingItem_Click(object sender, EventArgs e)
        {
            manageMeetingItemsForm manageMeetingItemsForm = new manageMeetingItemsForm();

            // Show the form as a dialog
            manageMeetingItemsForm.ShowDialog();

        }
    }
}
