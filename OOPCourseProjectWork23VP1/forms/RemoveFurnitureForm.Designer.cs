namespace OOPCourseWorkZimin23VP1.forms
{
    partial class RemoveFurnitureForm
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
            numericUpDown1 = new NumericUpDown();
            panel1 = new Panel();
            panel2 = new Panel();
            DeleteFurnitureButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(244, 18);
            label1.TabIndex = 0;
            label1.Text = "Введите ID мебели для удаления:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numericUpDown1.Location = new Point(380, 10);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(174, 24);
            numericUpDown1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 42);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(DeleteFurnitureButton);
            panel2.Location = new Point(3, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 42);
            panel2.TabIndex = 2;
            // 
            // DeleteFurnitureButton
            // 
            DeleteFurnitureButton.Dock = DockStyle.Fill;
            DeleteFurnitureButton.Location = new Point(0, 0);
            DeleteFurnitureButton.Name = "DeleteFurnitureButton";
            DeleteFurnitureButton.Size = new Size(555, 42);
            DeleteFurnitureButton.TabIndex = 0;
            DeleteFurnitureButton.Text = "Удалить мебель";
            DeleteFurnitureButton.UseVisualStyleBackColor = true;
            // 
            // RemoveFurnitureForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(564, 119);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MinimumSize = new Size(582, 163);
            Name = "RemoveFurnitureForm";
            Text = "Удаление мебели";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private Panel panel1;
        private Panel panel2;
        private Button DeleteFurnitureButton;
    }
}