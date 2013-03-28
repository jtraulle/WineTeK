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
    public partial class StatsGetChateau : Form
    {
        public StatsGetChateau()
        {
            InitializeComponent();
        }

        public int ReturnValue1 { get; set; }
        public string ReturnValue2 { get; set; }

        public int HResult { get; protected set; }

        private void StatsGetRegion_Load(object sender, EventArgs e)
        {
            lbxPays.DataSource = CaveVins.Business.PaysController.listPays();
            lbxPays.DisplayMember = "PAY_S_NOM";
            lbxPays.ValueMember = "PAY_C_CODE";

            lbxPays.Text = "Sélectionnez un pays";
            lbxRegion.Text = "Sélectionnez d'abord un pays";
            lbxRegion.Enabled = false;
        }

        private void lbxPays_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbxRegion.DataSource = Business.RegionsController.listRegionsFromPays(lbxPays.SelectedValue.ToString());
            lbxRegion.DisplayMember = "REG_S_NOM";
            lbxRegion.ValueMember = "REG_C_CODE";
            lbxRegion.Text = "Sélectionnez une région";
            lbxRegion.Enabled = true;
            lbxAppellation.Text = "Sélectionnez d'abord une région";
            lbxAppellation.Enabled = false;
        }

        private void lbxRegion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbxAppellation.DataSource = Business.AppellationsController.listAppellationsFromRegion(lbxRegion.SelectedValue.ToString());
            lbxAppellation.DisplayMember = "APT_S_NOM";
            lbxAppellation.ValueMember = "APT_I_ID";
            lbxAppellation.Text = "Sélectionnez une appellation";
            lbxAppellation.Enabled = true;
        }

        private void lbxAppellation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lbxChateau.DataSource = Business.ChateauController.listChateauxFromAppellation(int.Parse(lbxAppellation.SelectedValue.ToString()));
            lbxChateau.DisplayMember = "CHT_S_CHATEAU";
            lbxChateau.ValueMember = "CHT_I_ID";
            lbxChateau.Text = "Sélectionnez un château";
            lbxChateau.Enabled = true;
        }

        private void lbxChateau_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.ReturnValue1 = int.Parse(lbxChateau.SelectedValue.ToString());
            this.ReturnValue2 = lbxChateau.GetItemText(lbxChateau.SelectedItem);
            this.DialogResult = DialogResult.OK;
        }
    }
}
