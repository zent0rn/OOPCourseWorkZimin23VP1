using OOPCourseWorkZimin23VP1.entities;
using OOPCourseWorkZimin23VP1.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPCourseWorkZimin23VP1.forms
{
    /// <summary>
    /// Форма для редактирования данных об ответственном лице
    /// </summary>
    public partial class EditPersonForm : Form
    {
        /// <summary>
        /// ID редактируемого ответственного лица
        /// </summary>
        int _id;

        /// <summary>
        /// Репозиторий ответственных лиц
        /// </summary>
        ResponsiblePersonRepository personRepo = new ResponsiblePersonRepository();

        /// <summary>
        /// Объект ответственного лица
        /// </summary>
        ResponsiblePerson _person;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public EditPersonForm()
        {
            InitializeComponent();
            this.Select();
        }

        /// <summary>
        /// Конструктор формы с параметром
        /// </summary>
        /// <param name="id">ID редактируемого ответственного</param>
        public EditPersonForm(int id)
        {
            InitializeComponent();
            _id = id;
            this.Select();
        }

        /// <summary>
        /// Валидация email
        /// </summary>
        /// <param name="email">Email</param>
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

        private bool ValidatePersonData()
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                errors.AppendLine("• Не указано имя ответственного лица");
            }

            if (string.IsNullOrWhiteSpace(phoneTextBox.Text))
            {
                errors.AppendLine("• Не указан телефон ответственного лица");
            }

            if (IsValidEmail(emailTextBox.Text))
            {
                errors.AppendLine("• Не правильно указан email ответственного лица");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show($"Обнаружены ошибки:\n{errors.ToString()}",
                              "Ошибка валидации",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidatePersonData())
                {
                    return;
                }
                else
                {

                    string name = nameTextBox.Text;
                    string phone = phoneTextBox.Text;
                    string email = emailTextBox.Text;

                    personRepo.EditPerson(_id, name, phone, email);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadPersonData()
        {
            try
            {
                _person = personRepo.getDb().ResponsiblePerson
                    .FirstOrDefault(f => f.ID == _id);

                if (_person != null)
                {
                    nameTextBox.Text = _person.FullName;
                    phoneTextBox.Text = _person.Phone;
                    emailTextBox.Text = _person.Email;
                }
                else
                {
                    MessageBox.Show($"Не найдено ответственное лицо с таким ID", "Ошибка",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        
        }


        private void EditPersonForm_Load(object sender, EventArgs e)
        {
            loadPersonData();

        }
    }
}
