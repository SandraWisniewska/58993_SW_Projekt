using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _58993_SW_Projekt
{
    public partial class Sort_UC : UserControl
    {
        private SortowanieTablicy Sortowanie;
        public Sort_UC()
        {
            this.Sortowanie = new SortowanieTablicy();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validate it!!
            string arrayInString = this.SW_58993_textBox1.Text;
            int[] arrayToSort = Array.ConvertAll<string, int>(arrayInString.Split(','), Convert.ToInt32);


            if (this.SW_58993_radioBubble.Checked == true)
            {

                SortowanieTablicy.SortInfo sortInfo = this.Sortowanie.BubbleSort(arrayToSort);
                this.SW_58993_textBox2.Text = string.Join(",", sortInfo.sortedArray);
                this.SW_58993_label4.Text = sortInfo.numberOfSortOperations.ToString();

                this.SW_58993_textBox2.Visible = true;
                this.SW_58993_label2.Visible = true;
                this.SW_58993_label3.Visible = true;
                this.SW_58993_label4.Visible = true;
            }
            else if (this.SW_58993_radioQuick.Checked == true)
            {
                SortowanieTablicy.SortInfo sortInfo = this.Sortowanie.InsertionSort(arrayToSort);
                this.SW_58993_textBox2.Text = string.Join(",", sortInfo.sortedArray);
                this.SW_58993_label4.Text = sortInfo.numberOfSortOperations.ToString();

                this.SW_58993_textBox2.Visible = true;
                this.SW_58993_label3.Visible = true;
                this.SW_58993_label4.Visible = true;
            }
        }
    }
}
