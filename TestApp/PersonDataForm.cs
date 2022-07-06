using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TestApp
{
    public partial class PersonDataForm : Form
    {
        public MainForm form1;
        public PersonDataForm(MainForm owner)
        {
            form1 = owner;
            InitializeComponent();
            GenderBox.SelectedItem = "Мужской";

        }

        private void PersonDataForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PhotoBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.PNG;*.JPG;)|*.PNG;*.JPG|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Не удалось загрузить файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void AddButton1_Click(object sender, EventArgs e)
        {
            form1.dataGridView1.Rows.Add(NameText.Text, SurnameText.Text, GenderBox.Text, BirthText.Text);
            this.Close();

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
