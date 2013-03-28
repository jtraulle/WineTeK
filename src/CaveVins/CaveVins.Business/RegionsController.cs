using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Business
{
    public class RegionsController
    {
        static public List<Entity.T_REGION_REG> listRegionsFromPays(String Pays)
        {
            return Data.RegionModel.listRegionsFromPays(Pays);
        }

        static public List<Entity.T_REGION_REG> listRegions()
        {
            return Data.RegionModel.listRegions();
        }


        static public Array listRegionsFull()
        {
            return Data.RegionModel.listRegionsFull();
        }

        static public void AjouterRegion(string codeRegion, string nomRegion, string codePays)
        {
            Data.RegionModel.AjouterRegion(codeRegion, nomRegion, codePays);
        }

        static public void ModifierRegion(string codeRegion, string nomRegion, string codePays)
        {
            Data.RegionModel.ModifierRegion(codeRegion, nomRegion, codePays);
        }
 
        static public void SupprimerRegion(string codeRegion)
        {
            Data.RegionModel.SupprimerRegion(codeRegion);
        }
    }
}
