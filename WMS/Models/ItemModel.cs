using System;

namespace WMS_Core.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public int Weight { get; set; }
        public DateTime ShelfLife { get; set; }
        public byte[] Image { get; set; }
        public string About { get; set; }
        public int WarehouseId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int NewPrice { get; set; }
        public bool Moving { get; set; }
    }
}
