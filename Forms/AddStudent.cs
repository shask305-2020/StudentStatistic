using System;
using System.Data;
using System.Windows.Forms;
using StudentStatistic.Classes;

namespace StudentStatistic.Forms
{
    public partial class AddStudent : Form
    {
        //Поля, для которых есть элементы управлния на форме
        //Нижнее подчеркивание в префиксе названия поля означает что поле приватное
        private int _id;            //Приватное поле (id студента) для редактирования студента
        private string _fam;        //Фамилия
        private string _name;       //Имя
        private string _otch;       //Отчество
        private int _group;        //id Группы
        private int _gender;        //id Пола
        private DateTime _birthday; //День рождения
        private int _year;          //Год поступления

        //Поля
        private string _mode;        //Режим работы (добавление или редактирование)
        private bool _completed = false;


        //Конструкторы
        //Конструктор для добавления
        public AddStudent()
        {
            InitializeComponent();
            _mode = "Add";
        }

        //Конструктор для редактирования
        public AddStudent(int id)
        {
            InitializeComponent();
            _mode = "Edit";
            _id = id;
            LoadText();
        }

        private void LoadText()
        {
            DataTable table = ClassMySQL.LoadTable_Filtre("students", _id);
            _group = Convert.ToInt32(table.Rows[0]["id_group"]);
            _fam = table.Rows[0]["fam"].ToString();
            _name = table.Rows[0]["name"].ToString();
            _otch = table.Rows[0]["otch"].ToString();
            _birthday = Convert.ToDateTime(table.Rows[0]["birthday"]);
            _gender = Convert.ToInt32(table.Rows[0]["id_gender"]);
            _year = Convert.ToInt32(table.Rows[0]["year_of_admission"]);

            cbGroup.SelectedValue = _group;
            txFam.Text = _fam;
            txName.Text = _name;
            txOtch.Text = _otch;
            dateBirth.Value = _birthday;
            cbGender.SelectedValue = _gender;
            txYear.Text = _year.ToString();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            ReNameButton();
            LoadGroup();
            LoadGender();
            KeyPreview = true;  //Позволяет отлавливать нажатие кнопок (для клавиши Escape)
        }
        //Переименование элементов в зависимости от режима
        private void ReNameButton()
        {
            if (_mode == "Add")
                Text = "Студент: Новый";
            else
            {
                Text = "Студент: Редактирование данных студента";
                btAdd.Text = "Изменить";
            }    
        }
        //Загрузка списка групп в ComboBox
        private void LoadGroup()
        {
            DataTable table = ClassMySQL.LoadTable("groups");
            cbGroup.DisplayMember = "name";
            cbGroup.ValueMember = "id";
            cbGroup.DataSource = table;
        }
        //Загрузка пола в ComboBox
        private void LoadGender()
        {
            DataTable table = ClassMySQL.LoadTable("gender");
            cbGender.DisplayMember = "gender";
            cbGender.ValueMember = "id";
            cbGender.DataSource = table;
        }

        //Добавление данных о студенте в БД
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (_mode == "Add")
                Add();
            else
                Edit();
        }
        //Добавление записи в таблицу "Студенты"
        private void Add()
        {
            if (Valid())
            {
                WriteField();
                ClassMySQL.AddRow_Student(_group, _fam, _name, _otch, _gender, _birthday, _year);
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
                WriteField();
                ClassMySQL.EditRow_Student(_id, _group, _fam, _name, _otch, _gender, _birthday, _year);
                _completed = true;
                Close();
            }
            else
                MyMessage.MessageInformation();
        }
        //Обновление полей
        private void WriteField()
        {
            _group = (int)cbGroup.SelectedValue;
            _fam = txFam.Text;
            _name = txName.Text;
            _otch = txOtch.Text;
            _gender = (int)cbGender.SelectedValue;
            _birthday = dateBirth.Value;
            _year = Convert.ToInt32(txYear.Text);
        }
        //Проверка заполнения всех полей
        private bool Valid()
        {
            bool f, n, o;
            f = txFam.Text != "";
            n = txName.Text != "";
            o = txOtch.Text != "";
            if (f && n && o)
                return true;
            else return false;
        }
        //Выход из окна
        //Подтверждение выхода
        private void AddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_completed && Valid())
            {
                DialogResult result = MyMessage.MessageClose();
                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }
        //Обработка нажатия клавиши Escape (Выход из режима редактирования, без сохранения)
        private void AddStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
