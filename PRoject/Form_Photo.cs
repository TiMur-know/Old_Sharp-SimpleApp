using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRoject
{
    public partial class Form_Photo : Form
    {
        public class Data
        {
            public static byte[] photo;

        }
        OpenFileDialog openFileDialog1;
        public Form_Photo()
        {
           
            InitializeComponent();
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files(*.jpg)|*.jpg|All files(*.*)|*.*";
        }
        public Form_Photo(byte [] photo)
        {
            InitializeComponent();
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All files(*.*)|*.*";
            pictureBox1.BackgroundImage = byteArrayToImage(photo);
        }
        public byte[] imageToByteArray(Image imageIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Data.photo=imageToByteArray(pictureBox1.BackgroundImage);
            Close();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            pictureBox1.BackgroundImage = Image.FromFile(filename);
        }
    }
}
