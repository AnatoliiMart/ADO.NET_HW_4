using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace ADO.NET_HW_4
{
    public partial class Form1 : Form
    {
        private readonly SqlConnection _connection;
        private readonly DbDataAdapter _adapter;
        private readonly DataSet _dataSet;
        private readonly Dictionary<string, string> _tasks = new Dictionary<string, string>()
            {
                {"Весь список", "Вывести весь список" },
                {"Поиск по названию", "Введите название книги для поиска" },
                {"Поиск по автору", "Введите имя автора для поиска" },
                {"Поиск по категории", "Введите категорию для поиска" }
            };
        private List<string> _commandList;
        public Form1()
        {
            InitializeComponent();

            comboBox1.DataSource = _tasks.Keys.ToArray();
            comboBox1.SelectedIndex = 0;

            _connection = new SqlConnection();
            _connection.ConnectionString =
                ConfigurationManager.ConnectionStrings["library"].ConnectionString;

            _adapter = new SqlDataAdapter();

            string selectTxt = "SELECT * FROM Books";
            _adapter.SelectCommand = new SqlCommand(selectTxt, _connection);
            _dataSet = new DataSet();
            _adapter.Fill(_dataSet, "Books");
            dataGrid_Books.DataSource = _dataSet.Tables["Books"].DefaultView;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_ValueInputPresenter.Text = _tasks[comboBox1.SelectedItem.ToString()];
            txtBox_SearchValue.Text = string.Empty;

            if (comboBox1.SelectedIndex == 0)
                txtBox_SearchValue.ReadOnly = true;
            else
                txtBox_SearchValue.ReadOnly = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (_dataSet.Tables["Books"].Rows.Count == 0 || txtBox_SearchValue.Text == string.Empty)
            {
                _adapter.SelectCommand.CommandText = "SELECT * FROM Books";
                _dataSet.Tables["Books"].Rows.Clear();
                _adapter.Fill(_dataSet, "Books");
                return;
            }

            TaskCreation(txtBox_SearchValue.Text);
            _adapter.SelectCommand.CommandText = _commandList[comboBox1.SelectedIndex];
            _dataSet.Tables["Books"].Rows.Clear();
            _adapter.Fill(_dataSet, "Books");
            
        }

        private void TaskCreation(string searchValue)
        {
            _commandList = new List<string>
            {
                $"SELECT * FROM Books",
                $"SELECT * FROM Books WHERE Name LIKE '%{searchValue}%'",
                $"SELECT * FROM Books, Authors WHERE Authors.FirstName LIKE '%{searchValue}%' AND Authors.Id = Books.Id_Author",
                $"SELECT * FROM Books, Categories WHERE Categories.Name LIKE '%{searchValue}%' AND Categories.Id = Books.Id_Category"
            };
        }
    }
}
