using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using WMS_Core.Models;

namespace WMS.Controllers
{
    public static class WarehouseController
    {
        public static List<WarehouseModel> GetAllWarehouses()
        {
            HttpClient client = new HttpClient(new HttpClientHandler(){UseProxy = false});

            string query = $"https://localhost:7044/WarehouseController/Warehouse/GetAll";

            Task<HttpResponseMessage> response = client.GetAsync(query);
            var resp = response.Result.Content.ReadAsStringAsync();
            var ttt = resp.Result;

            List<WarehouseModel> contributors = JsonConvert.DeserializeObject<List<WarehouseModel>>(resp.Result);
            contributors.ForEach(Console.WriteLine);
            return contributors;
        }

        public static void AddWarehouse(WarehouseModel newWarehouse)
        {

            //db.WarehouseModels.Add(newWarehouse);
            //db.SaveChanges();

            //return new EmptyResult();
        }
        public static void UpdateWarehouse(WarehouseModel newWarehouse)
        {

            //db.WarehouseModels.Update(newWarehouse);
            //db.SaveChanges();

            //return new EmptyResult();
        }
        public static void DeleteWarehouse(int warehouseId)
        {

            //db.WarehouseModels.Remove(db.WarehouseModels.Find(warehouseId));
            //db.SaveChanges();

            //return new EmptyResult();
        }
    }
}
