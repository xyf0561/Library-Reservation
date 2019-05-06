namespace Library_reservation
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel = new System.Windows.Forms.Panel();
            this.SelectManager = new System.Windows.Forms.RadioButton();
            this.SelectUser = new System.Windows.Forms.RadioButton();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.label2);
            this.Panel.Controls.Add(this.label1);
            this.Panel.Controls.Add(this.SelectManager);
            this.Panel.Controls.Add(this.SelectUser);
            this.Panel.Controls.Add(this.LoginButton);
            this.Panel.Controls.Add(this.PasswordTextBox);
            this.Panel.Controls.Add(this.IDTextBox);
            this.Panel.Location = new System.Drawing.Point(168, 99);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(478, 238);
            this.Panel.TabIndex = 0;
            // 
            // SelectManager
            // 
            this.SelectManager.AutoSize = true;
            this.SelectManager.Location = new System.Drawing.Point(295, 136);
            this.SelectManager.Name = "SelectManager";
            this.SelectManager.Size = new System.Drawing.Size(87, 22);
            this.SelectManager.TabIndex = 6;
            this.SelectManager.Text = "管理员";
            this.SelectManager.UseVisualStyleBackColor = true;
            // 
            // SelectUser
            // 
            this.SelectUser.AutoSize = true;
            this.SelectUser.Checked = true;
            this.SelectUser.Location = new System.Drawing.Point(114, 136);
            this.SelectUser.Name = "SelectUser";
            this.SelectUser.Size = new System.Drawing.Size(69, 22);
            this.SelectUser.TabIndex = 5;
            this.SelectUser.TabStop = true;
            this.SelectUser.Text = "用户";
            this.SelectUser.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(161, 190);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(164, 34);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "登录";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(114, 90);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(268, 28);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            this.PasswordTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PasswordTextBox_MouseClick);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(114, 38);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(268, 28);
            this.IDTextBox.TabIndex = 0;
            this.IDTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.IDTextBox_MouseClick);
            this.IDTextBox.Leave += new System.EventHandler(this.IDTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "密码：";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Panel);
            this.Name = "LoginForm";
            this.Text = "欢迎使用";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.RadioButton SelectUser;
        private System.Windows.Forms.RadioButton SelectManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

