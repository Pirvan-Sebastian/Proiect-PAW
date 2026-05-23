using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAdmitere.Models
{
    public class DosarAdmitere
    {
        public int Id { get; set; }
        public int IdCandidat { get; set; }
        public int IdFacultate { get; set; }
        public double NotaBac { get; set; }
        public double NotaExamen { get; set; }
        public string NumeCandidat { get; set; }
        public string NumeFacultate { get; set; }

        public double MedieAdmitere 
        { get 
            {
                return (NotaBac * 0.4) + (NotaExamen * 0.6); //60% examen si 40% Bac
            }
        
        }
        public DosarAdmitere() { }
        
    }
}
