namespace CaveVins
{
    partial class StatsGetMillesime
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
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.iptAnnee = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.iptAnnee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Année";
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAjouter.Location = new System.Drawing.Point(27, 76);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(212, 23);
            this.BtnAjouter.TabIndex = 4;
            this.BtnAjouter.Text = "Afficher les statistiques pour cette année";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // iptAnnee
            // 
            this.iptAnnee.Location = new System.Drawing.Point(94, 31);
            this.iptAnnee.Maximum = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            this.iptAnnee.Minimum = new decimal(new int[] {
            1400,
            0,
            0,
            0});
            this.iptAnnee.Name = "iptAnnee";
            this.iptAnnee.Size = new System.Drawing.Size(63, 20);
            this.iptAnnee.TabIndex = 5;
            this.iptAnnee.Value = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            // 
            // StatsGetMillesime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 132);
            this.Controls.Add(this.iptAnnee);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StatsGetMillesime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quelle année ?";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.iptAnnee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.NumericUpDown iptAnnee;
    }
}