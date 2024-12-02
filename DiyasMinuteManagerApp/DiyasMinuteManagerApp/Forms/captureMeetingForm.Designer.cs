namespace DiyasMinuteManagerApp.Forms
{
    partial class captureMeetingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbMeetingType = new ComboBox();
            dtpMeetingDateTime = new DateTimePicker();
            lvPreviousMeetingItems = new ListView();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            txtNewItemDescription = new TextBox();
            txtStatus = new TextBox();
            txtResponsiblePerson = new TextBox();
            lbNewMeetingItems = new ListBox();
            btnAddNewItem = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // cbMeetingType
            // 
            cbMeetingType.FormattingEnabled = true;
            cbMeetingType.Location = new Point(73, 87);
            cbMeetingType.Name = "cbMeetingType";
            cbMeetingType.Size = new Size(151, 28);
            cbMeetingType.TabIndex = 0;
            // 
            // dtpMeetingDateTime
            // 
            dtpMeetingDateTime.Location = new Point(78, 157);
            dtpMeetingDateTime.Name = "dtpMeetingDateTime";
            dtpMeetingDateTime.Size = new Size(250, 27);
            dtpMeetingDateTime.TabIndex = 1;
            // 
            // lvPreviousMeetingItems
            // 
            lvPreviousMeetingItems.Location = new Point(82, 231);
            lvPreviousMeetingItems.Name = "lvPreviousMeetingItems";
            lvPreviousMeetingItems.Size = new Size(151, 121);
            lvPreviousMeetingItems.TabIndex = 2;
            lvPreviousMeetingItems.UseCompatibleStateImageBehavior = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(82, 383);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(150, 36);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "btnSaveMeeting";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // txtNewItemDescription
            // 
            txtNewItemDescription.Location = new Point(501, 118);
            txtNewItemDescription.Name = "txtNewItemDescription";
            txtNewItemDescription.Size = new Size(125, 27);
            txtNewItemDescription.TabIndex = 4;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(515, 190);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(125, 27);
            txtStatus.TabIndex = 5;
            // 
            // txtResponsiblePerson
            // 
            txtResponsiblePerson.Location = new Point(549, 248);
            txtResponsiblePerson.Name = "txtResponsiblePerson";
            txtResponsiblePerson.Size = new Size(125, 27);
            txtResponsiblePerson.TabIndex = 6;
            // 
            // lbNewMeetingItems
            // 
            lbNewMeetingItems.FormattingEnabled = true;
            lbNewMeetingItems.ItemHeight = 20;
            lbNewMeetingItems.Location = new Point(398, 300);
            lbNewMeetingItems.Name = "lbNewMeetingItems";
            lbNewMeetingItems.Size = new Size(150, 104);
            lbNewMeetingItems.TabIndex = 7;
            // 
            // btnAddNewItem
            // 
            btnAddNewItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddNewItem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddNewItem.Depth = 0;
            btnAddNewItem.HighEmphasis = true;
            btnAddNewItem.Icon = null;
            btnAddNewItem.Location = new Point(590, 368);
            btnAddNewItem.Margin = new Padding(4, 6, 4, 6);
            btnAddNewItem.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddNewItem.Name = "btnAddNewItem";
            btnAddNewItem.NoAccentTextColor = Color.Empty;
            btnAddNewItem.Size = new Size(158, 36);
            btnAddNewItem.TabIndex = 8;
            btnAddNewItem.Text = "materialButton2";
            btnAddNewItem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddNewItem.UseAccentColor = false;
            btnAddNewItem.UseVisualStyleBackColor = true;
            btnAddNewItem.Click += btnAddNewItem_Click;
            // 
            // captureMeetingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddNewItem);
            Controls.Add(lbNewMeetingItems);
            Controls.Add(txtResponsiblePerson);
            Controls.Add(txtStatus);
            Controls.Add(txtNewItemDescription);
            Controls.Add(materialButton1);
            Controls.Add(lvPreviousMeetingItems);
            Controls.Add(dtpMeetingDateTime);
            Controls.Add(cbMeetingType);
            Name = "captureMeetingForm";
            Text = "captureMeetingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMeetingType;
        private DateTimePicker dtpMeetingDateTime;
        private ListView lvPreviousMeetingItems;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private TextBox txtNewItemDescription;
        private TextBox txtStatus;
        private TextBox txtResponsiblePerson;
        private ListBox lbNewMeetingItems;
        private MaterialSkin.Controls.MaterialButton btnAddNewItem;
    }
}