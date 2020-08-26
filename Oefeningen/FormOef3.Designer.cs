namespace Oefeningen
{
    partial class FormOef3
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
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnWoordToevoegen = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.tbVertaald = new System.Windows.Forms.TextBox();
            this.cbTeVertalen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGeselecteerdeTaal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(15, 192);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(121, 23);
            this.btnVerwijder.TabIndex = 13;
            this.btnVerwijder.Text = "Verwijder geselecteerd woord";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // btnWoordToevoegen
            // 
            this.btnWoordToevoegen.Location = new System.Drawing.Point(15, 163);
            this.btnWoordToevoegen.Name = "btnWoordToevoegen";
            this.btnWoordToevoegen.Size = new System.Drawing.Size(121, 23);
            this.btnWoordToevoegen.TabIndex = 12;
            this.btnWoordToevoegen.Text = "Voeg een woord toe";
            this.btnWoordToevoegen.UseVisualStyleBackColor = true;
            this.btnWoordToevoegen.Click += new System.EventHandler(this.btnWoordToevoegen_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 121);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Vertaling";
            // 
            // tbVertaald
            // 
            this.tbVertaald.Enabled = false;
            this.tbVertaald.Location = new System.Drawing.Point(15, 137);
            this.tbVertaald.Name = "tbVertaald";
            this.tbVertaald.Size = new System.Drawing.Size(121, 20);
            this.tbVertaald.TabIndex = 10;
            // 
            // cbTeVertalen
            // 
            this.cbTeVertalen.FormattingEnabled = true;
            this.cbTeVertalen.Location = new System.Drawing.Point(15, 25);
            this.cbTeVertalen.Name = "cbTeVertalen";
            this.cbTeVertalen.Size = new System.Drawing.Size(121, 21);
            this.cbTeVertalen.TabIndex = 9;
            this.cbTeVertalen.SelectedIndexChanged += new System.EventHandler(this.cbTeVertalen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Te vertalen woord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Vertalen naar";
            // 
            // cbGeselecteerdeTaal
            // 
            this.cbGeselecteerdeTaal.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cbGeselecteerdeTaal.FormattingEnabled = true;
            this.cbGeselecteerdeTaal.Location = new System.Drawing.Point(15, 65);
            this.cbGeselecteerdeTaal.Name = "cbGeselecteerdeTaal";
            this.cbGeselecteerdeTaal.Size = new System.Drawing.Size(121, 21);
            this.cbGeselecteerdeTaal.TabIndex = 15;
            this.cbGeselecteerdeTaal.SelectedIndexChanged += new System.EventHandler(this.cbGeselecteerdeTaal_SelectedIndexChanged);
            // 
            // FormOef3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 236);
            this.Controls.Add(this.cbGeselecteerdeTaal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnWoordToevoegen);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.tbVertaald);
            this.Controls.Add(this.cbTeVertalen);
            this.Controls.Add(this.label1);
            this.Name = "FormOef3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormOef3";
            this.Load += new System.EventHandler(this.FormOef3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnWoordToevoegen;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox tbVertaald;
        private System.Windows.Forms.ComboBox cbTeVertalen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGeselecteerdeTaal;
    }
}