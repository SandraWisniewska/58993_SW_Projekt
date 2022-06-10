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
    public partial class SW_58993_Form1 : Form
    {
        public SW_58993_Form1()
        {
            InitializeComponent();
        }

        //zdarzenie następujące po kliknieciu opcji w menu
        //do pokazania algorytmu matematycznego
        private void SW_58993_algorytmMatematycznyToolStripMenuItem_Click(object SW_58993_sender, EventArgs SW_58993_e)
        {
            SW_58993_showUC(new SW_58993_Math_UC());
        }

        //zdarzenie następujące po kliknieciu opcji w menu
        //do pokazania algorytmu sortującego
        private void SW_58993_algorytmSortujacyToolStripMenuItem_Click(object SW_58993_sender, EventArgs SW_58993_e)
        {
            SW_58993_showUC(new SW_58993_Sort_UC());
        }

        //zdarzenie następujące po kliknieciu opcji w menu
        //do pokazania algorytmu kompresującego
        private void SW_58993_algorytmKompresujacyToolStripMenuItem_Click(object SW_58993_sender, EventArgs SW_58993_e)
        {
            SW_58993_showUC(new SW_58993_Compress_UC());
        }

        //funkcja służąca do ustawiania user controlki na pierwszym planie
        private void SW_58993_showUC(UserControl SW_58993_uc)
        {
            SW_58993_uc.Dock = DockStyle.Fill;
            //usuń kontrolki z widoku
            SW_58993_panel1.Controls.Clear();
            //dodaj kontrolke do widoku
            SW_58993_panel1.Controls.Add(SW_58993_uc);
            //ustaw kontrolke na froncie
            SW_58993_uc.BringToFront();
        }
    }
}
