namespace CaveVins
{
    partial class RechercheBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RechercheBase));
            this.lblAppelation = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lbxAppellation = new System.Windows.Forms.ComboBox();
            this.lbxRegion = new System.Windows.Forms.ComboBox();
            this.lblPays = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterCetteRéférenceÀLinventaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbxPays = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnChercherNom = new System.Windows.Forms.Button();
            this.iptStartWith = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnChercher = new System.Windows.Forms.Button();
            this.lblChateau = new System.Windows.Forms.Label();
            this.btnAjoutInventaire = new System.Windows.Forms.Button();
            this.panel43 = new System.Windows.Forms.Panel();
            this.btnRetour = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel43.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAppelation
            // 
            this.lblAppelation.AutoSize = true;
            this.lblAppelation.Location = new System.Drawing.Point(457, 16);
            this.lblAppelation.Name = "lblAppelation";
            this.lblAppelation.Size = new System.Drawing.Size(59, 13);
            this.lblAppelation.TabIndex = 15;
            this.lblAppelation.Text = "Appellation";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(218, 16);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(41, 13);
            this.lblRegion.TabIndex = 14;
            this.lblRegion.Text = "Région";
            // 
            // lbxAppellation
            // 
            this.lbxAppellation.FormattingEnabled = true;
            this.lbxAppellation.Location = new System.Drawing.Point(522, 13);
            this.lbxAppellation.Name = "lbxAppellation";
            this.lbxAppellation.Size = new System.Drawing.Size(175, 21);
            this.lbxAppellation.TabIndex = 13;
            this.lbxAppellation.SelectionChangeCommitted += new System.EventHandler(this.lbxAppellation_SelectionChangeCommitted);
            // 
            // lbxRegion
            // 
            this.lbxRegion.FormattingEnabled = true;
            this.lbxRegion.Location = new System.Drawing.Point(265, 13);
            this.lbxRegion.Name = "lbxRegion";
            this.lbxRegion.Size = new System.Drawing.Size(162, 21);
            this.lbxRegion.TabIndex = 12;
            this.lbxRegion.SelectedIndexChanged += new System.EventHandler(this.lbxRegion_SelectedIndexChanged);
            this.lbxRegion.SelectionChangeCommitted += new System.EventHandler(this.lbxRegion_SelectionChangeCommitted);
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Location = new System.Drawing.Point(13, 16);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(30, 13);
            this.lblPays.TabIndex = 11;
            this.lblPays.Text = "Pays";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rechercher dans la base";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(764, 368);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterCetteRéférenceÀLinventaireToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(265, 26);
            // 
            // ajouterCetteRéférenceÀLinventaireToolStripMenuItem
            // 
            this.ajouterCetteRéférenceÀLinventaireToolStripMenuItem.Name = "ajouterCetteRéférenceÀLinventaireToolStripMenuItem";
            this.ajouterCetteRéférenceÀLinventaireToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.ajouterCetteRéférenceÀLinventaireToolStripMenuItem.Text = "Ajouter cette référence à l\'inventaire";
            // 
            // lbxPays
            // 
            this.lbxPays.FormattingEnabled = true;
            this.lbxPays.Location = new System.Drawing.Point(49, 13);
            this.lbxPays.Name = "lbxPays";
            this.lbxPays.Size = new System.Drawing.Size(137, 21);
            this.lbxPays.TabIndex = 8;
            this.lbxPays.SelectedIndexChanged += new System.EventHandler(this.lbxPays_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 72);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbxPays);
            this.tabPage1.Controls.Add(this.lblAppelation);
            this.tabPage1.Controls.Add(this.lblPays);
            this.tabPage1.Controls.Add(this.lblRegion);
            this.tabPage1.Controls.Add(this.lbxRegion);
            this.tabPage1.Controls.Add(this.lbxAppellation);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 46);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Recherche géographique";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnChercherNom);
            this.tabPage2.Controls.Add(this.iptStartWith);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 46);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recherche par nom";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnChercherNom
            // 
            this.btnChercherNom.Location = new System.Drawing.Point(321, 11);
            this.btnChercherNom.Name = "btnChercherNom";
            this.btnChercherNom.Size = new System.Drawing.Size(65, 23);
            this.btnChercherNom.TabIndex = 8;
            this.btnChercherNom.Text = "Chercher";
            this.btnChercherNom.UseVisualStyleBackColor = true;
            this.btnChercherNom.Click += new System.EventHandler(this.btnChercherNom_Click);
            // 
            // iptStartWith
            // 
            this.iptStartWith.Location = new System.Drawing.Point(180, 13);
            this.iptStartWith.Name = "iptStartWith";
            this.iptStartWith.Size = new System.Drawing.Size(135, 20);
            this.iptStartWith.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nom du château commençant par";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.numericUpDown1);
            this.tabPage3.Controls.Add(this.btnChercher);
            this.tabPage3.Controls.Add(this.lblChateau);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(756, 46);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Recherche par année";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(141, 14);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1472,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            // 
            // btnChercher
            // 
            this.btnChercher.Location = new System.Drawing.Point(193, 12);
            this.btnChercher.Name = "btnChercher";
            this.btnChercher.Size = new System.Drawing.Size(65, 23);
            this.btnChercher.TabIndex = 5;
            this.btnChercher.Text = "Chercher";
            this.btnChercher.UseVisualStyleBackColor = true;
            this.btnChercher.Click += new System.EventHandler(this.btnChercher_Click);
            // 
            // lblChateau
            // 
            this.lblChateau.AutoSize = true;
            this.lblChateau.Location = new System.Drawing.Point(6, 16);
            this.lblChateau.Name = "lblChateau";
            this.lblChateau.Size = new System.Drawing.Size(129, 13);
            this.lblChateau.TabIndex = 4;
            this.lblChateau.Text = "Millésime correspondant à";
            // 
            // btnAjoutInventaire
            // 
            this.btnAjoutInventaire.Image = global::CaveVins.Properties.Resources.basket_put;
            this.btnAjoutInventaire.Location = new System.Drawing.Point(550, 10);
            this.btnAjoutInventaire.Name = "btnAjoutInventaire";
            this.btnAjoutInventaire.Size = new System.Drawing.Size(183, 30);
            this.btnAjoutInventaire.TabIndex = 17;
            this.btnAjoutInventaire.Text = "Ajouter sélection à l\'inventaire";
            this.btnAjoutInventaire.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjoutInventaire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjoutInventaire.UseVisualStyleBackColor = true;
            this.btnAjoutInventaire.Click += new System.EventHandler(this.btnAjoutInventaire_Click);
            // 
            // panel43
            // 
            this.panel43.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel43.Controls.Add(this.btnRetour);
            this.panel43.Controls.Add(this.label3);
            this.panel43.Controls.Add(this.label1);
            this.panel43.Controls.Add(this.btnAjoutInventaire);
            this.panel43.Location = new System.Drawing.Point(0, 0);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(788, 50);
            this.panel43.TabIndex = 27;
            // 
            // btnRetour
            // 
            this.btnRetour.Image = global::CaveVins.Properties.Resources.arrow_undo;
            this.btnRetour.Location = new System.Drawing.Point(738, 10);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(39, 30);
            this.btnRetour.TabIndex = 21;
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(183, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 34);
            this.label3.TabIndex = 19;
            this.label3.Text = "Effectuez une recherche dans la base de référence \r\nde l\'application pour ajouter" +
    " des bouteilles à votre inventaire.";
            // 
            // RechercheBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 533);
            this.ControlBox = false;
            this.Controls.Add(this.panel43);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RechercheBase";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rechercher dans la base de données";
            this.Load += new System.EventHandler(this.RechercheBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel43.ResumeLayout(false);
            this.panel43.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAppelation;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ComboBox lbxAppellation;
        private System.Windows.Forms.ComboBox lbxRegion;
        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox lbxPays;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterCetteRéférenceÀLinventaireToolStripMenuItem;
        private System.Windows.Forms.Button btnChercherNom;
        private System.Windows.Forms.TextBox iptStartWith;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnChercher;
        private System.Windows.Forms.Label lblChateau;
        private System.Windows.Forms.Button btnAjoutInventaire;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRetour;
    }
}