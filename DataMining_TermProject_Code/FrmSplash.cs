using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMining_TermProject_Code
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
			timer1.Interval = 6000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
