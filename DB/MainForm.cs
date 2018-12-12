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
        bool textBoxSearchActiveProviders = false;
        bool textBoxSearchActivePriceview = false;
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
            try
            {
                this.bridge_providers_partsTableAdapter.Fill(this.autoPartsDataSet.bridge_providers_parts);
            } catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных из таблицы bridge_providers_parts", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            try
            {
                this.dealsTableAdapter.Fill(this.autoPartsDataSet.deals);
            } catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных из таблицы deals", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                this.storehouseTableAdapter.Fill(this.autoPartsDataSet.storehouse);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных из представления storehouse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                this.priceviewTableAdapter.Fill(this.autoPartsDataSet.priceview);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных из представления priceview", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            labelRowCountStorehouse.Text += dataGridViewStorehouse.RowCount.ToString();
            labelRowCountParts.Text = "Количество записей: " + dataGridViewParts.RowCount.ToString();
            labelRowCountProviders.Text = "Количество записей: " + dataGridViewProviders.RowCount.ToString();
            labelRowCountPriceview.Text = "Количество записей: " + dataGridViewPriceview.RowCount.ToString();
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
        public void refreshAfterInsertParts()
        {
            dataGridViewParts.ClearSelection();
            this.partsTableAdapter.Fill(this.autoPartsDataSet.parts);
            dataGridViewParts.FirstDisplayedScrollingRowIndex = dataGridViewParts.RowCount - 1;
            labelRowCountParts.Text = "Количество записей: " + dataGridViewParts.RowCount.ToString();
        }
        public void refreshAfterInsertParts(AddDealsForm updateForm)
        {
            dataGridViewParts.ClearSelection();
            this.partsTableAdapter.Fill(this.autoPartsDataSet.parts);
            dataGridViewParts.FirstDisplayedScrollingRowIndex = dataGridViewParts.RowCount - 1;
            labelRowCountParts.Text = "Количество записей: " + dataGridViewParts.RowCount.ToString();

            foreach (DataRow row in this.autoPartsDataSet.parts.Select())
            {
                updateForm.textBoxTitle.AutoCompleteCustomSource.Add(
                    row.ItemArray[0].ToString());
                updateForm.textBoxManufacturer.AutoCompleteCustomSource.Add(
                    row.ItemArray[2].ToString());
            }
        }
        public void refreshAfterDeleteParts()
        {
            dataGridViewParts.ClearSelection();
            this.partsTableAdapter.Fill(this.autoPartsDataSet.parts);
            labelRowCountParts.Text = "Количество записей: " + dataGridViewParts.RowCount.ToString();
        }
        public void refreshAfterInsertProviders()
        {
            dataGridViewProviders.ClearSelection();
            this.providersTableAdapter.Fill(this.autoPartsDataSet.providers);
            dataGridViewProviders.FirstDisplayedScrollingRowIndex = dataGridViewProviders.RowCount - 1;
            labelRowCountProviders.Text = "Количество записей: " + dataGridViewProviders.RowCount.ToString();
        }
        public void refreshAfterInsertProviders(AddDealsForm updateForm)
        {
            dataGridViewProviders.ClearSelection();
            this.providersTableAdapter.Fill(this.autoPartsDataSet.providers);
            dataGridViewProviders.FirstDisplayedScrollingRowIndex = dataGridViewProviders.RowCount - 1;
            labelRowCountProviders.Text = "Количество записей: " + dataGridViewProviders.RowCount.ToString();

            updateForm.comboBoxProvider.Items.Clear();

            foreach (DataRow row in this.autoPartsDataSet.providers.Select())
            {
                updateForm.comboBoxProvider.Items.Add(
                    row.ItemArray[0].ToString());
            }
        }
        public void refreshAfterDeleteProviders()
        {
            dataGridViewProviders.ClearSelection();
            this.providersTableAdapter.Fill(this.autoPartsDataSet.providers);
            labelRowCountProviders.Text = "Количество записей: " + dataGridViewProviders.RowCount.ToString();
        }
        public void refreshAfterDeletePriceview()
        {
            dataGridViewPriceview.ClearSelection();
            this.priceviewTableAdapter.Fill(this.autoPartsDataSet.priceview);
            labelRowCountPriceview.Text = "Количество записей: " + dataGridViewPriceview.RowCount.ToString();
        }


        //Storehouse & Deals
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

        private void comboBoxSearchByStorehouse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchStorehouse(sender, e);
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

        private void textBoxSearchStorehouse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchStorehouse(sender, e);
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        
        private void buttonSearchClearStorehouse_Click(object sender, EventArgs e)
        {
            textBoxSearchStorehouse.ForeColor = Color.Gray;
            textBoxSearchStorehouse.Text = "Поиск🔍";
            textBoxSearchActiveStorehouse = false;
        }

        private void buttonSelectRowStorehouse_Click(object sender, EventArgs e)
        {
            var selectedCells = dataGridViewStorehouse.SelectedCells;

            foreach (DataGridViewCell cell in selectedCells)
            {
                dataGridViewStorehouse.Rows[cell.RowIndex].Selected = true;
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
                } catch (SqlException err)
                {
                    if (err.Number == 547)
                    {
                        MessageBox.Show("Невозможно удалить выбранную строку (строки) из таблицы deals, так как от нее зависимы другие таблицы. " +
                            "Сначала удалите связанные строки в них.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (dataGridViewStorehouse.SelectedRows.Count > 1) return;
                    }
                    else
                    {
                        MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        //Parts
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
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных из таблицы Parts", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            labelRowCountParts.Text = "Количество записей: " + dataGridViewParts.RowCount.ToString();
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

        private void comboBoxSearchByParts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchParts(sender, e);
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

        private void textBoxSearchParts_KeyDown(object sender, KeyEventArgs e)
        {
            SearchParts(sender, e);
        }

        private void buttonSearchClearParts_Click(object sender, EventArgs e)
        {
            textBoxSearchParts.ForeColor = Color.Gray;
            textBoxSearchParts.Text = "Поиск🔍";
            textBoxSearchActiveParts = false;
        }

        private void buttonSelectRowParts_Click(object sender, EventArgs e)
        {
            var selectedCells = dataGridViewParts.SelectedCells;

            foreach (DataGridViewCell cell in selectedCells)
            {
                dataGridViewParts.Rows[cell.RowIndex].Selected = true;
            }
        }

        private void buttonAddParts_Click(object sender, EventArgs e)
        {
            AddPartsForm addPartsForm = new AddPartsForm(this);
            addPartsForm.Show();
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

            if (MessageBox.Show("Выбранные строки удалятся из базы данных. Продолжить? Будет затронута таблица истории цен для данной запчасти", "Удалить запись", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        foreach (DataGridViewRow selectedRow in dataGridViewParts.SelectedRows)
                        {
                            for (int i = 0; i < dataGridViewStorehouse.Rows.Count; i++)
                            {
                                if (dataGridViewStorehouse.Rows[i].Cells[2].Value == selectedRow.Cells[1]) //deals.код == parts.код
                                {
                                    MessageBox.Show("Невозможно у.далить выбранную строку (строки) из таблицы deals, так как от нее зависимы другие таблицы. " +
                                        "Сначала удалите связанные строки в них.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }

                            string expression = "delete from priceHistory where parts_article = " + selectedRow.Cells[1].Value.ToString();

                            SqlCommand request = new SqlCommand(expression, connection);
                            request.ExecuteNonQuery();

                            expression = "delete from parts where title = '" + selectedRow.Cells[0].Value.ToString() + "'";

                            request = new SqlCommand(expression, connection);
                            request.ExecuteNonQuery();

                            if (dataGridViewParts.SelectedRows.Count <= 1) break;
                        }

                        this.refreshAfterDeleteParts();
                        connection.Close();
                    }
                } catch (SqlException err)
                {
                    if (err.Number == 547)
                    {
                        MessageBox.Show("Невозможно удалить выбранную строку (строки) из таблицы deals, так как от нее зависимы другие таблицы. " +
                            "Сначала удалите связанные строки в них.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (dataGridViewStorehouse.SelectedRows.Count > 1) return;
                    }
                    else
                    {
                        MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        //Providers
        private void SearchProviders(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxSearchProviders.Text != "")
            {
                bool getEntryInRow = false;
                foreach (DataGridViewRow row in dataGridViewProviders.Rows)
                {
                    row.Visible = true;
                }
                dataGridViewProviders.ClearSelection();
                dataGridViewProviders.CurrentCell = null;

                if (comboboxSearchByProviders.Text == "Все")
                {
                    for (int i = 0; i < dataGridViewProviders.RowCount; i++)
                    {
                        dataGridViewProviders.Rows[i].Selected = false;
                        for (int j = 0; j < dataGridViewProviders.ColumnCount; j++)
                        {
                            if (dataGridViewProviders.Rows[i].Cells[j].Value != null)
                            {
                                if (dataGridViewProviders.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBoxSearchProviders.Text.ToLower()))
                                {
                                    if (getEntryInRow == false)
                                    {
                                        getEntryInRow = true;
                                        dataGridViewProviders.FirstDisplayedScrollingRowIndex = i;
                                    }
                                    dataGridViewProviders.Rows[i].Selected = true;
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
                        foreach (DataGridViewRow row in dataGridViewProviders.Rows)
                        {
                            if (!row.Selected) row.Visible = false;
                        }
                        dataGridViewProviders.ClearSelection();

                        for (int i = 0; i < dataGridViewProviders.RowCount; i++)
                        {
                            if (dataGridViewProviders.Rows[i].Visible)
                            {
                                for (int j = 0; j < dataGridViewProviders.ColumnCount; j++)
                                {
                                    if (dataGridViewProviders.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBoxSearchProviders.Text.ToLower()))
                                    {
                                        dataGridViewProviders.Rows[i].Cells[j].Selected = true;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    int columnSearchBy;

                    switch (comboboxSearchByProviders.Text)
                    {
                        case "Название":
                            columnSearchBy = 0;
                            break;
                        case "Адрес":
                            columnSearchBy = 1;
                            break;
                        case "Телефон":
                            columnSearchBy = 2;
                            break;
                        default:
                            MessageBox.Show("Ошибка поиска! Выбранное поле отсутствует в таблице. Поиск будет произведен по названию.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            columnSearchBy = 1;
                            break;
                    }

                    for (int i = 0; i < dataGridViewProviders.RowCount; i++)
                    {
                        dataGridViewProviders.Rows[i].Selected = false;
                        if (dataGridViewProviders.Rows[i].Cells[columnSearchBy].Value != null)
                        {
                            if (dataGridViewProviders.Rows[i].Cells[columnSearchBy].Value.ToString().ToLower().Contains(textBoxSearchProviders.Text.ToLower()))
                            {
                                if (getEntryInRow == false)
                                {
                                    getEntryInRow = true;
                                    dataGridViewProviders.FirstDisplayedScrollingRowIndex = i;
                                }
                                dataGridViewProviders.Rows[i].Cells[columnSearchBy].Selected = true;
                            }
                        }
                    }
                    if (getEntryInRow == false) MessageBox.Show("Ничего не найдено, попробуйте изменить критерии поиска.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (e.KeyCode == Keys.Enter && textBoxSearchProviders.Text == "")
            {
                MessageBox.Show("Введите данные для поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonRefreshProviders_Click(object sender, EventArgs e)
        {
            try
            {
                this.providersTableAdapter.Fill(this.autoPartsDataSet.providers);
                foreach (DataGridViewColumn column in dataGridViewProviders.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
                dataGridViewProviders.ClearSelection();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных из таблицы providers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            labelRowCountProviders.Text = "Количество записей: " + dataGridViewProviders.RowCount.ToString();
        }

        private void buttonCleanProviders_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProviders.RowCount > 0)
                {
                    dataGridViewProviders.Sort(dataGridViewProviders.Columns[0], ListSortDirection.Ascending);
                    foreach (DataGridViewColumn column in dataGridViewProviders.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                    }
                    foreach (DataGridViewRow row in dataGridViewProviders.Rows) row.Visible = true;
                    dataGridViewProviders.FirstDisplayedScrollingRowIndex = 0;
                    dataGridViewProviders.ClearSelection();
                    labelRowCountProviders.Text = "Количество записей: " + dataGridViewProviders.RowCount.ToString();
                }
                else
                {
                    MessageBox.Show("Отсутствуют данные, сначала обновите таблицу.", "Ошибка загрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных из представления Providers", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxSearchByProviders_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchProviders(sender, e);
        }

        private void textBoxSearchProviders_Enter(object sender, EventArgs e)
        {
            if (textBoxSearchActiveProviders == false)
            {
                textBoxSearchProviders.Text = "";
                textBoxSearchProviders.ForeColor = Color.Black;
                textBoxSearchActiveProviders = true;
            }
        }

        private void textBoxSearchProviders_Leave(object sender, EventArgs e)
        {
            if (textBoxSearchProviders.Text == "")
            {
                textBoxSearchProviders.ForeColor = Color.Gray;
                textBoxSearchProviders.Text = "Поиск🔍";
                textBoxSearchActiveProviders = false;
            }
            else
            {
                textBoxSearchActiveProviders = true;
            }
        }

        private void textBoxSearchProviders_KeyDown(object sender, KeyEventArgs e)
        {
            SearchProviders(sender, e);
        }

        private void buttonSearchCleanProviders_Click(object sender, EventArgs e)
        {
            textBoxSearchProviders.ForeColor = Color.Gray;
            textBoxSearchProviders.Text = "Поиск🔍";
            textBoxSearchActiveProviders = false;
        }

        private void buttonSelectRowProviders_Click(object sender, EventArgs e)
        {
            var selectedCells = dataGridViewProviders.SelectedCells;

            foreach (DataGridViewCell cell in selectedCells)
            {
                dataGridViewProviders.Rows[cell.RowIndex].Selected = true;
            }
        }

        private void buttonAddProviders_Click(object sender, EventArgs e)
        {
            AddProvidersForm addProvidersForm = new AddProvidersForm(this);
            addProvidersForm.Show();
        }

        private void buttonDeleteProviders_Click(object sender, EventArgs e)
        {
            var selectedCells = dataGridViewProviders.SelectedCells;

            if (selectedCells.Count == 0)
            {
                MessageBox.Show("Не выбраны строки для удаления", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewCell cell in selectedCells)
            {
                dataGridViewProviders.Rows[cell.RowIndex].Selected = true;
            }

            if (MessageBox.Show("Выбранные строки удалятся из базы данных. Продолжить? Будет затронута таблица запчастей. " +
                "Если с ней связан выбранный поставщик (поставщики), удаление будет отменено.", "Удалить запись", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        foreach (DataGridViewRow selectedRow in dataGridViewProviders.SelectedRows)
                        {
                            for (int i = 0; i < autoPartsDataSet.bridge_providers_parts.Rows.Count; i++)
                            {
                                if (autoPartsDataSet.bridge_providers_parts.Rows[i].ItemArray[0].ToString() == selectedRow.Cells[0].ToString()) //bridge_priveders_parts.providers_title == parts.title
                                {
                                    MessageBox.Show("Невозможно удалить выбранную строку (строки) из таблицы providers, так как от нее зависимы другие таблицы. " +
                                        "Сначала удалите связанные строки в них.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }

                            string expression = "delete from providers where title = '" + selectedRow.Cells[0].Value.ToString() + "';";

                            SqlCommand request = new SqlCommand(expression, connection);
                            request.ExecuteNonQuery();
                            
                            if (dataGridViewParts.SelectedRows.Count <= 1) break;
                        }

                        this.refreshAfterDeleteProviders();
                        connection.Close();
                    }
                }
                catch (SqlException err)
                {
                    if (err.Number == 547)
                    {
                        MessageBox.Show("Невозможно удалить выбранную строку (строки) из таблицы deals, так как от нее зависимы другие таблицы. " +
                            "Сначала удалите связанные строки в них.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (dataGridViewStorehouse.SelectedRows.Count > 1) return;
                    }
                    else
                    {
                        MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        //priceview
        private void SearchPriceview(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxSearchPriceview.Text != "")
            {
                bool getEntryInRow = false;
                foreach (DataGridViewRow row in dataGridViewPriceview.Rows)
                {
                    row.Visible = true;
                }
                dataGridViewPriceview.ClearSelection();
                dataGridViewPriceview.CurrentCell = null;

                if (comboboxSearchByPriceview.Text == "Все")
                {
                    for (int i = 0; i < dataGridViewPriceview.RowCount; i++)
                    {
                        dataGridViewPriceview.Rows[i].Selected = false;
                        for (int j = 0; j < dataGridViewPriceview.ColumnCount; j++)
                        {
                            if (dataGridViewPriceview.Rows[i].Cells[j].Value != null)
                            {
                                if (dataGridViewPriceview.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBoxSearchPriceview.Text.ToLower()))
                                {
                                    if (getEntryInRow == false)
                                    {
                                        getEntryInRow = true;
                                        dataGridViewPriceview.FirstDisplayedScrollingRowIndex = i;
                                    }
                                    dataGridViewPriceview.Rows[i].Selected = true;
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
                        foreach (DataGridViewRow row in dataGridViewPriceview.Rows)
                        {
                            if (!row.Selected) row.Visible = false;
                        }
                        dataGridViewPriceview.ClearSelection();

                        for (int i = 0; i < dataGridViewPriceview.RowCount; i++)
                        {
                            if (dataGridViewPriceview.Rows[i].Visible)
                            {
                                for (int j = 0; j < dataGridViewPriceview.ColumnCount; j++)
                                {
                                    if (dataGridViewPriceview.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBoxSearchPriceview.Text.ToLower()))
                                    {
                                        dataGridViewPriceview.Rows[i].Cells[j].Selected = true;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    int columnSearchBy;

                    switch (comboboxSearchByPriceview.Text)
                    {
                        case "id":
                            columnSearchBy = 0;
                            break;
                        case "Код детали":
                            columnSearchBy = 1;
                            break;
                        case "Название":
                            columnSearchBy = 2;
                            break;
                        case "Текущая цена":
                            columnSearchBy = 3;
                            break;
                        case "Старая цена":
                            columnSearchBy = 4;
                            break;
                        case "Действовала до":
                            columnSearchBy = 5;
                            break;
                        default:
                            MessageBox.Show("Ошибка поиска! Выбранное поле отсутствует в представлении. Поиск будет произведен по названию.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            columnSearchBy = 1;
                            break;
                    }

                    for (int i = 0; i < dataGridViewPriceview.RowCount; i++)
                    {
                        dataGridViewPriceview.Rows[i].Selected = false;
                        if (dataGridViewPriceview.Rows[i].Cells[columnSearchBy].Value != null)
                        {
                            if (dataGridViewPriceview.Rows[i].Cells[columnSearchBy].Value.ToString().ToLower().Contains(textBoxSearchPriceview.Text.ToLower()))
                            {
                                if (getEntryInRow == false)
                                {
                                    getEntryInRow = true;
                                    dataGridViewPriceview.FirstDisplayedScrollingRowIndex = i;
                                }
                                dataGridViewPriceview.Rows[i].Cells[columnSearchBy].Selected = true;
                            }
                        }
                    }
                    if (getEntryInRow == false) MessageBox.Show("Ничего не найдено, попробуйте изменить критерии поиска.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (e.KeyCode == Keys.Enter && textBoxSearchPriceview.Text == "")
            {
                MessageBox.Show("Введите данные для поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonRefreshPriceview_Click(object sender, EventArgs e)
        {
            try
            {
                this.priceviewTableAdapter.Fill(this.autoPartsDataSet.priceview);
                foreach (DataGridViewColumn column in dataGridViewPriceview.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
                dataGridViewPriceview.ClearSelection();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных из представления priceview", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            labelRowCountPriceview.Text = "Количество записей: " + dataGridViewPriceview.RowCount.ToString();
        }

        private void buttonCleanPriceview_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPriceview.RowCount > 0)
                {
                    dataGridViewPriceview.Sort(dataGridViewPriceview.Columns[0], ListSortDirection.Ascending);
                    foreach (DataGridViewColumn column in dataGridViewPriceview.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                    }
                    foreach (DataGridViewRow row in dataGridViewPriceview.Rows) row.Visible = true;
                    dataGridViewPriceview.FirstDisplayedScrollingRowIndex = 0;
                    dataGridViewPriceview.ClearSelection();
                    labelRowCountPriceview.Text = "Количество записей: " + dataGridViewPriceview.RowCount.ToString();
                }
                else
                {
                    MessageBox.Show("Отсутствуют данные, сначала обновите таблицу.", "Ошибка загрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных из представления Priceview", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxSearchByPriceview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchPriceview(sender, e);
        }

        private void textBoxSearchPriceview_Enter(object sender, EventArgs e)
        {
            if (textBoxSearchActivePriceview == false)
            {
                textBoxSearchPriceview.Text = "";
                textBoxSearchPriceview.ForeColor = Color.Black;
                textBoxSearchActivePriceview = true;
            }
        }

        private void textBoxSearchPriceview_Leave(object sender, EventArgs e)
        {
            if (textBoxSearchPriceview.Text == "")
            {
                textBoxSearchPriceview.ForeColor = Color.Gray;
                textBoxSearchPriceview.Text = "Поиск🔍";
                textBoxSearchActivePriceview = false;
            }
            else
            {
                textBoxSearchActivePriceview = true;
            }
        }

        private void textBoxSearchPriceview_KeyDown(object sender, KeyEventArgs e)
        {
            SearchPriceview(sender, e);
        }

        private void buttonSearchCleanPriceview_Click(object sender, EventArgs e)
        {
            textBoxSearchPriceview.ForeColor = Color.Gray;
            textBoxSearchPriceview.Text = "Поиск🔍";
            textBoxSearchActivePriceview = false;
        }

        private void buttonSelectRowPriceview_Click(object sender, EventArgs e)
        {
            var selectedCells = dataGridViewPriceview.SelectedCells;

            foreach (DataGridViewCell cell in selectedCells)
            {
                dataGridViewPriceview.Rows[cell.RowIndex].Selected = true;
            }
        }

        private void buttonAddPriceview_Click(object sender, EventArgs e)
        {
            if (dataGridViewPriceview.SelectedRows.Count > 1)
            {
                MessageBox.Show("Выберите только одну строку для изменения цены", "Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var selectedCells = dataGridViewPriceview.SelectedCells;

                foreach (DataGridViewCell cell in selectedCells)
                {
                    dataGridViewPriceview.Rows[cell.RowIndex].Selected = true;
                }
            }

            AddPriceHistoryForm addPriceHistoryForm = new AddPriceHistoryForm(this);

            addPriceHistoryForm.textBoxTitle.Text = dataGridViewPriceview.SelectedCells[2].Value.ToString();

            if (dataGridViewPriceview.SelectedCells[3].ToString() != "")
                addPriceHistoryForm.textBoxOldPrice.Text = dataGridViewPriceview.SelectedCells[3].Value.ToString();

            foreach (DataRow row in this.autoPartsDataSet.priceview.Select())
            {
                addPriceHistoryForm.textBoxTitle.AutoCompleteCustomSource.Add(
                    row.ItemArray[2].ToString());
            }

            addPriceHistoryForm.Show();
            addPriceHistoryForm.partsAutocompleteСhanged();
            addPriceHistoryForm.isAllowedRecordRow();
        }

        private void buttonDeletePriceview_Click(object sender, EventArgs e)
        {
            var selectedCells = dataGridViewPriceview.SelectedCells;

            if (selectedCells.Count == 0)
            {
                MessageBox.Show("Не выбраны строки для удаления", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataGridViewCell cell in selectedCells)
            {
                dataGridViewPriceview.Rows[cell.RowIndex].Selected = true;
            }

            if (MessageBox.Show("Выбранные строки удалятся из базы данных. Продолжить?", "Удалить запись", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        foreach (DataGridViewRow selectedRow in dataGridViewPriceview.SelectedRows)
                        {
                            if (selectedRow.Cells[0].Value.ToString() == "")
                            {
                                MessageBox.Show("Для данной запчасти отсутствуют записи в таблице priceHistory, нечего удалять.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string expression = "delete from priceHistory where price_id = " + selectedRow.Cells[0].Value.ToString() + ";";

                            SqlCommand request = new SqlCommand(expression, connection);
                            request.ExecuteNonQuery();

                            if (dataGridViewPriceview.SelectedRows.Count <= 1) break;
                        }

                        this.refreshAfterDeletePriceview();
                        connection.Close();
                    }
                }
                catch (SqlException err)
                {
                    if (err.Number == 547)
                    {
                        MessageBox.Show("Невозможно удалить выбранную строку (строки) из представления priceview, так как от нее зависимы другие таблицы. " +
                            "Сначала удалите связанные строки в них.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (dataGridViewStorehouse.SelectedRows.Count > 1) return;
                    }
                    else
                    {
                        MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        //additional functions
        private void buttonRequest_Click(object sender, EventArgs e)
        {
            var addRequest = new AddRequest(this);
            addRequest.Show();
        }

        private void buttonToProvidersStorehouse_Click(object sender, EventArgs e)
        {
            tabs.SelectTab(providersTab);
            comboboxSearchByProviders.Text = "Название";
            textBoxSearchProviders.Focus();
            textBoxSearchProviders_Enter(sender, e);
            textBoxSearchProviders.Text = dataGridViewStorehouse.CurrentRow.Cells[8].Value.ToString();
            SendKeys.Send("{ENTER}");
            textBoxSearchProviders_Leave(sender, e);
        }

        private void buttonPricehistoryStorehouse_Click(object sender, EventArgs e)
        {
            tabs.SelectTab(pricehistoryTab);
            comboboxSearchByPriceview.Text = "Все";
            textBoxSearchPriceview.Focus();
            textBoxSearchPriceview_Enter(sender, e);
            textBoxSearchPriceview.Text = dataGridViewStorehouse.CurrentRow.Cells[1].Value.ToString();
            SendKeys.Send("{ENTER}");
            textBoxSearchPriceview_Leave(sender, e);
        }
    }
}
