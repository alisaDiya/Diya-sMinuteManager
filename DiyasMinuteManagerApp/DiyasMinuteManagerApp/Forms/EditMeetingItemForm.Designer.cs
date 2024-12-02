namespace DiyasMinuteManagerApp.Forms
{
    partial class EditMeetingItemForm
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
            txtStatus = new TextBox();
            txtResponsiblePerson = new TextBox();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(421, 135);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(324, 27);
            txtStatus.TabIndex = 0;
            // 
            // txtResponsiblePerson
            // 
            txtResponsiblePerson.Location = new Point(421, 194);
            txtResponsiblePerson.Name = "txtResponsiblePerson";
            txtResponsiblePerson.Size = new Size(324, 27);
            txtResponsiblePerson.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(310, 276);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(77, 36);
            btnSave.TabIndex = 2;
            btnSave.Text = "Update";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 135);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 3;
            label1.Text = "Status Change";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 194);
            label2.Name = "label2";
            label2.Size = new Size(200, 20);
            label2.TabIndex = 4;
            label2.Text = "Person Responsible - Change";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 86);
            label3.Name = "label3";
            label3.Size = new Size(168, 20);
            label3.TabIndex = 5;
            label3.Text = "Meeting Item - Changes";
            label3.Click += label3_Click;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(619, 394);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(168, 36);
            materialButton1.TabIndex = 6;
            materialButton1.Text = "Back to main menu";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // EditMeetingItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtResponsiblePerson);
            Controls.Add(txtStatus);
            Name = "EditMeetingItemForm";
            Text = "EditMeetingItemForm";
            Load += EditMeetingItemForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStatus;
        private TextBox txtResponsiblePerson;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}