using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Business
{
    public static class StockageController
    {
        static public Array NbBouteillesInEmplacementsFromLieu(int idLieu)
        {
            return Data.StockageModel.NbBouteillesInEmplacementsFromLieu(idLieu);
        }

        static public int? NbEmplacementsOQPSaufIdBtl(int idLieu, int idBouteille)
        {
            return Data.StockageModel.NbEmplacementsOQPSaufIdBtl(idLieu, idBouteille);
        }

        static public int? NbBouteillesInLieuByIdBtl(int idLieu, int idBouteille)
        {
            return Data.StockageModel.NbBouteillesInLieuByIdBtl(idLieu, idBouteille);
        }

        static public void addStockMass(int btlId, int empId, int qte)
        {
            Data.StockageModel.addStockMass(btlId, empId, qte);
        }

        static public void addStockUni(int btlId, int empId, int place)
        {
            Data.StockageModel.addStockUni(btlId, empId, place);
        }

        static public void majStockMass(int empId, int btlId, int nbBouteilles)
        {
            Data.StockageModel.majStockMass(empId, btlId, nbBouteilles);
        }

        static public Int64 getIdBtlStoMass(int empId)
        {
            return Data.StockageModel.getIdBtlStoMass(empId);
        }

        static public void majStockMassNeg(int empId, int btlId, int nbBouteilles)
        {
            Data.StockageModel.majStockMassNeg(empId, btlId, nbBouteilles);

            if (Data.StockageModel.getQte(empId, btlId) == 0)
                Data.StockageModel.supprimerStoMas(empId, btlId);
        }

        static public void supprimerStoUni(int empId, int place)
        {
            Data.StockageModel.supprimerStoUni(empId, place);
        }

        //Retourne la liste des identifiants des emplacements occupés pour un lieu unitaire donné
        static public List<Entity.T_EMPLACEMENT_EMP> idEmplacementsFromLieuStoU(int lieuId)
        {
            return Data.StockageModel.idEmplacementsFromLieuStoU(lieuId);
        }

        //Retourne la liste des bouteilles d'un emplacement
        static public List<Entity.T_STOUNI_STU> listBtlEmplacementStoU(int emplId)
        {
            return Data.StockageModel.listBtlEmplacementStoU(emplId);
        }

        //Retourne le nombre de bouteilles en stock pour un millesime
        static public long NbBouteillesFromMillesimeStock(int Millesime)
        {
            return Data.StockageModel.NbBouteillesFromMillesimeStock(Millesime);
        }

        //Retourne le nombre de bouteilles en stock pour une appellation
        static public long NbBouteillesFromAppellationStock(int Appellation)
        {
            return Data.StockageModel.NbBouteillesFromAppellationStock(Appellation);
        }

        //Retourne le nombre de bouteilles en stock pour une region
        static public long NbBouteillesFromRegionStock(String Region)
        {
            return Data.StockageModel.NbBouteillesFromRegionStock(Region);
        }

        //Retourne le nombre de bouteilles en stock pour un chateau
        static public long NbBouteillesFromChateauStock(int Chateau)
        {
            return Data.StockageModel.NbBouteillesFromChateauStock(Chateau);
        }
    }
}
