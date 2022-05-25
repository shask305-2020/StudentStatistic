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
    public partial class GuideGroups : Form
    {
        public GuideGroups()
        {
            InitializeComponent();
        }
        private void GuideGroups_Activated(object sender, EventArgs e)
        {
            LoadData();
            dataGridView1.Rows[0].Cells[1].Selected = true;
        }

        //Загрузка данных в DGV
        private void LoadData()
        {
            DataTable table = ClassMySQL.LoadTable("vw_groups");
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;   //Скрытие столбца с id
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //Открытие формы для добавления строки
        private void btAdd_Click(object sender, EventArgs e)
        {
            AddGroup add = new AddGroup();
            add.ShowDialog();
        }

        //Редактирование строки
        private void EditRow()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int indexRow = dataGridView1.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[indexRow].Cells[0].Value);
                AddGroup edit = new AddGroup(id);
                edit.ShowDialog();
            }
            else
                MyMessage.MessageNullRow();
        }

        //Редактирование выделенной строки (по кнопке "Редактировать")
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
                DialogResult result = MyMessage.MessageDeletRow();
                if (result == DialogResult.Yes)
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);
                    ClassMySQL.DeleteRow("groups", id);
                    //LoadData();
                }
            }
            else
            {
                MyMessage.MessageNullRow();
            }
        }
        
    }
}
