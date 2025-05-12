using OOPCourseWorkZimin23VP1.dbServices;
using OOPCourseWorkZimin23VP1.forms;
using OOPCourseWorkZimin23VP1.tools;
using System.Data;

namespace OOPCourseProjectWork23VP1
{
    /// <summary>
    /// Главная форма приложения
    /// </summary>
    public partial class FurnitureForm : Form
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public FurnitureForm()
        {
            InitializeComponent();
            InitializeContextMenu();
            //StartWindowForm startForm = new StartWindowForm();
            //startForm.ShowDialog();
            this.Select();
            //TopMost = true;
        }

        /// <summary>
        /// Создание репозитория мебели
        /// </summary>
        FurnitureRepository _furnitureRepo = new FurnitureRepository();

        /// <summary>
        /// Создание репозитория помещений
        /// </summary>
        RoomRepository _roomRepo = new RoomRepository();

        /// <summary>
        /// Создание репозитория ответственных лиц
        /// </summary>
        ResponsiblePersonRepository _personRepo = new ResponsiblePersonRepository();

        /// <summary>
        /// Метод для инициализации контекстного меню для таблицы
        /// </summary>
        private void InitializeContextMenu()
        {
            // Создаем контекстное меню
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            // Пункт "Редактировать"
            ToolStripMenuItem editItem = new ToolStripMenuItem("Редактировать");
            editItem.Click += EditMenuItem_Click;
            contextMenu.Items.Add(editItem);

            // Пункт "Удалить"
            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Удалить");
            deleteItem.Click += DeleteMenuItem_Click;
            contextMenu.Items.Add(deleteItem);

            // Назначаем меню DataGridView
            FurnitureDataGridView.ContextMenuStrip = contextMenu;
            RoomsDataGridView.ContextMenuStrip = contextMenu;
            RespPersonsDataGridView.ContextMenuStrip = contextMenu;
            // Включаем выделение строки при правом клике
            FurnitureDataGridView.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    var hit = FurnitureDataGridView.HitTest(e.X, e.Y);
                    if (hit.RowIndex >= 0)
                    {
                        FurnitureDataGridView.ClearSelection();
                        RoomsDataGridView.ClearSelection();
                        RespPersonsDataGridView.ClearSelection();
                        FurnitureDataGridView.Rows[hit.RowIndex].Selected = true;
                    }
                }
            };

            RoomsDataGridView.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    var hit = RoomsDataGridView.HitTest(e.X, e.Y);
                    if (hit.RowIndex >= 0)
                    {
                        FurnitureDataGridView.ClearSelection();
                        RoomsDataGridView.ClearSelection();
                        RespPersonsDataGridView.ClearSelection();
                        RoomsDataGridView.Rows[hit.RowIndex].Selected = true;
                    }
                }
            };

            RespPersonsDataGridView.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    var hit = RespPersonsDataGridView.HitTest(e.X, e.Y);
                    if (hit.RowIndex >= 0)
                    {
                        FurnitureDataGridView.ClearSelection();
                        RoomsDataGridView.ClearSelection();
                        RespPersonsDataGridView.ClearSelection();
                        RespPersonsDataGridView.Rows[hit.RowIndex].Selected = true;
                    }
                }
            };
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "редактировать" контекстного меню таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            var (grid, id, refreshMethod) = GetSelectedGridInfo();
            if (grid == null) return;

            // Определяем тип формы редактирования в зависимости от выбранной таблицы
            Form editForm = grid switch
            {
                DataGridView g when g == FurnitureDataGridView => new EditFurnitureForm(id),
                DataGridView g when g == RoomsDataGridView => new EditRoomForm(id),
                DataGridView g when g == RespPersonsDataGridView => new EditPersonForm(id),
                _ => null
            };

            if (editForm != null && editForm.ShowDialog() == DialogResult.OK)
            {
                refreshMethod?.Invoke();
            }
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку "удалить" контекстного меню таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            var (grid, id, name, refreshMethod) = GetSelectedGridInfoWithName();
            if (grid == null) return;

            var entityType = grid switch
            {
                DataGridView g when g == FurnitureDataGridView => "мебель",
                DataGridView g when g == RoomsDataGridView => "помещение",
                DataGridView g when g == RespPersonsDataGridView => "ответственное лицо",
                _ => "элемент"
            };

            var result = MessageBox.Show(
                $"Вы уверены, что хотите удалить {entityType}: '{name}'? " +
                $"Если есть связанные объекты, они также будут удалены.",
                "Подтверждение удаления",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            try
            {
                bool deleteResult = grid switch
                {
                    DataGridView g when g == FurnitureDataGridView => _furnitureRepo.DeleteFurniture(id),
                    DataGridView g when g == RoomsDataGridView => _roomRepo.DeleteRoom(id),
                    DataGridView g when g == RespPersonsDataGridView => _personRepo.DeletePerson(id),
                    _ => false
                };

                if (deleteResult)
                {
                    grid.Rows.Remove(grid.SelectedRows[0]);
                    refreshMethod?.Invoke();

                    MessageBox.Show($"{entityType.FirstCharToUpper()} успешно удален(а)", "Успех",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Не найден(а) {entityType} с данным ID!", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Получить информацию о выбранной таблице
        /// </summary>
        /// <returns></returns>
        private (DataGridView grid, int id, Action refreshMethod) GetSelectedGridInfo()
        {
            var info = GetSelectedGridInfoWithName();
            return (info.grid, info.id, info.refreshMethod);
        }

        /// <summary>
        /// Получить информацию о выбранной таблице
        /// </summary>
        /// <returns>Таблица, id, название, метод обновления данных</returns>
        private (DataGridView grid, int id, string name, Action refreshMethod) GetSelectedGridInfoWithName()
        {
            if (FurnitureDataGridView.SelectedRows.Count > 0)
            {
                var row = FurnitureDataGridView.SelectedRows[0];
                return (FurnitureDataGridView,
                       Convert.ToInt32(row.Cells["ID"].Value),
                       row.Cells["NameColumn"].Value.ToString(),
                       UpdateAllTablesData);
            }
            else if (RoomsDataGridView.SelectedRows.Count > 0)
            {
                var row = RoomsDataGridView.SelectedRows[0];
                return (RoomsDataGridView,
                       Convert.ToInt32(row.Cells["RoomIdColumn"].Value),
                       row.Cells["RoomNameColumn"].Value.ToString(),
                       UpdateAllTablesData);
            }
            else if (RespPersonsDataGridView.SelectedRows.Count > 0)
            {
                var row = RespPersonsDataGridView.SelectedRows[0];
                return (RespPersonsDataGridView,
                       Convert.ToInt32(row.Cells["RespPersonIDColumn"].Value),
                       row.Cells["RespPersonNameColumn"].Value.ToString(),
                       UpdateAllTablesData);
            }

            return (null, 0, null, null);
        }

        /// <summary>
        /// Обновить данные во всех таблицах
        /// </summary>
        private void UpdateAllTablesData()
        {
            UpdateFurnitureCountLabel();
            UpdateRoomCountLabel();
            UpdateResponsiblePersonCountLabel();
        }

        /// <summary>
        /// Обработчик кнопки "Delete"
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns>true, если клавиша обработана, false - если нет</returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Delete)
            {
                // Определяем активную вкладку и соответствующий DataGridView
                DataGridView activeGridView = null;

                switch (tabControl1.SelectedTab?.Name)
                {
                    case "tabPage1":
                        activeGridView = FurnitureDataGridView;
                        break;
                    case "tabPage2":
                        activeGridView = RoomsDataGridView;
                        break;
                    case "tabPage3":
                        activeGridView = RespPersonsDataGridView;
                        break;
                }

                // Проверяем, что нашли активный DataGridView и у него есть выделенная строка
                if (activeGridView != null && activeGridView.Focused &&
                    activeGridView.CurrentCell != null &&
                    !activeGridView.CurrentCell.IsInEditMode)
                {
                    int rowIndex = activeGridView.CurrentCell.RowIndex;

                    // Проверяем, что строка существует и не является пустой строкой для новых записей
                    if (rowIndex >= 0 && rowIndex < activeGridView.Rows.Count - (activeGridView.AllowUserToAddRows ? 1 : 0))
                    {
                        // Выделяем всю строку
                        activeGridView.Rows[rowIndex].Selected = true;

                        // Вызываем обработчик удаления
                        DeleteMenuItem_Click(null, null);
                        return true; // Сообщаем, что клавиша обработана
                    }
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Обновить данные о количестве найденных элементов
        /// </summary>
        private void UpdateFurnitureCountLabel()
        {
            FindFurnitureButton_Click(null, null);
            int count = _furnitureRepo.SearchFurniture().Count();
            ResTextBox.Text = $"Найдено {count} записей";
        }

        /// <summary>
        /// Обновить данные о количестве найденных элементов
        /// </summary>
        private void UpdateRoomCountLabel()
        {
            FindRoomsButton_Click(null, null);
            int count = _roomRepo.SearchRooms().Count();
            RoomsResTextBox.Text = $"Найдено {count} записей";
        }

        /// <summary>
        /// Обновить данные о количестве найденных элементов
        /// </summary>
        private void UpdateResponsiblePersonCountLabel()
        {
            FindPersonButton_Click(null, null);
            int count = _personRepo.SearchPersons().Count();
            RespPersonsResTextBox.Text = $"Найдено {count} записей";
        }
        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обработчик события загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FurnitureForm_Load(object sender, EventArgs e)
        {
            ResTextBox.Visible = false;
            RoomsResTextBox.Visible = false;
            RespPersonsResTextBox.Visible = false;


        }

        private void FurnitureMadeByTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void AddFurnitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFurnitureForm form = new AddFurnitureForm();
            form.ShowDialog();
            FindFurnitureButton_Click(null, null);
        }

        /// <summary>
        /// Обработчик нажатия на кнопку "найти мебель". 
        /// Находит мебель, соответствующую введённым критериям.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindFurnitureButton_Click(object sender, EventArgs e)
        {
            try
            {
                ResTextBox.Text = "";


                FurnitureDataGridView.Rows.Clear();

                var name = FurnitureNameTextBox.Text.Trim();
                var type = FurnitureTypeTextBox.Text.Trim();
                var material = FurnitureMaterialTextBox.Text.Trim();
                var madeBy = FurnitureMadeByTextBox.Text.Trim();
                int roomID = (int)FurnitureRoomNumeric.Value;

                _furnitureRepo.RefreshContext();
                var results = _furnitureRepo.SearchFurniture(name, type, material, madeBy, roomID);

                foreach (var item in results)
                {
                    FurnitureDataGridView.Rows.Add(
                        item.ID,
                        item.Name,
                        item.Type,
                        item.Material,
                        item.MadeByCountry,
                        item.Room_ID,
                        item.Price + " руб.",
                        item.ValueInRoom
                        );

                }
                ResTextBox.Visible = true;
                ResTextBox.Text = $"Найдено {results.Count()} записей";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}");
            }
        }


        /// <summary>
        /// Обработчик нажатия на кнопку "найти помещения". 
        /// При нажатии находит все помещения, соответствующие введённым критериям.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindRoomsButton_Click(object sender, EventArgs e)
        {

            RoomsResTextBox.Text = "";
            RoomsDataGridView.Rows.Clear();

            var name = NameOfRoomTextBox.Text.Trim();
            var adress = AdressOfRoomTextBox.Text.Trim();
            int area = (int)AreaOfRoomNumeric.Value;

            var results = _roomRepo.SearchRooms(name, adress, area);

            foreach (var item in results)
            {
                RoomsDataGridView.Rows.Add(
                    item.ID,
                    item.Name,
                    item.Adress,
                    item.Area,
                    item.Responsible_Person_ID
                    );

            }
            RoomsResTextBox.Visible = true;
            RoomsResTextBox.Text = $"Найдено {results.Count()} записей";

        }

        /// <summary>
        /// Обработчик нажатия на кнопку "сбросить параметры поиска".
        /// При нажатии сбрасывает все параметры поиска.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetSearchParametersButton_Click(object sender, EventArgs e)
        {
            var name = FurnitureNameTextBox.Text = "";
            var type = FurnitureTypeTextBox.Text = "";
            var material = FurnitureMaterialTextBox.Text = "";
            var madeBy = FurnitureMadeByTextBox.Text = "";
            var room = FurnitureRoomNumeric.Value = 0;
        }


        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Обработчик нажатия на кнопку "сбросить параметры поиска".
        /// При нажатии сбрасывает все параметры поиска.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetRoomSearchParButt_Click(object sender, EventArgs e)
        {
            NameOfRoomTextBox.Text = "";
            AdressOfRoomTextBox.Text = "";
            AreaOfRoomNumeric.Value = 0;
            PersonIDNumeric.Value = 0;

        }

        private void FurnitureDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRoomForm form = new AddRoomForm();
            form.ShowDialog();
            FindRoomsButton_Click(null, null);
        }

        /// <summary>
        /// Обработчик нажатия на кнопку "найти ответственных".
        /// При нажатии находит соответствующих введённым параметрам ответственных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindPersonButton_Click(object sender, EventArgs e)
        {

            RespPersonsResTextBox.Text = "";
            RespPersonsDataGridView.Rows.Clear();

            var name = PersonNameTextBox.Text.Trim();
            var phone = PersonPhoneTextBox.Text.Trim();
            string email = PersonEmailTextBox.Text.Trim();

            var results = _personRepo.SearchPersons(name, phone, email);

            foreach (var item in results)
            {
                RespPersonsDataGridView.Rows.Add(
                    item.ID,
                    item.FullName,
                    item.Phone,
                    item.Email
                    );

            }
            RespPersonsResTextBox.Visible = true;
            RespPersonsResTextBox.Text = $"Найдено {results.Count()} записей";
        }

        /// <summary>
        /// Обработчик нажатия на кнопку "сбросить параметры поиска".
        /// При нажатии сбрасывает все параметры поиска.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetPersonSearchParButton_Click(object sender, EventArgs e)
        {
            PersonNameTextBox.Text = "";
            PersonPhoneTextBox.Text = "";
            PersonEmailTextBox.Text = "";
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void AddRespPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddResponsiblePersonForm form = new AddResponsiblePersonForm();
            form.ShowDialog();
            FindPersonButton_Click(null, null);
        }

        private void FurnitureInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable furnitureData = _furnitureRepo.getDb().GetFurnitureDataTable();

            // Генерируем отчет
            PdfReportGenerator.GenerateFurnitureReport(furnitureData);
        }

        private void RoomsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable roomsData = _roomRepo.getDb().GetRoomDataTable();

            // Генерируем отчет
            PdfReportGenerator.GenerateRoomsReport(roomsData);
        }

        private void RespPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable personData = _personRepo.getDb().GetResponsiblePersonDataTable();

            // Генерируем отчет
            PdfReportGenerator.GeneratePersonsReport(personData);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            string dbPath = null;
            dbPath = StartWindowForm.ShowCreateDatabaseDialog();

            if (!string.IsNullOrEmpty(dbPath))
            {
                DatabaseService.Initialize(dbPath);


                _furnitureRepo = new FurnitureRepository();


                _roomRepo = new RoomRepository();


                _personRepo = new ResponsiblePersonRepository();

                UpdateAllTablesData();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (_furnitureRepo.DeleteAllFurniture() &&
                _roomRepo.DeleteAllRooms() &&
                _personRepo.DeleteAllResponsiblePersons())
            {
                MessageBox.Show($"База данных успешно очищена");
                UpdateAllTablesData();
            }
            else
            {
                MessageBox.Show($"Ошибка при очистке БД");
            }

        }

        private void toolStripDropDownButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string dbPath = null;
            dbPath = StartWindowForm.ShowOpenDatabaseDialog();

            if (!string.IsNullOrEmpty(dbPath))
            {
                DatabaseService.Initialize(dbPath);


                _furnitureRepo = new FurnitureRepository();


                _roomRepo = new RoomRepository();


                _personRepo = new ResponsiblePersonRepository();

                MessageBox.Show($"База данных успешно открыта");

                UpdateAllTablesData();

                
            }
        }
    }
}






// Метод расширения для первой буквы в верхнем регистре
public static class StringExtensions
{
    public static string FirstCharToUpper(this string input)
    {
        return input switch
        {
            null => throw new ArgumentNullException(nameof(input)),
            "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
            _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1))
        };
    }
}