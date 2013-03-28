using System;
using System.Collections.Generic;

namespace CaveVins.Business
{
    public static class ChateauController
    {
        static public Array listChateauxFull()
        {
            return Data.ChateauModel.listChateauxFull();
        }

        static public List<Entity.T_CHATEAU_CHT> listChateauxFromAppellation(int Appellation)
        {
            return Data.ChateauModel.listChateauxFromAppellation(Appellation);
        }
        
        static public void AjouterChateau(int idAppellation, string nomChateau, string descriptionChateau)
        {
            Data.ChateauModel.ajouterChateau(idAppellation, nomChateau, descriptionChateau);
        }

        static public void ModifierChateau(int idchateau, int idAppellation, string nomChateau, string descriptionChateau)
        {
            Data.ChateauModel.ModifierChateau(idchateau, idAppellation, nomChateau, descriptionChateau);
        }

        static public void SupprimerChateau(int idChateau)
        {
            Data.ChateauModel.SupprimerChateau(idChateau);
        }

        static public List<Entity.T_CHATEAU_CHT> listChateaux()
        {
            return Data.ChateauModel.listChateaux();
        }
    }
}
