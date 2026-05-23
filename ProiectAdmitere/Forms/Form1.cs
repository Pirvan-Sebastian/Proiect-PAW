using ProiectAdmitere.Forms;
using ProiectAdmitere.Repositories;
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

namespace ProiectAdmitere
{
    public partial class Form1 : Form
    {
        private CandidatRepository repoCandidat = new CandidatRepository();
        private FacultateRepository repoFacultate = new FacultateRepository();
        private DosarRepository repoDosar = new DosarRepository();

        public Form1()
        {
            InitializeComponent();
            IncarcaToateDatele();
        }

        private void IncarcaToateDatele()
        {
            dgvCandidati.DataSource = repoCandidat.GetAll();
            dgvFacultati.DataSource=repoFacultate.GetAll();
            dgvDosare.DataSource=repoDosar.GetAll();

            if (dgvDosare.Columns.Count > 0)
            {
                //ascund id ul 
                dgvDosare.Columns["IdCandidat"].Visible = false;
                dgvDosare.Columns["IdFacultate"].Visible = false;
            }
        }
        //--Candidati--
        private void btnAdaugaCandidat_Click(object sender, EventArgs e)
        {
            using (var formularCandidat = new FormEditareCandidat())
            {
                if (formularCandidat.ShowDialog() == DialogResult.OK)
                { 
                    repoCandidat.Add(formularCandidat.CandidatModificat);
                    IncarcaToateDatele();
                }
            }
        }
        //din events -> properties
        private void dgvCandidati_DoubleClick(object sender, EventArgs e)
        {
            if(dgvCandidati.SelectedRows.Count > 0)
            {
                var c = new Candidat
                {
                    Id = (int)dgvCandidati.SelectedRows[0].Cells["Id"].Value,
                    NumeComplet = dgvCandidati.SelectedRows[0].Cells["NumeComplet"].Value.ToString(),
                    CNP = dgvCandidati.SelectedRows[0].Cells["CNP"].Value.ToString()
                };
                using (var formularCandidat = new FormEditareCandidat(c))
                {
                    if (formularCandidat.ShowDialog() == DialogResult.OK)
                    {
                        repoCandidat.Update(formularCandidat.CandidatModificat);
                        IncarcaToateDatele();
                    }
                }
            }
        }
        private void btnStergeCandidat_Click(object sender, EventArgs e)
        {
            if (dgvCandidati.SelectedRows.Count > 0)
            {
                repoCandidat.Delete((int)dgvCandidati.SelectedRows[0].Cells["Id"].Value);
                IncarcaToateDatele();
            }
        }
        //---FACULTATI---
        private void btnAdaugaFacultate_Click(object sender, EventArgs e)
        {
            using (var f = new FormEditareFacultate())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    repoFacultate.Add(f.FacultateModificata);
                    IncarcaToateDatele();
                }
            }
        }

        private void dgvFacultati_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFacultati.SelectedRows.Count > 0)
            {
                var fac = new Facultate
                {
                    Id = (int)dgvFacultati.SelectedRows[0].Cells["Id"].Value,
                    Nume = dgvFacultati.SelectedRows[0].Cells["Nume"].Value.ToString(),
                    NumarLocuri = (int)dgvFacultati.SelectedRows[0].Cells["NumarLocuri"].Value
                };
                using (var f = new FormEditareFacultate(fac))
                {
                    if (f.ShowDialog() == DialogResult.OK) { repoFacultate.Update(f.FacultateModificata); IncarcaToateDatele(); }
                }
            }
        }

        private void btnStergeFacultate_Click(object sender, EventArgs e)
        {
            if (dgvFacultati.SelectedRows.Count > 0)
            {
                repoFacultate.Delete((int)dgvFacultati.SelectedRows[0].Cells["Id"].Value);
                IncarcaToateDatele();
            }
        }
        //---DOSARE---
        private void btnAdaugaDosar_Click(object sender, EventArgs e)
        {
            using (var f = new FormEditareDosar())
            {
                if (f.ShowDialog() == DialogResult.OK)
                { 
                    repoDosar.Add(f.DosarModificat);
                    IncarcaToateDatele(); 
                }
            }
        }
        private void dgvDosare_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDosare.SelectedRows.Count > 0)
            {
                var d = new DosarAdmitere
                {
                    Id = (int)dgvDosare.SelectedRows[0].Cells["Id"].Value,
                    IdCandidat = (int)dgvDosare.SelectedRows[0].Cells["IdCandidat"].Value,
                    IdFacultate = (int)dgvDosare.SelectedRows[0].Cells["IdFacultate"].Value,
                    NotaBac = Convert.ToDouble(dgvDosare.SelectedRows[0].Cells["NotaBac"].Value),
                    NotaExamen = Convert.ToDouble(dgvDosare.SelectedRows[0].Cells["NotaExamen"].Value)
                };
                using (var f = new FormEditareDosar(d))
                {
                    if (f.ShowDialog() == DialogResult.OK)
                    { 
                        repoDosar.Update(f.DosarModificat);
                        IncarcaToateDatele();
                    }
                }
            }
        }

        private void btnStergeDosar_Click(object sender, EventArgs e)
        {
            if (dgvDosare.SelectedRows.Count > 0)
            {
                repoDosar.Delete((int)dgvDosare.SelectedRows[0].Cells["Id"].Value);
                IncarcaToateDatele();
            }
        }
    }
}
