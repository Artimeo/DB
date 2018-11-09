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
    public partial class AddDealsForm : Form
    {
        public const string connectionString = "Data Source=ORANGE\\MSSQLEXPRESS2017;Initial Catalog=AutoParts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        public MainForm parentForm;
        private static Dictionary<string, int> bridge_id = new Dictionary<string, int> ();

        public AddDealsForm(MainForm mainForm)
        {
            parentForm = mainForm;
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
            this.providersTableAdapter.Fill(this.autoPartsDataSet.providers);
            this.dealsTableAdapter.Fill(this.autoPartsDataSet.deals);
            this.bridge_providers_partsTableAdapter.Fill(this.autoPartsDataSet.bridge_providers_parts);
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

        private void partsAutocomplete (object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "")
            {
                pictureTitleError.Show();
                pictureProviderError.Show();
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand request;
                request = new SqlCommand(
                    "select * from parts where title = '" + textBoxTitle.Text + "';",
                    connection);

                request.ExecuteNonQuery();

                int partArticle = -1;
                bridge_id.Clear();

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
                                bridge_id.Add(reader.GetString(1), reader.GetInt32(0));
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

        private void buttonRecordRow_Click(object sender, EventArgs e)
        {
            try
            {
                if (isAllowedRecordRow() && bridge_id.Count > 0)
                {
                    string expression = "insert into deals (deal_date, bridge_id, parts_count) values ('" + dateTimePicker.Text.ToString() + "', " + bridge_id[comboBoxProvider.Text] + ", " + textBoxCount.Text + ");";
                    //if (MessageBox.Show(expression, "SQL выражение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            SqlCommand request = new SqlCommand(expression, connection);
                            request.ExecuteNonQuery();

                            connection.Close();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не все ограничения удовлетворяют условиям добавления записи.", "Ошибка записи данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parentForm.refreshAfterInsertStorehouse();
            MessageBox.Show("Запись успешно добавлена", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonAddPart_Click(object sender, EventArgs e)
        {
            AddPartsForm addPartsForm = new AddPartsForm(this);
            addPartsForm.Show();
        }
    }
}
