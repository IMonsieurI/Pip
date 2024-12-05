using System;
using System.Drawing;
using System.Windows.Forms;

namespace RegistrationInPCclub
{
    public partial class Form3 : Form
    {
        private readonly Bitmap _receivedImage;
        private readonly string _userName;

        public Form3(Bitmap receivedImage, string userName)
        {
            InitializeComponent();
            _receivedImage = receivedImage;
            _userName = userName;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox3.Image = _receivedImage; // Отображение изображения
           
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {

        }
    }
}
