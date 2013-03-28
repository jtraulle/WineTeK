using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

namespace CaveVins.Data
{
    public class StockageModel
    {

        static public Array NbBouteillesInEmplacementsFromLieu(int idLieu)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                return db.NbBouteillesInEmplacementsFromLieu(idLieu).ToArray();
            }
        }

        static public void addStockMass(int btlId, int empId, int qte)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var stock = new Entity.T_STOMAS_STM
                {
                    BTL_I_ID = btlId,
                    EMP_I_ID = empId,
                    STO_I_QTE = qte
                };
                db.T_STOCKAGE_STO.Add(stock);
                db.SaveChanges();
            }
        }


        static public void addStockUni(int btlId, int empId, int place)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var stock = new Entity.T_STOUNI_STU
                {
                    BTL_I_ID = btlId,
                    EMP_I_ID = empId,
                    STO_I_QTE = 1,
                    STO_I_PLACE = place
                };
                db.T_STOCKAGE_STO.Add(stock);
                db.SaveChanges();
            }
        }


        static public void majStockMass(int empId, int btlId, int nbBouteilles)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var req = from stock in db.T_STOCKAGE_STO.OfType<Entity.T_STOMAS_STM>()
                          where stock.EMP_I_ID == empId &&
                                stock.BTL_I_ID == btlId
                          select stock;
                int qteActuelle = req.First().STO_I_QTE;
                req.First().STO_I_QTE = qteActuelle  + nbBouteilles;
                db.SaveChanges();
            }
        }

        static public void majStockMassNeg(int empId, int btlId, int nbBouteilles)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var req = from stock in db.T_STOCKAGE_STO.OfType<Entity.T_STOMAS_STM>()
                          where stock.EMP_I_ID == empId &&
                                stock.BTL_I_ID == btlId
                          select stock;
                int qteActuelle = req.First().STO_I_QTE;
                req.First().STO_I_QTE = qteActuelle - nbBouteilles;
                db.SaveChanges();
            }
        }

        static public void supprimerStoMas(int empId, int btlId)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var req = from stock in db.T_STOCKAGE_STO.OfType<Entity.T_STOMAS_STM>()
                          where stock.EMP_I_ID == empId &&
                                stock.BTL_I_ID == btlId
                          select stock;
                db.T_STOCKAGE_STO.Remove(req.First());
                db.SaveChanges();
            }
        }

        static public void supprimerStoUni(int empId, int place)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var req = from stock in db.T_STOCKAGE_STO.OfType<Entity.T_STOUNI_STU>()
                          where stock.EMP_I_ID == empId &&
                                stock.STO_I_PLACE == place
                          select stock;
                db.T_STOCKAGE_STO.Remove(req.First());
                db.SaveChanges();
            }
        }

        //Retourne la liste des identifiants des emplacements occupés pour un lieu unitaire donné
        static public List<Entity.T_EMPLACEMENT_EMP> idEmplacementsFromLieuStoU(int lieuId)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                return (from stock in db.T_STOCKAGE_STO.OfType<Entity.T_STOUNI_STU>()
                           where stock.T_EMPLACEMENT_EMP.LIE_I_ID == lieuId
                           select stock.T_EMPLACEMENT_EMP).Distinct().ToList();
            }
        }


        //Retourne la liste des bouteilles d'un emplacement
        static public List<Entity.T_STOUNI_STU> listBtlEmplacementStoU(int emplId)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                return (from stock in db.T_STOCKAGE_STO.Include("T_BOUTEILLE_BTL.T_CHATEAU_CHT").Include("T_BOUTEILLE_BTL.T_FLACONNAGE_FCG").OfType<Entity.T_STOUNI_STU>()
                        where stock.T_EMPLACEMENT_EMP.EMP_I_ID == emplId
                        select stock).ToList();
                
            }
        }

        static public int getQte(int empId, int btlId)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var req = from stock in db.T_STOCKAGE_STO.OfType<Entity.T_STOMAS_STM>()
                          where stock.EMP_I_ID == empId &&
                                stock.BTL_I_ID == btlId
                          select stock;
                
                return req.First().STO_I_QTE;
            }
        }

        static public Int64 getIdBtlStoMass(int empId)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var req = from stock in db.T_STOCKAGE_STO.OfType<Entity.T_STOMAS_STM>()
                          where stock.EMP_I_ID == empId
                          select stock;
                return req.First().BTL_I_ID;
            }
        }

        static public int? NbEmplacementsOQPSaufIdBtl(int idLieu, int idBouteille)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                return db.NbEmplacementsOQPSaufIdBtl(idLieu, idBouteille).First();
            }
        }

        static public int? NbBouteillesInLieuByIdBtl(int idLieu, int idBouteille)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                return db.NbBouteillesInLieuByIdBtl(idLieu, idBouteille).First();
            }
        }

        //Retourne le nombre de bouteilles en stock pour un millésime
        static public long NbBouteillesFromMillesimeStock(int Millesime)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from stock in db.T_STOCKAGE_STO
                                join bouteille in db.T_BOUTEILLE_BTL on stock.BTL_I_ID equals bouteille.BTL_I_ID
                                where bouteille.BTL_I_MILLESIME == Millesime
                                select stock.STO_I_QTE;

                if (listquery.Count() == 0)
                    return 0;
                else
                    return listquery.Sum();
            }
        }

        //Retourne le nombre de bouteilles en stock pour une appellation
        static public long NbBouteillesFromAppellationStock(int Appellation)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from stock in db.T_STOCKAGE_STO
                                join bouteille in db.T_BOUTEILLE_BTL on stock.BTL_I_ID equals bouteille.BTL_I_ID
                                join chateau in db.T_CHATEAU_CHT on bouteille.CHT_I_ID equals chateau.CHT_I_ID
                                join appellation in db.T_APPELLATION_APT on chateau.APT_I_ID equals appellation.APT_I_ID
                                where appellation.APT_I_ID == Appellation
                                select stock.STO_I_QTE;
                if (listquery.Count() == 0)
                    return 0;
                else
                    return listquery.Sum();
            }
        }

        //Retourne le nombre de bouteilles en stock pour une region
        static public long NbBouteillesFromRegionStock(String Region)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from stock in db.T_STOCKAGE_STO
                                join bouteille in db.T_BOUTEILLE_BTL on stock.BTL_I_ID equals bouteille.BTL_I_ID
                                join chateau in db.T_CHATEAU_CHT on bouteille.CHT_I_ID equals chateau.CHT_I_ID
                                join appellation in db.T_APPELLATION_APT on chateau.APT_I_ID equals appellation.APT_I_ID
                                join region in db.T_REGION_REG on appellation.REG_C_CODE equals region.REG_C_CODE
                                where region.REG_C_CODE == Region
                                select stock.STO_I_QTE;
                if (listquery.Count() == 0)
                    return 0;
                else
                    return listquery.Sum();
            }
        }

        //Retourne le nombre de bouteilles en stock pour un chateau
        static public long NbBouteillesFromChateauStock(int Chateau)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from stock in db.T_STOCKAGE_STO
                                join bouteille in db.T_BOUTEILLE_BTL on stock.BTL_I_ID equals bouteille.BTL_I_ID
                                join chateau in db.T_CHATEAU_CHT on bouteille.CHT_I_ID equals chateau.CHT_I_ID
                                where chateau.CHT_I_ID == Chateau
                                select stock.STO_I_QTE;
                if (listquery.Count() == 0)
                    return 0;
                else
                    return listquery.Sum();
            }
        }
    }
}
