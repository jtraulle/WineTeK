using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Data
{
    public class BouteilleModel
    {

        static public Array listBouteillesFromPays(String Pays)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from bouteille in db.T_BOUTEILLE_BTL
                                join chateau in db.T_CHATEAU_CHT on bouteille.CHT_I_ID equals chateau.CHT_I_ID
                                join appellation in db.T_APPELLATION_APT on chateau.APT_I_ID equals appellation.APT_I_ID
                                join region in db.T_REGION_REG on appellation.REG_C_CODE equals region.REG_C_CODE
                                join pays in db.T_PAYS_PAY on region.PAY_C_CODE equals pays.PAY_C_CODE
                                join couleur in db.T_COULEUR_CLR on bouteille.CLR_I_ID equals couleur.CLR_I_ID
                                join flaconnage in db.T_FLACONNAGE_FCG on bouteille.FCG_I_ID equals flaconnage.FCG_I_ID
                                where pays.PAY_C_CODE == Pays
                                orderby region.REG_S_NOM
                                select new {
                                                Id = bouteille.BTL_I_ID,
                                                Château = chateau.CHT_S_CHATEAU, 
                                                Millésime = bouteille.BTL_I_MILLESIME,
                                                Couleur = couleur.CLR_S_NOM, 
                                                Flaconnage = flaconnage.FCG_S_NOM, 
                                                cL = flaconnage.FCG_R_CONTENANCE,
                                                Appellation = appellation.APT_S_NOM,
                                                Région = region.REG_S_NOM
                                            };
                return listquery.ToArray();
            }
        }

        static public Array listBouteillesFull()
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from b in db.T_BOUTEILLE_BTL
                                select new
                                {
                                    Id = b.BTL_I_ID,
                                    Château = b.T_CHATEAU_CHT.CHT_S_CHATEAU,
                                    Couleur = b.T_COULEUR_CLR.CLR_S_NOM,
                                    Millésime = b.BTL_I_MILLESIME,
                                    Flaconnage = b.T_FLACONNAGE_FCG.FCG_S_NOM,
                                    Contenance = b.T_FLACONNAGE_FCG.FCG_R_CONTENANCE,
                                    Prix_bas = b.BTL_R_PRIXBAS,
                                    Prix_haut = b.BTL_R_PRIXHAUT,
                                    IdChateau = b.T_CHATEAU_CHT.CHT_I_ID,
                                    IdFlaconnage = b.T_FLACONNAGE_FCG.FCG_I_ID,
                                    IdCouleur = b.T_COULEUR_CLR.CLR_I_ID
                                };
                return listquery.ToArray();
            }
        }

        static public Array listBouteillesFromRegion(String Region)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from bouteille in db.T_BOUTEILLE_BTL
                                join chateau in db.T_CHATEAU_CHT on bouteille.CHT_I_ID equals chateau.CHT_I_ID
                                join appellation in db.T_APPELLATION_APT on chateau.APT_I_ID equals appellation.APT_I_ID
                                join region in db.T_REGION_REG on appellation.REG_C_CODE equals region.REG_C_CODE
                                join pays in db.T_PAYS_PAY on region.PAY_C_CODE equals pays.PAY_C_CODE
                                join couleur in db.T_COULEUR_CLR on bouteille.CLR_I_ID equals couleur.CLR_I_ID
                                join flaconnage in db.T_FLACONNAGE_FCG on bouteille.FCG_I_ID equals flaconnage.FCG_I_ID
                                where region.REG_C_CODE == Region
                                orderby region.REG_S_NOM
                                select new
                                {
                                    Id = bouteille.BTL_I_ID,
                                    Château = chateau.CHT_S_CHATEAU,
                                    Millésime = bouteille.BTL_I_MILLESIME,
                                    Couleur = couleur.CLR_S_NOM,
                                    Flaconnage = flaconnage.FCG_S_NOM,
                                    cL = flaconnage.FCG_R_CONTENANCE,
                                    Appellation = appellation.APT_S_NOM,
                                    Région = region.REG_S_NOM
                                };
                return listquery.ToArray();
            }
        }

        static public Array listBouteillesFromAppellation(int Appellation)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from bouteille in db.T_BOUTEILLE_BTL
                                join chateau in db.T_CHATEAU_CHT on bouteille.CHT_I_ID equals chateau.CHT_I_ID
                                join appellation in db.T_APPELLATION_APT on chateau.APT_I_ID equals appellation.APT_I_ID
                                join region in db.T_REGION_REG on appellation.REG_C_CODE equals region.REG_C_CODE
                                join pays in db.T_PAYS_PAY on region.PAY_C_CODE equals pays.PAY_C_CODE
                                join couleur in db.T_COULEUR_CLR on bouteille.CLR_I_ID equals couleur.CLR_I_ID
                                join flaconnage in db.T_FLACONNAGE_FCG on bouteille.FCG_I_ID equals flaconnage.FCG_I_ID
                                where appellation.APT_I_ID == Appellation
                                orderby appellation.APT_S_NOM
                                select new
                                {
                                    Id = bouteille.BTL_I_ID,
                                    Château = chateau.CHT_S_CHATEAU,
                                    Millésime = bouteille.BTL_I_MILLESIME,
                                    Couleur = couleur.CLR_S_NOM,
                                    Flaconnage = flaconnage.FCG_S_NOM,
                                    cL = flaconnage.FCG_R_CONTENANCE,
                                    Appellation = appellation.APT_S_NOM,
                                    Région = region.REG_S_NOM
                                };
                return listquery.ToArray();
            }
        }

        static public Array listBouteillesFromMillesime(int Millesime)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from bouteille in db.T_BOUTEILLE_BTL
                                join chateau in db.T_CHATEAU_CHT on bouteille.CHT_I_ID equals chateau.CHT_I_ID
                                join appellation in db.T_APPELLATION_APT on chateau.APT_I_ID equals appellation.APT_I_ID
                                join region in db.T_REGION_REG on appellation.REG_C_CODE equals region.REG_C_CODE
                                join pays in db.T_PAYS_PAY on region.PAY_C_CODE equals pays.PAY_C_CODE
                                join couleur in db.T_COULEUR_CLR on bouteille.CLR_I_ID equals couleur.CLR_I_ID
                                join flaconnage in db.T_FLACONNAGE_FCG on bouteille.FCG_I_ID equals flaconnage.FCG_I_ID
                                where bouteille.BTL_I_MILLESIME == Millesime
                                orderby appellation.APT_S_NOM
                                select new
                                {
                                    Id = bouteille.BTL_I_ID,
                                    Château = chateau.CHT_S_CHATEAU,
                                    Millésime = bouteille.BTL_I_MILLESIME,
                                    Couleur = couleur.CLR_S_NOM,
                                    Flaconnage = flaconnage.FCG_S_NOM,
                                    cL = flaconnage.FCG_R_CONTENANCE,
                                    Appellation = appellation.APT_S_NOM,
                                    Région = region.REG_S_NOM
                                };
                return listquery.ToArray();
            }
        }


        static public Array listBouteillesFromChateau(String Chateau)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from bouteille in db.T_BOUTEILLE_BTL
                                join chateau in db.T_CHATEAU_CHT on bouteille.CHT_I_ID equals chateau.CHT_I_ID
                                join appellation in db.T_APPELLATION_APT on chateau.APT_I_ID equals appellation.APT_I_ID
                                join region in db.T_REGION_REG on appellation.REG_C_CODE equals region.REG_C_CODE
                                join pays in db.T_PAYS_PAY on region.PAY_C_CODE equals pays.PAY_C_CODE
                                join couleur in db.T_COULEUR_CLR on bouteille.CLR_I_ID equals couleur.CLR_I_ID
                                join flaconnage in db.T_FLACONNAGE_FCG on bouteille.FCG_I_ID equals flaconnage.FCG_I_ID
                                where chateau.CHT_S_CHATEAU.StartsWith(Chateau)
                                orderby chateau.CHT_S_CHATEAU
                                select new
                                {
                                    Id = bouteille.BTL_I_ID,
                                    Château = chateau.CHT_S_CHATEAU,
                                    Millésime = bouteille.BTL_I_MILLESIME,
                                    Couleur = couleur.CLR_S_NOM,
                                    Flaconnage = flaconnage.FCG_S_NOM,
                                    cL = flaconnage.FCG_R_CONTENANCE,
                                    Appellation = appellation.APT_S_NOM,
                                    Région = region.REG_S_NOM
                                };
                return listquery.ToArray();
            }
        }

        static public long NbBouteillesFromMillesime(int Millesime)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from bouteille in db.T_BOUTEILLE_BTL
                                where bouteille.BTL_I_MILLESIME == Millesime
                                select bouteille.BTL_I_ID;
                return listquery.Count();
            }
        }

         static public long NbBouteillesFromRegion(string Region)
         { 
             using (var db = new Entity.Cave_VinsEntities())
             {
                var listquery = from bouteille in db.T_BOUTEILLE_BTL
                                join chateau in db.T_CHATEAU_CHT on bouteille.CHT_I_ID equals chateau.CHT_I_ID
                                join appellation in db.T_APPELLATION_APT on chateau.APT_I_ID equals appellation.APT_I_ID
                                join region in db.T_REGION_REG on appellation.REG_C_CODE equals region.REG_C_CODE
                                where region.REG_C_CODE == Region
                                select bouteille.BTL_I_ID;
                return listquery.Count();
             }
         }

         static public long NbBouteillesFromAppellation(int Appellation)
         {
             using (var db = new Entity.Cave_VinsEntities())
             {
                 var listquery = from bouteille in db.T_BOUTEILLE_BTL
                                 join chateau in db.T_CHATEAU_CHT on bouteille.CHT_I_ID equals chateau.CHT_I_ID
                                 join appellation in db.T_APPELLATION_APT on chateau.APT_I_ID equals appellation.APT_I_ID
                                 where appellation.APT_I_ID == Appellation
                                 select bouteille.BTL_I_ID;
                 return listquery.Count();
             }
         }

         static public long NbBouteillesFromChateau(int Chateau)
         {
             using (var db = new Entity.Cave_VinsEntities())
             {
                 var listquery = from bouteille in db.T_BOUTEILLE_BTL
                                 join chateau in db.T_CHATEAU_CHT on bouteille.CHT_I_ID equals chateau.CHT_I_ID
                                 where chateau.CHT_I_ID == Chateau
                                 select bouteille.BTL_I_ID;
                 return listquery.Count();
             }
         }

         //Permet d'ajouter une bouteille dans gérer données
         static public void ajouterBouteille(int idFlaconnage, int idChateau, int idCouleur, int millesimebouteille, float prixBasBouteille, float prixHautBouteille)
         {
             using (var db = new Entity.Cave_VinsEntities())
             {
                 var bouteille = new Entity.T_BOUTEILLE_BTL
                 {
                     FCG_I_ID = idFlaconnage,
                     CHT_I_ID = idChateau,
                     CLR_I_ID = idCouleur,
                     BTL_I_MILLESIME = millesimebouteille,
                     BTL_R_PRIXBAS = prixBasBouteille,
                     BTL_R_PRIXHAUT = prixHautBouteille,
                 };
                 db.T_BOUTEILLE_BTL.Add(bouteille);
                 db.SaveChanges();
             }
         }

         //Permet de modifier une bouteille dans gérer données
         static public void ModifierBouteille(int idBouteille, int idFlaconnage, int idChateau, int idCouleur, int millesimebouteille, float prixBasBouteille, float prixHautBouteille)
         {
             using (var db = new Entity.Cave_VinsEntities())
             {
                 var bouteille = db.T_BOUTEILLE_BTL.First(i => i.BTL_I_ID == idBouteille);
                 bouteille.FCG_I_ID = idFlaconnage;
                 bouteille.CHT_I_ID = idChateau;
                 bouteille.CLR_I_ID = idCouleur;
                 bouteille.BTL_I_MILLESIME = millesimebouteille;
                 bouteille.BTL_R_PRIXBAS = prixBasBouteille;
                 bouteille.BTL_R_PRIXHAUT = prixHautBouteille;
                 db.SaveChanges();
             }
         }

         //Permet de supprimer une bouteille dans gérer données
         static public void SupprimerBouteille(int idBouteille)
         {
             using (var db = new Entity.Cave_VinsEntities())
             {
                 var line = db.T_BOUTEILLE_BTL.First(i => i.BTL_I_ID == idBouteille);
                 db.T_BOUTEILLE_BTL.Remove(line);
                 db.SaveChanges();
             }
         }
    }
}
