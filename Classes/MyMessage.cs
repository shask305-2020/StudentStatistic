using System;
using System.Windows.Forms;

namespace StudentStatistic.Classes
{
    internal static class MyMessage
    {
        //Заполните все обязательные поля
        public static void MessageInformation()
        {
            MessageBox.Show("Заполните все обязательные поля\n(Отмечены звездочкой)",
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        //Отсутствуют строки для редактирования
        public static void MessageNullRow()
        {
            MessageBox.Show("Отсутствуют строки для редактирования",
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        //Данные не сохранены
        public static DialogResult MessageClose()
        {
            DialogResult result;
            result = MessageBox.Show("Данные не сохранены\nВы уверены, что хотите выйти?",
                    "Подтвердите действие",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
            return result;
        }


        //Удаление
        //Вы уверены, что хотите удалить строку?
        public static DialogResult MessageDeletRow()
        {
            DialogResult result;
            result = MessageBox.Show("Вы уверены, что хотите удалить строку?",
                    "Подтвердите действие",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
            return result;
        }
        //Нельзя удалить данные
        public static void MessageDeleteError(Exception ex)
        {
            MessageBox.Show("Нельзя удалить данные\n" + ex.Message,
                    "Ошибка удаления",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
