using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class Form1 : Form
    {
        bool textBoxSearchActive = false;
        //записки
        //https://www.flaticon.com/free-icon/plus_128575 иконка "назад"
        //42880b - зеленые иконки
        //1568A3 синие 
        //db342d красные
        //E8C538 желтые

        public Form1()
        {
            //autopartsDataContext dc = new autopartsDataContext(Properties.Settings.Default.AutoPartsConnectionString);
            /*
            if (dc.DatabaseExists())
            {
                dataGridViewStorehouse.DataSource = dc.storehouse;
            }
            else
            {
                MessageBox.Show("Не удалось загрузить базу данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }*/

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "autoPartsDataSet.storehouse". При необходимости она может быть перемещена или удалена.
                //this.storehouseTableAdapter.Fill(this.autoPartsDataSet.storehouse);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            labelRowCount.Text += dataGridViewStorehouse.RowCount.ToString();

        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearchActive == false)
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
                textBoxSearchActive = true;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.ForeColor = Color.Gray;
                textBoxSearch.Text = "Поиск🔍";
                textBoxSearchActive = false;
            } else
            {
                textBoxSearchActive = true;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "autoPartsDataSet.storehouse". При необходимости она может быть перемещена или удалена.
                this.storehouseTableAdapter.Fill(this.autoPartsDataSet.storehouse);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            labelRowCount.Text = "Количество записей: " + dataGridViewStorehouse.RowCount.ToString();
        }
    }
}
