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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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


    }
}
