namespace Center
{
    partial class DateForm
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
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.datetime = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.time1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpicker
            // 
            this.dtpicker.Location = new System.Drawing.Point(233, 62);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(299, 22);
            this.dtpicker.TabIndex = 0;
            // 
            // datetime
            // 
            this.datetime.AutoSize = true;
            this.datetime.Location = new System.Drawing.Point(258, 127);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(46, 17);
            this.datetime.TabIndex = 1;
            this.datetime.Text = "label1";
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.Location = new System.Drawing.Point(258, 171);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(46, 17);
            this.date1.TabIndex = 2;
            this.date1.Text = "label2";
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.Location = new System.Drawing.Point(258, 223);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(46, 17);
            this.date2.TabIndex = 3;
            this.date2.Text = "label3";
            // 
            // time1
            // 
            this.time1.AutoSize = true;
            this.time1.Location = new System.Drawing.Point(258, 268);
            this.time1.Name = "time1";
            this.time1.Size = new System.Drawing.Size(46, 17);
            this.time1.TabIndex = 4;
            this.time1.Text = "label4";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(456, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.time1);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.dtpicker);
            this.Name = "DateForm";
            this.Text = "DateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.Label datetime;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label time1;
        private System.Windows.Forms.Button button1;
    }
}