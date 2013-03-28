using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Data
{
    public static class EmplacementModel
    {
        static public void addEmplacement(Int64 lid, int X, int Y)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var emplacement = new Entity.T_EMPLACEMENT_EMP
                {
                    EMP_I_POSH = X,
                    EMP_I_POSV = Y,
                    LIE_I_ID = lid,
                };
                db.T_EMPLACEMENT_EMP.Add(emplacement);
                db.SaveChanges();
            }
        }


        static public Int64 getIdEmplacement(int idLieu, int X, int Y)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from emplacement in db.T_EMPLACEMENT_EMP
                                where   emplacement.LIE_I_ID == idLieu &&
                                        emplacement.EMP_I_POSH == X &&
                                        emplacement.EMP_I_POSV == Y
                                select emplacement;
                return listquery.First().EMP_I_ID;
            }
        }
    }
}
