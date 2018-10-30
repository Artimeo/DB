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

        private void buttonRecordRow_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text == "" || 
                textBoxPrice.Text == "" || 
                dateTimePicker.Text == "" || 
                textBoxCount.Text == "" || 
                comboBoxProvider.Text == "")
            {
                MessageBox.Show("Невозможно провести запись, не все необходимые поля заполены.", "Ошибка записи данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                string sqlExpressionInsertValues;
                string connectionString = "Data Source=ORANGE\\MSSQLEXPRESS2017;Initial Catalog=AutoParts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand request;

                    if (textBoxManufacturer.Text != "")
                    {
                        sqlExpressionInsertValues = "insert into parts (title, manufacturer, price) values ";
                        request = new SqlCommand(
                        sqlExpressionInsertValues + "('" + textBoxTitle.Text + "', '" + textBoxManufacturer.Text + "', " + textBoxPrice.Text + ");",
                        connection);
                    } 
                    else
                    {
                        sqlExpressionInsertValues = "insert into parts (title, price) values ";
                        request = new SqlCommand(
                        sqlExpressionInsertValues + "('" + textBoxTitle.Text + "', '" + textBoxManufacturer.Text + "', " + textBoxPrice.Text + ");",
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
        }
    }
}
