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
        //Добавление строки
        private void btAdd_Click(object sender, EventArgs e)
        {
            AddGroup add = new AddGroup();
            add.ShowDialog();
        }
        //Редактирование строки
        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int indexRow = dataGridView1.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[indexRow].Cells[0].Value);
                AddGroup add = new AddGroup();
                add.ShowDialog();
            }
            else
                MyMessage.MessageNullRow();
        }
        //Удаление строки
        private void btDelete_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            DataTable table = ClassMySQL.LoadTable("vw_groups");
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Visible = false;   //Скрытие столбца с id
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void GuideGroups_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
