using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using OOPCourseWorkZimin23VP1.entities;
using OOPCourseWorkZimin23VP1;
using OOPCourseWorkZimin23VP1.forms;
using OOPCourseWorkZimin23VP1.tools;
using System.Security.AccessControl;
using System.Data.Entity;

namespace OOPCourseProjectWork23VP1
{

    public partial class FurnitureForm : Form
    {

        public FurnitureForm()
        {
            InitializeComponent();
            InitializeContextMenu();
        }


        FurnitureRepository _furnitureRepo = new FurnitureRepository();
        RoomRepository _roomRepo = new RoomRepository();
        ResponsiblePersonRepository _personRepo = new ResponsiblePersonRepository();
        //ClientRepository _clientRepo = new ClientRepository();



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

        // Вспомогательные методы

        private (DataGridView grid, int id, Action refreshMethod) GetSelectedGridInfo()
        {
            var info = GetSelectedGridInfoWithName();
            return (info.grid, info.id, info.refreshMethod);
        }

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


        private void UpdateAllTablesData()
        {
            UpdateFurnitureCountLabel();
            UpdateRoomCountLabel();
            UpdateResponsiblePersonCountLabel();
        }

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


        private void UpdateFurnitureCountLabel()
        {
            FindFurnitureButton_Click(null, null);
            int count = _furnitureRepo.SearchFurniture().Count();
            ResTextBox.Text = $"Найдено {count} записей";
        }

        private void UpdateRoomCountLabel()
        {
            FindRoomsButton_Click(null, null);
            int count = _roomRepo.SearchRooms().Count();
            RoomsResTextBox.Text = $"Найдено {count} записей";
        }

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


        private void FurnitureForm_Load(object sender, EventArgs e)
        {
            ResTextBox.Visible = false;
            RoomsResTextBox.Visible = false;
            RespPersonsResTextBox.Visible = false;


        }

        private void FurnitureMadeByTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /*
        private void FurnitureDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == FurnitureDataGridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                var result = MessageBox.Show("Удалить эту запись?", "Подтверждение",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(FurnitureDataGridView.Rows[e.RowIndex].Cells["ID"].Value);

                    try
                    {

                        bool removeFurniture = _furnitureRepo.DeleteFurniture(id);
                        if (removeFurniture)
                        {
                            FurnitureDataGridView.Rows.RemoveAt(e.RowIndex);
                            MessageBox.Show("Мебель успешно удалена", "Успех",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Не найдена мебель с данным ID!", "Ошибка",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        */
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

        /*
        private string GetSelectedSortBy()
        {
            if (OrderByNameRadio.Checked) return "Name";
            if (OrderByMadeByRadio.Checked) return "MadeBy";
            if (OrderByTypeRadio.Checked) return "Type";
            if (OrderByMaterialRadio.Checked) return "Material";
            if (OrderByRoomRadio.Checked) return "Room";
            if (OrderByPriceRadio.Checked) return "Price";
            if (OrderByValueInRoom.Checked) return "ValueInRoom";
            return "Name"; // Сортировка по умолчанию
        }

        private string GetSelectedClientSortBy()
        {
            if (OrderClientsByNameRadio.Checked) return "Name";
            if (OrderClientsByPhoneNumberRadio.Checked) return "Phone";
            if (OrderClientsByNumbOfOrdersRadio.Checked) return "NumbOfOrders";
            if (OrderClientsByEmailRadio.Checked) return "Email";
            if (OrderClientsByAdressRadio.Checked) return "Adress";
            return "Name"; // Сортировка по умолчанию
        }
        */
        private void FindFurnitureButton_Click(object sender, EventArgs e)
        {
            try
            {
                ResTextBox.Text = "";
                //db.Database.EnsureCreated();

                FurnitureDataGridView.Rows.Clear();

                var name = FurnitureNameTextBox.Text.Trim();
                var type = FurnitureTypeTextBox.Text.Trim();
                var material = FurnitureMaterialTextBox.Text.Trim();
                var madeBy = FurnitureMadeByTextBox.Text.Trim();
                int roomID = (int)FurnitureRoomNumeric.Value;
                //string sortBy = GetSelectedSortBy();
                //var ascending = OrderByAscending.Checked;

                //FindFurnitureButton.Enabled = true;
                //var furniture = db.Furniture.ToList();

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
            /*
            ClientsResTextBox.Text = "";

            ClientsDataGridView.Rows.Clear();
            var name = ClientNameTextBox.Text.Trim();
            var phone = ClientPhoneNumberTextBox.Text.Trim();
            var adress = ClientAdressTextBox.Text.Trim();
            var email = ClientEmailTextBox.Text.Trim();
            int numbOfOrders = (int)NumbOfClientOrdersNumeric.Value;
            string sortBy = GetSelectedClientSortBy();
            var ascending = OrderClientsByAscending.Checked;


            var results = _clientRepo.SearchAndSortClients(name, phone, adress, email, numbOfOrders, sortBy, ascending);

            foreach (var item in results)
            {
                ClientsDataGridView.Rows.Add(
                    item.ID,
                    item.Name,
                    item.PhoneNumber,
                    item.Address,
                    item.Email,
                    item.NumbOfOrders
                    );

            }
            ClientsResTextBox.Visible = true;
            ClientsResTextBox.Text = $"Найдено {results.Count()} записей";
            */
        }



        private void OrderByMaterialRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OrderByNameRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OrderByMadeByRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        /*
        private void ResetSortParametersButton_Click(object sender, EventArgs e)
        {
            OrderByNameRadio.Checked = true;
            OrderByMadeByRadio.Checked = false;
            OrderByTypeRadio.Checked = false;
            OrderByMaterialRadio.Checked = false;
            OrderByRoomRadio.Checked = false;
            OrderByDescending.Checked = true;
        }
        */

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

        private void ResetClientSearchParButt_Click(object sender, EventArgs e)
        {
            NameOfRoomTextBox.Text = "";
            AdressOfRoomTextBox.Text = "";

            AreaOfRoomNumeric.Value = 0;
            PersonIDNumeric.Value = 0;


        }
        /*
        private void ResetClientSortParButt_Click(object sender, EventArgs e)
        {
            OrderClientsByNameRadio.Checked = true;
            OrderClientsByPhoneNumberRadio.Checked = false;
            OrderClientsByNumbOfOrdersRadio.Checked = false;
            OrderClientsByEmailRadio.Checked = false;
            OrderClientsByAdressRadio.Checked = false;
            OrderClientsByAscending.Checked = false;
            OrderClientsByDescending.Checked = true;
        }
        */
        private void EditFurnitureDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditFurnitureForm form = new EditFurnitureForm();
            form.ShowDialog();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void FurnitureDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void AddRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRoomForm form = new AddRoomForm();
            form.ShowDialog();
        }

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

        private void ResetPersonSearchParButton_Click(object sender, EventArgs e)
        {
            PersonNameTextBox.Text = "";
            PersonPhoneTextBox.Text = "";
            PersonEmailTextBox.Text = "";
        }

        private void AddRespPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddResponsiblePersonForm form = new AddResponsiblePersonForm();
            form.ShowDialog();
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