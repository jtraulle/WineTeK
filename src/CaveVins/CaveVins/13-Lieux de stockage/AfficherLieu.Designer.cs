﻿namespace CaveVins
{
    partial class AfficherLieu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel43 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRetirerDuStock = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel43.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Menu;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 11);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(55, 9);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel43
            // 
            this.panel43.AutoScroll = true;
            this.panel43.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel43.Controls.Add(this.tableLayoutPanel1);
            this.panel43.Controls.Add(this.label2);
            this.panel43.Location = new System.Drawing.Point(12, 110);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(764, 411);
            this.panel43.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::CaveVins.Properties.Resources.sablier_icone_8810_32;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(255, 181);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(245, 38);
            this.label2.TabIndex = 28;
            this.label2.Text = "Chargement, veuillez patienter ...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnRetirerDuStock);
            this.panel1.Controls.Add(this.btnRetour);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 50);
            this.panel1.TabIndex = 27;
            // 
            // btnRetirerDuStock
            // 
            this.btnRetirerDuStock.Image = global::CaveVins.Properties.Resources.icon_delete;
            this.btnRetirerDuStock.Location = new System.Drawing.Point(540, 11);
            this.btnRetirerDuStock.Name = "btnRetirerDuStock";
            this.btnRetirerDuStock.Size = new System.Drawing.Size(191, 30);
            this.btnRetirerDuStock.TabIndex = 20;
            this.btnRetirerDuStock.Text = "Retirer des bouteilles du stock";
            this.btnRetirerDuStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRetirerDuStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRetirerDuStock.UseVisualStyleBackColor = true;
            this.btnRetirerDuStock.Click += new System.EventHandler(this.btnRetirerDuStock_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Image = global::CaveVins.Properties.Resources.arrow_undo;
            this.btnRetour.Location = new System.Drawing.Point(737, 11);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(39, 30);
            this.btnRetour.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnRetour, "Retour à la liste des lieux");
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(217, 7);
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
            this.label1.Size = new System.Drawing.Size(186, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Visualiser un lieu de stockage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(10, 38);
            this.label4.TabIndex = 29;
            // 
            // AfficherLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 533);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel43);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AfficherLieu";
            this.Text = "AfficherLieu";
            this.Load += new System.EventHandler(this.AfficherLieu_Load);
            this.Shown += new System.EventHandler(this.GererDonnees_Shown);
            this.panel43.ResumeLayout(false);
            this.panel43.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRetirerDuStock;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}