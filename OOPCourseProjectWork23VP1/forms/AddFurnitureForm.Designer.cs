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
            roomListView = new ListView();
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
            label1.Location = new Point(171, 6);
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
            panel1.Location = new Point(14, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 311);
            panel1.TabIndex = 1;
            // 
            // FurnitureValueInRoomNumeric
            // 
            FurnitureValueInRoomNumeric.Location = new Point(367, 241);
            FurnitureValueInRoomNumeric.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            FurnitureValueInRoomNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            FurnitureValueInRoomNumeric.Name = "FurnitureValueInRoomNumeric";
            FurnitureValueInRoomNumeric.Size = new Size(169, 24);
            FurnitureValueInRoomNumeric.TabIndex = 16;
            FurnitureValueInRoomNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FurniturePriceNumeric
            // 
            FurniturePriceNumeric.Location = new Point(367, 200);
            FurniturePriceNumeric.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            FurniturePriceNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            FurniturePriceNumeric.Name = "FurniturePriceNumeric";
            FurniturePriceNumeric.Size = new Size(169, 24);
            FurniturePriceNumeric.TabIndex = 15;
            FurniturePriceNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // FurnitureCountryBox
            // 
            FurnitureCountryBox.Location = new Point(367, 166);
            FurnitureCountryBox.Name = "FurnitureCountryBox";
            FurnitureCountryBox.Size = new Size(169, 24);
            FurnitureCountryBox.TabIndex = 10;
            // 
            // FurnitureMaterialBox
            // 
            FurnitureMaterialBox.Location = new Point(367, 131);
            FurnitureMaterialBox.Name = "FurnitureMaterialBox";
            FurnitureMaterialBox.Size = new Size(169, 24);
            FurnitureMaterialBox.TabIndex = 9;
            // 
            // FurnitureTypeBox
            // 
            FurnitureTypeBox.Location = new Point(367, 96);
            FurnitureTypeBox.Name = "FurnitureTypeBox";
            FurnitureTypeBox.Size = new Size(169, 24);
            FurnitureTypeBox.TabIndex = 8;
            // 
            // FurnitureNameBox
            // 
            FurnitureNameBox.Location = new Point(367, 60);
            FurnitureNameBox.Name = "FurnitureNameBox";
            FurnitureNameBox.Size = new Size(169, 24);
            FurnitureNameBox.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 241);
            label8.Name = "label8";
            label8.Size = new Size(224, 18);
            label8.TabIndex = 6;
            label8.Text = "Количество мебели в комнате";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 202);
            label7.Name = "label7";
            label7.Size = new Size(100, 18);
            label7.TabIndex = 5;
            label7.Text = "Цена мебели";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 169);
            label5.Name = "label5";
            label5.Size = new Size(217, 18);
            label5.TabIndex = 3;
            label5.Text = "Страна производства мебели";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 134);
            label4.Name = "label4";
            label4.Size = new Size(134, 18);
            label4.TabIndex = 2;
            label4.Text = "Материал мебели";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 96);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 1;
            label3.Text = "Тип мебели";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 60);
            label2.Name = "label2";
            label2.Size = new Size(132, 18);
            label2.TabIndex = 0;
            label2.Text = "Название мебели";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(194, 13);
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
            panel2.Location = new Point(14, 376);
            panel2.Name = "panel2";
            panel2.Size = new Size(1326, 53);
            panel2.TabIndex = 17;
            // 
            // AddFurntiureButton
            // 
            AddFurntiureButton.Cursor = Cursors.Hand;
            AddFurntiureButton.Dock = DockStyle.Right;
            AddFurntiureButton.Location = new Point(1167, 0);
            AddFurntiureButton.Name = "AddFurntiureButton";
            AddFurntiureButton.Size = new Size(159, 53);
            AddFurntiureButton.TabIndex = 1;
            AddFurntiureButton.Text = "Добавить";
            AddFurntiureButton.UseVisualStyleBackColor = true;
            AddFurntiureButton.Click += AddFurntiureButton_Click;
            // 
            // DeclineAddFurnitureButton
            // 
            DeclineAddFurnitureButton.Cursor = Cursors.Hand;
            DeclineAddFurnitureButton.Dock = DockStyle.Left;
            DeclineAddFurnitureButton.Location = new Point(0, 0);
            DeclineAddFurnitureButton.Name = "DeclineAddFurnitureButton";
            DeclineAddFurnitureButton.Size = new Size(161, 53);
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
            panel3.Controls.Add(roomListView);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(594, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(746, 311);
            panel3.TabIndex = 18;
            // 
            // CreateNewRoomButton
            // 
            CreateNewRoomButton.Cursor = Cursors.Hand;
            CreateNewRoomButton.Dock = DockStyle.Bottom;
            CreateNewRoomButton.Location = new Point(0, 266);
            CreateNewRoomButton.Name = "CreateNewRoomButton";
            CreateNewRoomButton.Size = new Size(746, 45);
            CreateNewRoomButton.TabIndex = 6;
            CreateNewRoomButton.Text = "Новое помещение...";
            CreateNewRoomButton.UseVisualStyleBackColor = true;
            CreateNewRoomButton.Click += CreateNewRoomButton_Click;
            // 
            // roomListView
            // 
            roomListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roomListView.Location = new Point(3, 39);
            roomListView.Name = "roomListView";
            roomListView.Size = new Size(739, 216);
            roomListView.TabIndex = 1;
            roomListView.UseCompatibleStateImageBehavior = false;
            roomListView.SelectedIndexChanged += roomListView_SelectedIndexChanged;
            // 
            // AddFurnitureForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1354, 441);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MinimumSize = new Size(1348, 457);
            Name = "AddFurnitureForm";
            Text = "Добавление мебели";
            Load += AddFurnitureForm_Load;
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
        private ListView roomListView;
    }
}