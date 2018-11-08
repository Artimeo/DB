namespace DB
{
    partial class AddPartsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPartsForm));
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonRecordRow = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.pictureTitleError = new System.Windows.Forms.PictureBox();
            this.pictureManufacturerError = new System.Windows.Forms.PictureBox();
            this.picturePriceError = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitleError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureManufacturerError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePriceError)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(109, 16);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(160, 20);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged_Leave);
            this.textBoxTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEnterSelectNextControl);
            this.textBoxTitle.Leave += new System.EventHandler(this.textBoxTitle_TextChanged_Leave);
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Location = new System.Drawing.Point(109, 56);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(160, 20);
            this.textBoxManufacturer.TabIndex = 1;
            this.textBoxManufacturer.TextChanged += new System.EventHandler(this.textBoxManufacturer_TextChanged_Leave);
            this.textBoxManufacturer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEnterSelectNextControl);
            this.textBoxManufacturer.Leave += new System.EventHandler(this.textBoxManufacturer_TextChanged_Leave);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(109, 96);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(160, 20);
            this.textBoxPrice.TabIndex = 2;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            this.textBoxPrice.Leave += new System.EventHandler(this.textBoxPrice_Leave);
            // 
            // buttonRecordRow
            // 
            this.buttonRecordRow.Enabled = false;
            this.buttonRecordRow.Location = new System.Drawing.Point(37, 146);
            this.buttonRecordRow.Name = "buttonRecordRow";
            this.buttonRecordRow.Size = new System.Drawing.Size(75, 23);
            this.buttonRecordRow.TabIndex = 3;
            this.buttonRecordRow.Text = "Добавить";
            this.buttonRecordRow.UseVisualStyleBackColor = true;
            this.buttonRecordRow.Click += new System.EventHandler(this.buttonRecordRow_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(164, 146);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(11, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(60, 13);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Название:";
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Location = new System.Drawing.Point(11, 59);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(89, 13);
            this.labelManufacturer.TabIndex = 6;
            this.labelManufacturer.Text = "Производитель:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(11, 99);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 13);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Цена:";
            // 
            // pictureTitleError
            // 
            this.pictureTitleError.Image = ((System.Drawing.Image)(resources.GetObject("pictureTitleError.Image")));
            this.pictureTitleError.Location = new System.Drawing.Point(277, 17);
            this.pictureTitleError.Name = "pictureTitleError";
            this.pictureTitleError.Size = new System.Drawing.Size(16, 16);
            this.pictureTitleError.TabIndex = 18;
            this.pictureTitleError.TabStop = false;
            this.toolTip.SetToolTip(this.pictureTitleError, "Необходимо заполнить поле");
            // 
            // pictureManufacturerError
            // 
            this.pictureManufacturerError.Image = ((System.Drawing.Image)(resources.GetObject("pictureManufacturerError.Image")));
            this.pictureManufacturerError.Location = new System.Drawing.Point(277, 58);
            this.pictureManufacturerError.Name = "pictureManufacturerError";
            this.pictureManufacturerError.Size = new System.Drawing.Size(16, 16);
            this.pictureManufacturerError.TabIndex = 19;
            this.pictureManufacturerError.TabStop = false;
            this.toolTip.SetToolTip(this.pictureManufacturerError, "Необходимо заполнить поле");
            // 
            // picturePriceError
            // 
            this.picturePriceError.Image = ((System.Drawing.Image)(resources.GetObject("picturePriceError.Image")));
            this.picturePriceError.Location = new System.Drawing.Point(277, 98);
            this.picturePriceError.Name = "picturePriceError";
            this.picturePriceError.Size = new System.Drawing.Size(16, 16);
            this.picturePriceError.TabIndex = 20;
            this.picturePriceError.TabStop = false;
            this.toolTip.SetToolTip(this.picturePriceError, "Введенное значение не может быть преобразовано в число, менее нуля, либо является" +
        " отрицательным");
            // 
            // AddPartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 194);
            this.Controls.Add(this.picturePriceError);
            this.Controls.Add(this.pictureManufacturerError);
            this.Controls.Add(this.pictureTitleError);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelManufacturer);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonRecordRow);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxManufacturer);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "AddPartsForm";
            this.Text = "Добавить запчасть";
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitleError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureManufacturerError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePriceError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonRecordRow;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.PictureBox pictureTitleError;
        private System.Windows.Forms.PictureBox pictureManufacturerError;
        private System.Windows.Forms.PictureBox picturePriceError;
        private System.Windows.Forms.ToolTip toolTip;
    }
}