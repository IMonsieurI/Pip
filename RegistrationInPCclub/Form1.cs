using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO; // Добавляем пространство имен для работы с файлами

namespace RegistrationInPCclub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Bitmap SelectedImage { get; private set; }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Выберите изображение"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedImage = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = SelectedImage;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            string userName = textBoxName.Text;

            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show("Введите имя пользователя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form2 form2 = new Form2(SelectedImage, userName);
            form2.Show();
        }

        // Новый метод для сохранения данных
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath,"data.txt");

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("ФИО: " + textBoxName.Text);
                    writer.WriteLine("Номер компьютера: " + textBox1.Text);
                    writer.WriteLine("Номер телефона: " + textBox2.Text);
                }

                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сохранении данных: {ex.Message}");
            }
        }

        // Пустые обработчики событий, которые можно будет использовать позже
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Click += new System.EventHandler(this.ButtonSave_Click);
        }
    }
}