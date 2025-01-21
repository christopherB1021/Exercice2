using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Changement
{
    public class EtatHistorique
    {
        public string Nom {  get; set; }
        public DateTime DateTimeChangement { get; set; }
        public EtatHistorique(string nom) 
          {
              Nom = nom;
              DateTimeChangement = DateTime.Now;
           }
    }
}
