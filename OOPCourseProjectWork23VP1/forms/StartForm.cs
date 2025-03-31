using OOPCourseProjectWork23VP1;
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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {

            // Скрываем стартовую форму вместо закрытия
            this.Hide();

            // Создаем и показываем основную форму как диалоговое окно
            var furnitureForm = new FurnitureForm();
            furnitureForm.FormClosed += (s, args) => this.Close(); // Закрываем стартовую форму при закрытии основной
            furnitureForm.Show();




        }
    }
}
