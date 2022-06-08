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

        private void algorytmMatematycznyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Math_UC math_UC = new Math_UC();
            math_UC.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(math_UC);
            math_UC.BringToFront();
        }

        private void algorytmSortujacyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sort_UC sort_Uc = new Sort_UC();
            sort_Uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(sort_Uc);
            sort_Uc.BringToFront();
        }

        private void algorytmKompresujacyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compress_UC compress_UC = new Compress_UC();
            compress_UC.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(compress_UC);
            compress_UC.BringToFront();
        }
    }
}
