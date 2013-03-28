using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CaveVins
{
    public partial class Form1 : Form
    {
        //Il s'agit du formulaire principal de l'application.
        //
        //C'est le formulaire MDI parent dans lequel est affichée la barre de menu.
        //L'ensemble des formulaires enfants sont affichés dans ce formulaire
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tools.ouvrirForm("WelcomeScreen", this, true);
        }

        private void voirLesBouteillesDansLinventaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tools.ouvrirForm("InventaireListe", this);
        }

        private void chercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tools.ouvrirForm("RechercheBase", this);
        }

        private void gererToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tools.ouvrirForm("GererDonnees", this);
        }

        private void ajouterUnLieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tools.ouvrirForm("AjouterLieu", this);
        }

        /* Menu permettant de lancer les dialogues de statistiques */

        private void nbDeBouteillesDuneAnnéeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var getMil = new StatsGetMillesime())
            {
                //Cette définition de la position de la boîte de dialogue est utilisée à plusieurs endroits et permet de
                //centrer la nouvelle fenêtre affichée au centre de la fenêtre du conteneur MDI Parent.
                getMil.Location = new System.Drawing.Point(this.Location.X + (this.Width - getMil.Width) / 2, this.Location.Y + (this.Height - getMil.Height) / 2);
                var res = getMil.ShowDialog();
                if (res == DialogResult.OK)
                {
                    int millesime = int.Parse(getMil.ReturnValue1);

                    MessageBox.Show("Nombre de bouteilles pour l'année "+millesime+" :\n\n" +
                                    "- Dans la base de référence : " + Business.BouteillesController.NbBouteillesFromMillesime(millesime).ToString() + "\n" +
                                    "- Dans votre inventaire : " + Business.InventaireController.NbBouteillesFromMillesimeInventaire(millesime).ToString() + "\n" +
                                    "- Dans votre stock : " + Business.StockageController.NbBouteillesFromMillesimeStock(millesime).ToString());
                }
            }
        }

        private void nbDeBouteillesDuneRégionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var getRegion = new StatsGetRegion())
            {
                getRegion.Location = new System.Drawing.Point(this.Location.X + (this.Width - getRegion.Width) / 2, this.Location.Y + (this.Height - getRegion.Height) / 2);
                var res = getRegion.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string regionid = getRegion.ReturnValue1;
                    string region = getRegion.ReturnValue2;

                    MessageBox.Show("Nombre de bouteilles pour la région " + region + " :\n\n" +
                            "- Dans la base de référence : " + Business.BouteillesController.NbBouteillesFromRegion(regionid).ToString() + "\n" +
                            "- Dans votre inventaire : " + Business.InventaireController.NbBouteillesFromRegionInventaire(regionid).ToString() + "\n" +
                            "- Dans votre stock : " + Business.StockageController.NbBouteillesFromRegionStock(regionid).ToString());
                }
            }
        }

        private void nbDeBouteillesDuneAppellationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var getAppellation = new StatsGetAppellation())
            {
                getAppellation.Location = new System.Drawing.Point(this.Location.X + (this.Width - getAppellation.Width) / 2, this.Location.Y + (this.Height - getAppellation.Height) / 2);
                var res = getAppellation.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string appellation = getAppellation.ReturnValue2;
                    int appellationid = getAppellation.ReturnValue1;

                    MessageBox.Show("Nombre de bouteilles pour l'appellation " + appellation + " :\n\n" +
                            "- Dans la base de référence : " + Business.BouteillesController.NbBouteillesFromAppellation(appellationid).ToString() + "\n" +
                            "- Dans votre inventaire : " + Business.InventaireController.NbBouteillesFromAppellationInventaire(appellationid).ToString() + "\n" +
                            "- Dans votre stock : " + Business.StockageController.NbBouteillesFromAppellationStock(appellationid).ToString());
                }
            }

        }

        private void nbDeBouteillesDunChâteauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var getChateau = new StatsGetChateau())
            {
                getChateau.Location = new System.Drawing.Point(this.Location.X + (this.Width - getChateau.Width) / 2, this.Location.Y + (this.Height - getChateau.Height) / 2);
                var res = getChateau.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string chateau = getChateau.ReturnValue2;
                    int chateauid = getChateau.ReturnValue1;

                    MessageBox.Show("Nombre de bouteilles pour le chateau " + chateau + " :\n\n" +
                                    "- Dans la base de référence : " + Business.BouteillesController.NbBouteillesFromChateau(chateauid).ToString() + "\n" +
                                    "- Dans votre inventaire : " + Business.InventaireController.NbBouteillesFromChateauInventaire(chateauid).ToString() + "\n" +
                                    "- Dans votre stock : " + Business.StockageController.NbBouteillesFromChateauStock(chateauid).ToString());
                }
            }
        }

        //Affichage du statut de connexion à la base de données dans la barre d'état.
        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Business.Tools.canConnect())
            {
                statusBar1.Panels.Add("Connexion BDD établie");
                statusBar1.Panels[0].Icon = CaveVins.Properties.Resources.db;
                statusBar1.Panels[0].AutoSize = StatusBarPanelAutoSize.Contents;
            }
            else
            {
                DialogResult result = MessageBox.Show("La base de donnée n'existe pas, voulez vous la créer ?", "Créer la base de données ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BackgroundOperation f = new BackgroundOperation("CreerBase");
                    f.ShowDialog();
                    DialogResult result2 = MessageBox.Show("Voulez vous charger les données d'exemple ?", "Charger données d'exemple ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result2 == DialogResult.Yes)
                    {
                        BackgroundOperation f3 = new BackgroundOperation("LoadSampleData");
                        f3.ShowDialog();
                    }
                    statusBar1.Panels.Add("Connexion BDD établie");
                    statusBar1.Panels[0].Icon = CaveVins.Properties.Resources.db;
                    statusBar1.Panels[0].AutoSize = StatusBarPanelAutoSize.Contents;
                }
                else
                {
                    statusBar1.Panels.Add("Connexion BDD en erreur");
                    statusBar1.Panels[0].Icon = CaveVins.Properties.Resources.disconnect2;
                    statusBar1.Panels[0].AutoSize = StatusBarPanelAutoSize.Contents;
                }


            }
            statusBar1.ShowPanels = true;
        }

        //Fonction permettant de réaliser une copie de sauvegarde
        private void exporterUneSauvegardeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String filename = @"sauvegarde_winetek_" + DateTime.Now.ToString("yyyy_M_d_h_mm_ss") + ".wtk";

            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.Description = "Choisissez le dossier dans lequel vous souhaitez enregistrer la copie de sauvegarde.";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog1.SelectedPath;

                string[] args;
                args = new string[2] { filename, folderPath };

                BackgroundOperation f = new BackgroundOperation("EffectuerCopieSauvegarde", args);
                f.ShowDialog();
            }
        }

        //Fonction permettant de restaurer une sauvegarde
        private void importerUneSauvegardeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.Filter = "WineTeK database backup file (*.wtk)|*.wtk";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string sourceFile = openFileDialog1.FileName;
                    string filename = Path.GetFileName(sourceFile);

                    if (File.Exists(sourceFile))
                    {
                        if (MessageBox.Show("Êtes vous sûr(e) de vouloir restaurer cette copie de sauvegarde ?\n\nLa restauration supprime complètement la structure et les données de la base actuelle et les remplacent par celles de la copie de sauvegarde.\n\nSi vous souhaitez conserver la base actuelle, effectuez une copie de sauvegarde d'abord (Outils > Effectuer une copie de sauvegarde).", "Attention aux dragons !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Tools.ouvrirForm("WelcomeScreen", this);
                            Cursor.Current = Cursors.WaitCursor;

                            string[] args;
                            args = new string[1] { sourceFile };

                            BackgroundOperation f = new BackgroundOperation("RestaurerCopieSauvegarde", args);
                            f.ShowDialog();
                        }
                    }                  
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        //Fonction permettant de réinitialiser la base de données
        private void réinitialiserLaBaseDeDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes vous sûr(e) de vouloir réinitialiser la base de données ?\n\nLa réinitialisation ne peut pas être annulée. Elle supprime complètement la structure et les données de la base de données et crée une nouvelle base vierge.\n\nSi vous souhaitez conserver les données, effectuez une copie de sauvegarde d'abord (Outils > Effectuer une copie de sauvegarde).", "Attention aux dragons !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Tools.ouvrirForm("WelcomeScreen", this);
                Cursor.Current = Cursors.WaitCursor;
                
                BackgroundOperation f = new BackgroundOperation("SupprimerBase");
                f.ShowDialog();

                BackgroundOperation f2 = new BackgroundOperation("CreerBase");
                f2.ShowDialog();

                DialogResult result = MessageBox.Show("Voulez vous charger les données d'exemple ?", "Charger données d'exemple ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BackgroundOperation f3 = new BackgroundOperation("LoadSampleData");
                    f3.ShowDialog();
                }
            }
        }

        private void listerLesLieuxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tools.ouvrirForm("ListerLieux", this);
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
