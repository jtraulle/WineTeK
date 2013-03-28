using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Business
{
    public static class FlaconnageController
    {
        static public void AjouterFlaconnage(string nomFlaconnage, int contenanceFlaconnage)
        {
            Data.FlaconnageModel.AjouterFlaconnage(nomFlaconnage, contenanceFlaconnage);
        }
        
        static public void ModifierFlaconnage(int idFlaconnage, string nomFlaconnage, int contenanceFlaconnage)
        {
            Data.FlaconnageModel.ModifierFlaconnage(idFlaconnage, nomFlaconnage, contenanceFlaconnage);
        }

        static public void SupprimerFlaconnage(int idFlaconnage)
        {
            Data.FlaconnageModel.SupprimerFlaconnage(idFlaconnage);
        }

        public static Array listFlaconnagesFull(){
            return Data.FlaconnageModel.listFlaconnagesFull();
        }

        public static List<Entity.T_FLACONNAGE_FCG> listFlaconnages()
        {
            List<Entity.T_FLACONNAGE_FCG> list = Data.FlaconnageModel.listFlaconnages();

            foreach (Entity.T_FLACONNAGE_FCG flacon in list)
            {
                flacon.FCG_S_NOM = flacon.FCG_S_NOM + " (" + flacon.FCG_R_CONTENANCE + " cl)";
            }

            return list;
        }
    }
}
