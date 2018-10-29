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
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelProvider = new System.Windows.Forms.Label();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.buttonSetCurrentDate = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(132, 24);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(182, 20);
            this.textBoxTitle.TabIndex = 0;
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
            this.textBoxManufacturer.Size = new System.Drawing.Size(182, 20);
            this.textBoxManufacturer.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(132, 92);
            this.textBoxPrice.Name = "textBoxPrice";
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
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(132, 199);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(182, 21);
            this.comboBoxProvider.TabIndex = 5;
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
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(132, 127);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker.TabIndex = 12;
            this.dateTimePicker.Value = new System.DateTime(2018, 10, 30, 0, 5, 20, 0);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 362);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelProvider;
        public System.Windows.Forms.TextBox textBoxManufacturer;
        public System.Windows.Forms.ComboBox comboBoxProvider;
        private System.Windows.Forms.Button buttonSetCurrentDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}