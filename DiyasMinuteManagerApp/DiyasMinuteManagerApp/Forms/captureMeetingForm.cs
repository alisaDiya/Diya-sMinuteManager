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
    public partial class captureMeetingForm : MaterialForm
    {
        private List<MeetingItemStatus> previousMeetingItems = new List<MeetingItemStatus>();
        private List<MeetingItemStatus> newMeetingItems = new List<MeetingItemStatus>();
        private List<MeetingType> meetingTypes = new List<MeetingType>();
        public captureMeetingForm()
        {
            InitializeComponent();
            LoadMeetingTypes();
            cbMeetingType.SelectedIndexChanged += cbMeetingType_SelectedIndexChanged;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void captureMeetingForm_Load(object sender, EventArgs e)
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
            LoadPreviousMeetingItems();
        }

        private void LoadPreviousMeetingItems()
        {
            if (cbMeetingType.SelectedItem == null)
                return;

            int meetingTypeId = (int)cbMeetingType.SelectedValue;
            var previousMeeting = MeetingRepository.GetPreviousMeeting(meetingTypeId);

            if (previousMeeting != null)
            {
                previousMeetingItems = MeetingItemStatusRepository.GetMeetingItemsByMeetingId(previousMeeting.MeetingID);
                lvPreviousMeetingItems.Items.Clear();

                foreach (var item in previousMeetingItems)
                {
                    ListViewItem listViewItem = new ListViewItem(item.MeetingItem.Description);
                    listViewItem.SubItems.Add(item.Status);
                    lvPreviousMeetingItems.Items.Add(listViewItem);
                }

                lvPreviousMeetingItems.CheckBoxes = true;
            }
            else
            {
                lvPreviousMeetingItems.Items.Clear();
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (cbMeetingType.SelectedItem == null)
            {
                MessageBox.Show("Please select a meeting type.");
                return;
            }

            var meeting = new Meeting
            {
                MeetingTypeID = (int)cbMeetingType.SelectedValue,
                MeetingDateTime = dtpMeetingDateTime.Value
            };

            // Save meeting and get MeetingID
            int meetingId = MeetingRepository.AddMeeting(meeting);

            // Add selected previous meeting items
            foreach (ListViewItem selectedItem in lvPreviousMeetingItems.Items)
            {
                if (selectedItem.Checked)
                {
                    var itemStatus = previousMeetingItems.First(i => i.MeetingItem.Description == selectedItem.Text);
                    itemStatus.MeetingID = meetingId;
                    MeetingItemStatusRepository.AddMeetingItemStatus(itemStatus);
                }
            }

            // Add new meeting items
            foreach (var newItemStatus in newMeetingItems)
            {
                // Save new MeetingItem and get MeetingItemID
                int meetingItemId = MeetingItemRepository.AddMeetingItem(newItemStatus.MeetingItem);
                newItemStatus.MeetingItemID = meetingItemId;
                newItemStatus.MeetingID = meetingId;
                MeetingItemStatusRepository.AddMeetingItemStatus(newItemStatus);
            }

            MessageBox.Show("Meeting saved successfully!");
            this.Close();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            string description = txtNewItemDescription.Text.Trim();
            string responsiblePerson = txtResponsiblePerson.Text.Trim();
            string status = txtStatus.Text.Trim();

            if (string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please enter a description for the new meeting item.");
                return;
            }

            var newItem = new MeetingItem
            {
                Description = description
            };

            var newItemStatus = new MeetingItemStatus
            {
                MeetingItem = newItem,
                Status = status,
                ResponsiblePerson = responsiblePerson
            };

            newMeetingItems.Add(newItemStatus);
            lbNewMeetingItems.DataSource = null;
            lbNewMeetingItems.DataSource = newMeetingItems.Select(i => i.MeetingItem.Description).ToList();

            // Clear inputs
            txtNewItemDescription.Text = "";
            txtResponsiblePerson.Text = "";
            txtStatus.Text = "";
        }
    }
}
