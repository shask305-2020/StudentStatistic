using System;
using System.Data;
using System.Windows.Forms;
using StudentStatistic.Classes;
using StudentStatistic.Forms;

namespace StudentStatistic.Forms
{
    public partial class AddGroup : Form
    {
        private string mode;        //Режим
        private int id_group = 1;   //id группы
        private int id_spec = 1;    //id специальности
        private int kurs;           //Номер курса
        private string name;        //Наменование группы
        private bool completed = false;
        
        //Конструктор для добавления (Add)
        public AddGroup()
        {
            InitializeComponent();
            mode = "Add";
        }

        //Конструктор для редактирования (Edit)
        public AddGroup(int id)
        {
            InitializeComponent();
            id_group = id;
            LoadText();
            btAdd.Text = "Изменить";    //Меняем название кнопки (Добавить -> Изменить)
            mode = "Edit";
        }

        //Загрузка данных в поля ввода (Edit)
        private void LoadText()
        {
            DataTable table = ClassMySQL.LoadTable_Filtre("groups", id_group);
            id_spec = (int)table.Rows[0]["id_spec"];
            kurs = (int)table.Rows[0]["kurs"];
            name = table.Rows[0]["name"].ToString();
        }

        //Загрузка специальностей в ComboBox
        private void LoadSpec()
        {
            DataTable table = ClassMySQL.LoadTable("spec");
            cbSpec.DisplayMember = "name";
            cbSpec.ValueMember = "id";
            cbSpec.DataSource = table;
        }
        private void AddGroup_Load(object sender, EventArgs e)
        {
            LoadSpec();
            KeyPreview = true;  //Позволяет отлавливать нажатие кнопок (для клавиши Escape)

            //Изменение заголовка на форме в зависимости от режима работы
            if (mode == "Add")
                Text = "Группа: Новая";
            else
            {
                Text = "Группа: Редактирование записи";
                cbSpec.SelectedValue = id_spec;
                txName.Text = name;
                numKurs.Value = kurs;
            }    
                
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case "Add":
                    Add();
                    break;
                case "Edit":
                    Edit();
                    break;
                default:
                    break;
            }
        }

        //Добавление строки в БД (таблица "Группа")
        private void Add()
        {
            if (Valid())
            {
                id_spec = Convert.ToInt32(cbSpec.SelectedValue);
                kurs = Convert.ToInt32(numKurs.Value);
                name = txName.Text;

                ClassMySQL.AddRow_Group(id_spec, kurs, name);
                completed = true;
                Close();
            }
            else
                MyMessage.MessageInformation();
        }

        //Редактирование записи
        private void Edit()
        {
            if (Valid())
            {
                id_spec = (int)cbSpec.SelectedValue;
                name = txName.Text;
                kurs = (int)numKurs.Value;

                ClassMySQL.EditRow_Group(id_group, id_spec, kurs, name);
                completed = true;
                Close();
            }
            else
                MyMessage.MessageInformation();
        }

        private bool Valid()
        {
            if (txName.Text == "")
                return false;
            else return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSpec add = new AddSpec();
            add.ShowDialog();
        }

        private void AddGroup_Activated(object sender, EventArgs e)
        {
            LoadSpec();
            if (mode == "Edit")
                cbSpec.SelectedValue = id_spec;
        }

        //Выход из окна
        //Подтверждение выхода
        private void AddGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!completed && Valid())
            {
                DialogResult result = MyMessage.MessageClose();
                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }
        //Обработка нажатия клавиши Escape (Выход из режима редактирования без сохранения)
        private void AddGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
