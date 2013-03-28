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
    public partial class StatsGetRegion : Form
    {
        public StatsGetRegion()
        {
            InitializeComponent();
        }

        public string ReturnValue1 { get; set; }
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
        }

        private void lbxRegion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.ReturnValue1 = lbxRegion.SelectedValue.ToString();
            this.ReturnValue2 = lbxRegion.GetItemText(lbxRegion.SelectedItem);
            this.DialogResult = DialogResult.OK;
        }
    }
}
