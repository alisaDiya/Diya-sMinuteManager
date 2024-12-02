using DiyasMinuteManagerApp.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyasMinuteManagerApp.Forms
{
    public partial class EditMeetingItemForm : MaterialForm
    {
        private MeetingItemStatus meetingItemStatus;
        public EditMeetingItemForm(MeetingItemStatus itemStatus)
        {
            InitializeComponent();
            meetingItemStatus = itemStatus;

            // Populate fields
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
            meetingItemStatus.Status = txtStatus.Text.Trim();
            meetingItemStatus.ResponsiblePerson = txtResponsiblePerson.Text.Trim();

            // Close the form and indicate success
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
