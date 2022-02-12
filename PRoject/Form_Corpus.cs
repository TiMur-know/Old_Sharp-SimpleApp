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
    public partial class Form_Corpus : Form
    {
        public Form_Corpus()
        {
            InitializeComponent();
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] formFactors = new string[] { "ATX", "microATX", "EATX", "BTX", "mBTX", "mini - ITX", "SSI EEB", "SSI CEB", "нестандартный" };
            Form_Checked form_Checked = new Form_Checked(formFactors);
            form_Checked.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form_Corpus_Load(object sender, EventArgs e)
        {
            string[] tupe =
            {
                "Cube Case",
                "DeskTop",
                "Fulltower",
                "HTPC",
                "Miditower",
                "Minitower",
                "Rackmount",
                "Small Form Factor",
                "Small Tower",
                "Supertower",
                "Корпус-стол",
            };
           
            string[] purpose = {
                "Геймерский",
                "Для майнинга",
                "Мультимедийный",
                "Обычный",
                "Серверный",
            };
            string[] sposob =
            {
                "Вертикальный",
                "Горизонтальный",
                "Универсальный",
            };
            string[] bp_nav = { "Верхнее", "Нижнее", };
            comboBox1.Items.AddRange(tupe);
            comboBox2.Items.AddRange(bp_nav);
            comboBox3.Items.AddRange(purpose);
            comboBox4.Items.AddRange(sposob);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] osob = {
            "С ЖК экраном",
            "С безвинтовым креплением",
            "С боковым окном",
            "С вертикальной установкой видеокарты",
            "С поддержкой СВО",
            "С подсветкой",
            "С пылевым фильтром",
            "С системой организации кабелей",
            "С съемными корзинами для HDD",
            };
            Form_Checked form_Checked = new Form_Checked(osob);
            form_Checked.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] material = {
                "Акрил",
                "Алюминий",
                "Закаленное стекло",
                "Металл",
                "Пластик",
                "Пластмасса",
                "Резина",
                "Сталь",
            };
            Form_Checked form_Checked = new Form_Checked(material);
            form_Checked.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] otsek = {
                "Количество отсеков 2.5\"",
                "Количество внутренних  отсеков 2.5\"",
                "Количество внешнних отсеков 2.5\"",
                "Количество отсеков 5.25\""
            };
            Form_CheckedN form_CheckedN = new Form_CheckedN(otsek);
            form_CheckedN.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string[] conect = {
            "USB 3",
            "USB 2",
            "Вихід для навушників",
            "Вхід для мікрофона",
            "Аудио разьемы" };
            Form_CheckedN form_CheckedN = new Form_CheckedN(conect);
            form_CheckedN.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox4.Text) > 0)
            {
                textBox7.Enabled = true;
            }
            else
            {
                textBox7.Enabled = false;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox5.Text) > 0)
            {
                textBox8.Enabled = true;
            }
            else
            {
                textBox8.Enabled = false;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox6.Text) > 0)
            {
                textBox9.Enabled = true;
            }
            else
            {
                textBox9.Enabled = false;
            }
        }
    }
}
