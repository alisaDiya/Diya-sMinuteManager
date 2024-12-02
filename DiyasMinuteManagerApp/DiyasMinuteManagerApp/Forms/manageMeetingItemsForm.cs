using DiyasMinuteManagerApp.Data;
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
    public partial class manageMeetingItemsForm : MaterialForm
    {
        private List<MeetingType> meetingTypes = new List<MeetingType>();
        private List<Meeting> meetings = new List<Meeting>();
        private List<MeetingItemStatus> meetingItems = new List<MeetingItemStatus>();
        private Meeting selectedMeeting;

        public manageMeetingItemsForm()
        {
            InitializeComponent();
            LoadMeetingTypes();
            cbMeetingType.SelectedIndexChanged += cbMeetingType_SelectedIndexChanged;
            lbMeetings.SelectedIndexChanged += lbMeetings_SelectedIndexChanged;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void manageMeetingItemsForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadMeetingTypes()
        {
            meetingTypes = MeetingTypeRepository.GetMeetingTypes();
            cbMeetingType.DataSource = meetingTypes;
            cbMeetingType.DisplayMember = "TypeName";
            cbMeetingType.ValueMember = "MeetingTypeID";
        }

        private void cbMeetingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMeetingType.SelectedItem == null)
                return;

            int meetingTypeId = (int)cbMeetingType.SelectedValue;
            meetings = MeetingRepository.GetMeetingsByType(meetingTypeId);
            lbMeetings.DataSource = meetings.Select(m => $"Meeting ID: {m.MeetingID}, Date: {m.MeetingDateTime}").ToList();
        }

        private void lbMeetings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMeetings.SelectedItem == null)
                return;

            int index = lbMeetings.SelectedIndex;
            selectedMeeting = meetings[index];

            LoadMeetingItems();
        }

        private void LoadMeetingItems()
        {
            meetingItems = MeetingItemStatusRepository.GetMeetingItemsByMeetingId(selectedMeeting.MeetingID);
            lvMeetingItems.Items.Clear();

            foreach (var itemStatus in meetingItems)
            {
                var listItem = new ListViewItem(itemStatus.MeetingItem.Description);
                listItem.SubItems.Add(itemStatus.Status);
                listItem.SubItems.Add(itemStatus.ResponsiblePerson);
                listItem.Tag = itemStatus;
                lvMeetingItems.Items.Add(listItem);
            }
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (lvMeetingItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a meeting item to update.");
                return;
            }

            var selectedItem = lvMeetingItems.SelectedItems[0];
            var itemStatus = (MeetingItemStatus)selectedItem.Tag;

            // Show a dialog or form to edit the status and responsible person
            var editForm = new EditMeetingItemForm(itemStatus);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Update in database
                MeetingItemStatusRepository.UpdateMeetingItemStatus(itemStatus);

                // Refresh the list view
                selectedItem.SubItems[1].Text = itemStatus.Status;
                selectedItem.SubItems[2].Text = itemStatus.ResponsiblePerson;

                MessageBox.Show("Meeting item updated successfully!");
            }
        }
    }
}
