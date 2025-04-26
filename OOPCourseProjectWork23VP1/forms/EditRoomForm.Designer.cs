namespace OOPCourseWorkZimin23VP1.forms
{
    partial class EditRoomForm
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
            areaNumericUpDown = new NumericUpDown();
            addressTextBox = new TextBox();
            nameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            applyButton = new Button();
            exitButton = new Button();
            panel3 = new Panel();
            AddRespPersonButton = new Button();
            label4 = new Label();
            ResponsiblePersonListView = new ListView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)areaNumericUpDown).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(areaNumericUpDown);
            panel1.Controls.Add(addressTextBox);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 333);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(195, 23);
            label5.TabIndex = 6;
            label5.Text = "Основная информация";
            // 
            // areaNumericUpDown
            // 
            areaNumericUpDown.Location = new Point(278, 233);
            areaNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            areaNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            areaNumericUpDown.Name = "areaNumericUpDown";
            areaNumericUpDown.Size = new Size(208, 24);
            areaNumericUpDown.TabIndex = 5;
            areaNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(278, 159);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(208, 24);
            addressTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(278, 70);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(208, 24);
            nameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 249);
            label3.Name = "label3";
            label3.Size = new Size(170, 18);
            label3.TabIndex = 2;
            label3.Text = "Редактируйте площадь";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 166);
            label2.Name = "label2";
            label2.Size = new Size(153, 18);
            label2.TabIndex = 1;
            label2.Text = "Редактируйте адрес ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 73);
            label1.Name = "label1";
            label1.Size = new Size(208, 18);
            label1.TabIndex = 0;
            label1.Text = "Редактируйте наименование";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(applyButton);
            panel2.Controls.Add(exitButton);
            panel2.Location = new Point(14, 397);
            panel2.Name = "panel2";
            panel2.Size = new Size(1181, 48);
            panel2.TabIndex = 0;
            // 
            // applyButton
            // 
            applyButton.Dock = DockStyle.Right;
            applyButton.Location = new Point(1022, 0);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(159, 48);
            applyButton.TabIndex = 1;
            applyButton.Text = "Применить";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // exitButton
            // 
            exitButton.Dock = DockStyle.Left;
            exitButton.Location = new Point(0, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(202, 48);
            exitButton.TabIndex = 0;
            exitButton.Text = "Отмена";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = Color.PeachPuff;
            panel3.Controls.Add(AddRespPersonButton);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(ResponsiblePersonListView);
            panel3.Location = new Point(523, 11);
            panel3.Name = "panel3";
            panel3.Size = new Size(672, 333);
            panel3.TabIndex = 4;
            // 
            // AddRespPersonButton
            // 
            AddRespPersonButton.Dock = DockStyle.Bottom;
            AddRespPersonButton.Font = new Font("Segoe UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddRespPersonButton.Location = new Point(0, 291);
            AddRespPersonButton.Name = "AddRespPersonButton";
            AddRespPersonButton.Size = new Size(672, 42);
            AddRespPersonButton.TabIndex = 4;
            AddRespPersonButton.Text = "Добавить...";
            AddRespPersonButton.UseVisualStyleBackColor = true;
            AddRespPersonButton.Click += AddRespPersonButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(204, 10);
            label4.Name = "label4";
            label4.Size = new Size(272, 20);
            label4.TabIndex = 3;
            label4.Text = "Выберите ответственное лицо";
            // 
            // ResponsiblePersonListView
            // 
            ResponsiblePersonListView.Location = new Point(0, 33);
            ResponsiblePersonListView.Name = "ResponsiblePersonListView";
            ResponsiblePersonListView.Size = new Size(671, 253);
            ResponsiblePersonListView.TabIndex = 1;
            ResponsiblePersonListView.UseCompatibleStateImageBehavior = false;
            ResponsiblePersonListView.SelectedIndexChanged += ResponsiblePersonListView_SelectedIndexChanged_1;
            // 
            // EditRoomForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1213, 457);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MinimumSize = new Size(1231, 456);
            Name = "EditRoomForm";
            Text = "Редактировать помещение";
            Load += EditRoomForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)areaNumericUpDown).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private NumericUpDown areaNumericUpDown;
        private TextBox addressTextBox;
        private TextBox nameTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button applyButton;
        private Button exitButton;
        private Panel panel3;
        private Label label4;
        private ListView ResponsiblePersonListView;
        private Button AddRespPersonButton;
        private Label label5;
    }
}