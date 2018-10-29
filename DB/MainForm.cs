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
    public partial class MainForm : Form
    {
        bool textBoxSearchActive = false;
        //записки
        //https://www.flaticon.com/free-icon/plus_128575 иконка "назад"
        //42880b - зеленые иконки
        //1568A3 синие 
        //db342d красные
        //E8C538 желтые

        public MainForm()
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

        private void Search(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBoxSearch.Text != "")
            {
                bool getEntryInRow = false;
                dataGridViewStorehouse.ClearSelection();

                if (comboboxSearchBy.Text == "Все")
                {
                    for (int i = 0; i < dataGridViewStorehouse.RowCount; i++)
                    {
                        dataGridViewStorehouse.Rows[i].Selected = false;
                        for (int j = 0; j < dataGridViewStorehouse.ColumnCount; j++)
                        {
                            if (dataGridViewStorehouse.Rows[i].Cells[j].Value != null)
                            {
                                if (dataGridViewStorehouse.Rows[i].Cells[j].Value.ToString().ToLower().Contains(textBoxSearch.Text.ToLower()))
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
                    if (getEntryInRow == false) MessageBox.Show("Ничего не найдено, попробуйте изменить критерии поиска.", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int columnSearchBy;

                    switch (comboboxSearchBy.Text)
                    {
                        case "Код":
                            columnSearchBy = 0;
                            break;
                        case "Название":
                            columnSearchBy = 1;
                            break;
                        case "Цена":
                            columnSearchBy = 2;
                            break;
                        case "Количество":
                            columnSearchBy = 3;
                            break;
                        case "Производитель":
                            columnSearchBy = 4;
                            break;
                        case "Цена закупки":
                            columnSearchBy = 5;
                            break;
                        case "Дата закупки":
                            columnSearchBy = 6;
                            break;
                        case "Поставщик":
                            columnSearchBy = 7;
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
                            if (dataGridViewStorehouse.Rows[i].Cells[columnSearchBy].Value.ToString().ToLower().Contains(textBoxSearch.Text.ToLower()))
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
            else if (e.KeyCode == Keys.Enter && textBoxSearch.Text == "")
            {
                MessageBox.Show("Введите данные для поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                foreach (DataGridViewColumn column in dataGridViewStorehouse.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
                dataGridViewStorehouse.ClearSelection();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "Ошибка загрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            labelRowCount.Text = "Количество записей: " + dataGridViewStorehouse.RowCount.ToString();
        }

        private void buttonSearchClear_Click(object sender, EventArgs e)
        {
            textBoxSearch.ForeColor = Color.Gray;
            textBoxSearch.Text = "Поиск🔍";
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
            if (dataGridViewStorehouse.RowCount > 0)
            {
                dataGridViewStorehouse.Sort(dataGridViewStorehouse.Columns[0], ListSortDirection.Ascending);
                foreach (DataGridViewColumn column in dataGridViewStorehouse.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
                dataGridViewStorehouse.FirstDisplayedScrollingRowIndex = 0;
                dataGridViewStorehouse.ClearSelection();
                labelRowCount.Text = "Количество записей: " + dataGridViewStorehouse.RowCount.ToString();
            }
            else
            {
                MessageBox.Show("Отсутствуют данные, сначала обновите таблицу.", "Ошибка загрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] providers;
            AddForm addForm = new AddForm();
            addForm.Show();
        }
    }
}
