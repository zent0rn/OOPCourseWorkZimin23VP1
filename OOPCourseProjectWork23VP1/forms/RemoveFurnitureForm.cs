﻿using System;
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
    public partial class RemoveFurnitureForm : Form
    {
        public RemoveFurnitureForm()
        {
            InitializeComponent();
        }

        private void DeclineDeleteProcessButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveFurnitureForm_Load(object sender, EventArgs e)
        {

        }
    }
}
