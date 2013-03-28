using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CaveVins
{
    public static class Tools
    {
        public static void ouvrirForm(String nomForm, Form parentForm, Boolean isPrimary = false)
        {

            if (isPrimary != true)
                parentForm.MdiChildren[0].Close();

            if (nomForm != "WelcomeScreen" && Business.Tools.canConnect() == false)
            {
                MessageBox.Show(parentForm, "L'application n'a pas réussi à se connecter à la base de données. \n\nAssurez vous d'avoir correctement créé l'instance SQL Server localhost\\SQLEXPRESS et la base de donnée Cave_Vins associée. \n\n", "Ooops, nous avons un problème -_-'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var type = Type.GetType("CaveVins."+nomForm);
                Form newMDIChild = (Form)Activator.CreateInstance(type);
                // Set the Parent Form of the Child window.
                newMDIChild.MdiParent = parentForm;
                // Display the new form.
                newMDIChild.StartPosition = FormStartPosition.Manual;
                newMDIChild.SuspendLayout();
                newMDIChild.Location = new System.Drawing.Point(0, 0);
                newMDIChild.ResumeLayout();
                newMDIChild.Show();
            }

        }
    }
}
