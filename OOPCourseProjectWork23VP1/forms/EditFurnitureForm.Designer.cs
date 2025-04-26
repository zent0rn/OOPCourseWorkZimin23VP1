namespace OOPCourseWorkZimin23VP1.forms
{
    partial class EditFurnitureForm
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
            panel1 = new Panel();
            CreateNewRoomButton = new Button();
            label1 = new Label();
            roomListView = new ListView();
            panel2 = new Panel();
            QuantityNumeric = new NumericUpDown();
            PriceNumeric = new NumericUpDown();
            CountryTextBox = new TextBox();
            MaterialTextBox = new TextBox();
            TypeTextBox = new TextBox();
            NameTextBox = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            EditButton = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumeric).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(CreateNewRoomButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(roomListView);
            panel1.Location = new Point(508, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(616, 405);
            panel1.TabIndex = 0;
            // 
            // CreateNewRoomButton
            // 
            CreateNewRoomButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CreateNewRoomButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CreateNewRoomButton.Location = new Point(0, 354);
            CreateNewRoomButton.Name = "CreateNewRoomButton";
            CreateNewRoomButton.Size = new Size(616, 51);
            CreateNewRoomButton.TabIndex = 5;
            CreateNewRoomButton.Text = "Новое помещение...";
            CreateNewRoomButton.UseVisualStyleBackColor = true;
            CreateNewRoomButton.Click += CreateNewRoomButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(294, 18);
            label1.TabIndex = 4;
            label1.Text = "Помещение, в котором хранится мебель";
            // 
            // roomListView
            // 
            roomListView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            roomListView.Location = new Point(3, 36);
            roomListView.Name = "roomListView";
            roomListView.Size = new Size(610, 253);
            roomListView.TabIndex = 1;
            roomListView.UseCompatibleStateImageBehavior = false;
            roomListView.SelectedIndexChanged += FurnitureListView_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(QuantityNumeric);
            panel2.Controls.Add(PriceNumeric);
            panel2.Controls.Add(CountryTextBox);
            panel2.Controls.Add(MaterialTextBox);
            panel2.Controls.Add(TypeTextBox);
            panel2.Controls.Add(NameTextBox);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(453, 405);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // QuantityNumeric
            // 
            QuantityNumeric.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            QuantityNumeric.Location = new Point(237, 307);
            QuantityNumeric.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            QuantityNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            QuantityNumeric.Name = "QuantityNumeric";
            QuantityNumeric.Size = new Size(206, 24);
            QuantityNumeric.TabIndex = 14;
            QuantityNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // PriceNumeric
            // 
            PriceNumeric.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PriceNumeric.Location = new Point(237, 265);
            PriceNumeric.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            PriceNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PriceNumeric.Name = "PriceNumeric";
            PriceNumeric.Size = new Size(206, 24);
            PriceNumeric.TabIndex = 13;
            PriceNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CountryTextBox
            // 
            CountryTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CountryTextBox.Location = new Point(236, 207);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(206, 24);
            CountryTextBox.TabIndex = 11;
            // 
            // MaterialTextBox
            // 
            MaterialTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaterialTextBox.Location = new Point(236, 160);
            MaterialTextBox.Name = "MaterialTextBox";
            MaterialTextBox.Size = new Size(206, 24);
            MaterialTextBox.TabIndex = 10;
            // 
            // TypeTextBox
            // 
            TypeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TypeTextBox.Location = new Point(236, 111);
            TypeTextBox.Name = "TypeTextBox";
            TypeTextBox.Size = new Size(206, 24);
            TypeTextBox.TabIndex = 9;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NameTextBox.Location = new Point(237, 62);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(205, 24);
            NameTextBox.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 11.1272726F);
            label9.Location = new Point(4, 309);
            label9.Name = "label9";
            label9.Size = new Size(225, 20);
            label9.TabIndex = 7;
            label9.Text = "Количество в помещении";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.1272726F);
            label8.Location = new Point(4, 267);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 6;
            label8.Text = "Цена";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11.1272726F);
            label6.Location = new Point(3, 207);
            label6.Name = "label6";
            label6.Size = new Size(208, 20);
            label6.TabIndex = 4;
            label6.Text = "Страна-производитель";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.1272726F);
            label5.Location = new Point(3, 160);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 3;
            label5.Text = "Материал";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.1272726F);
            label4.Location = new Point(3, 111);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 2;
            label4.Text = "Тип";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.1272726F);
            label3.Location = new Point(4, 65);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 1;
            label3.Text = "Название";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(347, 22);
            label2.TabIndex = 0;
            label2.Text = "Редактирование основной информации";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(EditButton);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(12, 423);
            panel3.Name = "panel3";
            panel3.Size = new Size(1112, 51);
            panel3.TabIndex = 2;
            // 
            // EditButton
            // 
            EditButton.Dock = DockStyle.Right;
            EditButton.Location = new Point(969, 0);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(143, 51);
            EditButton.TabIndex = 1;
            EditButton.Text = "Применить изменения";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += editButton_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(153, 51);
            button1.TabIndex = 0;
            button1.Text = "Отменить изменения";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditFurnitureForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1138, 486);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MinimumSize = new Size(832, 530);
            Name = "EditFurnitureForm";
            Text = "Редактирование мебели";
            Load += EditFurnitureForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriceNumeric).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private NumericUpDown QuantityNumeric;
        private NumericUpDown PriceNumeric;
        private TextBox CountryTextBox;
        private TextBox MaterialTextBox;
        private TextBox TypeTextBox;
        private TextBox NameTextBox;
        private Panel panel3;
        private Button EditButton;
        private Button button1;
        private ListView roomListView;
        private Label label1;
        private Button CreateNewRoomButton;
    }
}