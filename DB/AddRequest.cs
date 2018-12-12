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
    public partial class AddRequest : Form
    {
        private const string connectionString = "Data Source=ORANGE\\MSSQLEXPRESS2017;Initial Catalog=AutoParts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        private MainForm parentForm;
        static DataSet ds;

        public AddRequest(MainForm mainForm)
        {
            parentForm = mainForm;
            InitializeComponent();
            //var sqlDataAdapter = new SqlDataAdapter("select * from parts", connectionString);
            //dataGridViewRequest.DataSource = parentForm.autoPartsDataSet.parts;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxRequest.Text.ToLower().Contains("select"))
                {
                    using (var sqlDataAdapter = new SqlDataAdapter(textBoxRequest.Text, connectionString))
                    {
                        ds = new DataSet();
                        sqlDataAdapter.Fill(ds);
                        dataGridViewRequest.DataSource = ds.Tables[0];
                        ds.Dispose();
                    }
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        SqlCommand request = new SqlCommand(textBoxRequest.Text, connection);
                        request.ExecuteNonQuery();

                        connection.Close();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("SQL запрос отклонен: ", err.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("SQL запрос успешно выполнен", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
