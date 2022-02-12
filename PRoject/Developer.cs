using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRoject
{
    public partial class Developer : Form
    {
        public Developer()
        {
            InitializeComponent();
        }

        private void Developer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_PC form_Mother = new Form_PC();
            form_Mother.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Mother form_Mother = new Form_Mother();
            form_Mother.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_SSD form_SSD = new Form_SSD();
            form_SSD.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_HDD form_HDD = new Form_HDD();
            form_HDD.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Corpus form_Corpus = new Form_Corpus();
            form_Corpus.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form_CPU form2 = new Form_CPU();
            form2.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form_Videocard form_Videocard = new Form_Videocard();
            form_Videocard.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form_PSU form_PSU = new Form_PSU();
            form_PSU.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form_System_cold _Cold = new Form_System_cold();
            _Cold.ShowDialog();
        }
    }
}
