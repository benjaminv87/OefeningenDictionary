namespace Oefeningen
{
    partial class FormOef1
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
            this.lblGetal = new System.Windows.Forms.Label();
            this.cbMijnGetallen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblGetal
            // 
            this.lblGetal.AutoSize = true;
            this.lblGetal.Location = new System.Drawing.Point(12, 36);
            this.lblGetal.Name = "lblGetal";
            this.lblGetal.Size = new System.Drawing.Size(35, 13);
            this.lblGetal.TabIndex = 1;
            this.lblGetal.Text = "label1";
            // 
            // cbMijnGetallen
            // 
            this.cbMijnGetallen.FormattingEnabled = true;
            this.cbMijnGetallen.Location = new System.Drawing.Point(12, 12);
            this.cbMijnGetallen.Name = "cbMijnGetallen";
            this.cbMijnGetallen.Size = new System.Drawing.Size(121, 21);
            this.cbMijnGetallen.TabIndex = 2;
            this.cbMijnGetallen.SelectedIndexChanged += new System.EventHandler(this.cbMijnGetallen_SelectedIndexChanged);
            // 
            // FormOef1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbMijnGetallen);
            this.Controls.Add(this.lblGetal);
            this.Name = "FormOef1";
            this.Text = "FormOef1";
            this.Load += new System.EventHandler(this.FormOef1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGetal;
        private System.Windows.Forms.ComboBox cbMijnGetallen;
    }
}