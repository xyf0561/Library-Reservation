namespace Library_reservation
{
    partial class ManagerGUI
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
            this.ExitManage = new System.Windows.Forms.Button();
            this.UserManage = new System.Windows.Forms.Button();
            this.SeatManage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("幼圆", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WelcomeLabel.Location = new System.Drawing.Point(301, 125);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(313, 30);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "欢迎管理员使用本系统";
            // 
            // ExitManage
            // 
            this.ExitManage.Location = new System.Drawing.Point(639, 364);
            this.ExitManage.Name = "ExitManage";
            this.ExitManage.Size = new System.Drawing.Size(133, 48);
            this.ExitManage.TabIndex = 6;
            this.ExitManage.Text = "退出";
            this.ExitManage.UseVisualStyleBackColor = true;
            this.ExitManage.Click += new System.EventHandler(this.ExitManage_Click);
            // 
            // UserManage
            // 
            this.UserManage.Location = new System.Drawing.Point(394, 364);
            this.UserManage.Name = "UserManage";
            this.UserManage.Size = new System.Drawing.Size(133, 48);
            this.UserManage.TabIndex = 5;
            this.UserManage.Text = "按人员管理";
            this.UserManage.UseVisualStyleBackColor = true;
            this.UserManage.Click += new System.EventHandler(this.UserManage_Click);
            // 
            // SeatManage
            // 
            this.SeatManage.Location = new System.Drawing.Point(150, 364);
            this.SeatManage.Name = "SeatManage";
            this.SeatManage.Size = new System.Drawing.Size(133, 48);
            this.SeatManage.TabIndex = 4;
            this.SeatManage.Text = "按座位管理";
            this.SeatManage.UseVisualStyleBackColor = true;
            this.SeatManage.Click += new System.EventHandler(this.SeatManage_Click);
            // 
            // ManagerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 581);
            this.Controls.Add(this.ExitManage);
            this.Controls.Add(this.UserManage);
            this.Controls.Add(this.SeatManage);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "ManagerGUI";
            this.Text = "ManagerGUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerGUI_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button ExitManage;
        private System.Windows.Forms.Button UserManage;
        private System.Windows.Forms.Button SeatManage;
    }
}