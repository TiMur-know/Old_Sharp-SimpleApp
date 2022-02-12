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
    public partial class Form_Videocard : Form
    {
        
        public Form_Videocard()
        {
            InitializeComponent();
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

        }
        string con = "";
        public Form_Videocard(int id)
        {
            InitializeComponent();
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            using (Model1 model = new Model1()) {
                Videocard videocard = new Videocard();
                textBoxId.Text = videocard.Id.ToString();
                textBoxName.Text = videocard.Name;
                textBoxPrice.Text = videocard.Price.ToString();
                textBoxCountry.Text = videocard.Country_Manufact;
                textBox_Brend.Text = videocard.Brand;
                string[] size = videocard.Sizes.Split('X');
                textBoxSize1.Text = size[0]; textBoxSize2.Text = size[1]; textBoxSize3.Text = size[2];
                textBox_Count.Text = videocard.Count.ToString();
                Form_Photo _Photo = new Form_Photo();
                pictureBox1.BackgroundImage = _Photo.byteArrayToImage(videocard.Photo);
                textBox_Advanced.Text = videocard.Additionally;

                textBox_SystemCold.Text = videocard.Cold;
                textBox4.Text = videocard.Memory_Freq.ToString();
                textBox5.Text = videocard.Core_Freq.ToString();
                textBox_MinPowerPSU.Text = videocard.Min_power_PSU.ToString();
                textBox_CoMemory.Text = videocard.Memory_Count.ToString();
                size = videocard.Max_rash.Split('X');
                textBox8.Text = size[0];textBox9.Text = size[1];
                comboBox1.SelectedItem = videocard.Manufacture;
                comboBox2.SelectedItem = videocard.Family;
                comboBox3.SelectedItem = videocard.Cheap;
                comboBox5.SelectedItem = videocard.Memory_bus;
                comboBox6.SelectedItem = videocard.Memory_type;
                comboBox7.SelectedItem = videocard.Interface;
                comboBox8.SelectedItem = videocard.FormFactor;
                comboBox9.SelectedItem = videocard.Advice_power;
                comboBox10.SelectedItem = videocard.Cold_Type;
                con = videocard.Interface;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 model1 = new Model1();
            Videocard videocard = new Videocard();

            videocard.Name = textBoxName.Text;
            videocard.Price = Convert.ToDecimal(textBoxPrice.Text);
            videocard.Country_Manufact = textBoxCountry.Text;
            videocard.Brand = textBox_Brend.Text;
            videocard.Sizes = textBoxSize1.Text + " X " + textBoxSize2.Text + " X " + textBoxSize3.Text;
            videocard.Count = Convert.ToInt32(textBox_Count.Text);
            videocard.Photo = Form_Photo.Data.photo;
            videocard.Additionally = textBox_Advanced.Text;

            videocard.Cold= textBox_SystemCold.Text;
            videocard.Memory_Freq= Convert.ToInt32(textBox4.Text);
            videocard.Core_Freq= Convert.ToInt32(textBox5.Text);
            videocard.Min_power_PSU= Convert.ToInt32(textBox_MinPowerPSU.Text);
            videocard.Memory_Count= Convert.ToInt32(textBox_CoMemory.Text);
            videocard.Max_rash= textBox8.Text+'X'+ textBox9.Text;

            videocard.Manufacture= comboBox1.SelectedItem.ToString();
            videocard.Family=comboBox2.SelectedItem.ToString();
            videocard.Cheap= comboBox3.SelectedItem.ToString();
            videocard.Memory_bus= Convert.ToInt32(comboBox5.SelectedItem);
            videocard.Memory_type= comboBox6.SelectedItem.ToString();
            videocard.Interface= comboBox7.SelectedItem.ToString();
            videocard.FormFactor= comboBox8.SelectedItem.ToString();
            videocard.Advice_power= comboBox9.SelectedItem.ToString();
            videocard.Cold_Type= comboBox10.SelectedItem.ToString();
            videocard.Interface= con;
        }

        private void Form_Videocard_Load(object sender, EventArgs e)
        {
            
            string[] factory =
            {
                "AMD",
                "NVIDIA"
            };
            string[] grafic_cheap =
            {
                "GeForce 210",
                "GeForce GT",
                "GeForce GT 1030",
                "GeForce GTX 1050",
                "GeForce GTX 1050 Ti",
                "GeForce GTX 1060",
                "GeForce GTX 1070",
                "GeForce GTX 1070 Ti",
                "GeForce GTX 1080",
                "GeForce GTX 1080 Ti",
                "GeForce GTX 1650",
                "GeForce GTX 1650 Super",
                "GeForce GTX 1660",
                "GeForce GTX 1660 Super",
                "GeForce GTX 1660 Ti",
                "GeForce GTX 550",
                "GeForce GTX 560",
                "GeForce GTX 590",
                "GeForce GTX 650",
                "GeForce GTX 660",
                "GeForce GTX 745",
                "GeForce GTX 750",
                "GeForce GTX 760",
                "GeForce GTX 770",
                "GeForce GTX 950",
                "GeForce GTX 960",
                "GeForce RTX 2060",
                "GeForce RTX 2060 Super",
                "GeForce RTX 2070",
                "GeForce RTX 2070 Super",
                "GeForce RTX 2080",
                "GeForce RTX 2080 Super",
                "GeForce RTX 2080 Ti",
                "GeForce RTX 3060",
                "GeForce RTX 3060 Ti",
                "GeForce RTX 3070",
                "GeForce RTX 3070 Ti",
                "GeForce RTX 3080",
                "GeForce RTX 3080 Ti",
                "GeForce RTX 3090",
                "NVidia P102-100 (Mining)",
                "NVidia P104-100 (Mining)",
                "QUADRO NVS",
                "R5 220",
                "R5 230",
                "R7 240",
                "R7 250",
                "R7 360",
                "R7 370",
                "R9 270",
                "R9 270X",
                "R9 290X",
                "R9 295X2",
                "R9 370",
                "R9 380",
                "RTX",
                "RX 460",
                "RX 470",
                "RX 480",
                "RX 550",
                "RX 5500 XT",
                "RX 560",
                "RX 5600 XT",
                "RX 570",
                "RX 5700",
                "RX 5700 XT",
                "RX 580",
                "RX 590",
                "RX 6500 XT",
                "RX 6600",
                "RX 6600 XT",
                "RX 6700 XT",
                "RX 6800",
                "RX 6800 XT",
                "RX 6900 XT",
                "RX Vega 56",
                "RX Vega 64",
                "Radeon 550",
                "Radeon HD5xxx",
                "Radeon HD6350",
                "Radeon HD6450",
                "Radeon HD6570",
                "Radeon HD7350",
                "Radeon HD7450",
                "Radeon HD7470",
                "Radeon HD7570",
                "Radeon HD7850",
                "Radeon HD8xxx",
                "Radeon Pro W5700",
                "Radeon Pro WX 3200",
                "Radeon Pro WX 7100",
                "Radeon R5",
                "Radeon RX 5500 XT",
                "Radeon RX 5600 XT",
                "Radeon RX 6600 XT",
                "Radeon VII",
                "T",
                "Titan RTX",
            };
            
            string[] bus_bit_rate =
            {
                "1024",
                "128",
                "160",
                "192",
                "2048",
                "256",
                "32",
                "320",
                "352",
                "384",
                "4096",
                "512",
                "64",
                "96",
            };
            string[] memory_type =
            {
                "DDR2",
                "DDR3",
                "DDR4",
                "DDR5",
                "GDDR2",
                "GDDR3",
                "GDDR4",
                "GDDR5",
                "GDDR5X",
                "GDDR6",
                "GDDR6X",
                "HBM2",
                "SDDR3",
            };          
            string[] interfaze =
            {
                "AGP",
                "PCI",
                "PCI Express 2.1",
                "PCI Express 3.0",
                "PCI-Express",
                "PCI-Express 2.0",
                "PCI-Express 4.0",
                "PCI-Express x1",
                "PCI-Express x16",
                "PCI-Express x16 2.х",
                "PCI-Express x16 3.0",
                "PCI-Express x16 4.0",
                "PCI-Express x4 3.0",
                "PCI-Express x8",
                "PCI-Express x8 2.0",
                "PCI-Express x8 3.0",
                "PCI-Express x8 4.0"
            };
            string[] form_factors =
            {
                "Внешняя",
                "Дискретная (Стандартная)",
                "Мини",
                "Низкопрофильная",
            };
            string[] cooling_system =
            {
                "Активная",
                "Водяное охлаждение",
                "Пассивная",
            };
            string[] additional_meals =
           {
                "1 x 12 pin",
                "1 x 6-Pin",
                "1 x 8 pin + 1 x 6 pin",
                "1 х 8 pin",
                "2 x 8 pin + 1 x 6 pin",
                "2 х 8 pin",
                "3 х 8 pin",
                "6 + 6 pin",
                "6 + 8 pin",
                "6 pin",
                "8 + 6 pin",
                "8 + 8 + 6 pin",
                "8 + 8 + 8 pin",
                "8 + 8 pin",
                "8 pin",
                "Нет",
            };
            comboBox1.Items.AddRange(factory);
            
            comboBox3.Items.AddRange(grafic_cheap);
            comboBox5.Items.AddRange(bus_bit_rate);
            comboBox6.Items.AddRange(memory_type);
            comboBox7.Items.AddRange(interfaze);
            comboBox8.Items.AddRange(form_factors);
            comboBox9.Items.AddRange(additional_meals);
            comboBox10.Items.AddRange(cooling_system);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] connector =
            {
                "DMS-59",
                "DP",
                "DVI",
                "DVI-D",
                "DVI-D Dual Link",
                "DVI-I",
                "DisplayPort",
                "HDMI",
                "S-Video",
                "USB Type-C",
                "VGA",
                "miniDisplayPort",
                "miniHDMI",
            };
            Form_Checked form_Checked = new Form_Checked(connector);
            form_Checked.ShowDialog();
            List<string> conectors = Form_Checked.Data.list;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Photo photo = new Form_Photo();
            photo.ShowDialog();
            pictureBox1.BackgroundImage = photo.byteArrayToImage(Form_Photo.Data.photo);
            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> family = new List<string>();
            if (comboBox1.SelectedItem.ToString() == "AMD")
            {
                family.Add("FirePro");
                family.Add("AMD/ATI Radeon");
            }
            else if (comboBox1.SelectedItem.ToString() == "NVIDIA")
            {
                family.Add("GeForce");
                family.Add("NVS");
                family.Add("Quadro");
                family.Add("RTX");
                family.Add("T");
            }
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(family.ToArray());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
