using System;
using System.Data;
using System.Windows.Forms;
using StudentStatistic.Classes;

namespace StudentStatistic.Forms
{
    public partial class AddLevel : Form
    {
        public AddLevel()
        {
            InitializeComponent();
        }
        private void AddLevel_Load(object sender, EventArgs e)
        {
            LoadLevel();
        }
        //Загрузка списка уровня образования
        private void LoadLevel()
        {
            DataTable table = ClassMySQL.LoadTable("level");
            listLevel.DisplayMember = "level";
            listLevel.ValueMember = "id";
            listLevel.DataSource = table;
        }

        //Добавление данных в БД (таблица level)
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtLevel.Text != "")
            {
                ClassMySQL.AddRow("level", "level", txtLevel.Text);
                txtLevel.Clear();
                LoadLevel();
            }
            else
                MessageBox.Show("Введите наименование уровня образования");
        }

        //Удаление выделенного пункта
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (listLevel.Items.Count > 0)
            {
                int id = Convert.ToInt32(listLevel.SelectedValue);
                DialogResult result = MyMessage.MessageDeletRow();
                if (result == DialogResult.Yes)
                {
                    ClassMySQL.DeleteRow("level", id);
                    LoadLevel();
                }
            }
            else
                MyMessage.MessageNullRowEdit();
        }
    }
}
