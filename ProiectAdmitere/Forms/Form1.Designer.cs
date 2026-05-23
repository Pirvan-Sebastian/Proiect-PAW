namespace ProiectAdmitere
{
    partial class Form1
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnStergeCandidat = new System.Windows.Forms.Button();
            this.btnAdaugaCandidat = new System.Windows.Forms.Button();
            this.dgvCandidati = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnStergeFacultate = new System.Windows.Forms.Button();
            this.btnAdaugaFacultate = new System.Windows.Forms.Button();
            this.dgvFacultati = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnStergeDosar = new System.Windows.Forms.Button();
            this.btnAdaugaDosar = new System.Windows.Forms.Button();
            this.dgvDosare = new System.Windows.Forms.DataGridView();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidati)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultati)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDosare)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(776, 426);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnStergeCandidat);
            this.tabPage1.Controls.Add(this.btnAdaugaCandidat);
            this.tabPage1.Controls.Add(this.dgvCandidati);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Candidati";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnStergeCandidat
            // 
            this.btnStergeCandidat.Location = new System.Drawing.Point(87, 350);
            this.btnStergeCandidat.Name = "btnStergeCandidat";
            this.btnStergeCandidat.Size = new System.Drawing.Size(75, 23);
            this.btnStergeCandidat.TabIndex = 2;
            this.btnStergeCandidat.Text = "Sterge";
            this.btnStergeCandidat.UseVisualStyleBackColor = true;
            this.btnStergeCandidat.Click += new System.EventHandler(this.btnStergeCandidat_Click);
            // 
            // btnAdaugaCandidat
            // 
            this.btnAdaugaCandidat.Location = new System.Drawing.Point(6, 350);
            this.btnAdaugaCandidat.Name = "btnAdaugaCandidat";
            this.btnAdaugaCandidat.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugaCandidat.TabIndex = 1;
            this.btnAdaugaCandidat.Text = "Adauga";
            this.btnAdaugaCandidat.UseVisualStyleBackColor = true;
            this.btnAdaugaCandidat.Click += new System.EventHandler(this.btnAdaugaCandidat_Click);
            // 
            // dgvCandidati
            // 
            this.dgvCandidati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidati.Location = new System.Drawing.Point(0, 0);
            this.dgvCandidati.Name = "dgvCandidati";
            this.dgvCandidati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidati.Size = new System.Drawing.Size(768, 344);
            this.dgvCandidati.TabIndex = 0;
            this.dgvCandidati.DoubleClick += new System.EventHandler(this.dgvCandidati_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnStergeFacultate);
            this.tabPage2.Controls.Add(this.btnAdaugaFacultate);
            this.tabPage2.Controls.Add(this.dgvFacultati);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Facultati";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnStergeFacultate
            // 
            this.btnStergeFacultate.Location = new System.Drawing.Point(87, 356);
            this.btnStergeFacultate.Name = "btnStergeFacultate";
            this.btnStergeFacultate.Size = new System.Drawing.Size(75, 23);
            this.btnStergeFacultate.TabIndex = 4;
            this.btnStergeFacultate.Text = "Sterge";
            this.btnStergeFacultate.UseVisualStyleBackColor = true;
            this.btnStergeFacultate.Click += new System.EventHandler(this.btnStergeFacultate_Click);
            // 
            // btnAdaugaFacultate
            // 
            this.btnAdaugaFacultate.Location = new System.Drawing.Point(6, 356);
            this.btnAdaugaFacultate.Name = "btnAdaugaFacultate";
            this.btnAdaugaFacultate.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugaFacultate.TabIndex = 3;
            this.btnAdaugaFacultate.Text = "Adauga";
            this.btnAdaugaFacultate.UseVisualStyleBackColor = true;
            this.btnAdaugaFacultate.Click += new System.EventHandler(this.btnAdaugaFacultate_Click);
            // 
            // dgvFacultati
            // 
            this.dgvFacultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacultati.Location = new System.Drawing.Point(0, 0);
            this.dgvFacultati.Name = "dgvFacultati";
            this.dgvFacultati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacultati.Size = new System.Drawing.Size(768, 350);
            this.dgvFacultati.TabIndex = 0;
            this.dgvFacultati.DoubleClick += new System.EventHandler(this.dgvFacultati_DoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnStergeDosar);
            this.tabPage3.Controls.Add(this.btnAdaugaDosar);
            this.tabPage3.Controls.Add(this.dgvDosare);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dosare";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnStergeDosar
            // 
            this.btnStergeDosar.Location = new System.Drawing.Point(87, 349);
            this.btnStergeDosar.Name = "btnStergeDosar";
            this.btnStergeDosar.Size = new System.Drawing.Size(75, 23);
            this.btnStergeDosar.TabIndex = 6;
            this.btnStergeDosar.Text = "Sterge";
            this.btnStergeDosar.UseVisualStyleBackColor = true;
            this.btnStergeDosar.Click += new System.EventHandler(this.btnStergeDosar_Click);
            // 
            // btnAdaugaDosar
            // 
            this.btnAdaugaDosar.Location = new System.Drawing.Point(6, 349);
            this.btnAdaugaDosar.Name = "btnAdaugaDosar";
            this.btnAdaugaDosar.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugaDosar.TabIndex = 5;
            this.btnAdaugaDosar.Text = "Adauga";
            this.btnAdaugaDosar.UseVisualStyleBackColor = true;
            this.btnAdaugaDosar.Click += new System.EventHandler(this.btnAdaugaDosar_Click);
            // 
            // dgvDosare
            // 
            this.dgvDosare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDosare.Location = new System.Drawing.Point(-4, 0);
            this.dgvDosare.Name = "dgvDosare";
            this.dgvDosare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDosare.Size = new System.Drawing.Size(772, 343);
            this.dgvDosare.TabIndex = 0;
            this.dgvDosare.DoubleClick += new System.EventHandler(this.dgvDosare_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidati)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacultati)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDosare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvCandidati;
        private System.Windows.Forms.DataGridView dgvFacultati;
        private System.Windows.Forms.DataGridView dgvDosare;
        private System.Windows.Forms.Button btnStergeCandidat;
        private System.Windows.Forms.Button btnAdaugaCandidat;
        private System.Windows.Forms.Button btnStergeFacultate;
        private System.Windows.Forms.Button btnAdaugaFacultate;
        private System.Windows.Forms.Button btnStergeDosar;
        private System.Windows.Forms.Button btnAdaugaDosar;
    }
}

