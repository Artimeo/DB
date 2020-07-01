using DB.AutoPartsDataSetTableAdapters;
using DB.Model.Repository;
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
        private Repository repository = Repository.Current;
        private bool textBoxSearchActiveStorehouse = false;
        private bool textBoxSearchActiveParts = false;
        private bool textBoxSearchActiveProviders = false;
        private bool textBoxSearchActivePriceview = false;

        public MainForm() { InitializeComponent(); }

        private void InitiallizeDataGridViews()
        {
            //DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            //columnHeaderStyle.BackColor = Color.Aqua;
            //columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);

            ////Storehouse
            //dataGridViewStorehouse.ColumnCount = 9;
            //dataGridViewStorehouse.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            //dataGridViewStorehouse.Columns[0].Name = "id";
            //dataGridViewStorehouse.Columns[1].Name = "Название";
            //dataGridViewStorehouse.Columns[2].Name = "Код";
            //dataGridViewStorehouse.Columns[3].Name = "Количество";
            //dataGridViewStorehouse.Columns[4].Name = "Производитель";
            //dataGridViewStorehouse.Columns[5].Name = "Цена закупки";
            //dataGridViewStorehouse.Columns[6].Name = "Дата закупки";
            //dataGridViewStorehouse.Columns[7].Name = "Поставщик";
            //dataGridViewStorehouse.Columns[8].Name = "Цена";

            ////Parts
            //dataGridViewParts.ColumnCount = 4;
            //dataGridViewParts.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            //dataGridViewParts.Columns[0].Name = "id";
            //dataGridViewParts.Columns[1].Name = "Название";
            //dataGridViewParts.Columns[2].Name = "Производитель";
            //dataGridViewParts.Columns[3].Name = "Цена";

            ////Providers
            //dataGridViewProviders.ColumnCount = 4;
            //dataGridViewProviders.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            //dataGridViewProviders.Columns[0].Name = "id";
            //dataGridViewProviders.Columns[1].Name = "Название";
            //dataGridViewProviders.Columns[2].Name = "Адрес";
            //dataGridViewProviders.Columns[3].Name = "Телефон";

            ////PriceView
            //dataGridViewPriceview.ColumnCount = 6;
            //dataGridViewPriceview.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            //dataGridViewPriceview.Columns[0].Name = "id";
            //dataGridViewPriceview.Columns[1].Name = "Код детали";
            //dataGridViewPriceview.Columns[2].Name = "Название";
            //dataGridViewPriceview.Columns[3].Name = "Текущая цена";
            //dataGridViewPriceview.Columns[4].Name = "Старая цена";
            //dataGridViewPriceview.Columns[5].Name = "Действовала до";
        }

        private void InitiallizeSearchComboboxes()
        {
            comboboxSearchByStorehouse.Items.Add("Все");
            for (int i = 0; i < dataGridViewStorehouse.ColumnCount; i++)
                comboboxSearchByStorehouse.Items.Add(dataGridViewStorehouse.Columns[i].HeaderText);
            comboboxSearchByStorehouse.SelectedIndex = 0;

            comboboxSearchByParts.Items.Add("Все");
            for (int i = 0; i < dataGridViewParts.ColumnCount; i++)
                comboboxSearchByParts.Items.Add(dataGridViewParts.Columns[i].HeaderText);
            comboboxSearchByParts.SelectedIndex = 0;
            
            comboboxSearchByProviders.Items.Add("Все");
            for (int i = 0; i < dataGridViewProviders.ColumnCount; i++)
                comboboxSearchByProviders.Items.Add(dataGridViewProviders.Columns[i].HeaderText);
            comboboxSearchByProviders.SelectedIndex = 0;
            
            comboboxSearchByPriceview.Items.Add("Все");
            for (int i = 0; i < dataGridViewPriceview.ColumnCount; i++)
                comboboxSearchByPriceview.Items.Add(dataGridViewPriceview.Columns[i].HeaderText);
            comboboxSearchByPriceview.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitiallizeDataGridViews();
            InitiallizeSearchComboboxes();

            try
            {
                refreshStorehouse();
                refreshParts();
                refreshProviders();
                refreshPriceview();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных из базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void refreshStorehouse(bool saveScrollPosition = false)
        {
            dataGridViewStorehouse.Rows.Clear();
            foreach (Repository.StorehouseItem item in repository.Storehouse())
                dataGridViewStorehouse.Rows.Add(
                    item.Id, item.Title, item.PartId, item.Count,
                    item.Manufacturer, item.OriginalPrice, item.Date.ToString("dd.MM.yyyy"), item.ProviderTitle, item.Price
                );
            if (saveScrollPosition == true)
                dataGridViewStorehouse.FirstDisplayedScrollingRowIndex = dataGridViewStorehouse.RowCount - 1;
            labelRowCountStorehouse.Text = "Количество записей: " + dataGridViewStorehouse.RowCount.ToString();
        }

        public void refreshParts(bool saveScrollPosition = false)
        {
            dataGridViewParts.Rows.Clear();
            foreach (Repository.PartItem item in repository.GetParts())
                dataGridViewParts.Rows.Add(
                    item.Id, item.Title, item.Manufacturer, item.Price
                );
            if (saveScrollPosition == true)
                dataGridViewParts.FirstDisplayedScrollingRowIndex = dataGridViewParts.RowCount - 1;
            labelRowCountParts.Text = "Количество записей: " + dataGridViewParts.RowCount.ToString();
            
            //в параметрах (AddDealsForm updateForm)
            //foreach (DataRow row in this.autoPartsDataSet.parts.Select())
            //{
            //    updateForm.textBoxTitle.AutoCompleteCustomSource.Add(
            //        row.ItemArray[0].ToString());
            //    updateForm.textBoxManufacturer.AutoCompleteCustomSource.Add(
            //        row.ItemArray[2].ToString());
            //}
        }

        public void refreshProviders(bool saveScrollPosition = false)
        {
            dataGridViewProviders.Rows.Clear();
            foreach (Repository.ProviderItem item in repository.GetProviders())
                dataGridViewProviders.Rows.Add(
                    item.Id, item.Title, item.Address, item.Phone
                );
            if (saveScrollPosition == true)
                dataGridViewProviders.FirstDisplayedScrollingRowIndex = dataGridViewProviders.RowCount - 1;
            labelRowCountProviders.Text = "Количество записей: " + dataGridViewProviders.RowCount.ToString();

            //updateForm.comboBoxProvider.Items.Clear();

            //foreach (DataRow row in this.autoPartsDataSet.providers.Select())
            //{
            //    updateForm.comboBoxProvider.Items.Add(
            //        row.ItemArray[0].ToString());
            //}
        }
        
        public void refreshPriceview(bool saveScrollPosition = false)
        {
            dataGridViewPriceview.Rows.Clear();
            foreach (Repository.PriceHistoryItem item in repository.GetPriceHistories())
                dataGridViewProviders.Rows.Add(
                    item.Id, item.PartId, item.Title, item.CurrentPrice, item.OldPrice, item.ActualBefore.ToString("dd.MM.yyyy")
                );
            if (saveScrollPosition == true)
                dataGridViewPriceview.FirstDisplayedScrollingRowIndex = dataGridViewPriceview.RowCount - 1;
            labelRowCountPriceview.Text = "Количество записей: " + dataGridViewPriceview.RowCount.ToString();
        }

        private int Search(DataGridView view, ComboBox comboboxSearchBy, string searchText)
        {
            if (searchText.Length == 0) 
                return -3;

            int columnSearchBy = comboboxSearchBy.SelectedIndex;
            bool getEntryInRow = false;
            searchText = searchText.ToLower();

            foreach (DataGridViewRow row in view.Rows)
                row.Visible = true;

            view.ClearSelection();
            view.CurrentCell = null;


            if (columnSearchBy == 0)
            {
                for (int i = 0; i < view.RowCount; i++)
                {
                    view.Rows[i].Selected = false;
                    for (int j = 0; j < view.ColumnCount; j++)
                    {
                        if (view.Rows[i].Cells[j].Value != null)
                        {
                            if (view.Rows[i].Cells[j].Value.ToString().ToLower().Contains(searchText))
                            {
                                if (getEntryInRow == false)
                                {
                                    getEntryInRow = true;
                                    view.FirstDisplayedScrollingRowIndex = i;
                                }
                                view.Rows[i].Selected = true;
                                break;
                            }
                        }
                    }
                }

                if (getEntryInRow == false)
                {
                    MessageBox.Show("Ничего не найдено, попробуйте изменить критерии поиска.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return -1;
                }
                else
                {
                    foreach (DataGridViewRow row in view.Rows)
                    {
                        if (!row.Selected) row.Visible = false;
                    }
                    view.ClearSelection();

                    for (int i = 0; i < view.RowCount; i++)
                    {
                        if (view.Rows[i].Visible)
                        {
                            for (int j = 0; j < view.ColumnCount; j++)
                            {
                                if (view.Rows[i].Cells[j].Value.ToString().ToLower().Contains(searchText))
                                {
                                    view.Rows[i].Cells[j].Selected = true;
                                }
                            }
                        }
                    }
                }
                return 0;
            }
            else
            {
                columnSearchBy -= 1;
                for (int i = 0; i < view.RowCount; i++)
                {
                    view.Rows[i].Selected = false;
                    if (view.Rows[i].Cells[columnSearchBy].Value != null)
                    {
                        if (view.Rows[i].Cells[columnSearchBy].Value.ToString().ToLower().Contains(searchText))
                        {
                            if (getEntryInRow == false)
                            {
                                getEntryInRow = true;
                                view.FirstDisplayedScrollingRowIndex = i;
                            }
                            view.Rows[i].Cells[columnSearchBy].Selected = true;
                        }
                    }
                }
                if (getEntryInRow == false)
                {
                    MessageBox.Show("Ничего не найдено, попробуйте изменить критерии поиска.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return -1;
                }
                return 0;
            }
        }


        //Storehouse
        private void buttonRefreshStorehouse_Click(object sender, EventArgs e)
        {
            try
            {
                refreshStorehouse();
                foreach (DataGridViewColumn column in dataGridViewStorehouse.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCleanStorehouse_Click(object sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show("Отсутствуют данные, сначала обновите таблицу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxSearchByStorehouse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxSearchStorehouse_KeyDown(sender, e);
        }

        public void textBoxSearchStorehouse_Enter(object sender, EventArgs e)
        {
            if (textBoxSearchActiveStorehouse == false)
            {
                textBoxSearchStorehouse.Text = "";
                textBoxSearchStorehouse.ForeColor = Color.Black;
                textBoxSearchActiveStorehouse = true;
            }
        }

        public void textBoxSearchStorehouse_Leave(object sender, EventArgs e)
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
                if (textBoxSearchStorehouse.Text.Length > 0)
                {
                    Search(dataGridViewStorehouse, comboboxSearchByStorehouse, textBoxSearchStorehouse.Text);
                }
                else
                {
                    MessageBox.Show("Введите данные для поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                dataGridViewStorehouse.Rows[cell.RowIndex].Selected = true;
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
                    foreach (DataGridViewRow selectedRow in dataGridViewStorehouse.SelectedRows)
                    {
                        int id = int.Parse(selectedRow.Cells[0].Value.ToString());
                        repository.DeleteDealById(id);

                        if (dataGridViewStorehouse.SelectedRows.Count <= 1) break;
                    }
                    refreshStorehouse(true);
                } 
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //Parts
        private void buttonRefreshParts_Click(object sender, EventArgs e)
        {
            try
            {
                refreshParts();
                foreach (DataGridViewColumn column in dataGridViewParts.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
                dataGridViewParts.ClearSelection();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCleanParts_Click(object sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show("Отсутствуют данные, сначала обновите таблицу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxSearchByParts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxSearchParts_KeyDown(sender, e);
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
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxSearchParts.Text != "")
                {
                    Search(dataGridViewParts, comboboxSearchByParts, textBoxSearchParts.Text);
                }
                else
                {
                    MessageBox.Show("Введите данные для поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                e.Handled = e.SuppressKeyPress = true;
            }
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
                dataGridViewParts.Rows[cell.RowIndex].Selected = true;
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

            if (MessageBox.Show("Выбранные строки удалятся из базы данных. Продолжить?", "Удалить запись", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    foreach (DataGridViewRow selectedRow in dataGridViewParts.SelectedRows)
                    {
                        int id = int.Parse(selectedRow.Cells[0].Value.ToString());
                        repository.DeletePartById(id);

                        if (dataGridViewParts.SelectedRows.Count <= 1) break;
                    }

                    refreshParts(true);
                } 
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //Providers
        private void buttonRefreshProviders_Click(object sender, EventArgs e)
        {
            try
            {
                refreshProviders();
                foreach (DataGridViewColumn column in dataGridViewProviders.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
                dataGridViewProviders.ClearSelection();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCleanProviders_Click(object sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show("Отсутствуют данные, сначала обновите таблицу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void comboBoxSearchByProviders_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxSearchProviders_KeyDown(sender, e);
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
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxSearchProviders.Text != "")
                {
                    Search(dataGridViewProviders, comboboxSearchByProviders, textBoxSearchProviders.Text);
                }
                else
                {
                    MessageBox.Show("Введите данные для поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                e.Handled = e.SuppressKeyPress = true;
            }
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
                dataGridViewProviders.Rows[cell.RowIndex].Selected = true;
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
                dataGridViewProviders.Rows[cell.RowIndex].Selected = true;

            if (MessageBox.Show("Выбранные строки удалятся из базы данных. Продолжить?", "Удалить запись", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    foreach (DataGridViewRow selectedRow in dataGridViewProviders.SelectedRows)
                    {
                        int id = int.Parse(selectedRow.Cells[0].Value.ToString());
                        repository.DeleteProviderById(id);

                        if (dataGridViewProviders.SelectedRows.Count <= 1) break;
                    }

                    refreshProviders(true);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //priceview
        private void buttonRefreshPriceview_Click(object sender, EventArgs e)
        {
            try
            {
                refreshPriceview();
                foreach (DataGridViewColumn column in dataGridViewPriceview.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
                dataGridViewPriceview.ClearSelection();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCleanPriceview_Click(object sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show("Отсутствуют данные, сначала обновите таблицу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxSearchByPriceview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) textBoxSearchPriceview_KeyDown(sender, e);
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
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxSearchPriceview.Text != "")
                {
                    Search(dataGridViewPriceview, comboboxSearchByPriceview, textBoxSearchPriceview.Text);
                }
                else
                {
                    MessageBox.Show("Введите данные для поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                e.Handled = e.SuppressKeyPress = true;
            }
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
                dataGridViewPriceview.Rows[cell.RowIndex].Selected = true;
        }

        private void buttonAddPriceview_Click(object sender, EventArgs e)
        {
            if (dataGridViewPriceview.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберите хотя бы одну строку для изменения цены", "Ошибка выбора", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
                dataGridViewPriceview.Rows[cell.RowIndex].Selected = true;

            if (MessageBox.Show("Выбранные строки удалятся из базы данных. Продолжить?", "Удалить запись", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    foreach (DataGridViewRow selectedRow in dataGridViewPriceview.SelectedRows)
                    {
                        int id = int.Parse(selectedRow.Cells[0].Value.ToString());
                        repository.DeletePriceHistoryById(id);

                        if (dataGridViewPriceview.SelectedRows.Count <= 1) break;
                    }

                    refreshPriceview(true);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            comboboxSearchByProviders.SelectedIndex = 2; // "Название"
            textBoxSearchProviders.Focus();
            textBoxSearchProviders_Enter(sender, e);
            textBoxSearchProviders.Text = dataGridViewStorehouse.CurrentRow.Cells[7].Value.ToString();
            SendKeys.Send("{ENTER}");
            textBoxSearchProviders_Leave(sender, e);
        }

        private void buttonPricehistoryStorehouse_Click(object sender, EventArgs e)
        {
            tabs.SelectTab(pricehistoryTab);
            comboboxSearchByPriceview.SelectedIndex = 2; // "Код детали"
            textBoxSearchPriceview.Focus();
            textBoxSearchPriceview_Enter(sender, e);
            textBoxSearchPriceview.Text = dataGridViewStorehouse.CurrentRow.Cells[2].Value.ToString();
            SendKeys.Send("{ENTER}");
            textBoxSearchPriceview_Leave(sender, e);
        }
    }
}
