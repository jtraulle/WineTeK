namespace CaveVins
{
    partial class ChoisirLieu
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(764, 453);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
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
            // 
            // supprimerCetteRéférenceToolStripMenuItem
            // 
            this.supprimerCetteRéférenceToolStripMenuItem.Image = global::CaveVins.Properties.Resources.icon_delete;
            this.supprimerCetteRéférenceToolStripMenuItem.Name = "supprimerCetteRéférenceToolStripMenuItem";
            this.supprimerCetteRéférenceToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.supprimerCetteRéférenceToolStripMenuItem.Text = "Supprimer cette référence";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Image = global::CaveVins.Properties.Resources.basket_add;
            this.btnAjouter.Location = new System.Drawing.Point(644, 10);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(131, 29);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "&Retour à l\'inventaire";
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 50);
            this.panel1.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(202, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 34);
            this.label3.TabIndex = 18;
            this.label3.Text = "Les lieux de stockage vous permettent de stocker\r\nles bouteilles de votre inventa" +
    "ire de manière définitive.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Choisir un lieu de stockage";
            // 
            // ChoisirLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 533);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoisirLieu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lister les lieux";
            this.Shown += new System.EventHandler(this.ChoisirLieu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierLeNombreDeBouteillesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerCetteRéférenceToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}