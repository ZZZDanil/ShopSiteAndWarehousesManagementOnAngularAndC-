namespace WMS
{
    partial class FormCreateItem
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
            this.TypeField = new System.Windows.Forms.ComboBox();
            this.WarehouseField = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PriceField = new System.Windows.Forms.NumericUpDown();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.WarehouseLabel = new System.Windows.Forms.Label();
            this.AmountField = new System.Windows.Forms.NumericUpDown();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.SendNewItem = new System.Windows.Forms.Button();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.AboutField = new System.Windows.Forms.TextBox();
            this.ChooseImage = new System.Windows.Forms.Button();
            this.LoadImage = new System.Windows.Forms.Button();
            this.LoadedImage = new System.Windows.Forms.PictureBox();
            this.ShelfLifeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ShelfLifeLabel = new System.Windows.Forms.Label();
            this.WeightField = new System.Windows.Forms.NumericUpDown();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightField)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeField
            // 
            this.TypeField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeField.FormattingEnabled = true;
            this.TypeField.Location = new System.Drawing.Point(127, 44);
            this.TypeField.MaximumSize = new System.Drawing.Size(350, 0);
            this.TypeField.MinimumSize = new System.Drawing.Size(200, 0);
            this.TypeField.Name = "TypeField";
            this.TypeField.Size = new System.Drawing.Size(250, 24);
            this.TypeField.TabIndex = 4;
            this.TypeField.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // WarehouseField
            // 
            this.WarehouseField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarehouseField.FormattingEnabled = true;
            this.WarehouseField.Location = new System.Drawing.Point(127, 282);
            this.WarehouseField.MaximumSize = new System.Drawing.Size(350, 0);
            this.WarehouseField.MinimumSize = new System.Drawing.Size(200, 0);
            this.WarehouseField.Name = "WarehouseField";
            this.WarehouseField.Size = new System.Drawing.Size(250, 24);
            this.WarehouseField.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.panel2.Controls.Add(this.PriceField);
            this.panel2.Controls.Add(this.PriceLabel);
            this.panel2.Controls.Add(this.WarehouseField);
            this.panel2.Controls.Add(this.WarehouseLabel);
            this.panel2.Controls.Add(this.AmountField);
            this.panel2.Controls.Add(this.AmountLabel);
            this.panel2.Controls.Add(this.SendNewItem);
            this.panel2.Controls.Add(this.AboutLabel);
            this.panel2.Controls.Add(this.AboutField);
            this.panel2.Controls.Add(this.ChooseImage);
            this.panel2.Controls.Add(this.LoadImage);
            this.panel2.Controls.Add(this.LoadedImage);
            this.panel2.Controls.Add(this.ShelfLifeDateTimePicker);
            this.panel2.Controls.Add(this.ShelfLifeLabel);
            this.panel2.Controls.Add(this.WeightField);
            this.panel2.Controls.Add(this.WeightLabel);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.TypeField);
            this.panel2.Controls.Add(this.TypeLabel);
            this.panel2.Controls.Add(this.NameLabel);
            this.panel2.Controls.Add(this.NameField);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MinimumSize = new System.Drawing.Size(580, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 425);
            this.panel2.TabIndex = 3;
            // 
            // PriceField
            // 
            this.PriceField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceField.Location = new System.Drawing.Point(127, 314);
            this.PriceField.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.PriceField.MaximumSize = new System.Drawing.Size(350, 0);
            this.PriceField.MinimumSize = new System.Drawing.Size(200, 0);
            this.PriceField.Name = "PriceField";
            this.PriceField.Size = new System.Drawing.Size(250, 22);
            this.PriceField.TabIndex = 21;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Location = new System.Drawing.Point(12, 307);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(109, 29);
            this.PriceLabel.TabIndex = 20;
            this.PriceLabel.Text = "Цена";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WarehouseLabel
            // 
            this.WarehouseLabel.Location = new System.Drawing.Point(12, 279);
            this.WarehouseLabel.Name = "WarehouseLabel";
            this.WarehouseLabel.Size = new System.Drawing.Size(109, 29);
            this.WarehouseLabel.TabIndex = 18;
            this.WarehouseLabel.Text = "Склад";
            this.WarehouseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmountField
            // 
            this.AmountField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountField.Location = new System.Drawing.Point(127, 341);
            this.AmountField.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.AmountField.MaximumSize = new System.Drawing.Size(350, 0);
            this.AmountField.MinimumSize = new System.Drawing.Size(200, 0);
            this.AmountField.Name = "AmountField";
            this.AmountField.Size = new System.Drawing.Size(250, 22);
            this.AmountField.TabIndex = 17;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Location = new System.Drawing.Point(12, 336);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(109, 29);
            this.AmountLabel.TabIndex = 16;
            this.AmountLabel.Text = "Количество";
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendNewItem
            // 
            this.SendNewItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SendNewItem.Location = new System.Drawing.Point(383, 313);
            this.SendNewItem.Name = "SendNewItem";
            this.SendNewItem.Size = new System.Drawing.Size(192, 23);
            this.SendNewItem.TabIndex = 15;
            this.SendNewItem.Text = "Отправить";
            this.SendNewItem.UseVisualStyleBackColor = true;
            this.SendNewItem.Click += new System.EventHandler(this.button4_Click);
            // 
            // AboutLabel
            // 
            this.AboutLabel.Location = new System.Drawing.Point(12, 182);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(109, 29);
            this.AboutLabel.TabIndex = 13;
            this.AboutLabel.Text = "Описание";
            this.AboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutField
            // 
            this.AboutField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutField.Location = new System.Drawing.Point(15, 214);
            this.AboutField.Multiline = true;
            this.AboutField.Name = "AboutField";
            this.AboutField.Size = new System.Drawing.Size(560, 62);
            this.AboutField.TabIndex = 14;
            // 
            // ChooseImage
            // 
            this.ChooseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseImage.Location = new System.Drawing.Point(383, 185);
            this.ChooseImage.Name = "ChooseImage";
            this.ChooseImage.Size = new System.Drawing.Size(192, 23);
            this.ChooseImage.TabIndex = 12;
            this.ChooseImage.Text = "Выбрать Изображение";
            this.ChooseImage.UseVisualStyleBackColor = true;
            // 
            // LoadImage
            // 
            this.LoadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadImage.Location = new System.Drawing.Point(383, 156);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(192, 23);
            this.LoadImage.TabIndex = 11;
            this.LoadImage.Text = "Загрузить Изображение";
            this.LoadImage.UseVisualStyleBackColor = true;
            this.LoadImage.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoadedImage
            // 
            this.LoadedImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadedImage.Location = new System.Drawing.Point(383, 12);
            this.LoadedImage.Name = "LoadedImage";
            this.LoadedImage.Size = new System.Drawing.Size(185, 138);
            this.LoadedImage.TabIndex = 10;
            this.LoadedImage.TabStop = false;
            // 
            // ShelfLifeDateTimePicker
            // 
            this.ShelfLifeDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShelfLifeDateTimePicker.Location = new System.Drawing.Point(127, 131);
            this.ShelfLifeDateTimePicker.MaximumSize = new System.Drawing.Size(350, 25);
            this.ShelfLifeDateTimePicker.MinimumSize = new System.Drawing.Size(200, 25);
            this.ShelfLifeDateTimePicker.Name = "ShelfLifeDateTimePicker";
            this.ShelfLifeDateTimePicker.Size = new System.Drawing.Size(250, 25);
            this.ShelfLifeDateTimePicker.TabIndex = 9;
            // 
            // ShelfLifeLabel
            // 
            this.ShelfLifeLabel.Location = new System.Drawing.Point(12, 127);
            this.ShelfLifeLabel.Name = "ShelfLifeLabel";
            this.ShelfLifeLabel.Size = new System.Drawing.Size(109, 29);
            this.ShelfLifeLabel.TabIndex = 8;
            this.ShelfLifeLabel.Text = "Срок Годности";
            this.ShelfLifeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShelfLifeLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // WeightField
            // 
            this.WeightField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightField.Location = new System.Drawing.Point(127, 103);
            this.WeightField.MaximumSize = new System.Drawing.Size(350, 0);
            this.WeightField.MinimumSize = new System.Drawing.Size(200, 0);
            this.WeightField.Name = "WeightField";
            this.WeightField.Size = new System.Drawing.Size(250, 22);
            this.WeightField.TabIndex = 7;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Location = new System.Drawing.Point(12, 98);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(109, 29);
            this.WeightLabel.TabIndex = 6;
            this.WeightLabel.Text = "Вес";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(127, 74);
            this.button1.MaximumSize = new System.Drawing.Size(350, 0);
            this.button1.MinimumSize = new System.Drawing.Size(200, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Окно Редактирования Типов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TypeLabel
            // 
            this.TypeLabel.Location = new System.Drawing.Point(12, 41);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(109, 29);
            this.TypeLabel.TabIndex = 3;
            this.TypeLabel.Text = "Тип";
            this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TypeLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(12, 12);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(109, 29);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Название";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameField
            // 
            this.NameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameField.Location = new System.Drawing.Point(127, 12);
            this.NameField.MaximumSize = new System.Drawing.Size(350, 25);
            this.NameField.MinimumSize = new System.Drawing.Size(200, 25);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(250, 22);
            this.NameField.TabIndex = 2;
            this.NameField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormCreateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(139F, 139F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.ClientSize = new System.Drawing.Size(580, 425);
            this.Controls.Add(this.panel2);
            this.Name = "FormCreateItem";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeightField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown WeightField;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label ShelfLifeLabel;
        private System.Windows.Forms.Button ChooseImage;
        private System.Windows.Forms.Button LoadImage;
        private System.Windows.Forms.PictureBox LoadedImage;
        private System.Windows.Forms.DateTimePicker ShelfLifeDateTimePicker;
        private System.Windows.Forms.Label AboutLabel;
        private System.Windows.Forms.TextBox AboutField;
        private System.Windows.Forms.Label WarehouseLabel;
        private System.Windows.Forms.NumericUpDown AmountField;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button SendNewItem;
        private System.Windows.Forms.NumericUpDown PriceField;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.ComboBox TypeField;
        private System.Windows.Forms.ComboBox WarehouseField;
    }
}