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
    //Ce formulaire permet d'afficher l'ensemble des actions permettant de gérer
    //la base de données de référence.
    public partial class GererDonnees : Form
    {
        //Stockage du mode (insertion/édition)
        //pour chaque onglet.
        string mode0 = "I";
        string mode1 = "I";
        string mode2 = "I";
        string mode3 = "I";
        string mode4 = "I";
        string mode5 = "I";
        string mode6 = "I";

        //Id pour les modifications
        int idAppellation;
        int idChateau;
        int idFlaconnage;
        int idCouleur;
        int idBouteille;

        public GererDonnees()
        {
            InitializeComponent();
        }

        private void GererDonnees_Shown(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Business.PaysController.listPaysFull();

            cbxPaysRegion.DataSource = Business.PaysController.listPays();
            cbxPaysRegion.DisplayMember = "PAY_S_NOM";
            cbxPaysRegion.ValueMember = "PAY_C_CODE";

            cbxRegionAppellation.DataSource = Business.RegionsController.listRegions();
            cbxRegionAppellation.DisplayMember = "REG_S_NOM";
            cbxRegionAppellation.ValueMember = "REG_C_CODE";

            cbxAppellationChateau.DataSource = Business.AppellationsController.listAppellations();
            cbxAppellationChateau.DisplayMember = "APT_S_NOM";
            cbxAppellationChateau.ValueMember = "APT_I_ID";

            cbxChateauBouteille.DataSource = Business.ChateauController.listChateaux();
            cbxChateauBouteille.DisplayMember = "CHT_S_CHATEAU";
            cbxChateauBouteille.ValueMember = "CHT_I_ID";

            cbxFlaconnageBouteille.DataSource = Business.FlaconnageController.listFlaconnages();
            cbxFlaconnageBouteille.DisplayMember = "FCG_S_NOM";
            cbxFlaconnageBouteille.ValueMember = "FCG_I_ID";

            cbxCouleurBouteille.DataSource = Business.CouleurController.listCouleurs();
            cbxCouleurBouteille.DisplayMember = "CLR_S_NOM";
            cbxCouleurBouteille.ValueMember = "CLR_I_ID";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                //Onglet Pays
                case 0:
                    dataGridView1.DataSource = Business.PaysController.listPaysFull();
                    dataGridView1.Columns[0].Visible = true;
                    break;
                //Onglet Région
                case 1:
                    dataGridView1.DataSource = Business.RegionsController.listRegionsFull();
                    dataGridView1.Columns[0].Visible = true;
                    dataGridView1.Columns[2].Visible = false;
                    break;
                //Onglet Appellation
                case 2:
                    dataGridView1.DataSource = Business.AppellationsController.listAppellationsFull();
                    //On cache l'id Appellation
                    dataGridView1.Columns[0].Visible = false;
                    //On cache l'id région
                    dataGridView1.Columns[2].Visible = false;
                    break;
                //Onglet Chateau
                case 3:
                    dataGridView1.DataSource = Business.ChateauController.listChateauxFull();
                    //On cache l'id chateau
                    dataGridView1.Columns[0].Visible = false;
                    //On cache l'id appellation
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[3].Visible = false;
                    break;
                //Onglet Flaconnage
                case 4:
                    dataGridView1.DataSource = Business.FlaconnageController.listFlaconnagesFull();
                    //On cache l'id chateau
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[2].Visible = true;
                    break;
                //Onglet Couleurs
                case 5:
                    dataGridView1.DataSource = Business.CouleurController.listCouleursFull();
                    //On cache l'id chateau
                    dataGridView1.Columns[0].Visible = false;
                    break;
                //Onglet Bouteilles
                case 6:
                    dataGridView1.DataSource = Business.BouteillesController.listBouteillesFull();
                    //On cache l'id bouteille
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                    dataGridView1.Columns[10].Visible = false;
                    break;
            }
            dataGridView1.AutoResizeColumns();
        }

        private void btnEditerEnregistrement_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (index != -1)
            {
                switch (tabControl1.SelectedIndex)
                {
                    //Onglet Pays
                    case 0:
                        switchModeTo("Edition");
                        iptIdentifiantPays.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        iptIdentifiantPays.Enabled = false;
                        iptNomPays.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        break;
                    //Onglet Région
                    case 1:
                        switchModeTo("Edition");
                        iptIdentifiantRegion.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        iptIdentifiantRegion.Enabled = false;
                        iptNomRegion.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        cbxPaysRegion.SelectedValue = dataGridView1.Rows[index].Cells[2].Value.ToString();
                        break;
                    //Onglet Appellation
                    case 2:
                        switchModeTo("Edition");
                        idAppellation = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                        iptNomAppellation.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        cbxRegionAppellation.SelectedValue = dataGridView1.Rows[index].Cells[2].Value.ToString();
                        break;
                    //Onglet Château
                    case 3:
                        switchModeTo("Edition");
                        idChateau = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                        iptNomChateau.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        cbxAppellationChateau.SelectedValue = int.Parse(dataGridView1.Rows[index].Cells[3].Value.ToString());
                        iptDescChateau.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                        break;
                    //Onglet Flaconnage
                    case 4:
                        switchModeTo("Edition");
                        idFlaconnage = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                        iptIntituleFlaconnage.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        iptContenanceFlaconnage.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                        break;
                    //Onglet Couleur
                    case 5:
                        switchModeTo("Edition");
                        idCouleur = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                        iptIntituleCouleur.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        break;
                    //Onglet Bouteille
                    case 6:
                        switchModeTo("Edition");
                        idBouteille = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                        cbxChateauBouteille.SelectedValue = Convert.ToInt64(dataGridView1.Rows[index].Cells[8].Value);
                        cbxCouleurBouteille.SelectedValue = int.Parse(dataGridView1.Rows[index].Cells[10].Value.ToString());
                        ipnMillesimeBouteille.Value = decimal.Parse(dataGridView1.Rows[index].Cells[3].Value.ToString());
                        cbxFlaconnageBouteille.SelectedValue = int.Parse(dataGridView1.Rows[index].Cells[9].Value.ToString());
                        iptPrixBasBouteille.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
                        iptPrixHautBouteille.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
                        break;
                }
            }
        }

        private void switchModeTo(string mde)
        {
            string index = tabControl1.SelectedIndex.ToString();
            ToolStrip toolstrip = (ToolStrip) tabControl1.Controls.Find("toolStrip" + index, true)[0];
            ToolStripLabel infomode = (ToolStripLabel) toolstrip.Items.Find("lblMode" + index, true)[0];
            ToolStripButton btnCancelEdit = (ToolStripButton) toolstrip.Items.Find("btnCancelEdit" + index, true)[0];

            if (mde == "Edition")
            {
                infomode.Image = Properties.Resources.database_edit;
                infomode.Text = "Mode édition";
                btnCancelEdit.Visible = true;
                setMode("E", int.Parse(index));
            }
            else if (mde == "Insertion")
            {
                infomode.Image = Properties.Resources.database_add;
                infomode.Text = "Mode insertion";
                btnCancelEdit.Visible = false;
                setMode("I", int.Parse(index));
            }
        }

        private void setMode(string mode, int onglet)
        {
            switch (onglet)
            {
                //Onglet Pays
                case 0:
                    mode0 = mode;
                    break;
                //Onglet Régions
                case 1:
                    mode1 = mode;
                    break;
                //Onglet Appellations
                case 2:
                    mode2 = mode;
                    break;
                //Onglet Châteaux
                case 3:
                    mode3 = mode;
                    break;
                //Onglet Flaconnages
                case 4:
                    mode4 = mode;
                    break;
                //Onglet Couleurs
                case 5:
                    mode5 = mode;
                    break;
                //Onglet Bouteilles
                case 6:
                    mode6 = mode;
                    break;
            }
        }

        private string retourner_erreurs()
        {
            string erreurs = "";

            switch (tabControl1.SelectedIndex)
            {
                //Onglet Pays
                case 0:
                    if (iptIdentifiantPays.TextLength != 3)
                        erreurs += "- La longueur de l'identifiant doit être de 3 caractères.\n";
                    if (iptNomPays.TextLength == 0)
                        erreurs += "- La nom ne peut pas être vide.";
                    break;
                //Onglet Région
                case 1:
                    if (iptIdentifiantRegion.TextLength != 3)
                        erreurs += "- La longueur de l'identifiant doit être de 3 caractères.\n";
                    if (iptNomRegion.TextLength == 0)
                        erreurs += "- La nom ne peut pas être vide.";
                    break;
                //Onglet Appellation
                case 2:
                    if (iptNomAppellation.TextLength == 0)
                        erreurs += "- La nom ne peut pas être vide.";
                    break;
                //Onglet Château
                case 3:
                    if (iptNomChateau.TextLength == 0)
                        erreurs += "- La nom ne peut pas être vide.";
                    break;
                //Onglet Flaconnage
                case 4:
                    if (iptIntituleFlaconnage.TextLength == 0)
                        erreurs += "- L'inititulé ne peut pas être vide.";
                    int contenance;
                    if (int.TryParse(iptContenanceFlaconnage.Text, out contenance) == false)
                        erreurs += "- Vous devez saisir une valeur numérique pour la contenance.";
                    break;
                //Onglet Couleur
                case 5:
                    if (iptIntituleCouleur.TextLength == 0)
                        erreurs += "- L'intitulé ne peut pas être vide.";
                    break;
                //Onglet Bouteille
                case 6:
                    decimal prixmin;
                    if (decimal.TryParse(iptPrixBasBouteille.Text, out prixmin) == false)
                        erreurs += "- Vous devez saisir une valeur numérique pour le prix min.";
                    decimal prixmax;
                    if (decimal.TryParse(iptPrixHautBouteille.Text, out prixmax) == false)
                        erreurs += "- Vous devez saisir une valeur numérique pour le prix haut.";
                    break;
            }

            return erreurs;
        }

        //Enregistrement insertion/modification Pays
        private void btnSave0_Click(object sender, EventArgs e)
        {
            string erreurs = retourner_erreurs();

            if (erreurs != "")
            {
                MessageBox.Show("Des erreurs ont été rencontrées pendant la validation du formulaire.\n"
                              + "Veuillez corriger les erreurs mentionnées ci-dessous :\n\n" + erreurs, "Impossible de valider le formulaire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (mode0 == "E")
                {
                    try
                    {
                        Business.PaysController.ModifierPays(iptIdentifiantPays.Text, iptNomPays.Text);
                        dataGridView1.DataSource = Business.PaysController.listPaysFull();
                        updateCombobox("Pays");
                        switchModeTo("Insertion");
                        viderChamps();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
                else if (mode0 == "I")
                {
                    try
                    {
                        Business.PaysController.addPays(iptIdentifiantPays.Text, iptNomPays.Text);
                        dataGridView1.DataSource = Business.PaysController.listPaysFull();
                        updateCombobox("Pays");
                        viderChamps();
                    }
                    catch (DataException ex)
                    { MessageBox.Show("Une erreur est survenue lors de l'enregistrement des données.\n\nHabituellement, l'enregistrement échoue si vous spécifiez un code identifiant qui existe déjà.\n\nPour plus d'informations sur l'erreur, reportez-vous au détail de l'exception levée ci-dessous :\n\n"+ex.InnerException.InnerException.Message, "Impossible d'ajouter l'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void btnSupprimerEnregistrement_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (index != -1)
            {
                DialogResult rep = MessageBox.Show("Souhaitez vous réellement supprimer cet enregistrement ?\nCette opération ne peut pas être annulée", "Êtes vous sûr(e) ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.Yes)
                {
                    try
                    {
                        //En fonction de l'onglet actif, on effectue l'action appropriée.
                        switch (tabControl1.SelectedIndex)
                        {
                            //Onglet Pays
                            case 0:
                                Business.PaysController.SupprimerPays(dataGridView1.Rows[index].Cells[0].Value.ToString());
                                dataGridView1.DataSource = Business.PaysController.listPaysFull();
                                updateCombobox("Pays");
                                break;
                            //Onglet Région
                            case 1:
                                Business.RegionsController.SupprimerRegion(dataGridView1.Rows[index].Cells[0].Value.ToString());
                                dataGridView1.DataSource = Business.RegionsController.listRegionsFull();
                                updateCombobox("Région");
                                break;
                            //Onglet Appellation
                            case 2:
                                Business.AppellationsController.SupprimerAppellation(int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString()));
                                dataGridView1.DataSource = Business.AppellationsController.listAppellationsFull();
                                updateCombobox("Appellation");
                                break;
                            //Onglet Château
                            case 3:
                                Business.ChateauController.SupprimerChateau(int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString()));
                                dataGridView1.DataSource = Business.ChateauController.listChateauxFull();
                                updateCombobox("Chateau");
                                break;
                            //Onglet Flaconnage
                            case 4:
                                Business.FlaconnageController.SupprimerFlaconnage(int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString()));
                                dataGridView1.DataSource = Business.FlaconnageController.listFlaconnagesFull();
                                updateCombobox("Flaconnage");
                                break;
                            //Onglet Couleur
                            case 5:
                                Business.CouleurController.SupprimerCouleur(int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString()));
                                dataGridView1.DataSource = Business.CouleurController.listCouleursFull();
                                updateCombobox("Couleur");
                                break;
                            //Onglet Bouteille
                            case 6:
                                Business.BouteillesController.SupprimerBouteille(int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString()));
                                dataGridView1.DataSource = Business.BouteillesController.listBouteillesFull();
                                break;
                        }
                    }
                    catch (DataException ex)
                    { MessageBox.Show("Une erreur est survenue lors de la suppression de l'enregistrement.\nLa suppression peut échouer si l'entité est encore liée à une autre.\n\nSupprimez d'abord l'ensemble des entitées liées pour pouvoir supprimer celle-ci.\n\nPour plus d'informations sur l'erreur, reportez-vous au détail de l'exception levée ci-dessous :\n\n" + ex.InnerException.InnerException.Message, "Impossible de supprimer l'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        //Enregistrement ajout/modification Région
        private void btnSave1_Click(object sender, EventArgs e)
        {
            string erreurs = retourner_erreurs();

            if (erreurs != "")
            {
                MessageBox.Show("Des erreurs ont été rencontrées pendant la validation du formulaire.\n"
                              + "Veuillez corriger les erreurs mentionnées ci-dessous :\n\n" + erreurs, "Impossible de valider le formulaire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (mode1 == "E")
                {
                    try
                    {
                        Business.RegionsController.ModifierRegion(iptIdentifiantRegion.Text, iptNomRegion.Text, cbxPaysRegion.SelectedValue.ToString());

                        dataGridView1.DataSource = Business.RegionsController.listRegionsFull();
                        switchModeTo("Insertion");
                        updateCombobox("Région");
                        viderChamps();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
                else if (mode1 == "I")
                {
                    try
                    {
                        Business.RegionsController.AjouterRegion(iptIdentifiantRegion.Text, iptNomRegion.Text, cbxPaysRegion.SelectedValue.ToString());
                        dataGridView1.DataSource = Business.RegionsController.listRegionsFull();
                        updateCombobox("Région");
                        viderChamps();
                    }
                    catch (DataException ex)
                    { MessageBox.Show("Une erreur est survenue lors de l'enregistrement des données.\n\nHabituellement, l'enregistrement échoue si vous spécifiez un code identifiant qui existe déjà.\n\nPour plus d'informations sur l'erreur, reportez-vous au détail de l'exception levée ci-dessous :\n\n" + ex.InnerException.InnerException.Message, "Impossible d'ajouter l'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void viderChamps(){
            switch (tabControl1.SelectedIndex)
            {
                //Onglet Pays
                case 0:
                    iptIdentifiantPays.Enabled = true;
                    iptIdentifiantPays.Text = "";
                    iptNomPays.Text = "";
                    break;
                //Onglet Région
                case 1:
                    iptIdentifiantRegion.Enabled = true;
                    iptIdentifiantRegion.Text = "";
                    iptNomRegion.Text = "";
                    cbxPaysRegion.SelectedIndex = 0;
                    break;
                //Onglet Appellation
                case 2:
                    idAppellation = default(int);
                    iptNomAppellation.Text = "";
                    cbxRegionAppellation.SelectedIndex = 0;
                    break;
                //Onglet Chateaux
                case 3:
                    idChateau = default(int);
                    iptNomChateau.Text = "";
                    iptDescChateau.Text = "";
                    cbxAppellationChateau.SelectedIndex = 0;
                    break;
                //Onglet Flaconnages
                case 4:
                    idFlaconnage = default(int);
                    iptIntituleFlaconnage.Text = "";
                    iptContenanceFlaconnage.Text = "";
                    break;
                //Onglet Couleurs
                case 5:
                    idCouleur = default(int);
                    iptIntituleCouleur.Text = "";
                    break;
                //Onglet Bouteille
                case 6:
                    idBouteille = default(int);
                    cbxChateauBouteille.SelectedIndex = 0;
                    cbxCouleurBouteille.SelectedIndex = 0;
                    ipnMillesimeBouteille.Value = 2013;
                    cbxFlaconnageBouteille.SelectedIndex = 0;
                    iptPrixBasBouteille.Text = "";
                    iptPrixHautBouteille.Text = "";
                    break;
            }
        }

        //Boutons pour annuler la modification en cours et retourner au mode edition.
        private void btnCancelEdit0_Click(object sender, EventArgs e)
        {
            viderChamps();
            switchModeTo("Insertion");
        }

        private void btnCancelEdit1_Click(object sender, EventArgs e)
        {
            viderChamps();
            switchModeTo("Insertion");
        }

        private void btnCancelEdit2_Click(object sender, EventArgs e)
        {
            viderChamps();
            switchModeTo("Insertion");
        }

        private void btnCancelEdit3_Click(object sender, EventArgs e)
        {
            viderChamps();
            switchModeTo("Insertion");
        }

        private void btnCancelEdit4_Click(object sender, EventArgs e)
        {
            viderChamps();
            switchModeTo("Insertion");
        }

        private void btnCancelEdit5_Click(object sender, EventArgs e)
        {
            viderChamps();
            switchModeTo("Insertion");
        }

        private void btnCancelEdit6_Click(object sender, EventArgs e)
        {
            viderChamps();
            switchModeTo("Insertion");
        }

        //Mise en majuscule automatique des identifiants
        private void iptIdentifiantPays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void iptIdentifiantRegion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void updateCombobox(string entite)
        {
            switch (entite)
            {
                //Onglet Pays
                case "Pays":
                    //On actualise la liste des pays dans l'onglet région.
                    //On resélectionne le pays précédemment sélectionné.
                    string selectedIdPaysRegion = Convert.ToString(cbxPaysRegion.SelectedValue);
                    cbxPaysRegion.DataSource = Business.PaysController.listPays();
                    cbxPaysRegion.SelectedValue = selectedIdPaysRegion;
                    break;
                case "Région":
                    //On actualise la liste des régions dans l'onglet appellation.
                    //On resélectionne la région précédemment sélectionné.
                    string selectedIdRegionAppellation = Convert.ToString(cbxRegionAppellation.SelectedValue);
                    cbxRegionAppellation.DataSource = Business.RegionsController.listRegions();
                    cbxRegionAppellation.SelectedValue = selectedIdRegionAppellation;
                    break;
                case "Appellation":
                    //On actualise la liste des régions dans l'onglet appellation.
                    //On resélectionne la région précédemment sélectionné.
                    int selectedIdAppellationChateau = Convert.ToInt32(cbxAppellationChateau.SelectedValue);
                    cbxAppellationChateau.DataSource = Business.AppellationsController.listAppellations();
                    cbxAppellationChateau.SelectedValue = selectedIdAppellationChateau;
                    break;
                case "Chateau":
                    //On actualise la liste des régions dans l'onglet appellation.
                    //On resélectionne la région précédemment sélectionné.
                    int selectedIdChateauBouteille = Convert.ToInt32(cbxChateauBouteille.SelectedValue);
                    cbxChateauBouteille.DataSource = Business.ChateauController.listChateaux();
                    cbxChateauBouteille.SelectedValue = selectedIdChateauBouteille;
                    break;
                case "Flaconnage":
                    //On actualise la liste des régions dans l'onglet appellation.
                    //On resélectionne la région précédemment sélectionné.
                    int selectedIdFlaconnageBouteille = Convert.ToInt32(cbxFlaconnageBouteille.SelectedValue);
                    cbxFlaconnageBouteille.DataSource = Business.FlaconnageController.listFlaconnages();
                    cbxFlaconnageBouteille.SelectedValue = selectedIdFlaconnageBouteille;
                    break;
                case "Couleur":
                    //On actualise la liste des régions dans l'onglet appellation.
                    //On resélectionne la région précédemment sélectionné.
                    int selectedIdCouleurBouteille = Convert.ToInt32(cbxCouleurBouteille.SelectedValue);
                    cbxCouleurBouteille.DataSource = Business.CouleurController.listCouleurs();
                    cbxCouleurBouteille.SelectedValue = selectedIdCouleurBouteille;
                    break;
            }
        }

        //Enregistrement insertion/modification Appellation
        private void btnSave2_Click(object sender, EventArgs e)
        {
            string erreurs = retourner_erreurs();

            if (erreurs != "")
            {
                MessageBox.Show("Des erreurs ont été rencontrées pendant la validation du formulaire.\n"
                              + "Veuillez corriger les erreurs mentionnées ci-dessous :\n\n" + erreurs, "Impossible de valider le formulaire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (mode2 == "E")
                {
                    try
                    {
                        Business.AppellationsController.ModifierAppellation(idAppellation, iptNomAppellation.Text, cbxRegionAppellation.SelectedValue.ToString());

                        dataGridView1.DataSource = Business.AppellationsController.listAppellationsFull();
                        switchModeTo("Insertion");
                        updateCombobox("Appellation");
                        viderChamps();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
                else if (mode2 == "I")
                {
                    try
                    {
                        Business.AppellationsController.AjouterAppellation(iptNomAppellation.Text, cbxRegionAppellation.SelectedValue.ToString());
                        dataGridView1.DataSource = Business.AppellationsController.listAppellationsFull();
                        updateCombobox("Appellation");
                        viderChamps();
                    }
                    catch (DataException ex)
                    { MessageBox.Show("Une erreur est survenue lors de l'enregistrement des données.\n\nPour plus d'informations sur l'erreur, reportez-vous au détail de l'exception levée ci-dessous :\n\n" + ex.InnerException.InnerException.Message, "Impossible d'ajouter l'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            string erreurs = retourner_erreurs();

            if (erreurs != "")
            {
                MessageBox.Show("Des erreurs ont été rencontrées pendant la validation du formulaire.\n"
                              + "Veuillez corriger les erreurs mentionnées ci-dessous :\n\n" + erreurs, "Impossible de valider le formulaire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (mode3 == "E")
                {
                    try
                    {
                        Business.ChateauController.ModifierChateau(idChateau, Convert.ToInt32(cbxAppellationChateau.SelectedValue), iptNomChateau.Text, iptDescChateau.Text);
                        
                        dataGridView1.DataSource = Business.ChateauController.listChateauxFull();
                        switchModeTo("Insertion");
                        updateCombobox("Chateau");
                        viderChamps();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
                else if (mode3 == "I")
                {
                    try
                    {
                        Business.ChateauController.AjouterChateau(Convert.ToInt32(cbxAppellationChateau.SelectedValue), iptNomChateau.Text, iptDescChateau.Text);
                        dataGridView1.DataSource = Business.ChateauController.listChateauxFull();
                        updateCombobox("Chateau");
                        viderChamps();
                    }
                    catch (DataException ex)
                    { MessageBox.Show("Une erreur est survenue lors de l'enregistrement des données.\n\nPour plus d'informations sur l'erreur, reportez-vous au détail de l'exception levée ci-dessous :\n\n" + ex.InnerException.InnerException.Message, "Impossible d'ajouter l'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void btnSave4_Click(object sender, EventArgs e)
        {
            string erreurs = retourner_erreurs();

            if (erreurs != "")
            {
                MessageBox.Show("Des erreurs ont été rencontrées pendant la validation du formulaire.\n"
                              + "Veuillez corriger les erreurs mentionnées ci-dessous :\n\n" + erreurs, "Impossible de valider le formulaire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (mode4 == "E")
                {
                    try
                    {
                        Business.FlaconnageController.ModifierFlaconnage(idFlaconnage, iptIntituleFlaconnage.Text, Convert.ToInt32(iptContenanceFlaconnage.Text));

                        dataGridView1.DataSource = Business.FlaconnageController.listFlaconnagesFull();
                        switchModeTo("Insertion");
                        updateCombobox("Flaconnage");
                        viderChamps();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
                else if (mode4 == "I")
                {
                    try
                    {
                        Business.FlaconnageController.AjouterFlaconnage(iptIntituleFlaconnage.Text, Convert.ToInt32(iptContenanceFlaconnage.Text));
                        dataGridView1.DataSource = Business.FlaconnageController.listFlaconnagesFull();
                        updateCombobox("Flaconnage");
                        viderChamps();
                    }
                    catch (DataException ex)
                    { MessageBox.Show("Une erreur est survenue lors de l'enregistrement des données.\n\nPour plus d'informations sur l'erreur, reportez-vous au détail de l'exception levée ci-dessous :\n\n" + ex.InnerException.InnerException.Message, "Impossible d'ajouter l'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void btnSave5_Click(object sender, EventArgs e)
        {
            string erreurs = retourner_erreurs();

            if (erreurs != "")
            {
                MessageBox.Show("Des erreurs ont été rencontrées pendant la validation du formulaire.\n"
                              + "Veuillez corriger les erreurs mentionnées ci-dessous :\n\n" + erreurs, "Impossible de valider le formulaire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (mode5 == "E")
                {
                    try
                    {
                        Business.CouleurController.ModifierCouleur(idCouleur, iptIntituleCouleur.Text);

                        dataGridView1.DataSource = Business.CouleurController.listCouleursFull();
                        switchModeTo("Insertion");
                        updateCombobox("Couleur");
                        viderChamps();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
                else if (mode5 == "I")
                {
                    try
                    {
                        Business.CouleurController.AjouterCouleur(iptIntituleCouleur.Text);
                        dataGridView1.DataSource = Business.CouleurController.listCouleursFull();
                        updateCombobox("Couleur");
                        viderChamps();
                    }
                    catch (DataException ex)
                    { MessageBox.Show("Une erreur est survenue lors de l'enregistrement des données.\n\nPour plus d'informations sur l'erreur, reportez-vous au détail de l'exception levée ci-dessous :\n\n" + ex.InnerException.InnerException.Message, "Impossible d'ajouter l'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void btnSave6_Click(object sender, EventArgs e)
        {
            string erreurs = retourner_erreurs();

            if (erreurs != "")
            {
                MessageBox.Show("Des erreurs ont été rencontrées pendant la validation du formulaire.\n"
                              + "Veuillez corriger les erreurs mentionnées ci-dessous :\n\n" + erreurs, "Impossible de valider le formulaire", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (mode6 == "E")
                {
                    try
                    {
                        Business.BouteillesController.ModifierBouteille(idBouteille, Convert.ToInt32(cbxFlaconnageBouteille.SelectedValue), Convert.ToInt32(cbxChateauBouteille.SelectedValue), Convert.ToInt32(cbxCouleurBouteille.SelectedValue), int.Parse(ipnMillesimeBouteille.Value.ToString()), float.Parse(iptPrixBasBouteille.Text), float.Parse(iptPrixHautBouteille.Text));

                        dataGridView1.DataSource = Business.BouteillesController.listBouteillesFull();
                        switchModeTo("Insertion");
                        viderChamps();
                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); }
                }
                else if (mode6 == "I")
                {
                    try
                    {
                        Business.BouteillesController.AjouterBouteille(Convert.ToInt32(cbxFlaconnageBouteille.SelectedValue), Convert.ToInt32(cbxChateauBouteille.SelectedValue), Convert.ToInt32(cbxCouleurBouteille.SelectedValue), int.Parse(ipnMillesimeBouteille.Value.ToString()), float.Parse(iptPrixBasBouteille.Text), float.Parse(iptPrixHautBouteille.Text));
                        dataGridView1.DataSource = Business.BouteillesController.listBouteillesFull();
                        viderChamps();
                    }
                    catch (DataException ex)
                    { MessageBox.Show("Une erreur est survenue lors de l'enregistrement des données.\n\nPour plus d'informations sur l'erreur, reportez-vous au détail de l'exception levée ci-dessous :\n\n" + ex.InnerException.InnerException.Message, "Impossible d'ajouter l'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Tools.ouvrirForm("WelcomeScreen", this.MdiParent);
        }
    }
}
