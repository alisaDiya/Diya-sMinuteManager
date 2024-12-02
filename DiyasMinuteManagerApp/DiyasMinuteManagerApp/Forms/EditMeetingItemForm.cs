using DiyasMinuteManagerApp.Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DiyasMinuteManagerApp.Forms
{
    // Form for editing meeting items, inheriting from MaterialForm
    public partial class EditMeetingItemForm : MaterialForm
    {
        private MeetingItemStatus meetingItemStatus;

        // Constructor for the form, taking a MeetingItemStatus object as a parameter
        public EditMeetingItemForm(MeetingItemStatus itemStatus)
        {
            InitializeComponent();
            // Populate form fields with data from the provided MeetingItemStatus object
            meetingItemStatus = itemStatus;
            txtStatus.Text = meetingItemStatus.Status;
            txtResponsiblePerson.Text = meetingItemStatus.ResponsiblePerson;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void EditMeetingItemForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Update the MeetingItemStatus object with the values entered in the form
            meetingItemStatus.Status = txtStatus.Text.Trim();
            meetingItemStatus.ResponsiblePerson = txtResponsiblePerson.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
