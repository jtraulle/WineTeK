using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Data
{
    public static class LieuModel
    {
        static public Array listLieux()
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from lieu in db.T_LIEU_LIE
                                select new
                                {
                                    Id = lieu.LIE_I_ID,
                                    Nom = lieu.LIE_S_NOM,
                                    Type = lieu.LIE_C_TYPE.Replace("M","Stockage de masse").Replace("U","Stockage unitaire"),
                                    X = lieu.LIE_I_NBHOR,
                                    Y = lieu.LIE_I_NBVERT,
                                    eX = lieu.LIE_I_NBHEMP,
                                    eY = lieu.LIE_I_NBVEMP,
                                    Capacité = lieu.LIE_I_CAPA
                                };
                return listquery.ToArray();
            }
        }

        static public Entity.T_LIEU_LIE[] listLieuxQuery()
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from lieu in db.T_LIEU_LIE
                                where lieu.LIE_C_TYPE == "M"
                                select lieu;
                return listquery.ToArray();
            }
        }

        static public Entity.T_LIEU_LIE[] listLieuxUQuery()
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from lieu in db.T_LIEU_LIE
                                where lieu.LIE_C_TYPE == "U"
                                select lieu;
                return listquery.ToArray();
            }
        }

        static public Entity.T_LIEU_LIE getLieu(int id)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from lieu in db.T_LIEU_LIE
                                where lieu.LIE_I_ID == id
                                select lieu;
                return listquery.First();
            }
        }

        static public Int64 addLieu(String titre, string type, int X, int Y, int eX, int eY, int Z)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var lieu = new Entity.T_LIEU_LIE
                {
                    LIE_S_NOM = titre,
                    LIE_I_NBHOR = X,
                    LIE_I_NBVERT = Y,
                    LIE_I_NBHEMP = eX,
                    LIE_I_NBVEMP = eY,
                    LIE_I_CAPA = Z,
                    LIE_C_TYPE = type
                };
                db.T_LIEU_LIE.Add(lieu);
                db.SaveChanges();
                return lieu.LIE_I_ID;
            }
        }

    }
}
