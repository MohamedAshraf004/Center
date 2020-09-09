namespace Center
{
    partial class TeachersForm
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
            this.comboTeacher = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboSubject = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboTeacher
            // 
            this.comboTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTeacher.FormattingEnabled = true;
            this.comboTeacher.Location = new System.Drawing.Point(163, 44);
            this.comboTeacher.Name = "comboTeacher";
            this.comboTeacher.Size = new System.Drawing.Size(203, 30);
            this.comboTeacher.TabIndex = 0;
            this.comboTeacher.SelectedIndexChanged += new System.EventHandler(this.comboTeacher_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(160, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(162, 157);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 20);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // comboSubject
            // 
            this.comboSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSubject.FormattingEnabled = true;
            this.comboSubject.Location = new System.Drawing.Point(472, 44);
            this.comboSubject.Name = "comboSubject";
            this.comboSubject.Size = new System.Drawing.Size(203, 30);
            this.comboSubject.TabIndex = 5;
            this.comboSubject.SelectedIndexChanged += new System.EventHandler(this.comboSubject_SelectedIndexChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(468, 118);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(59, 20);
            this.lblSubject.TabIndex = 6;
            this.lblSubject.Text = "label1";
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.comboSubject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.comboTeacher);
            this.Name = "TeachersForm";
            this.Text = "TeachersForm";
            this.Load += new System.EventHandler(this.TeachersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTeacher;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboSubject;
        private System.Windows.Forms.Label lblSubject;
    }
}