namespace DiyasMinuteManagerApp.Forms
{
    partial class manageMeetingItemsForm
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
            lvMeetingItems = new ListView();
            lbMeetings = new ListBox();
            btnUpdateItem = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // cbMeetingType
            // 
            cbMeetingType.FormattingEnabled = true;
            cbMeetingType.Location = new Point(324, 110);
            cbMeetingType.Name = "cbMeetingType";
            cbMeetingType.Size = new Size(151, 28);
            cbMeetingType.TabIndex = 0;
            // 
            // lvMeetingItems
            // 
            lvMeetingItems.Location = new Point(447, 190);
            lvMeetingItems.Name = "lvMeetingItems";
            lvMeetingItems.Size = new Size(319, 142);
            lvMeetingItems.TabIndex = 1;
            lvMeetingItems.UseCompatibleStateImageBehavior = false;
            // 
            // lbMeetings
            // 
            lbMeetings.FormattingEnabled = true;
            lbMeetings.ItemHeight = 20;
            lbMeetings.Location = new Point(23, 190);
            lbMeetings.Name = "lbMeetings";
            lbMeetings.Size = new Size(357, 144);
            lbMeetings.TabIndex = 2;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateItem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateItem.Depth = 0;
            btnUpdateItem.HighEmphasis = true;
            btnUpdateItem.Icon = null;
            btnUpdateItem.Location = new Point(324, 362);
            btnUpdateItem.Margin = new Padding(4, 6, 4, 6);
            btnUpdateItem.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.NoAccentTextColor = Color.Empty;
            btnUpdateItem.Size = new Size(77, 36);
            btnUpdateItem.TabIndex = 3;
            btnUpdateItem.Text = "Update";
            btnUpdateItem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateItem.UseAccentColor = false;
            btnUpdateItem.UseVisualStyleBackColor = true;
            btnUpdateItem.Click += btnUpdateItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 110);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 4;
            label1.Text = "Meeting Types";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 157);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 5;
            label2.Text = "Previous Meetings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(560, 157);
            label3.Name = "label3";
            label3.Size = new Size(152, 20);
            label3.TabIndex = 6;
            label3.Text = "Meeting Items to Edit";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(608, 81);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(168, 36);
            materialButton1.TabIndex = 7;
            materialButton1.Text = "Back to main menu";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // manageMeetingItemsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpdateItem);
            Controls.Add(lbMeetings);
            Controls.Add(lvMeetingItems);
            Controls.Add(cbMeetingType);
            Name = "manageMeetingItemsForm";
            Text = "Manage Meeting Items";
            Load += manageMeetingItemsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMeetingType;
        private ListView lvMeetingItems;
        private ListBox lbMeetings;
        private MaterialSkin.Controls.MaterialButton btnUpdateItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}