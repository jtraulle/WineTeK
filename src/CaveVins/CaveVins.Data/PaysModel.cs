using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Data
{
    public class PaysModel
    {
        static public void addPays(String code_pays, String nom_pays)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var pays = new Entity.T_PAYS_PAY
                {
                    PAY_C_CODE = code_pays,
                    PAY_S_NOM = nom_pays
                };
                db.T_PAYS_PAY.Add(pays);
                db.SaveChanges();
            }
        }

        static public List<Entity.T_PAYS_PAY> listPays()
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from p in db.T_PAYS_PAY
                                orderby p.PAY_S_NOM
                                select p;
                return listquery.ToList();
            }
        }


        static public Array listPaysFull()
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from p in db.T_PAYS_PAY
                                orderby p.PAY_S_NOM
                                select new
                                {
                                    Identifiant = p.PAY_C_CODE,
                                    Nom = p.PAY_S_NOM
                                };
                return listquery.ToArray();
            }
        }

        //Permet d'ajouter un pays dans gérer données
        static public void AjouterPays(string codePays, string nomPays)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var pays = new Entity.T_PAYS_PAY
                {
                    PAY_C_CODE = codePays,
                    PAY_S_NOM = nomPays
                };
                db.T_PAYS_PAY.Add(pays);
                db.SaveChanges();
            }
        }

        //Permet de modifier un pays dans gérer données
        static public void ModifierPays(string codePays, string nomPays)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var pays = db.T_PAYS_PAY.First(i => i.PAY_C_CODE == codePays);
                pays.PAY_S_NOM = nomPays;
                db.SaveChanges();
            }
        }

        //Permet de supprimer un pays dans gérer données
        static public void SupprimerPays(string codePays)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var line = db.T_PAYS_PAY.First(i => i.PAY_C_CODE == codePays);
                db.T_PAYS_PAY.Remove(line);
                db.SaveChanges();
            }
        }


        static public void majPays(string codePays, Entity.T_PAYS_PAY paysToModify)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var pays = db.T_PAYS_PAY.First(i => i.PAY_C_CODE == codePays);
                pays.PAY_C_CODE = paysToModify.PAY_C_CODE;
                pays.PAY_S_NOM = paysToModify.PAY_S_NOM;
                db.SaveChanges();
            }
        }
    }
}
