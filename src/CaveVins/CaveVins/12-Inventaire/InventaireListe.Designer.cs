namespace CaveVins
{
    partial class InventaireListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierLeNombreDeBouteillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerCetteRéférenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStocker = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.panel43 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel43.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(764, 436);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierLeNombreDeBouteillesToolStripMenuItem,
            this.supprimerCetteRéférenceToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(247, 48);
            // 
            // modifierLeNombreDeBouteillesToolStripMenuItem
            // 
            this.modifierLeNombreDeBouteillesToolStripMenuItem.Image = global::CaveVins.Properties.Resources.icon_edit;
            this.modifierLeNombreDeBouteillesToolStripMenuItem.Name = "modifierLeNombreDeBouteillesToolStripMenuItem";
            this.modifierLeNombreDeBouteillesToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.modifierLeNombreDeBouteillesToolStripMenuItem.Text = "Modifier le nombre de bouteilles";
            this.modifierLeNombreDeBouteillesToolStripMenuItem.Click += new System.EventHandler(this.modifierLeNombreDeBouteillesToolStripMenuItem_Click);
            // 
            // supprimerCetteRéférenceToolStripMenuItem
            // 
            this.supprimerCetteRéférenceToolStripMenuItem.Image = global::CaveVins.Properties.Resources.icon_delete;
            this.supprimerCetteRéférenceToolStripMenuItem.Name = "supprimerCetteRéférenceToolStripMenuItem";
            this.supprimerCetteRéférenceToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.supprimerCetteRéférenceToolStripMenuItem.Text = "Supprimer cette référence";
            this.supprimerCetteRéférenceToolStripMenuItem.Click += new System.EventHandler(this.supprimerCetteRéférenceToolStripMenuItem_Click);
            // 
            // btnStocker
            // 
            this.btnStocker.Image = global::CaveVins.Properties.Resources.box;
            this.btnStocker.Location = new System.Drawing.Point(451, 5);
            this.btnStocker.Name = "btnStocker";
            this.btnStocker.Size = new System.Drawing.Size(67, 40);
            this.btnStocker.TabIndex = 19;
            this.btnStocker.Text = "&Stocker";
            this.btnStocker.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStocker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStocker.UseVisualStyleBackColor = true;
            this.btnStocker.Click += new System.EventHandler(this.btnStocker_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Image = global::CaveVins.Properties.Resources.basket_add;
            this.btnAjouter.Location = new System.Drawing.Point(670, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(54, 40);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Image = global::CaveVins.Properties.Resources.basket_edit;
            this.btnModifier.Location = new System.Drawing.Point(608, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(61, 40);
            this.btnModifier.TabIndex = 14;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Image = global::CaveVins.Properties.Resources.basket_delete;
            this.btnSupprimer.Location = new System.Drawing.Point(541, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(66, 40);
            this.btnSupprimer.TabIndex = 13;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // panel43
            // 
            this.panel43.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel43.Controls.Add(this.btnRetour);
            this.panel43.Controls.Add(this.label2);
            this.panel43.Controls.Add(this.label4);
            this.panel43.Controls.Add(this.btnStocker);
            this.panel43.Controls.Add(this.btnModifier);
            this.panel43.Controls.Add(this.btnSupprimer);
            this.panel43.Controls.Add(this.btnAjouter);
            this.panel43.Location = new System.Drawing.Point(0, 0);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(788, 50);
            this.panel43.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(138, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 34);
            this.label2.TabIndex = 19;
            this.label2.Text = "L\'inventaire permet de garder en mémoire \r\ndes bouteilles possédées mais non stoc" +
    "kées.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Afficher l\'inventaire";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.Location = new System.Drawing.Point(11, 64);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(344, 13);
            this.lblStats.TabIndex = 29;
            this.lblStats.Text = "Votre inventaire contient xxx références (pour un total de xxx bouteilles)";
            // 
            // btnRetour
            // 
            this.btnRetour.Image = global::CaveVins.Properties.Resources.arrow_undo;
            this.btnRetour.Location = new System.Drawing.Point(737, 5);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(39, 40);
            this.btnRetour.TabIndex = 20;
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // InventaireListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 533);
            this.ControlBox = false;
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.panel43);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventaireListe";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Afficher l\'inventaire";
            this.Load += new System.EventHandler(this.InventaireListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel43.ResumeLayout(false);
            this.panel43.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierLeNombreDeBouteillesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerCetteRéférenceToolStripMenuItem;
        private System.Windows.Forms.Button btnStocker;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnRetour;
    }
}