using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable WFO1000

namespace OOPCourseWorkZimin23VP1.forms
{
    /// <summary>
    /// Форма для выбора действия с БД: создание новой или использование существующей
    /// </summary>
    public partial class DatabaseChoiceDialogForm : Form
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public DatabaseChoiceDialogForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Варианты выбора
        /// </summary>
        public enum ChoiceResult
        {
            CreateNew,
            OpenExisting,
            Cancel
        }

        /// <summary>
        /// Выбор пользователя
        /// </summary>
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
