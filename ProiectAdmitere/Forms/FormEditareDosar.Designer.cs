namespace ProiectAdmitere.Forms
{
    partial class FormEditareDosar
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
            this.cbCandidat = new System.Windows.Forms.ComboBox();
            this.cbFacultate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBac = new System.Windows.Forms.TextBox();
            this.txtExamen = new System.Windows.Forms.TextBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCandidat
            // 
            this.cbCandidat.FormattingEnabled = true;
            this.cbCandidat.Location = new System.Drawing.Point(86, 33);
            this.cbCandidat.Name = "cbCandidat";
            this.cbCandidat.Size = new System.Drawing.Size(170, 21);
            this.cbCandidat.TabIndex = 0;
            // 
            // cbFacultate
            // 
            this.cbFacultate.FormattingEnabled = true;
            this.cbFacultate.Location = new System.Drawing.Point(86, 75);
            this.cbFacultate.Name = "cbFacultate";
            this.cbFacultate.Size = new System.Drawing.Size(170, 21);
            this.cbFacultate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Candidat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Facultate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota Bac";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nota Examen";
            // 
            // txtBac
            // 
            this.txtBac.Location = new System.Drawing.Point(86, 129);
            this.txtBac.Name = "txtBac";
            this.txtBac.Size = new System.Drawing.Size(170, 20);
            this.txtBac.TabIndex = 6;
            // 
            // txtExamen
            // 
            this.txtExamen.Location = new System.Drawing.Point(86, 170);
            this.txtExamen.Name = "txtExamen";
            this.txtExamen.Size = new System.Drawing.Size(170, 20);
            this.txtExamen.TabIndex = 7;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(86, 229);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(110, 44);
            this.btnSalveaza.TabIndex = 8;
            this.btnSalveaza.Text = "Save";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // FormEditareDosar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 313);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.txtExamen);
            this.Controls.Add(this.txtBac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFacultate);
            this.Controls.Add(this.cbCandidat);
            this.Name = "FormEditareDosar";
            this.Text = "FormEditareDosar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCandidat;
        private System.Windows.Forms.ComboBox cbFacultate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBac;
        private System.Windows.Forms.TextBox txtExamen;
        private System.Windows.Forms.Button btnSalveaza;
    }
}