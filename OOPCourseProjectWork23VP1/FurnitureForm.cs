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

/*
    * TODO:
    * 1. Классы для каждой сущности из бд: Client, Furniture +
    * 2. Вывод данных в таблицу для Furniture                +
    * 3. Вывод данных в таблицу для Client                   +
    * 4. Форма добавления мебели                             +
    * 5. Форма удаления мебели                               +
    * 6. Форма редактирования мебели                         +
    * 7. Форма добавления клиента       
    * 8. Форма удаления клиента                              
    * 9. Форма редактирования клиента
    * 10. Форма приветственная                               +
    * 11. Поиск и сортировка                                 +
    * 12. Перенести действия с бд в отдельные классы         +
    * 13. Форма добавления помещения                         +
    * 14. Форма удаления помещения                             
    * 15. Форма редактирования помещения     
    * 16. Форма добавления заказа                        
    * 17. Форма удаления заказа                           
    * 18. Форма редактирования заказа
    * 
    */

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
                        FurnitureDataGridView.Rows[hit.RowIndex].Selected = true;
                    }
                }
            };
        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {
            if (FurnitureDataGridView.SelectedRows.Count == 0) return;

            var selectedRow = FurnitureDataGridView.SelectedRows[0];
            int furnitureId = Convert.ToInt32(selectedRow.Cells["ID"].Value);

            // Открываем форму редактирования
            var editForm = new EditFurnitureForm(furnitureId);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Обновляем данные в таблице после редактирования
                FindFurnitureButton_Click(null, null);
            }
        }

        private async void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            if (FurnitureDataGridView.SelectedRows.Count == 0) return;

            var selectedRow = FurnitureDataGridView.SelectedRows[0];
            int furnitureId = Convert.ToInt32(selectedRow.Cells["ID"].Value);
            string furnitureName = selectedRow.Cells["NameColumn"].Value.ToString();

            var result = MessageBox.Show(
                $"Вы уверены, что хотите удалить мебель '{furnitureName}'?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool delFurniture = _furnitureRepo.DeleteFurniture(furnitureId);
                    if (delFurniture)
                    {

                        // Удаляем строку из таблицы
                        FurnitureDataGridView.Rows.Remove(selectedRow);
                        /*
                        ResTextBox.Visible = true;
                        ResTextBox.Text = "Мебель успешно удалена";
                        */
                        UpdateCountLabel();

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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Delete && (FurnitureDataGridView.Focused ||
                RoomsDataGridView.Focused || RespPersonsDataGridView.Focused))
            {
                // Получаем текущую выделенную ячейку или строку
                if (FurnitureDataGridView.CurrentCell != null)
                {
                    int rowIndex = FurnitureDataGridView.CurrentCell.RowIndex;
                    if (rowIndex >= 0 && rowIndex < FurnitureDataGridView.Rows.Count)
                    {
                        // Выделяем всю строку для удаления
                        FurnitureDataGridView.Rows[rowIndex].Selected = true;
                        DeleteMenuItem_Click(null, null);
                        return true;
                    }
                }
                else if (RoomsDataGridView.CurrentCell != null)
                {
                    int rowIndex = RoomsDataGridView.CurrentCell.RowIndex;
                    if (rowIndex >= 0 && rowIndex < RoomsDataGridView.Rows.Count)
                    {
                        // Выделяем всю строку для удаления
                        RoomsDataGridView.Rows[rowIndex].Selected = true;
                        DeleteMenuItem_Click(null, null);
                        return true;
                    }
                }
                else if (RespPersonsDataGridView.CurrentCell != null)
                {
                    int rowIndex = FurnitureDataGridView.CurrentCell.RowIndex;
                    if (rowIndex >= 0 && rowIndex < FurnitureDataGridView.Rows.Count)
                    {
                        // Выделяем всю строку для удаления
                        FurnitureDataGridView.Rows[rowIndex].Selected = true;
                        DeleteMenuItem_Click(null, null);
                        return true;
                    }
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void UpdateCountLabel()
        {
            int count = _furnitureRepo.SearchFurniture().Count();
            ResTextBox.Text = $"Найдено {count} записей";
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
                    item.Area
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

        private void RemoveFurnitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveFurnitureForm form = new RemoveFurnitureForm();
            form.ShowDialog();
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

        private void FurnitureInfoToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
