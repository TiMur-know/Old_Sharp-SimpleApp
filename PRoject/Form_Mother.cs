using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRoject.Data;
namespace PRoject
{
    public partial class Form_Mother : Form
    {
        bool edit = false;
        public Form_Mother()
        {
            InitializeComponent();
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        public Form_Mother(int id)
        {
            InitializeComponent();
            edit = true;
            List<string> list = new List<string>();
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            Model1 model1 = new Model1();
            Motherboald motherboald = model1.Motherboald.Find(id);
            textBoxId.Text = motherboald.Id.ToString();
            textBoxName.Text = motherboald.Name;
            textBoxPrice.Text = motherboald.Price.ToString();
            textBox_Brend.Text = motherboald.Brand;
            textBoxCountry.Text = motherboald.Country_Manufact;
            string[] size=motherboald.Sizes.Split('X');
            textBox3.Text = size[0]; textBox2.Text = size[1]; textBox1.Text = size[2];
            textBox_Count.Text = motherboald.Count.ToString();
            comboBox1.SelectedItem = motherboald.Form_factor;
            comboBox2.SelectedItem = motherboald.Socket;
            comboBox3.SelectedItem = motherboald.Chipset;
            mem_sup = motherboald.Support_Memory;
            textBox4.Text = motherboald.M2.ToString();
            if (motherboald.Video != null)
            {
                checkBox1.Checked=true;
            }
            textBox5.Text = motherboald.Video;
            textBox16.Text = motherboald.Max_RAM.ToString();
            mem_help_cpu = motherboald.Help_CPU;
            comboBox6.SelectedItem = motherboald.Nazn;
            cone = motherboald.Connectors;
            comboBox5.SelectedItem = motherboald.Wifi;
            textBox_MChartMem.Text = motherboald.Max_memory_chart.ToString();
            textBoxNumber_of_memory_slots.Text = motherboald.Memory_cells.ToString();
            sata = motherboald.Sata;
            psi = motherboald.PSI;
            vne = motherboald.Vneshni;
            textBox_Advanced.Text = motherboald.Additionally;
            Form_Photo _Photo = new Form_Photo();
            pictureBox1.BackgroundImage = _Photo.byteArrayToImage(motherboald.Photo);
            textBox_net.Text = motherboald.Net;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
            textBoxId.Enabled = false;

            string[] formFactors = new string[] { "ATX", "microATX", "EATX", "BTX", "mBTX", "mini - ITX", "SSI EEB", "SSI CEB", "нестандартный" };
            string[] socket = {
                "Integrated CPU",
                "Socket 1150",
                "Socket 1151",
                "Socket 1155",
                "Socket 1156",
                "Socket 1200",
                "Socket 1700",
                "Socket 2011",
                "Socket 2011-3",
                "Socket 2066",
                "Socket 3647",
                "Socket 478",
                "Socket 775",
                "Socket AM1",
                "Socket AM2",
                "Socket AM2+",
                "Socket AM3",
                "Socket AM3+",
                "Socket AM3/Socket AM3+",
                "Socket AM4",
                "Socket FM1",
                "Socket FM2",
                "Socket FM2+",
                "Socket FM2/Socket FM2+",
                "Socket TR4",
                "Socket sTRX4",
            };
            string[] chipset =
            {
                "AMD 760G",
                "AMD 970",
                "AMD A320",
                "AMD A520",
                "AMD A68H",
                "AMD A75",
                "AMD A88X",
                "AMD B350",
                "AMD B450",
                "AMD B550",
                "AMD TRX40",
                "AMD X370",
                "AMD X399",
                "AMD X470",
                "AMD X570",
                "C612",
                "Intel 865G",
                "Intel B150",
                "Intel B250",
                "Intel B360",
                "Intel B365",
                "Intel B460",
                "Intel B560",
                "Intel B660",
                "Intel B75",
                "Intel B85",
                "Intel C226",
                "Intel C232",
                "Intel C236",
                "Intel C242",
                "Intel C246",
                "Intel C422",
                "Intel C602",
                "Intel C621",
                "Intel G31",
                "Intel G41",
                "Intel H110",
                "Intel H170",
                "Intel H270",
                "Intel H310",
                "Intel H370",
                "Intel H410",
                "Intel H470",
                "Intel H510",
                "Intel H55",
                "Intel H570",
                "Intel H61",
                "Intel H610",
                "Intel H670",
                "Intel H81",
                "Intel H87",
                "Intel H97",
                "Intel W480",
                "Intel X299",
                "Intel X58",
                "Intel X79",
                "Intel X99",
                "Intel Z170",
                "Intel Z370",
                "Intel Z390",
                "Intel Z490",
                "Intel Z590",
                "Intel Z690",
                "Intel Z87",
                "Intel Z97",
                "Nvidia GeForce 7025",
                "SoC",
                "Встроенный в APUs AMD Sempron & Athlon серий",
            };
            string[] purpose =
            {
                "Геймерские",
                "Для майнинга",
                "Для серверов",
                "Обычные",
            };
            string[] video =
            {
                "Есть",
                "Нет",
            };
            string[] wifi =
            {
                "802.11 b/g/n/ac/ax",
                "802.11 b/g/n/ас",
                "Bluetooth",
                "Без беспроводного подключения",
            };
            comboBox1.Items.AddRange(formFactors);
            comboBox2.Items.AddRange(socket);
            comboBox3.Items.AddRange(chipset);
            comboBox5.Items.AddRange(wifi);
            comboBox6.Items.AddRange(purpose);


        }
        string mem_sup = "";
        string mem_help_cpu="";
        string cone = "";
        string sata = "";
        string psi = "";
        string vne = "";
        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            using (Model1 model1 = new Model1()) { 
                Motherboald motherboald = new Motherboald();
                motherboald.Name = textBoxName.Text;
                motherboald.Price = Convert.ToDecimal(textBoxPrice.Text);
                motherboald.Country_Manufact = textBoxCountry.Text;
                motherboald.Brand = textBox_Brend.Text;
                motherboald.Sizes = textBox3.Text + " X " + textBox2.Text + " X " + textBox1.Text;
                motherboald.Count = Convert.ToInt32(textBox_Count.Text);
                motherboald.Support_Memory = mem_sup;
                motherboald.Socket = comboBox2.SelectedItem.ToString();
                motherboald.Chipset = comboBox3.SelectedItem.ToString();
                motherboald.Video = textBox5.Text;
                motherboald.Form_factor = comboBox1.SelectedItem.ToString();
                motherboald.Max_RAM = Convert.ToInt32(textBox16.Text);
                motherboald.Help_CPU = mem_help_cpu;
                motherboald.Nazn = comboBox6.SelectedItem.ToString();
                motherboald.Connectors = cone;
                motherboald.M2 = Convert.ToInt32(textBox4.Text);
                motherboald.Wifi = comboBox5.SelectedItem.ToString();
                motherboald.Memory_cells = Convert.ToInt32(textBoxNumber_of_memory_slots.Text);
                motherboald.Max_memory_chart = Convert.ToInt32(textBox_MChartMem.Text);
                motherboald.Sata = sata;
                motherboald.PSI = psi;
                motherboald.Vneshni = vne;
                motherboald.Additionally = textBox_Advanced.Text;
                motherboald.Photo = Form_Photo.Data.photo;
                    motherboald.Net = textBox_net.Text;
                model1.Motherboald.Add(motherboald);
                model1.SaveChanges();
            };
            }
            catch (Exception ex)
            {

            }
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] memory_help = {
            "DDR",
            "DDR2",
            "DDR3",
            "DDR3(SO - DIMM)",
            "DDR3L",
            "DDR3L(SO - DIMM)",
            "DDR4",
            "DDR4(SO - DIMM)",
            "DDR5",
            "RDRAM",
            "SDR SDRAM",
            "SIMM",
            };
            Form_CheckedN form_CheckedN = new Form_CheckedN(memory_help);
            if (edit)
            {
                form_CheckedN = new Form_CheckedN(memory_help, mem_sup);
            }
            form_CheckedN.ShowDialog();
            mem_sup = form_CheckedN.DatatoString();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string[] conect =
            {
                  "18 + 10 pin",
                "20 pin",
                "20 + 4 pin",
                "20 + 4 + 4 pin",
                "20 + 8pin",
                "24 pin",
                "24 + 4 pin",
                "24 + 4 + 4 pin",
                "24 + 8 pin",
                "24 + 8 + 4 pin",
                "24 + 8 + 8 pin",
            };
            Form_CheckedN form_Checked = new Form_CheckedN(conect);
            form_Checked.ShowDialog();
            cone = form_Checked.DatatoString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] family = {
            "AMD A-Series",
            "AMD Athlon",
            "AMD EPYC",
            "AMD FX-Series",
            "AMD Opteron",
            "AMD Ryzen 3",
            "AMD Ryzen 5",
            "AMD Ryzen 7",
            "AMD Ryzen 9",
            "AMD Ryzen Threadripper",
            "Intel Celeron",
            "Intel Core 2",
            "Intel Core i3",
            "Intel Core i5",
            "Intel Core i7",
            "Intel Core i9",
            "Intel Pentium",
            "Intel Xeon Bronze",
            "Intel Xeon E",
            "Intel Xeon E3",
            "Intel Xeon E5",
            "Intel Xeon E7",
            "Intel Xeon Gold",
            "Intel Xeon Silver",
            "Intel Xeon W",
            "Intel Xeon X",
            "Phenom",
            "Sempron",
            };
            Form_Checked form_Checked = new Form_Checked(family);
            if (edit)
            {
                form_Checked = new Form_Checked(family, mem_help_cpu);
            }
            form_Checked.ShowDialog();
            mem_help_cpu = form_Checked.DatatoString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            string[] psi_en = {
                "AGP",
                "PSI-X",
                "PSI",
                "PSI Exspress x1",
                "PSI Exspress x4",
                "PSI Exspress x8",
                "PSI Exspress x16",
            };
            Form_CheckedN form_Checked = new Form_CheckedN(psi_en);
            form_Checked.ShowDialog();
            psi = form_Checked.DatatoString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string[] vnes =
            {
                "PS / 2",
                "USB 2.0",
                "USB 3.0",
                "VGA",
                "DVI",
                "HDMI",
                "D-SUB",
                "SVGA",
                "eSATA",
                "IEEE 1394(FireWire)",
                "Rj45(Ethernet)",
                "Thunderbolt",
                "Аудиоразьемы",
            };
            Form_CheckedN form_Checked = new Form_CheckedN(vnes);
            form_Checked.ShowDialog();
            vne = form_Checked.DatatoString();
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            string[] satas = {
            "Sata1",
            "Sata2",
            "Sata3",
            };
            Form_CheckedN form_Checked = new Form_CheckedN(satas);
            form_Checked.ShowDialog();
            sata = form_Checked.DatatoString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox5.Enabled = true;
            }
            else
            {
                textBox5.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Photo photo = new Form_Photo();
            photo.ShowDialog();
            pictureBox1.BackgroundImage = photo.byteArrayToImage(Form_Photo.Data.photo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
