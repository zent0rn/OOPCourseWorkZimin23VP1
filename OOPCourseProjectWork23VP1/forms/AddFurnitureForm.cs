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
    public partial class AddFurnitureForm : Form
    {
        public AddFurnitureForm()
        {
            InitializeComponent();
        }

        private void DeclineAddFurnitureButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
