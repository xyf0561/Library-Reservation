namespace Library_reservation.GUI
{
    partial class UserInformationForm
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
            this.IDlabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CreditLabel = new System.Windows.Forms.Label();
            this.ResetPasswordButton = new System.Windows.Forms.Button();
            this.ReservationListView = new System.Windows.Forms.ListView();
            this.ReservationManagerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credit:";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(200, 45);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(62, 18);
            this.IDlabel.TabIndex = 3;
            this.IDlabel.Text = "label4";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(200, 98);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(62, 18);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "label4";
            // 
            // CreditLabel
            // 
            this.CreditLabel.AutoSize = true;
            this.CreditLabel.Location = new System.Drawing.Point(200, 153);
            this.CreditLabel.Name = "CreditLabel";
            this.CreditLabel.Size = new System.Drawing.Size(62, 18);
            this.CreditLabel.TabIndex = 5;
            this.CreditLabel.Text = "label4";
            // 
            // ResetPasswordButton
            // 
            this.ResetPasswordButton.Location = new System.Drawing.Point(107, 257);
            this.ResetPasswordButton.Name = "ResetPasswordButton";
            this.ResetPasswordButton.Size = new System.Drawing.Size(155, 45);
            this.ResetPasswordButton.TabIndex = 6;
            this.ResetPasswordButton.Text = "重置密码";
            this.ResetPasswordButton.UseVisualStyleBackColor = true;
            this.ResetPasswordButton.Click += new System.EventHandler(this.ResetPasswordButton_Click);
            // 
            // ReservationListView
            // 
            this.ReservationListView.Location = new System.Drawing.Point(361, 43);
            this.ReservationListView.Name = "ReservationListView";
            this.ReservationListView.Size = new System.Drawing.Size(722, 440);
            this.ReservationListView.TabIndex = 7;
            this.ReservationListView.UseCompatibleStateImageBehavior = false;
            // 
            // ReservationManagerButton
            // 
            this.ReservationManagerButton.Location = new System.Drawing.Point(107, 350);
            this.ReservationManagerButton.Name = "ReservationManagerButton";
            this.ReservationManagerButton.Size = new System.Drawing.Size(155, 46);
            this.ReservationManagerButton.TabIndex = 8;
            this.ReservationManagerButton.Text = "管理选中的预约";
            this.ReservationManagerButton.UseVisualStyleBackColor = true;
            this.ReservationManagerButton.Click += new System.EventHandler(this.ReservationManagerButton_Click);
            // 
            // UserInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 594);
            this.Controls.Add(this.ReservationManagerButton);
            this.Controls.Add(this.ReservationListView);
            this.Controls.Add(this.ResetPasswordButton);
            this.Controls.Add(this.CreditLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserInformationForm";
            this.Text = "UserInformationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CreditLabel;
        private System.Windows.Forms.Button ResetPasswordButton;
        private System.Windows.Forms.ListView ReservationListView;
        private System.Windows.Forms.Button ReservationManagerButton;
    }
}