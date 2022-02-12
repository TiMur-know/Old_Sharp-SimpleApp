using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRoject
{
    
    public partial class Form_CheckedN : Form
    {
        public class Checked_Data
        {
            public static List<string> Name;
            public static List<int> Count;
        }
        public Form_CheckedN()
        {
            InitializeComponent();
        }
        public Form_CheckedN(string[] in_name)
        {
            InitializeComponent();
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            Column3.FalseValue = 0;
            Column3.TrueValue = 1;
            for (int i = 0; i < in_name.Length; i++)
            {
                dataGridView1.Rows.Add(i, in_name[i], false,0);
            }


        }
        public Form_CheckedN(List<string> in_name)
        {
            InitializeComponent();
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            Column3.FalseValue = 0;
            Column3.TrueValue = 1;
            for (int i = 0; i < in_name.Count; i++)
            {
                dataGridView1.Rows.Add(i, in_name[i], false,0);
            }

        }
        public Form_CheckedN(string[]strs,string str)
        {
            InitializeComponent();
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            Column3.FalseValue = 0;
            Column3.TrueValue = 1;

            for (int i = 0; i < strs.Length; i++)
            {
                dataGridView1.Rows.Add(i, strs[i], false, 0);
            }
            DatatoString(str);
        }
        public Form_CheckedN(List<string> in_name, List<int> in_count)
        {
            InitializeComponent();
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            Column3.FalseValue = 0;
            Column3.TrueValue = 1;
            for (int i = 0; i < in_name.Count; i++)
            {          
                dataGridView1.Rows.Add(i , in_name[i], false, in_count);
            }
           

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            bool closed=true;
            List<string> name = new List<string>();
            List<int> count = new List<int>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[2].EditedFormattedValue) {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value)>0)
                    {
                        name.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                        count.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value));
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[3].Style.BackColor = Color.Red;
                        closed = false;
                    }
                }
            }
            if (closed)
            {
                Checked_Data.Name = name;
                Checked_Data.Count = count;
                Close();
            }
            else
            {
                MessageBox.Show("Не все данные заполнены");
            }
            
        }
        public string DatatoString()
        {
            string str = "";
            for (int i = 0; i < Checked_Data.Name.Count; i++)
            {
                str = str + Checked_Data.Name[i] + "(x" + Checked_Data.Count[i] + ")" + ";";
            }
            return str;
        }
        private void DatatoString(string str)
        {
            string[] strs = str.Split(';');
            var rg = new Regex(@"\(x(.*)\)");
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for(int j = 0; j < strs.Length; j++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == strs[j])
                    {
                        dataGridView1.Rows[i].Cells[3].Value = rg.Match(strs[i]).Groups[1].Value;
                        dataGridView1.Rows[i].Cells[1].Value= strs[i].Remove(strs[i].LastIndexOf(@"("));
                        dataGridView1.Rows[i].Cells[2].Value = true;
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
