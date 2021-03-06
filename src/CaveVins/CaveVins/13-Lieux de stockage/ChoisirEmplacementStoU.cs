﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CaveVins
{
    public partial class ChoisirEmplacementStoU : Form
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
        public ChoisirEmplacementStoU(int idl, int idb, int nbToStore)
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
            Color color = ((Control)sender).BackColor;

            if (color == Color.IndianRed)
                MessageBox.Show("Cet emplacement est déjà occupé par une bouteille.\nVeuillez choisir un emplacement disponible !", "La place est déjà prise", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                
                string senderName = ((Control)sender).Name;
                string[] info_place = senderName.Split(new string[] { "_" }, StringSplitOptions.None);

                //On récupère les infos dont-on a besoin pour stocker la bouteille.
                long id_emplacement = Business.EmplacementsController.getIdEmplacement(idlieu, int.Parse(info_place.GetValue(1).ToString()), int.Parse(info_place.GetValue(2).ToString()));
                int position = int.Parse(info_place.GetValue(4).ToString()) + 1;

                Business.StockageController.addStockUni(idBouteille, Convert.ToInt32(id_emplacement), position);
                Boolean termine = Business.InventaireController.retirerBouteilleInventaire(idBouteille, aStocker);

                colorerBouteilles(idlieu, Color.IndianRed);

                MessageBox.Show("La référence a correctement été stockée.\nStockage de la référence terminé.\n\nRetour à l'inventaire.", "Terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tools.ouvrirForm("InventaireListe", this.MdiParent);
            }


        }

        //Fonction permettant de retourner vrai si un nombre est paire, faux sinon
        private static bool isPaire(int val)
        {
            if (val % 2 == 0)
                return true;
            else
                return false;
        }

        private void colorerBouteilles(int idLieu, Color col)
        {
            List<Entity.T_EMPLACEMENT_EMP> emplacements = Business.StockageController.idEmplacementsFromLieuStoU(idLieu);

            foreach (Entity.T_EMPLACEMENT_EMP emplacement in emplacements)
            {
                List<Entity.T_STOUNI_STU> bouteilles = Business.StockageController.listBtlEmplacementStoU(Convert.ToInt32(emplacement.EMP_I_ID));

                foreach (Entity.T_STOUNI_STU bouteille in bouteilles)
                {
                    string namePanel = "btl_" + (emplacement.EMP_I_POSH) + "_" + (emplacement.EMP_I_POSV) + "_" + 0 + "_" + (bouteille.STO_I_PLACE - 1);

                    tableLayoutPanel1.Controls.Find(namePanel, true)[0].BackColor = col;
                    System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
                    ToolTip1.SetToolTip(tableLayoutPanel1.Controls.Find(namePanel, true)[0], bouteille.T_BOUTEILLE_BTL.T_CHATEAU_CHT.CHT_S_CHATEAU.ToString() + " " + bouteille.T_BOUTEILLE_BTL.T_FLACONNAGE_FCG.FCG_R_CONTENANCE.ToString() + "cL, " + bouteille.T_BOUTEILLE_BTL.BTL_I_MILLESIME.ToString());
                    ToolTip1.ShowAlways = true;
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
                lab.Height = 20;
                lab.Width = 5;
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
            colorerBouteilles(idlieu, Color.IndianRed);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tools.ouvrirForm("ListerLieux", this.MdiParent);
        }
    }
}
