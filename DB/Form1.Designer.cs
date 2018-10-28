namespace DB
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.autoPartsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoPartsDataSet = new DB.AutoPartsDataSet();
            this.tabs = new System.Windows.Forms.TabControl();
            this.storehouseTab = new System.Windows.Forms.TabPage();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.buttonSearchClear = new System.Windows.Forms.Button();
            this.buttonRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSet)).BeginInit();
            this.tabs.SuspendLayout();
            this.storehouseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // autoPartsDataSetBindingSource
            // 
            this.autoPartsDataSetBindingSource.DataSource = this.autoPartsDataSet;
            this.autoPartsDataSetBindingSource.Position = 0;
            // 
            // autoPartsDataSet
            // 
            this.autoPartsDataSet.DataSetName = "AutoPartsDataSet";
            this.autoPartsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.storehouseTab.Controls.Add(this.buttonRequest);
            this.storehouseTab.Controls.Add(this.buttonSearchClear);
            this.storehouseTab.Controls.Add(this.textBoxSearch);
            this.storehouseTab.Controls.Add(this.dataGridView1);
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
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.Gray;
            this.textBoxSearch.Location = new System.Drawing.Point(615, 11);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSearch.MaxLength = 255;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(150, 20);
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.Text = "Поиск🔍";
            this.textBoxSearch.WordWrap = false;
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.autoPartsDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 317);
            this.dataGridView1.TabIndex = 7;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(708, 40);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Padding = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Size = new System.Drawing.Size(79, 28);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(615, 40);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Padding = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Size = new System.Drawing.Size(87, 28);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(164, 40);
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
            this.button1.Location = new System.Drawing.Point(11, 40);
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
            "По цене",
            "По ...",
            "По ..."});
            this.comboboxSearchBy.Location = new System.Drawing.Point(406, 11);
            this.comboboxSearchBy.Name = "comboboxSearchBy";
            this.comboboxSearchBy.Size = new System.Drawing.Size(121, 21);
            this.comboboxSearchBy.TabIndex = 2;
            // 
            // buttonClean
            // 
            this.buttonClean.Image = ((System.Drawing.Image)(resources.GetObject("buttonClean.Image")));
            this.buttonClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClean.Location = new System.Drawing.Point(104, 6);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Padding = new System.Windows.Forms.Padding(2);
            this.buttonClean.Size = new System.Drawing.Size(86, 28);
            this.buttonClean.TabIndex = 1;
            this.buttonClean.Text = "Очистить";
            this.buttonClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClean.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("buttonRefresh.Image")));
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(11, 6);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRefresh.Size = new System.Drawing.Size(87, 28);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefresh.UseVisualStyleBackColor = true;
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
            // buttonSearchClear
            // 
            this.buttonSearchClear.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearchClear.Image")));
            this.buttonSearchClear.Location = new System.Drawing.Point(765, 10);
            this.buttonSearchClear.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchClear.Name = "buttonSearchClear";
            this.buttonSearchClear.Size = new System.Drawing.Size(22, 22);
            this.buttonSearchClear.TabIndex = 9;
            this.buttonSearchClear.UseVisualStyleBackColor = true;
            // 
            // buttonRequest
            // 
            this.buttonRequest.Image = ((System.Drawing.Image)(resources.GetObject("buttonRequest.Image")));
            this.buttonRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRequest.Location = new System.Drawing.Point(483, 40);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Padding = new System.Windows.Forms.Padding(2);
            this.buttonRequest.Size = new System.Drawing.Size(110, 28);
            this.buttonRequest.TabIndex = 10;
            this.buttonRequest.Text = "Ручной запрос";
            this.buttonRequest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRequest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSet)).EndInit();
            this.tabs.ResumeLayout(false);
            this.storehouseTab.ResumeLayout(false);
            this.storehouseTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource autoPartsDataSetBindingSource;
        private AutoPartsDataSet autoPartsDataSet;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearchClear;
        private System.Windows.Forms.Button buttonRequest;
    }
}

