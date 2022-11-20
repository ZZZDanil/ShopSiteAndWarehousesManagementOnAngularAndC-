using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using WMS_Core.Models;

namespace WMS_Core.Controllers
{
    /*
     https://localhost:7044/ItemController/Item/GetItem?id=1
    https://localhost:7044/ItemController/Item/GetItems?type=1&warehouse=2
     */
    [Route("ItemController")]
    public class ItemController : Controller
    {
        ApplicationContext db;
        public ItemController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        [Route("Item/GetItem")]
        public IActionResult GetItem(int id)
        {
            ItemModel? newItem = db.ItemModels.FromSqlRaw("select * from items where id = {0}", id).FirstOrDefault();
            return Json(newItem);
        }
        [HttpGet]
        [Route("Item/GetItemsByWarehouse")]
        public IActionResult GetItemsByWarehouse(int warehouse)
        {
            ItemModel[]? newItem = db.ItemModels.FromSqlRaw(
                "select * from items where warehouse = {0}", warehouse).ToArray();
            return Json(newItem);
        }
        [HttpGet]
        [Route("Item/GetItems")]
        public IActionResult GetItems(int type, int warehouse)
        {
            ItemModel[]? newItem = db.ItemModels.FromSqlRaw(
                "select * from items where type = {0} and warehouse = {1}", type, warehouse).ToArray();
            return Json(newItem);
        }

        [HttpPost]
        [Route("Item/Add")]
        public IActionResult AddItem(ItemModel newItem)
        {
            var r = Request;
            var c = Response;
            //string t = Request.Form["image"];
            //newItem.Image = Encoding.ASCII.GetBytes(t);

            IFormFileCollection fileCollection = Request.Form.Files;
            IFormFile? file = fileCollection[0];
            if (file != null) {
                using var fileStream = file.OpenReadStream();
                byte[] bytes = new byte[(int)file.Length];
                fileStream.Read(bytes, 0, (int)file.Length);
                newItem.Image = bytes;
            }
            db.ItemModels.Add(newItem);
            db.SaveChanges();

            return Content("ASP.NET Core на metanit.com");
            //return new EmptyResult();
        }
        [HttpPut]
        [Route("Item/Update")]
        public IActionResult UpdateItem(ItemModel newItem)
        {

            db.ItemModels.Update(newItem);
            db.SaveChanges();

            return new EmptyResult();
        }
        [HttpGet]
        [Route("Item/Reduce")]
        public IActionResult ReduceItem(int id, int reductionNumber)
        {
            if (reductionNumber > 0)
            {
                ItemModel? selectedItem = db.ItemModels.FromSqlRaw("select * from items where id = {0}", id).FirstOrDefault();
                if (selectedItem != null)
                {
                    int difference = selectedItem.Quantity - reductionNumber;
                    if (difference > -1)
                    {
                        selectedItem.Quantity = difference;
                        var d = db.ItemModels.Update(selectedItem);
                        db.SaveChanges();
                    }
                }
            }

            return new EmptyResult();
        }
        [HttpDelete]
        [Route("Item/DeleteById")]
        public IActionResult DeleteItem(int itemId)
        {

            db.ItemModels.Remove(db.ItemModels.Find(itemId));
            db.SaveChanges();

            return new EmptyResult();
        }
    }
}
