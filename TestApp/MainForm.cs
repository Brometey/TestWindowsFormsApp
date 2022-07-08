using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace TestApp
{

    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class MainForm : Form
    {
        public static bool editing;
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
            dataGridView1.Columns.Add("IsNew", String.Empty);
            this.dataGridView1.Columns["IsNew"].Visible = false;
        }

        public void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetDateTime(3).ToShortDateString(), record.GetString(5), RowState.ModifiedNew);
        }


        public void MainForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            RefreshDataGrid(dataGridView1);
        }

        private void DeleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
            
            var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            var deleteQuery = $"DELETE FROM PersonData WHERE id = {id}";

            var command = new SqlCommand(deleteQuery, _connection);
            command.ExecuteNonQuery();
        }
        private void Update()
        {
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {

                }
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {

        }

        void AddButton_Click(object sender, EventArgs e)
        {

            PersonDataForm form2 = new PersonDataForm(this);
            form2.ShowDialog();

        }



        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new PersonDataForm(this).ShowDialog();

            selectedRow = e.RowIndex;

        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"SELECT * FROM PersonData WHERE CONCAT(Name,' ',Surname) like N'{Search_box.Text}%'";
            SqlCommand command = new SqlCommand(searchString, _connection);
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


        private void button1_Click_1(object sender, EventArgs e)
        {
            Change();
        }
        private void Change()
        {
            editing = true;
            var id = dataGridView1.CurrentRow.Cells[0].Value; //значение ячейки id
            var selected = dataGridView1.CurrentRow;

            PersonDataForm form = new PersonDataForm(this);
            form.NameText.Text = (string)selected.Cells[1].Value; 

            string queryString = $"select * from PersonData where id={id}";
            SqlCommand command = new SqlCommand(queryString, _connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                form.NameText.Text = reader.GetString(1); // Имя
                form.SurnameText.Text = reader.GetString(2); // Фамилия
                form.BirthText.Text = reader.GetDateTime(3).ToShortDateString();
                form.InnText.Text = reader.GetString(4);
                form.GenderBox.Text = reader.GetString(5);
                form.EmailText.Text = reader.GetString(6);
                form.PhoneText.Text = reader.GetString(8);
            }

            reader.Close();
            form.ShowDialog();
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
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }
    }
}
