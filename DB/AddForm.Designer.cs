namespace DB
{
    partial class AddForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelProvider = new System.Windows.Forms.Label();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.buttonSetCurrentDate = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonAddProvider = new System.Windows.Forms.Button();
            this.buttonRecordRow = new System.Windows.Forms.Button();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            this.autoPartsDataSet = new DB.AutoPartsDataSet();
            this.partsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableAdapter = new DB.AutoPartsDataSetTableAdapters.partsTableAdapter();
            this.bridgeproviderspartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bridge_providers_partsTableAdapter = new DB.AutoPartsDataSetTableAdapters.bridge_providers_partsTableAdapter();
            this.dealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dealsTableAdapter = new DB.AutoPartsDataSetTableAdapters.dealsTableAdapter();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providersTableAdapter = new DB.AutoPartsDataSetTableAdapters.providersTableAdapter();
            this.buttonAddPart = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.pictureTitleError = new System.Windows.Forms.PictureBox();
            this.picturePartsCountError = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureProviderError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bridgeproviderspartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitleError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePartsCountError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProviderError)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(20, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(109, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Название запчасти:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(132, 92);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(182, 20);
            this.textBoxPrice.TabIndex = 2;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(90, 95);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 13);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Цена:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(46, 130);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(80, 13);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Дата закупки:";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(132, 162);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(182, 20);
            this.textBoxCount.TabIndex = 4;
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            this.textBoxCount.Leave += new System.EventHandler(this.textBoxCount_Leave);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(2, 165);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(124, 13);
            this.labelCount.TabIndex = 8;
            this.labelCount.Text = "Количество запчастей:";
            // 
            // labelProvider
            // 
            this.labelProvider.AutoSize = true;
            this.labelProvider.Location = new System.Drawing.Point(58, 202);
            this.labelProvider.Name = "labelProvider";
            this.labelProvider.Size = new System.Drawing.Size(68, 13);
            this.labelProvider.TabIndex = 10;
            this.labelProvider.Text = "Поставщик:";
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(132, 199);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(182, 21);
            this.comboBoxProvider.TabIndex = 5;
            this.comboBoxProvider.TextChanged += new System.EventHandler(this.comboBoxProvider_TextChanged);
            // 
            // buttonSetCurrentDate
            // 
            this.buttonSetCurrentDate.Location = new System.Drawing.Point(342, 125);
            this.buttonSetCurrentDate.Name = "buttonSetCurrentDate";
            this.buttonSetCurrentDate.Size = new System.Drawing.Size(136, 23);
            this.buttonSetCurrentDate.TabIndex = 11;
            this.buttonSetCurrentDate.Text = "Сегодня";
            this.buttonSetCurrentDate.UseVisualStyleBackColor = true;
            this.buttonSetCurrentDate.Click += new System.EventHandler(this.buttonSetCurrentDate_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy.MM.dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(132, 127);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker.TabIndex = 12;
            this.dateTimePicker.Value = new System.DateTime(2018, 10, 30, 0, 5, 20, 0);
            // 
            // buttonAddProvider
            // 
            this.buttonAddProvider.Location = new System.Drawing.Point(342, 197);
            this.buttonAddProvider.Name = "buttonAddProvider";
            this.buttonAddProvider.Size = new System.Drawing.Size(136, 23);
            this.buttonAddProvider.TabIndex = 13;
            this.buttonAddProvider.Text = "Добавить поставщика";
            this.buttonAddProvider.UseVisualStyleBackColor = true;
            // 
            // buttonRecordRow
            // 
            this.buttonRecordRow.Enabled = false;
            this.buttonRecordRow.Location = new System.Drawing.Point(132, 254);
            this.buttonRecordRow.Name = "buttonRecordRow";
            this.buttonRecordRow.Size = new System.Drawing.Size(117, 23);
            this.buttonRecordRow.TabIndex = 14;
            this.buttonRecordRow.Text = "Добавить запись";
            this.buttonRecordRow.UseVisualStyleBackColor = true;
            this.buttonRecordRow.Click += new System.EventHandler(this.buttonRecordRow_Click);
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Location = new System.Drawing.Point(284, 254);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(117, 23);
            this.buttonCloseForm.TabIndex = 15;
            this.buttonCloseForm.Text = "Закрыть";
            this.buttonCloseForm.UseVisualStyleBackColor = true;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // autoPartsDataSet
            // 
            this.autoPartsDataSet.DataSetName = "AutoPartsDataSet";
            this.autoPartsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataMember = "parts";
            this.partsBindingSource.DataSource = this.autoPartsDataSet;
            // 
            // partsTableAdapter
            // 
            this.partsTableAdapter.ClearBeforeFill = true;
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
            // dealsBindingSource
            // 
            this.dealsBindingSource.DataMember = "deals";
            this.dealsBindingSource.DataSource = this.autoPartsDataSet;
            // 
            // dealsTableAdapter
            // 
            this.dealsTableAdapter.ClearBeforeFill = true;
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "providers";
            this.providersBindingSource.DataSource = this.autoPartsDataSet;
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAddPart
            // 
            this.buttonAddPart.Location = new System.Drawing.Point(342, 22);
            this.buttonAddPart.Name = "buttonAddPart";
            this.buttonAddPart.Size = new System.Drawing.Size(136, 23);
            this.buttonAddPart.TabIndex = 16;
            this.buttonAddPart.Text = "Добавить запчасть";
            this.buttonAddPart.UseVisualStyleBackColor = true;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxTitle.Location = new System.Drawing.Point(132, 24);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(182, 20);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyDown);
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Location = new System.Drawing.Point(37, 60);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(89, 13);
            this.labelManufacturer.TabIndex = 2;
            this.labelManufacturer.Text = "Производитель:";
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxManufacturer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxManufacturer.Location = new System.Drawing.Point(132, 57);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.ReadOnly = true;
            this.textBoxManufacturer.Size = new System.Drawing.Size(182, 20);
            this.textBoxManufacturer.TabIndex = 1;
            // 
            // pictureTitleError
            // 
            this.pictureTitleError.Image = ((System.Drawing.Image)(resources.GetObject("pictureTitleError.Image")));
            this.pictureTitleError.Location = new System.Drawing.Point(321, 26);
            this.pictureTitleError.Name = "pictureTitleError";
            this.pictureTitleError.Size = new System.Drawing.Size(16, 16);
            this.pictureTitleError.TabIndex = 17;
            this.pictureTitleError.TabStop = false;
            this.toolTip.SetToolTip(this.pictureTitleError, "Эта деталь отсутствует в спике доступных. Необходимо ее добавить, или выбрать из " +
        "доступных");
            // 
            // picturePartsCountError
            // 
            this.picturePartsCountError.Image = ((System.Drawing.Image)(resources.GetObject("picturePartsCountError.Image")));
            this.picturePartsCountError.Location = new System.Drawing.Point(320, 164);
            this.picturePartsCountError.Name = "picturePartsCountError";
            this.picturePartsCountError.Size = new System.Drawing.Size(16, 16);
            this.picturePartsCountError.TabIndex = 18;
            this.picturePartsCountError.TabStop = false;
            this.toolTip.SetToolTip(this.picturePartsCountError, "Введенное значение не может быть преобразовано в число, менее нуля, либо является" +
        " отрицательным");
            // 
            // pictureProviderError
            // 
            this.pictureProviderError.Image = ((System.Drawing.Image)(resources.GetObject("pictureProviderError.Image")));
            this.pictureProviderError.Location = new System.Drawing.Point(321, 202);
            this.pictureProviderError.Name = "pictureProviderError";
            this.pictureProviderError.Size = new System.Drawing.Size(16, 16);
            this.pictureProviderError.TabIndex = 19;
            this.pictureProviderError.TabStop = false;
            this.toolTip.SetToolTip(this.pictureProviderError, "Для этой запчасти отсутствуют поставщики. Добавьте их или проверьте данные");
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 299);
            this.Controls.Add(this.pictureProviderError);
            this.Controls.Add(this.picturePartsCountError);
            this.Controls.Add(this.pictureTitleError);
            this.Controls.Add(this.buttonAddPart);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.buttonRecordRow);
            this.Controls.Add(this.buttonAddProvider);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonSetCurrentDate);
            this.Controls.Add(this.comboBoxProvider);
            this.Controls.Add(this.labelProvider);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxManufacturer);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "AddForm";
            this.Text = "Добавление записи";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoPartsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bridgeproviderspartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitleError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePartsCountError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProviderError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelProvider;
        public System.Windows.Forms.ComboBox comboBoxProvider;
        private System.Windows.Forms.Button buttonSetCurrentDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonAddProvider;
        private System.Windows.Forms.Button buttonRecordRow;
        private System.Windows.Forms.Button buttonCloseForm;
        private AutoPartsDataSet autoPartsDataSet;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private AutoPartsDataSetTableAdapters.partsTableAdapter partsTableAdapter;
        private System.Windows.Forms.BindingSource bridgeproviderspartsBindingSource;
        private AutoPartsDataSetTableAdapters.bridge_providers_partsTableAdapter bridge_providers_partsTableAdapter;
        private System.Windows.Forms.BindingSource dealsBindingSource;
        private AutoPartsDataSetTableAdapters.dealsTableAdapter dealsTableAdapter;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private AutoPartsDataSetTableAdapters.providersTableAdapter providersTableAdapter;
        private System.Windows.Forms.Button buttonAddPart;
        public System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelManufacturer;
        public System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.PictureBox pictureTitleError;
        private System.Windows.Forms.PictureBox picturePartsCountError;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox pictureProviderError;
    }
}