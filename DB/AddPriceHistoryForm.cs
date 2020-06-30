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
    public partial class AddPriceHistoryForm : Form
    {
        private const string connectionString = "Data Source=ORANGE\\MSSQLEXPRESS2017;Initial Catalog=AutoParts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        private MainForm parentForm;
        private int selectedPartArticle;

        public AddPriceHistoryForm(MainForm mainForm)
        {
            parentForm = mainForm;
            InitializeComponent();
            dateTimePicker.Value = System.DateTime.Now;
            partsAutocompleteСhanged();
        }

        private void buttonSetCurrentDate_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = System.DateTime.Now;
            isAllowedRecordRow();
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool isAllowedRecordRow()
        {
            if (pictureTitleError.Visible == false && pictureNewPriceError.Visible == false && pictureOldPriceError.Visible == false)
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

        public void partsAutocompleteСhanged()
        {
            if (textBoxTitle.Text == "")
            {
                pictureTitleError.Show();
                pictureOldPriceError.Show();
                return;
            }

            foreach (DataRow row in parentForm.autoPartsDataSet.priceview.Rows)
            {
                if (row.ItemArray[2].ToString().ToLower().Contains(textBoxTitle.Text.ToLower()))
                {
                    textBoxOldPrice.Text = row.ItemArray[3].ToString();
                    pictureTitleError.Hide();
                    pictureOldPriceError.Hide();
                    selectedPartArticle = int.Parse(row.ItemArray[1].ToString());
                    return;
                }
            }
            MessageBox.Show("Не найдена цена для данной запчасти", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            pictureTitleError.Show();
            pictureOldPriceError.Show();
            isAllowedRecordRow();
        }

        private void textBoxTitle_Leave(object sender, EventArgs e)
        {
            partsAutocompleteСhanged();
        }

        private void textBoxTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                partsAutocompleteСhanged();
            }
        }

        private void textBoxNewPrice_TextChanged(object sender, EventArgs e)
        {

            foreach (char ch in textBoxNewPrice.Text)
            {
                if (char.IsDigit(ch)) pictureNewPriceError.Hide();
                else
                {
                    pictureNewPriceError.Show();
                    break;
                };
            }
            isAllowedRecordRow();
        }

        private void textBoxNewPrice_Leave(object sender, EventArgs e)
        {
            if (textBoxNewPrice.Text != "")
            {
                try
                {
                    int partsCount = Int32.Parse(textBoxNewPrice.Text);
                    if (partsCount <= 0) pictureNewPriceError.Show(); else pictureNewPriceError.Hide();
                    isAllowedRecordRow();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureNewPriceError.Show();
                    isAllowedRecordRow();
                }
            }
        }

        private void buttonRecordRow_Click(object sender, EventArgs e)
        {
            if (textBoxNewPrice.Text == textBoxOldPrice.Text)
            {
                MessageBox.Show("Текущая цена и введенная вами совпадают, запись отменена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            try
            {
                if (isAllowedRecordRow())
                {

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        SqlCommand request = new SqlCommand("update parts set price = " + textBoxNewPrice.Text + " where article = " + selectedPartArticle.ToString(), connection);
                        request.ExecuteNonQuery();

                        connection.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Не все ограничения удовлетворяют условиям добавления записи.", "Ошибка записи данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //parentForm.refreshAfterDeletePriceview();
            MessageBox.Show("Запись успешно добавлена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            partsAutocompleteСhanged();
        }
    }
}
