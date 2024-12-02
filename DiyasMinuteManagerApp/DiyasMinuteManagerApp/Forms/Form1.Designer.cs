namespace DiyasMinuteManagerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCaptureMeeting = new MaterialSkin.Controls.MaterialButton();
            btnManageMeetingItem = new MaterialSkin.Controls.MaterialButton();
            btnExit = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // btnCaptureMeeting
            // 
            btnCaptureMeeting.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCaptureMeeting.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCaptureMeeting.Depth = 0;
            btnCaptureMeeting.HighEmphasis = true;
            btnCaptureMeeting.Icon = null;
            btnCaptureMeeting.Location = new Point(329, 152);
            btnCaptureMeeting.Margin = new Padding(4, 6, 4, 6);
            btnCaptureMeeting.MouseState = MaterialSkin.MouseState.HOVER;
            btnCaptureMeeting.Name = "btnCaptureMeeting";
            btnCaptureMeeting.NoAccentTextColor = Color.Empty;
            btnCaptureMeeting.Size = new Size(189, 36);
            btnCaptureMeeting.TabIndex = 0;
            btnCaptureMeeting.Text = "Capture new meeting";
            btnCaptureMeeting.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCaptureMeeting.UseAccentColor = false;
            btnCaptureMeeting.UseVisualStyleBackColor = true;
            btnCaptureMeeting.Click += btnCaptureMeeting_Click;
            // 
            // btnManageMeetingItem
            // 
            btnManageMeetingItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnManageMeetingItem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnManageMeetingItem.Depth = 0;
            btnManageMeetingItem.HighEmphasis = true;
            btnManageMeetingItem.Icon = null;
            btnManageMeetingItem.Location = new Point(329, 200);
            btnManageMeetingItem.Margin = new Padding(4, 6, 4, 6);
            btnManageMeetingItem.MouseState = MaterialSkin.MouseState.HOVER;
            btnManageMeetingItem.Name = "btnManageMeetingItem";
            btnManageMeetingItem.NoAccentTextColor = Color.Empty;
            btnManageMeetingItem.Size = new Size(197, 36);
            btnManageMeetingItem.TabIndex = 1;
            btnManageMeetingItem.Text = "Manage Meeting Items";
            btnManageMeetingItem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnManageMeetingItem.UseAccentColor = false;
            btnManageMeetingItem.UseVisualStyleBackColor = true;
            btnManageMeetingItem.Click += btnManageMeetingItem_Click;
            // 
            // btnExit
            // 
            btnExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExit.Depth = 0;
            btnExit.HighEmphasis = true;
            btnExit.Icon = null;
            btnExit.Location = new Point(353, 248);
            btnExit.Margin = new Padding(4, 6, 4, 6);
            btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            btnExit.Name = "btnExit";
            btnExit.NoAccentTextColor = Color.Empty;
            btnExit.Size = new Size(153, 36);
            btnExit.TabIndex = 2;
            btnExit.Text = " Exit Application";
            btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExit.UseAccentColor = false;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnManageMeetingItem);
            Controls.Add(btnCaptureMeeting);
            Name = "Form1";
            Sizable = false;
            Text = "Minutes Management System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCaptureMeeting;
        private MaterialSkin.Controls.MaterialButton btnManageMeetingItem;
        private MaterialSkin.Controls.MaterialButton btnExit;
    }
}
