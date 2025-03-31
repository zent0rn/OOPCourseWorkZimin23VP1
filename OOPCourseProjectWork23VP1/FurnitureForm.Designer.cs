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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FurnitureForm";
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FurnitureForm));
            this.FurnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MadeByColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumbOfItemColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ClientIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientAdressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientEmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientNumbOfOrdersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.FindFurnitureButton = new System.Windows.Forms.Button();
            this.ResetSortParametersButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.OrderByAscending = new System.Windows.Forms.RadioButton();
            this.OrderByDescending = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.OrderByMaterialRadio = new System.Windows.Forms.RadioButton();
            this.OrderByTypeRadio = new System.Windows.Forms.RadioButton();
            this.OrderByRoomRadio = new System.Windows.Forms.RadioButton();
            this.OrderByMadeByRadio = new System.Windows.Forms.RadioButton();
            this.OrderByNameRadio = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.FurnitureRoomTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.FurnitureMadeByTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.FurnitureMaterialTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FurnitureTypeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FurnitureNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FurnitureDataGridView
            // 
            this.FurnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FurnitureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.NameColumn,
            this.TypeColumn,
            this.MaterialColumn,
            this.MadeByColumn,
            this.RoomColumn,
            this.PriceColumn,
            this.NumbOfItemColumn});
            this.FurnitureDataGridView.Location = new System.Drawing.Point(4, 5);
            this.FurnitureDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FurnitureDataGridView.Name = "FurnitureDataGridView";
            this.FurnitureDataGridView.RowHeadersWidth = 51;
            this.FurnitureDataGridView.RowTemplate.Height = 24;
            this.FurnitureDataGridView.Size = new System.Drawing.Size(1006, 349);
            this.FurnitureDataGridView.TabIndex = 0;
            // 
            // IDColumn
            // 
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.MinimumWidth = 6;
            this.IDColumn.Name = "IDColumn";
            this.IDColumn.Width = 75;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Название";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 125;
            // 
            // TypeColumn
            // 
            this.TypeColumn.HeaderText = "Тип";
            this.TypeColumn.MinimumWidth = 6;
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.Width = 125;
            // 
            // MaterialColumn
            // 
            this.MaterialColumn.HeaderText = "Материал";
            this.MaterialColumn.MinimumWidth = 6;
            this.MaterialColumn.Name = "MaterialColumn";
            this.MaterialColumn.Width = 125;
            // 
            // MadeByColumn
            // 
            this.MadeByColumn.HeaderText = "Страна - производитель";
            this.MadeByColumn.MinimumWidth = 6;
            this.MadeByColumn.Name = "MadeByColumn";
            this.MadeByColumn.Width = 125;
            // 
            // RoomColumn
            // 
            this.RoomColumn.HeaderText = "ID Помещения";
            this.RoomColumn.MinimumWidth = 6;
            this.RoomColumn.Name = "RoomColumn";
            this.RoomColumn.Width = 125;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Цена";
            this.PriceColumn.MinimumWidth = 6;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.Width = 125;
            // 
            // NumbOfItemColumn
            // 
            this.NumbOfItemColumn.HeaderText = "Количество на складе";
            this.NumbOfItemColumn.MinimumWidth = 6;
            this.NumbOfItemColumn.Name = "NumbOfItemColumn";
            this.NumbOfItemColumn.Width = 125;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1395, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1395, 556);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.FurnitureDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(1387, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Поиск и сортировка мебели";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(1387, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поиск и сортировка клиентов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientIdColumn,
            this.ClientNameColumn,
            this.ClientNumberColumn,
            this.ClientAdressColumn,
            this.ClientEmailColumn,
            this.ClientNumbOfOrdersColumn});
            this.dataGridView2.Location = new System.Drawing.Point(2, 2);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(804, 322);
            this.dataGridView2.TabIndex = 0;
            // 
            // ClientIdColumn
            // 
            this.ClientIdColumn.HeaderText = "ID";
            this.ClientIdColumn.MinimumWidth = 6;
            this.ClientIdColumn.Name = "ClientIdColumn";
            this.ClientIdColumn.Width = 125;
            // 
            // ClientNameColumn
            // 
            this.ClientNameColumn.HeaderText = "Имя";
            this.ClientNameColumn.MinimumWidth = 6;
            this.ClientNameColumn.Name = "ClientNameColumn";
            this.ClientNameColumn.Width = 125;
            // 
            // ClientNumberColumn
            // 
            this.ClientNumberColumn.HeaderText = "Телефон";
            this.ClientNumberColumn.MinimumWidth = 6;
            this.ClientNumberColumn.Name = "ClientNumberColumn";
            this.ClientNumberColumn.Width = 125;
            // 
            // ClientAdressColumn
            // 
            this.ClientAdressColumn.HeaderText = "Адрес";
            this.ClientAdressColumn.MinimumWidth = 6;
            this.ClientAdressColumn.Name = "ClientAdressColumn";
            this.ClientAdressColumn.Width = 125;
            // 
            // ClientEmailColumn
            // 
            this.ClientEmailColumn.HeaderText = "Email";
            this.ClientEmailColumn.MinimumWidth = 6;
            this.ClientEmailColumn.Name = "ClientEmailColumn";
            this.ClientEmailColumn.Width = 125;
            // 
            // ClientNumbOfOrdersColumn
            // 
            this.ClientNumbOfOrdersColumn.HeaderText = "Количество заказов";
            this.ClientNumbOfOrdersColumn.MinimumWidth = 6;
            this.ClientNumbOfOrdersColumn.Name = "ClientNumbOfOrdersColumn";
            this.ClientNumbOfOrdersColumn.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1078, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 517);
            this.panel1.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.FindFurnitureButton);
            this.panel9.Controls.Add(this.ResetSortParametersButton);
            this.panel9.Location = new System.Drawing.Point(2, 458);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(292, 57);
            this.panel9.TabIndex = 5;
            // 
            // FindFurnitureButton
            // 
            this.FindFurnitureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindFurnitureButton.Location = new System.Drawing.Point(-3, 30);
            this.FindFurnitureButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FindFurnitureButton.Name = "FindFurnitureButton";
            this.FindFurnitureButton.Size = new System.Drawing.Size(292, 25);
            this.FindFurnitureButton.TabIndex = 4;
            this.FindFurnitureButton.Text = "Найти мебель";
            this.FindFurnitureButton.UseVisualStyleBackColor = true;
            // 
            // ResetSortParametersButton
            // 
            this.ResetSortParametersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetSortParametersButton.Location = new System.Drawing.Point(-1, 0);
            this.ResetSortParametersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResetSortParametersButton.Name = "ResetSortParametersButton";
            this.ResetSortParametersButton.Size = new System.Drawing.Size(292, 26);
            this.ResetSortParametersButton.TabIndex = 4;
            this.ResetSortParametersButton.Text = "Сбросить параметры сортировки";
            this.ResetSortParametersButton.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.OrderByAscending);
            this.panel8.Controls.Add(this.OrderByDescending);
            this.panel8.Location = new System.Drawing.Point(2, 429);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(300, 25);
            this.panel8.TabIndex = 3;
            // 
            // OrderByAscending
            // 
            this.OrderByAscending.AutoSize = true;
            this.OrderByAscending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderByAscending.Location = new System.Drawing.Point(2, 2);
            this.OrderByAscending.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderByAscending.Name = "OrderByAscending";
            this.OrderByAscending.Size = new System.Drawing.Size(134, 21);
            this.OrderByAscending.TabIndex = 2;
            this.OrderByAscending.TabStop = true;
            this.OrderByAscending.Text = "По возрастанию";
            this.OrderByAscending.UseVisualStyleBackColor = true;
            // 
            // OrderByDescending
            // 
            this.OrderByDescending.AutoSize = true;
            this.OrderByDescending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderByDescending.Location = new System.Drawing.Point(175, 2);
            this.OrderByDescending.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderByDescending.Name = "OrderByDescending";
            this.OrderByDescending.Size = new System.Drawing.Size(114, 21);
            this.OrderByDescending.TabIndex = 2;
            this.OrderByDescending.TabStop = true;
            this.OrderByDescending.Text = "По убыванию";
            this.OrderByDescending.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.OrderByMaterialRadio);
            this.panel7.Controls.Add(this.OrderByTypeRadio);
            this.panel7.Controls.Add(this.OrderByRoomRadio);
            this.panel7.Controls.Add(this.OrderByMadeByRadio);
            this.panel7.Controls.Add(this.OrderByNameRadio);
            this.panel7.Location = new System.Drawing.Point(0, 360);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(302, 65);
            this.panel7.TabIndex = 1;
            // 
            // OrderByMaterialRadio
            // 
            this.OrderByMaterialRadio.AutoSize = true;
            this.OrderByMaterialRadio.Checked = true;
            this.OrderByMaterialRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderByMaterialRadio.Location = new System.Drawing.Point(3, 45);
            this.OrderByMaterialRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderByMaterialRadio.Name = "OrderByMaterialRadio";
            this.OrderByMaterialRadio.Size = new System.Drawing.Size(119, 21);
            this.OrderByMaterialRadio.TabIndex = 2;
            this.OrderByMaterialRadio.TabStop = true;
            this.OrderByMaterialRadio.Text = "По материалу";
            this.OrderByMaterialRadio.UseVisualStyleBackColor = true;
            // 
            // OrderByTypeRadio
            // 
            this.OrderByTypeRadio.AutoSize = true;
            this.OrderByTypeRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderByTypeRadio.Location = new System.Drawing.Point(2, 24);
            this.OrderByTypeRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderByTypeRadio.Name = "OrderByTypeRadio";
            this.OrderByTypeRadio.Size = new System.Drawing.Size(78, 21);
            this.OrderByTypeRadio.TabIndex = 2;
            this.OrderByTypeRadio.Text = "По типу";
            this.OrderByTypeRadio.UseVisualStyleBackColor = true;
            this.OrderByTypeRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // OrderByRoomRadio
            // 
            this.OrderByRoomRadio.AutoSize = true;
            this.OrderByRoomRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderByRoomRadio.Location = new System.Drawing.Point(147, 44);
            this.OrderByRoomRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderByRoomRadio.Name = "OrderByRoomRadio";
            this.OrderByRoomRadio.Size = new System.Drawing.Size(126, 21);
            this.OrderByRoomRadio.TabIndex = 2;
            this.OrderByRoomRadio.Text = "По помещению";
            this.OrderByRoomRadio.UseVisualStyleBackColor = true;
            // 
            // OrderByMadeByRadio
            // 
            this.OrderByMadeByRadio.AutoSize = true;
            this.OrderByMadeByRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderByMadeByRadio.Location = new System.Drawing.Point(147, 2);
            this.OrderByMadeByRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderByMadeByRadio.Name = "OrderByMadeByRadio";
            this.OrderByMadeByRadio.Size = new System.Drawing.Size(151, 21);
            this.OrderByMadeByRadio.TabIndex = 2;
            this.OrderByMadeByRadio.Text = "По производителю";
            this.OrderByMadeByRadio.UseVisualStyleBackColor = true;
            // 
            // OrderByNameRadio
            // 
            this.OrderByNameRadio.AutoSize = true;
            this.OrderByNameRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderByNameRadio.Location = new System.Drawing.Point(2, 2);
            this.OrderByNameRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderByNameRadio.Name = "OrderByNameRadio";
            this.OrderByNameRadio.Size = new System.Drawing.Size(112, 21);
            this.OrderByNameRadio.TabIndex = 2;
            this.OrderByNameRadio.Text = "По названию";
            this.OrderByNameRadio.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.FurnitureRoomTextBox);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(2, 205);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(297, 37);
            this.panel6.TabIndex = 1;
            // 
            // FurnitureRoomTextBox
            // 
            this.FurnitureRoomTextBox.Location = new System.Drawing.Point(171, 4);
            this.FurnitureRoomTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FurnitureRoomTextBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.FurnitureRoomTextBox.Name = "FurnitureRoomTextBox";
            this.FurnitureRoomTextBox.Size = new System.Drawing.Size(120, 30);
            this.FurnitureRoomTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Помещение";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.FurnitureMadeByTextBox);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(1, 160);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 40);
            this.panel5.TabIndex = 1;
            // 
            // FurnitureMadeByTextBox
            // 
            this.FurnitureMadeByTextBox.Location = new System.Drawing.Point(172, 4);
            this.FurnitureMadeByTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FurnitureMadeByTextBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.FurnitureMadeByTextBox.Name = "FurnitureMadeByTextBox";
            this.FurnitureMadeByTextBox.Size = new System.Drawing.Size(120, 30);
            this.FurnitureMadeByTextBox.TabIndex = 1;
            this.FurnitureMadeByTextBox.TextChanged += new System.EventHandler(this.FurnitureMadeByTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(2, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Производитель ";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.FurnitureMaterialTextBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 117);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(298, 38);
            this.panel4.TabIndex = 1;
            // 
            // FurnitureMaterialTextBox
            // 
            this.FurnitureMaterialTextBox.Location = new System.Drawing.Point(173, 6);
            this.FurnitureMaterialTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FurnitureMaterialTextBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.FurnitureMaterialTextBox.Name = "FurnitureMaterialTextBox";
            this.FurnitureMaterialTextBox.Size = new System.Drawing.Size(120, 30);
            this.FurnitureMaterialTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Материал";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.FurnitureTypeTextBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 38);
            this.panel3.TabIndex = 1;
            // 
            // FurnitureTypeTextBox
            // 
            this.FurnitureTypeTextBox.Location = new System.Drawing.Point(173, 2);
            this.FurnitureTypeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FurnitureTypeTextBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.FurnitureTypeTextBox.Name = "FurnitureTypeTextBox";
            this.FurnitureTypeTextBox.Size = new System.Drawing.Size(120, 30);
            this.FurnitureTypeTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(2, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Тип";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FurnitureNameTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 38);
            this.panel2.TabIndex = 1;
            // 
            // FurnitureNameTextBox
            // 
            this.FurnitureNameTextBox.Location = new System.Drawing.Point(172, 6);
            this.FurnitureNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FurnitureNameTextBox.MinimumSize = new System.Drawing.Size(4, 30);
            this.FurnitureNameTextBox.Name = "FurnitureNameTextBox";
            this.FurnitureNameTextBox.Size = new System.Drawing.Size(120, 30);
            this.FurnitureNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название мебели";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск и сортировка мебели";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(226, 448);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(672, 20);
            this.textBox1.TabIndex = 6;
            // 
            // FurnitureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 596);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FurnitureForm";
            this.Text = "Мебель";
            this.Load += new System.EventHandler(this.FurnitureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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

    }
    #endregion
}