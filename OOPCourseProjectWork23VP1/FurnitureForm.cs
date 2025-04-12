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

/*
    * TODO:
    * 1. Классы для каждой сущности из бд: Client, Furniture
    * 2. Вывод данных в таблицу для Furniture
    * 3. Вывод данных в таблицу для Client
    * 4. Форма добавления мебели
    * 5. Форма добавления клиента
    * 6. Форма приветственная
    * 7. Поиск и сортировка
    * 8. Перенести все действия с бд в dbservice
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


        }

        private void FurnitureMadeByTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FurnitureDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void FindFurnitureButton_Click(object sender, EventArgs e)
        {
            ResTextBox.Text = "";
            using (FurnitureDBContext db = new FurnitureDBContext())
            {
                db.Database.EnsureCreated();
                FurnitureDataGridView.Rows.Clear();

                var name = FurnitureNameTextBox.Text.Trim();
                var type = FurnitureTypeTextBox.Text.Trim();
                var material = FurnitureMaterialTextBox.Text.Trim();
                var madeBy = FurnitureMadeByTextBox.Text.Trim();
                int roomID = (int)FurnitureRoomNumeric.Value;
                string sortBy = GetSelectedSortBy();
                //var furniture = db.Furniture.ToList();

                var results = SearchFurniture(name, type, material, madeBy, roomID, sortBy);


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
                ResTextBox.Text = $"Найдено {results.Count()} записей";
            }


        }


        public List<Furniture> SearchFurniture(string name = null, string type = null,
                                      string material = null, string manufacturer = null,
                                      int roomID = 0, string sortBy = null)
        {
            FindFurnitureButton.Enabled = false;
            using (var db = new FurnitureDBContext())
            {
                // Начинаем с базового запроса
                IQueryable<Furniture> query = db.Furniture;
                //.Include(f => f.Room); // Загружаем связанные данные

                // Добавляем условия только если параметры не пустые
                if (!string.IsNullOrWhiteSpace(name))
                    query = query.Where(f => f.Name.Contains(name));

                if (!string.IsNullOrWhiteSpace(type))
                    query = query.Where(f => f.Type.Contains(type));

                if (!string.IsNullOrWhiteSpace(material))
                    query = query.Where(f => f.Material.Contains(material));

                if (!string.IsNullOrWhiteSpace(manufacturer))
                    query = query.Where(f => f.MadeByCountry.Contains(manufacturer));

                if (roomID != 0)
                    query = query.Where(f => f.Room_ID.Equals(roomID)); // Name.Contains(room);



                var ascending = OrderByAscending.Checked;

                switch (sortBy)
                {
                    case "Name":
                        query = ascending ? query.OrderBy(f => f.Name) : query.OrderByDescending(f => f.Name);
                        break;
                    case "MadeBy":
                        query = ascending ? query.OrderBy(f => f.MadeByCountry) : query.OrderByDescending(f => f.MadeByCountry);
                        break;
                    case "Type":
                        query = ascending ? query.OrderBy(f => f.Type) : query.OrderByDescending(f => f.Type);
                        break;
                    case "Material":
                        query = ascending ? query.OrderBy(f => f.Material) : query.OrderByDescending(f => f.Material);
                        break;
                    case "Room":
                        query = ascending ?
                            query.OrderBy(f => f.Room_ID) :
                            query.OrderByDescending(f => f.Room_ID);
                        break;
                    case "Price":
                        query = ascending ? query.OrderBy(f => (int)f.Price) : query.OrderByDescending(f => (int)f.Price);
                        break;
                    case "ValueInRoom":
                        query = ascending ? query.OrderBy(f => f.ValueInRoom) : query.OrderByDescending(f => f.ValueInRoom);
                        break;
                    default:
                        query = query.OrderBy(f => f.Name);
                        break;
                }

                FindFurnitureButton.Enabled = true;
                return query.ToList();

            }
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

        }
    }
}
