using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace TestApp
{
    public partial class MainForm : Form
    {
        public SqlConnection _connection = null;
        int selectedRow;
        public MainForm()
        {
            
            InitializeComponent();
            
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "Id");
            dataGridView1.Columns.Add("name", "Имя");
            dataGridView1.Columns.Add("surname", "Фамилия");
            dataGridView1.Columns.Add("birthday", "Дата Рождения");
            dataGridView1.Columns.Add("Gender", "Пол");
        }

        private void ReadSingleRow(DataGridView dgw,IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0),record.GetString(1), record.GetString(2), record.GetDateTime(3).ToShortDateString(), record.GetString(5));
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from PersonData";
            SqlCommand command = new SqlCommand(queryString, _connection);
            _connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            RefreshDataGrid(dataGridView1);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {

        }

        void AddButton_Click(object sender, EventArgs e)
        {
            PersonDataForm form2 = new PersonDataForm(this);
            form2.ShowDialog();
            
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new PersonDataForm(this).ShowDialog();

            selectedRow = e.RowIndex;
            
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"SELECT * FROM PersonData WHERE CONCAT(Name,' ',Surname) like '{Search_box.Text}%'";
            SqlCommand command = new SqlCommand(searchString,_connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Search_box_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PersonDataForm form2 = new PersonDataForm(this);
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
