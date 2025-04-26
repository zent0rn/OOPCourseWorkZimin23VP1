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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPCourseWorkZimin23VP1.forms
{
    /// <summary>
    /// Форма для редактирования данных о помещении
    /// </summary>
    public partial class EditRoomForm : Form
    {
        /// <summary>
        /// ID редактируемого помещения
        /// </summary>
        int _id;

        /// <summary>
        /// ID выбранного ответственного лица для помещения
        /// </summary>
        int _selId;

        /// <summary>
        /// Объект комнаты
        /// </summary>
        Room _room;

        /// <summary>
        /// Репозиторий ответственных лиц
        /// </summary>
        ResponsiblePersonRepository personRepo = new ResponsiblePersonRepository();

        /// <summary>
        /// Репозиторий помещений
        /// </summary>
        RoomRepository roomRepo = new RoomRepository();

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public EditRoomForm()
        {
            InitializeComponent();
            this.Select();
        }

        /// <summary>
        /// Конструктор формы с параметром
        /// </summary>
        /// <param name="id">ID редактируемого помещения</param>
        public EditRoomForm(int id)
        {
            InitializeComponent();
            _id = id;
            this.Select();
        }

        private void InitializeResponsiblePersonsListView()
        {
            ResponsiblePersonListView.View = View.Details;
            ResponsiblePersonListView.FullRowSelect = true;
            ResponsiblePersonListView.GridLines = true;
            ResponsiblePersonListView.Columns.Add("ID", 70);
            ResponsiblePersonListView.Columns.Add("Полное имя", 200);
            ResponsiblePersonListView.Columns.Add("Телефон", 150);
            ResponsiblePersonListView.Columns.Add("Email", 150);
        }

        private void loadPersonsToListView()
        {
            try
            {
                ResponsiblePersonListView.Items.Clear();


                var persons = personRepo.LoadData();

                foreach (var person in persons)
                {
                    var item = new ListViewItem(person.ID.ToString());
                    item.SubItems.Add(person.FullName);
                    item.SubItems.Add(person.Phone);
                    item.SubItems.Add(person.Email);

                    item.Tag = person.ID; // Сохраняем ID в Tag

                    ResponsiblePersonListView.Items.Add(item);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки ответственных лиц: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateRoomData()
        {
            StringBuilder errors = new StringBuilder();

            // Проверка названия
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                errors.AppendLine("• Не указано название помещения");
            }
            else if (nameTextBox.Text.Length > 100)
            {
                errors.AppendLine("• Название слишком длинное (макс. 100 символов)");
            }


            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                errors.AppendLine("• Не указан адрес помещения");
            }


            if (ResponsiblePersonListView.SelectedItems == null)
            {
                errors.AppendLine("• Не выбрано ответственное лицо");
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

        private void EditRoomForm_Load(object sender, EventArgs e)
        {
            InitializeResponsiblePersonsListView();
            loadPersonsToListView();
            loadRoomData();

        }

        private void loadRoomData()
        {
            try
            {

                _room = roomRepo.getDb().Room
                .FirstOrDefault(f => f.ID == _id);


                if (_room != null)
                {
                    nameTextBox.Text = _room.Name;
                    addressTextBox.Text = _room.Adress;
                    areaNumericUpDown.Value = _room.Area;
                    _selId = _room.Responsible_Person_ID;
                    

                    foreach (ListViewItem item in ResponsiblePersonListView.Items)
                    {
                        if ((int)item.Tag == _selId)
                        {
                            item.Selected = true;
                        }
                    }


                }
                else
                {
                    MessageBox.Show($"Не найдена комната с таким ID", "Ошибка",
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


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateRoomData())
                {
                    return;
                }
                else
                {

                    string name = nameTextBox.Text;
                    string address = addressTextBox.Text;
                    int area = (int)areaNumericUpDown.Value;

                    roomRepo.EditRoom(_id, name, address, area, _selId);

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

        private void ResponsiblePersonListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ResponsiblePersonListView.SelectedItems.Count == 0) return;
            _selId = (int)ResponsiblePersonListView.SelectedItems[0].Tag;
        }

        private void AddRespPersonButton_Click(object sender, EventArgs e)
        {
            AddResponsiblePersonForm form = new AddResponsiblePersonForm();
            form.ShowDialog();
            loadPersonsToListView();
        }
    }
}
