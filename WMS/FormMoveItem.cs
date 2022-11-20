using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS
{
    public partial class FormMoveItem : Form
    {
        public FormMoveItem()
        {
            InitializeComponent();
        }

        public void AddRow()
        {
            DataGridViewRow row = (DataGridViewRow)Table.Rows[0].Clone();
            //row.Cells.Add(new DataGridViewTextBoxCell());
            //row.Cells.Add(new DataGridViewTextBoxCell());
            row.Cells[0].Value = "XYZ";
            row.Cells[1].Value = "asas";
            Table.Rows.Add(row);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
