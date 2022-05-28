using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentStatistic.Forms
{
    public partial class AddStudent : Form
    {
        //Поля, которые есть на форме
        //Нижнее подчеркивание в префиксе названия поля означает, что поле приватное
        private int _id;            //Приватное поле (id студента)
        private string _fam;        //Фамилия
        private string _name;       //Имя
        private string _otch;       //Отчество
        private int _groupe;        //Группа
        private int _gender;        //Пол
        private DateTime _birthday; //День рождения
        private int _year;          //Год поступления

        //Поля
        private string _mode;        //Режим работы (добавление или редактирование)


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
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            ReNameButton();
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
    }
}
