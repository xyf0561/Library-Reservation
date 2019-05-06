namespace Library_reservation.GUI
{
    partial class ReservationForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UidLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.SidLabel = new System.Windows.Forms.Label();
            this.EndLabel = new System.Windows.Forms.Label();
            this.SignOffButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "座位ID：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "结束时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "开始时间：";
            // 
            // UidLabel
            // 
            this.UidLabel.AutoSize = true;
            this.UidLabel.Location = new System.Drawing.Point(263, 112);
            this.UidLabel.Name = "UidLabel";
            this.UidLabel.Size = new System.Drawing.Size(62, 18);
            this.UidLabel.TabIndex = 4;
            this.UidLabel.Text = "label5";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(265, 227);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(62, 18);
            this.StartLabel.TabIndex = 5;
            this.StartLabel.Text = "label6";
            // 
            // SidLabel
            // 
            this.SidLabel.AutoSize = true;
            this.SidLabel.Location = new System.Drawing.Point(263, 173);
            this.SidLabel.Name = "SidLabel";
            this.SidLabel.Size = new System.Drawing.Size(62, 18);
            this.SidLabel.TabIndex = 6;
            this.SidLabel.Text = "label7";
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(265, 277);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(62, 18);
            this.EndLabel.TabIndex = 7;
            this.EndLabel.Text = "label8";
            // 
            // SignOffButton
            // 
            this.SignOffButton.Location = new System.Drawing.Point(173, 453);
            this.SignOffButton.Name = "SignOffButton";
            this.SignOffButton.Size = new System.Drawing.Size(140, 37);
            this.SignOffButton.TabIndex = 8;
            this.SignOffButton.Text = "删除当前预约";
            this.SignOffButton.UseVisualStyleBackColor = true;
            this.SignOffButton.Click += new System.EventHandler(this.SignOffButton_Click);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 553);
            this.Controls.Add(this.SignOffButton);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.SidLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.UidLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UidLabel;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label SidLabel;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.Button SignOffButton;
    }
}