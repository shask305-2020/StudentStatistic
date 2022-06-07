using StudentStatistic.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentStatistic.Forms
{
    public partial class AddBase : Form
    {
        public AddBase()
        {
            InitializeComponent();
        }

        private void AddBase_Load(object sender, EventArgs e)
        {
            LoadBase();
        }

        //Загрузка списка базы образования
        private void LoadBase()
        {
            DataTable table = ClassMySQL.LoadTable("base");
            listBase.DisplayMember = "base";
            listBase.ValueMember = "id";
            listBase.DataSource = table;
        }

        //Добавление данных в БД (таблица base)
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtBase.Text != "")
            {
                ClassMySQL.AddRow("base", "base", txtBase.Text);
                txtBase.Clear();
                LoadBase();
            }
            else
                MessageBox.Show("Введите наименование базы образования", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Удаление выделенного пункта
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (listBase.Items.Count > 0)
            {
                int id = Convert.ToInt32(listBase.SelectedValue);
                DialogResult result = MyMessage.MessageDeletRow();
                if (result == DialogResult.Yes)
                {
                    ClassMySQL.DeleteRow("base", id);
                    LoadBase();
                }
            }
            else
                MyMessage.MessageNullRowEdit();
        }
    }
}
