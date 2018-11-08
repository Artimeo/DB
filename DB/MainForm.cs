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
        public const string connectionString = "Data Source=ORANGE\\MSSQLEXPRESS2017;Initial Catalog=AutoParts;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False";
        bool textBoxSearchActiveStorehouse = false;
        bool textBoxSearchActiveParts = false;
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
            labelRowCountParts.Text = "Количество записей: " + dataGridViewParts.RowCount.ToString();
        }


        private void SearchStorehouse(object sender, KeyEventArgs e)
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

        private void textBoxSearchStorehouse_Enter(object sender, EventArgs e)
        {
            if (textBoxSearchActiveStorehouse == false)
            {
                textBoxSearchStorehouse.Text = "";
                textBoxSearchStorehouse.ForeColor = Color.Black;
                textBoxSearchActiveStorehouse = true;
            }
        }

        private void textBoxSearchStorehouse_Leave(object sender, EventArgs e)
        {
            if (textBoxSearchStorehouse.Text == "")
            {
                textBoxSearchStorehouse.ForeColor = Color.Gray;
                textBoxSearchStorehouse.Text = "Поиск🔍";
                textBoxSearchActiveStorehouse = false;
            } else
            {
                textBoxSearchActiveStorehouse = true;
            }
        }

        private void buttonRefreshStorehouse_Click(object sender, EventArgs e)
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

        public void refreshAfterInsertStorehouse()
        {
            dataGridViewStorehouse.ClearSelection();
            this.storehouseTableAdapter.Fill(this.autoPartsDataSet.storehouse);
            dataGridViewStorehouse.FirstDisplayedScrollingRowIndex = dataGridViewStorehouse.RowCount - 1;
            labelRowCountStorehouse.Text = "Количество записей: " + dataGridViewStorehouse.RowCount.ToString();
        }

        public void refreshAfterDeleteStorehouse()
        {
            dataGridViewStorehouse.ClearSelection();
            this.storehouseTableAdapter.Fill(this.autoPartsDataSet.storehouse);
            labelRowCountStorehouse.Text = "Количество записей: " + dataGridViewStorehouse.RowCount.ToString();
        }

        private void buttonSearchClearStorehouse_Click(object sender, EventArgs e)
        {
            textBoxSearchStorehouse.ForeColor = Color.Gray;
            textBoxSearchStorehouse.Text = "Поиск🔍";
            textBoxSearchActiveStorehouse = false;
        }

        private void textBoxSearchStorehouse_KeyDown(object sender, KeyEventArgs e)
        {
            SearchStorehouse(sender, e);
        }

        private void comboBoxSearchByStorehouse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchStorehouse(sender, e);
        }

        private void buttonCleanStorehouse_Click(object sender, EventArgs e)
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

        private void buttonAddStorehouse_Click(object sender, EventArgs e)
        {
            AddDealsForm addDealsForm = new AddDealsForm(this);

            foreach (DataRow row in this.autoPartsDataSet.parts.Select())
            {
                addDealsForm.textBoxTitle.AutoCompleteCustomSource.Add(
                    row.ItemArray[0].ToString());
                addDealsForm.textBoxManufacturer.AutoCompleteCustomSource.Add(
                    row.ItemArray[2].ToString());
            }
            foreach (DataRow row in this.autoPartsDataSet.providers.Select())
            {
                addDealsForm.comboBoxProvider.Items.Add(
                    row.ItemArray[0].ToString());
            }
            addDealsForm.Show();
        }

        private void buttonSelectRowStorehouse_Click(object sender, EventArgs e)
        {
            var selectedCells = dataGridViewStorehouse.SelectedCells;

            foreach (DataGridViewCell cell in selectedCells)
            {
                dataGridViewStorehouse.Rows[cell.RowIndex].Selected = true;
            }
        }

        private void buttonDeleteStorehouse_Click(object sender, EventArgs e)
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
                try
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

                        this.refreshAfterDeleteStorehouse();
                        connection.Close();
                    }
                } catch (Exception err)
                {
                    MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void SearchParts(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxSearchParts.Text != "")
            {
                bool getEntryInRow = false;
                foreach (DataGridViewRow row in dataGridViewParts.Rows)
                {
                    row.Visible = true;
                }
                dataGridViewParts.ClearSelection();
                dataGridViewParts.CurrentCell = null;

                if (comboboxSearchByParts.Text == "Все")
                {
                    for (int i = 0; i < dataGridViewParts.RowCount; i++)
                    {
                        dataGridViewParts.Rows[i].Selected = false;
                        for (int j = 0; j < dataGridViewParts.ColumnCount; j++)
                        {
                            if (dataGridViewParts.Rows[i].Cells[j].Value != null)
                            {
                                if (dataGridViewParts.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBoxSearchParts.Text.ToLower()))
                                {
                                    if (getEntryInRow == false)
                                    {
                                        getEntryInRow = true;
                                        dataGridViewParts.FirstDisplayedScrollingRowIndex = i;
                                    }
                                    dataGridViewParts.Rows[i].Selected = true;
                                    break;
                                }
                            }
                        }
                    }
                    if (getEntryInRow == false)
                    {
                        MessageBox.Show("Ничего не найдено, попробуйте изменить критерии поиска.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dataGridViewParts.Rows)
                        {
                            if (!row.Selected) row.Visible = false;
                        }
                        dataGridViewParts.ClearSelection();

                        for (int i = 0; i < dataGridViewParts.RowCount; i++)
                        {
                            if (dataGridViewParts.Rows[i].Visible)
                            {
                                for (int j = 0; j < dataGridViewParts.ColumnCount; j++)
                                {
                                    if (dataGridViewParts.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBoxSearchParts.Text.ToLower()))
                                    {
                                        dataGridViewParts.Rows[i].Cells[j].Selected = true;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    int columnSearchBy;

                    switch (comboboxSearchByParts.Text)
                    {
                        case "Название":
                            columnSearchBy = 0;
                            break;
                        case "Код":
                            columnSearchBy = 1;
                            break;
                        case "Производитель":
                            columnSearchBy = 2;
                            break;
                        case "Цена":
                            columnSearchBy = 3;
                            break;
                        default:
                            MessageBox.Show("Ошибка поиска! Выбранное поле отсутствует в таблице. Поиск будет произведен по названию.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            columnSearchBy = 1;
                            break;
                    }

                    for (int i = 0; i < dataGridViewParts.RowCount; i++)
                    {
                        dataGridViewParts.Rows[i].Selected = false;
                        if (dataGridViewParts.Rows[i].Cells[columnSearchBy].Value != null)
                        {
                            if (dataGridViewParts.Rows[i].Cells[columnSearchBy].Value.ToString().ToLower().Contains(textBoxSearchParts.Text.ToLower()))
                            {
                                if (getEntryInRow == false)
                                {
                                    getEntryInRow = true;
                                    dataGridViewParts.FirstDisplayedScrollingRowIndex = i;
                                }
                                dataGridViewParts.Rows[i].Cells[columnSearchBy].Selected = true;
                            }
                        }
                    }
                    if (getEntryInRow == false) MessageBox.Show("Ничего не найдено, попробуйте изменить критерии поиска.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (e.KeyCode == Keys.Enter && textBoxSearchParts.Text == "")
            {
                MessageBox.Show("Введите данные для поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxSearchParts_Enter(object sender, EventArgs e)
        {
            if (textBoxSearchActiveParts == false)
            {
                textBoxSearchParts.Text = "";
                textBoxSearchParts.ForeColor = Color.Black;
                textBoxSearchActiveParts = true;
            }
        }

        private void textBoxSearchParts_Leave(object sender, EventArgs e)
        {
            if (textBoxSearchParts.Text == "")
            {
                textBoxSearchParts.ForeColor = Color.Gray;
                textBoxSearchParts.Text = "Поиск🔍";
                textBoxSearchActiveParts = false;
            }
            else
            {
                textBoxSearchActiveParts = true;
            }
        }

        private void buttonRefreshParts_Click(object sender, EventArgs e)
        {
            try
            {
                this.partsTableAdapter.Fill(this.autoPartsDataSet.parts);
                foreach (DataGridViewColumn column in dataGridViewParts.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
                dataGridViewParts.ClearSelection();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных из представления Parts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            labelRowCountParts.Text = "Количество записей: " + dataGridViewParts.RowCount.ToString();
        }

        public void refreshAfterDeleteParts()
        {
            dataGridViewParts.ClearSelection();
            this.partsTableAdapter.Fill(this.autoPartsDataSet.parts);
            labelRowCountParts.Text = "Количество записей: " + dataGridViewParts.RowCount.ToString();
        }

        public void refreshAfterInsertParts()
        {
            dataGridViewParts.ClearSelection();
            this.partsTableAdapter.Fill(this.autoPartsDataSet.parts);
            dataGridViewParts.FirstDisplayedScrollingRowIndex = dataGridViewParts.RowCount - 1;
            labelRowCountParts.Text = "Количество записей: " + dataGridViewParts.RowCount.ToString();
        }

        private void buttonSearchClearParts_Click(object sender, EventArgs e)
        {
            textBoxSearchParts.ForeColor = Color.Gray;
            textBoxSearchParts.Text = "Поиск🔍";
            textBoxSearchActiveParts = false;
        }

        private void textBoxSearchParts_KeyDown(object sender, KeyEventArgs e)
        {
            SearchParts(sender, e);
        }

        private void comboBoxSearchByParts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchParts(sender, e);
        }

        private void buttonCleanParts_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewParts.RowCount > 0)
                {
                    dataGridViewParts.Sort(dataGridViewParts.Columns[0], ListSortDirection.Ascending);
                    foreach (DataGridViewColumn column in dataGridViewParts.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                    }
                    foreach (DataGridViewRow row in dataGridViewParts.Rows) row.Visible = true;
                    dataGridViewParts.FirstDisplayedScrollingRowIndex = 0;
                    dataGridViewParts.ClearSelection();
                    labelRowCountParts.Text = "Количество записей: " + dataGridViewParts.RowCount.ToString();
                }
                else
                {
                    MessageBox.Show("Отсутствуют данные, сначала обновите таблицу.", "Ошибка загрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных из представления Parts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddParts_Click(object sender, EventArgs e)
        {
            AddPartsForm addPartsForm = new AddPartsForm(this);
            addPartsForm.Show();
        }

        private void buttonSelectRowParts_Click(object sender, EventArgs e)
        {
            var selectedCells = dataGridViewParts.SelectedCells;

            foreach (DataGridViewCell cell in selectedCells)
            {
                dataGridViewParts.Rows[cell.RowIndex].Selected = true;
            }
        }

        private void buttonDeleteParts_Click(object sender, EventArgs e)
        {
            var selectedCells = dataGridViewParts.SelectedCells;

            if (selectedCells.Count == 0)
            {
                MessageBox.Show("Не выбраны строки для удаления", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewCell cell in selectedCells)
            {
                dataGridViewParts.Rows[cell.RowIndex].Selected = true;
            }

            if (MessageBox.Show("Выбранные строки удалятся из базы данных. Продолжить?", "Удалить запись", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        foreach (DataGridViewRow selectedRow in dataGridViewParts.SelectedRows)
                        {
                            string expression = "delete from parts where title = '" + selectedRow.Cells[0].Value.ToString() + "'";

                            SqlCommand request = new SqlCommand(expression, connection);
                            request.ExecuteNonQuery();

                            if (dataGridViewParts.SelectedRows.Count <= 1) break;
                        }

                        this.refreshAfterDeleteParts();
                        connection.Close();
                    }
                } catch (Exception err)
                {
                    MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
