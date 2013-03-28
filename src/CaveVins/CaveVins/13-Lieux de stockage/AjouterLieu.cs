using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CaveVins
{
    public partial class AjouterLieu : Form
    {
        public AjouterLieu()
        {
            InitializeComponent();
        }

        private void AjouterLieu_Load(object sender, EventArgs e)
        {
            lbxType.SelectedIndex = 0;
        }

        private void lbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxType.SelectedIndex == 0)
            {
                //test
                ipnX.Value = 1;
                ipnY.Value = 1;
                ipnEX0.Value = 2;
                
                lblEX1.Visible = true;
                iptEX1.Text = "1";
                iptEX1.Visible = true;

                ipnEY.Minimum = 2;
                ipnEY.Value = 2;
                ipnEY.Enabled = true;
            }
            else
            {
                lblEX1.Visible = false;
                iptEX1.Text = "1";
                iptEX1.Visible = false;

                ipnX.Value = 1;
                ipnY.Value = 1;
                ipnEX0.Value = 2;

                ipnEY.Minimum = 1;
                ipnEY.Value = 1;
                ipnEY.Enabled = false;
            }
        }

        private int calculNbEmplacements()
        {
            return int.Parse(ipnX.Value.ToString()) * int.Parse(ipnY.Value.ToString());
        }

        private int calculNbBouteilles()
        {
            return int.Parse(ipnX.Value.ToString()) * int.Parse(ipnY.Value.ToString()) * int.Parse(iptZ.Text);
        }


        private int calculZ()
        {
            int nbRangeesPaires = qteNbPaire(int.Parse(ipnEY.Value.ToString()));
            int nbRangeesImpaires = qteNbImpaire(int.Parse(ipnEY.Value.ToString()));

            return (nbRangeesImpaires * int.Parse(ipnEX0.Value.ToString())) + (nbRangeesPaires * int.Parse(iptEX1.Text.ToString()));
        }

        private int qteNbPaire(int nb)
        {
            int compteur = 0;
            if(nb > 0)
            {
                int i;
                for (i = 1; i <= nb; i++)
                {
                    if (i % 2 == 0) compteur += 1;
                }
            }
            return compteur;
        }

        private int qteNbImpaire(int nb){
            int compteur = 0;
            if (nb > 0)
            {
                int i;
                for (i = 1; i <= nb; i++)
                {
                    if (i % 2 != 0) compteur += 1;
                }
            }
            return compteur;
        }

        private void ipnEX0_ValueChanged(object sender, EventArgs e)
        {
            iptEX1.Text = (ipnEX0.Value - 1).ToString();
            iptZ.Text = calculZ().ToString();
            iptNbBouteilles.Text = calculNbBouteilles().ToString();
        }

        private void ipnEY_ValueChanged(object sender, EventArgs e)
        {
            iptZ.Text = calculZ().ToString();
            iptNbBouteilles.Text = calculNbBouteilles().ToString();
        }

        private void ipnX_ValueChanged(object sender, EventArgs e)
        {
            iptNbEmplacements.Text = calculNbEmplacements().ToString();
            iptNbBouteilles.Text = calculNbBouteilles().ToString();
        }

        private void ipnY_ValueChanged(object sender, EventArgs e)
        {
            iptNbEmplacements.Text = calculNbEmplacements().ToString();
            iptNbBouteilles.Text = calculNbBouteilles().ToString();
        }

        private void btnAjouterLieu_Click(object sender, EventArgs e)
        {
            Boolean canAdd = true;

            if (iptNom.Text == "")
            {
                canAdd = false;
                MessageBox.Show("Vous devez renseigner un nom pour le nouveau lieu !", "Saisie incomplète", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string type;
            if(lbxType.SelectedIndex == 0)
                type = "M";
            else
                type = "U";

            if (canAdd == true)
            {
                String titre = iptNom.Text;
                int X = int.Parse(ipnX.Value.ToString());
                int Y = int.Parse(ipnY.Value.ToString());
                int eX = int.Parse(ipnEX0.Value.ToString());
                int eY = int.Parse(ipnEY.Value.ToString());
                int Z = int.Parse(iptZ.Text);

                Business.LieuxController.addLieu(titre, type, X, Y, eX, eY, Z);

                DialogResult result = MessageBox.Show("Le lieu a été correctement ajouté.\nAller à la liste des lieux ?", "Lieu ajouté", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Tools.ouvrirForm("ListerLieux", this.MdiParent);
                } 
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Tools.ouvrirForm("WelcomeScreen", this.MdiParent);
        }
    }
}
