using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectAdmitere.Models
{
    public class Facultate
    {
        public int Id {  get; set; }
        public string Nume {  get; set; }
        public int NumarLocuri {  get; set; }
        //constructor
        public Facultate() { }
    }
}
