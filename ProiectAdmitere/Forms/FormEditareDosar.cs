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
using ProiectAdmitere.Repositories;

namespace ProiectAdmitere.Forms
{
    public partial class FormEditareDosar : Form
    {
        public DosarAdmitere DosarModificat { get; private set; }
        public FormEditareDosar(DosarAdmitere dosar = null)
        {
            InitializeComponent();
            //Candidati 
            cbCandidat.DataSource= new CandidatRepository().GetAll(); //sursa variante
            cbCandidat.DisplayMember = "NumeComplet";
            cbCandidat.ValueMember = "Id"; //val selectata

            //Facultati
            cbFacultate.DataSource= new FacultateRepository().GetAll();
            cbFacultate.DisplayMember= "Nume Facultate";
            cbFacultate.ValueMember= "Id";


            if (dosar == null)
            {
                DosarModificat = new DosarAdmitere(); 
            }
            else
            {
                DosarModificat = dosar;
                cbCandidat.SelectedValue = dosar.IdCandidat;
                cbFacultate.SelectedValue = dosar.IdFacultate;
                txtBac.Text = dosar.NotaBac.ToString();
                txtExamen.Text = dosar.NotaExamen.ToString();
            }

        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            DosarModificat.IdCandidat = (int)cbCandidat.SelectedValue;
            DosarModificat.IdFacultate = (int)cbFacultate.SelectedValue;
            DosarModificat.NotaBac = Convert.ToDouble(txtBac.Text);
            DosarModificat.NotaExamen = Convert.ToDouble(txtExamen.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
