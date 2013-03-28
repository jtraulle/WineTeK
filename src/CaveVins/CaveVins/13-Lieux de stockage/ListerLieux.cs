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
    public partial class ListerLieux : Form
    {
        public ListerLieux()
        {
            InitializeComponent();
        }

        private void InventaireListe_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
    
            dataGridView1.DataSource = Business.LieuxController.listLieux();
            dataGridView1.AutoResizeColumns();
            dataGridView1.Focus();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Nom du lieu";
            dataGridView1.Columns[2].HeaderText = "Type de lieu";
            dataGridView1.Columns[3].HeaderText = "Nombre d'emplacements horizontaux";
            dataGridView1.Columns[3].MinimumWidth = 90;
            dataGridView1.Columns[4].HeaderText = "Nombre d'emplacements verticaux";
            dataGridView1.Columns[4].MinimumWidth = 90;
            dataGridView1.Columns[5].HeaderText = "Nombre de bouteilles par ligne par emplacement";
            dataGridView1.Columns[5].MinimumWidth = 90;
            dataGridView1.Columns[6].HeaderText = "Nombre de lignes de bouteilles par emplacement";
            dataGridView1.Columns[6].MinimumWidth = 90;
            dataGridView1.Columns[7].HeaderText = "Nombre de bouteilles par emplacement";
            dataGridView1.Columns[7].MinimumWidth = 85;

            Cursor = Cursors.Arrow;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (index != -1)
            {
                String titre = dataGridView1.Rows[index].Cells[1].Value.ToString();
                String typelieu = dataGridView1.Rows[index].Cells[2].Value.ToString();
                int idlieu = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                int X = int.Parse(dataGridView1.Rows[index].Cells[3].Value.ToString());
                int Y = int.Parse(dataGridView1.Rows[index].Cells[4].Value.ToString());
                int eX = int.Parse(dataGridView1.Rows[index].Cells[5].Value.ToString());
                int eY = int.Parse(dataGridView1.Rows[index].Cells[6].Value.ToString());

                Form mdiparent = this.MdiParent;
                this.Close();

                Form newMDIChild;

                if(typelieu.Trim() == "Stockage unitaire")
                    newMDIChild = new AfficherLieuStoU(idlieu);
                else
                    newMDIChild = new AfficherLieu(idlieu); 
                
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
            Tools.ouvrirForm("AjouterLieu", this.MdiParent);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Tools.ouvrirForm("WelcomeScreen", this.MdiParent);
        }
    }
}
