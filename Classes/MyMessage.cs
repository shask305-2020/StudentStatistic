using System;
using System.Windows.Forms;

namespace StudentStatistic.Classes
{
    internal static class MyMessage
    {
        //Ошибка операции
        public static void MessageError(Exception ex)
        {
            MessageBox.Show("Изменения не были применены\n\n" + ex.Message,
                    "Ошибка операции",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Настройки сохранены
        public static void MessageSaveSettings()
        {
            MessageBox.Show("Соединение установлено\nНастрйки сохранены и применены",
                    "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Заполните все обязательные поля
        public static void MessageInformation()
        {
            MessageBox.Show("Заполните все обязательные поля",
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        //Отсутствуют строки для редактирования
        public static void MessageNullRowEdit()
        {
            MessageBox.Show("Отсутствуют строки для редактирования",
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        //Отсутствуют строки для удаления
        public static void MessageNullRowDel()
        {
            MessageBox.Show("Отсутствуют строки для удаления",
                "Информация",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        //Данные не сохранены при выходе из формы
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
        
        // Удаление
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
