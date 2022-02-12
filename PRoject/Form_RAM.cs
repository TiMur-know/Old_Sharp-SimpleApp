using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRoject.Data;
namespace PRoject
{
    public partial class Form_RAM : Form
    {
        bool edit = false;
        public Form_RAM()
        {
            InitializeComponent();
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public Form_RAM(int id)
        {
            InitializeComponent();
            edit = true;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            using (Model1 model1 = new Model1()) { 
            RAM rAM = model1.RAM.Find(id);
            textBoxId.Text= rAM.Id.ToString();
            textBoxName.Text= rAM.Name ;
            textBoxPrice.Text=rAM.Price.ToString() ;
            textBoxCountry.Text=rAM.Country_Manufact ;
            textBox_Brend.Text= rAM.Brand;
                string[] size = rAM.Sizes.Split('X');
                textBoxSize1.Text = size[0]; textBoxSize2.Text = size[1]; textBoxSize3.Text = size[2];
                textBox_Count.Text=rAM.Count.ToString() ;
                Form_Photo _Photo = new Form_Photo();
                pictureBox1.BackgroundImage = _Photo.byteArrayToImage(rAM.Photo);
                textBox_Advanced.Text= rAM.Additionally;
            textBox_plank.Text= rAM.Plank_count.ToString();
            textBox_countMem.Text=rAM.Memory_count.ToString();
            textBox_SystemCold.Text= rAM.Cold ;
            textBox_ChartMemory.Text= rAM.Memory_freq.ToString();
            comboBox3.SelectedItem= rAM.Memory_type;
            comboBox1.SelectedItem= rAM.Timing_scheme;
            comboBox2.SelectedItem= rAM.Nazn;
            textBox1.Text= rAM.Voltage.ToString();
            textBox_effect.Text= rAM.Throughput.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Photo form = new Form_Photo();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add
            Model1 model1 = new Model1();

            RAM rAM = new RAM();
            rAM.Name = textBoxName.Text;
            rAM.Price = Convert.ToDecimal(textBoxPrice.Text);
            rAM.Country_Manufact = textBoxCountry.Text;
            rAM.Brand = textBox_Brend.Text;
            rAM.Sizes = textBoxSize1.Text + " X " + textBoxSize2.Text + " X " + textBoxSize3.Text;
            rAM.Count = Convert.ToInt32(textBox_Count.Text);
            rAM.Photo = Form_Photo.Data.photo;
            rAM.Additionally = textBox_Advanced.Text;
            rAM.Plank_count = Convert.ToInt32(textBox_plank.Text);
            rAM.Memory_count = Convert.ToInt32(textBox_countMem.Text);
            rAM.Cold = textBox_SystemCold.Text;
            rAM.Memory_freq = Convert.ToInt32(textBox_ChartMemory.Text);
            rAM.Memory_type = comboBox3.SelectedItem.ToString();
            rAM.Timing_scheme = comboBox1.SelectedItem.ToString();
            rAM.Nazn = comboBox2.SelectedItem.ToString();
            rAM.Voltage = Convert.ToInt32(textBox1.Text);
            rAM.Throughput = Convert.ToInt32(textBox_effect.Text);

                model1.RAM.Add(rAM);

                model1.SaveChanges();
 

        }

        private void Form_RAM_Load(object sender, EventArgs e)
        {
            string[] timing ={
                "DDR SDRAM",
                "DDR2 SDRAM",
                "DDR3 SDRAM",
                "DDR3L SDRAM",
                "DDR4 DIMM",
                "DDR4 SDRAM",
                "DDR5 SDRAM",
                "DIMM DDR3",
                "SODIMM DDR",
                "SODIMM DDR2",
                "SODIMM DDR3",
                "SODIMM DDR3L",
                "SODIMM DDR4",
            };
            string[] schema = {
            "CL10",
            "CL11",
            "CL12",
            "CL13",
            "CL14",
            "CL15",
            "CL16",
            "CL17",
            "CL18",
            "CL19",
            "CL2.5",
            "CL20",
            "CL21",
            "CL22",
            "CL3",
            "CL36",
            "CL38",
            "CL4",
            "CL40",
            "CL5",
            "CL6",
            "CL7",
            "CL8",
            "CL9",
            };
            string[] what =
            {
                "Для настольных ПК",
                "Для ноутбуков",
                "Серверная память",
            };
            comboBox3.Items.AddRange(timing);
            comboBox1.Items.AddRange(schema);
            comboBox2.Items.AddRange(what);

        }
    }
}
