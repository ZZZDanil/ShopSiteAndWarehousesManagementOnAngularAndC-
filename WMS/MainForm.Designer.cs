namespace WMS
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.OOO = new System.Windows.Forms.ToolStripMenuItem();
            this.настроитьПодключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateItem = new System.Windows.Forms.Button();
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.WarehouseManagement = new System.Windows.Forms.Button();
            this.MoveItem = new System.Windows.Forms.Button();
            this.ClosePanel = new System.Windows.Forms.Button();
            this.TopMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.AutoSize = false;
            this.TopMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TopMenu.GripMargin = new System.Windows.Forms.Padding(3);
            this.TopMenu.ImageScalingSize = new System.Drawing.Size(23, 23);
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OOO,
            this.настройкиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(780, 32);
            this.TopMenu.TabIndex = 0;
            this.TopMenu.Text = "TopMenu";
            this.TopMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // OOO
            // 
            this.OOO.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настроитьПодключениеToolStripMenuItem});
            this.OOO.Name = "OOO";
            this.OOO.Size = new System.Drawing.Size(136, 28);
            this.OOO.Text = "Подключение";
            // 
            // настроитьПодключениеToolStripMenuItem
            // 
            this.настроитьПодключениеToolStripMenuItem.Name = "настроитьПодключениеToolStripMenuItem";
            this.настроитьПодключениеToolStripMenuItem.Size = new System.Drawing.Size(304, 32);
            this.настроитьПодключениеToolStripMenuItem.Text = "Настроить Подключение";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стильToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(110, 28);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // стильToolStripMenuItem
            // 
            this.стильToolStripMenuItem.Name = "стильToolStripMenuItem";
            this.стильToolStripMenuItem.Size = new System.Drawing.Size(153, 32);
            this.стильToolStripMenuItem.Text = "Стиль";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(92, 28);
            this.оПрограммеToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(216, 32);
            this.оПрограммеToolStripMenuItem1.Text = "О Программе";
            // 
            // CreateItem
            // 
            this.CreateItem.AutoSize = true;
            this.CreateItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreateItem.Location = new System.Drawing.Point(0, 0);
            this.CreateItem.Margin = new System.Windows.Forms.Padding(0);
            this.CreateItem.MinimumSize = new System.Drawing.Size(60, 0);
            this.CreateItem.Name = "CreateItem";
            this.CreateItem.Size = new System.Drawing.Size(153, 57);
            this.CreateItem.TabIndex = 1;
            this.CreateItem.Text = "Создание Товара";
            this.CreateItem.UseVisualStyleBackColor = true;
            this.CreateItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 32);
            this.MainSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.AutoScroll = true;
            this.MainSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MainSplitContainer.Panel1.Controls.Add(this.ClosePanel);
            this.MainSplitContainer.Panel1.Controls.Add(this.WarehouseManagement);
            this.MainSplitContainer.Panel1.Controls.Add(this.MoveItem);
            this.MainSplitContainer.Panel1.Controls.Add(this.CreateItem);
            this.MainSplitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainSplitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.AutoScroll = true;
            this.MainSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.MainSplitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainSplitContainer.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.MainSplitContainer.Size = new System.Drawing.Size(780, 515);
            this.MainSplitContainer.SplitterDistance = 153;
            this.MainSplitContainer.TabIndex = 2;
            this.MainSplitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // WarehouseManagement
            // 
            this.WarehouseManagement.AutoSize = true;
            this.WarehouseManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.WarehouseManagement.Location = new System.Drawing.Point(0, 114);
            this.WarehouseManagement.Margin = new System.Windows.Forms.Padding(0);
            this.WarehouseManagement.MinimumSize = new System.Drawing.Size(60, 0);
            this.WarehouseManagement.Name = "WarehouseManagement";
            this.WarehouseManagement.Size = new System.Drawing.Size(153, 57);
            this.WarehouseManagement.TabIndex = 3;
            this.WarehouseManagement.Text = "Управление Складом";
            this.WarehouseManagement.UseVisualStyleBackColor = true;
            this.WarehouseManagement.Click += new System.EventHandler(this.WarehouseManagement_Click);
            // 
            // MoveItem
            // 
            this.MoveItem.AutoSize = true;
            this.MoveItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoveItem.Location = new System.Drawing.Point(0, 57);
            this.MoveItem.Margin = new System.Windows.Forms.Padding(0);
            this.MoveItem.MinimumSize = new System.Drawing.Size(60, 0);
            this.MoveItem.Name = "MoveItem";
            this.MoveItem.Size = new System.Drawing.Size(153, 57);
            this.MoveItem.TabIndex = 2;
            this.MoveItem.Text = "Перевоз Товара";
            this.MoveItem.UseVisualStyleBackColor = true;
            this.MoveItem.Click += new System.EventHandler(this.MoveItem_Click);
            // 
            // ClosePanel
            // 
            this.ClosePanel.AutoSize = true;
            this.ClosePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ClosePanel.Location = new System.Drawing.Point(0, 458);
            this.ClosePanel.Margin = new System.Windows.Forms.Padding(0);
            this.ClosePanel.MinimumSize = new System.Drawing.Size(60, 0);
            this.ClosePanel.Name = "ClosePanel";
            this.ClosePanel.Size = new System.Drawing.Size(153, 57);
            this.ClosePanel.TabIndex = 4;
            this.ClosePanel.Text = "Закрыть Вкладку";
            this.ClosePanel.UseVisualStyleBackColor = true;
            this.ClosePanel.Click += new System.EventHandler(this.ClosePanel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(139F, 139F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(780, 547);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.TopMenu);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem OOO;
        private System.Windows.Forms.Button CreateItem;
        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.Button WarehouseManagement;
        private System.Windows.Forms.Button MoveItem;
        private System.Windows.Forms.ToolStripMenuItem настроитьПодключениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem стильToolStripMenuItem;
        private System.Windows.Forms.Button ClosePanel;
    }
}

