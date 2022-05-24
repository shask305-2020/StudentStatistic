using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentStatistic.Classes
{
    public class Person
    {
        private int age = 0;
        public static int retirementAge = 65;   //Пенсионный возраст
        private DateTime dateOfBirth;


        public int Age
        {
            private set
            {
                if (value < 0 || value > 120)
                    MessageBox.Show("Возраст должен быть в диапазоне от 0 до 120");
                else
                    age = value;
            }
            get { return age; }
        }

        //Свойство (дата рождения)
        public DateTime DateOfBirth
        {
            set
            {
                if (dateOfBirth > DateTime.Today)
                    MessageBox.Show("Дата рождения не может быть позже текущей");
                else
                {
                    dateOfBirth = value;
                    Age = AgeOfPeople(DateOfBirth); //Установление возраста
                }
            }
            get { return dateOfBirth; }
        }

        //Вычисление возраста человека (в годах)
        private int AgeOfPeople(DateTime dateOfBirth)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - dateOfBirth.Year;

            if (dateOfBirth > now.AddYears(-age))
                age--;  //Уменьшаем возраст на год, т.к. день рождения еще не наступил в текущем году
            return age;
        }

        //Проверка, находится ли человек на пенсии или нет
        public bool СheckAge()
        {
            if (age >= retirementAge)
                return true;    //На пенсии
            else
                return false;   //Не на пенсии
        }
    }
}
