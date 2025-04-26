namespace OOPCourseWorkZimin23VP1.forms
{
    partial class StartWindowForm
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
            label5 = new Label();
            StartButton = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 15.7090912F);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(756, 184);
            label5.Name = "label5";
            label5.Size = new Size(194, 142);
            label5.TabIndex = 9;
            label5.Text = "Выполнил:\r\nСтудент группы 23ВП1\r\nЗимин Е. А.\r\n\r\n";
            // 
            // StartButton
            // 
            StartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StartButton.Cursor = Cursors.Hand;
            StartButton.ForeColor = Color.LimeGreen;
            StartButton.ImeMode = ImeMode.NoControl;
            StartButton.Location = new Point(13, 252);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(451, 71);
            StartButton.TabIndex = 8;
            StartButton.Text = "Запуск";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click_1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(4, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(946, 170);
            panel1.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(label4);
            panel5.Location = new Point(103, 116);
            panel5.Name = "panel5";
            panel5.Size = new Size(837, 51);
            panel5.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 18.3272724F);
            label4.ForeColor = Color.MidnightBlue;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(3, 8);
            label4.Name = "label4";
            label4.Size = new Size(825, 37);
            label4.TabIndex = 3;
            label4.Text = "\"Разработка программы с использованием ООП. ИС Мебель\"";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(8, 121);
            panel4.Name = "panel4";
            panel4.Size = new Size(88, 45);
            panel4.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(4, 13);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 8;
            label6.Text = "На тему:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 11.7818184F);
            label3.ForeColor = SystemColors.HotTrack;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(-9, 12);
            label3.Name = "label3";
            label3.Size = new Size(0, 33);
            label3.TabIndex = 2;
            label3.Text = "По теме:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(164, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(681, 45);
            panel3.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.7454548F);
            label2.ForeColor = SystemColors.Highlight;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(20, 12);
            label2.Name = "label2";
            label2.Size = new Size(658, 27);
            label2.TabIndex = 1;
            label2.Text = "по дисциплине \"Объектно-ориентированное программирование\"";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(318, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 63);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.PeachPuff;
            label1.Font = new Font("Segoe UI", 24.2181816F, FontStyle.Bold);
            label1.ForeColor = Color.Teal;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(386, 51);
            label1.TabIndex = 0;
            label1.Text = "Курсовая работа";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartWindowForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(954, 336);
            Controls.Add(label5);
            Controls.Add(StartButton);
            Controls.Add(panel1);
            MinimumSize = new Size(972, 380);
            Name = "StartWindowForm";
            Text = "Стартовое окно";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label5;
        private Button StartButton;
        private Panel panel1;
        private Panel panel5;
        private Label label4;
        private Panel panel4;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private Panel panel2;
        private Label label1;
        private Label label6;
    }
}