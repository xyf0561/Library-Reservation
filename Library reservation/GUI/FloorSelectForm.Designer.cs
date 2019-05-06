namespace Library_reservation.GUI
{
    partial class FloorSelectForm
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
            this.FloorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.NearWindowsCheck = new System.Windows.Forms.CheckBox();
            this.NearSocketCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FloorComboBox
            // 
            this.FloorComboBox.FormattingEnabled = true;
            this.FloorComboBox.Location = new System.Drawing.Point(141, 17);
            this.FloorComboBox.Name = "FloorComboBox";
            this.FloorComboBox.Size = new System.Drawing.Size(152, 26);
            this.FloorComboBox.TabIndex = 0;
            this.FloorComboBox.SelectedIndexChanged += new System.EventHandler(this.FloorComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "可选楼层：";
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(21, 54);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1104, 644);
            this.MainPanel.TabIndex = 2;
            // 
            // NearWindowsCheck
            // 
            this.NearWindowsCheck.AutoSize = true;
            this.NearWindowsCheck.Location = new System.Drawing.Point(614, 21);
            this.NearWindowsCheck.Name = "NearWindowsCheck";
            this.NearWindowsCheck.Size = new System.Drawing.Size(106, 22);
            this.NearWindowsCheck.TabIndex = 3;
            this.NearWindowsCheck.Text = "仅限靠窗";
            this.NearWindowsCheck.UseVisualStyleBackColor = true;
            this.NearWindowsCheck.CheckedChanged += new System.EventHandler(this.NearWindowsCheck_CheckedChanged);
            this.NearWindowsCheck.CheckStateChanged += new System.EventHandler(this.NearWindowsCheck_CheckedChanged);
            // 
            // NearSocketCheck
            // 
            this.NearSocketCheck.AutoSize = true;
            this.NearSocketCheck.Location = new System.Drawing.Point(750, 19);
            this.NearSocketCheck.Name = "NearSocketCheck";
            this.NearSocketCheck.Size = new System.Drawing.Size(142, 22);
            this.NearSocketCheck.TabIndex = 4;
            this.NearSocketCheck.Text = "仅限靠近插座";
            this.NearSocketCheck.UseVisualStyleBackColor = true;
            this.NearSocketCheck.CheckedChanged += new System.EventHandler(this.NearSocketCheck_CheckedChanged);
            this.NearSocketCheck.CheckStateChanged += new System.EventHandler(this.NearSocketCheck_CheckedChanged);
            // 
            // FloorSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 719);
            this.Controls.Add(this.NearSocketCheck);
            this.Controls.Add(this.NearWindowsCheck);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FloorComboBox);
            this.Name = "FloorSelectForm";
            this.Text = "FloorSelectForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FloorSelectForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FloorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.CheckBox NearWindowsCheck;
        private System.Windows.Forms.CheckBox NearSocketCheck;
    }
}