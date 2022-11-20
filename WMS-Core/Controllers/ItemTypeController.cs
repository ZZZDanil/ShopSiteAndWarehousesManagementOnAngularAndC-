using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WMS_Core.Models;

namespace WMS_Core.Controllers
{
    /*
     https://localhost:7044/ItemTypeController/ItemType/GetAll
     */

    [Route("ItemTypeController")]
    public class ItemTypeController : Controller
    {
        ApplicationContext db;
        public ItemTypeController(ApplicationContext context)
        {
            db = context;
        }
        [HttpGet]
        [Route("ItemType/GetAll")]
        public IActionResult GetAllItemTypes()
        {
            ItemTypeModel[]? all = db.ItemTypeModels.FromSqlRaw("select * from item_types").ToArray();
            return Json(all);
        }
        [HttpPost]
        [Route("ItemType/Add")]
        public IActionResult AddItemType(ItemTypeModel newItemType)
        {

            db.ItemTypeModels.Add(newItemType);
            db.SaveChanges();

            return new EmptyResult();
        }
        [HttpPut]
        [Route("ItemType/Update")]
        public IActionResult UpdateWarehouse(ItemTypeModel newItemType)
        {

            db.ItemTypeModels.Update(newItemType);
            db.SaveChanges();

            return new EmptyResult();
        }
        [HttpDelete]
        [Route("ItemType/DeleteById")]
        public IActionResult DeleteWarehouse(int itemTypeId)
        {

            db.ItemTypeModels.Remove(db.ItemTypeModels.Find(itemTypeId));
            db.SaveChanges();

            return new EmptyResult();
        }
    }
}
