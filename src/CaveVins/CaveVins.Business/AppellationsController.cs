using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Business
{
    public class AppellationsController
    {
        static public List<Entity.T_APPELLATION_APT> listAppellationsFromRegion(String Region)
        {
            return Data.AppellationModel.listAppellationsFromRegion(Region);
        }

        static public List<Entity.T_APPELLATION_APT> listAppellations()
        {
            return Data.AppellationModel.listAppellations();
        }

        static public Array listAppellationsFull()
        {
            return Data.AppellationModel.listAppellationsFull();
        }

        static public void AjouterAppellation(string nomAppellation, string codeRegion)
        {
            Data.AppellationModel.AjouterAppellation(nomAppellation, codeRegion);
        }

        static public void ModifierAppellation(int idAppellation, string nomAppellation, string codeRegion)
        {
            Data.AppellationModel.ModifierAppellation(idAppellation, nomAppellation, codeRegion);            
        }

        static public void SupprimerAppellation(int idAppellation)
        {
            Data.AppellationModel.SupprimerAppellation(idAppellation);
        }
    }
}
