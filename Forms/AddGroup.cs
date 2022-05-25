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
            mode = "Edit";
            id_group = id;
            LoadText();
            btAdd.Text = "Изменить";    //Меняем название кнопки (Добавить -> Изменить)
        }

        //Загрузка данных в поля ввода (для режима Edit)
        private void LoadText()
        {
            DataTable table = ClassMySQL.LoadTable_Filtre("groups", id_group);
            id_spec = (int)table.Rows[0]["id_spec"];
            kurs = (int)table.Rows[0]["kurs"];
            name = table.Rows[0]["name"].ToString();

            cbSpec.SelectedValue = id_spec;
            txName.Text = name;
            numKurs.Value = kurs;
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
            {
                MyMessage.MessageInformation();
                return false;
            }
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
        }
    }
}
