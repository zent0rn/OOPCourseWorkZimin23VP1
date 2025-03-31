namespace OOPCourseProjectWork23VP1
{
    partial class FurnitureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FurnitureDataGridView = new DataGridView();
            IDColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            TypeColumn = new DataGridViewTextBoxColumn();
            MaterialColumn = new DataGridViewTextBoxColumn();
            MadeByColumn = new DataGridViewTextBoxColumn();
            RoomColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            NumbOfItemColumn = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            AddFurnitureToolStripMenuItem = new ToolStripMenuItem();
            RemoveFurnitureToolStripMenuItem = new ToolStripMenuItem();
            EditFurnitureDataToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox1 = new TextBox();
            panel1 = new Panel();
            panel9 = new Panel();
            FindFurnitureButton = new Button();
            ResetSortParametersButton = new Button();
            panel8 = new Panel();
            OrderByAscending = new RadioButton();
            OrderByDescending = new RadioButton();
            panel7 = new Panel();
            OrderByMaterialRadio = new RadioButton();
            OrderByTypeRadio = new RadioButton();
            OrderByRoomRadio = new RadioButton();
            OrderByMadeByRadio = new RadioButton();
            OrderByNameRadio = new RadioButton();
            panel6 = new Panel();
            FurnitureRoomTextBox = new TextBox();
            label6 = new Label();
            panel5 = new Panel();
            FurnitureMadeByTextBox = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            FurnitureMaterialTextBox = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            FurnitureTypeTextBox = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            FurnitureNameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            ClientIdColumn = new DataGridViewTextBoxColumn();
            ClientNameColumn = new DataGridViewTextBoxColumn();
            ClientNumberColumn = new DataGridViewTextBoxColumn();
            ClientAdressColumn = new DataGridViewTextBoxColumn();
            ClientEmailColumn = new DataGridViewTextBoxColumn();
            ClientNumbOfOrdersColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)FurnitureDataGridView).BeginInit();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // FurnitureDataGridView
            // 
            FurnitureDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FurnitureDataGridView.Columns.AddRange(new DataGridViewColumn[] { IDColumn, NameColumn, TypeColumn, MaterialColumn, MadeByColumn, RoomColumn, PriceColumn, NumbOfItemColumn });
            FurnitureDataGridView.Location = new Point(5, 7);
            FurnitureDataGridView.Name = "FurnitureDataGridView";
            FurnitureDataGridView.RowHeadersWidth = 51;
            FurnitureDataGridView.RowTemplate.Height = 24;
            FurnitureDataGridView.Size = new Size(1341, 510);
            FurnitureDataGridView.TabIndex = 0;
            FurnitureDataGridView.CellContentClick += FurnitureDataGridView_CellContentClick;
            // 
            // IDColumn
            // 
            IDColumn.HeaderText = "ID";
            IDColumn.MinimumWidth = 6;
            IDColumn.Name = "IDColumn";
            IDColumn.Width = 75;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Название";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.Width = 125;
            // 
            // TypeColumn
            // 
            TypeColumn.HeaderText = "Тип";
            TypeColumn.MinimumWidth = 6;
            TypeColumn.Name = "TypeColumn";
            TypeColumn.Width = 125;
            // 
            // MaterialColumn
            // 
            MaterialColumn.HeaderText = "Материал";
            MaterialColumn.MinimumWidth = 6;
            MaterialColumn.Name = "MaterialColumn";
            MaterialColumn.Width = 125;
            // 
            // MadeByColumn
            // 
            MadeByColumn.HeaderText = "Страна - производитель";
            MadeByColumn.MinimumWidth = 6;
            MadeByColumn.Name = "MadeByColumn";
            MadeByColumn.Width = 125;
            // 
            // RoomColumn
            // 
            RoomColumn.HeaderText = "ID Помещения";
            RoomColumn.MinimumWidth = 6;
            RoomColumn.Name = "RoomColumn";
            RoomColumn.Width = 125;
            // 
            // PriceColumn
            // 
            PriceColumn.HeaderText = "Цена";
            PriceColumn.MinimumWidth = 6;
            PriceColumn.Name = "PriceColumn";
            PriceColumn.Width = 125;
            // 
            // NumbOfItemColumn
            // 
            NumbOfItemColumn.HeaderText = "Количество на складе";
            NumbOfItemColumn.MinimumWidth = 6;
            NumbOfItemColumn.Name = "NumbOfItemColumn";
            NumbOfItemColumn.Width = 125;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripDropDownButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1860, 26);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(14, 23);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { AddFurnitureToolStripMenuItem, RemoveFurnitureToolStripMenuItem, EditFurnitureDataToolStripMenuItem });
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(72, 23);
            toolStripDropDownButton2.Text = "Мебель";
            // 
            // AddFurnitureToolStripMenuItem
            // 
            AddFurnitureToolStripMenuItem.Name = "AddFurnitureToolStripMenuItem";
            AddFurnitureToolStripMenuItem.Size = new Size(313, 24);
            AddFurnitureToolStripMenuItem.Text = "Добавить мебель...";
            AddFurnitureToolStripMenuItem.Click += AddFurnitureToolStripMenuItem_Click;
            // 
            // RemoveFurnitureToolStripMenuItem
            // 
            RemoveFurnitureToolStripMenuItem.Name = "RemoveFurnitureToolStripMenuItem";
            RemoveFurnitureToolStripMenuItem.Size = new Size(313, 24);
            RemoveFurnitureToolStripMenuItem.Text = "Удалить мебель...";
            // 
            // EditFurnitureDataToolStripMenuItem
            // 
            EditFurnitureDataToolStripMenuItem.Name = "EditFurnitureDataToolStripMenuItem";
            EditFurnitureDataToolStripMenuItem.Size = new Size(313, 24);
            EditFurnitureDataToolStripMenuItem.Text = "Редактирование данных о мебели...";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 42);
            tabControl1.MinimumSize = new Size(1860, 813);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1860, 813);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(FurnitureDataGridView);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1852, 781);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Поиск и сортировка мебели";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(279, 641);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(895, 26);
            textBox1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1446, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 775);
            panel1.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(FindFurnitureButton);
            panel9.Controls.Add(ResetSortParametersButton);
            panel9.Location = new Point(3, 669);
            panel9.Name = "panel9";
            panel9.Size = new Size(400, 83);
            panel9.TabIndex = 5;
            // 
            // FindFurnitureButton
            // 
            FindFurnitureButton.Dock = DockStyle.Bottom;
            FindFurnitureButton.Font = new Font("Microsoft Sans Serif", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FindFurnitureButton.Location = new Point(0, 46);
            FindFurnitureButton.Name = "FindFurnitureButton";
            FindFurnitureButton.Size = new Size(400, 37);
            FindFurnitureButton.TabIndex = 4;
            FindFurnitureButton.Text = "Найти мебель";
            FindFurnitureButton.UseVisualStyleBackColor = true;
            // 
            // ResetSortParametersButton
            // 
            ResetSortParametersButton.Dock = DockStyle.Top;
            ResetSortParametersButton.Font = new Font("Microsoft Sans Serif", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ResetSortParametersButton.Location = new Point(0, 0);
            ResetSortParametersButton.Name = "ResetSortParametersButton";
            ResetSortParametersButton.Size = new Size(400, 38);
            ResetSortParametersButton.TabIndex = 4;
            ResetSortParametersButton.Text = "Сбросить параметры сортировки";
            ResetSortParametersButton.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(OrderByAscending);
            panel8.Controls.Add(OrderByDescending);
            panel8.Location = new Point(3, 627);
            panel8.Name = "panel8";
            panel8.Size = new Size(400, 37);
            panel8.TabIndex = 3;
            // 
            // OrderByAscending
            // 
            OrderByAscending.AutoSize = true;
            OrderByAscending.Font = new Font("Microsoft Sans Serif", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OrderByAscending.Location = new Point(3, 3);
            OrderByAscending.Name = "OrderByAscending";
            OrderByAscending.Size = new Size(134, 21);
            OrderByAscending.TabIndex = 2;
            OrderByAscending.TabStop = true;
            OrderByAscending.Text = "По возрастанию";
            OrderByAscending.UseVisualStyleBackColor = true;
            // 
            // OrderByDescending
            // 
            OrderByDescending.AutoSize = true;
            OrderByDescending.Font = new Font("Microsoft Sans Serif", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OrderByDescending.Location = new Point(193, 3);
            OrderByDescending.Name = "OrderByDescending";
            OrderByDescending.Size = new Size(114, 21);
            OrderByDescending.TabIndex = 2;
            OrderByDescending.TabStop = true;
            OrderByDescending.Text = "По убыванию";
            OrderByDescending.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(OrderByMaterialRadio);
            panel7.Controls.Add(OrderByTypeRadio);
            panel7.Controls.Add(OrderByRoomRadio);
            panel7.Controls.Add(OrderByMadeByRadio);
            panel7.Controls.Add(OrderByNameRadio);
            panel7.Location = new Point(0, 526);
            panel7.Name = "panel7";
            panel7.Size = new Size(403, 95);
            panel7.TabIndex = 1;
            // 
            // OrderByMaterialRadio
            // 
            OrderByMaterialRadio.AutoSize = true;
            OrderByMaterialRadio.Checked = true;
            OrderByMaterialRadio.Font = new Font("Microsoft Sans Serif", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OrderByMaterialRadio.Location = new Point(4, 66);
            OrderByMaterialRadio.Name = "OrderByMaterialRadio";
            OrderByMaterialRadio.Size = new Size(119, 21);
            OrderByMaterialRadio.TabIndex = 2;
            OrderByMaterialRadio.TabStop = true;
            OrderByMaterialRadio.Text = "По материалу";
            OrderByMaterialRadio.UseVisualStyleBackColor = true;
            // 
            // OrderByTypeRadio
            // 
            OrderByTypeRadio.AutoSize = true;
            OrderByTypeRadio.Font = new Font("Microsoft Sans Serif", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OrderByTypeRadio.Location = new Point(3, 35);
            OrderByTypeRadio.Name = "OrderByTypeRadio";
            OrderByTypeRadio.Size = new Size(78, 21);
            OrderByTypeRadio.TabIndex = 2;
            OrderByTypeRadio.Text = "По типу";
            OrderByTypeRadio.UseVisualStyleBackColor = true;
            OrderByTypeRadio.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // OrderByRoomRadio
            // 
            OrderByRoomRadio.AutoSize = true;
            OrderByRoomRadio.Font = new Font("Microsoft Sans Serif", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OrderByRoomRadio.Location = new Point(196, 64);
            OrderByRoomRadio.Name = "OrderByRoomRadio";
            OrderByRoomRadio.Size = new Size(126, 21);
            OrderByRoomRadio.TabIndex = 2;
            OrderByRoomRadio.Text = "По помещению";
            OrderByRoomRadio.UseVisualStyleBackColor = true;
            // 
            // OrderByMadeByRadio
            // 
            OrderByMadeByRadio.AutoSize = true;
            OrderByMadeByRadio.Font = new Font("Microsoft Sans Serif", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OrderByMadeByRadio.Location = new Point(196, 3);
            OrderByMadeByRadio.Name = "OrderByMadeByRadio";
            OrderByMadeByRadio.Size = new Size(151, 21);
            OrderByMadeByRadio.TabIndex = 2;
            OrderByMadeByRadio.Text = "По производителю";
            OrderByMadeByRadio.UseVisualStyleBackColor = true;
            // 
            // OrderByNameRadio
            // 
            OrderByNameRadio.AutoSize = true;
            OrderByNameRadio.Font = new Font("Microsoft Sans Serif", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OrderByNameRadio.Location = new Point(3, 3);
            OrderByNameRadio.Name = "OrderByNameRadio";
            OrderByNameRadio.Size = new Size(112, 21);
            OrderByNameRadio.TabIndex = 2;
            OrderByNameRadio.Text = "По названию";
            OrderByNameRadio.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(FurnitureRoomTextBox);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(3, 300);
            panel6.Name = "panel6";
            panel6.Size = new Size(396, 54);
            panel6.TabIndex = 1;
            // 
            // FurnitureRoomTextBox
            // 
            FurnitureRoomTextBox.Location = new Point(228, 6);
            FurnitureRoomTextBox.MinimumSize = new Size(4, 30);
            FurnitureRoomTextBox.Name = "FurnitureRoomTextBox";
            FurnitureRoomTextBox.Size = new Size(159, 30);
            FurnitureRoomTextBox.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(1, 15);
            label6.Name = "label6";
            label6.Size = new Size(115, 24);
            label6.TabIndex = 0;
            label6.Text = "Помещение";
            label6.Click += label1_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(FurnitureMadeByTextBox);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(1, 234);
            panel5.Name = "panel5";
            panel5.Size = new Size(397, 58);
            panel5.TabIndex = 1;
            // 
            // FurnitureMadeByTextBox
            // 
            FurnitureMadeByTextBox.Location = new Point(229, 6);
            FurnitureMadeByTextBox.MinimumSize = new Size(4, 30);
            FurnitureMadeByTextBox.Name = "FurnitureMadeByTextBox";
            FurnitureMadeByTextBox.Size = new Size(159, 30);
            FurnitureMadeByTextBox.TabIndex = 1;
            FurnitureMadeByTextBox.TextChanged += FurnitureMadeByTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(3, 15);
            label5.Name = "label5";
            label5.Size = new Size(158, 24);
            label5.TabIndex = 0;
            label5.Text = "Производитель ";
            label5.Click += label1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(FurnitureMaterialTextBox);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(0, 171);
            panel4.Name = "panel4";
            panel4.Size = new Size(397, 56);
            panel4.TabIndex = 1;
            // 
            // FurnitureMaterialTextBox
            // 
            FurnitureMaterialTextBox.Location = new Point(231, 9);
            FurnitureMaterialTextBox.MinimumSize = new Size(4, 30);
            FurnitureMaterialTextBox.Name = "FurnitureMaterialTextBox";
            FurnitureMaterialTextBox.Size = new Size(159, 30);
            FurnitureMaterialTextBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(4, 15);
            label4.Name = "label4";
            label4.Size = new Size(99, 24);
            label4.TabIndex = 0;
            label4.Text = "Материал";
            label4.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(FurnitureTypeTextBox);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(0, 108);
            panel3.Name = "panel3";
            panel3.Size = new Size(395, 56);
            panel3.TabIndex = 1;
            // 
            // FurnitureTypeTextBox
            // 
            FurnitureTypeTextBox.Location = new Point(231, 3);
            FurnitureTypeTextBox.MinimumSize = new Size(4, 30);
            FurnitureTypeTextBox.Name = "FurnitureTypeTextBox";
            FurnitureTypeTextBox.Size = new Size(159, 30);
            FurnitureTypeTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 15);
            label3.Name = "label3";
            label3.Size = new Size(44, 24);
            label3.TabIndex = 0;
            label3.Text = "Тип";
            label3.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(FurnitureNameTextBox);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 56);
            panel2.TabIndex = 1;
            // 
            // FurnitureNameTextBox
            // 
            FurnitureNameTextBox.Location = new Point(229, 9);
            FurnitureNameTextBox.MinimumSize = new Size(4, 30);
            FurnitureNameTextBox.Name = "FurnitureNameTextBox";
            FurnitureNameTextBox.Size = new Size(159, 30);
            FurnitureNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 15);
            label2.Name = "label2";
            label2.Size = new Size(169, 24);
            label2.TabIndex = 0;
            label2.Text = "Название мебели";
            label2.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(1, 4);
            label1.Name = "label1";
            label1.Size = new Size(298, 26);
            label1.TabIndex = 0;
            label1.Text = "Поиск и сортировка мебели";
            label1.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1852, 781);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Поиск и сортировка клиентов";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { ClientIdColumn, ClientNameColumn, ClientNumberColumn, ClientAdressColumn, ClientEmailColumn, ClientNumbOfOrdersColumn });
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 24;
            dataGridView2.Size = new Size(1072, 471);
            dataGridView2.TabIndex = 0;
            // 
            // ClientIdColumn
            // 
            ClientIdColumn.HeaderText = "ID";
            ClientIdColumn.MinimumWidth = 6;
            ClientIdColumn.Name = "ClientIdColumn";
            ClientIdColumn.Width = 125;
            // 
            // ClientNameColumn
            // 
            ClientNameColumn.HeaderText = "Имя";
            ClientNameColumn.MinimumWidth = 6;
            ClientNameColumn.Name = "ClientNameColumn";
            ClientNameColumn.Width = 125;
            // 
            // ClientNumberColumn
            // 
            ClientNumberColumn.HeaderText = "Телефон";
            ClientNumberColumn.MinimumWidth = 6;
            ClientNumberColumn.Name = "ClientNumberColumn";
            ClientNumberColumn.Width = 125;
            // 
            // ClientAdressColumn
            // 
            ClientAdressColumn.HeaderText = "Адрес";
            ClientAdressColumn.MinimumWidth = 6;
            ClientAdressColumn.Name = "ClientAdressColumn";
            ClientAdressColumn.Width = 125;
            // 
            // ClientEmailColumn
            // 
            ClientEmailColumn.HeaderText = "Email";
            ClientEmailColumn.MinimumWidth = 6;
            ClientEmailColumn.Name = "ClientEmailColumn";
            ClientEmailColumn.Width = 125;
            // 
            // ClientNumbOfOrdersColumn
            // 
            ClientNumbOfOrdersColumn.HeaderText = "Количество заказов";
            ClientNumbOfOrdersColumn.MinimumWidth = 6;
            ClientNumbOfOrdersColumn.Name = "ClientNumbOfOrdersColumn";
            ClientNumbOfOrdersColumn.Width = 125;
            // 
            // FurnitureForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1860, 871);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            MinimumSize = new Size(1878, 915);
            Name = "FurnitureForm";
            Text = "Мебель";
            Load += FurnitureForm_Load;
            ((System.ComponentModel.ISupportInitialize)FurnitureDataGridView).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        private System.Windows.Forms.DataGridView FurnitureDataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox FurnitureMaterialTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox FurnitureTypeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox FurnitureNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox FurnitureRoomTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox FurnitureMadeByTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton OrderByMaterialRadio;
        private System.Windows.Forms.RadioButton OrderByTypeRadio;
        private System.Windows.Forms.RadioButton OrderByRoomRadio;
        private System.Windows.Forms.RadioButton OrderByMadeByRadio;
        private System.Windows.Forms.RadioButton OrderByNameRadio;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton OrderByAscending;
        private System.Windows.Forms.RadioButton OrderByDescending;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button FindFurnitureButton;
        private System.Windows.Forms.Button ResetSortParametersButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientAdressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientEmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientNumbOfOrdersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MadeByColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumbOfItemColumn;
        private System.Windows.Forms.TextBox textBox1;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem AddFurnitureToolStripMenuItem;
        private ToolStripMenuItem RemoveFurnitureToolStripMenuItem;
        private ToolStripMenuItem EditFurnitureDataToolStripMenuItem;
    }
    #endregion
}