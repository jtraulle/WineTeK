using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Management;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.IO;

namespace CaveVins.Business
{
    public static class Tools
    {
        public static void effectuerCopieSauvegarde(String filename, String folderPath)
        {
            String tempath = @"C:\Sauvegardes_WinTeK";
            String tempfile = tempath + @"\" + filename;
            String destfile = folderPath + @"\" + filename;

            if (!Directory.Exists(tempath))
                Directory.CreateDirectory(tempath);

            Data.Procedures.effectuerCopieSauvegarde(tempfile);

            File.Copy(tempfile, destfile);
            File.Delete(tempfile);
            Directory.Delete(tempath);
        }

        public static void restaurerCopieSauvegarde(String sourceFile)
        {
            String tempath = @"C:\Sauvegardes_WinTeK";
            String filename = Path.GetFileName(sourceFile);
            String tempfile = tempath + @"\" + filename;

            if (!Directory.Exists(tempath))
                Directory.CreateDirectory(tempath);

            File.Copy(sourceFile, tempfile);

            if (Business.Tools.canConnect())
            {
                Business.Tools.executeQueryMaster(Business.Tools.getSqlScript("SupprimerBase"));
            }

            Data.Procedures.restaurerCopieSauvegarde(tempfile);

            File.Delete(tempfile);
            Directory.Delete(tempath);
        }
        
        public static Boolean canConnect()
        {
            return Data.Procedures.canConnect();
        }

        public static String getSqlScript(String nom)
        {
            return Data.Procedures.getSqlScript(nom);
        }

        public static void executeQueryMaster(String req)
        {
            SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Integrated security=SSPI;database=master");
            Server server = new Server(new ServerConnection(connection));
            server.ConnectionContext.ExecuteNonQuery(req);
        }

        public static void executeQueryCaveVins(String req)
        {
            SqlConnection connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Integrated security=SSPI;database=Cave_Vins");
            Server server = new Server(new ServerConnection(connection));
            server.ConnectionContext.ExecuteNonQuery(req);
        }
    }
}
