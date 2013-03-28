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
    public partial class InventaireListe : Form
    {
        public InventaireListe()
        {
            InitializeComponent();
        }

        string lblNbBouteilles;
        string lblNbRef;

        private void InventaireListe_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            dataGridView1.DataSource = Business.InventaireController.listerInventaire();
            lblNbBouteilles = calcBouteille().ToString();
            lblNbRef = dataGridView1.RowCount.ToString();
            lblStats.Text = "Votre inventaire contient "+lblNbRef+" référence(s) - avec un total de "+lblNbBouteilles+" bouteille(s)";
            dataGridView1.AutoResizeColumns();
            dataGridView1.Focus();
            dataGridView1.Columns[0].Visible = false;

            if (dataGridView1.RowCount == 0)
            {
                btnModifier.Visible = false;
                btnSupprimer.Visible = false;
                btnStocker.Visible = false;
            }

            Cursor = Cursors.Arrow;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            modifierBouteilleInventaire();
        }

        private int calcBouteille()
        {
            int total = 0;
            if (dataGridView1.RowCount != 0)
            {
                
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    total += int.Parse(row.Cells[3].Value.ToString());
                }                
            }
            return total;
        }

        private void modifierBouteilleInventaire()
        {
            int index = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (index != -1)
            {
                int idBouteille = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                String chateau = dataGridView1.Rows[index].Cells[1].Value.ToString();
                String millesime = dataGridView1.Rows[index].Cells[2].Value.ToString();

                using (var cbBouteilles = new Combien())
                {
                    cbBouteilles.Text = "Combien ?";
                    cbBouteilles.ShowIcon = false;
                    cbBouteilles.setLabel("Saisissez la nouvelle quantité désirée pour\n[" + chateau + " - " + millesime + "].");
                    cbBouteilles.setMin(1);
                    cbBouteilles.Location = new System.Drawing.Point(this.MdiParent.Location.X + (this.MdiParent.Width - cbBouteilles.Width) / 2, this.MdiParent.Location.Y + (this.MdiParent.Height - cbBouteilles.Height) / 2);
                    var res = cbBouteilles.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        int nbBouteilles = int.Parse(cbBouteilles.ReturnValue1);
                        Business.InventaireController.modifierBouteilleInventaire(idBouteille, nbBouteilles);
                        dataGridView1.DataSource = Business.InventaireController.listerInventaire();
                        lblNbBouteilles = calcBouteille().ToString();
                        lblStats.Text = "Votre inventaire contient " + lblNbRef + " référence(s) - avec un total de " + lblNbBouteilles + " bouteille(s)";
                        dataGridView1.AutoResizeColumns();
                    }
                }

            }
        }


        private void supprimerBouteilleInventaire()
        {
            int index = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (index != -1)
            {
                int idBouteille = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                String chateau = dataGridView1.Rows[index].Cells[1].Value.ToString();
                String millesime = dataGridView1.Rows[index].Cells[2].Value.ToString();

                DialogResult rep = MessageBox.Show("Souhaitez vous réellement supprimer la référence [" + chateau + " - " + millesime + "] de votre inventaire ?\n\nCette opération ne peut pas être annulée. Pour modifier la quantité de bouteilles possédées pour cette référence, utilisez la fonction modifier.", "Êtes vous sûr(e) ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    Business.InventaireController.supprimerBouteille(idBouteille);
                    dataGridView1.DataSource = Business.InventaireController.listerInventaire();
                    lblNbBouteilles = calcBouteille().ToString();
                    lblNbRef = dataGridView1.RowCount.ToString();

                    lblStats.Text = "Votre inventaire contient " + lblNbRef + " référence(s) - avec un total de " + lblNbBouteilles + " bouteille(s)";

                    if (dataGridView1.RowCount == 0)
                    {
                        btnModifier.Visible = false;
                        btnSupprimer.Visible = false;
                        btnStocker.Visible = false;
                    }
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Tools.ouvrirForm("RechercheBase", this.MdiParent);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            modifierBouteilleInventaire();
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

        private void modifierLeNombreDeBouteillesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifierBouteilleInventaire();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            supprimerBouteilleInventaire();
        }

        private void supprimerCetteRéférenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimerBouteilleInventaire();
        }

        private void btnStocker_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (index != -1)
            {
                int idBouteille = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                int nb = int.Parse(dataGridView1.Rows[index].Cells[3].Value.ToString());

                Form mdiparent = this.MdiParent;
                this.Close();
                Form newMDIChild = new ChoisirLieu(idBouteille, nb);
                // Set the Parent Form of the Child window.
                newMDIChild.MdiParent = mdiparent;
                // Display the new form.
                newMDIChild.StartPosition = FormStartPosition.Manual;
                newMDIChild.SuspendLayout();
                newMDIChild.Location = new System.Drawing.Point(0, 0);
                newMDIChild.ResumeLayout();
                newMDIChild.Show();
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner une référence pour pouvoir la stocker");
            }
            
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Tools.ouvrirForm("WelcomeScreen", this.MdiParent);
        }
    }
}
