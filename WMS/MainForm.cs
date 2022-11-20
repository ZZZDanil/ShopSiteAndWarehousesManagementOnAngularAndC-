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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.MainSplitContainer.Panel2.Controls.Clear();

            FormCreateItem newForm = new FormCreateItem();
            newForm.TopLevel = false;
            //newForm.Parent = this.MainSplitContainer.Panel2;
            this.MainSplitContainer.Panel2.Controls.Add(newForm);
            newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            newForm.Show();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MoveItem_Click(object sender, EventArgs e)
        {
            this.MainSplitContainer.Panel2.Controls.Clear();

            FormMoveItem newForm = new FormMoveItem();
            newForm.TopLevel = false;
            //newForm.Parent = this.MainSplitContainer.Panel2;
            this.MainSplitContainer.Panel2.Controls.Add(newForm);
            newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;

            newForm.AddRow();

            newForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void ClosePanel_Click(object sender, EventArgs e)
        {
            this.MainSplitContainer.Panel2.Controls.Clear();
        }

        private void WarehouseManagement_Click(object sender, EventArgs e)
        {
            this.MainSplitContainer.Panel2.Controls.Clear();

            FormShowItems newForm = new FormShowItems();
            newForm.TopLevel = false;
            //newForm.Parent = this.MainSplitContainer.Panel2;
            this.MainSplitContainer.Panel2.Controls.Add(newForm);
            newForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;


            newForm.Show();
        }
    }
}
