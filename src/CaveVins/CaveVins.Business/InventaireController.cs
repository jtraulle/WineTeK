using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Business
{
    public class InventaireController
    {
        static public int combienBouteilles(int idBouteille)
        {
            return Data.InventaireModel.combienBouteilles(idBouteille);
        }


        static public void ajouterBouteilleInventaire(int idBouteille, int nbBouteilles)
        {
            if (combienBouteilles(idBouteille) == 0)
                Data.InventaireModel.ajouterBouteille(idBouteille, nbBouteilles);
            else
                Data.InventaireModel.majBouteille(idBouteille, nbBouteilles);
        }


        static public Boolean retirerBouteilleInventaire(int idBouteille, int nbBouteilles)
        {
            if (combienBouteilles(idBouteille) - nbBouteilles == 0)
                Data.InventaireModel.supprimerBouteille(idBouteille);
            else
                Data.InventaireModel.majBouteilleNeg(idBouteille, nbBouteilles);

            if (combienBouteilles(idBouteille) == 0)
                return true;
            else
                return false;
        }

        static public void modifierBouteilleInventaire(int idBouteille, int nbBouteilles)
        {
            Data.InventaireModel.modifierBouteille(idBouteille, nbBouteilles);
        }

        static public Array listerInventaire()
        {
            return Data.InventaireModel.listerInventaire();
        }


        static public void supprimerBouteille(int idBouteille)
        {
            Data.InventaireModel.supprimerBouteille(idBouteille);
        }

        static public long NbBouteillesFromMillesimeInventaire(int Millesime)
        {
            return Data.InventaireModel.NbBouteillesFromMillesimeInventaire(Millesime);
        }

        static public long NbBouteillesFromRegionInventaire(string Region)
        {
            return Data.InventaireModel.NbBouteillesFromRegionInventaire(Region);
        }

        static public long NbBouteillesFromAppellationInventaire(int Appellation)
        {
            return Data.InventaireModel.NbBouteillesFromAppellationInventaire(Appellation);
        }

        static public long NbBouteillesFromChateauInventaire(int Chateau)
        {
            return Data.InventaireModel.NbBouteillesFromChateauInventaire(Chateau);
        }
    }
}
