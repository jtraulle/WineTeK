using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Deployment;

namespace CaveVins
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }


        public string AssemblyVersion
        {
            get
            {
                try
                {
                    return System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
                }
                catch
                {
                    return Assembly.GetExecutingAssembly().GetName().Version.ToString();
                }
            }
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            label2.Text = String.Format("v. {0}", AssemblyVersion);
        }
    }
}
