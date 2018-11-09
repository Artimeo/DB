namespace DB
{
    partial class AddProvidersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProvidersForm));
            this.picturePhoneError = new System.Windows.Forms.PictureBox();
            this.pictureAddressError = new System.Windows.Forms.PictureBox();
            this.pictureTitleError = new System.Windows.Forms.PictureBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRecordRow = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoneError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddressError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitleError)).BeginInit();
            this.SuspendLayout();
            // 
            // picturePhoneError
            // 
            this.picturePhoneError.Image = ((System.Drawing.Image)(resources.GetObject("picturePhoneError.Image")));
            this.picturePhoneError.Location = new System.Drawing.Point(280, 97);
            this.picturePhoneError.Name = "picturePhoneError";
            this.picturePhoneError.Size = new System.Drawing.Size(16, 16);
            this.picturePhoneError.TabIndex = 31;
            this.picturePhoneError.TabStop = false;
            this.toolTip.SetToolTip(this.picturePhoneError, "Введенное значение не является телефонным номером");
            this.picturePhoneError.Visible = false;
            // 
            // pictureAddressError
            // 
            this.pictureAddressError.Image = ((System.Drawing.Image)(resources.GetObject("pictureAddressError.Image")));
            this.pictureAddressError.Location = new System.Drawing.Point(280, 57);
            this.pictureAddressError.Name = "pictureAddressError";
            this.pictureAddressError.Size = new System.Drawing.Size(16, 16);
            this.pictureAddressError.TabIndex = 30;
            this.pictureAddressError.TabStop = false;
            this.toolTip.SetToolTip(this.pictureAddressError, "Необходимо заполнить поле");
            // 
            // pictureTitleError
            // 
            this.pictureTitleError.Image = ((System.Drawing.Image)(resources.GetObject("pictureTitleError.Image")));
            this.pictureTitleError.Location = new System.Drawing.Point(280, 16);
            this.pictureTitleError.Name = "pictureTitleError";
            this.pictureTitleError.Size = new System.Drawing.Size(16, 16);
            this.pictureTitleError.TabIndex = 29;
            this.pictureTitleError.TabStop = false;
            this.toolTip.SetToolTip(this.pictureTitleError, "Необходимо заполнить поле");
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(12, 100);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 13);
            this.labelPhone.TabIndex = 28;
            this.labelPhone.Text = "Телефон:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(12, 60);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(41, 13);
            this.labelAddress.TabIndex = 27;
            this.labelAddress.Text = "Адрес:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(60, 13);
            this.labelTitle.TabIndex = 26;
            this.labelTitle.Text = "Название:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(188, 143);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 25;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonRecordRow
            // 
            this.buttonRecordRow.Enabled = false;
            this.buttonRecordRow.Location = new System.Drawing.Point(61, 143);
            this.buttonRecordRow.Name = "buttonRecordRow";
            this.buttonRecordRow.Size = new System.Drawing.Size(75, 23);
            this.buttonRecordRow.TabIndex = 24;
            this.buttonRecordRow.Text = "Добавить";
            this.buttonRecordRow.UseVisualStyleBackColor = true;
            this.buttonRecordRow.Click += new System.EventHandler(this.buttonRecordRow_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(77, 95);
            this.textBoxPhone.MaxLength = 14;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(195, 20);
            this.textBoxPhone.TabIndex = 23;
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged_Leave);
            this.textBoxPhone.Leave += new System.EventHandler(this.textBoxPhone_TextChanged_Leave);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(77, 55);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(195, 20);
            this.textBoxAddress.TabIndex = 22;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged_Leave);
            this.textBoxAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEnterSelectNextControl);
            this.textBoxAddress.Leave += new System.EventHandler(this.textBoxAddress_TextChanged_Leave);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(77, 15);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(195, 20);
            this.textBoxTitle.TabIndex = 21;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged_Leave);
            this.textBoxTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownEnterSelectNextControl);
            this.textBoxTitle.Leave += new System.EventHandler(this.textBoxTitle_TextChanged_Leave);
            // 
            // AddProvidersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 188);
            this.Controls.Add(this.picturePhoneError);
            this.Controls.Add(this.pictureAddressError);
            this.Controls.Add(this.pictureTitleError);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonRecordRow);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "AddProvidersForm";
            this.Text = "AddProvidersForm";
            ((System.ComponentModel.ISupportInitialize)(this.picturePhoneError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAddressError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTitleError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePhoneError;
        private System.Windows.Forms.PictureBox pictureAddressError;
        private System.Windows.Forms.PictureBox pictureTitleError;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonRecordRow;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ToolTip toolTip;
    }
}