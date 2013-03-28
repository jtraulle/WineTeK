using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Business
{
    public class PaysController
    {
        static public void addPays(String code_pays, String nom_pays)
        {
            Data.PaysModel.addPays(code_pays, nom_pays);
        }
        
        static public List<Entity.T_PAYS_PAY> listPays()
        {
            return Data.PaysModel.listPays();
        }

        static public Array listPaysFull()
        {
            return Data.PaysModel.listPaysFull();
        }

        static public void ModifierPays(string codePays, string nomPays)
        {
            Data.PaysModel.ModifierPays(codePays, nomPays);  
        }

        static public void SupprimerPays(string codePays)
        {
            Data.PaysModel.SupprimerPays(codePays);
        }
    }
}
