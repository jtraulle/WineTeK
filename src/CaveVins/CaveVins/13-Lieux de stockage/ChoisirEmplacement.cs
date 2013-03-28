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
    public partial class ChoisirEmplacement : Form
    {
        String title;
        int idlieu;
        int idBouteille;
        int X;
        int Y;
        int eX;
        int eY;
        int Z;
        int aStocker;
        public ChoisirEmplacement(int idl, int idb, int nbToStore)
        {
            InitializeComponent();
            idlieu = idl;

            Entity.T_LIEU_LIE lieu = Business.LieuxController.getLieu(idl);

            title = lieu.LIE_S_NOM;
            idBouteille = idb;
            X = lieu.LIE_I_NBHOR;
            Y = lieu.LIE_I_NBVERT;
            eX = lieu.LIE_I_NBHEMP;
            eY = lieu.LIE_I_NBVEMP;
            Z = lieu.LIE_I_CAPA;
            aStocker = nbToStore;
        }


        protected void Button_Click(object sender, EventArgs e)
        {
            string ctrlName2 = ((Control)sender).Name;

            string[] info_emplacement = ctrlName2.Split(new string[] { "_" }, StringSplitOptions.None);

           /* MessageBox.Show("X = "+info_emplacement.GetValue(1));
            MessageBox.Show("Y = "+info_emplacement.GetValue(2));*/

            Array emplacements = Business.StockageController.NbBouteillesInEmplacementsFromLieu(idlieu);

            bool trouve = false;

            if (emplacements.Length > 0)
            {
                foreach (Entity.NbBouteillesInEmplacementsFromLieu_Result emplacement in emplacements)
                {
                    if (emplacement.X.Value == int.Parse(info_emplacement.GetValue(1).ToString()) && emplacement.Y.Value == int.Parse(info_emplacement.GetValue(2).ToString()))
                    {
                        trouve = true;
                        if (emplacement.IdBtl == idBouteille)
                        {
                            if (emplacement.Dispo != 0)
                            {
                                using (var cbBouteilles = new Combien())
                                {
                                    cbBouteilles.Text = "Combien ?";
                                    cbBouteilles.ShowIcon = false;
                                    cbBouteilles.setLabel("Combien de bouteilles souhaitez vous\nstocker à cet emplacement ?");
                                    cbBouteilles.setMin(1);

                                    decimal max;
                                    if (aStocker < emplacement.Dispo)
                                        max = aStocker;
                                    else
                                        max = Convert.ToDecimal(emplacement.Dispo);

                                    cbBouteilles.setMax(max);
                                    cbBouteilles.Location = new System.Drawing.Point(this.MdiParent.Location.X + (this.MdiParent.Width - cbBouteilles.Width) / 2, this.MdiParent.Location.Y + (this.MdiParent.Height - cbBouteilles.Height) / 2);
                                    var res = cbBouteilles.ShowDialog();
                                    if (res == DialogResult.OK)
                                    {
                                        int nbBouteilles = int.Parse(cbBouteilles.ReturnValue1);

                                        Int64 id_emplacement = Business.EmplacementsController.getIdEmplacement(idlieu, int.Parse(info_emplacement.GetValue(1).ToString()), int.Parse(info_emplacement.GetValue(2).ToString()));
                                        Business.StockageController.majStockMass(Convert.ToInt32(id_emplacement), idBouteille, nbBouteilles);
                                        aStocker -= nbBouteilles;
                                        lblNbToStore.Text = (int.Parse(lblNbToStore.Text) - nbBouteilles).ToString();
                                        Boolean termine = Business.InventaireController.retirerBouteilleInventaire(idBouteille, nbBouteilles);
                                        reColorerBouteilles();
                                        MessageBox.Show("La référence a correctement été stockée.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        if (termine == true)
                                        {
                                            MessageBox.Show("Stockage de la référence terminé.\nRetour à l'inventaire.", "Terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Tools.ouvrirForm("InventaireListe", this.MdiParent);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Plus de place dispo dans cet emplacement :'(\nVeuillez choisir un autre emplacement.", "C'est complet !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Impossible de stocker cette référence dans cet emplacement\ncar la référence de bouteille(s) déjà stokées est différente !", "On est pas du même clan !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }

            if (trouve == false)
            {
                //MessageBox.Show("Emplacement complètement dispo, on peut stocker ici, " + Z + " bouteilles");

                using (var cbBouteilles = new Combien())
                {
                    cbBouteilles.Text = "Combien ?";
                    cbBouteilles.ShowIcon = false;
                    cbBouteilles.setLabel("Combien de bouteilles souhaitez vous\nstocker à cet emplacement ?");
                    cbBouteilles.setMin(1);

                    decimal max;
                    if (aStocker < Z)
                        max = aStocker;
                    else
                        max = Z;

                    cbBouteilles.setMax(max);
                    cbBouteilles.Location = new System.Drawing.Point(this.MdiParent.Location.X + (this.MdiParent.Width - cbBouteilles.Width) / 2, this.MdiParent.Location.Y + (this.MdiParent.Height - cbBouteilles.Height) / 2);
                    var res = cbBouteilles.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        int nbBouteilles = int.Parse(cbBouteilles.ReturnValue1);

                        Int64 id_emplacement = Business.EmplacementsController.getIdEmplacement(idlieu, int.Parse(info_emplacement.GetValue(1).ToString()), int.Parse(info_emplacement.GetValue(2).ToString()));
                        Business.StockageController.addStockMass(idBouteille, Convert.ToInt32(id_emplacement), nbBouteilles);
                        aStocker -= nbBouteilles;
                        lblNbToStore.Text = (int.Parse(lblNbToStore.Text) - nbBouteilles).ToString();
                        Boolean termine = Business.InventaireController.retirerBouteilleInventaire(idBouteille, nbBouteilles);
                        reColorerBouteilles();
                        MessageBox.Show("La référence a correctement été stockée.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (termine == true)
                        {
                            MessageBox.Show("Stockage de la référence terminé.\nRetour à l'inventaire.", "Terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Tools.ouvrirForm("InventaireListe", this.MdiParent);
                        }

                    }
                }
            }

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //Fonction permettant de retourner vrai si un nombre est paire, faux sinon
        private static bool isPaire(int val)
        {
            if (val % 2 == 0)
                return true;
            else
                return false;
        }

        private void colorerBouteilles(int nbBouteilles, int posX, int posY, String libelleBouteille, Color col)
        {
            int nbColores = 0;
            for (int i = 0; i <= eY - 1; i++)
            {
                int delta = 0;
                if (!isPaire(i))
                    delta += 1;
                
                for (int j = 0; j <= eX - delta - 1; j++)
                {
                    string namePanel = "btl_" + (posX) + "_" + (posY) + "_" + i + "_" + j;
                    if (nbColores != nbBouteilles)
                    {
                        tableLayoutPanel1.Controls.Find(namePanel, true)[0].BackColor = col;
                        System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                        ToolTip1.SetToolTip(tableLayoutPanel1.Controls.Find(namePanel, true)[0], libelleBouteille);
                        ToolTip1.ShowAlways = true;
                        nbColores += 1;
                    }
                }
            }
        }

        private void dessinerStock(String title, int X, int Y, int eX, int eY)
        {
            label2.BackColor = Color.Coral;
            label2.Visible = true;
            label2.Refresh();

            label4.Text = title;
            label4.Refresh();

            this.DoubleBuffered = true;
            tableLayoutPanel1.SuspendLayout();

            tableLayoutPanel1.Controls.Clear();

            tableLayoutPanel1.ColumnCount = X + 1;
            tableLayoutPanel1.RowCount = Y + 1;

            TableLayoutColumnStyleCollection stylescol = tableLayoutPanel1.ColumnStyles;
            foreach (ColumnStyle style in stylescol)
            {
                style.SizeType = SizeType.AutoSize;
            }

            TableLayoutRowStyleCollection styleslig = tableLayoutPanel1.RowStyles;
            foreach (RowStyle style in styleslig)
            {
                style.SizeType = SizeType.AutoSize;
            }


            for (int lig = 1; lig <= tableLayoutPanel1.RowCount - 1; lig++)
            {
                Label lab = new Label();
                lab.Text = (lig).ToString();
                lab.AutoSize = false;
                lab.Width = 20;
                lab.Dock = DockStyle.Fill;
                lab.TextAlign = ContentAlignment.MiddleCenter;
                tableLayoutPanel1.Controls.Add(lab, 0, tableLayoutPanel1.RowCount - lig);
            }

            TableLayoutPanel[,] panel = new TableLayoutPanel[tableLayoutPanel1.ColumnCount, tableLayoutPanel1.RowCount];
            for (int k = 1; k <= tableLayoutPanel1.ColumnCount - 1; k++)
            {
                for (int l = 1; l <= tableLayoutPanel1.RowCount - 1; l++)
                {
                    panel[k, l] = new TableLayoutPanel();
                    panel[k, l].AutoSize = true;
                    panel[k, l].ColumnCount = 1;
                    panel[k, l].RowCount = panel.Length;
                    panel[k, l].Name = "emplacement_" + k + "_" + l;
                    panel[k, l].Click += new System.EventHandler(this.Button_Click);

                    TableLayoutPanel[] lignes = new TableLayoutPanel[eY];
                    for (int i = 0; i <= lignes.Length - 1; i++)
                    {
                        lignes[i] = new TableLayoutPanel();
                        lignes[i].AutoSize = true;
                        if (!isPaire(i))
                        {
                            lignes[i].ColumnCount = eX - 1;
                            lignes[i].Margin = new Padding(17, 0, 0, 0);
                        }
                        else
                        {
                            lignes[i].ColumnCount = eX;
                        }
                        lignes[i].RowCount = 1;
                        lignes[i].Name = "ligne_" + k + "_" + l;
                        lignes[i].Click += new System.EventHandler(this.Button_Click);

                        panel[k, l].Controls.Add(lignes[i], 0, lignes.Length - i);

                        Panel[] bouteilles = new Panel[lignes[i].ColumnCount];

                        for (int j = 0; j <= lignes[i].ColumnCount - 1; j++)
                        {
                            bouteilles[j] = new Panel();
                            bouteilles[j].Width = 23;
                            bouteilles[j].Height = 13;
                            bouteilles[j].BackColor = Color.LightGray;
                            bouteilles[j].Click += new System.EventHandler(this.Button_Click);
                            bouteilles[j].Name = "btl_" + k + "_" + l + "_" + i + "_" + j;

                            lignes[i].Controls.Add(bouteilles[j], j, 0);
                        }
                    }
                    tableLayoutPanel1.Controls.Add(panel[k, l], k, tableLayoutPanel1.RowCount - l);
                }
            }


            for (int col = 1; col <= tableLayoutPanel1.ColumnCount - 1; col++)
            {
                Label lab = new Label();
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                lab.Text = alpha[col - 1].ToString();
                lab.AutoSize = false;
                lab.Width = 5;
                lab.Height = 20;
                lab.Dock = DockStyle.Fill;
                lab.TextAlign = ContentAlignment.MiddleCenter;
                tableLayoutPanel1.Controls.Add(lab, col, tableLayoutPanel1.RowCount);
            }

            label2.Visible = false;

            tableLayoutPanel1.ResumeLayout();
        }

        private void GererDonnees_Shown(object sender, EventArgs e)
        {
            this.Refresh();
            Cursor.Current = Cursors.WaitCursor;
            dessinerStock(title, X, Y, eX, eY);
            reColorerBouteilles();
            
        }

        private void reColorerBouteilles()
        {
            Array emplacements = Business.StockageController.NbBouteillesInEmplacementsFromLieu(idlieu);

            if (emplacements.Length > 0)
            {
                foreach (Entity.NbBouteillesInEmplacementsFromLieu_Result emplacement in emplacements)
                {
                    if (Convert.ToInt32(emplacement.IdBtl) == idBouteille)
                        colorerBouteilles(emplacement.Qte.Value, emplacement.X.Value, emplacement.Y.Value, emplacement.Cha + ", " + emplacement.Mil, Color.DarkSeaGreen);
                    else
                        colorerBouteilles(emplacement.Qte.Value, emplacement.X.Value, emplacement.Y.Value, emplacement.Cha + ", " + emplacement.Mil, Color.IndianRed);
                }
            }
        }

        private void AfficherLieu_Load(object sender, EventArgs e)
        {
            lblNbToStore.Text = aStocker.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tools.ouvrirForm("ListerLieux", this.MdiParent);
        }
    }
}
