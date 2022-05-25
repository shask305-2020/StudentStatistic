using StudentStatistic.Classes;
using System;
using System.Data;
using System.Windows.Forms;
using StudentStatistic.Forms;

namespace StudentStatistic.Forms
{
    public partial class AddSpec : Form
    {
        private int specId; //ИД для редактирования записи в БД (Edit)
        private string mode;   //Режим добавления (Add) или изменения (Edit)

        //Переменные на форме
        private string code;
        private string name;
        private string sokr;
        private int id_level = 1;
        private int id_base = 1;
        private bool completed = false;

        //Конструкторы
        //Конструктор для создания (Add)
        public AddSpec()
        {
            InitializeComponent();
            mode = "Add";
        }
        //Конструктор для редактирования (Edit)
        public AddSpec(int id_spec)
        {
            InitializeComponent();
            specId = id_spec;
            LoadText();
            mode = "Edit";
            btAdd.Text = "Изменить";    //Меняем название кнопки (Добавить -> Изменить)
        }

        //Загрузка формы
        private void AddSpec_Load(object sender, EventArgs e)
        {
            //Load_tabLevel();
            //Load_tabBase();
            
            KeyPreview = true;  //Позволяет отлавливать нажатие кнопок (для клавиши Escape)
            
            //Изменение заголовка на форме в зависимости от режима работы
            if (mode == "Add")
                Text = "Специальность: Новая";
            else
                Text = "Специальность: Редактирование записи";
        }
        //Обновление списка в ComoBox
        private void AddSpec_Activated(object sender, EventArgs e)
        {
            Load_tabLevel();
            Load_tabBase();
            cbLevel.SelectedValue = id_level;
            cbBase.SelectedValue = id_base;
        }
        //Добавление записи в БД (или изменение, если mode=Edit)
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
        //Проверка заполнения обязательных полей
        private bool Valid()
        {
            if (txCode.Text == "  .  ." || txName.Text == "")
                return false;
            else return true;
        }
        //Добавление записи
        private void Add()
        {
            if (Valid())
            {
                code = txCode.Text;
                name = txName.Text;
                sokr = txAbbr.Text;
                id_level = (int)cbLevel.SelectedValue;
                id_base = (int)cbBase.SelectedValue;
                ClassMySQL.AddRow_Spec(code, name, sokr, id_level, id_base);
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
                code = txCode.Text;
                name = txName.Text;
                sokr = txAbbr.Text;
                id_level = (int)cbLevel.SelectedValue;
                id_base = (int)cbBase.SelectedValue;
                ClassMySQL.EditRow_Spec(specId, code, name, sokr, id_level, id_base);
                completed = true;
                Close();
            }
            else
                MyMessage.MessageInformation();
        }


        //Загрузка данных в поля ввода (для режима Edit)
        private void LoadText()
        {
            DataTable table = ClassMySQL.LoadTable_Filtre("spec", specId);
            code = table.Rows[0]["code"].ToString();
            name = table.Rows[0]["name"].ToString();
            sokr = table.Rows[0]["sokr"].ToString();
            id_level = Convert.ToInt32(table.Rows[0]["id_level"]);
            id_base = Convert.ToInt32(table.Rows[0]["id_base"]);

            txCode.Text = code;
            txName.Text = name;
            txAbbr.Text = sokr;
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

        //Выход из окна
        //Подтверждение выхода
        private void AddSpec_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!completed && Valid())
            {
                DialogResult result = MyMessage.MessageClose();
                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }
        //Обработка нажатия клавиши Escape (Выход из режима редактирования без сохранения)
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
    }
}
