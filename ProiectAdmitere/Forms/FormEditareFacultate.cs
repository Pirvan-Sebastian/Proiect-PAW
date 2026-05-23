using ProiectAdmitere.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectAdmitere.Forms
{
    public partial class FormEditareFacultate : Form
    {
        public Facultate FacultateModificata { get; private set; }

        public FormEditareFacultate(Facultate facultate = null)
        {
            InitializeComponent();
            if(facultate == null) { FacultateModificata = new Facultate(); }
            else
            {
                FacultateModificata = facultate;
                txtNume.Text = facultate.Nume;
                txtLocuri.Text = facultate.NumarLocuri.ToString();
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            FacultateModificata.Nume = txtNume.Text;
            FacultateModificata.NumarLocuri = Convert.ToInt32(txtLocuri.Text);
            this.DialogResult = DialogResult.OK;
        }

        //din greseala
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
