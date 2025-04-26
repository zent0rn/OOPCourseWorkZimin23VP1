namespace OOPCourseWorkZimin23VP1.forms
{
    partial class DatabaseChoiceDialogForm
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
            btnCancel = new Button();
            btnOpenExisting = new Button();
            btnCreateNew = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnOpenExisting);
            panel1.Controls.Add(btnCreateNew);
            panel1.Location = new Point(15, 195);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 59);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Right;
            btnCancel.Location = new Point(602, 0);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 59);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOpenExisting
            // 
            btnOpenExisting.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnOpenExisting.Location = new Point(257, 0);
            btnOpenExisting.Margin = new Padding(4, 3, 4, 3);
            btnOpenExisting.Name = "btnOpenExisting";
            btnOpenExisting.Size = new Size(270, 59);
            btnOpenExisting.TabIndex = 1;
            btnOpenExisting.Text = "Открыть существующую БД";
            btnOpenExisting.UseVisualStyleBackColor = true;
            btnOpenExisting.Click += btnOpenExisting_Click_1;
            // 
            // btnCreateNew
            // 
            btnCreateNew.Dock = DockStyle.Left;
            btnCreateNew.Location = new Point(0, 0);
            btnCreateNew.Margin = new Padding(4, 3, 4, 3);
            btnCreateNew.Name = "btnCreateNew";
            btnCreateNew.Size = new Size(190, 59);
            btnCreateNew.TabIndex = 0;
            btnCreateNew.Text = "Создать новую БД";
            btnCreateNew.UseVisualStyleBackColor = true;
            btnCreateNew.Click += btnCreateNew_Click_1;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 20.2909088F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(765, 121);
            label1.TabIndex = 3;
            label1.Text = "Выберите действие с БД";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(15, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(765, 121);
            panel2.TabIndex = 4;
            // 
            // DatabaseChoiceDialogForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(792, 265);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(810, 309);
            Name = "DatabaseChoiceDialogForm";
            Text = "Выбор действия с БД";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnOpenExisting;
        private Button btnCreateNew;
        private Label label1;
        private Panel panel2;
    }
}