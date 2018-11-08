namespace DB
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabs = new System.Windows.Forms.TabControl();
            this.storehouseTab = new System.Windows.Forms.TabPage();
            this.buttonSelectRow = new System.Windows.Forms.Button();
            this.flowLayoutPanelRowCount = new System.Windows.Forms.FlowLayoutPanel();
            this.labelRowCount = new System.Windows.Forms.Label();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.buttonSearchClear = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewStorehouse = new System.Windows.Forms.DataGridView();
            this.storehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoPartsDataSet = new DB.AutoPartsDataSet();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboboxSearchBy = new System.Windows.Forms.ComboBox();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.partsTab = new System.Windows.Forms.TabPage();
            this.providersTab = new System.Windows.Forms.TabPage();
            this.pricehistoryTab = new System.Windows.Forms.TabPage();
            this.autoPartsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storehouseTableAdapter = new DB.AutoPartsDataSetTableAdapters.storehouseTableAdapter();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providersTableAdapter = new DB.AutoPartsDataSetTableAdapters.providersTableAdapter();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter = new DB.AutoPartsDataSetTableAdapters.partsTableAdapter();
            this.dealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dealsTableAdapter = new DB.AutoPartsDataSetTableAdapters.dealsTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.производительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаЗакупкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗакупкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabs.SuspendLayout();
            this.storehouseTab.SuspendLayout();
            this.flowLayoutPanelRowCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabs.Controls.Add(this.storehouseTab);
            this.tabs.Controls.Add(this.partsTab);
            this.tabs.Controls.Add(this.providersTab);
            this.tabs.Controls.Add(this.pricehistoryTab);
            this.tabs.Location = new System.Drawing.Point(-3, 1);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(805, 452);
            this.tabs.TabIndex = 0;
            // 
            // storehouseTab
            // 
            this.storehouseTab.Controls.Add(this.buttonSelectRow);
            this.storehouseTab.Controls.Add(this.flowLayoutPanelRowCount);
            this.storehouseTab.Controls.Add(this.buttonRequest);
            this.storehouseTab.Controls.Add(this.buttonSearchClear);
            this.storehouseTab.Controls.Add(this.textBoxSearch);
            this.storehouseTab.Controls.Add(this.dataGridViewStorehouse);
            this.storehouseTab.Controls.Add(this.buttonDelete);
            this.storehouseTab.Controls.Add(this.buttonAdd);
            this.storehouseTab.Controls.Add(this.button2);
            this.storehouseTab.Controls.Add(this.button1);
            this.storehouseTab.Controls.Add(this.comboboxSearchBy);
            this.storehouseTab.Controls.Add(this.buttonClean);
            this.storehouseTab.Controls.Add(this.buttonRefresh);
            this.storehouseTab.Location = new System.Drawing.Point(4, 25);
            this.storehouseTab.Name = "storehouseTab";
            this.storehouseTab.Padding = new System.Windows.Forms.Padding(3);
            this.storehouseTab.Size = new System.Drawing.Size(797, 423);
            this.storehouseTab.TabIndex = 0;
            this.storehouseTab.Text = "Склад";
            this.storehouseTab.UseVisualStyleBackColor = true;
            // 
            // buttonSelectRow
            // 
            this.buttonSelectRow.Location = new System.Drawing.Point(343, 40);
            this.buttonSelectRow.Name = "buttonSelectRow";
            this.buttonSelectRow.Size = new System.Drawing.Size(109, 28);
            this.buttonSelectRow.TabIndex = 13;
            this.buttonSelectRow.Text = "Выделить строку";
            this.buttonSelectRow.UseVisualStyleBackColor = true;
            this.buttonSelectRow.Click += new System.EventHandler(this.buttonSelectRow_Click);
            // 
            // flowLayoutPanelRowCount
            // 
            this.flowLayoutPanelRowCount.Controls.Add(this.labelRowCount);
            this.flowLayoutPanelRowCount.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelRowCount.Location = new System.Drawing.Point(566, 401);
            this.flowLayoutPanelRowCount.Name = "flowLayoutPanelRowCount";
            this.flowLayoutPanelRowCount.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.flowLayoutPanelRowCount.Size = new System.Drawing.Size(231, 22);
            this.flowLayoutPanelRowCount.TabIndex = 12;
            // 
            // labelRowCount
            // 
            this.labelRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRowCount.AutoSize = true;
            this.labelRowCount.Location = new System.Drawing.Point(107, 4);
            this.labelRowCount.Name = "labelRowCount";
            this.labelRowCount.Size = new System.Drawing.Size(117, 13);
            this.labelRowCount.TabIndex = 11;
            this.labelRowCount.Text = "Количество записей: ";
            this.labelRowCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonRequest
            // 
            this.buttonRequest.Image = ((System.Drawing.Image)(resources.GetObject("buttonRequest.Image")));
            this.buttonRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequest.Location = new System.Drawing.Point(497, 40);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRequest.Size = new System.Drawing.Size(110, 28);
            this.buttonRequest.TabIndex = 10;
            this.buttonRequest.Text = "Ручной запрос";
            this.buttonRequest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRequest.UseVisualStyleBackColor = true;
            // 
            // buttonSearchClear
            // 
            this.buttonSearchClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchClear.Image")));
            this.buttonSearchClear.Location = new System.Drawing.Point(769, 10);
            this.buttonSearchClear.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchClear.Name = "buttonSearchClear";
            this.buttonSearchClear.Size = new System.Drawing.Size(22, 22);
            this.buttonSearchClear.TabIndex = 9;
            this.buttonSearchClear.UseVisualStyleBackColor = true;
            this.buttonSearchClear.Click += new System.EventHandler(this.buttonSearchClear_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSearch.Location = new System.Drawing.Point(619, 11);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearch.MaxLength = 255;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(150, 20);
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.Text = "Поиск🔍";
            this.textBoxSearch.WordWrap = false;
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // dataGridViewStorehouse
            // 
            this.dataGridViewStorehouse.AllowUserToAddRows = false;
            this.dataGridViewStorehouse.AllowUserToDeleteRows = false;
            this.dataGridViewStorehouse.AutoGenerateColumns = false;
            this.dataGridViewStorehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStorehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.названиеDataGridViewTextBoxColumn,
            this.кодDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.производительDataGridViewTextBoxColumn,
            this.ценаЗакупкиDataGridViewTextBoxColumn,
            this.датаЗакупкиDataGridViewTextBoxColumn,
            this.поставщикDataGridViewTextBoxColumn});
            this.dataGridViewStorehouse.DataSource = this.storehouseBindingSource;
            this.dataGridViewStorehouse.Location = new System.Drawing.Point(0, 74);
            this.dataGridViewStorehouse.Name = "dataGridViewStorehouse";
            this.dataGridViewStorehouse.ReadOnly = true;
            this.dataGridViewStorehouse.Size = new System.Drawing.Size(797, 327);
            this.dataGridViewStorehouse.TabIndex = 7;
            // 
            // storehouseBindingSource
            // 
            this.storehouseBindingSource.AllowNew = false;
            this.storehouseBindingSource.DataMember = "storehouse";
            this.storehouseBindingSource.DataSource = this.autoPartsDataSet;
            // 
            // autoPartsDataSet
            // 
            this.autoPartsDataSet.DataSetName = "AutoPartsDataSet";
            this.autoPartsDataSet.EnforceConstraints = false;
            this.autoPartsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(712, 40);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Padding = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Size = new System.Drawing.Size(79, 28);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(619, 40);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Padding = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Size = new System.Drawing.Size(87, 28);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(159, 40);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(2);
            this.button2.Size = new System.Drawing.Size(147, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Показать историю цен";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(6, 40);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2);
            this.button1.Size = new System.Drawing.Size(147, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Перейти к поставщику";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboboxSearchBy
            // 
            this.comboboxSearchBy.FormattingEnabled = true;
            this.comboboxSearchBy.ItemHeight = 13;
            this.comboboxSearchBy.Items.AddRange(new object[] {
            "Все",
            "id",
            "Название",
            "Код",
            "Цена",
            "Количество",
            "Производитель",
            "Цена закупки",
            "Дата закупки",
            "Поставщик"});
            this.comboboxSearchBy.Location = new System.Drawing.Point(526, 11);
            this.comboboxSearchBy.Name = "comboboxSearchBy";
            this.comboboxSearchBy.Size = new System.Drawing.Size(81, 21);
            this.comboboxSearchBy.TabIndex = 2;
            this.comboboxSearchBy.Text = "Все";
            this.comboboxSearchBy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxSearchBy_KeyDown);
            // 
            // buttonClean
            // 
            this.buttonClean.Image = ((System.Drawing.Image)(resources.GetObject("buttonClean.Image")));
            this.buttonClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClean.Location = new System.Drawing.Point(99, 6);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Padding = new System.Windows.Forms.Padding(2);
            this.buttonClean.Size = new System.Drawing.Size(86, 28);
            this.buttonClean.TabIndex = 1;
            this.buttonClean.Text = "Очистить";
            this.buttonClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(6, 6);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Size = new System.Drawing.Size(87, 28);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // partsTab
            // 
            this.partsTab.Location = new System.Drawing.Point(4, 25);
            this.partsTab.Name = "partsTab";
            this.partsTab.Padding = new System.Windows.Forms.Padding(3);
            this.partsTab.Size = new System.Drawing.Size(797, 423);
            this.partsTab.TabIndex = 1;
            this.partsTab.Text = "Детали";
            this.partsTab.UseVisualStyleBackColor = true;
            // 
            // providersTab
            // 
            this.providersTab.Location = new System.Drawing.Point(4, 25);
            this.providersTab.Name = "providersTab";
            this.providersTab.Padding = new System.Windows.Forms.Padding(3);
            this.providersTab.Size = new System.Drawing.Size(797, 423);
            this.providersTab.TabIndex = 2;
            this.providersTab.Text = "Поставщики";
            this.providersTab.UseVisualStyleBackColor = true;
            // 
            // pricehistoryTab
            // 
            this.pricehistoryTab.Location = new System.Drawing.Point(4, 25);
            this.pricehistoryTab.Name = "pricehistoryTab";
            this.pricehistoryTab.Size = new System.Drawing.Size(797, 423);
            this.pricehistoryTab.TabIndex = 3;
            this.pricehistoryTab.Text = "История цен";
            this.pricehistoryTab.UseVisualStyleBackColor = true;
            // 
            // autoPartsDataSetBindingSource
            // 
            this.autoPartsDataSetBindingSource.DataSource = this.autoPartsDataSet;
            this.autoPartsDataSetBindingSource.Position = 0;
            // 
            // storehouseTableAdapter
            // 
            this.storehouseTableAdapter.ClearBeforeFill = true;
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "providers";
            this.providersBindingSource.DataSource = this.autoPartsDataSetBindingSource;
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "parts";
            this.partsBindingSource.DataSource = this.autoPartsDataSetBindingSource;
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
            // 
            // dealsBindingSource
            // 
            this.dealsBindingSource.DataMember = "deals";
            this.dealsBindingSource.DataSource = this.autoPartsDataSet;
            // 
            // dealsTableAdapter
            // 
            this.dealsTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.DataPropertyName = "id";
            this.id.Frozen = true;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.Width = 40;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn.Width = 51;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.ReadOnly = true;
            this.количествоDataGridViewTextBoxColumn.Width = 91;
            // 
            // производительDataGridViewTextBoxColumn
            // 
            this.производительDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.производительDataGridViewTextBoxColumn.DataPropertyName = "Производитель";
            this.производительDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.производительDataGridViewTextBoxColumn.Name = "производительDataGridViewTextBoxColumn";
            this.производительDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ценаЗакупкиDataGridViewTextBoxColumn
            // 
            this.ценаЗакупкиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ценаЗакупкиDataGridViewTextBoxColumn.DataPropertyName = "Цена закупки";
            this.ценаЗакупкиDataGridViewTextBoxColumn.HeaderText = "Цена закупки";
            this.ценаЗакупкиDataGridViewTextBoxColumn.Name = "ценаЗакупкиDataGridViewTextBoxColumn";
            this.ценаЗакупкиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаЗакупкиDataGridViewTextBoxColumn
            // 
            this.датаЗакупкиDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаЗакупкиDataGridViewTextBoxColumn.DataPropertyName = "Дата закупки";
            this.датаЗакупкиDataGridViewTextBoxColumn.HeaderText = "Дата закупки";
            this.датаЗакупкиDataGridViewTextBoxColumn.Name = "датаЗакупкиDataGridViewTextBoxColumn";
            this.датаЗакупкиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // поставщикDataGridViewTextBoxColumn
            // 
            this.поставщикDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.поставщикDataGridViewTextBoxColumn.DataPropertyName = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.Name = "поставщикDataGridViewTextBoxColumn";
            this.поставщикDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabs);
            this.Name = "MainForm";
            this.Text = "Запчасти";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabs.ResumeLayout(false);
            this.storehouseTab.ResumeLayout(false);
            this.storehouseTab.PerformLayout();
            this.flowLayoutPanelRowCount.ResumeLayout(false);
            this.flowLayoutPanelRowCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage storehouseTab;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TabPage partsTab;
        private System.Windows.Forms.TabPage providersTab;
        private System.Windows.Forms.TabPage pricehistoryTab;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboboxSearchBy;
        private System.Windows.Forms.DataGridView dataGridViewStorehouse;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearchClear;
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRowCount;
        private System.Windows.Forms.Label labelRowCount;
        private AutoPartsDataSet autoPartsDataSet;
        private System.Windows.Forms.BindingSource storehouseBindingSource;
        private AutoPartsDataSetTableAdapters.storehouseTableAdapter storehouseTableAdapter;
        private System.Windows.Forms.BindingSource autoPartsDataSetBindingSource;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private AutoPartsDataSetTableAdapters.providersTableAdapter providersTableAdapter;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private AutoPartsDataSetTableAdapters.partsTableAdapter partsTableAdapter;
        private System.Windows.Forms.Button buttonSelectRow;
        private System.Windows.Forms.BindingSource dealsBindingSource;
        private AutoPartsDataSetTableAdapters.dealsTableAdapter dealsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn производительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаЗакупкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗакупкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поставщикDataGridViewTextBoxColumn;
    }
}

