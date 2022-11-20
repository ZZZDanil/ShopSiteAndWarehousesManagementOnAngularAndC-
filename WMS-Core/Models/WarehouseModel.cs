using System.ComponentModel.DataAnnotations.Schema;

namespace WMS_Core.Models
{
    [Table("warehouses")]
    public class WarehouseModel
    {
        [Column("id")] public int Id { get; set; }
        [Column("name")] public string? Name { get; set; }
    }
}
