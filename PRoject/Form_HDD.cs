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
    public partial class Form_HDD : Form
    {
        public Form_HDD()
        {
            InitializeComponent();
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public Form_HDD(int id)
        {
            InitializeComponent();
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            using(Model1 model = new Model1())
            {
                HDD hDD = model.HDD.Find(id);
                textBoxId.Text = hDD.Id.ToString();
                textBoxName.Text = hDD.Name;
                textBoxPrice.Text = hDD.Price.ToString();
                textBoxCountry.Text = hDD.Country_Manufact;
                textBox_Brend.Text = hDD.Brand;
                string[] size = hDD.Sizes.Split('X');
                textBoxSize1.Text = size[0]; textBoxSize2.Text = size[1]; textBoxSize3.Text = size[2];
                textBox_Count.Text = hDD.Count.ToString();
                Form_Photo _Photo = new Form_Photo();
                pictureBox1.BackgroundImage = _Photo.byteArrayToImage(hDD.Photo);
                textBox1.Text = hDD.Additionally;

                textBox_countMem.Text = hDD.Memory_count.ToString();
                textBox_buffer.Text = hDD.Buffer_size.ToString();
                textBox_Shpindel.Text = hDD.Spindle.ToString();
                textBox_speedtransl.Text = hDD.Speed_data.ToString();
                comboBox1.SelectedItem = hDD.FormFactor;
                comboBox2.SelectedItem = hDD.Connector;
                comboBox4.SelectedItem = hDD.Nazn;
                comboBox3.SelectedItem = hDD.Type;
            }
        }
        private void Form_HDD_Load(object sender, EventArgs e)
        {
            string[] formFactors = new string[] {
                "1.8\"",
                "2.5\"",
                "3.5\"",
            };
            string[] inter = new string[] {
                "Fibre Channel",
                "IDE",
                "LAN (Ethernet)_old",
                "NL-SAS (Near Line)",
                "SAS",
                "SATAI",
                "SATAII",
                "SATAIII",
                "SCSI",
                "Thunderbolt",
                "Thunderbolt 2",
                "Thunderbolt 3",
                "USB 2.0",
                "USB 3.0",
                "USB 3.1",
                "USB 3.2",
                "USB Type-C",
                "Wi-Fi",
                "eSATA",
            };
            string[] purpose = new string[] {
                "Для компьютера",
                "Для ноутбука",
                "Для сервера",
            };
            string[] memory_type = new string[] {
                "Внешний",
                "Внутренний",
            };
            string[] tech = new string[] {
                "HDD",
                "HDD + SSD",
                "SSHD (Гибридные)",
            };
            comboBox1.Items.AddRange(formFactors);
            comboBox2.Items.AddRange(inter);
            comboBox3.Items.AddRange(memory_type);
            comboBox4.Items.AddRange(purpose);
            comboBox4.Items.AddRange(tech);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 model1 = new Model1();
            HDD hDD = new HDD();

            hDD.Name = textBoxName.Text;
            hDD.Price = Convert.ToDecimal(textBoxPrice.Text);
            hDD.Country_Manufact = textBoxCountry.Text;
            hDD.Brand = textBox_Brend.Text;
            hDD.Sizes = textBoxSize1.Text + " X " + textBoxSize2.Text + " X " + textBoxSize3.Text;
            hDD.Count = Convert.ToInt32(textBox_Count.Text);
            hDD.Photo = Form_Photo.Data.photo;
            hDD.Additionally = textBox1.Text;

            hDD.Memory_count = Convert.ToDecimal(textBox_countMem.Text);
            hDD.Buffer_size= Convert.ToInt32(textBox_buffer.Text);
            hDD.Spindle= Convert.ToInt32(textBox_Shpindel.Text) ;
            hDD.Speed_data= Convert.ToInt32(textBox_speedtransl.Text) ;
            hDD.FormFactor= comboBox1.SelectedItem.ToString();
            hDD.Connector= comboBox2.SelectedItem.ToString();
            hDD.Nazn= comboBox4.SelectedItem.ToString();
            hDD.Type= comboBox3.SelectedItem.ToString();
        }
    }
}
