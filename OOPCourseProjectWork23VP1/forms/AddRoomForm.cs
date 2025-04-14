using OOPCourseWorkZimin23VP1.entities;

namespace OOPCourseWorkZimin23VP1.forms
{
    public partial class AddRoomForm : Form
    {
        public AddRoomForm()
        {
            InitializeComponent();
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            var name = RoomNameTextBox.Text;
            var adress = RoomAdressTextBox.Text;
            var personName = RoomPersonNameTextBox.Text;

            using (var db = new FurnitureDBContext())
            {
                var room = new Room
                {
                    Name = name,
                    Adress = adress,
                    Responsible_Person = personName
                };
                db.Room.Add(room);
                db.SaveChanges();
                MessageBox.Show("Комната успешно добавлена", "Успех",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            }
    }
}
