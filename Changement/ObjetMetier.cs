using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Changement
{
   
    public class ObjetMetier
    {
        //Id de l'objet
        public int Id { get; set; }
        // Etat permettant de retracer l'historique des modifications
        public List<EtatHistorique> EtatHistoriques { get; set; } = new List<EtatHistorique>();


        public ObjetMetier(int id) 
        {
            Id = id;
        }
        public void AjouterEtat(EtatHistorique etatHistorique)
        {
            EtatHistoriques.Add(etatHistorique);
        }
         public void AfficherHistorique(EtatHistorique etatHistorique)
         {
            //Console.WriteLine($"Historique de l'objet : {etatHistorique.Nom} );
            foreach (var etathistorique in EtatHistoriques)
            {Console.WriteLine("on affiche la liste des changements d'état de l'objet");
             Console.WriteLine("Etat : " + etatHistorique.Nom + " Date : " + etatHistorique.DateTimeChangement);
            }
         }

    }
}
