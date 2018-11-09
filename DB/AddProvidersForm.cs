using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class AddProvidersForm : Form
    {
        public const string connectionString = "Data Source=ORANGE\\MSSQLEXPRESS2017;Initial Catalog=AutoParts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        MainForm parentMainForm;
        AddDealsForm parentAddDealsForm;

        public AddProvidersForm(MainForm mainForm)
        {
            parentMainForm = mainForm;
            InitializeComponent();
        }

        public AddProvidersForm(AddDealsForm addDealsForm)
        {
            parentAddDealsForm = addDealsForm;
            InitializeComponent();
        }

        public bool isAllowedRecordRow()
        {
            if (pictureTitleError.Visible == false && pictureAddressError.Visible == false && picturePhoneError.Visible == false)
            {
                buttonRecordRow.Enabled = true;
                return true;
            }
            else
            {
                buttonRecordRow.Enabled = false;
                return false;
            }
        }

        private void KeyDownEnterSelectNextControl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                SendKeys.Send("{tab}");
            }
        }


        private void textBoxTitle_TextChanged_Leave(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "") pictureTitleError.Show();
            else pictureTitleError.Hide();
            isAllowedRecordRow();
        }

        private void textBoxAddress_TextChanged_Leave(object sender, EventArgs e)
        {
            if (textBoxAddress.Text == "") pictureAddressError.Show();
            else pictureAddressError.Hide();
            isAllowedRecordRow();
        }

        private void textBoxPhone_TextChanged_Leave(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == "")
            {
                picturePhoneError.Hide();
                return;
            }
            else
            {
                
                for (int i = 0; i < textBoxPhone.Text.Length; i++)
                {
                    if (char.IsDigit(textBoxPhone.Text[i]))
                    {
                        continue;
                    }
                    else if (i == 0 && textBoxPhone.Text[i] == '+')
                    {
                        continue;
                    }
                    else
                    {
                        picturePhoneError.Show();
                        return;
                    }
                }
                picturePhoneError.Hide();
                isAllowedRecordRow();
            }
        }


        private void buttonRecordRow_Click(object sender, EventArgs e)
        {
            if (isAllowedRecordRow())
            {
                string expression;

                if (textBoxPhone.Text != "")
                    expression = "insert into providers(title, provider_address, phone) values ('" + textBoxTitle.Text + "', '" + textBoxAddress.Text + "', '" + textBoxPhone.Text + "');";
                else 
                    expression = "insert into providers(title, provider_address) values ('" + textBoxTitle.Text + "', '" + textBoxAddress.Text + "');";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        SqlCommand request = new SqlCommand(expression, connection);
                        request.ExecuteNonQuery();

                        connection.Close();

                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Запись успешно добавлена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (parentMainForm != null) parentMainForm.refreshAfterInsertProviders();
                else if (parentAddDealsForm != null)
                {
                    parentAddDealsForm.parentForm.refreshAfterInsertProviders(parentAddDealsForm);
                    parentAddDealsForm.Activate();
                    this.Close();
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
