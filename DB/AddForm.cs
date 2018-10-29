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
    }
}
