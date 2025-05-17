using OOPCourseProjectWork23VP1;
using OOPCourseWorkZimin23VP1.dbServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace OOPCourseWorkZimin23VP1.forms
{
    /// <summary>
    /// Приветственная форма
    /// </summary>
    public partial class StartWindowForm : Form
    {
        public static class DatabaseHelper
        {
            public static string ShowCreateDatabaseDialog()
            {
                using (var saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "SQLite Database (*.db)|*.db";
                    saveDialog.Title = "Создать новую базу данных";
                    saveDialog.RestoreDirectory = true; // Важно для установленного приложения

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            CreateNewDatabase(saveDialog.FileName);
                            return saveDialog.FileName;
                        }
                        catch
                        {
                            return null;
                        }
                    }
                }

                return null;
            }

            public static string ShowOpenDatabaseDialog()
            {
                using (var openDialog = new OpenFileDialog())
                {
                    openDialog.Filter = "SQLite Database (*.db)|*.db";
                    openDialog.Title = "Открыть базу данных";
                    openDialog.RestoreDirectory = true; // Важно для установленного приложения
                    openDialog.CheckFileExists = true; // Проверка существования файла

                    if (openDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (File.Exists(openDialog.FileName)) // Дополнительная проверка
                        {
                            return openDialog.FileName;
                        }

                        MessageBox.Show("Файл базы данных не найден!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                return null;
            }


            public static void CreateNewDatabase(string path)
            {
                try
                {
                    string directory = Path.GetDirectoryName(path);
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }

                    using (var context = new FurnitureDBContext(path))
                    {
                        context.Database.EnsureCreated();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при создании БД: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        private Timer autoStartTimer;

        public StartWindowForm()
        {
            InitializeComponent();
            InitializeAutoStartTimer();
        }

        private void InitializeAutoStartTimer()
        {
            autoStartTimer = new Timer();
            autoStartTimer.Interval = 7000; // 7 секунд
            autoStartTimer.Tick += (s, e) =>
            {
                autoStartTimer.Stop();
                StartApplication();
            };
            autoStartTimer.Start();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            autoStartTimer.Stop();
            StartApplication();
        }

        private void StartApplication()
        {
            this.Hide();

            string dbPath = null;
            var choiceDialog = new DatabaseChoiceDialogForm();

            if (choiceDialog.ShowDialog() == DialogResult.OK)
            {
                switch (choiceDialog.UserChoice)
                {
                    case DatabaseChoiceDialogForm.ChoiceResult.CreateNew:
                        dbPath = DatabaseHelper.ShowCreateDatabaseDialog();
                        break;

                    case DatabaseChoiceDialogForm.ChoiceResult.OpenExisting:
                        dbPath = DatabaseHelper.ShowOpenDatabaseDialog();
                        break;
                }
            }

            if (!string.IsNullOrEmpty(dbPath))
            {
                try
                {
                    DatabaseService.Initialize(dbPath);
                    var form = new FurnitureForm();
                    form.FormClosed += (s, args) => Application.Exit();
                    form.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при подключении к БД: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}




