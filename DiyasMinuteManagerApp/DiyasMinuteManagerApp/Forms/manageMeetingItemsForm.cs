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
    // Form for managing meeting items, inheriting from MaterialForm
    public partial class manageMeetingItemsForm : MaterialForm
    {
        // Fields for storing meeting-related data

        private List<MeetingType> meetingTypes = new List<MeetingType>();
        private List<Meeting> meetings = new List<Meeting>();
        private List<MeetingItemStatus> meetingItems = new List<MeetingItemStatus>();
        private Meeting selectedMeeting;

        public manageMeetingItemsForm()
        {
            InitializeComponent();
            LoadMeetingTypes();
            // Attach event handlers for dropdown and listbox selection changes
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
        // Method to load meeting types into the ComboBox--> Binds the data 
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
            // Bind data to ListBox
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

            // Load meeting items for the selected meeting
            LoadMeetingItems();
        }

        // Method to load meeting items into the ListView
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
