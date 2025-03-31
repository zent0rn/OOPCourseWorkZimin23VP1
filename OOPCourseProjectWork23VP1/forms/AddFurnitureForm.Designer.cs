namespace OOPCourseWorkZimin23VP1.forms
{
    partial class AddFurnitureForm
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
            label1 = new Label();
            panel1 = new Panel();
            FurnitureValueInRoomNumeric = new NumericUpDown();
            FurniturePriceNumeric = new NumericUpDown();
            FurnitureCountryBox = new TextBox();
            FurnitureMaterialBox = new TextBox();
            FurnitureTypeBox = new TextBox();
            FurnitureNameBox = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            AddFurntiureButton = new Button();
            DeclineAddFurnitureButton = new Button();
            panel3 = new Panel();
            CreateNewRoomButton = new Button();
            listView1 = new ListView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FurnitureValueInRoomNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FurniturePriceNumeric).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(152, 6);
            label1.Name = "label1";
            label1.Size = new Size(204, 25);
            label1.TabIndex = 0;
            label1.Text = "Основная информация";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(FurnitureValueInRoomNumeric);
            panel1.Controls.Add(FurniturePriceNumeric);
            panel1.Controls.Add(FurnitureCountryBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(FurnitureMaterialBox);
            panel1.Controls.Add(FurnitureTypeBox);
            panel1.Controls.Add(FurnitureNameBox);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 328);
            panel1.TabIndex = 1;
            // 
            // FurnitureValueInRoomNumeric
            // 
            FurnitureValueInRoomNumeric.Location = new Point(326, 252);
            FurnitureValueInRoomNumeric.Name = "FurnitureValueInRoomNumeric";
            FurnitureValueInRoomNumeric.Size = new Size(138, 26);
            FurnitureValueInRoomNumeric.TabIndex = 16;
            // 
            // FurniturePriceNumeric
            // 
            FurniturePriceNumeric.Location = new Point(326, 211);
            FurniturePriceNumeric.Name = "FurniturePriceNumeric";
            FurniturePriceNumeric.Size = new Size(138, 26);
            FurniturePriceNumeric.TabIndex = 15;
            // 
            // FurnitureCountryBox
            // 
            FurnitureCountryBox.Location = new Point(326, 175);
            FurnitureCountryBox.Name = "FurnitureCountryBox";
            FurnitureCountryBox.Size = new Size(138, 26);
            FurnitureCountryBox.TabIndex = 10;
            // 
            // FurnitureMaterialBox
            // 
            FurnitureMaterialBox.Location = new Point(326, 138);
            FurnitureMaterialBox.Name = "FurnitureMaterialBox";
            FurnitureMaterialBox.Size = new Size(138, 26);
            FurnitureMaterialBox.TabIndex = 9;
            // 
            // FurnitureTypeBox
            // 
            FurnitureTypeBox.Location = new Point(326, 101);
            FurnitureTypeBox.Name = "FurnitureTypeBox";
            FurnitureTypeBox.Size = new Size(138, 26);
            FurnitureTypeBox.TabIndex = 8;
            // 
            // FurnitureNameBox
            // 
            FurnitureNameBox.Location = new Point(326, 63);
            FurnitureNameBox.Name = "FurnitureNameBox";
            FurnitureNameBox.Size = new Size(138, 26);
            FurnitureNameBox.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 254);
            label8.Name = "label8";
            label8.Size = new Size(201, 19);
            label8.TabIndex = 6;
            label8.Text = "Количество мебели в комнате";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 213);
            label7.Name = "label7";
            label7.Size = new Size(92, 19);
            label7.TabIndex = 5;
            label7.Text = "Цена мебели";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 178);
            label5.Name = "label5";
            label5.Size = new Size(196, 19);
            label5.TabIndex = 3;
            label5.Text = "Страна производства мебели";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 141);
            label4.Name = "label4";
            label4.Size = new Size(123, 19);
            label4.TabIndex = 2;
            label4.Text = "Материал мебели";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 101);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 1;
            label3.Text = "Тип мебели";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 63);
            label2.Name = "label2";
            label2.Size = new Size(120, 19);
            label2.TabIndex = 0;
            label2.Text = "Название мебели";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(73, 15);
            label6.Name = "label6";
            label6.Size = new Size(334, 23);
            label6.TabIndex = 4;
            label6.Text = "Помещение, в котором хранится мебель";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(AddFurntiureButton);
            panel2.Controls.Add(DeclineAddFurnitureButton);
            panel2.Location = new Point(12, 397);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 56);
            panel2.TabIndex = 17;
            // 
            // AddFurntiureButton
            // 
            AddFurntiureButton.Cursor = Cursors.Hand;
            AddFurntiureButton.Dock = DockStyle.Right;
            AddFurntiureButton.Location = new Point(867, 0);
            AddFurntiureButton.Name = "AddFurntiureButton";
            AddFurntiureButton.Size = new Size(141, 56);
            AddFurntiureButton.TabIndex = 1;
            AddFurntiureButton.Text = "Добавить";
            AddFurntiureButton.UseVisualStyleBackColor = true;
            // 
            // DeclineAddFurnitureButton
            // 
            DeclineAddFurnitureButton.Cursor = Cursors.Hand;
            DeclineAddFurnitureButton.Dock = DockStyle.Left;
            DeclineAddFurnitureButton.Location = new Point(0, 0);
            DeclineAddFurnitureButton.Name = "DeclineAddFurnitureButton";
            DeclineAddFurnitureButton.Size = new Size(143, 56);
            DeclineAddFurnitureButton.TabIndex = 0;
            DeclineAddFurnitureButton.Text = "Отмена";
            DeclineAddFurnitureButton.UseVisualStyleBackColor = true;
            DeclineAddFurnitureButton.Click += DeclineAddFurnitureButton_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = Color.Bisque;
            panel3.Controls.Add(CreateNewRoomButton);
            panel3.Controls.Add(listView1);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(556, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(464, 328);
            panel3.TabIndex = 18;
            // 
            // CreateNewRoomButton
            // 
            CreateNewRoomButton.Cursor = Cursors.Hand;
            CreateNewRoomButton.Dock = DockStyle.Bottom;
            CreateNewRoomButton.Location = new Point(0, 276);
            CreateNewRoomButton.Name = "CreateNewRoomButton";
            CreateNewRoomButton.Size = new Size(464, 52);
            CreateNewRoomButton.TabIndex = 6;
            CreateNewRoomButton.Text = "Новое помещение...";
            CreateNewRoomButton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Location = new Point(13, 41);
            listView1.Name = "listView1";
            listView1.Size = new Size(432, 105);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // AddFurnitureForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1033, 465);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddFurnitureForm";
            Text = "Добавление мебели";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FurnitureValueInRoomNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)FurniturePriceNumeric).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox FurnitureCountryBox;
        private TextBox FurnitureMaterialBox;
        private TextBox FurnitureTypeBox;
        private TextBox FurnitureNameBox;
        private NumericUpDown FurnitureValueInRoomNumeric;
        private NumericUpDown FurniturePriceNumeric;
        private Panel panel2;
        private Button DeclineAddFurnitureButton;
        private Button AddFurntiureButton;
        private Panel panel3;
        private Button CreateNewRoomButton;
        private ListView listView1;
    }
}