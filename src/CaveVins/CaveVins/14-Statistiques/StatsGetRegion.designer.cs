namespace CaveVins
{
    partial class StatsGetRegion
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbxPays = new System.Windows.Forms.ComboBox();
            this.lbxRegion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pays";
            // 
            // lbxPays
            // 
            this.lbxPays.FormattingEnabled = true;
            this.lbxPays.Location = new System.Drawing.Point(68, 30);
            this.lbxPays.Name = "lbxPays";
            this.lbxPays.Size = new System.Drawing.Size(171, 21);
            this.lbxPays.TabIndex = 5;
            this.lbxPays.Text = "Sélectionnez un pays";
            this.lbxPays.SelectionChangeCommitted += new System.EventHandler(this.lbxPays_SelectionChangeCommitted);
            // 
            // lbxRegion
            // 
            this.lbxRegion.Enabled = false;
            this.lbxRegion.FormattingEnabled = true;
            this.lbxRegion.Location = new System.Drawing.Point(68, 69);
            this.lbxRegion.Name = "lbxRegion";
            this.lbxRegion.Size = new System.Drawing.Size(171, 21);
            this.lbxRegion.TabIndex = 7;
            this.lbxRegion.Text = "Sélectionnez d\'abord un pays";
            this.lbxRegion.SelectionChangeCommitted += new System.EventHandler(this.lbxRegion_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Région";
            // 
            // StatsGetRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 132);
            this.Controls.Add(this.lbxRegion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxPays);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StatsGetRegion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quelle région ?";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.StatsGetRegion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lbxPays;
        private System.Windows.Forms.ComboBox lbxRegion;
        private System.Windows.Forms.Label label2;
    }
}