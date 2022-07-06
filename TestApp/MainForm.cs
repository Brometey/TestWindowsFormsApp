using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace TestApp
{
    public partial class MainForm : Form
    {
        private SqlConnection _connection = null;
        public MainForm()
        {
            
            InitializeComponent();
            
        }
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            _connection.Open();
            if (_connection.State == ConnectionState.Open)
            {
                MessageBox.Show("Установлено");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void MainLabel_Click(object sender, EventArgs e)
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
    }
}
