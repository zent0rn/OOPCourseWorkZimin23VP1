namespace OOPCourseWorkZimin23VP1.forms
{
    partial class AddResponsiblePersonForm
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
            AddPersonButton = new Button();
            exitButton = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            RespPersonNameTextBox = new TextBox();
            RespPersonPhoneTextBox = new TextBox();
            RespPersonEmailTextBox = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(AddPersonButton);
            panel1.Controls.Add(exitButton);
            panel1.Location = new Point(12, 392);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 51);
            panel1.TabIndex = 0;
            // 
            // AddPersonButton
            // 
            AddPersonButton.BackColor = Color.Bisque;
            AddPersonButton.Dock = DockStyle.Right;
            AddPersonButton.Location = new Point(404, 0);
            AddPersonButton.Name = "AddPersonButton";
            AddPersonButton.Size = new Size(160, 51);
            AddPersonButton.TabIndex = 1;
            AddPersonButton.Text = "Добавить";
            AddPersonButton.UseVisualStyleBackColor = false;
            AddPersonButton.Click += AddPersonButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Bisque;
            exitButton.Dock = DockStyle.Left;
            exitButton.Location = new Point(0, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(147, 51);
            exitButton.TabIndex = 0;
            exitButton.Text = "Отмена";
            exitButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(RespPersonNameTextBox);
            panel2.Controls.Add(RespPersonPhoneTextBox);
            panel2.Controls.Add(RespPersonEmailTextBox);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 374);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 251);
            label3.Name = "label3";
            label3.Size = new Size(231, 19);
            label3.TabIndex = 5;
            label3.Text = "Введите email ответственного лица";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 166);
            label2.Name = "label2";
            label2.Size = new Size(252, 19);
            label2.TabIndex = 4;
            label2.Text = "Введите телефон ответственного лица";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 92);
            label1.Name = "label1";
            label1.Size = new Size(224, 19);
            label1.TabIndex = 3;
            label1.Text = "Введите имя ответственного лица";
            // 
            // RespPersonNameTextBox
            // 
            RespPersonNameTextBox.Location = new Point(321, 85);
            RespPersonNameTextBox.Name = "RespPersonNameTextBox";
            RespPersonNameTextBox.Size = new Size(222, 26);
            RespPersonNameTextBox.TabIndex = 2;
            // 
            // RespPersonPhoneTextBox
            // 
            RespPersonPhoneTextBox.Location = new Point(321, 159);
            RespPersonPhoneTextBox.Name = "RespPersonPhoneTextBox";
            RespPersonPhoneTextBox.Size = new Size(222, 26);
            RespPersonPhoneTextBox.TabIndex = 1;
            // 
            // RespPersonEmailTextBox
            // 
            RespPersonEmailTextBox.Location = new Point(321, 244);
            RespPersonEmailTextBox.Name = "RespPersonEmailTextBox";
            RespPersonEmailTextBox.Size = new Size(222, 26);
            RespPersonEmailTextBox.TabIndex = 0;
            // 
            // AddResponsiblePersonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(582, 455);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddResponsiblePersonForm";
            Text = "Добавление ответственного лица";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button AddPersonButton;
        private Button exitButton;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox RespPersonNameTextBox;
        private TextBox RespPersonPhoneTextBox;
        private TextBox RespPersonEmailTextBox;
    }
}