using MySQL_Client;
using StudentStatistic.Classes;
using StudentStatistic.Forms;
using System;
using System.Windows.Forms;

namespace StudentStatistic
{
    public partial class MainForm : Form
    {
        private string serverName = Properties.Settings.Default.server;
        private string dbName = Properties.Settings.Default.database;
        private string login = Properties.Settings.Default.login;
        private string password = Properties.Settings.Default.pass;
        public MainForm()
        {
            InitializeComponent();
        }

        //Загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {
            ClassMySQL.CheckConnect(serverName, dbName, login, password);     //Проверка соединения с БД при загрузке программы
        }

        //Открытие окна с настройками соединения
        private void menuSettingsApp_Click(object sender, EventArgs e)
        {
            SettingsApp app = new SettingsApp();
            app.ShowDialog();
        }

        //Заполнение справочника "Специальности"
        private void menuSpecGuide_Click(object sender, EventArgs e)
        {
            GuideSpec spec = new GuideSpec();
            spec.ShowDialog();
        }

        private void menuGroupGuide_Click(object sender, EventArgs e)
        {
            GuideGroups groups = new GuideGroups();
            groups.ShowDialog();
        }

        private void menuStudentsGuide_Click(object sender, EventArgs e)
        {
            GuideStudents students = new GuideStudents();
            students.ShowDialog();
        }
    }
}
