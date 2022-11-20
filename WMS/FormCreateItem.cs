using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMS.Controllers;
using WMS_Core.Models;

namespace WMS
{
    public partial class FormCreateItem : Form
    {
        public FormCreateItem()
        {
            InitializeComponent();
            LoadedImage.SizeMode = PictureBoxSizeMode.Zoom;
            LoadWarehouses();
            LoadItemTypes();
        }
        private void LoadWarehouses()
        {
            List<WarehouseModel> warehouses = WarehouseController.GetAllWarehouses();

            WarehouseField.DataSource = warehouses;
            WarehouseField.DisplayMember = "Name";
            WarehouseField.ValueMember = "Id";
            ;
        }
        private void LoadItemTypes()
        {
            List<ItemTypeModel> types = ItemTypeController.GetAllItemTypes();

            TypeField.DataSource = types;
            TypeField.DisplayMember = "Name";
            TypeField.ValueMember = "Id";
            ;
        }
        
        public FormCreateItem(Form form)
        {
            InitializeComponent();
            form.BackColor = Color.Black;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form1 newForm = new Form1();
            //newForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ItemModel item = new ItemModel();
            item.Name = NameField.Text;

            item.TypeId = Int32.Parse(TypeField.SelectedValue.ToString());
            item.Weight = Int32.Parse(WeightField.Text);
            item.ShelfLife = ShelfLifeDateTimePicker.Value;
            item.About = AboutField.Text;
            item.WarehouseId = Int32.Parse(WarehouseField.SelectedValue.ToString());
            item.Price = Int32.Parse(PriceField.Text);
            item.Quantity = Int32.Parse(AmountField.Text);
            item.NewPrice = Int32.Parse(PriceField.Text);
            ItemController.AddItem(item, LoadedImage.Image);
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            ImageController.LoadImage(LoadedImage);
        }
    }
}
