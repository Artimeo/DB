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
    public partial class AddPartsForm : Form
    {
        public const string connectionString = "Data Source=ORANGE\\MSSQLEXPRESS2017;Initial Catalog=AutoParts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        MainForm parentForm;

        public AddPartsForm(MainForm mainForm)
        {
            parentForm = mainForm;
            InitializeComponent();
        }

        public bool isAllowedRecordRow()
        {
            if (pictureTitleError.Visible == false && pictureManufacturerError.Visible == false && picturePriceError.Visible == false)
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
        }

        private void textBoxManufacturer_TextChanged_Leave(object sender, EventArgs e)
        {
            if (textBoxManufacturer.Text == "") pictureManufacturerError.Show();
            else pictureManufacturerError.Hide();
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPrice.Text != "")
            {
                foreach (char ch in textBoxPrice.Text)
                {
                    if (char.IsDigit(ch)) picturePriceError.Hide();
                    else
                    {
                        picturePriceError.Show();
                        break;
                    };
                }
            }
            else picturePriceError.Show();

            isAllowedRecordRow();
        }

        private void textBoxPrice_Leave(object sender, EventArgs e)
        {
            if (textBoxPrice.Text != "")
                picturePriceError.Hide();
            else
            {
                picturePriceError.Show();
                isAllowedRecordRow();
                return;
            }
            try
            {
                int price = Int32.Parse(textBoxPrice.Text);
                if (price <= 0) picturePriceError.Show(); else picturePriceError.Hide();
                isAllowedRecordRow();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                picturePriceError.Show();
                isAllowedRecordRow();
            }
        }


        private void buttonRecordRow_Click(object sender, EventArgs e)
        {
            if (isAllowedRecordRow())
            {
                string expression = "insert into parts(title, manufacturer, price) values ('" + textBoxTitle.Text + "', '" + textBoxManufacturer.Text + "', " + textBoxPrice.Text + ");";
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        SqlCommand request = new SqlCommand(expression, connection);
                        request.ExecuteNonQuery();

                        connection.Close();

                    }
                } catch (Exception err)
                {
                    MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                parentForm.refreshAfterInsertParts();
                MessageBox.Show("Запись успешно добавлена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
