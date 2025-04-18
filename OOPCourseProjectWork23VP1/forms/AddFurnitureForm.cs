﻿using OOPCourseWorkZimin23VP1.entities;
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
using OOPCourseWorkZimin23VP1.forms;
using OOPCourseProjectWork23VP1;

namespace OOPCourseWorkZimin23VP1.forms
{
    public partial class AddFurnitureForm : Form
    {
        int SelectedRoomId;
        RoomRepository roomRepo = new RoomRepository();
        public AddFurnitureForm()
        {
            InitializeComponent();
        }

        private void DeclineAddFurnitureButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateNewRoomButton_Click(object sender, EventArgs e)
        {
            AddRoomForm form = new AddRoomForm();
            form.ShowDialog();
            LoadRoomsToListView();
        }

        private void roomListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomListView.SelectedItems.Count == 0) return;

            var selectedItem = roomListView.SelectedItems[0];
            int roomId = (int)selectedItem.Tag;


            SelectedRoomId = roomId;

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
                    item.SubItems.Add(room.Responsible_Person_ID.ToString());

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

        private void InitializeRoomsListView()
        {
            roomListView.View = View.Details;
            roomListView.FullRowSelect = true;
            roomListView.GridLines = true;
            roomListView.Columns.Add("Название", 150);
            roomListView.Columns.Add("Адрес", 100);
            roomListView.Columns.Add("Площадь", 100);
            roomListView.Columns.Add("ID Ответственного лица", 200);
            //roomListView.SelectedIndexChanged += RoomsListView_SelectedIndexChanged;
        }



        private void AddFurnitureForm_Load(object sender, EventArgs e)
        {
            InitializeRoomsListView();
            LoadRoomsToListView();

            
        }

        private void AddFurntiureButton_Click(object sender, EventArgs e)
        {
            if (SelectedRoomId == 0)
            {
                MessageBox.Show("Выберите помещение", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(FurniturePriceNumeric.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Введите корректную цену", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (FurnitureNameBox.Text == "" || FurnitureNameBox.Text == null)
            {
                MessageBox.Show("Введите название", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if (FurnitureTypeBox.Text == "" || FurnitureTypeBox.Text == null)
            {
                MessageBox.Show("Введите тип", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (FurnitureMaterialBox.Text == "" || FurnitureMaterialBox.Text == null)
            {
                MessageBox.Show("Введите материал", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (FurnitureCountryBox.Text == "" || FurnitureCountryBox.Text == null)
            {
                MessageBox.Show("Введите страну производства", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string Name = FurnitureNameBox.Text;
                string Type = FurnitureTypeBox.Text;
                string Material = FurnitureMaterialBox.Text;
                string MadeByCountry = FurnitureCountryBox.Text;
                int Price = (int)price;
                int ValueInRoom = (int)FurnitureValueInRoomNumeric.Value;
                int Room_ID = SelectedRoomId;

                FurnitureRepository repo = new FurnitureRepository();
                repo.AddFurniture(Name, Type, Material, MadeByCountry, Price, ValueInRoom, Room_ID);


                MessageBox.Show("Мебель успешно добавлена", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
