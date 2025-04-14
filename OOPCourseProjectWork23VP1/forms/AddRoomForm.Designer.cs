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
            RoomPersonNameTextBox = new TextBox();
            RoomAdressTextBox = new TextBox();
            RoomNameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            addRoomButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(RoomPersonNameTextBox);
            panel1.Controls.Add(RoomAdressTextBox);
            panel1.Controls.Add(RoomNameTextBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 160);
            panel1.TabIndex = 0;
            // 
            // RoomPersonNameTextBox
            // 
            RoomPersonNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RoomPersonNameTextBox.Location = new Point(413, 124);
            RoomPersonNameTextBox.Name = "RoomPersonNameTextBox";
            RoomPersonNameTextBox.Size = new Size(242, 24);
            RoomPersonNameTextBox.TabIndex = 5;
            // 
            // RoomAdressTextBox
            // 
            RoomAdressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RoomAdressTextBox.Location = new Point(413, 70);
            RoomAdressTextBox.Name = "RoomAdressTextBox";
            RoomAdressTextBox.Size = new Size(242, 24);
            RoomAdressTextBox.TabIndex = 4;
            // 
            // RoomNameTextBox
            // 
            RoomNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RoomNameTextBox.Location = new Point(413, 17);
            RoomNameTextBox.Name = "RoomNameTextBox";
            RoomNameTextBox.Size = new Size(242, 24);
            RoomNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 130);
            label3.Name = "label3";
            label3.Size = new Size(311, 18);
            label3.TabIndex = 2;
            label3.Text = "Введите имя отвественного за помещение:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 76);
            label2.Name = "label2";
            label2.Size = new Size(198, 18);
            label2.TabIndex = 1;
            label2.Text = "Введите адрес помещения:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(257, 18);
            label1.TabIndex = 0;
            label1.Text = "Введите наименование помещения:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(addRoomButton);
            panel2.Location = new Point(14, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(685, 54);
            panel2.TabIndex = 1;
            // 
            // addRoomButton
            // 
            addRoomButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addRoomButton.Location = new Point(0, 0);
            addRoomButton.Name = "addRoomButton";
            addRoomButton.Size = new Size(685, 54);
            addRoomButton.TabIndex = 0;
            addRoomButton.Text = "Добавить помещение";
            addRoomButton.UseVisualStyleBackColor = true;
            addRoomButton.Click += addRoomButton_Click;
            // 
            // AddRoomForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(712, 259);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MinimumSize = new Size(730, 303);
            Name = "AddRoomForm";
            Text = "Добавить помещение";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox RoomPersonNameTextBox;
        private TextBox RoomAdressTextBox;
        private TextBox RoomNameTextBox;
        private Panel panel2;
        private Button addRoomButton;
    }
}