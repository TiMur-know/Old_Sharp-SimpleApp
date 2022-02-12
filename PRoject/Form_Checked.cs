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
    public partial class Form_Checked : Form
    {
        public class Data{
            public static List<string> list;
        }
        
        public Form_Checked(string[] str)
        {
            InitializeComponent();
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(str);
        }
        public Form_Checked(string[] str,string chec)
        {
            InitializeComponent();
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.AddRange(str);
            string []checed = chec.Split(';');
            for(int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                for(int j = 0; j < checed.Length; j++)
                {
                    if (checkedListBox1.Items[i].ToString() == checed[j])
                    {
                        checkedListBox1.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach(string str in checkedListBox1.CheckedItems)
            {
                list.Add(str);
            }
            Data.list = list;
            Close();
           
        }
        public string DatatoString()
        {
            string str = "";
            for (int i = 0; i < Data.list.Count; i++)
            {
                str = str + Data.list[i] + ";";
            }
            return str;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
