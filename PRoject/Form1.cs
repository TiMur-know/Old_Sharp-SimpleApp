using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using PRoject.Data;
namespace PRoject
{
    public partial class Form_Trader : Form
    {
        public Form_Trader()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Developer developer = new Developer();
            developer.ShowDialog();
        }
        void GridCreate<T>(DbSet<T> ts, int i) where T : class
        {
            DataGridView dataGridView = new DataGridView();
            dataGridView.Parent = tabControl1.TabPages[i];
            dataGridView.DataSource = ts.ToList();
            dataGridView.Width = tabControl1.TabPages[i].Width;
            dataGridView.Height = tabControl1.TabPages[i].Height;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dgv";
            DataGridViewLinkColumn dataGridViewLinkColumn = new DataGridViewLinkColumn();
            dataGridViewLinkColumn.Name = "links";
            dataGridViewLinkColumn.HeaderText = "Linked";
            dataGridViewLinkColumn.UseColumnTextForLinkValue = true;
            dataGridViewLinkColumn.Text = "Delete";
            dbSets.Add(Method(ts.ToList()));
            dataGridView.CellContentClick += DataGridView_CellContentClick;   
            dataGridView.Columns.Add(dataGridViewLinkColumn);
        }
        List<Type> dbSets;
        static Type Method<T>(IEnumerable<T> enumerable)
        {
            return typeof(T);
        }
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)tabControl1.SelectedTab.Controls["dgv"];
            if (IsANonHeaderLinkCell(e))
            {
                using (Model1 model = new Model1()) {
                    MessageBox.Show(model.Set(dbSets[tabControl1.SelectedIndex]).Find(dataGridView.Rows[e.RowIndex].Cells["Id"].Value).ToString());
                    
                    model.Set(dbSets[tabControl1.SelectedIndex]).Find(dataGridView.Rows[e.RowIndex].Cells["Id"].Value);
                model.SaveChanges();
                dataGridView.Refresh();
                }
            }
        }
        private bool IsANonHeaderLinkCell(DataGridViewCellEventArgs cellEvent)
        {
            DataGridView dataGridView = (DataGridView)tabControl1.SelectedTab.Controls["dgv"];
            if (dataGridView.Columns[cellEvent.ColumnIndex] is
                DataGridViewLinkColumn &&
                cellEvent.RowIndex != -1)
            { return true; }
            else { return false; }
        }

        private void Form_Trader_Load(object sender, EventArgs e)
        {
            dbSets = new List<Type>();
            Model1 db = new Model1();
            { 
            GridCreate(db.Motherboald, 0);
                GridCreate(db.Videocard, 1);
                GridCreate(db.CPU, 2);
                GridCreate(db.System_cold, 3);
                GridCreate(db.SSD, 4);
                GridCreate(db.HDD, 5);
                GridCreate(db.RAM, 6);
                GridCreate(db.PSU, 7);
                GridCreate(db.Corpus, 8);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                Form_Mother form = new Form_Mother();
                form.ShowDialog();

            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                Form_Videocard form = new Form_Videocard();
                form.ShowDialog();

            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                Form_CPU form = new Form_CPU();
                form.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPage4)
            {
                Form_System_cold form = new Form_System_cold();
                form.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPage5)
            {
                Form_SSD form = new Form_SSD();
                form.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPage6)
            {
                Form_HDD form = new Form_HDD();
                form.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPage7)
            {
                Form_RAM form = new Form_RAM();
                form.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPage8)
            {
                Form_PSU form = new Form_PSU();
                form.ShowDialog();
            }
            else if (tabControl1.SelectedTab == tabPage9)
            {
                Form_Corpus form = new Form_Corpus();
                form.ShowDialog();
            }
        }
    }
}
