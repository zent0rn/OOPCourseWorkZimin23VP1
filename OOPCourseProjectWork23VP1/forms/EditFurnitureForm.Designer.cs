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
            label1 = new Label();
            EditFurnitureIDNumeric = new NumericUpDown();
            UploadFurnitureData = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            panel3 = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditFurnitureIDNumeric).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(UploadFurnitureData);
            panel1.Controls.Add(EditFurnitureIDNumeric);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 112);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(57, 19);
            label1.Name = "label1";
            label1.Size = new Size(96, 22);
            label1.TabIndex = 0;
            label1.Text = "ID Мебели";
            // 
            // EditFurnitureIDNumeric
            // 
            EditFurnitureIDNumeric.Location = new Point(246, 20);
            EditFurnitureIDNumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            EditFurnitureIDNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            EditFurnitureIDNumeric.Name = "EditFurnitureIDNumeric";
            EditFurnitureIDNumeric.Size = new Size(164, 24);
            EditFurnitureIDNumeric.TabIndex = 1;
            EditFurnitureIDNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // UploadFurnitureData
            // 
            UploadFurnitureData.Location = new Point(134, 61);
            UploadFurnitureData.Name = "UploadFurnitureData";
            UploadFurnitureData.Size = new Size(164, 48);
            UploadFurnitureData.TabIndex = 2;
            UploadFurnitureData.Text = "Загрузить данные о мебели";
            UploadFurnitureData.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(numericUpDown3);
            panel2.Controls.Add(numericUpDown2);
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(14, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(441, 381);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(59, 13);
            label2.Name = "label2";
            label2.Size = new Size(347, 22);
            label2.TabIndex = 0;
            label2.Text = "Редактирование основной информации";
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 11.1272726F);
            label7.Location = new Point(3, 255);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 5;
            label7.Text = "ID Помещения";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 11.1272726F);
            label8.Location = new Point(3, 304);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 6;
            label8.Text = "Цена";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 11.1272726F);
            label9.Location = new Point(3, 346);
            label9.Name = "label9";
            label9.Size = new Size(225, 20);
            label9.TabIndex = 7;
            label9.Text = "Количество в помещении";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 24);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(245, 111);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 24);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(245, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 24);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(245, 207);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(189, 24);
            textBox4.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(245, 253);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(189, 24);
            numericUpDown1.TabIndex = 12;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(245, 302);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(189, 24);
            numericUpDown2.TabIndex = 13;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(245, 344);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(189, 24);
            numericUpDown3.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(14, 542);
            panel3.Name = "panel3";
            panel3.Size = new Size(441, 51);
            panel3.TabIndex = 2;
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
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.Location = new Point(298, 0);
            button2.Name = "button2";
            button2.Size = new Size(143, 51);
            button2.TabIndex = 1;
            button2.Text = "Применить изменения";
            button2.UseVisualStyleBackColor = true;
            // 
            // EditFurnitureForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(462, 598);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "EditFurnitureForm";
            Text = "Редактирование мебели";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EditFurnitureIDNumeric).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button UploadFurnitureData;
        private NumericUpDown EditFurnitureIDNumeric;
        private Label label1;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel3;
        private Button button2;
        private Button button1;
    }
}