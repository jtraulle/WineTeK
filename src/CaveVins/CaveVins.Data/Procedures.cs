using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Reflection;
using System.IO;
using System.Resources;
using System.Collections;

namespace CaveVins.Data
{
    public static class Procedures
    {

        public static Boolean canConnect()
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                if(db.Database.Exists())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static String getSqlScript(String name)
        {
            switch (name)
            {
                case "CreerBase":
                    return Properties.Resources.CreerBase.ToString();
                case "SupprimerBase":
                    return Properties.Resources.SupprimerBase.ToString();
                case "SampleData":
                    return Properties.Resources.SampleData.ToString();
                case "T_INVENTAIRE_INV":
                    return Properties.Resources.T_INVENTAIRE_INV.ToString();
                case "T_LIEU_LIE":
                    return Properties.Resources.T_LIEU_LIE.ToString();
                case "T_EMPLACEMENT_EMP":
                    return Properties.Resources.T_EMPLACEMENT_EMP.ToString();
                case "T_STOCKAGE_STO":
                    return Properties.Resources.T_STOCKAGE_STO.ToString();
                case "proceduresStockees":
                    return Properties.Resources.proceduresStockees.ToString();
                default:
                    return "Not found!";
            }
        }

        public static void effectuerCopieSauvegarde(String tempfile)
        {
            //Connect to DB
            SqlConnection connect;
            string con = "Server=localhost\\SQLEXPRESS;Integrated security=SSPI;database=Cave_Vins";
            connect = new SqlConnection(con);
            connect.Open();
            //----------------------------------------------------------------------------------------------------

            //Execute SQL---------------
            SqlCommand command;
            command = new SqlCommand(@"backup database Cave_Vins to disk ='" + tempfile + "' with init,stats=10", connect);
            command.ExecuteNonQuery();
            //-------------------------------------------------------------------------------------------------------------------------------

            connect.Close();
        }

        public static void restaurerCopieSauvegarde(String tempfile)
        {
            //Connect SQL-----------
            SqlConnection connect;
            string con = "Server=localhost\\SQLEXPRESS;Integrated security=SSPI;database=master";
            connect = new SqlConnection(con);
            connect.Open();
            //-----------------------------------------------------------------------------------------

            //Excute SQL----------------
            SqlCommand command;
            command = new SqlCommand("use master", connect);
            command.ExecuteNonQuery();
            command = new SqlCommand("RESTORE DATABASE [Cave_Vins] FILE = N'Cave_Vins' FROM  DISK = N'"+tempfile+"' WITH  FILE = 1,  NOUNLOAD", connect);
            command.ExecuteNonQuery();
            //--------------------------------------------------------------------------------------------------------
            connect.Close();
        }
    }
}
