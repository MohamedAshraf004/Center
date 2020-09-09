namespace Center
{
    partial class DialogForm
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
            this.btnDecide = new System.Windows.Forms.Button();
            this.lblDialog = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do u want to purchese";
            // 
            // btnDecide
            // 
            this.btnDecide.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecide.Location = new System.Drawing.Point(304, 92);
            this.btnDecide.Name = "btnDecide";
            this.btnDecide.Size = new System.Drawing.Size(90, 42);
            this.btnDecide.TabIndex = 1;
            this.btnDecide.Text = "Decide";
            this.btnDecide.UseVisualStyleBackColor = true;
            this.btnDecide.Click += new System.EventHandler(this.btnDecide_Click);
            // 
            // lblDialog
            // 
            this.lblDialog.AutoSize = true;
            this.lblDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialog.Location = new System.Drawing.Point(244, 165);
            this.lblDialog.Name = "lblDialog";
            this.lblDialog.Size = new System.Drawing.Size(32, 25);
            this.lblDialog.TabIndex = 2;
            this.lblDialog.Text = "....";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(205, 209);
            this.monthCalendar1.MaxSelectionCount = 40;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(221, 469);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(267, 22);
            this.numericUpDown1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(557, 468);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(863, 466);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // DialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 588);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblDialog);
            this.Controls.Add(this.btnDecide);
            this.Controls.Add(this.label1);
            this.Name = "DialogForm";
            this.Text = "DialogForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDecide;
        private System.Windows.Forms.Label lblDialog;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}