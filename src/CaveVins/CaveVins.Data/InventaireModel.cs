using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Data
{
    public class InventaireModel
    {
        static public int combienBouteilles(int idBouteille)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from inventaire in db.T_INVENTAIRE_INV
                                where inventaire.BTL_I_ID == idBouteille
                                select inventaire.INV_I_NB;

                if (listquery.Count() == 0)
                    return 0;
                else
                {
                    List<int> nbBouteilles = listquery.ToList();
                    return int.Parse(nbBouteilles.ElementAt(0).ToString());
                }
            }
        }

        //Permet d'ajouter une bouteille dans l'inventaire
        static public void ajouterBouteille(int idBouteille, int nbBouteilles)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var bouteille = new Entity.T_INVENTAIRE_INV
                {
                    BTL_I_ID = idBouteille,
                    INV_I_NB = nbBouteilles
                };
                db.T_INVENTAIRE_INV.Add(bouteille);
                db.SaveChanges();
            }
        }

        static public void majBouteille(int idBouteille, int nbBouteilles)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var bouteille = db.T_INVENTAIRE_INV.First(i => i.BTL_I_ID == idBouteille);
                bouteille.INV_I_NB = bouteille.INV_I_NB + nbBouteilles;
                db.SaveChanges();
            }
        }

        static public void majBouteilleNeg(int idBouteille, int nbBouteilles)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var bouteille = db.T_INVENTAIRE_INV.First(i => i.BTL_I_ID == idBouteille);
                bouteille.INV_I_NB = bouteille.INV_I_NB - nbBouteilles;
                db.SaveChanges();
            }
        }

        //Permet de modifier une bouteille dans l'inventaire
        static public void modifierBouteille(int idBouteille, int nbBouteilles)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var bouteille = db.T_INVENTAIRE_INV.First(i => i.BTL_I_ID == idBouteille);
                bouteille.INV_I_NB = nbBouteilles;
                db.SaveChanges();
            }
        }

        //Permet de supprimer une bouteille dans l'inventaire
        static public void supprimerBouteille(int idBouteille)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var line = db.T_INVENTAIRE_INV.First(i => i.BTL_I_ID == idBouteille);
                db.T_INVENTAIRE_INV.Remove(line);
                db.SaveChanges();
            }
        }

        static public Array listerInventaire()
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from inventaire in db.T_INVENTAIRE_INV
                                join bouteille in db.T_BOUTEILLE_BTL on inventaire.BTL_I_ID equals bouteille.BTL_I_ID
                                join chateau in db.T_CHATEAU_CHT on bouteille.CHT_I_ID equals chateau.CHT_I_ID
                                join appellation in db.T_APPELLATION_APT on chateau.APT_I_ID equals appellation.APT_I_ID
                                join region in db.T_REGION_REG on appellation.REG_C_CODE equals region.REG_C_CODE
                                join pays in db.T_PAYS_PAY on region.PAY_C_CODE equals pays.PAY_C_CODE
                                join couleur in db.T_COULEUR_CLR on bouteille.CLR_I_ID equals couleur.CLR_I_ID
                                join flaconnage in db.T_FLACONNAGE_FCG on bouteille.FCG_I_ID equals flaconnage.FCG_I_ID
                                orderby inventaire.INV_I_NB descending
                                select new
                                {
                                    Id = bouteille.BTL_I_ID,
                                    Château = chateau.CHT_S_CHATEAU,
                                    Millésime = bouteille.BTL_I_MILLESIME,
                                    Qté = inventaire.INV_I_NB,
                                    Couleur = couleur.CLR_S_NOM,
                                    Flaconnage = flaconnage.FCG_S_NOM,
                                    cL = flaconnage.FCG_R_CONTENANCE,
                                    Appellation = appellation.APT_S_NOM,
                                    Région = region.REG_S_NOM,
                                    Pays = pays.PAY_S_NOM
                                };
                return listquery.ToArray();
            }
        }

        static public long NbBouteillesFromMillesimeInventaire(int Millesime)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from inventaire in db.T_INVENTAIRE_INV
                                join bouteille in db.T_BOUTEILLE_BTL on inventaire.BTL_I_ID equals bouteille.BTL_I_ID
                                where bouteille.BTL_I_MILLESIME == Millesime
                                select inventaire.INV_I_NB;

                if(listquery.Count() == 0)
                    return 0;
                else
                    return listquery.Sum();
            }
        }

        static public long NbBouteillesFromRegionInventaire(string Region)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from inventaire in db.T_INVENTAIRE_INV
                                join bouteille in db.T_BOUTEILLE_BTL on inventaire.BTL_I_ID equals bouteille.BTL_I_ID
                                join chateau in db.T_CHATEAU_CHT on bouteille.CHT_I_ID equals chateau.CHT_I_ID
                                join appellation in db.T_APPELLATION_APT on chateau.APT_I_ID equals appellation.APT_I_ID
                                join region in db.T_REGION_REG on appellation.REG_C_CODE equals region.REG_C_CODE
                                where region.REG_C_CODE == Region
                                select inventaire.INV_I_NB;
                if (listquery.Count() == 0)
                    return 0;
                else
                    return listquery.Sum();
            }
        }

        static public long NbBouteillesFromAppellationInventaire(int Appellation)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from inventaire in db.T_INVENTAIRE_INV
                                join bouteille in db.T_BOUTEILLE_BTL on inventaire.BTL_I_ID equals bouteille.BTL_I_ID
                                join chateau in db.T_CHATEAU_CHT on bouteille.CHT_I_ID equals chateau.CHT_I_ID
                                join appellation in db.T_APPELLATION_APT on chateau.APT_I_ID equals appellation.APT_I_ID
                                where appellation.APT_I_ID == Appellation
                                select inventaire.INV_I_NB;
                if (listquery.Count() == 0)
                    return 0;
                else
                    return listquery.Sum(); 
            }
        }

        static public long NbBouteillesFromChateauInventaire(int Chateau)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from inventaire in db.T_INVENTAIRE_INV
                                join bouteille in db.T_BOUTEILLE_BTL on inventaire.BTL_I_ID equals bouteille.BTL_I_ID
                                join chateau in db.T_CHATEAU_CHT on bouteille.CHT_I_ID equals chateau.CHT_I_ID
                                where chateau.CHT_I_ID == Chateau
                                select inventaire.INV_I_NB;
                if (listquery.Count() == 0)
                    return 0;
                else
                    return listquery.Sum();
            }
        }
    }
}
