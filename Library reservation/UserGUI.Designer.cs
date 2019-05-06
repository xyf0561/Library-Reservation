namespace Library_reservation
{
    partial class UserGUI
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.FloorBookBtn = new System.Windows.Forms.Button();
            this.TimeBookBtn = new System.Windows.Forms.Button();
            this.ExitBookBtn = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CancelPanel = new System.Windows.Forms.Panel();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WelcomeLabel.Location = new System.Drawing.Point(295, 95);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(283, 30);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "欢迎同学使用本系统";
            // 
            // FloorBookBtn
            // 
            this.FloorBookBtn.Location = new System.Drawing.Point(253, 306);
            this.FloorBookBtn.Name = "FloorBookBtn";
            this.FloorBookBtn.Size = new System.Drawing.Size(133, 48);
            this.FloorBookBtn.TabIndex = 1;
            this.FloorBookBtn.Text = "按楼层预定";
            this.FloorBookBtn.UseVisualStyleBackColor = true;
            this.FloorBookBtn.Click += new System.EventHandler(this.FloorBookBtn_Click);
            // 
            // TimeBookBtn
            // 
            this.TimeBookBtn.Location = new System.Drawing.Point(493, 306);
            this.TimeBookBtn.Name = "TimeBookBtn";
            this.TimeBookBtn.Size = new System.Drawing.Size(133, 48);
            this.TimeBookBtn.TabIndex = 2;
            this.TimeBookBtn.Text = "按时间预定";
            this.TimeBookBtn.UseVisualStyleBackColor = true;
            this.TimeBookBtn.Click += new System.EventHandler(this.TimeBookBtn_Click);
            // 
            // ExitBookBtn
            // 
            this.ExitBookBtn.Location = new System.Drawing.Point(493, 415);
            this.ExitBookBtn.Name = "ExitBookBtn";
            this.ExitBookBtn.Size = new System.Drawing.Size(133, 48);
            this.ExitBookBtn.TabIndex = 3;
            this.ExitBookBtn.Text = "退出";
            this.ExitBookBtn.UseVisualStyleBackColor = true;
            this.ExitBookBtn.Click += new System.EventHandler(this.ExitBookBtn_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(253, 415);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(133, 48);
            this.ChangePasswordButton.TabIndex = 4;
            this.ChangePasswordButton.Text = "修改密码";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(608, 56);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(133, 48);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CancelPanel
            // 
            this.CancelPanel.Controls.Add(this.EndTimeLabel);
            this.CancelPanel.Controls.Add(this.StartTimeLabel);
            this.CancelPanel.Controls.Add(this.label2);
            this.CancelPanel.Controls.Add(this.label1);
            this.CancelPanel.Controls.Add(this.CancelButton);
            this.CancelPanel.Location = new System.Drawing.Point(55, 152);
            this.CancelPanel.Name = "CancelPanel";
            this.CancelPanel.Size = new System.Drawing.Size(758, 133);
            this.CancelPanel.TabIndex = 6;
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(140, 86);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(71, 18);
            this.EndTimeLabel.TabIndex = 9;
            this.EndTimeLabel.Text = "EndTime";
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Location = new System.Drawing.Point(140, 29);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(89, 18);
            this.StartTimeLabel.TabIndex = 8;
            this.StartTimeLabel.Text = "StartTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "结束时间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "开始时间：";
            // 
            // UserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.CancelPanel);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.ExitBookBtn);
            this.Controls.Add(this.TimeBookBtn);
            this.Controls.Add(this.FloorBookBtn);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "UserGUI";
            this.Text = "UserGUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserGUI_FormClosed);
            this.CancelPanel.ResumeLayout(false);
            this.CancelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button FloorBookBtn;
        private System.Windows.Forms.Button TimeBookBtn;
        private System.Windows.Forms.Button ExitBookBtn;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel CancelPanel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}