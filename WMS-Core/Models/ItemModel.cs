using System.ComponentModel.DataAnnotations.Schema;

namespace WMS_Core.Models
{
    [Table("items")]
    public class ItemModel
    {
        [Column("id")] public int Id { get; set; }
        [Column("name")] public string? Name { get; set; }
        [Column("type")] public int TypeId { get; set; }
        [ForeignKey("TypeId")] public ItemTypeModel? ItemTypeModel { get; set; }
        [Column("weight")] public int Weight { get; set; }
        [Column("date", TypeName = "Date")] public DateTime ShelfLife { get; set; }
        [Column("image", TypeName = "Bytea")] public byte[] Image { get; set; }
        [Column("about")] public string? About { get; set; }
        [Column("warehouse")]
        [ForeignKey("warehouse")]
        public int WarehouseId { get; set; }
        [Column("price")] public int Price { get; set; }
        [Column("quantity")] public int Quantity { get; set; }
        [Column("new_price")] public int NewPrice { get; set; }
        [Column("moving")] public bool Moving { get; set; }
        
        //
    }
}
