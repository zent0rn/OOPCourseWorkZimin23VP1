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
    public partial class DatabaseChoiceDialogForm : Form
    {
        public DatabaseChoiceDialogForm()
        {
            InitializeComponent();
        }

        public enum ChoiceResult
        {
            CreateNew,
            OpenExisting,
            Cancel
        }

        public ChoiceResult UserChoice { get; private set; } = ChoiceResult.Cancel;

        private void btnCreateNew_Click_1(object sender, EventArgs e)
        {
            UserChoice = ChoiceResult.CreateNew;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOpenExisting_Click_1(object sender, EventArgs e)
        {
            UserChoice = ChoiceResult.OpenExisting;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UserChoice = ChoiceResult.Cancel;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
