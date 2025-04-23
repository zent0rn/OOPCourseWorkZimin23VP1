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
            exitButton = new Button();
            AddPersonButton = new Button();
            panel2 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 374);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(321, 244);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 26);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(321, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 26);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(321, 85);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(222, 26);
            textBox3.TabIndex = 2;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 166);
            label2.Name = "label2";
            label2.Size = new Size(252, 19);
            label2.TabIndex = 4;
            label2.Text = "Введите телефон ответственного лица";
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
            // AddResponsiblePersonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
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
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}