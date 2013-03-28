namespace CaveVins
{
    partial class StatsGetAppellation
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
            this.lbxAppellation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pays";
            // 
            // lbxPays
            // 
            this.lbxPays.FormattingEnabled = true;
            this.lbxPays.Location = new System.Drawing.Point(95, 30);
            this.lbxPays.Name = "lbxPays";
            this.lbxPays.Size = new System.Drawing.Size(175, 21);
            this.lbxPays.TabIndex = 5;
            this.lbxPays.Text = "Sélectionnez un pays";
            this.lbxPays.SelectionChangeCommitted += new System.EventHandler(this.lbxPays_SelectionChangeCommitted);
            // 
            // lbxRegion
            // 
            this.lbxRegion.Enabled = false;
            this.lbxRegion.FormattingEnabled = true;
            this.lbxRegion.Location = new System.Drawing.Point(95, 69);
            this.lbxRegion.Name = "lbxRegion";
            this.lbxRegion.Size = new System.Drawing.Size(175, 21);
            this.lbxRegion.TabIndex = 7;
            this.lbxRegion.Text = "Sélectionnez d\'abord un pays";
            this.lbxRegion.SelectionChangeCommitted += new System.EventHandler(this.lbxRegion_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Région";
            // 
            // lbxAppellation
            // 
            this.lbxAppellation.Enabled = false;
            this.lbxAppellation.FormattingEnabled = true;
            this.lbxAppellation.Location = new System.Drawing.Point(96, 107);
            this.lbxAppellation.Name = "lbxAppellation";
            this.lbxAppellation.Size = new System.Drawing.Size(175, 21);
            this.lbxAppellation.TabIndex = 9;
            this.lbxAppellation.Text = "Sélectionnez d\'abord une région";
            this.lbxAppellation.SelectionChangeCommitted += new System.EventHandler(this.lbxAppellation_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Appellation";
            // 
            // StatsGetAppellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 164);
            this.Controls.Add(this.lbxAppellation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxRegion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxPays);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StatsGetAppellation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quelle appellation ?";
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
        private System.Windows.Forms.ComboBox lbxAppellation;
        private System.Windows.Forms.Label label3;
    }
}