namespace Center
{
    partial class RelationShipForm
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
            this.radioMarried = new System.Windows.Forms.RadioButton();
            this.radioSingle = new System.Windows.Forms.RadioButton();
            this.radioInRelation = new System.Windows.Forms.RadioButton();
            this.btnSubmitRelation = new System.Windows.Forms.Button();
            this.btnBH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "RelationShip";
            // 
            // radioMarried
            // 
            this.radioMarried.AutoSize = true;
            this.radioMarried.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMarried.Location = new System.Drawing.Point(285, 136);
            this.radioMarried.Name = "radioMarried";
            this.radioMarried.Size = new System.Drawing.Size(106, 29);
            this.radioMarried.TabIndex = 1;
            this.radioMarried.TabStop = true;
            this.radioMarried.Text = "Married";
            this.radioMarried.UseVisualStyleBackColor = true;
            // 
            // radioSingle
            // 
            this.radioSingle.AutoSize = true;
            this.radioSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSingle.Location = new System.Drawing.Point(285, 171);
            this.radioSingle.Name = "radioSingle";
            this.radioSingle.Size = new System.Drawing.Size(94, 29);
            this.radioSingle.TabIndex = 2;
            this.radioSingle.TabStop = true;
            this.radioSingle.Text = "Single";
            this.radioSingle.UseVisualStyleBackColor = true;
            // 
            // radioInRelation
            // 
            this.radioInRelation.AutoSize = true;
            this.radioInRelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioInRelation.Location = new System.Drawing.Point(285, 207);
            this.radioInRelation.Name = "radioInRelation";
            this.radioInRelation.Size = new System.Drawing.Size(129, 29);
            this.radioInRelation.TabIndex = 3;
            this.radioInRelation.TabStop = true;
            this.radioInRelation.Text = "InRelation";
            this.radioInRelation.UseVisualStyleBackColor = true;
            // 
            // btnSubmitRelation
            // 
            this.btnSubmitRelation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitRelation.Location = new System.Drawing.Point(444, 301);
            this.btnSubmitRelation.Name = "btnSubmitRelation";
            this.btnSubmitRelation.Size = new System.Drawing.Size(140, 60);
            this.btnSubmitRelation.TabIndex = 4;
            this.btnSubmitRelation.Text = "Submit";
            this.btnSubmitRelation.UseVisualStyleBackColor = true;
            this.btnSubmitRelation.Click += new System.EventHandler(this.btnSubmitRelation_Click);
            // 
            // btnBH
            // 
            this.btnBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBH.Location = new System.Drawing.Point(265, 301);
            this.btnBH.Name = "btnBH";
            this.btnBH.Size = new System.Drawing.Size(127, 59);
            this.btnBH.TabIndex = 5;
            this.btnBH.Text = "Back";
            this.btnBH.UseVisualStyleBackColor = true;
            this.btnBH.Click += new System.EventHandler(this.btnBH_Click);
            // 
            // RelationShipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBH);
            this.Controls.Add(this.btnSubmitRelation);
            this.Controls.Add(this.radioInRelation);
            this.Controls.Add(this.radioSingle);
            this.Controls.Add(this.radioMarried);
            this.Controls.Add(this.label1);
            this.Name = "RelationShipForm";
            this.Text = "RelationShipForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioMarried;
        private System.Windows.Forms.RadioButton radioSingle;
        private System.Windows.Forms.RadioButton radioInRelation;
        private System.Windows.Forms.Button btnSubmitRelation;
        private System.Windows.Forms.Button btnBH;
    }
}