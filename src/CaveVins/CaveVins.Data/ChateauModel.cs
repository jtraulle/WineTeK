using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Data
{
    public static class ChateauModel
    {
        //Permet d'ajouter un chateau dans gérer données
        static public void ajouterChateau(int idAppellation, string nomChateau, string descriptionChateau)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var chateau = new Entity.T_CHATEAU_CHT
                {
                    APT_I_ID = idAppellation,
                    CHT_S_CHATEAU = nomChateau,
                    CHT_T_DESCRIPTION = descriptionChateau
                };
                db.T_CHATEAU_CHT.Add(chateau);
                db.SaveChanges();
            }
        }

        static public List<Entity.T_CHATEAU_CHT> listChateauxFromAppellation(int Appellation)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from c in db.T_CHATEAU_CHT
                                where c.T_APPELLATION_APT.APT_I_ID == Appellation
                                orderby c.CHT_S_CHATEAU
                                select c;
                return listquery.ToList();
            }
        }

        static public Array listChateauxFull()
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from c in db.T_CHATEAU_CHT
                                orderby c.T_APPELLATION_APT.T_REGION_REG.T_PAYS_PAY.PAY_S_NOM,
                                        c.T_APPELLATION_APT.T_REGION_REG.REG_S_NOM,
                                        c.T_APPELLATION_APT.APT_S_NOM,
                                        c.CHT_S_CHATEAU
                                select new
                                {
                                    Identifiant = c.CHT_I_ID,
                                    Nom = c.CHT_S_CHATEAU,
                                    Description = c.CHT_T_DESCRIPTION,
                                    IdAppellation = c.T_APPELLATION_APT.APT_I_ID,
                                    Appellation = c.T_APPELLATION_APT.APT_S_NOM,
                                    Région = c.T_APPELLATION_APT.T_REGION_REG.REG_S_NOM,
                                    Pays = c.T_APPELLATION_APT.T_REGION_REG.T_PAYS_PAY.PAY_S_NOM
                                };
                return listquery.ToArray();
            }
        }


        static public List<Entity.T_CHATEAU_CHT> listChateaux()
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from c in db.T_CHATEAU_CHT
                                orderby c.CHT_S_CHATEAU
                                select c;
                return listquery.ToList();
            }
        }

        //Permet de modifier un chateau dans gérer données
        static public void ModifierChateau(int idChateau, int idAppellation, string nomChateau, string descriptionChateau)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var chateau = db.T_CHATEAU_CHT.First(i => i.CHT_I_ID == idChateau);
                chateau.APT_I_ID = idAppellation;
                chateau.CHT_S_CHATEAU = nomChateau;
                chateau.CHT_T_DESCRIPTION = descriptionChateau;
                db.SaveChanges();
            }
        }

        //Permet de supprimer un chateau dans gérer données
        static public void SupprimerChateau(int idChateau)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var line = db.T_CHATEAU_CHT.First(i => i.CHT_I_ID == idChateau);
                db.T_CHATEAU_CHT.Remove(line);
                db.SaveChanges();
            }
        }
    }
}
