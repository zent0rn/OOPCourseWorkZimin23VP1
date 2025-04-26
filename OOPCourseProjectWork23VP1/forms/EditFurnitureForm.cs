using OOPCourseWorkZimin23VP1.entities;
using OOPCourseWorkZimin23VP1.tools;
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
    public partial class EditFurnitureForm : Form
    {
        int _id;
        int SelectedRoomId;
        private Furniture _furniture;
        RoomRepository roomRepo = new RoomRepository();
        FurnitureRepository furnRepo = new FurnitureRepository();
        public EditFurnitureForm()
        {
            InitializeComponent();
            this.Select();
        }

        public EditFurnitureForm(int id)
        {
            InitializeComponent();
            _id = id;
            this.Select();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void InitializeRoomsListView()
        {
            roomListView.View = View.Details;
            roomListView.FullRowSelect = true;
            roomListView.GridLines = true;
            roomListView.Columns.Add("Название", 150);
            roomListView.Columns.Add("Адрес", 200);
            roomListView.Columns.Add("Площадь", 150);
            //roomListView.Columns.Add("Ответственное лицо", 250);
            //roomListView.SelectedIndexChanged += RoomsListView_SelectedIndexChanged;
        }

        private void LoadRoomsToListView()
        {
            try
            {
                roomListView.Items.Clear();


                var rooms = roomRepo.LoadData();

                foreach (var room in rooms)
                {
                    var item = new ListViewItem(room.Name);
                    item.SubItems.Add(room.Adress);
                    item.SubItems.Add((room.Area).ToString());

                    item.Tag = room.ID; // Сохраняем ID помещения в Tag

                    roomListView.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки помещений: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFurnitureData()
        {
            try
            {

                _furniture = furnRepo.getDb().Furniture
                    .FirstOrDefault(f => f.ID == _id);


                if (_furniture != null)
                {
                    NameTextBox.Text = _furniture.Name;
                    TypeTextBox.Text = _furniture.Type;
                    MaterialTextBox.Text = _furniture.Material;
                    CountryTextBox.Text = _furniture.MadeByCountry;
                    PriceNumeric.Text = _furniture.Price.ToString("N2");
                    QuantityNumeric.Value = _furniture.ValueInRoom;
                    SelectedRoomId = _furniture.Room_ID;

                    foreach (ListViewItem item in roomListView.Items)
                    {
                        if ((int)item.Tag == SelectedRoomId)
                        {
                            item.Selected = true;
                        }
                    }


                }
                else
                {
                    MessageBox.Show($"Не найдена мебель с таким ID", "Ошибка",
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool ValidateFurnitureData()
        {
            StringBuilder errors = new StringBuilder();

            // Проверка названия
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                errors.AppendLine("• Не указано название мебели");
            }
            else if (NameTextBox.Text.Length > 100)
            {
                errors.AppendLine("• Название слишком длинное (макс. 100 символов)");
            }

            // Проверка типа
            if (string.IsNullOrWhiteSpace(TypeTextBox.Text))
            {
                errors.AppendLine("• Не указан тип мебели");
            }

            // Проверка материала
            if (string.IsNullOrWhiteSpace(MaterialTextBox.Text))
            {
                errors.AppendLine("• Не указан материал");
            }

            // Проверка цены
            if (PriceNumeric.Value <= 0)
            {
                errors.AppendLine("• Некорректная цена (должна быть положительным числом)");
            }

            // Проверка количества
            if (QuantityNumeric.Value <= 0)
            {
                errors.AppendLine("• Количество должно быть больше 0");
            }

            // Проверка помещения
            if (roomListView.SelectedItems == null)
            {
                errors.AppendLine("• Не выбрано помещение");
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

        private void EditFurnitureForm_Load(object sender, EventArgs e)
        {
            InitializeRoomsListView();
            LoadRoomsToListView();
            LoadFurnitureData();
        }

        private void FurnitureListView_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (roomListView.SelectedItems.Count == 0) return;

            var selectedItem = roomListView.SelectedItems[0];
            int roomId = (int)selectedItem.Tag;

            SelectedRoomId = roomId;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateFurnitureData())
                {

                    return;
                }

                string Name = NameTextBox.Text;
                string Type = TypeTextBox.Text;
                string Material = MaterialTextBox.Text;
                string MadeByCountry = CountryTextBox.Text;
                int Price = (int)PriceNumeric.Value;
                int ValueInRoom = (int)QuantityNumeric.Value;
                int Room_ID = SelectedRoomId;

                furnRepo.EditFurniture(_id, Name, Type, Material, MadeByCountry, Price, ValueInRoom, Room_ID);

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateNewRoomButton_Click(object sender, EventArgs e)
        {
            AddRoomForm form = new AddRoomForm();
            form.ShowDialog();
            LoadRoomsToListView();
        }
    }
}
