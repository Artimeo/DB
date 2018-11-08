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
    public partial class MainForm : Form
    {
        public static string connectionString = "Data Source=ORANGE\\MSSQLEXPRESS2017;Initial Catalog=AutoParts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        bool textBoxSearchActive = false;
        //записки
        //https://www.flaticon.com/free-icon/plus_128575 иконка "назад"
        //42880b - зеленые иконки
        //1568A3 синие 
        //db342d красные
        //E8C538 желтые

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoPartsDataSet.deals". При необходимости она может быть перемещена или удалена.
            this.dealsTableAdapter.Fill(this.autoPartsDataSet.deals);
            try
            {
                this.partsTableAdapter.Fill(this.autoPartsDataSet.parts);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных из таблицы parts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                this.providersTableAdapter.Fill(this.autoPartsDataSet.providers);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных из таблицы providers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                //this.storehouseTableAdapter.Fill(this.autoPartsDataSet.storehouse);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных из представления storehouse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            labelRowCountStorehouse.Text += dataGridViewStorehouse.RowCount.ToString();

        }

        private void Search(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxSearchStorehouse.Text != "")
            {
                bool getEntryInRow = false;
                foreach (DataGridViewRow row in dataGridViewStorehouse.Rows)
                {
                    row.Visible = true;
                }
                dataGridViewStorehouse.ClearSelection();
                dataGridViewStorehouse.CurrentCell = null;

                if (comboboxSearchByStorehouse.Text == "Все")
                {
                    for (int i = 0; i < dataGridViewStorehouse.RowCount; i++)
                    {
                        dataGridViewStorehouse.Rows[i].Selected = false;
                        for (int j = 0; j < dataGridViewStorehouse.ColumnCount; j++)
                        {
                            if (dataGridViewStorehouse.Rows[i].Cells[j].Value != null)
                            {
                                if (dataGridViewStorehouse.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBoxSearchStorehouse.Text.ToLower()))
                                {
                                    if (getEntryInRow == false)
                                    {
                                        getEntryInRow = true;
                                        dataGridViewStorehouse.FirstDisplayedScrollingRowIndex = i;
                                    }
                                    dataGridViewStorehouse.Rows[i].Selected = true;
                                    break;
                                }
                            }
                        }
                    }
                    if (getEntryInRow == false) {
                        MessageBox.Show("Ничего не найдено, попробуйте изменить критерии поиска.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridViewStorehouse.Rows)
                        {
                            if (!row.Selected) row.Visible = false;
                        }
                        dataGridViewStorehouse.ClearSelection();
                        
                        for (int i = 0; i < dataGridViewStorehouse.RowCount; i++)
                        {
                            if (dataGridViewStorehouse.Rows[i].Visible)
                            {
                                for (int j = 0; j < dataGridViewStorehouse.ColumnCount; j++)
                                {
                                    if (dataGridViewStorehouse.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBoxSearchStorehouse.Text.ToLower()))
                                    {
                                        dataGridViewStorehouse.Rows[i].Cells[j].Selected = true;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    int columnSearchBy;

                    switch (comboboxSearchByStorehouse.Text)
                    {
                        case "id":
                            columnSearchBy = 0;
                            break;
                        case "Название":
                            columnSearchBy = 1;
                            break;
                        case "Код":
                            columnSearchBy = 2;
                            break;
                        case "Цена":
                            columnSearchBy = 3;
                            break;
                        case "Количество":
                            columnSearchBy = 4;
                            break;
                        case "Производитель":
                            columnSearchBy = 5;
                            break;
                        case "Цена закупки":
                            columnSearchBy = 6;
                            break;
                        case "Дата закупки":
                            columnSearchBy = 7;
                            break;
                        case "Поставщик":
                            columnSearchBy = 8;
                            break;
                        default:
                            MessageBox.Show("Ошибка поиска! Выбранное поле отсутствует в таблице. Поиск будет произведен по названию.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            columnSearchBy = 1;
                            break;
                    }

                    for (int i = 0; i < dataGridViewStorehouse.RowCount; i++)
                    {
                        dataGridViewStorehouse.Rows[i].Selected = false;
                        if (dataGridViewStorehouse.Rows[i].Cells[columnSearchBy].Value != null)
                        {
                            if (dataGridViewStorehouse.Rows[i].Cells[columnSearchBy].Value.ToString().ToLower().Contains(textBoxSearchStorehouse.Text.ToLower()))
                            {
                                if (getEntryInRow == false)
                                {
                                    getEntryInRow = true;
                                    dataGridViewStorehouse.FirstDisplayedScrollingRowIndex = i;
                                }
                                dataGridViewStorehouse.Rows[i].Cells[columnSearchBy].Selected = true;
                            }
                        }
                    }
                    if (getEntryInRow == false) MessageBox.Show("Ничего не найдено, попробуйте изменить критерии поиска.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (e.KeyCode == Keys.Enter && textBoxSearchStorehouse.Text == "")
            {
                MessageBox.Show("Введите данные для поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearchActive == false)
            {
                textBoxSearchStorehouse.Text = "";
                textBoxSearchStorehouse.ForeColor = Color.Black;
                textBoxSearchActive = true;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearchStorehouse.Text == "")
            {
                textBoxSearchStorehouse.ForeColor = Color.Gray;
                textBoxSearchStorehouse.Text = "Поиск🔍";
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
                this.storehouseTableAdapter.Fill(this.autoPartsDataSet.storehouse);
                foreach (DataGridViewColumn column in dataGridViewStorehouse.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
                dataGridViewStorehouse.ClearSelection();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных из представления storehouse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            labelRowCountStorehouse.Text = "Количество записей: " + dataGridViewStorehouse.RowCount.ToString();
        }

        private void refreshAfterDelete()
        {
            dataGridViewStorehouse.ClearSelection();
            this.storehouseTableAdapter.Fill(this.autoPartsDataSet.storehouse);
            labelRowCountStorehouse.Text = "Количество записей: " + dataGridViewStorehouse.RowCount.ToString();
        }

        private void buttonSearchClear_Click(object sender, EventArgs e)
        {
            textBoxSearchStorehouse.ForeColor = Color.Gray;
            textBoxSearchStorehouse.Text = "Поиск🔍";
            textBoxSearchActive = false;
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            Search(sender, e);
        }

        private void comboBoxSearchBy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Search(sender, e);
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewStorehouse.RowCount > 0)
                {
                    dataGridViewStorehouse.Sort(dataGridViewStorehouse.Columns[0], ListSortDirection.Ascending);
                    foreach (DataGridViewColumn column in dataGridViewStorehouse.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                    }
                    foreach (DataGridViewRow row in dataGridViewStorehouse.Rows) row.Visible = true;
                    dataGridViewStorehouse.FirstDisplayedScrollingRowIndex = 0;
                    dataGridViewStorehouse.ClearSelection();
                    labelRowCountStorehouse.Text = "Количество записей: " + dataGridViewStorehouse.RowCount.ToString();
                }
                else
                {
                    MessageBox.Show("Отсутствуют данные, сначала обновите таблицу.", "Ошибка загрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных из представления storehouse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddDealsForm addForm = new AddDealsForm();

            foreach (DataRow row in this.autoPartsDataSet.parts.Select())
            {
                addForm.textBoxTitle.AutoCompleteCustomSource.Add(
                    row.ItemArray[0].ToString());
                addForm.textBoxManufacturer.AutoCompleteCustomSource.Add(
                    row.ItemArray[2].ToString());
            }
            foreach (DataRow row in this.autoPartsDataSet.providers.Select())
            {
                addForm.comboBoxProvider.Items.Add(
                    row.ItemArray[0].ToString());
            }
            addForm.Show();
        }

        private void buttonSelectRow_Click(object sender, EventArgs e)
        {
            var selectedCells = dataGridViewStorehouse.SelectedCells;

            foreach (DataGridViewCell cell in selectedCells)
            {
                dataGridViewStorehouse.Rows[cell.RowIndex].Selected = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedCells = dataGridViewStorehouse.SelectedCells;

            if (selectedCells.Count == 0)
            {
                MessageBox.Show("Не выбраны строки для удаления", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewCell cell in selectedCells) 
            {
                dataGridViewStorehouse.Rows[cell.RowIndex].Selected = true;
            }

            if (MessageBox.Show("Выбранные строки удалятся из базы данных. Продолжить?", "Удалить запись", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    foreach (DataGridViewRow selectedRow in dataGridViewStorehouse.SelectedRows)
                    {
                        string expression = "delete from deals where id = " + selectedRow.Cells[0].Value;

                        SqlCommand request = new SqlCommand(expression, connection);
                        request.ExecuteNonQuery();

                        if (dataGridViewStorehouse.SelectedRows.Count <= 1) break;
                    }

                    this.refreshAfterDelete();
                    connection.Close();
                }
            }
        }
    }
}
