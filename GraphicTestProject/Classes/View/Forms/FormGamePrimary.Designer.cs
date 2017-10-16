namespace GraphicTestProject.Classes.View.Forms
{
    partial class FormGamePrimary
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
            this.lblFPS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFPS
            // 
            this.lblFPS.AutoSize = true;
            this.lblFPS.Location = new System.Drawing.Point(941, 532);
            this.lblFPS.Name = "lblFPS";
            this.lblFPS.Size = new System.Drawing.Size(37, 13);
            this.lblFPS.TabIndex = 0;
            this.lblFPS.Text = "lblFPS";
            this.lblFPS.Visible = false;
            this.lblFPS.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormGamePrimary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 554);
            this.Controls.Add(this.lblFPS);
            this.Name = "FormGamePrimary";
            this.Text = "FormGamePrimary";
            this.Load += new System.EventHandler(this.FormGamePrimary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFPS;
    }
}