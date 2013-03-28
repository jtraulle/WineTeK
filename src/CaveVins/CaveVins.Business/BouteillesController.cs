using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Business
{
    public class BouteillesController
    {
        static public Array listBouteillesFull()
        {
            return Data.BouteilleModel.listBouteillesFull();
        }
        
        static public Array listBouteillesFromPays(String Pays)
        {
            return Data.BouteilleModel.listBouteillesFromPays(Pays);
        }

        static public Array listBouteillesFromRegion(String Region)
        {
            return Data.BouteilleModel.listBouteillesFromRegion(Region);
        }

        static public Array listBouteillesFromAppellation(int Appellation)
        {
            return Data.BouteilleModel.listBouteillesFromAppellation(Appellation);
        }

        static public Array listBouteillesFromMillesime(int Millesime)
        {
            return Data.BouteilleModel.listBouteillesFromMillesime(Millesime);
        }

        static public Array listBouteillesFromChateau(String Chateau)
        {
            return Data.BouteilleModel.listBouteillesFromChateau(Chateau);
        }

        static public long NbBouteillesFromMillesime(int Millesime)
        {
            return Data.BouteilleModel.NbBouteillesFromMillesime(Millesime);
        }

        static public long NbBouteillesFromRegion(string Region)
        {
            return Data.BouteilleModel.NbBouteillesFromRegion(Region);
        }

        static public long NbBouteillesFromAppellation(int Appellation)
        {
            return Data.BouteilleModel.NbBouteillesFromAppellation(Appellation);
        }

        static public long NbBouteillesFromChateau(int Chateau)
        {
            return Data.BouteilleModel.NbBouteillesFromChateau(Chateau);
        }

        static public void AjouterBouteille(int idFlaconnage, int idChateau, int idCouleur, int millesimebouteille, float prixBasBouteille, float prixHautBouteille)
        {
            Data.BouteilleModel.ajouterBouteille(idFlaconnage, idChateau, idCouleur, millesimebouteille, prixBasBouteille, prixHautBouteille);
        }

        static public void ModifierBouteille(int idBouteille, int idFlaconnage, int idChateau, int idCouleur, int millesimebouteille, float prixBasBouteille, float prixHautBouteille)
        {
            Data.BouteilleModel.ModifierBouteille(idBouteille, idFlaconnage, idChateau, idCouleur, millesimebouteille, prixBasBouteille, prixHautBouteille);
        }

        static public void SupprimerBouteille(int idBouteille)
        {
            Data.BouteilleModel.SupprimerBouteille(idBouteille);
        }
    }
}
