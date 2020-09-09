namespace Center
{
    partial class HomeForm
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
            this.lblHomeWel = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.btnRelation = new System.Windows.Forms.Button();
            this.btnShowDialog = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHomeWel
            // 
            this.lblHomeWel.AutoSize = true;
            this.lblHomeWel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeWel.Location = new System.Drawing.Point(285, 39);
            this.lblHomeWel.Name = "lblHomeWel";
            this.lblHomeWel.Size = new System.Drawing.Size(0, 29);
            this.lblHomeWel.TabIndex = 0;
            this.lblHomeWel.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(325, 286);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(125, 64);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btnDateTime
            // 
            this.btnDateTime.Location = new System.Drawing.Point(99, 148);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(121, 63);
            this.btnDateTime.TabIndex = 2;
            this.btnDateTime.Text = "DateTime";
            this.btnDateTime.UseVisualStyleBackColor = true;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // btnRelation
            // 
            this.btnRelation.Location = new System.Drawing.Point(261, 148);
            this.btnRelation.Name = "btnRelation";
            this.btnRelation.Size = new System.Drawing.Size(121, 63);
            this.btnRelation.TabIndex = 3;
            this.btnRelation.Text = "Set Relation";
            this.btnRelation.UseVisualStyleBackColor = true;
            this.btnRelation.Click += new System.EventHandler(this.btnRelation_Click);
            // 
            // btnShowDialog
            // 
            this.btnShowDialog.Location = new System.Drawing.Point(402, 148);
            this.btnShowDialog.Name = "btnShowDialog";
            this.btnShowDialog.Size = new System.Drawing.Size(121, 63);
            this.btnShowDialog.TabIndex = 4;
            this.btnShowDialog.Text = "Dialog";
            this.btnShowDialog.UseVisualStyleBackColor = true;
            this.btnShowDialog.Click += new System.EventHandler(this.btnShowDialog_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(542, 148);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(121, 63);
            this.btnCombo.TabIndex = 5;
            this.btnCombo.Text = "Combo";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCombo);
            this.Controls.Add(this.btnShowDialog);
            this.Controls.Add(this.btnRelation);
            this.Controls.Add(this.btnDateTime);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lblHomeWel);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHomeWel;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.Button btnRelation;
        private System.Windows.Forms.Button btnShowDialog;
        private System.Windows.Forms.Button btnCombo;
    }
}