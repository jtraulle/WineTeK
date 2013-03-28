using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaveVins.Data
{
    public static class CouleurModel
    {
        static public List<Entity.T_COULEUR_CLR> listCouleurs()
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from c in db.T_COULEUR_CLR
                                orderby c.CLR_S_NOM
                                select c;
                return listquery.ToList();
            }
        }

        static public Array listCouleursFull()
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var listquery = from c in db.T_COULEUR_CLR
                                orderby c.CLR_S_NOM
                                select new
                                {
                                    Identifiant = c.CLR_I_ID,
                                    Intitulé = c.CLR_S_NOM
                                };
                return listquery.ToArray();
            }
        }
        
        //Permet d'ajouter une couleur dans gérer données
        static public void AjouterCouleur(string nomCouleur)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var couleur = new Entity.T_COULEUR_CLR
                {
                    CLR_S_NOM = nomCouleur
                };
                db.T_COULEUR_CLR.Add(couleur);
                db.SaveChanges();
            }
        }

        //Permet de modifier une couleur dans gérer données
        static public void ModifierCouleur(int idCouleur, string nomCouleur)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var couleur = db.T_COULEUR_CLR.First(i => i.CLR_I_ID == idCouleur);
                couleur.CLR_S_NOM = nomCouleur;
                db.SaveChanges();
            }
        }

        //Permet de supprimer une couleur dans gérer données
        static public void SupprimerCouleur(int idCouleur)
        {
            using (var db = new Entity.Cave_VinsEntities())
            {
                var line = db.T_COULEUR_CLR.First(i => i.CLR_I_ID == idCouleur);
                db.T_COULEUR_CLR.Remove(line);
                db.SaveChanges();
            }
        }
    }
}
