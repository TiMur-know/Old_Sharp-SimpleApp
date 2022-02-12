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
    public partial class Form_System_cold : Form
    {
        public Form_System_cold()
        {
            InitializeComponent();
           
        }
        string svo = "";
        string socket = "";
        public Form_System_cold(int id)
        {
            InitializeComponent();
            using (Model1 model = new Model1())
            {
                System_cold system_Cold = model.System_cold.Find(id);
                textBoxId.Text = system_Cold.Id.ToString();
                textBoxName.Text = system_Cold.Name;
                textBoxPrice.Text = system_Cold.Price.ToString();
                textBoxCountry.Text = system_Cold.Country_Manufact;
                textBox_Brend.Text = system_Cold.Brand;
                string[] size = system_Cold.Sizes.Split('X');
                textBoxSize1.Text = size[0]; textBoxSize2.Text = size[1]; textBoxSize3.Text = size[2];
                textBox_Count.Text = system_Cold.Count.ToString();
                Form_Photo _Photo = new Form_Photo();
                pictureBox1.BackgroundImage = _Photo.byteArrayToImage(system_Cold.Photo);
                textBox5.Text = system_Cold.Additionally;

                textBox1.Text = system_Cold.Size_Vent.ToString();
                textBox2.Text = system_Cold.Max_TDP.ToString();
                textBox3.Text = system_Cold.Noise.ToString();
                textBox4.Text = system_Cold.Thickness.ToString();
                textBox5.Text = system_Cold.Rotation_speed.ToString();
                comboBox1.SelectedItem = system_Cold.Naz;
                comboBox2.SelectedItem = system_Cold.Type;
                comboBox3.SelectedItem = system_Cold.Conector;
                comboBox4.SelectedItem = system_Cold.Light;
                comboBox5.SelectedItem = system_Cold.Bearing;
                comboBox7.SelectedItem = system_Cold.Counstruction;
                if (system_Cold.SVO!=null)
                {
                    checkBox1.Checked = true;
                    svo = system_Cold.SVO;
                }
                if (system_Cold.Socket != null)
                {
                    checkBox2.Checked = true;
                    socket = system_Cold.Socket;
                }

            }

        }
        private void Form_System_cold_Load(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button5.Enabled = false;
            string[] naz =
            {
                "Для корпуса и БП",
                "Охлаждение для процессора",
            };
            string[] vid = {
            "Вентиляторы",
            "Кулеры",
            "Пылевые фильтры",
            "Системы водяного охлаждения",
            };
            
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
            string[] color = {
                "ARGB",
                "RGB",
                "Без подсветки",
                "Белый",
                "Бирюзовый",
                "Голубой",
                "Желтый",
                "Зеленый",
                "Красный",
                "Оранжевый",
                "Синий",
                "Фиолетовый",
            };
            string[] pod =
            {
                "Гидродинамический подшипник (FDB)",
                "Керамический подшипник качения",
                "Подшипник качения",
                "Подшипник масляного давления (SSO)",
                "Подшипник с полиоксиметиленом (POM)",
                "Подшипник скольжения",
                "Подшипник скольжения c винтовой нарезкой",
                "Самосмазывающийся подшипник скольжения (LDP)",
            };
            string[] tep =
            {
                "Акстивное",
            };
            string[] con =
            {
                "Top Flow (горизонтальная)",
                "Башенная",
            };
            
            comboBox1.Items.AddRange(naz);
            comboBox2.Items.AddRange(vid);
            comboBox3.Items.AddRange(conect);
            comboBox4.Items.AddRange(color);
            comboBox5.Items.AddRange(pod);
            comboBox7.Items.AddRange(con);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] cvo =
            {
                "Водоблоки",
                "Крепления",
                "Помпы",
                "Радиаторы",
                "Резервуары",
                "Терминалы",
                "Трубки и шланги",
                "Фитинги",
                "Хладагенты",
            };
            Form_Checked form = new Form_Checked(cvo);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] socket ={
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
            Form_Checked form = new Form_Checked(socket);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Для корпуса и БП")
            {

            }
            else if (comboBox1.SelectedItem.ToString() == "Охлаждение для процессора")
            {
            }   
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button5.Enabled = true;
            }
            else
            {
                button5.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System_cold system_Cold = new System_cold();
            system_Cold.Name = textBoxName.Text;
            system_Cold.Price = Convert.ToDecimal(textBoxPrice.Text);
            system_Cold.Country_Manufact = textBoxCountry.Text;
            system_Cold.Brand = textBox_Brend.Text;
            system_Cold.Sizes = textBoxSize1.Text + " X " + textBoxSize2.Text + " X " + textBoxSize3.Text;
            system_Cold.Count = Convert.ToInt32(textBox_Count.Text);
            system_Cold.Photo = Form_Photo.Data.photo;
            system_Cold.Additionally = textBox5.Text;

            system_Cold.Size_Vent= Convert.ToInt32(textBox1.Text) ;
            system_Cold.Max_TDP= Convert.ToInt32(textBox2.Text);
            system_Cold.Noise= Convert.ToInt32(textBox3.Text);
            system_Cold.Thickness= Convert.ToInt32(textBox4.Text);
            system_Cold.Rotation_speed= Convert.ToInt32(textBox5.Text);
            system_Cold.Naz= comboBox1.SelectedItem.ToString();
            system_Cold.Type= comboBox2.SelectedItem.ToString();
            system_Cold.Conector= comboBox3.SelectedItem.ToString();
            system_Cold.Light= comboBox4.SelectedItem.ToString();
            system_Cold.Bearing= comboBox5.SelectedItem.ToString();
            system_Cold.Counstruction= comboBox7.SelectedItem.ToString();
            if (checkBox1.Checked)
            {
                system_Cold.SVO = svo;
            }
            if (checkBox2.Checked)
            {
                system_Cold.Socket = socket;
            }
        }
    }
}
