using OOPCourseWorkZimin23VP1.entities;
using OOPCourseWorkZimin23VP1.tools;

namespace OOPCourseWorkZimin23VP1.forms
{
    public partial class AddRoomForm : Form
    {

        public AddRoomForm()
        {
            InitializeComponent();
        }
        int _selId;
        ResponsiblePersonRepository repo = new ResponsiblePersonRepository();
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


        private void addRoomButton_Click(object sender, EventArgs e)
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
            else
            {
                MessageBox.Show("Введите данные во все поля", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResponsiblePersonListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ResponsiblePersonListView.SelectedItems.Count == 0) return;
            _selId = (int)ResponsiblePersonListView.SelectedItems[0].Tag;
        }

        private void AddRoomForm_Load(object sender, EventArgs e)
        {
            

            InitializeResponsiblePersonsListView();
            loadPersonsToListView();
            
        }
    }
}
