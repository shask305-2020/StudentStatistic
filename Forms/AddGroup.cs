using System;
using System.Data;
using System.Windows.Forms;
using StudentStatistic.Classes;

namespace StudentStatistic.Forms
{
    public partial class AddGroup : Form
    {
        private string mode;
        private int id_spec = 1;
        private int kurs;
        private string name;
        //private bool completed = false;
        
        //Конструктор для добавления
        public AddGroup()
        {
            InitializeComponent();
            mode = "Add";
        }

        //Конструктор для редактирования
        //public AddGroup()

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
                    //Edit();
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
                id_spec = Convert.ToInt32(cbSpec.SelectedIndex);
                kurs = Convert.ToInt32(numKurs.Value);
                name = txName.Text;

                ClassMySQL.AddRow_Group(id_spec, kurs, name);
                //completed = true;
                Close();
            }
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
    }
}
