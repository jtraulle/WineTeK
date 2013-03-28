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
    public partial class AfficherLieu : Form
    {
        String title;
        int idlieu;
        int idBouteille;
        int X;
        int Y;
        int eX;
        int eY;
        public AfficherLieu(int idl, int idb = 0)
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
            GC.Collect();
            GC.WaitForPendingFinalizers();

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
                    panel[k, l].Name = "emplacement_" + (k + 1) + "_" + (l + 1);

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

                        panel[k, l].Controls.Add(lignes[i], 0, lignes.Length - i);

                        Panel[] bouteilles = new Panel[lignes[i].ColumnCount];

                        for (int j = 0; j <= lignes[i].ColumnCount - 1; j++)
                        {
                            bouteilles[j] = new Panel();
                            bouteilles[j].Width = 23;
                            bouteilles[j].Height = 13;
                            bouteilles[j].BackColor = Color.LightGray;
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
            dessinerStock(title, X, Y, eX, eY);

            Array emplacements = Business.StockageController.NbBouteillesInEmplacementsFromLieu(idlieu);

            if (emplacements.Length > 0)
            {
                foreach (Entity.NbBouteillesInEmplacementsFromLieu_Result emplacement in emplacements)
                {
                    if(Convert.ToInt32(emplacement.IdBtl) == idBouteille) 
                        colorerBouteilles(emplacement.Qte.Value, emplacement.X.Value, emplacement.Y.Value, emplacement.Cha+", "+emplacement.Mil, Color.DarkSeaGreen);
                    else
                        colorerBouteilles(emplacement.Qte.Value, emplacement.X.Value, emplacement.Y.Value, emplacement.Cha + ", " + emplacement.Mil, Color.IndianRed);
                }
            }
        }

        private void AfficherLieu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tools.ouvrirForm("ListerLieux", this.MdiParent);
        }

        private void btnRetirerDuStock_Click(object sender, EventArgs e)
        {
            Form mdiparent = this.MdiParent;
            this.Close();
            Form newMDIChild = new DestockerMasse(idlieu);
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = mdiparent;
            // Display the new form.
            newMDIChild.StartPosition = FormStartPosition.Manual;
            newMDIChild.SuspendLayout();
            newMDIChild.Location = new System.Drawing.Point(0, 0);
            newMDIChild.ResumeLayout();
            newMDIChild.Show();
        }
    }
}
