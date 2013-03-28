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
    public partial class ChoisirLieu : Form
    {
        int idBouteille, nbToStore;
        public ChoisirLieu(int idbtl, int nbAstocker)
        {
            InitializeComponent();
            idBouteille = idbtl;
            nbToStore = nbAstocker;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int ri = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                if (ri != -1)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.CurrentCell = dataGridView1.Rows[ri].Cells[1];
                    dataGridView1.Rows[ri].Selected = true;
                    contextMenuStrip1.Show(dataGridView1, new Point(e.X, e.Y));
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (index != -1)
            {
                int idlieu = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                Form mdiparent = this.MdiParent;
                this.Close();

                Form newMDIChild; 
                
                if(nbToStore == 1)
                    newMDIChild = new ChoisirEmplacementStoU(idlieu, idBouteille, nbToStore);
                else
                    newMDIChild = new ChoisirEmplacement(idlieu, idBouteille, nbToStore);

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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Tools.ouvrirForm("InventaireListe", this.MdiParent);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (int.Parse(row.Cells[3].Value.ToString()) > 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Honeydew;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void ChoisirLieu_Shown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            Entity.T_LIEU_LIE[] lieux;
            
            if(nbToStore == 1)
                lieux = Business.LieuxController.listLieuxUQuery();
            else
                lieux = Business.LieuxController.listLieuxQuery();

            if (lieux.Length == 0)
            {
                MessageBox.Show("Impossible de stocker cette référence, aucun lieu de stockage existant.\nCommencez par créer un lieu de stockage.\n\nRetour à l'inventaire", "Aucun stockage existant :'(", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Tools.ouvrirForm("InventaireListe", this.MdiParent);
            }
            else
            {

                BindingSource BS = new BindingSource();
                DataTable testTable = new DataTable();

                testTable.Columns.Add("idlieu", typeof(int));
                testTable.Columns.Add("nomlieu", typeof(string));
                testTable.Columns.Add("placestotal", typeof(int));
                testTable.Columns.Add("nbbtlid", typeof(int));
                testTable.Columns.Add("placesdispo", typeof(int));

                foreach (Entity.T_LIEU_LIE lieu in lieux)
                {

                    int? placesOQPparAutresBouteilles = Business.StockageController.NbEmplacementsOQPSaufIdBtl(int.Parse(lieu.LIE_I_ID.ToString()), idBouteille) * lieu.LIE_I_CAPA;
                    int? nbBouteillesIdentiques = Business.StockageController.NbBouteillesInLieuByIdBtl(int.Parse(lieu.LIE_I_ID.ToString()), idBouteille);

                    int capaLieu = lieu.LIE_I_NBHOR * lieu.LIE_I_NBVERT * lieu.LIE_I_CAPA;
                    int placesDisponibles = capaLieu - int.Parse(placesOQPparAutresBouteilles.ToString()) - int.Parse(nbBouteillesIdentiques.ToString());

                    if (placesDisponibles != 0)
                        testTable.Rows.Add(lieu.LIE_I_ID, lieu.LIE_S_NOM, capaLieu, nbBouteillesIdentiques, placesDisponibles);

                    DataView view = testTable.DefaultView;
                    view.Sort = "nbbtlid DESC, placestotal DESC";

                    BS.DataSource = view;
                }

                dataGridView1.DataSource = BS;

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Nom du lieu";
                dataGridView1.Columns[2].HeaderText = "Places totales";

                dataGridView1.Columns[3].HeaderText = "Nb btl réf identique";
                dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.Programmatic;
                dataGridView1.Columns[3].HeaderCell.SortGlyphDirection = SortOrder.Descending;

                dataGridView1.Columns[4].HeaderText = "Places dispo";
                dataGridView1.Columns[4].SortMode = DataGridViewColumnSortMode.Programmatic;
                dataGridView1.Columns[4].HeaderCell.SortGlyphDirection = SortOrder.Descending;

                dataGridView1.ClearSelection();
                dataGridView1.Rows[0].Selected = false;

                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Désolé, plus aucune place disponnible dans les lieux de stockage.\nCréez un nouveau lieu ou libérez de l'espace dans les lieux existants ...\n\nRetour à l'inventaire", "Plus de place :'(", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Tools.ouvrirForm("InventaireListe", this.MdiParent);
                }
            }
        }
}
}
