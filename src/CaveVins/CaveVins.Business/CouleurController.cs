using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Business
{
    public static class CouleurController
    {
        public static List<Entity.T_COULEUR_CLR> listCouleurs()
        {
            return Data.CouleurModel.listCouleurs();
        }

        public static Array listCouleursFull()
        {
            return Data.CouleurModel.listCouleursFull();
        }

        static public void AjouterCouleur(string nomCouleur)
        {
            Data.CouleurModel.AjouterCouleur(nomCouleur);
        }

        static public void ModifierCouleur(int idCouleur, string nomCouleur)
        {
            Data.CouleurModel.ModifierCouleur(idCouleur, nomCouleur);   
        }

        static public void SupprimerCouleur(int idCouleur)
        {
            Data.CouleurModel.SupprimerCouleur(idCouleur);
        }
    }
}
