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
    public partial class Form_CPU : Form
    {
        public Form_CPU()
        {
            InitializeComponent();
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

        }
        public Form_CPU(int id)
        {
            
            SSD sSD = model.SSD.Find(id);
            textBoxId.Text = sSD.Id.ToString();
            textBoxName.Text = sSD.Name;
            textBoxPrice.Text = sSD.Price.ToString();
            textBoxCountry.Text = sSD.Country_Manufact;
            textBox_Brend.Text = sSD.Brand;
            string[] size = sSD.Sizes.Split('X');
            textBoxSize1.Text = size[0]; textBoxSize2.Text = size[1]; textBoxSize3.Text = size[2];
            textBox_Count.Text = sSD.Count.ToString();
            Form_Photo _Photo = new Form_Photo();
            pictureBox1.BackgroundImage = _Photo.byteArrayToImage(sSD.Photo);
            textBox_Advice.Text = sSD.Additionally;
        }
        private void Form_CPU_Load(object sender, EventArgs e)
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
            string [] socket={
                "Socket 1150",
                "Socket 1151",
                "Socket 1151 - V2",
                "Socket 1155",
                "Socket 1156",
                "Socket 1200",
                "Socket 1356",
                "Socket 1366",
                "Socket 1567",
                "Socket 1700",
                "Socket 1944",
                "Socket 2011",
                "Socket 2011 - 3",
                "Socket 2066",
                "Socket 3647",
                "Socket 604",
                "Socket 754",
                "Socket 771",
                "Socket 775",
                "Socket AM1",
                "Socket AM2",
                "Socket AM2+",
                "Socket AM2 +/ Socket AM3",
                  "Socket AM3",
                  "Socket AM3 +",
                  "Socket AM4",
                  "Socket FM1",
                  "Socket FM2",
                  "Socket FM2 +",
                  "Socket G2",
                  "Socket G3",
                  "Socket G34",
                  "Socket sTR4",
                  "Socket sTRX4",
                  "Socket sWRX8",
            };
            string[] pok_intel = {
            "Нет",
            "1 поколение",
            "2 поколение(Sandy Bridge)",
            "3 поколение(Ivy Bridge)",
            "4 поколение(Haswell)",
            "5 поколение(Broadwell)",
            "6 поколение(Skylake)",
            "7 поколение(Kaby Lake)",
            "8 поколение(Coffee Lake)",
            "9 поколение(Coffee Lake Refresh)",
            "10 поколение(Cascade Lake)",
            "10 поколение(Comet Lake)",
            "11 поколение(Rocket Lake)",
            "12 поколение(Alder Lake)",
            };
            string[] container = {
            "BOX",
            "Tray",
            };
            string[] purpose = {
            "Сервер",
            "Компьютер",
            };
            string[] pok_amd = {
            "Excavator",
            "Piledriver",
            "Zen",
            "Zen 2",
            "Zen 3",
            "Zen +",
            };
            string[] multiplier = {
            "Залокирован",
            "Разблокирован",
            "Нет",
            };
            string[] cooler = {
            "Есть",
            "Нет",
            };
            comboBox1.Items.AddRange(family);
            comboBox2.Items.AddRange(socket);
            comboBox3.Items.AddRange(pok_intel);
            comboBox4.Items.AddRange(pok_amd);
            comboBox5.Items.AddRange(purpose);
            comboBox6.Items.AddRange(container);
            comboBox8.Items.AddRange(cooler);
            comboBox7.Items.AddRange(multiplier);

        }

        private void button4_Click(object sender, EventArgs e)
        {
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
            Form_Checked form_Checked = new Form_Checked(memory_type);
            form_Checked.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
