using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WMS_Core.Models;

namespace WMS_Core.Controllers
{
    /*
     https://localhost:7044/WarehouseController/Warehouse/GetAll
     */
    [Route("WarehouseController")]
    public class WarehouseController : Controller
    {
        ApplicationContext db;
        public WarehouseController(ApplicationContext context)
        {
            db = context;
        }

        [HttpGet]
        [Route("Warehouse/GetAll")]
        public IActionResult GetAllWarehouses()
        {
            WarehouseModel[]? all = db.WarehouseModels.FromSqlRaw("select * from warehouses").ToArray();
            return Json(all);
        }

        [HttpPost]
        [Route("Warehouse/Add")]
        public IActionResult AddWarehouse(WarehouseModel newWarehouse)
        {

            db.WarehouseModels.Add(newWarehouse);
            db.SaveChanges();

            return new EmptyResult();
        }
        [HttpPut]
        [Route("Warehouse/Update")]
        public IActionResult UpdateWarehouse(WarehouseModel newWarehouse)
        {

            db.WarehouseModels.Update(newWarehouse);
            db.SaveChanges();

            return new EmptyResult();
        }
        [HttpDelete]
        [Route("Warehouse/DeleteById")]
        public IActionResult DeleteWarehouse(int warehouseId)
        {

            db.WarehouseModels.Remove(db.WarehouseModels.Find(warehouseId));
            db.SaveChanges();

            return new EmptyResult();
        }
    }
}
