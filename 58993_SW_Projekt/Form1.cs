using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _58993_SW_Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //zdarzenie następujące po kliknieciu opcji w menu
        //do pokazania algorytmu matematycznego
        private void algorytmMatematycznyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUC(new Math_UC());
        }

        //zdarzenie następujące po kliknieciu opcji w menu
        //do pokazania algorytmu sortującego
        private void algorytmSortujacyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUC(new Sort_UC());
        }

        //zdarzenie następujące po kliknieciu opcji w menu
        //do pokazania algorytmu kompresującego
        private void algorytmKompresujacyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showUC(new Compress_UC());
        }

        //funkcja służąca do ustawiania user controlki na pierwszym planie
        private void showUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            //usuń kontrolki z widoku
            panel1.Controls.Clear();
            //dodaj kontrolke do widoku
            panel1.Controls.Add(uc);
            //ustaw kontrolke na froncie
            uc.BringToFront();
        }
    }
}
