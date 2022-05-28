using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentStatistic;
using StudentStatistic.Classes;

namespace MySQL_Client
{
    public partial class SettingsApp : Form
    {
        //Переменные, в оторых сохраняются данные из поле ввода
        private string ser, db, log, pas;
        public SettingsApp()
        {
            InitializeComponent();
            txPass.UseSystemPasswordChar = true;
        }

        private void SettingsApp_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        //Заполнение переменных значениями из полей ввода
        private void WriteVariable()
        {
            ser = txServerName.Text;
            db = txDBname.Text;
            log = txLogin.Text;
            pas = txPass.Text;
        }

        //Загрузка сохраненных настроек
        private void LoadSettings()
        {
            txServerName.Text = StudentStatistic.Properties.Settings.Default.server;
            txDBname.Text = StudentStatistic.Properties.Settings.Default.database;
            txLogin.Text = StudentStatistic.Properties.Settings.Default.login;
            txPass.Text = StudentStatistic.Properties.Settings.Default.pass;
            WriteVariable();
        }

        //Проверка, чтобы все поля ввода были заполнены
        private bool Valid()
        {
            WriteVariable();
            bool server = ser != "";
            bool dbN = db != "";
            bool login = log != "";
            bool pass = pas != "";
            if (server && dbN && login && pass)
                return true;
            else
                return false;
        }

        //Сохранение настроек
        private void SaveSettings()
        {
            StudentStatistic.Properties.Settings.Default.server = ser;
            StudentStatistic.Properties.Settings.Default.database = db;
            StudentStatistic.Properties.Settings.Default.login = log;
            StudentStatistic.Properties.Settings.Default.pass = pas;
            StudentStatistic.Properties.Settings.Default.Save();
        }

        //Кнопка "Примененить настройки"
        private void btApply_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                bool check = ClassMySQL.CheckConnect(ser, db, log, pas);
                if (!check)
                    return;
                SaveSettings();
                ClassMySQL.DB_Load(ser, db, log, pas);
                MessageBox.Show("Соединение установлено\nНастрйки сохранены и применены",
                    "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Проверьте корректность заполнения всех полей");
            }
        }

        //Проверка сохранения настроек при закрытии окна
        private void SettingsApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckSaveSettings())
            {
                DialogResult dialog = MessageBox.Show("Данные не сохранены!\nВы желаете выйти из пограммы?", 
                    "Внимание!", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dialog == DialogResult.No)
                    e.Cancel = true;
            }
        }

        //Отображение (скрытие) пароля
        private void chViewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chViewPass.Checked)
                txPass.UseSystemPasswordChar = false;
            else
                txPass.UseSystemPasswordChar = true;
            txPass.Focus();
        }

        //Проверка, сохранены ли настройки
        private bool CheckSaveSettings()
        {
            bool server = ser != StudentStatistic.Properties.Settings.Default.server;
            bool dbN = db != StudentStatistic.Properties.Settings.Default.database;
            bool login = log != StudentStatistic.Properties.Settings.Default.login;
            bool pass = pas != StudentStatistic.Properties.Settings.Default.pass;
            if (server || dbN || login || pass)
                return true;
            else
                return false;
        }

        //Изменение данных в формах ввода
        private void txServerName_TextChanged(object sender, EventArgs e)
        {
            ser = txServerName.Text;
        }
        private void txDBname_TextChanged(object sender, EventArgs e)
        {
            db = txDBname.Text;
        }
        private void txLogin_TextChanged(object sender, EventArgs e)
        {
            log = txLogin.Text;
        }
        private void txPass_TextChanged(object sender, EventArgs e)
        {
            pas = txPass.Text;
        }
    }
}
