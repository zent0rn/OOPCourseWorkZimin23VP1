namespace OOPCourseWorkZimin23VP1.forms
{
    partial class EditPersonForm
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
            nameTextBox = new TextBox();
            phoneTextBox = new TextBox();
            emailTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            exitButton = new Button();
            ApplyButton = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(phoneTextBox);
            panel1.Controls.Add(emailTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 363);
            panel1.TabIndex = 0;
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameTextBox.Location = new Point(213, 70);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(271, 30);
            nameTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 204);
            phoneTextBox.Location = new Point(213, 176);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(271, 30);
            phoneTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 11.1272726F, FontStyle.Regular, GraphicsUnit.Point, 204);
            emailTextBox.Location = new Point(213, 285);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(271, 30);
            emailTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 290);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 2;
            label3.Text = "Редактируйте почту";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 176);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 1;
            label2.Text = "Редактируйте телефон";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 70);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "Редактируйте имя";
            // 
            // exitButton
            // 
            exitButton.Dock = DockStyle.Left;
            exitButton.Location = new Point(0, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(152, 49);
            exitButton.TabIndex = 0;
            exitButton.Text = "Отмена";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // ApplyButton
            // 
            ApplyButton.Dock = DockStyle.Right;
            ApplyButton.Location = new Point(412, 0);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(143, 49);
            ApplyButton.TabIndex = 1;
            ApplyButton.Text = "Применить";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(exitButton);
            panel2.Controls.Add(ApplyButton);
            panel2.Location = new Point(12, 413);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 49);
            panel2.TabIndex = 2;
            // 
            // EditPersonForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(579, 474);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "EditPersonForm";
            Text = "Редактировать ответственное лицо";
            Load += EditPersonForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox nameTextBox;
        private TextBox phoneTextBox;
        private TextBox emailTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button exitButton;
        private Button ApplyButton;
        private Panel panel2;
    }
}