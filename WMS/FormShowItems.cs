using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMS.Controllers;
using WMS_Core.Models;

namespace WMS
{
    public partial class FormShowItems : Form
    {
        public FormShowItems()
        {
            InitializeComponent();
            LoadWarehouses();
            LoadTable();
            Warehouse.SelectedIndexChanged += new EventHandler(this.ChangeWarehouse);
        }
        void ChangeWarehouse(object sender, EventArgs e)
        {
            LoadTable();
        }
        private void LoadWarehouses()
        {
            List<WarehouseModel> warehouses = WarehouseController.GetAllWarehouses();

            Warehouse.DataSource = warehouses;
            Warehouse.DisplayMember = "Name";
            Warehouse.ValueMember = "Id";
            ;
        }
        private void LoadTable()
        {
            Table.Rows.Clear();
            List<ItemModel> items = ItemController.GetAllItemsByWarehouse(Convert.ToInt32(Warehouse.SelectedValue));
            foreach (ItemModel item in items)
            {
                var r = item.Quantity.ToString();
                AddRow(item.Name, item.Quantity.ToString());
            }
            ;
        }
        private void AddRow(string name, string quantity)
        {
            DataGridViewRow row = (DataGridViewRow)Table.Rows[0].Clone();
            row.Cells[1].Value = name;
            row.Cells[2].Value = quantity;
            Table.Rows.Add(row);
        }
    }
}
