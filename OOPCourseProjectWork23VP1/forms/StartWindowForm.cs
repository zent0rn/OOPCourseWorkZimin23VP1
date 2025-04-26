using OOPCourseProjectWork23VP1;
using OOPCourseWorkZimin23VP1.dbServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPCourseWorkZimin23VP1.forms
{
    /// <summary>
    /// Приветственная форма
    /// </summary>
    public partial class StartWindowForm : Form
    {
        private string defaultDbPath = Path.Combine(Directory.GetCurrentDirectory(), "OOPDataBase", "FurnitureDB.db");
        /// <summary>
        /// Конструктор формы
        /// </summary>
        public StartWindowForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private static string ShowCreateDatabaseDialog()
        {
            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "SQLite Database (*.db)|*.db";
                saveDialog.Title = "Создать новую базу данных";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    CreateNewDatabase(saveDialog.FileName);
                    return saveDialog.FileName;
                }
            }
            return null;
        }

        private static string ShowOpenDatabaseDialog()
        {
            using (var openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "SQLite Database (*.db)|*.db";
                openDialog.Title = "Открыть базу данных";
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    return openDialog.FileName;
                }
            }
            return null;
        }

        private static void CreateNewDatabase(string path)
        {
            try
            {
                using (var context = new FurnitureDBContext(path))
                {
                    context.Database.EnsureCreated();
                    // Здесь можно добавить начальные данные
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании БД: {ex.Message}");
                throw;
            }
        }

        private void StartButton_Click_1(object sender, EventArgs e)
        {
            // Скрываем стартовую форму вместо закрытия
            this.Hide();

            string dbPath = null;
            var choiceDialog = new DatabaseChoiceDialogForm();

            if (choiceDialog.ShowDialog() == DialogResult.OK)
            {
                switch (choiceDialog.UserChoice)
                {
                    case DatabaseChoiceDialogForm.ChoiceResult.CreateNew:
                        dbPath = ShowCreateDatabaseDialog();
                        break;

                    case DatabaseChoiceDialogForm.ChoiceResult.OpenExisting:
                        dbPath = ShowOpenDatabaseDialog();
                        break;
                }
            }

            if (!string.IsNullOrEmpty(dbPath))
            {
                DatabaseService.Initialize(dbPath);
                FurnitureForm form = new FurnitureForm();
                form.FormClosed += (s, args) => this.Close(); // Закрываем стартовую форму при закрытии основной
                form.ShowDialog();
            }
        }
    }
}
