using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Linq;

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

        void AddButton1_Click(object sender, EventArgs e)
        {
            #region Names of Textboxes
            string[] dates = BirthText.Text.Split('.');
            string name = NameText.Text;
            string surname = SurnameText.Text;
            string date = $"{dates[2]}/{dates[1]}/{dates[0]}";
            string inn = InnText.Text;
            string gender = GenderBox.Text;
            string email = EmailText.Text;
            string phone = PhoneText.Text;
            #endregion
            if (MainForm.editing == false)
            {
                SqlCommand command = new SqlCommand($"INSERT INTO [PersonData] (Name,Surname,Birthday,INN,Gender,Email,PhotoPath,PhoneNumber) " +
                                                    $"VALUES(N'{name}',N'{surname}','{date}','{inn}'," +
                                                    $"N'{gender}','{email}',N'{ofd.FileName}','{phone}')", form1._connection);
                command.ExecuteNonQuery();


                string query = $"SELECT id FROM PersonData WHERE Name = N'{NameText.Text}' AND Surname = N'{SurnameText.Text}' AND Birthday ='{date}' ";
                SqlCommand command1 = new SqlCommand(query,form1._connection);


                SqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                   int  id = reader.GetInt32(0);
                    form1.dataGridView1.Rows.Add($"{id}", NameText.Text, SurnameText.Text, BirthText.Text, GenderBox.Text);
                }
                reader.Close();
                
            }
            else
            {
                var id = form1.dataGridView1.CurrentRow.Cells[0].Value; //значение ячейки id

                string query = $"UPDATE PersonData SET Name = N'{name}',Surname = N'{surname}',Birthday = '{date}',INN = '{inn}'," +
                    $"Gender = N'{gender}',Email='{email}',PhotoPath = N'{ofd.FileName}',PhoneNumber = '{phone}' WHERE id = {id}";
                SqlCommand cmd = new SqlCommand(query,form1._connection);
                cmd.ExecuteNonQuery();
                
                int index = form1.dataGridView1.CurrentCell.RowIndex;
                form1.dataGridView1.Rows[index].Visible = false;

                form1.dataGridView1.Rows.Add($"{id}", NameText.Text, SurnameText.Text, BirthText.Text, GenderBox.Text);

                MainForm.editing = false;
            }
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
