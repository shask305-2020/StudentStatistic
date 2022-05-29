using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentStatistic.Classes
{
    public class ClassMySQL
    {
        private static MySqlConnectionStringBuilder db;     //Сборщик строки подключения
        private static MySqlConnection connection;          //Строка подключения
        private static MySqlCommand cmd;                    //SQL команда
        private static string sql;                          //Тект SQL команды

        //Создание строки подключения
        public static void DB_Load(string server, string database, string login, string pass)
        {
            db = new MySqlConnectionStringBuilder();
            db.Server = server;
            db.Database = database;
            db.UserID = login;
            db.Password = pass;
            db.CharacterSet = "utf8";
            connection = new MySqlConnection(db.ConnectionString);
        }

        //Проверка соединения с конкретной БД на сервере MySQL
        public static bool CheckConnect(string server, string database, string login, string pass)
        {
            DB_Load(server, database, login, pass);
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проблемы с подключением к БД\n" + ex.Message, "Ошибка соединения",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }

        //Загрузка данных из БД (по названию таблицы, без фильтра)
        public static DataTable LoadTable(string tableName)
        {
            DataTable dt = new DataTable();
            sql = string.Format($"SELECT * FROM {db.Database}.{tableName}");
            cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        //Загрузка данных из БД (по названию таблицы, с фильтром по id (ключевое поле))
        public static DataTable LoadTable_Filtre(string tableName, int id)
        {
            sql = string.Format($"SELECT * FROM {db.Database}.{tableName} WHERE id = @id");
            cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", MySqlDbType.Int32);
            cmd.Parameters["@id"].Value = id;

            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        //Загрузка данных из БД (по названию таблицы, с фильтром по конкретному поле)
        public static DataTable LoadTable_Filtre(string tableName, string columnName, int value)
        {
            sql = string.Format($"SELECT * FROM {db.Database}.{tableName} WHERE {columnName} = @value");
            cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@value", MySqlDbType.Int32);
            cmd.Parameters["@value"].Value = value;

            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        //Добавление данных в таблицу (если нужно вставить значение в одно поле)
        public static void AddRow(string tableName, string value)
        {
            sql = string.Format($"INSERT INTO {db.Database}.{tableName} VALUES (@value)");
            cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@value", value);

            BlokTry();
        }

        //Добавление строки в таблицу "Группы"
        internal static void AddRow_Group(int id_spec, int kurs, string name)
        {
            sql = string.Format($"INSERT INTO {db.Database}.groups " +
                $"(id_spec, kurs, name) " +
                $"VALUES (@id_spec, @kurs, @name)");
            cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
                //Добавляем параметры
            cmd.Parameters.Add("@id_spec", MySqlDbType.Int32);
            cmd.Parameters.Add("@kurs", MySqlDbType.Int32);
            cmd.Parameters.Add("@name", MySqlDbType.VarChar, 10);
                //Присваивание переменным значений
            cmd.Parameters["@id_spec"].Value = id_spec;
            cmd.Parameters["@kurs"].Value = kurs;
            cmd.Parameters["@name"].Value = name;

            BlokTry();
        }

        //Редактируем данные в таблице "Группы"
        internal static void EditRow_Group(int id_group, int id_spec, int kurs, string name)
        {
            //Пока команда, в будущем планирую создать хранимую роцедуру
            sql = string.Format($"UPDATE {db.Database}.groups SET id_spec = @id_spec, kurs = @kurs, name = @name " +
                $"WHERE id = @id_group");
            cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
                //Параметры (перменные)
            cmd.Parameters.Add("@id_group", MySqlDbType.Int32);
            cmd.Parameters.Add("@id_spec", MySqlDbType.Int32);
            cmd.Parameters.Add("@kurs", MySqlDbType.Int32);
            cmd.Parameters.Add("@name", MySqlDbType.VarChar, 10);
                //Присваивание переменным значений
            cmd.Parameters["@id_group"].Value = id_group;
            cmd.Parameters["@id_spec"].Value = id_spec;
            cmd.Parameters["@kurs"].Value = kurs;
            cmd.Parameters["@name"].Value = name;

            BlokTry();
        }
        
        //Блок Try - Catch
        private static void BlokTry()
        {
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MyMessage.MessageDeleteError(ex);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }

        //Добавление строки в таблицу "Специальности"
        public static void AddRow_Spec(string code, string name, string sokr, int id_level, int id_base)
        {
                //Пока команда, в будущем планирую создать хранимую роцедуру
            sql = string.Format($"INSERT INTO {db.Database}.spec (code, name, sokr, id_level, id_base) " +
                $"VALUES (@code, @name, @sokr, @id_level, @id_base)");
            cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
                //Параметры (перменные)
            cmd.Parameters.Add("@code", MySqlDbType.VarChar, 10);
            cmd.Parameters.Add("@name", MySqlDbType.VarChar, 45);
            cmd.Parameters.Add("@sokr", MySqlDbType.VarChar, 45);
            cmd.Parameters.Add("@id_level", MySqlDbType.Int32);
            cmd.Parameters.Add("@id_base", MySqlDbType.Int32);
                //Присваивание переменным значений
            cmd.Parameters["@code"].Value = code;
            cmd.Parameters["@name"].Value = name;
            cmd.Parameters["@sokr"].Value = sokr;
            cmd.Parameters["@id_level"].Value = id_level;
            cmd.Parameters["@id_base"].Value = id_base;

            BlokTry();
        }

        //Редактирование строки в таблице "Специальности"
        public static void EditRow_Spec(int id, string code, string name, string sokr, int id_level, int id_base)
        {
            //Пока команда, в будущем планирую создать хранимую роцедуру
            sql = string.Format($"UPDATE {db.Database}.spec SET code = @code, name = @name, sokr = @sokr, id_level = @id_level, id_base = @id_base " +
                $"WHERE id = @id_spec");
            cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
                //Параметры (перменные)
            cmd.Parameters.Add("@code", MySqlDbType.VarChar, 10);
            cmd.Parameters.Add("@name", MySqlDbType.VarChar, 45);
            cmd.Parameters.Add("@sokr", MySqlDbType.VarChar, 45);
            cmd.Parameters.Add("@id_level", MySqlDbType.Int32);
            cmd.Parameters.Add("@id_base", MySqlDbType.Int32);
            cmd.Parameters.Add("@id_spec", MySqlDbType.Int32);
                //Присваивание переменным значений
            cmd.Parameters["@id_spec"].Value = id;
            cmd.Parameters["@code"].Value = code;
            cmd.Parameters["@name"].Value = name;
            cmd.Parameters["@sokr"].Value = sokr;
            cmd.Parameters["@id_level"].Value = id_level;
            cmd.Parameters["@id_base"].Value = id_base;

            BlokTry();
        }

        //Удаление строки в БД (по таблице)
        public static void DeleteRow(string tableName, int id)
        {
            //Пока команда, в будущем планирую создать хранимую роцедуру
            sql = string.Format($"DELETE FROM {db.Database}.{tableName} WHERE id = @id");
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.Int32);
            cmd.Parameters["@id"].Value = id;

            BlokTry();
        }
    }
}
