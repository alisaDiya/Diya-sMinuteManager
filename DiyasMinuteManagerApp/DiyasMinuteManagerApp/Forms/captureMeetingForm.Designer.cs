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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // cbMeetingType
            // 
            cbMeetingType.FormattingEnabled = true;
            cbMeetingType.Location = new Point(169, 137);
            cbMeetingType.Name = "cbMeetingType";
            cbMeetingType.Size = new Size(289, 28);
            cbMeetingType.TabIndex = 0;
            // 
            // dtpMeetingDateTime
            // 
            dtpMeetingDateTime.Location = new Point(169, 198);
            dtpMeetingDateTime.Name = "dtpMeetingDateTime";
            dtpMeetingDateTime.Size = new Size(289, 27);
            dtpMeetingDateTime.TabIndex = 1;
            // 
            // lvPreviousMeetingItems
            // 
            lvPreviousMeetingItems.Location = new Point(17, 325);
            lvPreviousMeetingItems.Name = "lvPreviousMeetingItems";
            lvPreviousMeetingItems.Size = new Size(441, 116);
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
            materialButton1.Location = new Point(142, 473);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(125, 36);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "Save Meeting";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // txtNewItemDescription
            // 
            txtNewItemDescription.Location = new Point(623, 160);
            txtNewItemDescription.Multiline = true;
            txtNewItemDescription.Name = "txtNewItemDescription";
            txtNewItemDescription.Size = new Size(269, 103);
            txtNewItemDescription.TabIndex = 4;
            txtNewItemDescription.TextChanged += txtNewItemDescription_TextChanged;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(702, 289);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(216, 27);
            txtStatus.TabIndex = 5;
            // 
            // txtResponsiblePerson
            // 
            txtResponsiblePerson.Location = new Point(702, 333);
            txtResponsiblePerson.Name = "txtResponsiblePerson";
            txtResponsiblePerson.Size = new Size(216, 27);
            txtResponsiblePerson.TabIndex = 6;
            // 
            // lbNewMeetingItems
            // 
            lbNewMeetingItems.FormattingEnabled = true;
            lbNewMeetingItems.ItemHeight = 20;
            lbNewMeetingItems.Location = new Point(561, 407);
            lbNewMeetingItems.Name = "lbNewMeetingItems";
            lbNewMeetingItems.Size = new Size(331, 144);
            lbNewMeetingItems.TabIndex = 7;
            // 
            // btnAddNewItem
            // 
            btnAddNewItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddNewItem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddNewItem.Depth = 0;
            btnAddNewItem.HighEmphasis = true;
            btnAddNewItem.Icon = null;
            btnAddNewItem.Location = new Point(660, 561);
            btnAddNewItem.Margin = new Padding(4, 6, 4, 6);
            btnAddNewItem.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddNewItem.Name = "btnAddNewItem";
            btnAddNewItem.NoAccentTextColor = Color.Empty;
            btnAddNewItem.Size = new Size(124, 36);
            btnAddNewItem.TabIndex = 8;
            btnAddNewItem.Text = "Add New Item";
            btnAddNewItem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddNewItem.UseAccentColor = false;
            btnAddNewItem.UseVisualStyleBackColor = true;
            btnAddNewItem.Click += btnAddNewItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 85);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 9;
            label1.Text = "Capture New Meeting";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 140);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 10;
            label2.Text = "Meeting Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 203);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 11;
            label3.Text = "Date and  Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 289);
            label4.Name = "label4";
            label4.Size = new Size(243, 20);
            label4.TabIndex = 12;
            label4.Text = "Select a meeting Item to Carry over";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(677, 127);
            label5.Name = "label5";
            label5.Size = new Size(178, 20);
            label5.TabIndex = 13;
            label5.Text = "Meeting Item Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(526, 296);
            label6.Name = "label6";
            label6.Size = new Size(142, 20);
            label6.TabIndex = 14;
            label6.Text = "Meeting Item Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(532, 340);
            label7.Name = "label7";
            label7.Size = new Size(136, 20);
            label7.TabIndex = 15;
            label7.Text = "Person Responsible";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(660, 374);
            label8.Name = "label8";
            label8.Size = new Size(153, 20);
            label8.TabIndex = 16;
            label8.Text = "Meeting Items Added";
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(734, 77);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(168, 36);
            materialButton2.TabIndex = 17;
            materialButton2.Text = "Back to main menu";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // captureMeetingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 606);
            Controls.Add(materialButton2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
            Load += captureMeetingForm_Load;
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}