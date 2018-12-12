namespace DB
{
    partial class AddRequest
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
            this.textBoxRequest = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridViewRequest = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.AllowDrop = true;
            this.textBoxRequest.Location = new System.Drawing.Point(0, 297);
            this.textBoxRequest.Multiline = true;
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.Size = new System.Drawing.Size(475, 178);
            this.textBoxRequest.TabIndex = 0;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(526, 339);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(98, 33);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(526, 402);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(98, 32);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridViewRequest
            // 
            this.dataGridViewRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequest.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRequest.Name = "dataGridViewRequest";
            this.dataGridViewRequest.Size = new System.Drawing.Size(689, 297);
            this.dataGridViewRequest.TabIndex = 3;
            // 
            // AddRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 475);
            this.Controls.Add(this.dataGridViewRequest);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxRequest);
            this.Name = "AddRequest";
            this.Text = "AddRequest";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRequest;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridViewRequest;
    }
}