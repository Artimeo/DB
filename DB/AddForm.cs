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
    public partial class AddForm : Form
    {
        public static string sqlExpression;
        public static string connectionString = "Data Source=ORANGE\\MSSQLEXPRESS2017;Initial Catalog=AutoParts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

        public AddForm()
        {
            InitializeComponent();
            dateTimePicker.Value = System.DateTime.Now;
        }

        private void buttonSetCurrentDate_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = System.DateTime.Now;
        }

        private void buttonCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoPartsDataSet.providers". При необходимости она может быть перемещена или удалена.
            this.providersTableAdapter.Fill(this.autoPartsDataSet.providers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoPartsDataSet.deals". При необходимости она может быть перемещена или удалена.
            this.dealsTableAdapter.Fill(this.autoPartsDataSet.deals);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoPartsDataSet.bridge_providers_parts". При необходимости она может быть перемещена или удалена.
            this.bridge_providers_partsTableAdapter.Fill(this.autoPartsDataSet.bridge_providers_parts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoPartsDataSet.parts". При необходимости она может быть перемещена или удалена.
            this.partsTableAdapter.Fill(this.autoPartsDataSet.parts);

        }

        public bool isAllowedRecordRow()
        {
            if (pictureTitleError.Visible == false && picturePartsCountError.Visible == false && pictureProviderError.Visible == false)
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

        private void buttonRecordRow_Click(object sender, EventArgs e)
        {
            if (isAllowedRecordRow())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand request;

                    if (textBoxManufacturer.Text != "")
                    {
                        sqlExpression = "insert into parts (title, manufacturer, price) values ";
                        request = new SqlCommand(
                        sqlExpression + "('" + textBoxTitle.Text + "', '" + textBoxManufacturer.Text + "', " + textBoxPrice.Text + ");",
                        connection);
                    }
                    else
                    {
                        sqlExpression = "insert into parts (title, price) values ";
                        request = new SqlCommand(
                        sqlExpression + "('" + textBoxTitle.Text + "', '" + textBoxManufacturer.Text + "', " + textBoxPrice.Text + ");",
                        connection);
                    }

                    request.ExecuteNonQuery();

                    string addedPartArticle;
                    request.CommandText = "select max(article) from parts;";
                    using (SqlDataReader reader = request.ExecuteReader())
                    {
                        addedPartArticle = reader.GetString(2);
                    };

                    request.CommandText = "insert into deals values ('" + dateTimePicker.Text + "', " + addedPartArticle + ", " + textBoxCount.Text + ");";
                    request.ExecuteNonQuery();

                    request.CommandText = "insert into bridge_providers_parts values('" + comboBoxProvider.Text + "', " + addedPartArticle + ");";
                    request.ExecuteNonQuery();


                    connection.Close();

                }

            }
            else
            {
                MessageBox.Show("Не все ограничения удовлетворяют условиям добавления записи.", "Ошибка записи данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void partsAutocomplete (object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "")
            {
                pictureTitleError.Show();
                pictureProviderError.Show();
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand request;
                    request = new SqlCommand(
                        "select * from parts where title = '" + textBoxTitle.Text + "';",
                        connection);

                    request.ExecuteNonQuery();

                    int partArticle = -1;

                    using (SqlDataReader reader = request.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            pictureTitleError.Hide();
                            while (reader.Read())
                            {
                                partArticle = reader.GetInt32(1);
                                textBoxManufacturer.Text = reader.GetString(2);
                                textBoxPrice.Text = reader.GetInt32(3).ToString();
                            }
                        }
                        else
                        {
                            pictureTitleError.Show();
                            comboBoxProvider.Text = "";
                            comboBoxProvider.Items.Clear();
                            pictureProviderError.Show();
                            textBoxManufacturer.Text = "";
                            textBoxPrice.Text = "";
                        }
                    }

                    if (partArticle != -1)
                    {
                        request = new SqlCommand(
                            "select * from bridge_providers_parts where parts_article = " + partArticle.ToString() + ";",
                            connection);
                        request.ExecuteNonQuery();

                        using (SqlDataReader reader = request.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                comboBoxProvider.Items.Clear();

                                while (reader.Read())
                                {
                                    comboBoxProvider.Items.Add(reader.GetString(1));
                                }
                            }
                            else
                            {
                                pictureProviderError.Show();
                            }
                        }
                    }

                    connection.Close();

                    isAllowedRecordRow();
                }
            }
        }
        private void textBoxTitle_Leave(object sender, EventArgs e)
        {
            partsAutocomplete(sender, e);
        }

        private void textBoxTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                partsAutocomplete(sender, e);
            }
        }

        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {

            foreach (char ch in textBoxCount.Text)
            {
                if (char.IsDigit(ch)) picturePartsCountError.Hide();
                else
                {
                    picturePartsCountError.Show();
                    break;
                };
            }
            isAllowedRecordRow();
        }

        private void textBoxCount_Leave(object sender, EventArgs e)
        {
            try
            {
                int partsCount = Int32.Parse(textBoxCount.Text);
                if (partsCount <= 0) picturePartsCountError.Show(); else picturePartsCountError.Hide();
                isAllowedRecordRow();
            }
            catch (Exception err)
            {
                picturePartsCountError.Show();
                isAllowedRecordRow();
            }
        }

        private void comboBoxProvider_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxProvider.Text == "")
            {
                pictureProviderError.Show();
            }
            else pictureProviderError.Hide();

            isAllowedRecordRow();
        }

        
    }
}
