using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CaveVins
{
    public partial class BackgroundOperation : Form
    {
        string[] arg;
        string meth;
        string message;

        public BackgroundOperation(String methode, string[] args = null)
        {
            InitializeComponent();
            meth = methode;
            arg = args;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (backgroundWorker1.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    switch (meth)
                    {
                        case "CreerBase":
                            Business.Tools.executeQueryMaster(Business.Tools.getSqlScript("CreerBase"));
                            Business.Tools.executeQueryCaveVins(Business.Tools.getSqlScript("T_INVENTAIRE_INV"));
                            Business.Tools.executeQueryCaveVins(Business.Tools.getSqlScript("T_LIEU_LIE"));
                            Business.Tools.executeQueryCaveVins(Business.Tools.getSqlScript("T_EMPLACEMENT_EMP"));
                            Business.Tools.executeQueryCaveVins(Business.Tools.getSqlScript("T_STOCKAGE_STO"));
                            Business.Tools.executeQueryCaveVins(Business.Tools.getSqlScript("proceduresStockees"));
                            break;
                        case "SupprimerBase":
                            Business.Tools.executeQueryMaster(Business.Tools.getSqlScript("SupprimerBase"));
                            break;
                        case "LoadSampleData":
                            Business.Tools.executeQueryCaveVins(Business.Tools.getSqlScript("SampleData"));
                            break;
                        case "EffectuerCopieSauvegarde":
                            Business.Tools.effectuerCopieSauvegarde(arg[0], arg[1]);
                            break;
                        case "RestaurerCopieSauvegarde":
                            Business.Tools.restaurerCopieSauvegarde(arg[0]);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception exp)
                {
                    message = exp.Message;
                }
            }      
        }

        private void CreationBase_Load(object sender, EventArgs e)
        {
            switch (meth)
            {
                case "CreerBase":
                    this.Text = "Création de la base de données ...";
                    lblInfo.Text = "La base de données est en cours de création.";
                    break;
                case "SupprimerBase":
                    this.Text = "Suppression de la base de données ...";
                    lblInfo.Text = "La base de données est en cours de suppression.";
                    break;
                case "LoadSampleData":
                    this.Text = "Chargement des données d'exemple ...";
                    lblInfo.Text = "Les données d'exemple sont en cours de chargement.";
                    break;
                case "EffectuerCopieSauvegarde":
                    this.Text = "Copie de sauvegarde ...";
                    lblInfo.Text = "La copie de sauvegarde est en cours de création.";
                    break;
                case "RestaurerCopieSauvegarde":
                    this.Text = "Restauration ...";
                    lblInfo.Text = "La copie de sauvegarde est en cours de restauration.";
                    break;
            }
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = 0;
            this.Height = 0;
            
            if (message != null)
            {
                MessageBox.Show(message);
            }
            else
            {
                switch (meth)
                {
                    case "EffectuerCopieSauvegarde":
                        MessageBox.Show("La copie de sauvegarde a été effectuée avec succès.", "Copie de sauvegarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "RestaurerCopieSauvegarde":
                        MessageBox.Show("La copie de sauvegarde a été restaurée avec succès.", "Restauration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }

            this.Close();
        }
    }
}
