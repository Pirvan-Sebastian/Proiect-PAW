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
    public partial class FormEditareCandidat : Form
    {
        public Candidat CandidatModificat { get; private set; }
        //daca nu exista deja acest candidat face unul nou si il baga in CanidatModificat, altfel foloseste candidat existent
        //pentru a refolosi acelasi Form si pt Adaugare si editare- code styling!
        public FormEditareCandidat(Candidat candidat = null) //=null valoare default
        {
            InitializeComponent();
            if (candidat == null)
            { 
                CandidatModificat = new Candidat(); 
            }

            else
            {
                CandidatModificat = candidat;
                txtNume.Text = candidat.NumeComplet;
                txtCNP.Text = candidat.CNP;
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            CandidatModificat.NumeComplet = txtNume.Text;
            CandidatModificat.CNP = txtCNP.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
