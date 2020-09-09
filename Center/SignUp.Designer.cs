namespace Center
{
    partial class SignUp
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.groupBoxServices = new System.Windows.Forms.GroupBox();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblSmsNotifaction = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkSmsNotification = new System.Windows.Forms.CheckBox();
            this.chkReport = new System.Windows.Forms.CheckBox();
            this.chkTransaction = new System.Windows.Forms.CheckBox();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBoxServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(173, 229);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 24);
            this.lblPassword.TabIndex = 34;
            this.lblPassword.Text = "Password";
            // 
            // groupBoxServices
            // 
            this.groupBoxServices.Controls.Add(this.chkTransaction);
            this.groupBoxServices.Controls.Add(this.chkReport);
            this.groupBoxServices.Controls.Add(this.chkSmsNotification);
            this.groupBoxServices.Controls.Add(this.lblTransaction);
            this.groupBoxServices.Controls.Add(this.lblReport);
            this.groupBoxServices.Controls.Add(this.lblSmsNotifaction);
            this.groupBoxServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxServices.Location = new System.Drawing.Point(167, 304);
            this.groupBoxServices.Name = "groupBoxServices";
            this.groupBoxServices.Size = new System.Drawing.Size(862, 198);
            this.groupBoxServices.TabIndex = 33;
            this.groupBoxServices.TabStop = false;
            this.groupBoxServices.Text = "Services";
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTransaction.Location = new System.Drawing.Point(476, 156);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(52, 24);
            this.lblTransaction.TabIndex = 5;
            this.lblTransaction.Text = ". . . .";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.ForeColor = System.Drawing.Color.Blue;
            this.lblReport.Location = new System.Drawing.Point(476, 117);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(52, 24);
            this.lblReport.TabIndex = 4;
            this.lblReport.Text = ". . . .";
            // 
            // lblSmsNotifaction
            // 
            this.lblSmsNotifaction.AutoSize = true;
            this.lblSmsNotifaction.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSmsNotifaction.Location = new System.Drawing.Point(476, 74);
            this.lblSmsNotifaction.Name = "lblSmsNotifaction";
            this.lblSmsNotifaction.Size = new System.Drawing.Size(52, 24);
            this.lblSmsNotifaction.TabIndex = 3;
            this.lblSmsNotifaction.Text = ". . . .";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(173, 183);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(145, 24);
            this.lblEmailAddress.TabIndex = 32;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(173, 144);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(108, 24);
            this.lblLastName.TabIndex = 31;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(173, 96);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(111, 24);
            this.lblFirstName.TabIndex = 30;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(416, 98);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(613, 22);
            this.txtFirstName.TabIndex = 35;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(416, 144);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(613, 22);
            this.txtLastName.TabIndex = 36;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(416, 183);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(613, 22);
            this.txtEmailAddress.TabIndex = 37;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(416, 229);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(613, 22);
            this.txtPassword.TabIndex = 38;
            // 
            // chkSmsNotification
            // 
            this.chkSmsNotification.AutoSize = true;
            this.chkSmsNotification.Location = new System.Drawing.Point(249, 80);
            this.chkSmsNotification.Name = "chkSmsNotification";
            this.chkSmsNotification.Size = new System.Drawing.Size(181, 28);
            this.chkSmsNotification.TabIndex = 20;
            this.chkSmsNotification.Text = "Sms Notification";
            this.chkSmsNotification.UseVisualStyleBackColor = true;
            this.chkSmsNotification.CheckedChanged += new System.EventHandler(this.chkSmsNotification_CheckedChanged);
            // 
            // chkReport
            // 
            this.chkReport.AutoSize = true;
            this.chkReport.Location = new System.Drawing.Point(249, 120);
            this.chkReport.Name = "chkReport";
            this.chkReport.Size = new System.Drawing.Size(94, 28);
            this.chkReport.TabIndex = 21;
            this.chkReport.Text = "Report";
            this.chkReport.UseVisualStyleBackColor = true;
            this.chkReport.CheckedChanged += new System.EventHandler(this.chkReport_CheckedChanged);
            // 
            // chkTransaction
            // 
            this.chkTransaction.AutoSize = true;
            this.chkTransaction.Location = new System.Drawing.Point(249, 154);
            this.chkTransaction.Name = "chkTransaction";
            this.chkTransaction.Size = new System.Drawing.Size(141, 28);
            this.chkTransaction.TabIndex = 22;
            this.chkTransaction.Text = "Transaction";
            this.chkTransaction.UseVisualStyleBackColor = true;
            this.chkTransaction.CheckedChanged += new System.EventHandler(this.chkTransaction_CheckedChanged);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.Location = new System.Drawing.Point(416, 508);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(406, 56);
            this.SignUpBtn.TabIndex = 39;
            this.SignUpBtn.Text = "SignUp";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(861, 508);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 56);
            this.btnBack.TabIndex = 40;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 599);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.groupBoxServices);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.groupBoxServices.ResumeLayout(false);
            this.groupBoxServices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox groupBoxServices;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblSmsNotifaction;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.CheckBox chkTransaction;
        private System.Windows.Forms.CheckBox chkReport;
        private System.Windows.Forms.CheckBox chkSmsNotification;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Button btnBack;
    }
}