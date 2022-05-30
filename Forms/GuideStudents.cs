using System;
using System.Data;
using System.Windows.Forms;
using StudentStatistic.Classes;

namespace StudentStatistic.Forms
{
    public partial class GuideStudents : Form
    {
        public GuideStudents()
        {
            InitializeComponent();
        }
        private void GuideStudents_Load(object sender, EventArgs e)
        {
            LoadGroup();
        }
        //Обновление данных в таблице при добавлении нового студента
        private void GuideStudents_Activated(object sender, EventArgs e)
        {
            LoadGroup();
        }
        //Загрузка списка групп в ComboBox
        private void LoadGroup()
        {
            DataTable table = ClassMySQL.LoadTable("groups");
            cbGroup.DisplayMember = "name";
            cbGroup.ValueMember = "id";
            cbGroup.DataSource = table;
        }
        //Добавление новой записи
        private void btAdd_Click(object sender, EventArgs e)
        {
            AddStudent add = new AddStudent();
            add.ShowDialog();
        }
        //Редактирование записи
        private void EditRow()
        {
            if (dgvStudents.Rows.Count > 0)
            {
                int indexRow = dgvStudents.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dgvStudents.Rows[indexRow].Cells[0].Value);
                AddStudent edit = new AddStudent(id);
                edit.ShowDialog();
            }
            else
                MyMessage.MessageNullRow();
        }
        //Редактирование записи (нажатие на кнопку "Редактировать")
        private void btEdit_Click(object sender, EventArgs e)
        {
            EditRow();
        }
        //Редактирование записи (двойной клик на строке)
        private void dgvStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditRow();
        }
        //Удаление строки
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.Rows.Count > 0)
            {
                DialogResult result = MyMessage.MessageDeletRow();
                if (result == DialogResult.Yes)
                {
                    int rowIndex = dgvStudents.CurrentCell.RowIndex;
                    int id = Convert.ToInt32(dgvStudents.Rows[rowIndex].Cells[0].Value);
                    ClassMySQL.DeleteRow("students", id);
                }
            }
            else
            {
                MyMessage.MessageNullRowDel();
            }
        }
        //Загрузка студентов при смене группы
        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cbGroup.SelectedValue;
            LoadData(id);
        }
        //Загрузка данных по студентам
        private void LoadData(int id)
        {
            DataTable table = ClassMySQL.LoadTable_Filtre("vw_students", "id_group", id);
            dgvStudents.DataSource = table;
            dgvStudents.Columns[0].Visible = false;   //Скрытие столбца с id
            dgvStudents.Columns[1].Visible = false;   //Скрытие столбца с id_group
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;     //Ширина столбцов одинаковая
        }
    }
}
