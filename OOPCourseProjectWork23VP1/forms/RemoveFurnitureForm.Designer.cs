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
            panel2 = new Panel();
            DeclineDeleteProcessButton = new Button();
            DeleteFurnitureButton = new Button();
            FurnitureDataGridView = new DataGridView();
            IDColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            TypeColumn = new DataGridViewTextBoxColumn();
            MaterialColumn = new DataGridViewTextBoxColumn();
            MadeByColumn = new DataGridViewTextBoxColumn();
            RoomColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            NumbOfItemColumn = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FurnitureDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(DeclineDeleteProcessButton);
            panel2.Controls.Add(DeleteFurnitureButton);
            panel2.Location = new Point(3, 512);
            panel2.Name = "panel2";
            panel2.Size = new Size(1010, 42);
            panel2.TabIndex = 2;
            // 
            // DeclineDeleteProcessButton
            // 
            DeclineDeleteProcessButton.Dock = DockStyle.Left;
            DeclineDeleteProcessButton.Location = new Point(0, 0);
            DeclineDeleteProcessButton.Name = "DeclineDeleteProcessButton";
            DeclineDeleteProcessButton.Size = new Size(185, 42);
            DeclineDeleteProcessButton.TabIndex = 1;
            DeclineDeleteProcessButton.Text = "Отмена";
            DeclineDeleteProcessButton.UseVisualStyleBackColor = true;
            DeclineDeleteProcessButton.Click += DeclineDeleteProcessButton_Click;
            // 
            // DeleteFurnitureButton
            // 
            DeleteFurnitureButton.Dock = DockStyle.Right;
            DeleteFurnitureButton.Location = new Point(804, 0);
            DeleteFurnitureButton.Name = "DeleteFurnitureButton";
            DeleteFurnitureButton.Size = new Size(206, 42);
            DeleteFurnitureButton.TabIndex = 0;
            DeleteFurnitureButton.Text = "Удалить мебель";
            DeleteFurnitureButton.UseVisualStyleBackColor = true;
            // 
            // FurnitureDataGridView
            // 
            FurnitureDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FurnitureDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FurnitureDataGridView.Columns.AddRange(new DataGridViewColumn[] { IDColumn, NameColumn, TypeColumn, MaterialColumn, MadeByColumn, RoomColumn, PriceColumn, NumbOfItemColumn });
            FurnitureDataGridView.Location = new Point(12, 11);
            FurnitureDataGridView.Margin = new Padding(3, 2, 3, 2);
            FurnitureDataGridView.Name = "FurnitureDataGridView";
            FurnitureDataGridView.RowHeadersWidth = 51;
            FurnitureDataGridView.RowTemplate.Height = 24;
            FurnitureDataGridView.Size = new Size(1008, 447);
            FurnitureDataGridView.TabIndex = 4;
            // 
            // IDColumn
            // 
            IDColumn.HeaderText = "ID";
            IDColumn.MinimumWidth = 6;
            IDColumn.Name = "IDColumn";
            IDColumn.Width = 75;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Название";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.Width = 125;
            // 
            // TypeColumn
            // 
            TypeColumn.HeaderText = "Тип";
            TypeColumn.MinimumWidth = 6;
            TypeColumn.Name = "TypeColumn";
            TypeColumn.Width = 125;
            // 
            // MaterialColumn
            // 
            MaterialColumn.HeaderText = "Материал";
            MaterialColumn.MinimumWidth = 6;
            MaterialColumn.Name = "MaterialColumn";
            MaterialColumn.Width = 125;
            // 
            // MadeByColumn
            // 
            MadeByColumn.HeaderText = "Страна - производитель";
            MadeByColumn.MinimumWidth = 6;
            MadeByColumn.Name = "MadeByColumn";
            MadeByColumn.Width = 125;
            // 
            // RoomColumn
            // 
            RoomColumn.HeaderText = "ID Помещения";
            RoomColumn.MinimumWidth = 6;
            RoomColumn.Name = "RoomColumn";
            RoomColumn.Width = 125;
            // 
            // PriceColumn
            // 
            PriceColumn.HeaderText = "Цена";
            PriceColumn.MinimumWidth = 6;
            PriceColumn.Name = "PriceColumn";
            PriceColumn.Width = 125;
            // 
            // NumbOfItemColumn
            // 
            NumbOfItemColumn.HeaderText = "Количество на складе";
            NumbOfItemColumn.MinimumWidth = 6;
            NumbOfItemColumn.Name = "NumbOfItemColumn";
            NumbOfItemColumn.Width = 125;
            // 
            // RemoveFurnitureForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1032, 561);
            Controls.Add(FurnitureDataGridView);
            Controls.Add(panel2);
            Font = new Font("Microsoft Sans Serif", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MinimumSize = new Size(582, 208);
            Name = "RemoveFurnitureForm";
            Text = "Удаление мебели";
            Load += RemoveFurnitureForm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FurnitureDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button DeleteFurnitureButton;
        private Button DeclineDeleteProcessButton;
        private DataGridView FurnitureDataGridView;
        private DataGridViewTextBoxColumn IDColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn TypeColumn;
        private DataGridViewTextBoxColumn MaterialColumn;
        private DataGridViewTextBoxColumn MadeByColumn;
        private DataGridViewTextBoxColumn RoomColumn;
        private DataGridViewTextBoxColumn PriceColumn;
        private DataGridViewTextBoxColumn NumbOfItemColumn;
    }
}