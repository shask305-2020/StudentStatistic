using StudentStatistic.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentStatistic.Forms
{
    public partial class GuideSpec : Form
    {
        private int rowIndex;
        private bool state = true;
        public GuideSpec()
        {
            InitializeComponent();
        }

        private void GuideSpec_Load(object sender, EventArgs e)
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
            state = true;
            AddSpec add = new AddSpec();
            add.ShowDialog();
        }
        //Редактирование строки
        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                state = true;
                int indexRow = dataGridView1.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[indexRow].Cells[0].Value);
                AddSpec add = new AddSpec(id);
                add.ShowDialog();
            }
            else
            {
                MyMessage.MessageNullRow();
            }           
        }
        //Удаление строки
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                state = false;
                DialogResult result = MyMessage.MessageDeletRow();
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);
                    ClassMySQL.DeleteRow_Spec(id);
                    LoadData();
                }
            }
            else
            {
                MyMessage.MessageNullRow();
            }
            
        }
        //Обновление таблицы с данными
        private void GuideSpec_Activated(object sender, EventArgs e)
        {
            if (state)
                LoadData();
        }

        //Редактирование выделенной строки (двойной клик)
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                state = true;
                int indexRow = dataGridView1.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[indexRow].Cells[0].Value);
                AddSpec add = new AddSpec(id);
                add.ShowDialog();
            }
            else
            {
                MyMessage.MessageNullRow();
            }
        }

        //Оределение индекса выделенной строки
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
                rowIndex = dataGridView1.CurrentCell.RowIndex;
        }
    }
}
