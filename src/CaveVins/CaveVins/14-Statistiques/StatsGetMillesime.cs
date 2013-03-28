using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CaveVins
{
    public partial class StatsGetMillesime : Form
    {
        public StatsGetMillesime()
        {
            InitializeComponent();
        }

        public string ReturnValue1 { get; set; }

        public int HResult { get; protected set; }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            this.ReturnValue1 = this.iptAnnee.Value.ToString();
        }
    }
}
