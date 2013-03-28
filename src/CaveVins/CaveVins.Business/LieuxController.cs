using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Business
{
    public class LieuxController
    {
        static public void addLieu(String titre, string type, int X, int Y, int eX, int eY, int Z)
        {
            Int64 idlieu = Data.LieuModel.addLieu(titre, type, X, Y, eX, eY, Z);

            for (int i = 1; i <= Y; i++)
            {
                for (int j = 1; j <= X; j++)
                {
                    Data.EmplacementModel.addEmplacement(idlieu, j, i);
                }
            }
        }
        
        static public Array listLieux()
        {
            return Data.LieuModel.listLieux();
        }


        static public Entity.T_LIEU_LIE[] listLieuxQuery()
        {
            return Data.LieuModel.listLieuxQuery();
        }

        static public Entity.T_LIEU_LIE[] listLieuxUQuery()
        {
            return Data.LieuModel.listLieuxUQuery();
        }

        static public Entity.T_LIEU_LIE getLieu(int id)
        {
            return Data.LieuModel.getLieu(id);
        }
    }
}
