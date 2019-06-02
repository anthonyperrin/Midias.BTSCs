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
        private const int cGrip = 16;
        private const int cCaption = 32;

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);

        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = PointToClient(pos);
                //Drag la fenêtre
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                //Resize la fenêtre
                //if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                //{
                //    m.Result = (IntPtr)17;
                //    return;
                //}
            }
            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuBarPanel.Top = HomeBtn.Top;
            menuBarPanel.Height = HomeBtn.Height;
            homeUC.Show();
            vehiculeUC1.Hide();
            salarieUC.Hide();
            produitUC.Hide();
            clientUC.Hide();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            menuBarPanel.Top = HomeBtn.Top;
            homeUC.Show();
            vehiculeUC1.Hide();
            salarieUC.Hide();
            produitUC.Hide();
            clientUC.Hide();
        }

        private void ProduitsBtn_Click(object sender, EventArgs e)
        {
            menuBarPanel.Top = ProduitsBtn.Top;
            homeUC.Hide();
            vehiculeUC1.Hide();
            salarieUC.Hide();
            produitUC.Show();
            clientUC.Hide();
        }

        private void CommandeBtn_Click(object sender, EventArgs e)
        {
            menuBarPanel.Top = CommandeBtn.Top;
            homeUC.Hide();
            vehiculeUC1.Hide();
            produitUC.Hide();
            salarieUC.Hide();
            clientUC.Hide();
        }

        private void ClientsBtn_Click(object sender, EventArgs e)
        {
            menuBarPanel.Top = ClientsBtn.Top;
            homeUC.Hide();
            vehiculeUC1.Hide();
            produitUC.Hide();
            salarieUC.Hide();
            clientUC.Show();
        }

        private void SalariesBtn_Click(object sender, EventArgs e)
        {
            menuBarPanel.Top = SalariesBtn.Top;
            homeUC.Hide();
            vehiculeUC1.Hide();
            produitUC.Hide();
            salarieUC.Show();
            clientUC.Hide();
        }

        private void VehiculesBtn_Click(object sender, EventArgs e)
        {
            menuBarPanel.Top = VehiculesBtn.Top;
            homeUC.Hide();
            salarieUC.Hide();
            produitUC.Hide();
            vehiculeUC1.Show();
            clientUC.Hide();
        }

        /// <summary>
        /// Event for closing the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeAppBox_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        /// <summary>
        /// Minimize the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minimizeAppBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
