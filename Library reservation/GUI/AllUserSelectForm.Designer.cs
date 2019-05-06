namespace Library_reservation.GUI
{
    partial class AllUserSelectForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.UserListView = new System.Windows.Forms.ListView();
            this.OKbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "在此处输入学号进行搜索：";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(333, 63);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(263, 28);
            this.IDtextBox.TabIndex = 1;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(662, 58);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(148, 34);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "开始查找";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // UserListView
            // 
            this.UserListView.Location = new System.Drawing.Point(120, 131);
            this.UserListView.Name = "UserListView";
            this.UserListView.Size = new System.Drawing.Size(720, 426);
            this.UserListView.TabIndex = 3;
            this.UserListView.UseCompatibleStateImageBehavior = false;
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(891, 477);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(113, 57);
            this.OKbutton.TabIndex = 4;
            this.OKbutton.Text = "确认";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // AllUserSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 639);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.UserListView);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label1);
            this.Name = "AllUserSelectForm";
            this.Text = "AllUserSelectForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AllUserSelectForm_FormClosing);
            this.Load += new System.EventHandler(this.AllUserSelectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ListView UserListView;
        private System.Windows.Forms.Button OKbutton;
    }
}