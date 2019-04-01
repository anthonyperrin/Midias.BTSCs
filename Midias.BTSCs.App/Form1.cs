using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midias.BTSCs.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            homeUC.Show();

        }

        private void ProduitsBtn_Click(object sender, EventArgs e)
        {
            homeUC.Show();
        }

        private void SalariesBtn_Click(object sender, EventArgs e)
        {
            homeUC.Hide();
        }

        private void VehiculesBtn_Click(object sender, EventArgs e)
        {
            homeUC.Hide();
        }
    }
}
