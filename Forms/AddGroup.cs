using System;
using System.Data;
using System.Windows.Forms;
using StudentStatistic.Classes;

namespace StudentStatistic.Forms
{
    public partial class AddGroup : Form
    {
        private string _mode;        //Режим
        private int _id_group = 1;   //id группы
        private int _id_spec = 1;    //id специальности
        private int _kurs;           //Номер курса
        private string _name;        //Наменование группы
        private bool _completed = false;     //Статус (при завершении операции True)
        
        //Конструктор для добавления (Add)
        public AddGroup()
        {
            InitializeComponent();
            _mode = "Add";
        }

        //Конструктор для редактирования (Edit)
        public AddGroup(int id)
        {
            InitializeComponent();
            _id_group = id;
            LoadText();
            btAdd.Text = "Изменить";    //Меняем название кнопки (Добавить -> Изменить)
            _mode = "Edit";
        }
        private void AddGroup_Load(object sender, EventArgs e)
        {
            LoadSpec();
            KeyPreview = true;  //Позволяет отлавливать нажатие кнопок (для клавиши Escape)

            //Изменение заголовка на форме в зависимости от режима работы
            if (_mode == "Add")
                Text = "Группа: Новая";
            else
            {
                Text = "Группа: Редактирование записи";
                cbSpec.SelectedValue = _id_spec;
                txName.Text = _name;
                numKurs.Value = _kurs;
            }
        }
        private void AddGroup_Activated(object sender, EventArgs e)
        {
            LoadSpec();
            if (_mode == "Edit")
                cbSpec.SelectedValue = _id_spec;
        }

        //Загрузка данных в поля ввода (Edit)
        private void LoadText()
        {
            DataTable table = ClassMySQL.LoadTable_Filtre("groups", _id_group);
            _id_spec = (int)table.Rows[0]["id_spec"];
            _kurs = (int)table.Rows[0]["kurs"];
            _name = table.Rows[0]["name"].ToString();
        }

        //Загрузка специальностей в ComboBox
        private void LoadSpec()
        {
            DataTable table = ClassMySQL.LoadTable("spec");
            cbSpec.DisplayMember = "name";
            cbSpec.ValueMember = "id";
            cbSpec.DataSource = table;
        }
        
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (_mode == "Add")
                Add();
            else
                Edit();
        }
        //Проверка заполнения обязательных полей
        private bool Valid()
        {
            if (txName.Text != "")
                return true;
            else return false;
        }
        //Добавление строки в БД (таблица "Группа")
        private void Add()
        {
            if (Valid())
            {
                _id_spec = Convert.ToInt32(cbSpec.SelectedValue);
                _kurs = Convert.ToInt32(numKurs.Value);
                _name = txName.Text;

                ClassMySQL.AddRow_Group(_id_spec, _kurs, _name);
                _completed = true;
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
                _id_spec = (int)cbSpec.SelectedValue;
                _name = txName.Text;
                _kurs = (int)numKurs.Value;

                ClassMySQL.EditRow_Group(_id_group, _id_spec, _kurs, _name);
                _completed = true;
                Close();
            }
            else
                MyMessage.MessageInformation();
        }
        //Добавление специальностей
        private void btAddSpec_Click(object sender, EventArgs e)
        {
            AddSpec add = new AddSpec();
            add.ShowDialog();
        }


        //Выход из окна
        //Подтверждение выхода
        private void AddGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_completed && Valid())
            {
                DialogResult result = MyMessage.MessageClose();
                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }
        //Обработка нажатия клавиши Escape (Выход из режима редактирования, без сохранения)
        private void AddGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
