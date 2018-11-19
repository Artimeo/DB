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

        public AddPriceHistoryForm(MainForm mainForm)
        {
            parentForm = mainForm;
            InitializeComponent();
            dateTimePicker.Value = System.DateTime.Now;
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
            if (pictureTitleError.Visible == false && pictureNewPriceError.Visible == false)
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

        private void partsAutocomplete()
        {
            if (textBoxTitle.Text == "")
            {
                pictureTitleError.Show();
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
                connection.Close();
            }
        }

    }
}
