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
    }
}
