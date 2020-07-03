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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoPartsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoPartsDataSet = new DB.AutoPartsDataSet();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonInfoProviders = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonCleanStorehouse = new System.Windows.Forms.Button();
            this.buttonRequestStorehouse = new System.Windows.Forms.Button();
            this.storehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storehouseTableAdapter = new DB.AutoPartsDataSetTableAdapters.storehouseTableAdapter();
            this.providersTableAdapter = new DB.AutoPartsDataSetTableAdapters.providersTableAdapter();
            this.partsTableAdapter = new DB.AutoPartsDataSetTableAdapters.partsTableAdapter();
            this.dealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dealsTableAdapter = new DB.AutoPartsDataSetTableAdapters.dealsTableAdapter();
            this.bridgeproviderspartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bridge_providers_partsTableAdapter = new DB.AutoPartsDataSetTableAdapters.bridge_providers_partsTableAdapter();
            this.priceviewTableAdapter = new DB.AutoPartsDataSetTableAdapters.priceviewTableAdapter();
            this.providersTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelRowCountProviders = new System.Windows.Forms.Label();
            this.buttonRefreshProviders = new System.Windows.Forms.Button();
            this.buttonSelectRowProviders = new System.Windows.Forms.Button();
            this.dataGridViewProviders = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRequestProviders = new System.Windows.Forms.Button();
            this.buttonDeleteProviders = new System.Windows.Forms.Button();
            this.buttonCleanProviders = new System.Windows.Forms.Button();
            this.buttonAddProviders = new System.Windows.Forms.Button();
            this.comboboxSearchByProviders = new System.Windows.Forms.ComboBox();
            this.textBoxSearchProviders = new System.Windows.Forms.TextBox();
            this.buttonSearchCleanProviders = new System.Windows.Forms.Button();
            this.partsTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelRowCountParts = new System.Windows.Forms.Label();
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRefreshParts = new System.Windows.Forms.Button();
            this.buttonSelectRowParts = new System.Windows.Forms.Button();
            this.buttonRequestParts = new System.Windows.Forms.Button();
            this.buttonDeleteParts = new System.Windows.Forms.Button();
            this.buttonCleanParts = new System.Windows.Forms.Button();
            this.buttonAddParts = new System.Windows.Forms.Button();
            this.comboboxSearchByParts = new System.Windows.Forms.ComboBox();
            this.textBoxSearchParts = new System.Windows.Forms.TextBox();
            this.buttonSearchCleanParts = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonInfoParts = new System.Windows.Forms.Button();
            this.storehouseTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelRowCountStorehouse = new System.Windows.Forms.Label();
            this.dataGridViewStorehouse = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStoreHouseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRefreshStorehouse = new System.Windows.Forms.Button();
            this.buttonSelectRowStorehouse = new System.Windows.Forms.Button();
            this.textBoxSearchStorehouse = new System.Windows.Forms.TextBox();
            this.comboboxSearchByStorehouse = new System.Windows.Forms.ComboBox();
            this.buttonSearchClearStorehouse = new System.Windows.Forms.Button();
            this.buttonToProvidersStorehouse = new System.Windows.Forms.Button();
            this.buttonDeleteStorehouse = new System.Windows.Forms.Button();
            this.buttonInfoStorehouse = new System.Windows.Forms.Button();
            this.buttonAddStorehouse = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bridgeproviderspartsBindingSource)).BeginInit();
            this.providersTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviders)).BeginInit();
            this.partsTab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            this.storehouseTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorehouse)).BeginInit();
            this.tabs.SuspendLayout();
            this.SuspendLayout();
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
            // autoPartsDataSet
            // 
            this.autoPartsDataSet.DataSetName = "AutoPartsDataSet";
            this.autoPartsDataSet.EnforceConstraints = false;
            this.autoPartsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "providers";
            this.providersBindingSource.DataSource = this.autoPartsDataSetBindingSource;
            // 
            // buttonInfoProviders
            // 
            this.buttonInfoProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInfoProviders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInfoProviders.Location = new System.Drawing.Point(133, 38);
            this.buttonInfoProviders.Name = "buttonInfoProviders";
            this.buttonInfoProviders.Padding = new System.Windows.Forms.Padding(2);
            this.buttonInfoProviders.Size = new System.Drawing.Size(124, 29);
            this.buttonInfoProviders.TabIndex = 31;
            this.buttonInfoProviders.Text = "Сводка";
            this.toolTip.SetToolTip(this.buttonInfoProviders, "Показать все детали на складе, приобретенные у выбранного поставщика");
            this.buttonInfoProviders.UseVisualStyleBackColor = true;
            this.buttonInfoProviders.Click += new System.EventHandler(this.buttonInfoProviders_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(3, 38);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(2);
            this.button7.Size = new System.Drawing.Size(124, 29);
            this.button7.TabIndex = 30;
            this.button7.Text = "Показать ассортимент";
            this.toolTip.SetToolTip(this.button7, "Показать все доступные детали у этого поставщика");
            this.button7.UseVisualStyleBackColor = true;
            // 
            // buttonCleanStorehouse
            // 
            this.buttonCleanStorehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCleanStorehouse.Image = ((System.Drawing.Image)(resources.GetObject("buttonCleanStorehouse.Image")));
            this.buttonCleanStorehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCleanStorehouse.Location = new System.Drawing.Point(133, 3);
            this.buttonCleanStorehouse.Name = "buttonCleanStorehouse";
            this.buttonCleanStorehouse.Padding = new System.Windows.Forms.Padding(2);
            this.buttonCleanStorehouse.Size = new System.Drawing.Size(124, 29);
            this.buttonCleanStorehouse.TabIndex = 1;
            this.buttonCleanStorehouse.Text = "Очистить";
            this.buttonCleanStorehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.buttonCleanStorehouse, "Сбросить все фильтры для таблицы");
            this.buttonCleanStorehouse.UseVisualStyleBackColor = true;
            this.buttonCleanStorehouse.Click += new System.EventHandler(this.buttonCleanStorehouse_Click);
            // 
            // buttonRequestStorehouse
            // 
            this.buttonRequestStorehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRequestStorehouse.Image = ((System.Drawing.Image)(resources.GetObject("buttonRequestStorehouse.Image")));
            this.buttonRequestStorehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequestStorehouse.Location = new System.Drawing.Point(393, 38);
            this.buttonRequestStorehouse.Name = "buttonRequestStorehouse";
            this.buttonRequestStorehouse.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRequestStorehouse.Size = new System.Drawing.Size(124, 29);
            this.buttonRequestStorehouse.TabIndex = 10;
            this.buttonRequestStorehouse.Text = "Ручной запрос";
            this.buttonRequestStorehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.buttonRequestStorehouse, "Создать ручной SQL-запрос");
            this.buttonRequestStorehouse.UseVisualStyleBackColor = true;
            this.buttonRequestStorehouse.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // storehouseBindingSource
            // 
            this.storehouseBindingSource.AllowNew = false;
            this.storehouseBindingSource.DataMember = "storehouse";
            this.storehouseBindingSource.DataSource = this.autoPartsDataSet;
            // 
            // priceviewBindingSource
            // 
            this.priceviewBindingSource.DataMember = "priceview";
            this.priceviewBindingSource.DataSource = this.autoPartsDataSet;
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
            // providersTab
            // 
            this.providersTab.Controls.Add(this.tableLayoutPanel3);
            this.providersTab.Location = new System.Drawing.Point(4, 25);
            this.providersTab.Name = "providersTab";
            this.providersTab.Padding = new System.Windows.Forms.Padding(3);
            this.providersTab.Size = new System.Drawing.Size(792, 421);
            this.providersTab.TabIndex = 2;
            this.providersTab.Text = "Поставщики";
            this.providersTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.Controls.Add(this.labelRowCountProviders, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.buttonRefreshProviders, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonSelectRowProviders, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewProviders, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.buttonRequestProviders, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonDeleteProviders, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonCleanProviders, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonAddProviders, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.comboboxSearchByProviders, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxSearchProviders, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonSearchCleanProviders, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.button7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonInfoProviders, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(786, 415);
            this.tableLayoutPanel3.TabIndex = 40;
            // 
            // labelRowCountProviders
            // 
            this.labelRowCountProviders.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.labelRowCountProviders, 2);
            this.labelRowCountProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRowCountProviders.Location = new System.Drawing.Point(523, 380);
            this.labelRowCountProviders.Name = "labelRowCountProviders";
            this.labelRowCountProviders.Size = new System.Drawing.Size(260, 35);
            this.labelRowCountProviders.TabIndex = 11;
            this.labelRowCountProviders.Text = "Количество записей: ";
            this.labelRowCountProviders.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonRefreshProviders
            // 
            this.buttonRefreshProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRefreshProviders.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefreshProviders.Image")));
            this.buttonRefreshProviders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefreshProviders.Location = new System.Drawing.Point(3, 3);
            this.buttonRefreshProviders.Name = "buttonRefreshProviders";
            this.buttonRefreshProviders.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRefreshProviders.Size = new System.Drawing.Size(124, 29);
            this.buttonRefreshProviders.TabIndex = 27;
            this.buttonRefreshProviders.Text = "Обновить";
            this.buttonRefreshProviders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefreshProviders.UseVisualStyleBackColor = true;
            this.buttonRefreshProviders.Click += new System.EventHandler(this.buttonRefreshProviders_Click);
            // 
            // buttonSelectRowProviders
            // 
            this.buttonSelectRowProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelectRowProviders.Location = new System.Drawing.Point(263, 38);
            this.buttonSelectRowProviders.Name = "buttonSelectRowProviders";
            this.buttonSelectRowProviders.Size = new System.Drawing.Size(124, 29);
            this.buttonSelectRowProviders.TabIndex = 39;
            this.buttonSelectRowProviders.Text = "Выделить строку";
            this.buttonSelectRowProviders.UseVisualStyleBackColor = true;
            this.buttonSelectRowProviders.Click += new System.EventHandler(this.buttonSelectRowProviders_Click);
            // 
            // dataGridViewProviders
            // 
            this.dataGridViewProviders.AllowUserToAddRows = false;
            this.dataGridViewProviders.AllowUserToDeleteRows = false;
            this.dataGridViewProviders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProviders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProviders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.tableLayoutPanel3.SetColumnSpan(this.dataGridViewProviders, 6);
            this.dataGridViewProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProviders.Location = new System.Drawing.Point(3, 73);
            this.dataGridViewProviders.Name = "dataGridViewProviders";
            this.dataGridViewProviders.ReadOnly = true;
            this.dataGridViewProviders.RowHeadersVisible = false;
            this.dataGridViewProviders.Size = new System.Drawing.Size(780, 304);
            this.dataGridViewProviders.TabIndex = 34;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Название";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Адрес";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Телефон";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // buttonRequestProviders
            // 
            this.buttonRequestProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRequestProviders.Image = ((System.Drawing.Image)(resources.GetObject("buttonRequestProviders.Image")));
            this.buttonRequestProviders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequestProviders.Location = new System.Drawing.Point(393, 38);
            this.buttonRequestProviders.Name = "buttonRequestProviders";
            this.buttonRequestProviders.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRequestProviders.Size = new System.Drawing.Size(124, 29);
            this.buttonRequestProviders.TabIndex = 37;
            this.buttonRequestProviders.Text = "Ручной запрос";
            this.buttonRequestProviders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRequestProviders.UseVisualStyleBackColor = true;
            this.buttonRequestProviders.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // buttonDeleteProviders
            // 
            this.buttonDeleteProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeleteProviders.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteProviders.Image")));
            this.buttonDeleteProviders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteProviders.Location = new System.Drawing.Point(653, 38);
            this.buttonDeleteProviders.Name = "buttonDeleteProviders";
            this.buttonDeleteProviders.Padding = new System.Windows.Forms.Padding(2);
            this.buttonDeleteProviders.Size = new System.Drawing.Size(130, 29);
            this.buttonDeleteProviders.TabIndex = 33;
            this.buttonDeleteProviders.Text = "Удалить";
            this.buttonDeleteProviders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteProviders.UseVisualStyleBackColor = true;
            this.buttonDeleteProviders.Click += new System.EventHandler(this.buttonDeleteProviders_Click);
            // 
            // buttonCleanProviders
            // 
            this.buttonCleanProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCleanProviders.Image = ((System.Drawing.Image)(resources.GetObject("buttonCleanProviders.Image")));
            this.buttonCleanProviders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCleanProviders.Location = new System.Drawing.Point(133, 3);
            this.buttonCleanProviders.Name = "buttonCleanProviders";
            this.buttonCleanProviders.Padding = new System.Windows.Forms.Padding(2);
            this.buttonCleanProviders.Size = new System.Drawing.Size(124, 29);
            this.buttonCleanProviders.TabIndex = 28;
            this.buttonCleanProviders.Text = "Очистить";
            this.buttonCleanProviders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCleanProviders.UseVisualStyleBackColor = true;
            this.buttonCleanProviders.Click += new System.EventHandler(this.buttonCleanProviders_Click);
            // 
            // buttonAddProviders
            // 
            this.buttonAddProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddProviders.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddProviders.Image")));
            this.buttonAddProviders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddProviders.Location = new System.Drawing.Point(523, 38);
            this.buttonAddProviders.Name = "buttonAddProviders";
            this.buttonAddProviders.Padding = new System.Windows.Forms.Padding(2);
            this.buttonAddProviders.Size = new System.Drawing.Size(124, 29);
            this.buttonAddProviders.TabIndex = 32;
            this.buttonAddProviders.Text = "Добавить";
            this.buttonAddProviders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddProviders.UseVisualStyleBackColor = true;
            this.buttonAddProviders.Click += new System.EventHandler(this.buttonAddProviders_Click);
            // 
            // comboboxSearchByProviders
            // 
            this.comboboxSearchByProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboboxSearchByProviders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxSearchByProviders.FormattingEnabled = true;
            this.comboboxSearchByProviders.ItemHeight = 13;
            this.comboboxSearchByProviders.Location = new System.Drawing.Point(393, 3);
            this.comboboxSearchByProviders.Name = "comboboxSearchByProviders";
            this.comboboxSearchByProviders.Size = new System.Drawing.Size(124, 21);
            this.comboboxSearchByProviders.TabIndex = 29;
            this.comboboxSearchByProviders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxSearchByProviders_KeyDown);
            // 
            // textBoxSearchProviders
            // 
            this.textBoxSearchProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearchProviders.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSearchProviders.Location = new System.Drawing.Point(520, 0);
            this.textBoxSearchProviders.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearchProviders.MaxLength = 255;
            this.textBoxSearchProviders.Name = "textBoxSearchProviders";
            this.textBoxSearchProviders.Size = new System.Drawing.Size(130, 20);
            this.textBoxSearchProviders.TabIndex = 35;
            this.textBoxSearchProviders.Text = "Поиск🔍";
            this.textBoxSearchProviders.WordWrap = false;
            this.textBoxSearchProviders.Enter += new System.EventHandler(this.textBoxSearchProviders_Enter);
            this.textBoxSearchProviders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchProviders_KeyDown);
            this.textBoxSearchProviders.Leave += new System.EventHandler(this.textBoxSearchProviders_Leave);
            // 
            // buttonSearchCleanProviders
            // 
            this.buttonSearchCleanProviders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchCleanProviders.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchCleanProviders.Image")));
            this.buttonSearchCleanProviders.Location = new System.Drawing.Point(764, 0);
            this.buttonSearchCleanProviders.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchCleanProviders.Name = "buttonSearchCleanProviders";
            this.buttonSearchCleanProviders.Size = new System.Drawing.Size(22, 22);
            this.buttonSearchCleanProviders.TabIndex = 36;
            this.buttonSearchCleanProviders.UseVisualStyleBackColor = true;
            this.buttonSearchCleanProviders.Click += new System.EventHandler(this.buttonSearchCleanProviders_Click);
            // 
            // partsTab
            // 
            this.partsTab.Controls.Add(this.tableLayoutPanel2);
            this.partsTab.Location = new System.Drawing.Point(4, 25);
            this.partsTab.Name = "partsTab";
            this.partsTab.Padding = new System.Windows.Forms.Padding(3);
            this.partsTab.Size = new System.Drawing.Size(792, 421);
            this.partsTab.TabIndex = 1;
            this.partsTab.Text = "Детали";
            this.partsTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.labelRowCountParts, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewParts, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonRefreshParts, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSelectRowParts, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonRequestParts, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonDeleteParts, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonCleanParts, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonAddParts, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboboxSearchByParts, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxSearchParts, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSearchCleanParts, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.button9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonInfoParts, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 415);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // labelRowCountParts
            // 
            this.labelRowCountParts.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.labelRowCountParts, 2);
            this.labelRowCountParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRowCountParts.Location = new System.Drawing.Point(523, 380);
            this.labelRowCountParts.Name = "labelRowCountParts";
            this.labelRowCountParts.Size = new System.Drawing.Size(260, 35);
            this.labelRowCountParts.TabIndex = 11;
            this.labelRowCountParts.Text = "Количество записей: ";
            this.labelRowCountParts.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.AllowUserToAddRows = false;
            this.dataGridViewParts.AllowUserToDeleteRows = false;
            this.dataGridViewParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.tableLayoutPanel2.SetColumnSpan(this.dataGridViewParts, 6);
            this.dataGridViewParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewParts.Location = new System.Drawing.Point(3, 73);
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.ReadOnly = true;
            this.dataGridViewParts.RowHeadersVisible = false;
            this.dataGridViewParts.Size = new System.Drawing.Size(780, 304);
            this.dataGridViewParts.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Производитель";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Цена";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // buttonRefreshParts
            // 
            this.buttonRefreshParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRefreshParts.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefreshParts.Image")));
            this.buttonRefreshParts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefreshParts.Location = new System.Drawing.Point(3, 3);
            this.buttonRefreshParts.Name = "buttonRefreshParts";
            this.buttonRefreshParts.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRefreshParts.Size = new System.Drawing.Size(124, 29);
            this.buttonRefreshParts.TabIndex = 14;
            this.buttonRefreshParts.Text = "Обновить";
            this.buttonRefreshParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefreshParts.UseVisualStyleBackColor = true;
            this.buttonRefreshParts.Click += new System.EventHandler(this.buttonRefreshParts_Click);
            // 
            // buttonSelectRowParts
            // 
            this.buttonSelectRowParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelectRowParts.Location = new System.Drawing.Point(263, 38);
            this.buttonSelectRowParts.Name = "buttonSelectRowParts";
            this.buttonSelectRowParts.Size = new System.Drawing.Size(124, 29);
            this.buttonSelectRowParts.TabIndex = 26;
            this.buttonSelectRowParts.Text = "Выделить строку";
            this.buttonSelectRowParts.UseVisualStyleBackColor = true;
            this.buttonSelectRowParts.Click += new System.EventHandler(this.buttonSelectRowParts_Click);
            // 
            // buttonRequestParts
            // 
            this.buttonRequestParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRequestParts.Image = ((System.Drawing.Image)(resources.GetObject("buttonRequestParts.Image")));
            this.buttonRequestParts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequestParts.Location = new System.Drawing.Point(393, 38);
            this.buttonRequestParts.Name = "buttonRequestParts";
            this.buttonRequestParts.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRequestParts.Size = new System.Drawing.Size(124, 29);
            this.buttonRequestParts.TabIndex = 24;
            this.buttonRequestParts.Text = "Ручной запрос";
            this.buttonRequestParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRequestParts.UseVisualStyleBackColor = true;
            this.buttonRequestParts.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // buttonDeleteParts
            // 
            this.buttonDeleteParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeleteParts.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteParts.Image")));
            this.buttonDeleteParts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteParts.Location = new System.Drawing.Point(653, 38);
            this.buttonDeleteParts.Name = "buttonDeleteParts";
            this.buttonDeleteParts.Padding = new System.Windows.Forms.Padding(2);
            this.buttonDeleteParts.Size = new System.Drawing.Size(130, 29);
            this.buttonDeleteParts.TabIndex = 20;
            this.buttonDeleteParts.Text = "Удалить";
            this.buttonDeleteParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteParts.UseVisualStyleBackColor = true;
            this.buttonDeleteParts.Click += new System.EventHandler(this.buttonDeleteParts_Click);
            // 
            // buttonCleanParts
            // 
            this.buttonCleanParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCleanParts.Image = ((System.Drawing.Image)(resources.GetObject("buttonCleanParts.Image")));
            this.buttonCleanParts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCleanParts.Location = new System.Drawing.Point(133, 3);
            this.buttonCleanParts.Name = "buttonCleanParts";
            this.buttonCleanParts.Padding = new System.Windows.Forms.Padding(2);
            this.buttonCleanParts.Size = new System.Drawing.Size(124, 29);
            this.buttonCleanParts.TabIndex = 15;
            this.buttonCleanParts.Text = "Очистить";
            this.buttonCleanParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCleanParts.UseVisualStyleBackColor = true;
            this.buttonCleanParts.Click += new System.EventHandler(this.buttonCleanParts_Click);
            // 
            // buttonAddParts
            // 
            this.buttonAddParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddParts.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddParts.Image")));
            this.buttonAddParts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddParts.Location = new System.Drawing.Point(523, 38);
            this.buttonAddParts.Name = "buttonAddParts";
            this.buttonAddParts.Padding = new System.Windows.Forms.Padding(2);
            this.buttonAddParts.Size = new System.Drawing.Size(124, 29);
            this.buttonAddParts.TabIndex = 19;
            this.buttonAddParts.Text = "Добавить";
            this.buttonAddParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddParts.UseVisualStyleBackColor = true;
            this.buttonAddParts.Click += new System.EventHandler(this.buttonAddParts_Click);
            // 
            // comboboxSearchByParts
            // 
            this.comboboxSearchByParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboboxSearchByParts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxSearchByParts.FormattingEnabled = true;
            this.comboboxSearchByParts.ItemHeight = 13;
            this.comboboxSearchByParts.Location = new System.Drawing.Point(393, 3);
            this.comboboxSearchByParts.Name = "comboboxSearchByParts";
            this.comboboxSearchByParts.Size = new System.Drawing.Size(124, 21);
            this.comboboxSearchByParts.TabIndex = 16;
            this.comboboxSearchByParts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxSearchByParts_KeyDown);
            // 
            // textBoxSearchParts
            // 
            this.textBoxSearchParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearchParts.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSearchParts.Location = new System.Drawing.Point(520, 0);
            this.textBoxSearchParts.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearchParts.MaxLength = 255;
            this.textBoxSearchParts.Name = "textBoxSearchParts";
            this.textBoxSearchParts.Size = new System.Drawing.Size(130, 20);
            this.textBoxSearchParts.TabIndex = 22;
            this.textBoxSearchParts.Text = "Поиск🔍";
            this.textBoxSearchParts.WordWrap = false;
            this.textBoxSearchParts.Enter += new System.EventHandler(this.textBoxSearchParts_Enter);
            this.textBoxSearchParts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchParts_KeyDown);
            this.textBoxSearchParts.Leave += new System.EventHandler(this.textBoxSearchParts_Leave);
            // 
            // buttonSearchCleanParts
            // 
            this.buttonSearchCleanParts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchCleanParts.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchCleanParts.Image")));
            this.buttonSearchCleanParts.Location = new System.Drawing.Point(764, 0);
            this.buttonSearchCleanParts.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchCleanParts.Name = "buttonSearchCleanParts";
            this.buttonSearchCleanParts.Size = new System.Drawing.Size(22, 22);
            this.buttonSearchCleanParts.TabIndex = 23;
            this.buttonSearchCleanParts.UseVisualStyleBackColor = true;
            this.buttonSearchCleanParts.Click += new System.EventHandler(this.buttonSearchClearParts_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(3, 38);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(2);
            this.button9.Size = new System.Drawing.Size(124, 29);
            this.button9.TabIndex = 17;
            this.button9.Text = "Показать поставщиков";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // buttonInfoParts
            // 
            this.buttonInfoParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInfoParts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInfoParts.Location = new System.Drawing.Point(133, 38);
            this.buttonInfoParts.Name = "buttonInfoParts";
            this.buttonInfoParts.Padding = new System.Windows.Forms.Padding(2);
            this.buttonInfoParts.Size = new System.Drawing.Size(124, 29);
            this.buttonInfoParts.TabIndex = 18;
            this.buttonInfoParts.Text = "Сводка";
            this.buttonInfoParts.UseVisualStyleBackColor = true;
            this.buttonInfoParts.Click += new System.EventHandler(this.buttonInfoParts_Click);
            // 
            // storehouseTab
            // 
            this.storehouseTab.Controls.Add(this.tableLayoutPanel1);
            this.storehouseTab.Location = new System.Drawing.Point(4, 25);
            this.storehouseTab.Name = "storehouseTab";
            this.storehouseTab.Padding = new System.Windows.Forms.Padding(3);
            this.storehouseTab.Size = new System.Drawing.Size(792, 421);
            this.storehouseTab.TabIndex = 0;
            this.storehouseTab.Text = "Склад";
            this.storehouseTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.labelRowCountStorehouse, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewStorehouse, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonRefreshStorehouse, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSelectRowStorehouse, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSearchStorehouse, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboboxSearchByStorehouse, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSearchClearStorehouse, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonRequestStorehouse, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonCleanStorehouse, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonToProvidersStorehouse, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonDeleteStorehouse, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonInfoStorehouse, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddStorehouse, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 415);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // labelRowCountStorehouse
            // 
            this.labelRowCountStorehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRowCountStorehouse.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelRowCountStorehouse, 2);
            this.labelRowCountStorehouse.Location = new System.Drawing.Point(666, 402);
            this.labelRowCountStorehouse.Name = "labelRowCountStorehouse";
            this.labelRowCountStorehouse.Size = new System.Drawing.Size(117, 13);
            this.labelRowCountStorehouse.TabIndex = 11;
            this.labelRowCountStorehouse.Text = "Количество записей: ";
            this.labelRowCountStorehouse.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dataGridViewStorehouse
            // 
            this.dataGridViewStorehouse.AllowUserToAddRows = false;
            this.dataGridViewStorehouse.AllowUserToDeleteRows = false;
            this.dataGridViewStorehouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStorehouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStorehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStorehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nameStoreHouseColumn,
            this.codeColumn,
            this.amountColumn,
            this.manufacturerColumn,
            this.salePriceColumn,
            this.supplierColumn,
            this.priceColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridViewStorehouse, 6);
            this.dataGridViewStorehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStorehouse.Location = new System.Drawing.Point(3, 73);
            this.dataGridViewStorehouse.Name = "dataGridViewStorehouse";
            this.dataGridViewStorehouse.ReadOnly = true;
            this.dataGridViewStorehouse.RowHeadersVisible = false;
            this.dataGridViewStorehouse.Size = new System.Drawing.Size(780, 304);
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
            this.id.Width = 46;
            // 
            // nameStoreHouseColumn
            // 
            this.nameStoreHouseColumn.HeaderText = "Название";
            this.nameStoreHouseColumn.Name = "nameStoreHouseColumn";
            this.nameStoreHouseColumn.ReadOnly = true;
            // 
            // codeColumn
            // 
            this.codeColumn.HeaderText = "Код";
            this.codeColumn.Name = "codeColumn";
            this.codeColumn.ReadOnly = true;
            // 
            // amountColumn
            // 
            this.amountColumn.HeaderText = "Количество";
            this.amountColumn.Name = "amountColumn";
            this.amountColumn.ReadOnly = true;
            // 
            // manufacturerColumn
            // 
            this.manufacturerColumn.HeaderText = "Производитель";
            this.manufacturerColumn.Name = "manufacturerColumn";
            this.manufacturerColumn.ReadOnly = true;
            // 
            // salePriceColumn
            // 
            this.salePriceColumn.HeaderText = "Дата закупки";
            this.salePriceColumn.Name = "salePriceColumn";
            this.salePriceColumn.ReadOnly = true;
            // 
            // supplierColumn
            // 
            this.supplierColumn.HeaderText = "Поставщик";
            this.supplierColumn.Name = "supplierColumn";
            this.supplierColumn.ReadOnly = true;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Цена";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            // 
            // buttonRefreshStorehouse
            // 
            this.buttonRefreshStorehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRefreshStorehouse.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefreshStorehouse.Image")));
            this.buttonRefreshStorehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefreshStorehouse.Location = new System.Drawing.Point(3, 3);
            this.buttonRefreshStorehouse.Name = "buttonRefreshStorehouse";
            this.buttonRefreshStorehouse.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRefreshStorehouse.Size = new System.Drawing.Size(124, 29);
            this.buttonRefreshStorehouse.TabIndex = 0;
            this.buttonRefreshStorehouse.Text = "Обновить";
            this.buttonRefreshStorehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefreshStorehouse.UseVisualStyleBackColor = true;
            this.buttonRefreshStorehouse.Click += new System.EventHandler(this.buttonRefreshStorehouse_Click);
            // 
            // buttonSelectRowStorehouse
            // 
            this.buttonSelectRowStorehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelectRowStorehouse.Location = new System.Drawing.Point(263, 38);
            this.buttonSelectRowStorehouse.Name = "buttonSelectRowStorehouse";
            this.buttonSelectRowStorehouse.Size = new System.Drawing.Size(124, 29);
            this.buttonSelectRowStorehouse.TabIndex = 13;
            this.buttonSelectRowStorehouse.Text = "Выделить строку";
            this.buttonSelectRowStorehouse.UseVisualStyleBackColor = true;
            this.buttonSelectRowStorehouse.Click += new System.EventHandler(this.buttonSelectRowStorehouse_Click);
            // 
            // textBoxSearchStorehouse
            // 
            this.textBoxSearchStorehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearchStorehouse.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSearchStorehouse.Location = new System.Drawing.Point(520, 0);
            this.textBoxSearchStorehouse.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearchStorehouse.MaxLength = 255;
            this.textBoxSearchStorehouse.Name = "textBoxSearchStorehouse";
            this.textBoxSearchStorehouse.Size = new System.Drawing.Size(130, 20);
            this.textBoxSearchStorehouse.TabIndex = 8;
            this.textBoxSearchStorehouse.Text = "Поиск🔍";
            this.textBoxSearchStorehouse.WordWrap = false;
            this.textBoxSearchStorehouse.Enter += new System.EventHandler(this.textBoxSearchStorehouse_Enter);
            this.textBoxSearchStorehouse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchStorehouse_KeyDown);
            this.textBoxSearchStorehouse.Leave += new System.EventHandler(this.textBoxSearchStorehouse_Leave);
            // 
            // comboboxSearchByStorehouse
            // 
            this.comboboxSearchByStorehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboboxSearchByStorehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxSearchByStorehouse.FormattingEnabled = true;
            this.comboboxSearchByStorehouse.ItemHeight = 13;
            this.comboboxSearchByStorehouse.Location = new System.Drawing.Point(393, 3);
            this.comboboxSearchByStorehouse.Name = "comboboxSearchByStorehouse";
            this.comboboxSearchByStorehouse.Size = new System.Drawing.Size(124, 21);
            this.comboboxSearchByStorehouse.TabIndex = 2;
            this.comboboxSearchByStorehouse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxSearchByStorehouse_KeyDown);
            // 
            // buttonSearchClearStorehouse
            // 
            this.buttonSearchClearStorehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchClearStorehouse.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchClearStorehouse.Image")));
            this.buttonSearchClearStorehouse.Location = new System.Drawing.Point(764, 0);
            this.buttonSearchClearStorehouse.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchClearStorehouse.Name = "buttonSearchClearStorehouse";
            this.buttonSearchClearStorehouse.Size = new System.Drawing.Size(22, 22);
            this.buttonSearchClearStorehouse.TabIndex = 9;
            this.buttonSearchClearStorehouse.UseVisualStyleBackColor = true;
            this.buttonSearchClearStorehouse.Click += new System.EventHandler(this.buttonSearchClearStorehouse_Click);
            // 
            // buttonToProvidersStorehouse
            // 
            this.buttonToProvidersStorehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonToProvidersStorehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonToProvidersStorehouse.Location = new System.Drawing.Point(3, 38);
            this.buttonToProvidersStorehouse.Name = "buttonToProvidersStorehouse";
            this.buttonToProvidersStorehouse.Padding = new System.Windows.Forms.Padding(2);
            this.buttonToProvidersStorehouse.Size = new System.Drawing.Size(124, 29);
            this.buttonToProvidersStorehouse.TabIndex = 3;
            this.buttonToProvidersStorehouse.Text = "Перейти к поставщику";
            this.buttonToProvidersStorehouse.UseVisualStyleBackColor = true;
            this.buttonToProvidersStorehouse.Click += new System.EventHandler(this.buttonToProvidersStorehouse_Click);
            // 
            // buttonDeleteStorehouse
            // 
            this.buttonDeleteStorehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeleteStorehouse.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteStorehouse.Image")));
            this.buttonDeleteStorehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteStorehouse.Location = new System.Drawing.Point(653, 38);
            this.buttonDeleteStorehouse.Name = "buttonDeleteStorehouse";
            this.buttonDeleteStorehouse.Padding = new System.Windows.Forms.Padding(2);
            this.buttonDeleteStorehouse.Size = new System.Drawing.Size(130, 29);
            this.buttonDeleteStorehouse.TabIndex = 6;
            this.buttonDeleteStorehouse.Text = "Удалить";
            this.buttonDeleteStorehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteStorehouse.UseVisualStyleBackColor = true;
            this.buttonDeleteStorehouse.Click += new System.EventHandler(this.buttonDeleteStorehouse_Click);
            // 
            // buttonInfoStorehouse
            // 
            this.buttonInfoStorehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInfoStorehouse.Enabled = false;
            this.buttonInfoStorehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInfoStorehouse.Location = new System.Drawing.Point(133, 38);
            this.buttonInfoStorehouse.Name = "buttonInfoStorehouse";
            this.buttonInfoStorehouse.Padding = new System.Windows.Forms.Padding(2);
            this.buttonInfoStorehouse.Size = new System.Drawing.Size(124, 29);
            this.buttonInfoStorehouse.TabIndex = 4;
            this.buttonInfoStorehouse.Text = "Сводка";
            this.buttonInfoStorehouse.UseVisualStyleBackColor = true;
            this.buttonInfoStorehouse.Click += new System.EventHandler(this.buttonInfoStorehouse_Click);
            // 
            // buttonAddStorehouse
            // 
            this.buttonAddStorehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddStorehouse.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddStorehouse.Image")));
            this.buttonAddStorehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddStorehouse.Location = new System.Drawing.Point(523, 38);
            this.buttonAddStorehouse.Name = "buttonAddStorehouse";
            this.buttonAddStorehouse.Padding = new System.Windows.Forms.Padding(2);
            this.buttonAddStorehouse.Size = new System.Drawing.Size(124, 29);
            this.buttonAddStorehouse.TabIndex = 5;
            this.buttonAddStorehouse.Text = "Добавить";
            this.buttonAddStorehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddStorehouse.UseVisualStyleBackColor = true;
            this.buttonAddStorehouse.Click += new System.EventHandler(this.buttonAddStorehouse_Click);
            // 
            // tabs
            // 
            this.tabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabs.Controls.Add(this.storehouseTab);
            this.tabs.Controls.Add(this.partsTab);
            this.tabs.Controls.Add(this.providersTab);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(800, 450);
            this.tabs.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bridgeproviderspartsBindingSource)).EndInit();
            this.providersTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviders)).EndInit();
            this.partsTab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            this.storehouseTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorehouse)).EndInit();
            this.tabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource storehouseBindingSource;
        private AutoPartsDataSetTableAdapters.storehouseTableAdapter storehouseTableAdapter;
        private System.Windows.Forms.BindingSource autoPartsDataSetBindingSource;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private AutoPartsDataSetTableAdapters.providersTableAdapter providersTableAdapter;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private AutoPartsDataSetTableAdapters.partsTableAdapter partsTableAdapter;
        private System.Windows.Forms.BindingSource dealsBindingSource;
        private AutoPartsDataSetTableAdapters.dealsTableAdapter dealsTableAdapter;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.BindingSource bridgeproviderspartsBindingSource;
        private AutoPartsDataSetTableAdapters.bridge_providers_partsTableAdapter bridge_providers_partsTableAdapter;
        private System.Windows.Forms.BindingSource priceviewBindingSource;
        private AutoPartsDataSetTableAdapters.priceviewTableAdapter priceviewTableAdapter;
        public AutoPartsDataSet autoPartsDataSet;
        public System.Windows.Forms.TabPage providersTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelRowCountProviders;
        private System.Windows.Forms.Button buttonRefreshProviders;
        private System.Windows.Forms.Button buttonSelectRowProviders;
        private System.Windows.Forms.DataGridView dataGridViewProviders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button buttonRequestProviders;
        private System.Windows.Forms.Button buttonDeleteProviders;
        private System.Windows.Forms.Button buttonCleanProviders;
        private System.Windows.Forms.Button buttonAddProviders;
        private System.Windows.Forms.ComboBox comboboxSearchByProviders;
        private System.Windows.Forms.TextBox textBoxSearchProviders;
        private System.Windows.Forms.Button buttonSearchCleanProviders;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonInfoProviders;
        public System.Windows.Forms.TabPage partsTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelRowCountParts;
        private System.Windows.Forms.DataGridView dataGridViewParts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button buttonRefreshParts;
        private System.Windows.Forms.Button buttonSelectRowParts;
        private System.Windows.Forms.Button buttonRequestParts;
        private System.Windows.Forms.Button buttonDeleteParts;
        private System.Windows.Forms.Button buttonCleanParts;
        private System.Windows.Forms.Button buttonAddParts;
        private System.Windows.Forms.ComboBox comboboxSearchByParts;
        private System.Windows.Forms.TextBox textBoxSearchParts;
        private System.Windows.Forms.Button buttonSearchCleanParts;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonInfoParts;
        public System.Windows.Forms.TabPage storehouseTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelRowCountStorehouse;
        private System.Windows.Forms.DataGridView dataGridViewStorehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStoreHouseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.Button buttonRefreshStorehouse;
        private System.Windows.Forms.Button buttonSelectRowStorehouse;
        public System.Windows.Forms.TextBox textBoxSearchStorehouse;
        public System.Windows.Forms.ComboBox comboboxSearchByStorehouse;
        private System.Windows.Forms.Button buttonSearchClearStorehouse;
        private System.Windows.Forms.Button buttonRequestStorehouse;
        private System.Windows.Forms.Button buttonCleanStorehouse;
        private System.Windows.Forms.Button buttonToProvidersStorehouse;
        private System.Windows.Forms.Button buttonDeleteStorehouse;
        private System.Windows.Forms.Button buttonInfoStorehouse;
        private System.Windows.Forms.Button buttonAddStorehouse;
        public System.Windows.Forms.TabControl tabs;
    }
}

