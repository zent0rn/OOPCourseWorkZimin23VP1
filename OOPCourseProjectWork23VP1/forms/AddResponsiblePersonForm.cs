using OOPCourseWorkZimin23VP1.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPCourseWorkZimin23VP1.forms
{
    /// <summary>
    /// Форма добавления ответственного лица
    /// </summary>
    public partial class AddResponsiblePersonForm : Form
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public AddResponsiblePersonForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия на кнопку добавить ответственное лицо. 
        /// При нажатии происходит валидация введённых данных 
        /// и добавление ответственного лица, если данные корректны.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            if (RespPersonNameTextBox.Text == "" || RespPersonNameTextBox.Text == null)
            {
                MessageBox.Show("Введите имя", "Ошибка",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (RespPersonPhoneTextBox.Text == "" || RespPersonPhoneTextBox.Text == null)
            {
                MessageBox.Show("Введите телефон", "Ошибка",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsValidEmail(RespPersonEmailTextBox.Text))
            {
                MessageBox.Show("Введите корректный email", "Ошибка",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string name = RespPersonNameTextBox.Text;
                string phone = RespPersonPhoneTextBox.Text;
                string email = RespPersonEmailTextBox.Text;

                ResponsiblePersonRepository repo = new ResponsiblePersonRepository();
                repo.AddPerson(name, phone, email);

                MessageBox.Show("Ответственное лицо успешно добавлено", "Успех",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Метод для валидации email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Простая, но эффективная проверка основных требований
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
