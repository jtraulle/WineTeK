using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CaveVins
{
    public partial class RechercheBase : Form
    {
        public RechercheBase()
        {
            InitializeComponent();
        }

        //Ce formulaire permet d'effectuer une recherche à partir de la base de référence de l'application
        //Il est possible d'ajouter une ligne de résultat de la recherche à l'inventaire

        //Lorsque le pays est sélectionné, la région devient sélectionnable
        //Lorsque la région est sélectionnée, l'appellation devient selectionnable

        private void lbxPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxRegion.DataSource = Business.RegionsController.listRegionsFromPays(lbxPays.SelectedValue.ToString());
            lbxRegion.DisplayMember = "REG_S_NOM";
            lbxRegion.ValueMember = "REG_C_CODE";
            lbxRegion.Text = "Sélectionnez une région";
            lbxRegion.Enabled = true;
            lbxAppellation.Text = "Sélectionnez d'abord une région";
            lbxAppellation.Enabled = false;
            Cursor = Cursors.WaitCursor;
            dataGridView1.DataSource = Business.BouteillesController.listBouteillesFromPays(lbxPays.SelectedValue.ToString());
            if (dataGridView1.RowCount > 0) btnAjoutInventaire.Visible = true; else btnAjoutInventaire.Visible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.Focus();
            dataGridView1.Columns[0].Visible = false;
            Cursor = Cursors.Arrow;
        }

        private void lbxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void RechercheBase_Load(object sender, EventArgs e)
        {
            lbxPays.DataSource = CaveVins.Business.PaysController.listPays();
            lbxPays.DisplayMember = "PAY_S_NOM";
            lbxPays.ValueMember = "PAY_C_CODE";
            lbxPays.Text = "Sélectionnez un pays";

            lbxRegion.Text = "Sélectionnez d'abord un pays";
            lbxRegion.Enabled = false;


            lbxAppellation.Text = "Sélectionnez d'abord une région";
            lbxAppellation.Enabled = false;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (index != -1)
            {
                stockerDansInventaire(index);
            }
        }

        private void stockerDansInventaire(int index){
            int idBouteille = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
            String chateau = dataGridView1.Rows[index].Cells[1].Value.ToString();
            String millesime = dataGridView1.Rows[index].Cells[2].Value.ToString();
            DialogResult result = MessageBox.Show("Voulez vous ajouter cette bouteille à votre inventaire ?", "Ajouter à l'inventaire ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var cbBouteilles = new Combien())
                {
                    cbBouteilles.Text = "Combien ?";
                    cbBouteilles.ShowIcon = false;
                    cbBouteilles.setLabel("Combien de bouteilles [" + chateau + " - " + millesime + "]\nvoulez vous ajouter à votre inventaire ?");
                    cbBouteilles.setMin(1);
                    cbBouteilles.Location = new System.Drawing.Point(this.MdiParent.Location.X + (this.MdiParent.Width - cbBouteilles.Width) / 2, this.MdiParent.Location.Y + (this.MdiParent.Height - cbBouteilles.Height) / 2);
                    var res = cbBouteilles.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        int nbBouteilles = int.Parse(cbBouteilles.ReturnValue1);
                        Business.InventaireController.ajouterBouteilleInventaire(idBouteille, nbBouteilles);
                        DialogResult dialogResult = MessageBox.Show("La référence a correctement été ajoutée à l'inventaire.\n\nAfficher l'inventaire maintenant ?", "Aller à l'inventaire ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Tools.ouvrirForm("InventaireListe", this.MdiParent);
                        }
                    }
                }
            }
        }

        private void lbxRegion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbxAppellation.DataSource = Business.AppellationsController.listAppellationsFromRegion(lbxRegion.SelectedValue.ToString());
            lbxAppellation.DisplayMember = "APT_S_NOM";
            lbxAppellation.ValueMember = "APT_I_ID";
            lbxAppellation.Text = "Sélectionnez une appellation";
            lbxAppellation.Enabled = true;
            dataGridView1.DataSource = Business.BouteillesController.listBouteillesFromRegion(lbxRegion.SelectedValue.ToString());
            if (dataGridView1.RowCount > 0) btnAjoutInventaire.Visible = true; else btnAjoutInventaire.Visible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.Focus();
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            Array bouteilles = Business.BouteillesController.listBouteillesFromMillesime(int.Parse(numericUpDown1.Value.ToString()));
            if (bouteilles.Length != 0)
            {
                dataGridView1.DataSource = bouteilles;
                btnAjoutInventaire.Visible = true;
                dataGridView1.AutoResizeColumns();
                dataGridView1.Focus();
                dataGridView1.Columns[0].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = null;
                btnAjoutInventaire.Visible = false;
                MessageBox.Show("Aucune bouteille trouvée pour votre recherche, essayez avec des critères différents","Aucun résultat pour la recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            dataGridView1.DataSource = null;
            btnAjoutInventaire.Visible = false;
            lbxPays.Text = "Sélectionnez un pays";
            lbxRegion.Text = "Sélectionnez d'abord un pays";
            lbxRegion.DataSource = null;
            lbxRegion.Enabled = false;
            lbxAppellation.Text = "Sélectionnez d'abord une région";
            lbxAppellation.DataSource = null;
            lbxAppellation.Enabled = false;
        }

        private void btnChercherNom_Click(object sender, EventArgs e)
        {
            if (iptStartWith.TextLength >= 1)
            {
                Array bouteilles = Business.BouteillesController.listBouteillesFromChateau(iptStartWith.Text.ToString());
                if (bouteilles.Length != 0)
                {
                    dataGridView1.DataSource = bouteilles;
                    btnAjoutInventaire.Visible = true;
                    dataGridView1.AutoResizeColumns();
                    dataGridView1.Focus();
                    dataGridView1.Columns[0].Visible = false;
                }
                else
                {
                    dataGridView1.DataSource = null;
                    btnAjoutInventaire.Visible = false;
                    MessageBox.Show("Aucune bouteille trouvée pour votre recherche, essayez avec des critères différents", "Aucun résultat pour la recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vous devez saisir un critère pour pouvoir lancer la recherche !", "Saisie incomplète", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnAjoutInventaire_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (index != -1)
            {
                stockerDansInventaire(index);
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner une référence pour pouvoir l'ajouter à votre inventaire !","",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Tools.ouvrirForm("WelcomeScreen", this.MdiParent);
        }

        private void lbxAppellation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Business.BouteillesController.listBouteillesFromAppellation(int.Parse(lbxAppellation.SelectedValue.ToString()));
            if (dataGridView1.RowCount > 0) btnAjoutInventaire.Visible = true; else btnAjoutInventaire.Visible = false;
            dataGridView1.AutoResizeColumns();
            dataGridView1.Focus();
            dataGridView1.Columns[0].Visible = false;
        }
    }
}
