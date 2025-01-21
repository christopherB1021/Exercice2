using Changement;
using System;
using System.Globalization;

namespace MyApp
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            //Creation de l'objet métier
            ObjetMetier course = new ObjetMetier(1);
            // ajouytr le nom de l'objet


            //Ajout des différents état
             Console.WriteLine("Ajouter un etat");
            //string etat = Console.ReadLine();
             string nom = Console.ReadLine();
            course.AjouterEtat(new EtatHistorique("initial"));

            //Récuperer l'historique des états 
             //foreach (var EtatHistoriques in etat);
            course.AfficherHistorique(new EtatHistorique(nom));


        }
    }
}