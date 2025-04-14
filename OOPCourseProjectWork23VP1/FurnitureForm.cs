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
            ClientsResTextBox.Visible = false;

        }

        private void FurnitureMadeByTextBox_TextChanged(object sender, EventArgs e)
        {

        }

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
                        using (var db = new FurnitureDBContext())
                        {
                            var furniture = db.Furniture.Find(id);
                            if (furniture != null)
                            {
                                db.Furniture.Remove(furniture);
                                db.SaveChanges();

                                FurnitureDataGridView.Rows.RemoveAt(e.RowIndex);
                                ResTextBox.Visible = true;
                                ResTextBox.Text = "Запись удалена!";
                            }
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
        }

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
            string sortBy = GetSelectedSortBy();
            var ascending = OrderByAscending.Checked;

            //FindFurnitureButton.Enabled = true;
            //var furniture = db.Furniture.ToList();

            FurnitureRepository repo = new FurnitureRepository();
            var results = repo.SearchAndSortFurniture(name, type, material, madeBy, roomID, sortBy, ascending);

            foreach (var item in results)
            {
                FurnitureDataGridView.Rows.Add(
                    item.ID,
                    item.Name,
                    item.Type,
                    item.Material,
                    item.MadeByCountry,
                    item.Room_ID,
                    item.Price.ToString("C"),
                    item.ValueInRoom
                    );

            }
            ResTextBox.Visible = true;
            ResTextBox.Text = $"Найдено {results.Count()} записей";

        }

        

        private void FindClientsButton_Click(object sender, EventArgs e)
        {
            
            ClientsResTextBox.Text = "";

            ClientsDataGridView.Rows.Clear();
            var name = ClientNameTextBox.Text.Trim();
            var phone = ClientPhoneNumberTextBox.Text.Trim();
            var adress = ClientAdressTextBox.Text.Trim();
            var email = ClientEmailTextBox.Text.Trim();
            int numbOfOrders = (int)NumbOfClientOrdersNumeric.Value;
            string sortBy = GetSelectedClientSortBy();
            var ascending = OrderClientsByAscending.Checked;

            ClientRepository repo = new ClientRepository();
            var results = repo.SearchAndSortClients(name, phone, adress, email, numbOfOrders, sortBy, ascending);

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

        private void ResetSortParametersButton_Click(object sender, EventArgs e)
        {
            OrderByNameRadio.Checked = true;
            OrderByMadeByRadio.Checked = false;
            OrderByTypeRadio.Checked = false;
            OrderByMaterialRadio.Checked = false;
            OrderByRoomRadio.Checked = false;
            OrderByDescending.Checked = true;
        }

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
            ClientNameTextBox.Text = "";
            ClientPhoneNumberTextBox.Text = "";
            ClientAdressTextBox.Text = "";
            ClientEmailTextBox.Text = "";
            NumbOfClientOrdersNumeric.Value = 0;



        }

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

        private void EditFurnitureDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditFurnitureForm form = new EditFurnitureForm();
            form.ShowDialog();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
