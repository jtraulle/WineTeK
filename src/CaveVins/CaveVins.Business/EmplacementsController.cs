using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Business
{
    public static class EmplacementsController
    {
        static public Int64 getIdEmplacement(int idLieu, int X, int Y)
        {
            return Data.EmplacementModel.getIdEmplacement(idLieu, X, Y);
        }
    }
}
