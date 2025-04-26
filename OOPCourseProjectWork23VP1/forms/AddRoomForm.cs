using OOPCourseWorkZimin23VP1.entities;
using OOPCourseWorkZimin23VP1.tools;
using System.Text;

namespace OOPCourseWorkZimin23VP1.forms
{
    /// <summary>
    /// Форма добавления помещения.
    /// </summary>
    public partial class AddRoomForm : Form
    {

        /// <summary>
        /// Конструктор
        /// </summary>
        public AddRoomForm()
        {
            InitializeComponent();
            this.Select();
        }

        /// <summary>
        /// Выбранное ID ответственного лица
        /// </summary>
        int _selId;

        /// <summary>
        /// Репозиторий помещений
        /// </summary>
        ResponsiblePersonRepository repo = new ResponsiblePersonRepository();
        /// <summary>
        /// Инициализация list view ответственных лиц
        /// </summary>
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

        /// <summary>
        /// Загрузка ответственных лиц в list view
        /// </summary>
        private void loadPersonsToListView()
        {
            try
            {
                ResponsiblePersonListView.Items.Clear();


                var persons = repo.LoadData();

                foreach (var person in persons)
                {
                    var item = new ListViewItem(person.ID.ToString());
                    item.SubItems.Add(person.FullName);
                    item.SubItems.Add(person.Phone);
                    item.SubItems.Add(person.Email);

                    item.Tag = person.ID; // Сохраняем ID помещения в Tag

                    ResponsiblePersonListView.Items.Add(item);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки ответственных лиц: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Валидация введённых в форму данных.
        /// </summary>
        /// <returns></returns>
        private bool ValidateRoomData()
        {
            StringBuilder errors = new StringBuilder();

            // Проверка названия
            if (string.IsNullOrWhiteSpace(RoomNameTextBox.Text))
            {
                errors.AppendLine("• Не указано название помещения");
            }
            else if (RoomNameTextBox.Text.Length > 100)
            {
                errors.AppendLine("• Название слишком длинное (макс. 100 символов)");
            }


            if (string.IsNullOrWhiteSpace(RoomAdressTextBox.Text))
            {
                errors.AppendLine("• Не указан адрес помещения");
            }


            if (ResponsiblePersonListView.SelectedItems.Count == 0)
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

        /// <summary>
        /// Обработчик события нажатия на кнопку добавить комнату. 
        /// При нажатии происходит валидация данных, 
        /// а затем добавление комнаты в БД, если данные корректны.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addRoomButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateRoomData())
                {
                    return;
                }
                else
                {

                    var name = RoomNameTextBox.Text.Trim();
                    var adress = RoomAdressTextBox.Text.Trim();
                    int area = (int)areaNumeric.Value;


                    RoomRepository repo = new RoomRepository();

                    bool res = repo.AddRoom(name, adress, area, _selId);
                    if (res)
                    {
                        MessageBox.Show("Комната успешно добавлена", "Успех",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Обработчик нажатия на кнопку отмена. 
        /// При нажатии текущая форма закрывается.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Обработчик события смены индекса в list view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResponsiblePersonListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ResponsiblePersonListView.SelectedItems.Count == 0) return;
            _selId = (int)ResponsiblePersonListView.SelectedItems[0].Tag;
        }

        /// <summary>
        /// Обработчик события загрузки формы. 
        /// Происходит иниализация list view для ответственных лиц.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRoomForm_Load(object sender, EventArgs e)
        {
            InitializeResponsiblePersonsListView();
            loadPersonsToListView();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку добавить ответственное лицо. 
        /// При нажатии открывается форма добавления ответственного лица.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRespPersonButton_Click(object sender, EventArgs e)
        {
            AddResponsiblePersonForm form = new AddResponsiblePersonForm();
            form.ShowDialog();
            loadPersonsToListView();
        }
    }
}
