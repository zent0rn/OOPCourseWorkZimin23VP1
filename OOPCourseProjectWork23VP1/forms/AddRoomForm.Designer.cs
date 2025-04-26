namespace OOPCourseWorkZimin23VP1.forms
{
    partial class AddRoomForm
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
            label5 = new Label();
            label3 = new Label();
            areaNumeric = new NumericUpDown();
            RoomAdressTextBox = new TextBox();
            RoomNameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            exitButton = new Button();
            addRoomButton = new Button();
            ResponsiblePersonListView = new ListView();
            panel3 = new Panel();
            AddRespPersonButton = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)areaNumeric).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(areaNumeric);
            panel1.Controls.Add(RoomAdressTextBox);
            panel1.Controls.Add(RoomNameTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(556, 335);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(170, 18);
            label5.TabIndex = 6;
            label5.Text = "Основная информация";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 198);
            label3.Name = "label3";
            label3.Size = new Size(215, 18);
            label3.TabIndex = 5;
            label3.Text = "Введите площадь помещения";
            // 
            // areaNumeric
            // 
            areaNumeric.Location = new Point(310, 196);
            areaNumeric.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            areaNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            areaNumeric.Name = "areaNumeric";
            areaNumeric.Size = new Size(233, 24);
            areaNumeric.TabIndex = 2;
            areaNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // RoomAdressTextBox
            // 
            RoomAdressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RoomAdressTextBox.Location = new Point(310, 140);
            RoomAdressTextBox.Name = "RoomAdressTextBox";
            RoomAdressTextBox.Size = new Size(233, 24);
            RoomAdressTextBox.TabIndex = 4;
            // 
            // RoomNameTextBox
            // 
            RoomNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RoomNameTextBox.Location = new Point(310, 87);
            RoomNameTextBox.Name = "RoomNameTextBox";
            RoomNameTextBox.Size = new Size(233, 24);
            RoomNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 143);
            label2.Name = "label2";
            label2.Size = new Size(198, 18);
            label2.TabIndex = 1;
            label2.Text = "Введите адрес помещения:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 90);
            label1.Name = "label1";
            label1.Size = new Size(257, 18);
            label1.TabIndex = 0;
            label1.Text = "Введите наименование помещения:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(exitButton);
            panel2.Controls.Add(addRoomButton);
            panel2.Location = new Point(14, 385);
            panel2.Name = "panel2";
            panel2.Size = new Size(1180, 54);
            panel2.TabIndex = 1;
            // 
            // exitButton
            // 
            exitButton.Dock = DockStyle.Left;
            exitButton.Location = new Point(0, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(209, 54);
            exitButton.TabIndex = 1;
            exitButton.Text = "Отмена";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // addRoomButton
            // 
            addRoomButton.Dock = DockStyle.Right;
            addRoomButton.Location = new Point(944, 0);
            addRoomButton.Name = "addRoomButton";
            addRoomButton.Size = new Size(236, 54);
            addRoomButton.TabIndex = 0;
            addRoomButton.Text = "Добавить помещение";
            addRoomButton.UseVisualStyleBackColor = true;
            addRoomButton.Click += addRoomButton_Click;
            // 
            // ResponsiblePersonListView
            // 
            ResponsiblePersonListView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ResponsiblePersonListView.Location = new Point(0, 30);
            ResponsiblePersonListView.Name = "ResponsiblePersonListView";
            ResponsiblePersonListView.Size = new Size(618, 254);
            ResponsiblePersonListView.TabIndex = 1;
            ResponsiblePersonListView.UseCompatibleStateImageBehavior = false;
            ResponsiblePersonListView.SelectedIndexChanged += ResponsiblePersonListView_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(AddRespPersonButton);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(ResponsiblePersonListView);
            panel3.Location = new Point(576, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(618, 335);
            panel3.TabIndex = 3;
            // 
            // AddRespPersonButton
            // 
            AddRespPersonButton.Dock = DockStyle.Bottom;
            AddRespPersonButton.Location = new Point(0, 290);
            AddRespPersonButton.Name = "AddRespPersonButton";
            AddRespPersonButton.Size = new Size(618, 45);
            AddRespPersonButton.TabIndex = 4;
            AddRespPersonButton.Text = "Добавить...";
            AddRespPersonButton.UseVisualStyleBackColor = true;
            AddRespPersonButton.Click += AddRespPersonButton_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(189, 7);
            label4.Name = "label4";
            label4.Size = new Size(272, 20);
            label4.TabIndex = 3;
            label4.Text = "Выберите ответственное лицо";
            // 
            // AddRoomForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1206, 448);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MinimumSize = new Size(1070, 459);
            Name = "AddRoomForm";
            Text = "Добавить помещение";
            Load += AddRoomForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)areaNumeric).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox RoomAdressTextBox;
        private TextBox RoomNameTextBox;
        private Panel panel2;
        private Button addRoomButton;
        private Button exitButton;
        private Label label3;
        private NumericUpDown areaNumeric;
        private ListView ResponsiblePersonListView;
        private Panel panel3;
        private Label label4;
        private Button AddRespPersonButton;
        private Label label5;
    }
}