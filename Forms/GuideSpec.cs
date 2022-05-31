using StudentStatistic.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentStatistic.Forms
{
    public partial class GuideSpec : Form
    {
        public GuideSpec()
        {
            InitializeComponent();
        }
        private void GuideSpec_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        //Обновление таблицы с данными
        private void GuideSpec_Activated(object sender, EventArgs e)
        {
            LoadData();
        }
        
        //Загрузка данных
        private void LoadData()
        {
            DataTable table = ClassMySQL.LoadTable("vw_spec");
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;   //Скрытие столбца с id
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        //Добавление строки
        private void btAdd_Click(object sender, EventArgs e)
        {
            AddSpec add = new AddSpec();
            add.ShowDialog();
        }

        //Редактирование строки
        private void EditRow()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int indexRow = dataGridView1.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[indexRow].Cells[0].Value);
                AddSpec add = new AddSpec(id);
                add.ShowDialog();
            }
            else
            {
                MyMessage.MessageNullRowEdit();
            }
        }

        //Редактирование строки (по нажатию на кнопку "Редактировать")
        private void btEdit_Click(object sender, EventArgs e)
        {
            EditRow();
        }

        //Редактирование выделенной строки (двойной клик)
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditRow();
        }

        //Удаление строки
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                DialogResult result = MyMessage.MessageDeletRow();
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);
                    ClassMySQL.DeleteRow("spec", id);
                }
                LoadData();
            }
            else
            {
                MyMessage.MessageNullRowDel();
            }
        }
    }
}
