using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Data
{
    public static class FlaconnageModel
    {
        //Permet d'ajouter un flaconnage dans gérer données
        static public void AjouterFlaconnage(string nomFlaconnage, int contenanceFlaconnage)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var flaconnage = new Entity.T_FLACONNAGE_FCG
                {
                    FCG_S_NOM = nomFlaconnage,
                    FCG_R_CONTENANCE = contenanceFlaconnage
                };
                db.T_FLACONNAGE_FCG.Add(flaconnage);
                db.SaveChanges();
            }
        }

        static public List<Entity.T_FLACONNAGE_FCG> listFlaconnages()
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from f in db.T_FLACONNAGE_FCG
                                orderby f.FCG_S_NOM
                                select f;
                return listquery.ToList();
            }
        }

        static public Array listFlaconnagesFull()
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from f in db.T_FLACONNAGE_FCG
                                orderby f.FCG_S_NOM
                                select new
                                {
                                    Identifiant = f.FCG_I_ID,
                                    Nom = f.FCG_S_NOM,
                                    Contenance = f.FCG_R_CONTENANCE
                                };
                return listquery.ToArray();
            }
        }

        //Permet de modifier un flaconnage dans gérer données
        static public void ModifierFlaconnage(int idFlaconnage, string nomFlaconnage, int contenanceFlaconnage)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var flaconnage = db.T_FLACONNAGE_FCG.First(i => i.FCG_I_ID == idFlaconnage);
                flaconnage.FCG_S_NOM = nomFlaconnage;
                flaconnage.FCG_R_CONTENANCE = contenanceFlaconnage;
                db.SaveChanges();
            }
        }

        //Permet de supprimer un flaconnage dans gérer données
        static public void SupprimerFlaconnage(int idFlaconnage)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var line = db.T_FLACONNAGE_FCG.First(i => i.FCG_I_ID == idFlaconnage);
                db.T_FLACONNAGE_FCG.Remove(line);
                db.SaveChanges();
            }
        }
    }
}
