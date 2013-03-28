namespace CaveVins
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gérerLaBaseDeDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gererToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLesBouteillesDansLinventaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lieuxDeStockageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnLieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerLesLieuxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nbDeBouteillesDuneAnnéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nbDeBouteillesDuneRégionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nbDeBouteillesDuneAppellationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nbDeBouteillesDunChâteauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterUneSauvegardeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerUneSauvegardeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réinitialiserLaBaseDeDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLaBaseDeDonnéesToolStripMenuItem,
            this.inventaireToolStripMenuItem,
            this.lieuxDeStockageToolStripMenuItem,
            this.statistiquesToolStripMenuItem,
            this.aideToolStripMenuItem,
            this.outilsToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gérerLaBaseDeDonnéesToolStripMenuItem
            // 
            this.gérerLaBaseDeDonnéesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gererToolStripMenuItem,
            this.chercherToolStripMenuItem});
            this.gérerLaBaseDeDonnéesToolStripMenuItem.Image = global::CaveVins.Properties.Resources.database;
            this.gérerLaBaseDeDonnéesToolStripMenuItem.Name = "gérerLaBaseDeDonnéesToolStripMenuItem";
            this.gérerLaBaseDeDonnéesToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.gérerLaBaseDeDonnéesToolStripMenuItem.Text = "Base de &référence";
            // 
            // gererToolStripMenuItem
            // 
            this.gererToolStripMenuItem.Image = global::CaveVins.Properties.Resources.application_view_columns;
            this.gererToolStripMenuItem.Name = "gererToolStripMenuItem";
            this.gererToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.gererToolStripMenuItem.Text = "Gérer données";
            this.gererToolStripMenuItem.Click += new System.EventHandler(this.gererToolStripMenuItem_Click);
            // 
            // chercherToolStripMenuItem
            // 
            this.chercherToolStripMenuItem.Image = global::CaveVins.Properties.Resources.find;
            this.chercherToolStripMenuItem.Name = "chercherToolStripMenuItem";
            this.chercherToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.chercherToolStripMenuItem.Text = "Chercher";
            this.chercherToolStripMenuItem.Click += new System.EventHandler(this.chercherToolStripMenuItem_Click);
            // 
            // inventaireToolStripMenuItem
            // 
            this.inventaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirLesBouteillesDansLinventaireToolStripMenuItem});
            this.inventaireToolStripMenuItem.Image = global::CaveVins.Properties.Resources.basket1;
            this.inventaireToolStripMenuItem.Name = "inventaireToolStripMenuItem";
            this.inventaireToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.inventaireToolStripMenuItem.Text = "&Inventaire";
            // 
            // voirLesBouteillesDansLinventaireToolStripMenuItem
            // 
            this.voirLesBouteillesDansLinventaireToolStripMenuItem.Image = global::CaveVins.Properties.Resources.basket_go;
            this.voirLesBouteillesDansLinventaireToolStripMenuItem.Name = "voirLesBouteillesDansLinventaireToolStripMenuItem";
            this.voirLesBouteillesDansLinventaireToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.voirLesBouteillesDansLinventaireToolStripMenuItem.Text = "Afficher les bouteilles dans l\'inventaire";
            this.voirLesBouteillesDansLinventaireToolStripMenuItem.Click += new System.EventHandler(this.voirLesBouteillesDansLinventaireToolStripMenuItem_Click);
            // 
            // lieuxDeStockageToolStripMenuItem
            // 
            this.lieuxDeStockageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnLieuToolStripMenuItem,
            this.listerLesLieuxToolStripMenuItem});
            this.lieuxDeStockageToolStripMenuItem.Image = global::CaveVins.Properties.Resources.box;
            this.lieuxDeStockageToolStripMenuItem.Name = "lieuxDeStockageToolStripMenuItem";
            this.lieuxDeStockageToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.lieuxDeStockageToolStripMenuItem.Text = "Lieux de &stockage";
            // 
            // ajouterUnLieuToolStripMenuItem
            // 
            this.ajouterUnLieuToolStripMenuItem.Image = global::CaveVins.Properties.Resources.add;
            this.ajouterUnLieuToolStripMenuItem.Name = "ajouterUnLieuToolStripMenuItem";
            this.ajouterUnLieuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajouterUnLieuToolStripMenuItem.Text = "Ajouter un lieu";
            this.ajouterUnLieuToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnLieuToolStripMenuItem_Click);
            // 
            // listerLesLieuxToolStripMenuItem
            // 
            this.listerLesLieuxToolStripMenuItem.Image = global::CaveVins.Properties.Resources.application_view_list1;
            this.listerLesLieuxToolStripMenuItem.Name = "listerLesLieuxToolStripMenuItem";
            this.listerLesLieuxToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listerLesLieuxToolStripMenuItem.Text = "Lister les lieux";
            this.listerLesLieuxToolStripMenuItem.Click += new System.EventHandler(this.listerLesLieuxToolStripMenuItem_Click);
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nbDeBouteillesDuneAnnéeToolStripMenuItem,
            this.nbDeBouteillesDuneRégionToolStripMenuItem,
            this.nbDeBouteillesDuneAppellationToolStripMenuItem,
            this.nbDeBouteillesDunChâteauToolStripMenuItem});
            this.statistiquesToolStripMenuItem.Image = global::CaveVins.Properties.Resources.chart_bar;
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            // 
            // nbDeBouteillesDuneAnnéeToolStripMenuItem
            // 
            this.nbDeBouteillesDuneAnnéeToolStripMenuItem.Image = global::CaveVins.Properties.Resources.bullet_red;
            this.nbDeBouteillesDuneAnnéeToolStripMenuItem.Name = "nbDeBouteillesDuneAnnéeToolStripMenuItem";
            this.nbDeBouteillesDuneAnnéeToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.nbDeBouteillesDuneAnnéeToolStripMenuItem.Text = "Nb de bouteilles d\'une année";
            this.nbDeBouteillesDuneAnnéeToolStripMenuItem.Click += new System.EventHandler(this.nbDeBouteillesDuneAnnéeToolStripMenuItem_Click);
            // 
            // nbDeBouteillesDuneRégionToolStripMenuItem
            // 
            this.nbDeBouteillesDuneRégionToolStripMenuItem.Image = global::CaveVins.Properties.Resources.bullet_pink;
            this.nbDeBouteillesDuneRégionToolStripMenuItem.Name = "nbDeBouteillesDuneRégionToolStripMenuItem";
            this.nbDeBouteillesDuneRégionToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.nbDeBouteillesDuneRégionToolStripMenuItem.Text = "Nb de bouteilles d\'une région";
            this.nbDeBouteillesDuneRégionToolStripMenuItem.Click += new System.EventHandler(this.nbDeBouteillesDuneRégionToolStripMenuItem_Click);
            // 
            // nbDeBouteillesDuneAppellationToolStripMenuItem
            // 
            this.nbDeBouteillesDuneAppellationToolStripMenuItem.Image = global::CaveVins.Properties.Resources.bullet_orange;
            this.nbDeBouteillesDuneAppellationToolStripMenuItem.Name = "nbDeBouteillesDuneAppellationToolStripMenuItem";
            this.nbDeBouteillesDuneAppellationToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.nbDeBouteillesDuneAppellationToolStripMenuItem.Text = "Nb de bouteilles d\'une appellation";
            this.nbDeBouteillesDuneAppellationToolStripMenuItem.Click += new System.EventHandler(this.nbDeBouteillesDuneAppellationToolStripMenuItem_Click);
            // 
            // nbDeBouteillesDunChâteauToolStripMenuItem
            // 
            this.nbDeBouteillesDunChâteauToolStripMenuItem.Image = global::CaveVins.Properties.Resources.bullet_yellow;
            this.nbDeBouteillesDunChâteauToolStripMenuItem.Name = "nbDeBouteillesDunChâteauToolStripMenuItem";
            this.nbDeBouteillesDunChâteauToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.nbDeBouteillesDunChâteauToolStripMenuItem.Text = "Nb de bouteilles d\'un château";
            this.nbDeBouteillesDunChâteauToolStripMenuItem.Click += new System.EventHandler(this.nbDeBouteillesDunChâteauToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.aideToolStripMenuItem.Image = global::CaveVins.Properties.Resources.help;
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.aideToolStripMenuItem.Text = "&Aide";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Image = global::CaveVins.Properties.Resources.information;
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exporterUneSauvegardeToolStripMenuItem,
            this.importerUneSauvegardeToolStripMenuItem,
            this.réinitialiserLaBaseDeDonnéesToolStripMenuItem});
            this.outilsToolStripMenuItem.Image = global::CaveVins.Properties.Resources.wrench;
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.outilsToolStripMenuItem.Text = "Outils";
            // 
            // exporterUneSauvegardeToolStripMenuItem
            // 
            this.exporterUneSauvegardeToolStripMenuItem.Image = global::CaveVins.Properties.Resources.database_save;
            this.exporterUneSauvegardeToolStripMenuItem.Name = "exporterUneSauvegardeToolStripMenuItem";
            this.exporterUneSauvegardeToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.exporterUneSauvegardeToolStripMenuItem.Text = "Effectuer une copie de sauvegarde";
            this.exporterUneSauvegardeToolStripMenuItem.Click += new System.EventHandler(this.exporterUneSauvegardeToolStripMenuItem_Click);
            // 
            // importerUneSauvegardeToolStripMenuItem
            // 
            this.importerUneSauvegardeToolStripMenuItem.Image = global::CaveVins.Properties.Resources.database_go;
            this.importerUneSauvegardeToolStripMenuItem.Name = "importerUneSauvegardeToolStripMenuItem";
            this.importerUneSauvegardeToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.importerUneSauvegardeToolStripMenuItem.Text = "Restaurer une copie de sauvegarde";
            this.importerUneSauvegardeToolStripMenuItem.Click += new System.EventHandler(this.importerUneSauvegardeToolStripMenuItem_Click);
            // 
            // réinitialiserLaBaseDeDonnéesToolStripMenuItem
            // 
            this.réinitialiserLaBaseDeDonnéesToolStripMenuItem.Image = global::CaveVins.Properties.Resources.pill;
            this.réinitialiserLaBaseDeDonnéesToolStripMenuItem.Name = "réinitialiserLaBaseDeDonnéesToolStripMenuItem";
            this.réinitialiserLaBaseDeDonnéesToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.réinitialiserLaBaseDeDonnéesToolStripMenuItem.Text = "Réinitialiser la base de données";
            this.réinitialiserLaBaseDeDonnéesToolStripMenuItem.Click += new System.EventHandler(this.réinitialiserLaBaseDeDonnéesToolStripMenuItem_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 562);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(792, 22);
            this.statusBar1.TabIndex = 12;
            this.statusBar1.Text = "v 1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 584);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WineTeK - Gestion de cave à vin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lieuxDeStockageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirLesBouteillesDansLinventaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nbDeBouteillesDuneAnnéeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nbDeBouteillesDuneRégionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nbDeBouteillesDuneAppellationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nbDeBouteillesDunChâteauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLaBaseDeDonnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gererToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chercherToolStripMenuItem;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnLieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterUneSauvegardeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerUneSauvegardeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réinitialiserLaBaseDeDonnéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerLesLieuxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
    }
}

