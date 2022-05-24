using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentStatistic.Classes;

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
                ClassMySQL.AddBase(txtBase.Text);
                txtBase.Clear();
                LoadBase();
            }
            else
                MessageBox.Show("Введите наименование базы образования");
        }

        //Удаление выделенного пункта
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (listBase.Items.Count > 0)
            {
                DialogResult result = MyMessage.MessageDeletRow();
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(listBase.SelectedValue);
                    ClassMySQL.DeleteLevel(id);
                    LoadBase();
                }
            }
            else
                MyMessage.MessageNullRow();
        }
    }
}
