﻿namespace DB
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
            this.buttonSelectRowStorehouse = new System.Windows.Forms.Button();
            this.flowLayoutPanelRowCountStorehouse = new System.Windows.Forms.FlowLayoutPanel();
            this.labelRowCountStorehouse = new System.Windows.Forms.Label();
            this.buttonRequestStorehouse = new System.Windows.Forms.Button();
            this.buttonSearchClearStorehouse = new System.Windows.Forms.Button();
            this.textBoxSearchStorehouse = new System.Windows.Forms.TextBox();
            this.dataGridViewStorehouse = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.производительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаЗакупкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗакупкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoPartsDataSet = new DB.AutoPartsDataSet();
            this.buttonDeleteStorehouse = new System.Windows.Forms.Button();
            this.buttonAddStorehouse = new System.Windows.Forms.Button();
            this.buttonPricehistoryStorehouse = new System.Windows.Forms.Button();
            this.buttonToProvidersStorehouse = new System.Windows.Forms.Button();
            this.comboboxSearchByStorehouse = new System.Windows.Forms.ComboBox();
            this.buttonCleanStorehouse = new System.Windows.Forms.Button();
            this.buttonRefreshStorehouse = new System.Windows.Forms.Button();
            this.partsTab = new System.Windows.Forms.TabPage();
            this.buttonSelectRowParts = new System.Windows.Forms.Button();
            this.flowLayoutPanelParts = new System.Windows.Forms.FlowLayoutPanel();
            this.labelRowCountParts = new System.Windows.Forms.Label();
            this.buttonRequestParts = new System.Windows.Forms.Button();
            this.buttonSearchCleanParts = new System.Windows.Forms.Button();
            this.textBoxSearchParts = new System.Windows.Forms.TextBox();
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoPartsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDeleteParts = new System.Windows.Forms.Button();
            this.buttonAddParts = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.comboboxSearchByParts = new System.Windows.Forms.ComboBox();
            this.buttonCleanParts = new System.Windows.Forms.Button();
            this.buttonRefreshParts = new System.Windows.Forms.Button();
            this.providersTab = new System.Windows.Forms.TabPage();
            this.buttonSelectRowProviders = new System.Windows.Forms.Button();
            this.flowLayoutPanelProviders = new System.Windows.Forms.FlowLayoutPanel();
            this.labelRowCountProviders = new System.Windows.Forms.Label();
            this.buttonRequestProviders = new System.Windows.Forms.Button();
            this.buttonSearchCleanProviders = new System.Windows.Forms.Button();
            this.textBoxSearchProviders = new System.Windows.Forms.TextBox();
            this.dataGridViewProviders = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provideraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDeleteProviders = new System.Windows.Forms.Button();
            this.buttonAddProviders = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboboxSearchByProviders = new System.Windows.Forms.ComboBox();
            this.buttonCleanProviders = new System.Windows.Forms.Button();
            this.buttonRefreshProviders = new System.Windows.Forms.Button();
            this.pricehistoryTab = new System.Windows.Forms.TabPage();
            this.buttonSelectRowPriceview = new System.Windows.Forms.Button();
            this.flowLayoutPanelPriceview = new System.Windows.Forms.FlowLayoutPanel();
            this.labelRowCountPriceview = new System.Windows.Forms.Label();
            this.buttonRequestPriceview = new System.Windows.Forms.Button();
            this.buttonSearchCleanPriceview = new System.Windows.Forms.Button();
            this.textBoxSearchPriceview = new System.Windows.Forms.TextBox();
            this.dataGridViewPriceview = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодДеталиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.текущаяЦенаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стараяЦенаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.действовалаДоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDeletePriceveiw = new System.Windows.Forms.Button();
            this.buttonAddPriceview = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.comboboxSearchByPriceview = new System.Windows.Forms.ComboBox();
            this.buttonCleanPriceview = new System.Windows.Forms.Button();
            this.buttonRefreshPriceview = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.storehouseTableAdapter = new DB.AutoPartsDataSetTableAdapters.storehouseTableAdapter();
            this.providersTableAdapter = new DB.AutoPartsDataSetTableAdapters.providersTableAdapter();
            this.partsTableAdapter = new DB.AutoPartsDataSetTableAdapters.partsTableAdapter();
            this.dealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dealsTableAdapter = new DB.AutoPartsDataSetTableAdapters.dealsTableAdapter();
            this.bridgeproviderspartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bridge_providers_partsTableAdapter = new DB.AutoPartsDataSetTableAdapters.bridge_providers_partsTableAdapter();
            this.priceviewTableAdapter = new DB.AutoPartsDataSetTableAdapters.priceviewTableAdapter();
            this.tabs.SuspendLayout();
            this.storehouseTab.SuspendLayout();
            this.flowLayoutPanelRowCountStorehouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSet)).BeginInit();
            this.partsTab.SuspendLayout();
            this.flowLayoutPanelParts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSetBindingSource)).BeginInit();
            this.providersTab.SuspendLayout();
            this.flowLayoutPanelProviders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            this.pricehistoryTab.SuspendLayout();
            this.flowLayoutPanelPriceview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriceview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bridgeproviderspartsBindingSource)).BeginInit();
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
            this.storehouseTab.Controls.Add(this.buttonSelectRowStorehouse);
            this.storehouseTab.Controls.Add(this.flowLayoutPanelRowCountStorehouse);
            this.storehouseTab.Controls.Add(this.buttonRequestStorehouse);
            this.storehouseTab.Controls.Add(this.buttonSearchClearStorehouse);
            this.storehouseTab.Controls.Add(this.textBoxSearchStorehouse);
            this.storehouseTab.Controls.Add(this.dataGridViewStorehouse);
            this.storehouseTab.Controls.Add(this.buttonDeleteStorehouse);
            this.storehouseTab.Controls.Add(this.buttonAddStorehouse);
            this.storehouseTab.Controls.Add(this.buttonPricehistoryStorehouse);
            this.storehouseTab.Controls.Add(this.buttonToProvidersStorehouse);
            this.storehouseTab.Controls.Add(this.comboboxSearchByStorehouse);
            this.storehouseTab.Controls.Add(this.buttonCleanStorehouse);
            this.storehouseTab.Controls.Add(this.buttonRefreshStorehouse);
            this.storehouseTab.Location = new System.Drawing.Point(4, 25);
            this.storehouseTab.Name = "storehouseTab";
            this.storehouseTab.Padding = new System.Windows.Forms.Padding(3);
            this.storehouseTab.Size = new System.Drawing.Size(797, 423);
            this.storehouseTab.TabIndex = 0;
            this.storehouseTab.Text = "Склад";
            this.storehouseTab.UseVisualStyleBackColor = true;
            // 
            // buttonSelectRowStorehouse
            // 
            this.buttonSelectRowStorehouse.Location = new System.Drawing.Point(343, 40);
            this.buttonSelectRowStorehouse.Name = "buttonSelectRowStorehouse";
            this.buttonSelectRowStorehouse.Size = new System.Drawing.Size(109, 28);
            this.buttonSelectRowStorehouse.TabIndex = 13;
            this.buttonSelectRowStorehouse.Text = "Выделить строку";
            this.buttonSelectRowStorehouse.UseVisualStyleBackColor = true;
            this.buttonSelectRowStorehouse.Click += new System.EventHandler(this.buttonSelectRowStorehouse_Click);
            // 
            // flowLayoutPanelRowCountStorehouse
            // 
            this.flowLayoutPanelRowCountStorehouse.Controls.Add(this.labelRowCountStorehouse);
            this.flowLayoutPanelRowCountStorehouse.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelRowCountStorehouse.Location = new System.Drawing.Point(566, 401);
            this.flowLayoutPanelRowCountStorehouse.Name = "flowLayoutPanelRowCountStorehouse";
            this.flowLayoutPanelRowCountStorehouse.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.flowLayoutPanelRowCountStorehouse.Size = new System.Drawing.Size(231, 22);
            this.flowLayoutPanelRowCountStorehouse.TabIndex = 12;
            // 
            // labelRowCountStorehouse
            // 
            this.labelRowCountStorehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRowCountStorehouse.AutoSize = true;
            this.labelRowCountStorehouse.Location = new System.Drawing.Point(107, 4);
            this.labelRowCountStorehouse.Name = "labelRowCountStorehouse";
            this.labelRowCountStorehouse.Size = new System.Drawing.Size(117, 13);
            this.labelRowCountStorehouse.TabIndex = 11;
            this.labelRowCountStorehouse.Text = "Количество записей: ";
            this.labelRowCountStorehouse.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonRequestStorehouse
            // 
            this.buttonRequestStorehouse.Image = ((System.Drawing.Image)(resources.GetObject("buttonRequestStorehouse.Image")));
            this.buttonRequestStorehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequestStorehouse.Location = new System.Drawing.Point(497, 40);
            this.buttonRequestStorehouse.Name = "buttonRequestStorehouse";
            this.buttonRequestStorehouse.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRequestStorehouse.Size = new System.Drawing.Size(110, 28);
            this.buttonRequestStorehouse.TabIndex = 10;
            this.buttonRequestStorehouse.Text = "Ручной запрос";
            this.buttonRequestStorehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.buttonRequestStorehouse, "Создать ручной SQL-запрос");
            this.buttonRequestStorehouse.UseVisualStyleBackColor = true;
            this.buttonRequestStorehouse.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // buttonSearchClearStorehouse
            // 
            this.buttonSearchClearStorehouse.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchClearStorehouse.Image")));
            this.buttonSearchClearStorehouse.Location = new System.Drawing.Point(769, 10);
            this.buttonSearchClearStorehouse.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchClearStorehouse.Name = "buttonSearchClearStorehouse";
            this.buttonSearchClearStorehouse.Size = new System.Drawing.Size(22, 22);
            this.buttonSearchClearStorehouse.TabIndex = 9;
            this.buttonSearchClearStorehouse.UseVisualStyleBackColor = true;
            this.buttonSearchClearStorehouse.Click += new System.EventHandler(this.buttonSearchClearStorehouse_Click);
            // 
            // textBoxSearchStorehouse
            // 
            this.textBoxSearchStorehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchStorehouse.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSearchStorehouse.Location = new System.Drawing.Point(619, 11);
            this.textBoxSearchStorehouse.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearchStorehouse.MaxLength = 255;
            this.textBoxSearchStorehouse.Name = "textBoxSearchStorehouse";
            this.textBoxSearchStorehouse.Size = new System.Drawing.Size(150, 20);
            this.textBoxSearchStorehouse.TabIndex = 8;
            this.textBoxSearchStorehouse.Text = "Поиск🔍";
            this.textBoxSearchStorehouse.WordWrap = false;
            this.textBoxSearchStorehouse.Enter += new System.EventHandler(this.textBoxSearchStorehouse_Enter);
            this.textBoxSearchStorehouse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchStorehouse_KeyDown);
            this.textBoxSearchStorehouse.Leave += new System.EventHandler(this.textBoxSearchStorehouse_Leave);
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
            // buttonDeleteStorehouse
            // 
            this.buttonDeleteStorehouse.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteStorehouse.Image")));
            this.buttonDeleteStorehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteStorehouse.Location = new System.Drawing.Point(712, 40);
            this.buttonDeleteStorehouse.Name = "buttonDeleteStorehouse";
            this.buttonDeleteStorehouse.Padding = new System.Windows.Forms.Padding(2);
            this.buttonDeleteStorehouse.Size = new System.Drawing.Size(79, 28);
            this.buttonDeleteStorehouse.TabIndex = 6;
            this.buttonDeleteStorehouse.Text = "Удалить";
            this.buttonDeleteStorehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteStorehouse.UseVisualStyleBackColor = true;
            this.buttonDeleteStorehouse.Click += new System.EventHandler(this.buttonDeleteStorehouse_Click);
            // 
            // buttonAddStorehouse
            // 
            this.buttonAddStorehouse.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddStorehouse.Image")));
            this.buttonAddStorehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddStorehouse.Location = new System.Drawing.Point(619, 40);
            this.buttonAddStorehouse.Name = "buttonAddStorehouse";
            this.buttonAddStorehouse.Padding = new System.Windows.Forms.Padding(2);
            this.buttonAddStorehouse.Size = new System.Drawing.Size(87, 28);
            this.buttonAddStorehouse.TabIndex = 5;
            this.buttonAddStorehouse.Text = "Добавить";
            this.buttonAddStorehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddStorehouse.UseVisualStyleBackColor = true;
            this.buttonAddStorehouse.Click += new System.EventHandler(this.buttonAddStorehouse_Click);
            // 
            // buttonPricehistoryStorehouse
            // 
            this.buttonPricehistoryStorehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPricehistoryStorehouse.Location = new System.Drawing.Point(159, 40);
            this.buttonPricehistoryStorehouse.Name = "buttonPricehistoryStorehouse";
            this.buttonPricehistoryStorehouse.Padding = new System.Windows.Forms.Padding(2);
            this.buttonPricehistoryStorehouse.Size = new System.Drawing.Size(147, 28);
            this.buttonPricehistoryStorehouse.TabIndex = 4;
            this.buttonPricehistoryStorehouse.Text = "Показать историю цен";
            this.buttonPricehistoryStorehouse.UseVisualStyleBackColor = true;
            this.buttonPricehistoryStorehouse.Click += new System.EventHandler(this.buttonPricehistoryStorehouse_Click);
            // 
            // buttonToProvidersStorehouse
            // 
            this.buttonToProvidersStorehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToProvidersStorehouse.Location = new System.Drawing.Point(6, 40);
            this.buttonToProvidersStorehouse.Name = "buttonToProvidersStorehouse";
            this.buttonToProvidersStorehouse.Padding = new System.Windows.Forms.Padding(2);
            this.buttonToProvidersStorehouse.Size = new System.Drawing.Size(147, 28);
            this.buttonToProvidersStorehouse.TabIndex = 3;
            this.buttonToProvidersStorehouse.Text = "Перейти к поставщику";
            this.buttonToProvidersStorehouse.UseVisualStyleBackColor = true;
            this.buttonToProvidersStorehouse.Click += new System.EventHandler(this.buttonToProvidersStorehouse_Click);
            // 
            // comboboxSearchByStorehouse
            // 
            this.comboboxSearchByStorehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxSearchByStorehouse.FormattingEnabled = true;
            this.comboboxSearchByStorehouse.ItemHeight = 13;
            this.comboboxSearchByStorehouse.Items.AddRange(new object[] {
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
            this.comboboxSearchByStorehouse.Location = new System.Drawing.Point(526, 11);
            this.comboboxSearchByStorehouse.Name = "comboboxSearchByStorehouse";
            this.comboboxSearchByStorehouse.Size = new System.Drawing.Size(81, 21);
            this.comboboxSearchByStorehouse.TabIndex = 2;
            this.comboboxSearchByStorehouse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxSearchByStorehouse_KeyDown);
            // 
            // buttonCleanStorehouse
            // 
            this.buttonCleanStorehouse.Image = ((System.Drawing.Image)(resources.GetObject("buttonCleanStorehouse.Image")));
            this.buttonCleanStorehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCleanStorehouse.Location = new System.Drawing.Point(99, 6);
            this.buttonCleanStorehouse.Name = "buttonCleanStorehouse";
            this.buttonCleanStorehouse.Padding = new System.Windows.Forms.Padding(2);
            this.buttonCleanStorehouse.Size = new System.Drawing.Size(86, 28);
            this.buttonCleanStorehouse.TabIndex = 1;
            this.buttonCleanStorehouse.Text = "Очистить";
            this.buttonCleanStorehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.buttonCleanStorehouse, "Сбросить все фильтры для таблицы");
            this.buttonCleanStorehouse.UseVisualStyleBackColor = true;
            this.buttonCleanStorehouse.Click += new System.EventHandler(this.buttonCleanStorehouse_Click);
            // 
            // buttonRefreshStorehouse
            // 
            this.buttonRefreshStorehouse.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefreshStorehouse.Image")));
            this.buttonRefreshStorehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefreshStorehouse.Location = new System.Drawing.Point(6, 6);
            this.buttonRefreshStorehouse.Name = "buttonRefreshStorehouse";
            this.buttonRefreshStorehouse.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRefreshStorehouse.Size = new System.Drawing.Size(87, 28);
            this.buttonRefreshStorehouse.TabIndex = 0;
            this.buttonRefreshStorehouse.Text = "Обновить";
            this.buttonRefreshStorehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefreshStorehouse.UseVisualStyleBackColor = true;
            this.buttonRefreshStorehouse.Click += new System.EventHandler(this.buttonRefreshStorehouse_Click);
            // 
            // partsTab
            // 
            this.partsTab.Controls.Add(this.buttonSelectRowParts);
            this.partsTab.Controls.Add(this.flowLayoutPanelParts);
            this.partsTab.Controls.Add(this.buttonRequestParts);
            this.partsTab.Controls.Add(this.buttonSearchCleanParts);
            this.partsTab.Controls.Add(this.textBoxSearchParts);
            this.partsTab.Controls.Add(this.dataGridViewParts);
            this.partsTab.Controls.Add(this.buttonDeleteParts);
            this.partsTab.Controls.Add(this.buttonAddParts);
            this.partsTab.Controls.Add(this.button8);
            this.partsTab.Controls.Add(this.button9);
            this.partsTab.Controls.Add(this.comboboxSearchByParts);
            this.partsTab.Controls.Add(this.buttonCleanParts);
            this.partsTab.Controls.Add(this.buttonRefreshParts);
            this.partsTab.Location = new System.Drawing.Point(4, 25);
            this.partsTab.Name = "partsTab";
            this.partsTab.Padding = new System.Windows.Forms.Padding(3);
            this.partsTab.Size = new System.Drawing.Size(797, 423);
            this.partsTab.TabIndex = 1;
            this.partsTab.Text = "Детали";
            this.partsTab.UseVisualStyleBackColor = true;
            // 
            // buttonSelectRowParts
            // 
            this.buttonSelectRowParts.Location = new System.Drawing.Point(343, 40);
            this.buttonSelectRowParts.Name = "buttonSelectRowParts";
            this.buttonSelectRowParts.Size = new System.Drawing.Size(109, 28);
            this.buttonSelectRowParts.TabIndex = 26;
            this.buttonSelectRowParts.Text = "Выделить строку";
            this.buttonSelectRowParts.UseVisualStyleBackColor = true;
            this.buttonSelectRowParts.Click += new System.EventHandler(this.buttonSelectRowParts_Click);
            // 
            // flowLayoutPanelParts
            // 
            this.flowLayoutPanelParts.Controls.Add(this.labelRowCountParts);
            this.flowLayoutPanelParts.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelParts.Location = new System.Drawing.Point(566, 401);
            this.flowLayoutPanelParts.Name = "flowLayoutPanelParts";
            this.flowLayoutPanelParts.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.flowLayoutPanelParts.Size = new System.Drawing.Size(231, 22);
            this.flowLayoutPanelParts.TabIndex = 25;
            // 
            // labelRowCountParts
            // 
            this.labelRowCountParts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRowCountParts.AutoSize = true;
            this.labelRowCountParts.Location = new System.Drawing.Point(107, 4);
            this.labelRowCountParts.Name = "labelRowCountParts";
            this.labelRowCountParts.Size = new System.Drawing.Size(117, 13);
            this.labelRowCountParts.TabIndex = 11;
            this.labelRowCountParts.Text = "Количество записей: ";
            this.labelRowCountParts.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonRequestParts
            // 
            this.buttonRequestParts.Image = ((System.Drawing.Image)(resources.GetObject("buttonRequestParts.Image")));
            this.buttonRequestParts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequestParts.Location = new System.Drawing.Point(497, 40);
            this.buttonRequestParts.Name = "buttonRequestParts";
            this.buttonRequestParts.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRequestParts.Size = new System.Drawing.Size(110, 28);
            this.buttonRequestParts.TabIndex = 24;
            this.buttonRequestParts.Text = "Ручной запрос";
            this.buttonRequestParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRequestParts.UseVisualStyleBackColor = true;
            this.buttonRequestParts.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // buttonSearchCleanParts
            // 
            this.buttonSearchCleanParts.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchCleanParts.Image")));
            this.buttonSearchCleanParts.Location = new System.Drawing.Point(769, 10);
            this.buttonSearchCleanParts.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchCleanParts.Name = "buttonSearchCleanParts";
            this.buttonSearchCleanParts.Size = new System.Drawing.Size(22, 22);
            this.buttonSearchCleanParts.TabIndex = 23;
            this.buttonSearchCleanParts.UseVisualStyleBackColor = true;
            this.buttonSearchCleanParts.Click += new System.EventHandler(this.buttonSearchClearParts_Click);
            // 
            // textBoxSearchParts
            // 
            this.textBoxSearchParts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchParts.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSearchParts.Location = new System.Drawing.Point(619, 11);
            this.textBoxSearchParts.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearchParts.MaxLength = 255;
            this.textBoxSearchParts.Name = "textBoxSearchParts";
            this.textBoxSearchParts.Size = new System.Drawing.Size(150, 20);
            this.textBoxSearchParts.TabIndex = 22;
            this.textBoxSearchParts.Text = "Поиск🔍";
            this.textBoxSearchParts.WordWrap = false;
            this.textBoxSearchParts.Enter += new System.EventHandler(this.textBoxSearchParts_Enter);
            this.textBoxSearchParts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchParts_KeyDown);
            this.textBoxSearchParts.Leave += new System.EventHandler(this.textBoxSearchParts_Leave);
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.AllowUserToAddRows = false;
            this.dataGridViewParts.AllowUserToDeleteRows = false;
            this.dataGridViewParts.AutoGenerateColumns = false;
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.articleDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewParts.DataSource = this.partsBindingSource;
            this.dataGridViewParts.Location = new System.Drawing.Point(0, 74);
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.ReadOnly = true;
            this.dataGridViewParts.Size = new System.Drawing.Size(797, 327);
            this.dataGridViewParts.TabIndex = 21;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Код";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.ReadOnly = true;
            this.articleDataGridViewTextBoxColumn.Width = 51;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "parts";
            this.partsBindingSource.DataSource = this.autoPartsDataSetBindingSource;
            // 
            // autoPartsDataSetBindingSource
            // 
            this.autoPartsDataSetBindingSource.DataSource = this.autoPartsDataSet;
            this.autoPartsDataSetBindingSource.Position = 0;
            // 
            // buttonDeleteParts
            // 
            this.buttonDeleteParts.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteParts.Image")));
            this.buttonDeleteParts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteParts.Location = new System.Drawing.Point(712, 40);
            this.buttonDeleteParts.Name = "buttonDeleteParts";
            this.buttonDeleteParts.Padding = new System.Windows.Forms.Padding(2);
            this.buttonDeleteParts.Size = new System.Drawing.Size(79, 28);
            this.buttonDeleteParts.TabIndex = 20;
            this.buttonDeleteParts.Text = "Удалить";
            this.buttonDeleteParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteParts.UseVisualStyleBackColor = true;
            this.buttonDeleteParts.Click += new System.EventHandler(this.buttonDeleteParts_Click);
            // 
            // buttonAddParts
            // 
            this.buttonAddParts.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddParts.Image")));
            this.buttonAddParts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddParts.Location = new System.Drawing.Point(619, 40);
            this.buttonAddParts.Name = "buttonAddParts";
            this.buttonAddParts.Padding = new System.Windows.Forms.Padding(2);
            this.buttonAddParts.Size = new System.Drawing.Size(87, 28);
            this.buttonAddParts.TabIndex = 19;
            this.buttonAddParts.Text = "Добавить";
            this.buttonAddParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddParts.UseVisualStyleBackColor = true;
            this.buttonAddParts.Click += new System.EventHandler(this.buttonAddParts_Click);
            // 
            // button8
            // 
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(159, 40);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(2);
            this.button8.Size = new System.Drawing.Size(147, 28);
            this.button8.TabIndex = 18;
            this.button8.Text = "Показать историю цен";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(6, 40);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(2);
            this.button9.Size = new System.Drawing.Size(147, 28);
            this.button9.TabIndex = 17;
            this.button9.Text = "Показать поставщиков";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // comboboxSearchByParts
            // 
            this.comboboxSearchByParts.FormattingEnabled = true;
            this.comboboxSearchByParts.ItemHeight = 13;
            this.comboboxSearchByParts.Items.AddRange(new object[] {
            "Все",
            "Название",
            "Код",
            "Производитель",
            "Цена"});
            this.comboboxSearchByParts.Location = new System.Drawing.Point(526, 11);
            this.comboboxSearchByParts.Name = "comboboxSearchByParts";
            this.comboboxSearchByParts.Size = new System.Drawing.Size(81, 21);
            this.comboboxSearchByParts.TabIndex = 16;
            this.comboboxSearchByParts.Text = "Все";
            this.comboboxSearchByParts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxSearchByParts_KeyDown);
            // 
            // buttonCleanParts
            // 
            this.buttonCleanParts.Image = ((System.Drawing.Image)(resources.GetObject("buttonCleanParts.Image")));
            this.buttonCleanParts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCleanParts.Location = new System.Drawing.Point(99, 6);
            this.buttonCleanParts.Name = "buttonCleanParts";
            this.buttonCleanParts.Padding = new System.Windows.Forms.Padding(2);
            this.buttonCleanParts.Size = new System.Drawing.Size(86, 28);
            this.buttonCleanParts.TabIndex = 15;
            this.buttonCleanParts.Text = "Очистить";
            this.buttonCleanParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCleanParts.UseVisualStyleBackColor = true;
            this.buttonCleanParts.Click += new System.EventHandler(this.buttonCleanParts_Click);
            // 
            // buttonRefreshParts
            // 
            this.buttonRefreshParts.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefreshParts.Image")));
            this.buttonRefreshParts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefreshParts.Location = new System.Drawing.Point(6, 6);
            this.buttonRefreshParts.Name = "buttonRefreshParts";
            this.buttonRefreshParts.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRefreshParts.Size = new System.Drawing.Size(87, 28);
            this.buttonRefreshParts.TabIndex = 14;
            this.buttonRefreshParts.Text = "Обновить";
            this.buttonRefreshParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefreshParts.UseVisualStyleBackColor = true;
            this.buttonRefreshParts.Click += new System.EventHandler(this.buttonRefreshParts_Click);
            // 
            // providersTab
            // 
            this.providersTab.Controls.Add(this.buttonSelectRowProviders);
            this.providersTab.Controls.Add(this.flowLayoutPanelProviders);
            this.providersTab.Controls.Add(this.buttonRequestProviders);
            this.providersTab.Controls.Add(this.buttonSearchCleanProviders);
            this.providersTab.Controls.Add(this.textBoxSearchProviders);
            this.providersTab.Controls.Add(this.dataGridViewProviders);
            this.providersTab.Controls.Add(this.buttonDeleteProviders);
            this.providersTab.Controls.Add(this.buttonAddProviders);
            this.providersTab.Controls.Add(this.button6);
            this.providersTab.Controls.Add(this.button7);
            this.providersTab.Controls.Add(this.comboboxSearchByProviders);
            this.providersTab.Controls.Add(this.buttonCleanProviders);
            this.providersTab.Controls.Add(this.buttonRefreshProviders);
            this.providersTab.Location = new System.Drawing.Point(4, 25);
            this.providersTab.Name = "providersTab";
            this.providersTab.Padding = new System.Windows.Forms.Padding(3);
            this.providersTab.Size = new System.Drawing.Size(797, 423);
            this.providersTab.TabIndex = 2;
            this.providersTab.Text = "Поставщики";
            this.providersTab.UseVisualStyleBackColor = true;
            // 
            // buttonSelectRowProviders
            // 
            this.buttonSelectRowProviders.Location = new System.Drawing.Point(343, 40);
            this.buttonSelectRowProviders.Name = "buttonSelectRowProviders";
            this.buttonSelectRowProviders.Size = new System.Drawing.Size(109, 28);
            this.buttonSelectRowProviders.TabIndex = 39;
            this.buttonSelectRowProviders.Text = "Выделить строку";
            this.buttonSelectRowProviders.UseVisualStyleBackColor = true;
            this.buttonSelectRowProviders.Click += new System.EventHandler(this.buttonSelectRowProviders_Click);
            // 
            // flowLayoutPanelProviders
            // 
            this.flowLayoutPanelProviders.Controls.Add(this.labelRowCountProviders);
            this.flowLayoutPanelProviders.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelProviders.Location = new System.Drawing.Point(566, 401);
            this.flowLayoutPanelProviders.Name = "flowLayoutPanelProviders";
            this.flowLayoutPanelProviders.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.flowLayoutPanelProviders.Size = new System.Drawing.Size(231, 22);
            this.flowLayoutPanelProviders.TabIndex = 38;
            // 
            // labelRowCountProviders
            // 
            this.labelRowCountProviders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRowCountProviders.AutoSize = true;
            this.labelRowCountProviders.Location = new System.Drawing.Point(107, 4);
            this.labelRowCountProviders.Name = "labelRowCountProviders";
            this.labelRowCountProviders.Size = new System.Drawing.Size(117, 13);
            this.labelRowCountProviders.TabIndex = 11;
            this.labelRowCountProviders.Text = "Количество записей: ";
            this.labelRowCountProviders.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonRequestProviders
            // 
            this.buttonRequestProviders.Image = ((System.Drawing.Image)(resources.GetObject("buttonRequestProviders.Image")));
            this.buttonRequestProviders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequestProviders.Location = new System.Drawing.Point(497, 40);
            this.buttonRequestProviders.Name = "buttonRequestProviders";
            this.buttonRequestProviders.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRequestProviders.Size = new System.Drawing.Size(110, 28);
            this.buttonRequestProviders.TabIndex = 37;
            this.buttonRequestProviders.Text = "Ручной запрос";
            this.buttonRequestProviders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRequestProviders.UseVisualStyleBackColor = true;
            this.buttonRequestProviders.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // buttonSearchCleanProviders
            // 
            this.buttonSearchCleanProviders.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchCleanProviders.Image")));
            this.buttonSearchCleanProviders.Location = new System.Drawing.Point(769, 10);
            this.buttonSearchCleanProviders.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchCleanProviders.Name = "buttonSearchCleanProviders";
            this.buttonSearchCleanProviders.Size = new System.Drawing.Size(22, 22);
            this.buttonSearchCleanProviders.TabIndex = 36;
            this.buttonSearchCleanProviders.UseVisualStyleBackColor = true;
            this.buttonSearchCleanProviders.Click += new System.EventHandler(this.buttonSearchCleanProviders_Click);
            // 
            // textBoxSearchProviders
            // 
            this.textBoxSearchProviders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchProviders.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSearchProviders.Location = new System.Drawing.Point(619, 11);
            this.textBoxSearchProviders.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearchProviders.MaxLength = 255;
            this.textBoxSearchProviders.Name = "textBoxSearchProviders";
            this.textBoxSearchProviders.Size = new System.Drawing.Size(150, 20);
            this.textBoxSearchProviders.TabIndex = 35;
            this.textBoxSearchProviders.Text = "Поиск🔍";
            this.textBoxSearchProviders.WordWrap = false;
            this.textBoxSearchProviders.Enter += new System.EventHandler(this.textBoxSearchProviders_Enter);
            this.textBoxSearchProviders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchProviders_KeyDown);
            this.textBoxSearchProviders.Leave += new System.EventHandler(this.textBoxSearchProviders_Leave);
            // 
            // dataGridViewProviders
            // 
            this.dataGridViewProviders.AllowUserToAddRows = false;
            this.dataGridViewProviders.AllowUserToDeleteRows = false;
            this.dataGridViewProviders.AutoGenerateColumns = false;
            this.dataGridViewProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProviders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn1,
            this.provideraddressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridViewProviders.DataSource = this.providersBindingSource;
            this.dataGridViewProviders.Location = new System.Drawing.Point(0, 74);
            this.dataGridViewProviders.Name = "dataGridViewProviders";
            this.dataGridViewProviders.ReadOnly = true;
            this.dataGridViewProviders.Size = new System.Drawing.Size(797, 327);
            this.dataGridViewProviders.TabIndex = 34;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // provideraddressDataGridViewTextBoxColumn
            // 
            this.provideraddressDataGridViewTextBoxColumn.DataPropertyName = "provider_address";
            this.provideraddressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.provideraddressDataGridViewTextBoxColumn.Name = "provideraddressDataGridViewTextBoxColumn";
            this.provideraddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "providers";
            this.providersBindingSource.DataSource = this.autoPartsDataSetBindingSource;
            // 
            // buttonDeleteProviders
            // 
            this.buttonDeleteProviders.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteProviders.Image")));
            this.buttonDeleteProviders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteProviders.Location = new System.Drawing.Point(712, 40);
            this.buttonDeleteProviders.Name = "buttonDeleteProviders";
            this.buttonDeleteProviders.Padding = new System.Windows.Forms.Padding(2);
            this.buttonDeleteProviders.Size = new System.Drawing.Size(79, 28);
            this.buttonDeleteProviders.TabIndex = 33;
            this.buttonDeleteProviders.Text = "Удалить";
            this.buttonDeleteProviders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteProviders.UseVisualStyleBackColor = true;
            this.buttonDeleteProviders.Click += new System.EventHandler(this.buttonDeleteProviders_Click);
            // 
            // buttonAddProviders
            // 
            this.buttonAddProviders.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddProviders.Image")));
            this.buttonAddProviders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddProviders.Location = new System.Drawing.Point(619, 40);
            this.buttonAddProviders.Name = "buttonAddProviders";
            this.buttonAddProviders.Padding = new System.Windows.Forms.Padding(2);
            this.buttonAddProviders.Size = new System.Drawing.Size(87, 28);
            this.buttonAddProviders.TabIndex = 32;
            this.buttonAddProviders.Text = "Добавить";
            this.buttonAddProviders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddProviders.UseVisualStyleBackColor = true;
            this.buttonAddProviders.Click += new System.EventHandler(this.buttonAddProviders_Click);
            // 
            // button6
            // 
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(159, 40);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(2);
            this.button6.Size = new System.Drawing.Size(147, 28);
            this.button6.TabIndex = 31;
            this.button6.Text = "Показать на складе";
            this.toolTip.SetToolTip(this.button6, "Показать все детали на складе, приобретенные у выбранного поставщика");
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(6, 40);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(2);
            this.button7.Size = new System.Drawing.Size(147, 28);
            this.button7.TabIndex = 30;
            this.button7.Text = "Показать ассортимент";
            this.toolTip.SetToolTip(this.button7, "Показать все доступные детали у этого поставщика");
            this.button7.UseVisualStyleBackColor = true;
            // 
            // comboboxSearchByProviders
            // 
            this.comboboxSearchByProviders.FormattingEnabled = true;
            this.comboboxSearchByProviders.ItemHeight = 13;
            this.comboboxSearchByProviders.Items.AddRange(new object[] {
            "Все",
            "Название",
            "Адрес",
            "Телефон"});
            this.comboboxSearchByProviders.Location = new System.Drawing.Point(526, 11);
            this.comboboxSearchByProviders.Name = "comboboxSearchByProviders";
            this.comboboxSearchByProviders.Size = new System.Drawing.Size(81, 21);
            this.comboboxSearchByProviders.TabIndex = 29;
            this.comboboxSearchByProviders.Text = "Все";
            this.comboboxSearchByProviders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxSearchByProviders_KeyDown);
            // 
            // buttonCleanProviders
            // 
            this.buttonCleanProviders.Image = ((System.Drawing.Image)(resources.GetObject("buttonCleanProviders.Image")));
            this.buttonCleanProviders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCleanProviders.Location = new System.Drawing.Point(99, 6);
            this.buttonCleanProviders.Name = "buttonCleanProviders";
            this.buttonCleanProviders.Padding = new System.Windows.Forms.Padding(2);
            this.buttonCleanProviders.Size = new System.Drawing.Size(86, 28);
            this.buttonCleanProviders.TabIndex = 28;
            this.buttonCleanProviders.Text = "Очистить";
            this.buttonCleanProviders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCleanProviders.UseVisualStyleBackColor = true;
            this.buttonCleanProviders.Click += new System.EventHandler(this.buttonCleanProviders_Click);
            // 
            // buttonRefreshProviders
            // 
            this.buttonRefreshProviders.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefreshProviders.Image")));
            this.buttonRefreshProviders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefreshProviders.Location = new System.Drawing.Point(6, 6);
            this.buttonRefreshProviders.Name = "buttonRefreshProviders";
            this.buttonRefreshProviders.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRefreshProviders.Size = new System.Drawing.Size(87, 28);
            this.buttonRefreshProviders.TabIndex = 27;
            this.buttonRefreshProviders.Text = "Обновить";
            this.buttonRefreshProviders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefreshProviders.UseVisualStyleBackColor = true;
            this.buttonRefreshProviders.Click += new System.EventHandler(this.buttonRefreshProviders_Click);
            // 
            // pricehistoryTab
            // 
            this.pricehistoryTab.Controls.Add(this.buttonSelectRowPriceview);
            this.pricehistoryTab.Controls.Add(this.flowLayoutPanelPriceview);
            this.pricehistoryTab.Controls.Add(this.buttonRequestPriceview);
            this.pricehistoryTab.Controls.Add(this.buttonSearchCleanPriceview);
            this.pricehistoryTab.Controls.Add(this.textBoxSearchPriceview);
            this.pricehistoryTab.Controls.Add(this.dataGridViewPriceview);
            this.pricehistoryTab.Controls.Add(this.buttonDeletePriceveiw);
            this.pricehistoryTab.Controls.Add(this.buttonAddPriceview);
            this.pricehistoryTab.Controls.Add(this.button10);
            this.pricehistoryTab.Controls.Add(this.button11);
            this.pricehistoryTab.Controls.Add(this.comboboxSearchByPriceview);
            this.pricehistoryTab.Controls.Add(this.buttonCleanPriceview);
            this.pricehistoryTab.Controls.Add(this.buttonRefreshPriceview);
            this.pricehistoryTab.Location = new System.Drawing.Point(4, 25);
            this.pricehistoryTab.Name = "pricehistoryTab";
            this.pricehistoryTab.Size = new System.Drawing.Size(797, 423);
            this.pricehistoryTab.TabIndex = 3;
            this.pricehistoryTab.Text = "История цен";
            this.pricehistoryTab.UseVisualStyleBackColor = true;
            // 
            // buttonSelectRowPriceview
            // 
            this.buttonSelectRowPriceview.Location = new System.Drawing.Point(343, 40);
            this.buttonSelectRowPriceview.Name = "buttonSelectRowPriceview";
            this.buttonSelectRowPriceview.Size = new System.Drawing.Size(109, 28);
            this.buttonSelectRowPriceview.TabIndex = 52;
            this.buttonSelectRowPriceview.Text = "Выделить строку";
            this.buttonSelectRowPriceview.UseVisualStyleBackColor = true;
            this.buttonSelectRowPriceview.Click += new System.EventHandler(this.buttonSelectRowPriceview_Click);
            // 
            // flowLayoutPanelPriceview
            // 
            this.flowLayoutPanelPriceview.Controls.Add(this.labelRowCountPriceview);
            this.flowLayoutPanelPriceview.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelPriceview.Location = new System.Drawing.Point(566, 401);
            this.flowLayoutPanelPriceview.Name = "flowLayoutPanelPriceview";
            this.flowLayoutPanelPriceview.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.flowLayoutPanelPriceview.Size = new System.Drawing.Size(231, 22);
            this.flowLayoutPanelPriceview.TabIndex = 51;
            // 
            // labelRowCountPriceview
            // 
            this.labelRowCountPriceview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRowCountPriceview.AutoSize = true;
            this.labelRowCountPriceview.Location = new System.Drawing.Point(107, 4);
            this.labelRowCountPriceview.Name = "labelRowCountPriceview";
            this.labelRowCountPriceview.Size = new System.Drawing.Size(117, 13);
            this.labelRowCountPriceview.TabIndex = 11;
            this.labelRowCountPriceview.Text = "Количество записей: ";
            this.labelRowCountPriceview.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonRequestPriceview
            // 
            this.buttonRequestPriceview.Image = ((System.Drawing.Image)(resources.GetObject("buttonRequestPriceview.Image")));
            this.buttonRequestPriceview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequestPriceview.Location = new System.Drawing.Point(497, 40);
            this.buttonRequestPriceview.Name = "buttonRequestPriceview";
            this.buttonRequestPriceview.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRequestPriceview.Size = new System.Drawing.Size(110, 28);
            this.buttonRequestPriceview.TabIndex = 50;
            this.buttonRequestPriceview.Text = "Ручной запрос";
            this.buttonRequestPriceview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRequestPriceview.UseVisualStyleBackColor = true;
            this.buttonRequestPriceview.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // buttonSearchCleanPriceview
            // 
            this.buttonSearchCleanPriceview.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchCleanPriceview.Image")));
            this.buttonSearchCleanPriceview.Location = new System.Drawing.Point(769, 10);
            this.buttonSearchCleanPriceview.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchCleanPriceview.Name = "buttonSearchCleanPriceview";
            this.buttonSearchCleanPriceview.Size = new System.Drawing.Size(22, 22);
            this.buttonSearchCleanPriceview.TabIndex = 49;
            this.buttonSearchCleanPriceview.UseVisualStyleBackColor = true;
            this.buttonSearchCleanPriceview.Click += new System.EventHandler(this.buttonSearchCleanPriceview_Click);
            // 
            // textBoxSearchPriceview
            // 
            this.textBoxSearchPriceview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchPriceview.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSearchPriceview.Location = new System.Drawing.Point(619, 11);
            this.textBoxSearchPriceview.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearchPriceview.MaxLength = 255;
            this.textBoxSearchPriceview.Name = "textBoxSearchPriceview";
            this.textBoxSearchPriceview.Size = new System.Drawing.Size(150, 20);
            this.textBoxSearchPriceview.TabIndex = 48;
            this.textBoxSearchPriceview.Text = "Поиск🔍";
            this.textBoxSearchPriceview.WordWrap = false;
            this.textBoxSearchPriceview.Enter += new System.EventHandler(this.textBoxSearchPriceview_Enter);
            this.textBoxSearchPriceview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchPriceview_KeyDown);
            this.textBoxSearchPriceview.Leave += new System.EventHandler(this.textBoxSearchPriceview_Leave);
            // 
            // dataGridViewPriceview
            // 
            this.dataGridViewPriceview.AllowUserToAddRows = false;
            this.dataGridViewPriceview.AllowUserToDeleteRows = false;
            this.dataGridViewPriceview.AutoGenerateColumns = false;
            this.dataGridViewPriceview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPriceview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.кодДеталиDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn1,
            this.текущаяЦенаDataGridViewTextBoxColumn,
            this.стараяЦенаDataGridViewTextBoxColumn,
            this.действовалаДоDataGridViewTextBoxColumn});
            this.dataGridViewPriceview.DataSource = this.priceviewBindingSource;
            this.dataGridViewPriceview.Location = new System.Drawing.Point(0, 74);
            this.dataGridViewPriceview.Name = "dataGridViewPriceview";
            this.dataGridViewPriceview.ReadOnly = true;
            this.dataGridViewPriceview.Size = new System.Drawing.Size(797, 327);
            this.dataGridViewPriceview.TabIndex = 47;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодДеталиDataGridViewTextBoxColumn
            // 
            this.кодДеталиDataGridViewTextBoxColumn.DataPropertyName = "Код детали";
            this.кодДеталиDataGridViewTextBoxColumn.HeaderText = "Код детали";
            this.кодДеталиDataGridViewTextBoxColumn.Name = "кодДеталиDataGridViewTextBoxColumn";
            this.кодДеталиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеDataGridViewTextBoxColumn1
            // 
            this.названиеDataGridViewTextBoxColumn1.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn1.Name = "названиеDataGridViewTextBoxColumn1";
            this.названиеDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // текущаяЦенаDataGridViewTextBoxColumn
            // 
            this.текущаяЦенаDataGridViewTextBoxColumn.DataPropertyName = "Текущая цена";
            this.текущаяЦенаDataGridViewTextBoxColumn.HeaderText = "Текущая цена";
            this.текущаяЦенаDataGridViewTextBoxColumn.Name = "текущаяЦенаDataGridViewTextBoxColumn";
            this.текущаяЦенаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стараяЦенаDataGridViewTextBoxColumn
            // 
            this.стараяЦенаDataGridViewTextBoxColumn.DataPropertyName = "Старая цена";
            this.стараяЦенаDataGridViewTextBoxColumn.HeaderText = "Старая цена";
            this.стараяЦенаDataGridViewTextBoxColumn.Name = "стараяЦенаDataGridViewTextBoxColumn";
            this.стараяЦенаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // действовалаДоDataGridViewTextBoxColumn
            // 
            this.действовалаДоDataGridViewTextBoxColumn.DataPropertyName = "Действовала до";
            this.действовалаДоDataGridViewTextBoxColumn.HeaderText = "Действовала до";
            this.действовалаДоDataGridViewTextBoxColumn.Name = "действовалаДоDataGridViewTextBoxColumn";
            this.действовалаДоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceviewBindingSource
            // 
            this.priceviewBindingSource.DataMember = "priceview";
            this.priceviewBindingSource.DataSource = this.autoPartsDataSet;
            // 
            // buttonDeletePriceveiw
            // 
            this.buttonDeletePriceveiw.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeletePriceveiw.Image")));
            this.buttonDeletePriceveiw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeletePriceveiw.Location = new System.Drawing.Point(712, 40);
            this.buttonDeletePriceveiw.Name = "buttonDeletePriceveiw";
            this.buttonDeletePriceveiw.Padding = new System.Windows.Forms.Padding(2);
            this.buttonDeletePriceveiw.Size = new System.Drawing.Size(79, 28);
            this.buttonDeletePriceveiw.TabIndex = 46;
            this.buttonDeletePriceveiw.Text = "Удалить";
            this.buttonDeletePriceveiw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeletePriceveiw.UseVisualStyleBackColor = true;
            this.buttonDeletePriceveiw.Click += new System.EventHandler(this.buttonDeletePriceview_Click);
            // 
            // buttonAddPriceview
            // 
            this.buttonAddPriceview.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddPriceview.Image")));
            this.buttonAddPriceview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddPriceview.Location = new System.Drawing.Point(619, 40);
            this.buttonAddPriceview.Name = "buttonAddPriceview";
            this.buttonAddPriceview.Padding = new System.Windows.Forms.Padding(2);
            this.buttonAddPriceview.Size = new System.Drawing.Size(87, 28);
            this.buttonAddPriceview.TabIndex = 45;
            this.buttonAddPriceview.Text = "Изменить";
            this.buttonAddPriceview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddPriceview.UseVisualStyleBackColor = true;
            this.buttonAddPriceview.Click += new System.EventHandler(this.buttonAddPriceview_Click);
            // 
            // button10
            // 
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(159, 40);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(2);
            this.button10.Size = new System.Drawing.Size(147, 28);
            this.button10.TabIndex = 44;
            this.button10.Text = "Показать на складе";
            this.toolTip.SetToolTip(this.button10, "Показать все детали на складе, приобретенные у выбранного поставщика");
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(6, 40);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(2);
            this.button11.Size = new System.Drawing.Size(147, 28);
            this.button11.TabIndex = 43;
            this.button11.Text = "Показать ассортимент";
            this.toolTip.SetToolTip(this.button11, "Показать все доступные детали у этого поставщика");
            this.button11.UseVisualStyleBackColor = true;
            // 
            // comboboxSearchByPriceview
            // 
            this.comboboxSearchByPriceview.FormattingEnabled = true;
            this.comboboxSearchByPriceview.ItemHeight = 13;
            this.comboboxSearchByPriceview.Items.AddRange(new object[] {
            "Все",
            "id",
            "Код детали",
            "Название",
            "Текущая цена",
            "Старая цена",
            "Действовала до"});
            this.comboboxSearchByPriceview.Location = new System.Drawing.Point(526, 11);
            this.comboboxSearchByPriceview.Name = "comboboxSearchByPriceview";
            this.comboboxSearchByPriceview.Size = new System.Drawing.Size(81, 21);
            this.comboboxSearchByPriceview.TabIndex = 42;
            this.comboboxSearchByPriceview.Text = "Все";
            this.comboboxSearchByPriceview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxSearchByPriceview_KeyDown);
            // 
            // buttonCleanPriceview
            // 
            this.buttonCleanPriceview.Image = ((System.Drawing.Image)(resources.GetObject("buttonCleanPriceview.Image")));
            this.buttonCleanPriceview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCleanPriceview.Location = new System.Drawing.Point(99, 6);
            this.buttonCleanPriceview.Name = "buttonCleanPriceview";
            this.buttonCleanPriceview.Padding = new System.Windows.Forms.Padding(2);
            this.buttonCleanPriceview.Size = new System.Drawing.Size(86, 28);
            this.buttonCleanPriceview.TabIndex = 41;
            this.buttonCleanPriceview.Text = "Очистить";
            this.buttonCleanPriceview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCleanPriceview.UseVisualStyleBackColor = true;
            this.buttonCleanPriceview.Click += new System.EventHandler(this.buttonCleanPriceview_Click);
            // 
            // buttonRefreshPriceview
            // 
            this.buttonRefreshPriceview.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefreshPriceview.Image")));
            this.buttonRefreshPriceview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefreshPriceview.Location = new System.Drawing.Point(6, 6);
            this.buttonRefreshPriceview.Name = "buttonRefreshPriceview";
            this.buttonRefreshPriceview.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRefreshPriceview.Size = new System.Drawing.Size(87, 28);
            this.buttonRefreshPriceview.TabIndex = 40;
            this.buttonRefreshPriceview.Text = "Обновить";
            this.buttonRefreshPriceview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefreshPriceview.UseVisualStyleBackColor = true;
            this.buttonRefreshPriceview.Click += new System.EventHandler(this.buttonRefreshPriceview_Click);
            // 
            // storehouseTableAdapter
            // 
            this.storehouseTableAdapter.ClearBeforeFill = true;
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
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
            // bridgeproviderspartsBindingSource
            // 
            this.bridgeproviderspartsBindingSource.DataMember = "bridge_providers_parts";
            this.bridgeproviderspartsBindingSource.DataSource = this.autoPartsDataSet;
            // 
            // bridge_providers_partsTableAdapter
            // 
            this.bridge_providers_partsTableAdapter.ClearBeforeFill = true;
            // 
            // priceviewTableAdapter
            // 
            this.priceviewTableAdapter.ClearBeforeFill = true;
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
            this.flowLayoutPanelRowCountStorehouse.ResumeLayout(false);
            this.flowLayoutPanelRowCountStorehouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSet)).EndInit();
            this.partsTab.ResumeLayout(false);
            this.partsTab.PerformLayout();
            this.flowLayoutPanelParts.ResumeLayout(false);
            this.flowLayoutPanelParts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSetBindingSource)).EndInit();
            this.providersTab.ResumeLayout(false);
            this.providersTab.PerformLayout();
            this.flowLayoutPanelProviders.ResumeLayout(false);
            this.flowLayoutPanelProviders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            this.pricehistoryTab.ResumeLayout(false);
            this.pricehistoryTab.PerformLayout();
            this.flowLayoutPanelPriceview.ResumeLayout(false);
            this.flowLayoutPanelPriceview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriceview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bridgeproviderspartsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCleanStorehouse;
        private System.Windows.Forms.Button buttonRefreshStorehouse;
        private System.Windows.Forms.Button buttonDeleteStorehouse;
        private System.Windows.Forms.Button buttonAddStorehouse;
        private System.Windows.Forms.Button buttonPricehistoryStorehouse;
        private System.Windows.Forms.Button buttonToProvidersStorehouse;
        private System.Windows.Forms.DataGridView dataGridViewStorehouse;
        private System.Windows.Forms.Button buttonSearchClearStorehouse;
        private System.Windows.Forms.Button buttonRequestStorehouse;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRowCountStorehouse;
        private System.Windows.Forms.Label labelRowCountStorehouse;
        private System.Windows.Forms.BindingSource storehouseBindingSource;
        private AutoPartsDataSetTableAdapters.storehouseTableAdapter storehouseTableAdapter;
        private System.Windows.Forms.BindingSource autoPartsDataSetBindingSource;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private AutoPartsDataSetTableAdapters.providersTableAdapter providersTableAdapter;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private AutoPartsDataSetTableAdapters.partsTableAdapter partsTableAdapter;
        private System.Windows.Forms.Button buttonSelectRowStorehouse;
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
        private System.Windows.Forms.Button buttonSelectRowParts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelParts;
        private System.Windows.Forms.Label labelRowCountParts;
        private System.Windows.Forms.Button buttonRequestParts;
        private System.Windows.Forms.Button buttonSearchCleanParts;
        private System.Windows.Forms.TextBox textBoxSearchParts;
        private System.Windows.Forms.DataGridView dataGridViewParts;
        private System.Windows.Forms.Button buttonDeleteParts;
        private System.Windows.Forms.Button buttonAddParts;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboboxSearchByParts;
        private System.Windows.Forms.Button buttonCleanParts;
        private System.Windows.Forms.Button buttonRefreshParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSelectRowProviders;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProviders;
        private System.Windows.Forms.Label labelRowCountProviders;
        private System.Windows.Forms.Button buttonRequestProviders;
        private System.Windows.Forms.Button buttonSearchCleanProviders;
        private System.Windows.Forms.TextBox textBoxSearchProviders;
        private System.Windows.Forms.DataGridView dataGridViewProviders;
        private System.Windows.Forms.Button buttonDeleteProviders;
        private System.Windows.Forms.Button buttonAddProviders;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboboxSearchByProviders;
        private System.Windows.Forms.Button buttonCleanProviders;
        private System.Windows.Forms.Button buttonRefreshProviders;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.BindingSource bridgeproviderspartsBindingSource;
        private AutoPartsDataSetTableAdapters.bridge_providers_partsTableAdapter bridge_providers_partsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn provideraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSelectRowPriceview;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPriceview;
        private System.Windows.Forms.Label labelRowCountPriceview;
        private System.Windows.Forms.Button buttonRequestPriceview;
        private System.Windows.Forms.Button buttonSearchCleanPriceview;
        private System.Windows.Forms.TextBox textBoxSearchPriceview;
        private System.Windows.Forms.Button buttonDeletePriceveiw;
        private System.Windows.Forms.Button buttonAddPriceview;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox comboboxSearchByPriceview;
        private System.Windows.Forms.Button buttonCleanPriceview;
        private System.Windows.Forms.Button buttonRefreshPriceview;
        private System.Windows.Forms.BindingSource priceviewBindingSource;
        private AutoPartsDataSetTableAdapters.priceviewTableAdapter priceviewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДеталиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn текущаяЦенаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стараяЦенаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn действовалаДоDataGridViewTextBoxColumn;
        public AutoPartsDataSet autoPartsDataSet;
        private System.Windows.Forms.DataGridView dataGridViewPriceview;
        public System.Windows.Forms.TextBox textBoxSearchStorehouse;
        public System.Windows.Forms.TabControl tabs;
        public System.Windows.Forms.ComboBox comboboxSearchByStorehouse;
        public System.Windows.Forms.TabPage storehouseTab;
        public System.Windows.Forms.TabPage partsTab;
        public System.Windows.Forms.TabPage providersTab;
        public System.Windows.Forms.TabPage pricehistoryTab;
    }
}

