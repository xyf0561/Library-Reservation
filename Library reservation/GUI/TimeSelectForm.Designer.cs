namespace Library_reservation.GUI
{
    partial class TimeSelectForm
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
            this.components = new System.ComponentModel.Container();
            this.CurrentTimer = new System.Windows.Forms.Timer(this.components);
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectDate = new System.Windows.Forms.DateTimePicker();
            this.StartTimeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ReduceButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.ReservationList = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CurrentTimer
            // 
            this.CurrentTimer.Tick += new System.EventHandler(this.CurrentTimer_Tick);
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.Location = new System.Drawing.Point(139, 85);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(80, 18);
            this.CurrentTimeLabel.TabIndex = 0;
            this.CurrentTimeLabel.Text = "时间显示";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "当前时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "选择日期：";
            // 
            // SelectDate
            // 
            this.SelectDate.Location = new System.Drawing.Point(116, 158);
            this.SelectDate.Name = "SelectDate";
            this.SelectDate.Size = new System.Drawing.Size(209, 28);
            this.SelectDate.TabIndex = 13;
            this.SelectDate.ValueChanged += new System.EventHandler(this.SelectDate_ValueChanged);
            // 
            // StartTimeComboBox
            // 
            this.StartTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartTimeComboBox.FormattingEnabled = true;
            this.StartTimeComboBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.StartTimeComboBox.Items.AddRange(new object[] {
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30"});
            this.StartTimeComboBox.Location = new System.Drawing.Point(116, 208);
            this.StartTimeComboBox.Name = "StartTimeComboBox";
            this.StartTimeComboBox.Size = new System.Drawing.Size(116, 26);
            this.StartTimeComboBox.TabIndex = 14;
            this.StartTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.StartTimeComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "开始时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "结束时间：";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(284, 211);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(41, 40);
            this.AddButton.TabIndex = 17;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ReduceButton
            // 
            this.ReduceButton.Location = new System.Drawing.Point(350, 211);
            this.ReduceButton.Name = "ReduceButton";
            this.ReduceButton.Size = new System.Drawing.Size(41, 40);
            this.ReduceButton.TabIndex = 18;
            this.ReduceButton.Text = "-";
            this.ReduceButton.UseVisualStyleBackColor = true;
            this.ReduceButton.Click += new System.EventHandler(this.ReduceButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(126, 319);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(124, 33);
            this.ConfirmButton.TabIndex = 19;
            this.ConfirmButton.Text = "确定";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Location = new System.Drawing.Point(128, 253);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(80, 18);
            this.EndTimeLabel.TabIndex = 20;
            this.EndTimeLabel.Text = "结束时间";
            // 
            // ReservationList
            // 
            this.ReservationList.Location = new System.Drawing.Point(489, 73);
            this.ReservationList.Name = "ReservationList";
            this.ReservationList.Size = new System.Drawing.Size(607, 346);
            this.ReservationList.TabIndex = 21;
            this.ReservationList.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(314, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "已经存在以下预约，请合理安排时间：";
            // 
            // TimeSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 455);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReservationList);
            this.Controls.Add(this.EndTimeLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ReduceButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StartTimeComboBox);
            this.Controls.Add(this.SelectDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentTimeLabel);
            this.Controls.Add(this.label3);
            this.Name = "TimeSelectForm";
            this.Text = "TimeSelectForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TimeSelectForm_FormClosed);
            this.Load += new System.EventHandler(this.TimeSelectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer CurrentTimer;
        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker SelectDate;
        private System.Windows.Forms.ComboBox StartTimeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ReduceButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.ListView ReservationList;
        private System.Windows.Forms.Label label5;
    }
}