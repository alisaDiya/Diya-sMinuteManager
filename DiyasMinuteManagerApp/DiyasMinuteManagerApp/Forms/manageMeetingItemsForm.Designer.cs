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
            comboBox1 = new ComboBox();
            lvMeetingItems = new ListView();
            lbMeetings = new ListBox();
            btnUpdateItem = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(266, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // lvMeetingItems
            // 
            lvMeetingItems.Location = new Point(452, 190);
            lvMeetingItems.Name = "lvMeetingItems";
            lvMeetingItems.Size = new Size(269, 156);
            lvMeetingItems.TabIndex = 1;
            lvMeetingItems.UseCompatibleStateImageBehavior = false;
            // 
            // lbMeetings
            // 
            lbMeetings.FormattingEnabled = true;
            lbMeetings.ItemHeight = 20;
            lbMeetings.Location = new Point(112, 190);
            lbMeetings.Name = "lbMeetings";
            lbMeetings.Size = new Size(225, 124);
            lbMeetings.TabIndex = 2;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateItem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateItem.Depth = 0;
            btnUpdateItem.HighEmphasis = true;
            btnUpdateItem.Icon = null;
            btnUpdateItem.Location = new Point(353, 374);
            btnUpdateItem.Margin = new Padding(4, 6, 4, 6);
            btnUpdateItem.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.NoAccentTextColor = Color.Empty;
            btnUpdateItem.Size = new Size(140, 36);
            btnUpdateItem.TabIndex = 3;
            btnUpdateItem.Text = "btnUpdateItem";
            btnUpdateItem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateItem.UseAccentColor = false;
            btnUpdateItem.UseVisualStyleBackColor = true;
            // 
            // manageMeetingItemsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateItem);
            Controls.Add(lbMeetings);
            Controls.Add(lvMeetingItems);
            Controls.Add(comboBox1);
            Name = "manageMeetingItemsForm";
            Text = "manageMeetingItemsForm";
            Load += manageMeetingItemsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ListView lvMeetingItems;
        private ListBox lbMeetings;
        private MaterialSkin.Controls.MaterialButton btnUpdateItem;
    }
}