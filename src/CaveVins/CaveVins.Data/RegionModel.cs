using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Data
{
    public class RegionModel
    {

        static public List<Entity.T_REGION_REG> listRegionsFromPays(string Pays)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from r in db.T_REGION_REG
                                join p in db.T_PAYS_PAY on r.PAY_C_CODE equals p.PAY_C_CODE
                                where p.PAY_C_CODE == Pays
                                orderby r.REG_S_NOM
                                select r;
                return listquery.ToList();
            }
        }


        static public List<Entity.T_REGION_REG> listRegions()
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from r in db.T_REGION_REG
                                orderby r.REG_S_NOM
                                select r;
                return listquery.ToList();
            }
        }

        static public Array listRegionsFull()
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from r in db.T_REGION_REG
                                join p in db.T_PAYS_PAY on r.PAY_C_CODE equals p.PAY_C_CODE
                                orderby p.PAY_S_NOM, r.REG_S_NOM
                                select new
                                {
                                    Identifiant = r.REG_C_CODE,
                                    Nom = r.REG_S_NOM,
                                    IdPays = p.PAY_C_CODE,
                                    Pays = p.PAY_S_NOM
                                };
                return listquery.ToArray();
            }
        }

        //Permet d'ajouter une région dans gérer données 
        static public void AjouterRegion(string codeRegion, string nomRegion, string codePays)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var region = new Entity.T_REGION_REG
                {
                    REG_C_CODE = codeRegion,
                    REG_S_NOM = nomRegion,
                    PAY_C_CODE = codePays
                };
                db.T_REGION_REG.Add(region);
                db.SaveChanges();
            }
        }

        //Permet de modifier une région dans gérer données
        static public void ModifierRegion(string codeRegion, string nomRegion, string codePays)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var region = db.T_REGION_REG.First(i => i.REG_C_CODE == codeRegion);
                region.REG_S_NOM = nomRegion;
                region.PAY_C_CODE = codePays;
                db.SaveChanges();
            }
        }

        //Permet de supprimer une région dans gérer données
        static public void SupprimerRegion(string codeRegion)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var line = db.T_REGION_REG.First(i => i.REG_C_CODE == codeRegion);
                db.T_REGION_REG.Remove(line);
                db.SaveChanges();
            }
        }
    }
}
