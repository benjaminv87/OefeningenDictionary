namespace Oefeningen
{
    partial class FormOef2
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
            this.cbTeVertalen = new System.Windows.Forms.ComboBox();
            this.tbVertaald = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnWoordToevoegen = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Te vertalen woord";
            // 
            // cbTeVertalen
            // 
            this.cbTeVertalen.FormattingEnabled = true;
            this.cbTeVertalen.Location = new System.Drawing.Point(15, 25);
            this.cbTeVertalen.Name = "cbTeVertalen";
            this.cbTeVertalen.Size = new System.Drawing.Size(121, 21);
            this.cbTeVertalen.TabIndex = 3;
            this.cbTeVertalen.SelectedIndexChanged += new System.EventHandler(this.cbTeVertalen_SelectedIndexChanged);
            // 
            // tbVertaald
            // 
            this.tbVertaald.Enabled = false;
            this.tbVertaald.Location = new System.Drawing.Point(15, 65);
            this.tbVertaald.Name = "tbVertaald";
            this.tbVertaald.Size = new System.Drawing.Size(121, 20);
            this.tbVertaald.TabIndex = 4;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 49);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Vertaling";
            // 
            // btnWoordToevoegen
            // 
            this.btnWoordToevoegen.Location = new System.Drawing.Point(15, 142);
            this.btnWoordToevoegen.Name = "btnWoordToevoegen";
            this.btnWoordToevoegen.Size = new System.Drawing.Size(121, 23);
            this.btnWoordToevoegen.TabIndex = 6;
            this.btnWoordToevoegen.Text = "Voeg een woord toe";
            this.btnWoordToevoegen.UseVisualStyleBackColor = true;
            this.btnWoordToevoegen.Click += new System.EventHandler(this.btnWoordToevoegen_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(15, 171);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(121, 23);
            this.btnVerwijder.TabIndex = 7;
            this.btnVerwijder.Text = "Verwijder geselecteerd woord";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // FormOef2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 202);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnWoordToevoegen);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.tbVertaald);
            this.Controls.Add(this.cbTeVertalen);
            this.Controls.Add(this.label1);
            this.Name = "FormOef2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Oefening 2";
            this.Load += new System.EventHandler(this.FormOef2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTeVertalen;
        private System.Windows.Forms.TextBox tbVertaald;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button btnWoordToevoegen;
        private System.Windows.Forms.Button btnVerwijder;
    }
}