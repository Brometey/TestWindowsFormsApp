using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

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
        OpenFileDialog ofd = new OpenFileDialog();
        public void PhotoBox_Click(object sender, EventArgs e)
        {
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
            SqlCommand command = new SqlCommand($"INSERT INTO [PersonData] (Name,Surname,Birthday,INN,Gender,Email,PhotoPath) " +
                                                $"VALUES(N'{NameText.Text}',N'{SurnameText.Text}','{BirthText.Text}','{InnText.Text}'," +
                                                $"N'{GenderBox.Text}','{EmailText.Text}',N'{ofd.FileName}')", form1._connection);
            command.ExecuteNonQuery();
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
