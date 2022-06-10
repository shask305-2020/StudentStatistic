using StudentStatistic.Properties;
using StudentStatistic.Classes;
using System;
using System.Windows.Forms;
using Encryption;

namespace MySQL_Client
{
    public partial class SettingsApp : Form
    {
        //Переменные, в которых сохраняются данные из полей ввода
        private string _ser, _db, _log, _pas;

        //Поля дешифрованных логина и пароля
        private string _user, _password;

        //Шифрование логина и пароля
        private string User
        {
            get
            {
                _user = Shifr.GetShifr(Settings.Default.login, 12);
                return _user;
            }
            set
            {
                _user = value;
                Settings.Default.login = Shifr.SetShifr(_user, 12);
            }
        }
        private string Password { get; set; }

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
            _ser = txServerName.Text;
            _db = txDBname.Text;
            _log = txLogin.Text;
            _pas = txPass.Text;
        }

        //Загрузка сохраненных настроек
        private void LoadSettings()
        {
            txServerName.Text = Settings.Default.server;
            txDBname.Text = Settings.Default.database;
            txLogin.Text = Settings.Default.login;
            _password = Shifr.GetShifr(Settings.Default.pass, 12);
            txPass.Text = Shifr.GetShifr(Settings.Default.pass, 12);
            WriteVariable();
        }

        //Проверка, чтобы все поля ввода были заполнены
        private bool Valid()
        {
            WriteVariable();
            bool server = _ser != "";
            bool dbN = _db != "";
            bool login = _log != "";
            bool pass = _pas != "";
            if (server && dbN && login && pass)
                return true;
            else
                return false;
        }

        //Сохранение настроек
        private void SaveSettings()
        {
            Settings.Default.server = _ser;
            Settings.Default.database = _db;
            Settings.Default.login = _log;
            Settings.Default.pass = _pas;
            Settings.Default.Save();
        }

        //Кнопка "Примененить настройки"
        private void btApply_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                bool check = ClassMySQL.CheckConnect(_ser, _db, _log, _pas);
                if (!check)
                    return;
                SaveSettings();
                ClassMySQL.DB_Load(_ser, _db, _log, _pas);
                MyMessage.MessageSaveSettings();
                Close();
            }
            else
            {
                MyMessage.MessageInformation();
            }
        }

        //Проверка сохранения настроек при закрытии окна
        private void SettingsApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CheckSaveSettings())
            {
                DialogResult dialog = MyMessage.MessageClose();
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
            bool server = _ser != Settings.Default.server;
            bool dbN = _db != Settings.Default.database;
            bool login = _log != Settings.Default.login;
            bool pass = _pas != Settings.Default.pass;
            if (server || dbN || login || pass)
                return true;
            else
                return false;
        }

        //Изменение данных в формах ввода
        private void txServerName_TextChanged(object sender, EventArgs e)
        {
            _ser = txServerName.Text;
        }
        private void txDBname_TextChanged(object sender, EventArgs e)
        {
            _db = txDBname.Text;
        }
        private void txLogin_TextChanged(object sender, EventArgs e)
        {
            _log = txLogin.Text;
        }
        private void txPass_TextChanged(object sender, EventArgs e)
        {
            _pas = txPass.Text;
        }
    }
}
