using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Data
{
    public class AppellationModel
    {

        static public List<Entity.T_APPELLATION_APT> listAppellationsFromRegion(String Region)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from a in db.T_APPELLATION_APT
                                join r in db.T_REGION_REG on a.REG_C_CODE equals r.REG_C_CODE
                                where r.REG_C_CODE == Region
                                orderby a.APT_S_NOM
                                select a;
                return listquery.ToList();
            }
        }

        static public List<Entity.T_APPELLATION_APT> listAppellations()
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from a in db.T_APPELLATION_APT
                                orderby a.APT_S_NOM
                                select a;
                return listquery.ToList();
            }
        }

        static public Array listAppellationsFull()
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from a in db.T_APPELLATION_APT
                                orderby a.T_REGION_REG.T_PAYS_PAY.PAY_S_NOM,
                                        a.T_REGION_REG.REG_S_NOM,
                                        a.APT_S_NOM
                                select new
                                {
                                    Identifiant = a.APT_I_ID,
                                    Nom = a.APT_S_NOM,
                                    CodeReg = a.T_REGION_REG.REG_C_CODE,
                                    Région = a.T_REGION_REG.REG_S_NOM,
                                    Pays = a.T_REGION_REG.T_PAYS_PAY.PAY_S_NOM
                                };
                return listquery.ToArray();
            }
        }

        //Permet d'ajouter une appellation dans gérer données
        public static void AjouterAppellation(string nomAppellation, string codeRegion)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var appellation = new Entity.T_APPELLATION_APT
                {
                    APT_S_NOM = nomAppellation,
                    REG_C_CODE = codeRegion
                };
                db.T_APPELLATION_APT.Add(appellation);
                db.SaveChanges();
            }
        }

        //Permet de modifier une appellation dans gérer données
        public static void ModifierAppellation(int idAppellation, string nomAppellation, string codeRegion)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var appellation = db.T_APPELLATION_APT.First(i => i.APT_I_ID == idAppellation);
                appellation.APT_S_NOM = nomAppellation;
                appellation.REG_C_CODE = codeRegion;
                db.SaveChanges();
            }
        }

        //Permet de supprimer une appellation dans gérer données
        public static void SupprimerAppellation(int idAppellation)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var line = db.T_APPELLATION_APT.First(i => i.APT_I_ID == idAppellation);
                db.T_APPELLATION_APT.Remove(line);
                db.SaveChanges();
            }
        }
    }
}
