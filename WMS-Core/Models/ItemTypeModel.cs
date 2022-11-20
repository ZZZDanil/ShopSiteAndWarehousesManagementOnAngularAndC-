using System.ComponentModel.DataAnnotations.Schema;

namespace WMS_Core.Models
{
    [Table("item_types")]
    public class ItemTypeModel
    {
        [Column("id")] public int Id { get; set; }
        [Column("name")] public string? Name { get; set; }
    }
}
