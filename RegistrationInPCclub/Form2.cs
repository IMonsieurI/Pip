using System;
using System.Drawing;
using System.Windows.Forms;

namespace RegistrationInPCclub
{
    public partial class Form2 : Form
    {
        private readonly Bitmap _receivedImage;
        private readonly string _userName;
        private string userName;
        private string imagePath;

        public Form2(Bitmap receivedImage, string userName)
        {
            InitializeComponent();
            _receivedImage = receivedImage;
            _userName = userName;
        }

        public Form2(string userName, string imagePath)
        {
            this.userName = userName;
            this.imagePath = imagePath;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = _receivedImage; // Отображение изображения
           
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(_receivedImage, _userName);
            form3.Show();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
