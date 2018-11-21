namespace DB
{
    partial class AddPriceHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPriceHistoryForm));
            this.pictureNewPriceError = new System.Windows.Forms.PictureBox();
            this.pictureTitleError = new System.Windows.Forms.PictureBox();
            this.labelNewPrice = new System.Windows.Forms.Label();
            this.labelOldPrice = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRecordRow = new System.Windows.Forms.Button();
            this.textBoxNewPrice = new System.Windows.Forms.TextBox();
            this.textBoxOldPrice = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonSetCurrentDate = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureOldPriceError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNewPriceError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitleError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOldPriceError)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureNewPriceError
            // 
            this.pictureNewPriceError.Image = ((System.Drawing.Image)(resources.GetObject("pictureNewPriceError.Image")));
            this.pictureNewPriceError.Location = new System.Drawing.Point(294, 132);
            this.pictureNewPriceError.Name = "pictureNewPriceError";
            this.pictureNewPriceError.Size = new System.Drawing.Size(16, 16);
            this.pictureNewPriceError.TabIndex = 42;
            this.pictureNewPriceError.TabStop = false;
            this.toolTip.SetToolTip(this.pictureNewPriceError, "Цена отсутствует либо неправильно введена");
            // 
            // pictureTitleError
            // 
            this.pictureTitleError.Image = ((System.Drawing.Image)(resources.GetObject("pictureTitleError.Image")));
            this.pictureTitleError.Location = new System.Drawing.Point(294, 16);
            this.pictureTitleError.Name = "pictureTitleError";
            this.pictureTitleError.Size = new System.Drawing.Size(16, 16);
            this.pictureTitleError.TabIndex = 40;
            this.pictureTitleError.TabStop = false;
            this.toolTip.SetToolTip(this.pictureTitleError, "Выберите запчасть из доступных");
            // 
            // labelNewPrice
            // 
            this.labelNewPrice.AutoSize = true;
            this.labelNewPrice.Location = new System.Drawing.Point(16, 133);
            this.labelNewPrice.Name = "labelNewPrice";
            this.labelNewPrice.Size = new System.Drawing.Size(69, 13);
            this.labelNewPrice.TabIndex = 39;
            this.labelNewPrice.Text = "Новая цена:";
            // 
            // labelOldPrice
            // 
            this.labelOldPrice.AutoSize = true;
            this.labelOldPrice.Location = new System.Drawing.Point(3, 58);
            this.labelOldPrice.Name = "labelOldPrice";
            this.labelOldPrice.Size = new System.Drawing.Size(82, 13);
            this.labelOldPrice.TabIndex = 38;
            this.labelOldPrice.Text = "Текущая цена:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(25, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(60, 13);
            this.labelTitle.TabIndex = 37;
            this.labelTitle.Text = "Название:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(192, 165);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 36;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // buttonRecordRow
            // 
            this.buttonRecordRow.Enabled = false;
            this.buttonRecordRow.Location = new System.Drawing.Point(65, 165);
            this.buttonRecordRow.Name = "buttonRecordRow";
            this.buttonRecordRow.Size = new System.Drawing.Size(75, 23);
            this.buttonRecordRow.TabIndex = 35;
            this.buttonRecordRow.Text = "Изменить";
            this.buttonRecordRow.UseVisualStyleBackColor = true;
            this.buttonRecordRow.Click += new System.EventHandler(this.buttonRecordRow_Click);
            // 
            // textBoxNewPrice
            // 
            this.textBoxNewPrice.Location = new System.Drawing.Point(91, 130);
            this.textBoxNewPrice.MaxLength = 14;
            this.textBoxNewPrice.Name = "textBoxNewPrice";
            this.textBoxNewPrice.Size = new System.Drawing.Size(195, 20);
            this.textBoxNewPrice.TabIndex = 34;
            this.textBoxNewPrice.TextChanged += new System.EventHandler(this.textBoxNewPrice_TextChanged);
            this.textBoxNewPrice.Leave += new System.EventHandler(this.textBoxNewPrice_Leave);
            // 
            // textBoxOldPrice
            // 
            this.textBoxOldPrice.Location = new System.Drawing.Point(91, 55);
            this.textBoxOldPrice.Name = "textBoxOldPrice";
            this.textBoxOldPrice.ReadOnly = true;
            this.textBoxOldPrice.Size = new System.Drawing.Size(195, 20);
            this.textBoxOldPrice.TabIndex = 33;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxTitle.Location = new System.Drawing.Point(91, 15);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(195, 20);
            this.textBoxTitle.TabIndex = 32;
            this.textBoxTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTitle_KeyDown);
            this.textBoxTitle.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy.MM.dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(91, 93);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker.TabIndex = 45;
            this.dateTimePicker.Value = new System.DateTime(2018, 10, 30, 0, 5, 20, 0);
            // 
            // buttonSetCurrentDate
            // 
            this.buttonSetCurrentDate.Location = new System.Drawing.Point(207, 92);
            this.buttonSetCurrentDate.Name = "buttonSetCurrentDate";
            this.buttonSetCurrentDate.Size = new System.Drawing.Size(79, 23);
            this.buttonSetCurrentDate.TabIndex = 44;
            this.buttonSetCurrentDate.Text = "Сегодня";
            this.buttonSetCurrentDate.UseVisualStyleBackColor = true;
            this.buttonSetCurrentDate.Click += new System.EventHandler(this.buttonSetCurrentDate_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 97);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(73, 13);
            this.labelDate.TabIndex = 43;
            this.labelDate.Text = "Действует с:";
            // 
            // pictureOldPriceError
            // 
            this.pictureOldPriceError.Image = ((System.Drawing.Image)(resources.GetObject("pictureOldPriceError.Image")));
            this.pictureOldPriceError.Location = new System.Drawing.Point(294, 58);
            this.pictureOldPriceError.Name = "pictureOldPriceError";
            this.pictureOldPriceError.Size = new System.Drawing.Size(16, 16);
            this.pictureOldPriceError.TabIndex = 46;
            this.pictureOldPriceError.TabStop = false;
            this.toolTip.SetToolTip(this.pictureOldPriceError, "Не найдена цена для данной запчасти");
            // 
            // AddPriceHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 204);
            this.Controls.Add(this.pictureOldPriceError);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonSetCurrentDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.pictureNewPriceError);
            this.Controls.Add(this.pictureTitleError);
            this.Controls.Add(this.labelNewPrice);
            this.Controls.Add(this.labelOldPrice);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonRecordRow);
            this.Controls.Add(this.textBoxNewPrice);
            this.Controls.Add(this.textBoxOldPrice);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "AddPriceHistoryForm";
            this.Text = "Изменить цену";
            ((System.ComponentModel.ISupportInitialize)(this.pictureNewPriceError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitleError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOldPriceError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureNewPriceError;
        private System.Windows.Forms.PictureBox pictureTitleError;
        private System.Windows.Forms.Label labelNewPrice;
        private System.Windows.Forms.Label labelOldPrice;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRecordRow;
        private System.Windows.Forms.TextBox textBoxNewPrice;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonSetCurrentDate;
        private System.Windows.Forms.Label labelDate;
        public System.Windows.Forms.TextBox textBoxOldPrice;
        public System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox pictureOldPriceError;
    }
}