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
    public partial class Form_PSU : Form
    {
        public Form_PSU()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_factor.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxId.Enabled = false;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public Form_PSU(int id)
        {
            InitializeComponent();
            using (Model1 model1 = new Model1())
            {
                PSU pSU = model1.PSU.Find(id);
                textBoxId.Text = pSU.Id.ToString();
                textBoxName.Text = pSU.Name;
                textBoxPrice.Text = pSU.Price.ToString();
                textBoxCountry.Text = pSU.Country_Manufact;
                textBox_Brend.Text = pSU.Brand;
                string[] size = pSU.Sizes.Split('X');
                textBoxSize1.Text = size[0]; textBoxSize2.Text = size[1]; textBoxSize3.Text = size[2];
                textBox_Count.Text = pSU.Count.ToString();
                Form_Photo _Photo = new Form_Photo();
                pictureBox1.BackgroundImage = _Photo.byteArrayToImage(pSU.Photo);
                textBox_Advanced.Text = pSU.Additionally;

                textBox_CoSATA.Text=pSU.Connector_Sata.ToString() ;
                comboBox_factor.SelectedItem=pSU.Form_factor;
                comboBox1.SelectedItem=pSU.System_cold;
                textBox_power.Text=pSU.Power.ToString();
                comboBox2.SelectedItem=pSU.Type;
                textBoxIde.Text=pSU.Connector_Molex.ToString();
                cpu= pSU.Connector_CPU;
                mother=pSU.Connector_Mother;
                video=pSU.Connector_Video;
                shield=pSU.Shield_tech;
                textBox_cold.Text=pSU.Cold;
                textBox_DsB.Text=pSU.Noise.ToString();
                comboBox3.SelectedItem=pSU.PFC;
            }
        }
        private void Add()
        {
            int id = Convert.ToInt32(textBoxId.Text);
            string name = textBoxName.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);
            string country_factory = textBoxCountry.Text;
            string brend = textBox_Brend.Text;
            string size = textBoxSize1.Text + " X " + textBoxSize2.Text + " X " + textBoxSize3.Text;
            int count = Convert.ToInt32(textBox_Count.Text);
        }
        private void Form_PSU_Load(object sender, EventArgs e)
        {
            string[] form =
            {
                "ATX",
                "ATX (PS/2)",
                "ATX 12 V",
                "ATX 12V v2.01",
                "ATX 12V v2.2",
                "ATX 12V v2.3",
                "ATX 12V v2.31",
                "ATX 12V v2.4",
                "ATX 12V v2.52",
                "BTX",
                "EPS",
                "Flex ATX",
                "ITX",
                "Micro ATX",
                "Mini-ITX",
                "SFX",
                "TFX",
            };
            string[] system_cold =
            {
                "Активная",
                "Пасивная",
            };
            string[] pfc =
            {
                "Активный",
                "Пасивный",
                "Нет",
            };
            string[] tupe =
            {
                "Внешний",
                "Для геймеров",
                "Для майнинга",
                "Компьютерный",
                "Промышленный",
                "Серверный",
            };
            comboBox_factor.Items.AddRange(form);
            comboBox1.Items.AddRange(system_cold);
            comboBox2.Items.AddRange(tupe);
            comboBox3.Items.AddRange(pfc);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] tex_shield =
            {
                "Защита от короткого замыкания (SCP)",
                "Защита от перегрева (OTP)",
                "Защита от перегрузки (OLP)",
                "Защита от перегрузки (OPP)",
                "Защита от перегрузки по току (OCP)",
                "Защита от перепадов напряжения (OVP/UVP)",
                "Защита от скачков тока и напряжения (SIP)",
            };
            Form_Checked form = new Form_Checked(tex_shield);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] conector =
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
            Form_Checked form = new Form_Checked(conector);
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Photo photo = new Form_Photo();
            photo.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] conect = {
            "2 - pin",
            "3 - pin",
            "3 - pin + Molex",
            "4 - pin",
            "4 - pin + Molex",
            "5 - pin",
            "6 - pin",
            "8 - pin",
            "Molex",
            "USB 2.0 connectors(9 Pin)",
            };
            Form_Checked form_Checked = new Form_Checked(conect);
            form_Checked.ShowDialog();
            List<string> conectors = Form_Checked.Data.list;
        }

        private void button7_Click(object sender, EventArgs e)
        {
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
            Form_CheckedN form_Checked = new Form_CheckedN(additional_meals);
            form_Checked.ShowDialog();
            
        }
        string cpu="";
        string mother = "";
        string video = "";
        string shield = "";
        private void button3_Click(object sender, EventArgs e)
        {
            Model1 model1 = new Model1();
            PSU pSU = new PSU();
            pSU.Name = textBoxName.Text;
            pSU.Price = Convert.ToDecimal(textBoxPrice.Text);
            pSU.Country_Manufact = textBoxCountry.Text;
            pSU.Brand = textBox_Brend.Text;
            pSU.Sizes = textBoxSize1.Text + " X " + textBoxSize2.Text + " X " + textBoxSize3.Text;
            pSU.Count = Convert.ToInt32(textBox_Count.Text);
            pSU.Photo = Form_Photo.Data.photo;
            pSU.Additionally = textBox_Advanced.Text;

            pSU.Connector_Sata = Convert.ToInt32(textBox_CoSATA.Text);
            pSU.Form_factor = comboBox_factor.SelectedItem.ToString();
            pSU.System_cold = comboBox1.SelectedItem.ToString();
            pSU.Power = Convert.ToInt32(textBox_power.Text);
            pSU.Type = comboBox2.SelectedItem.ToString();
            pSU.Connector_Molex = Convert.ToInt32(textBoxIde.Text);
            pSU.Connector_CPU = cpu;
            pSU.Connector_Mother = mother;
            pSU.Connector_Video = video;
            pSU.Shield_tech = shield;
            pSU.Cold = textBox_cold.Text;
            pSU.Noise = Convert.ToInt32(textBox_DsB.Text);
            pSU.PFC = comboBox3.SelectedItem.ToString();
            
        }
    }
}
