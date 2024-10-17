using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        // Словарь для хранения задач, где ключом является дата, а значением — список задач
        private Dictionary<DateTime, List<string>> tasksByDate;
        public Form1()
        {
            InitializeComponent();
            // Инициализация словаря задач
            tasksByDate = new Dictionary<DateTime, List<string>>();
            // Подписка на событие изменения выбранной даты в календаре
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
        }
        // Метод для добавления новой задачи
        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            // Получение текста задачи из текстового поля
            string task = textBoxTask.Text;
            // Проверяем, что задача не пустая
            if (!string.IsNullOrEmpty(task))
            {
                // Получаем выбранную пользователем дату в календаре
                DateTime selectedDate = monthCalendar1.SelectionStart;
                // Если для выбранной даты еще нет задач, создаем новый список
                if (!tasksByDate.ContainsKey(selectedDate))
                {
                    tasksByDate[selectedDate] = new List<string>();
                }
                // Добавляем задачу к выбранной дате
                tasksByDate[selectedDate].Add(task);
                // Обновляем отображение задач для выбранной даты
                UpdateTaskList(selectedDate);
                // Очищаем текстовое поле для новой задачи
                textBoxTask.Clear();
            }
            else
            {
                // Показываем предупреждение, если задача не была введена
                MessageBox.Show("Введите задачу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Метод для удаления выбранной задачи
        private void buttonRemoveTask_Click(object sender, EventArgs e)
        {
            // Проверяем, что задача выбрана в списке
            if (listBoxTasks.SelectedItem != null)
            {
                // Получаем выбранную дату
                DateTime selectedDate = monthCalendar1.SelectionStart;
                // Получаем выбранную задачу
                string selectedTask = listBoxTasks.SelectedItem.ToString();
                // Удаляем задачу из списка задач для выбранной даты
                tasksByDate[selectedDate].Remove(selectedTask);
                // Обновляем отображение задач после удаления
                UpdateTaskList(selectedDate);
            }
            else
            {
                // Показываем предупреждение, если задача для удаления не выбрана
                MessageBox.Show("Выберите задачу для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Метод для установки напоминания на выбранную задачу
        private void buttonSetReminder_Click(object sender, EventArgs e)
        {
            // Получаем выбранную дату из dateTimePicker для напоминания
            DateTime selectedDate = dateTimePickerReminder.Value.Date;
            // Получаем выбранное время из другого dateTimePicker
            DateTime selectedTime = dateTimePickerTime.Value;
            // Объединяем выбранные дату и время для напоминания
            DateTime reminderDateTime = selectedDate.AddHours(selectedTime.Hour).AddMinutes(selectedTime.Minute);
            // Проверяем, что выбранное время напоминания находится в будущем
            if (reminderDateTime > DateTime.Now)
            {
                // Создаем таймер, который сработает в момент напоминания
                Timer reminderTimer = new Timer();
                // Устанавливаем интервал таймера до выбранного времени напоминания
                reminderTimer.Interval = (int)(reminderDateTime - DateTime.Now).TotalMilliseconds;
                // Добавляем событие, которое срабатывает при наступлении времени напоминания
                reminderTimer.Tick += (s, ev) =>
                {
                    // Останавливаем таймер
                    reminderTimer.Stop();
                    // Показываем сообщение с задачами на выбранную дату
                    MessageBox.Show("Напоминание: " + string.Join(", ", tasksByDate[selectedDate]), "Напоминание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
                // Запускаем таймер
                reminderTimer.Start();
                // Показываем подтверждение пользователю, что напоминание установлено
                MessageBox.Show("Напоминание установлено на " + reminderDateTime.ToString("f"), "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Показываем предупреждение, если пользователь выбрал прошедшее время для напоминания
                MessageBox.Show("Укажите время напоминания в будущем.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Метод для обновления списка задач в ListBox для выбранной даты
        private void UpdateTaskList(DateTime selectedDate)
        {
            // Очищаем текущий список задач
            listBoxTasks.Items.Clear();

            // Проверяем, есть ли задачи для выбранной даты
            if (tasksByDate.ContainsKey(selectedDate))
            {
                // Добавляем каждую задачу в список для отображения
                foreach (string task in tasksByDate[selectedDate])
                {
                    listBoxTasks.Items.Add(task);
                }
            }
        }
        // Метод для обновления списка задач при изменении выбранной даты в календаре
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Обновляем задачи для даты, которую выбрал пользователь
            UpdateTaskList(e.Start);
        }
    }
}