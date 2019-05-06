namespace Library_reservation.GUI
{
    partial class SeatManageForm
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
            this.MaintainButton = new System.Windows.Forms.Button();
            this.ReservationList = new System.Windows.Forms.ListView();
            this.SIDLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaintainLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "座位号：";
            // 
            // MaintainButton
            // 
            this.MaintainButton.Location = new System.Drawing.Point(490, 138);
            this.MaintainButton.Name = "MaintainButton";
            this.MaintainButton.Size = new System.Drawing.Size(143, 46);
            this.MaintainButton.TabIndex = 1;
            this.MaintainButton.Text = "进入/退出维护";
            this.MaintainButton.UseVisualStyleBackColor = true;
            this.MaintainButton.Click += new System.EventHandler(this.MaintainButton_Click);
            // 
            // ReservationList
            // 
            this.ReservationList.Location = new System.Drawing.Point(109, 198);
            this.ReservationList.Name = "ReservationList";
            this.ReservationList.Size = new System.Drawing.Size(633, 272);
            this.ReservationList.TabIndex = 2;
            this.ReservationList.UseCompatibleStateImageBehavior = false;
            // 
            // SIDLabel
            // 
            this.SIDLabel.AutoSize = true;
            this.SIDLabel.Location = new System.Drawing.Point(244, 77);
            this.SIDLabel.Name = "SIDLabel";
            this.SIDLabel.Size = new System.Drawing.Size(80, 18);
            this.SIDLabel.TabIndex = 3;
            this.SIDLabel.Text = "SIDLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "维护状态：";
            // 
            // MaintainLabel
            // 
            this.MaintainLabel.AutoSize = true;
            this.MaintainLabel.Location = new System.Drawing.Point(244, 124);
            this.MaintainLabel.Name = "MaintainLabel";
            this.MaintainLabel.Size = new System.Drawing.Size(125, 18);
            this.MaintainLabel.TabIndex = 5;
            this.MaintainLabel.Text = "MaintainLabel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "本座位已有的预约：";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(490, 77);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(142, 47);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "清空所有预约";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "管理选中预约";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SeatManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaintainLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SIDLabel);
            this.Controls.Add(this.ReservationList);
            this.Controls.Add(this.MaintainButton);
            this.Controls.Add(this.label1);
            this.Name = "SeatManageForm";
            this.Text = "SeatManageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MaintainButton;
        private System.Windows.Forms.ListView ReservationList;
        private System.Windows.Forms.Label SIDLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MaintainLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button button1;
    }
}