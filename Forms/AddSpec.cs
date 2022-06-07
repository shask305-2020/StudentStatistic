using StudentStatistic.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentStatistic.Forms
{
    public partial class AddSpec : Form
    {
        private int _id_spec; //ИД для редактирования записи в БД (Edit)
        private string _mode;   //Режим добавления (Add) или изменения (Edit)

        //Переменные на форме
        private string _code;
        private string _name;
        private string _sokr;
        private int _id_level = 1;
        private int _id_base = 1;
        private bool _completed = false;

        //Конструкторы
        //Конструктор для создания (Add)
        public AddSpec()
        {
            InitializeComponent();
            _mode = "Add";
        }
        //Конструктор для редактирования (Edit)
        public AddSpec(int id_spec)
        {
            InitializeComponent();
            _id_spec = id_spec;
            LoadText();
            _mode = "Edit";
            btAdd.Text = "Изменить";    //Меняем название кнопки (Добавить -> Изменить)
        }

        //Загрузка формы
        private void AddSpec_Load(object sender, EventArgs e)
        {
            Load_tabLevel();
            Load_tabBase();
            
            KeyPreview = true;  //Позволяет отлавливать нажатие кнопок (для клавиши Escape)
            
            //Изменение заголовка на форме в зависимости от режима работы
            if (_mode == "Add")
                Text = "Специальность: Новая";
            else
                Text = "Специальность: Редактирование записи";
        }
        //Обновление списка в ComoBox
        private void AddSpec_Activated(object sender, EventArgs e)
        {
            Load_tabLevel();
            Load_tabBase();
        }
        //Добавление записи в БД (или изменение, если mode=Edit)
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
            if (txCode.Text == "  .  ." || txName.Text == "")
                return false;
            else return true;
        }
        private void WriteField()
        {
            _code = txCode.Text;
            _name = txName.Text;
            _sokr = txAbbr.Text;
            _id_level = (int)cbLevel.SelectedValue;
            _id_base = (int)cbBase.SelectedValue;
        }
        //Добавление записи
        private void Add()
        {
            if (Valid())
            {
                WriteField();
                ClassMySQL.AddRow_Spec(_code, _name, _sokr, _id_level, _id_base);
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
                ClassMySQL.EditRow_Spec(_id_spec, _code, _name, _sokr, _id_level, _id_base);
                _completed = true;
                Close();
            }
            else
                MyMessage.MessageInformation();
        }

        //Загрузка данных в поля ввода (для режима Edit)
        private void LoadText()
        {
            DataTable table = ClassMySQL.LoadTable_Filtre("spec", _id_spec);
            _code = table.Rows[0]["code"].ToString();
            _name = table.Rows[0]["name"].ToString();
            _sokr = table.Rows[0]["sokr"].ToString();
            _id_level = Convert.ToInt32(table.Rows[0]["id_level"]);
            _id_base = Convert.ToInt32(table.Rows[0]["id_base"]);

            txCode.Text = _code;
            txName.Text = _name;
            txAbbr.Text = _sokr;
        }

        //Загрузка уровня образования в ComboBox
        private void Load_tabLevel()
        {
            DataTable dt = ClassMySQL.LoadTable("level");
            cbLevel.DisplayMember = "level";
            cbLevel.ValueMember = "id";
            cbLevel.DataSource = dt;
        }

        //Загрузка базы образования в ComboBox
        private void Load_tabBase()
        {
            DataTable dt = ClassMySQL.LoadTable("base");
            cbBase.DisplayMember = "base";
            cbBase.ValueMember = "id";
            cbBase.DataSource = dt;
        }
        //Новое окно "Добавить базу образования"
        private void bt_add_base_Click(object sender, EventArgs e)
        {
            AddBase form = new AddBase();
            form.ShowDialog();
        }

        //Новое окно "Добавить уровень"
        private void bt_add_level_Click(object sender, EventArgs e)
        {
            AddLevel form = new AddLevel();
            form.ShowDialog();
        }

        //Выход из окна
        //Подтверждение выхода
        private void AddSpec_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_completed && Valid())
            {
                DialogResult result = MyMessage.MessageClose();
                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }
        //Обработка нажатия клавиши Escape (Выход из режима редактирования, без сохранения)
        private void AddSpec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();    
            }
        }
        //Кнопка "Отмена" (выход из редактирования)
        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
