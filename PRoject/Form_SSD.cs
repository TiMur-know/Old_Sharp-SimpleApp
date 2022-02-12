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
    public partial class Form_SSD : Form
    {
        public Form_SSD()
        {
            
            InitializeComponent();
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }
        public Form_SSD(int id)
        {
            InitializeComponent();
            using (Model1 model =new Model1())
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

                textBox_countMem.Text = sSD.Memory.ToString();
                textBox_speedRead.Text = sSD.Speed_read.ToString();
                textBox_speedWrite.Text = sSD.Speed_write.ToString();
                textBox_cold.Text = sSD.Cold;
                comboBox1.SelectedItem = sSD.FormFactor;
                comboBox2.SelectedItem = sSD.Connector;
                comboBox3.SelectedItem = sSD.Type_drive;
                comboBox4.SelectedItem = sSD.Purpose;
                comboBox5.SelectedItem = sSD.Type_cells;
            }
        }
        private void Form_SSD_Load(object sender, EventArgs e)
        {
            string[] formFactors = new string[] {
                "1.8\"",
                "2.5\"",
                "3.5\"",
                "Apple proprierity",
                "Half-Slim",
                "M.2",
                "PSI Exspress",
                "U.2",
                "mSATA"
            };
            string[] inter = new string[] {
                "PSI Exspress",
                "SAT",
                "SATA 3.2",
                "SATA I",
                "SATA II",
                "SATA III",
                "Thunderbolt",
                "Thunderbolt 3",
                "USB Type-A",
                "USB Type-C",
                "mSATA"
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
            string[] cells = new string[] {
                "3D NAND",
                "MLC",
                "MLC 3D NAND",
                "QLC",
                "QLC 3D NAND",
                "SLC",
                "TLC",
                "TLC 3D NAND",
                "V-NAND",
            };
            comboBox1.Items.AddRange(formFactors);
            comboBox2.Items.AddRange(inter);
            comboBox3.Items.AddRange(memory_type);
            comboBox4.Items.AddRange(purpose);
            comboBox5.Items.AddRange(cells);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 model1 = new Model1();
            SSD sSD = new SSD();

            sSD.Name = textBoxName.Text;
            sSD.Price = Convert.ToDecimal(textBoxPrice.Text);
            sSD.Country_Manufact = textBoxCountry.Text;
            sSD.Brand = textBox_Brend.Text;
            sSD.Sizes = textBoxSize1.Text + " X " + textBoxSize2.Text + " X " + textBoxSize3.Text;
            sSD.Count = Convert.ToInt32(textBox_Count.Text);
            sSD.Photo = Form_Photo.Data.photo;
            sSD.Additionally = textBox_Advice.Text;

            sSD.Memory= Convert.ToInt32(textBox_countMem.Text);
            sSD.Speed_read= Convert.ToInt32(textBox_speedRead.Text) ;
            sSD.Speed_write= Convert.ToInt32(textBox_speedWrite.Text)  ;
            sSD.Cold= textBox_cold.Text;
            sSD.FormFactor= comboBox1.SelectedItem.ToString();
            sSD.Connector= comboBox2.SelectedItem.ToString();
            sSD.Type_drive = comboBox3.SelectedItem.ToString();
            sSD.Purpose= comboBox4.SelectedItem.ToString();
            sSD.Type_cells= comboBox5.SelectedItem.ToString();
        }
    }
}
