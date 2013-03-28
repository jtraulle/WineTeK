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
    public partial class Combien : Form
    {
        public Combien()
        {
            InitializeComponent();
        }

        public string ReturnValue1 { get; set; }

        public void setLabel(String Title) {
            label1.Text = Title; 
        }

        public void setMin(Decimal Min)
        {
            numericUpDown1.Minimum = Min;
        }

        public void setMax(Decimal Max)
        {
            numericUpDown1.Maximum = Max;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ReturnValue1 = this.numericUpDown1.Value.ToString();
        }
    }
}
