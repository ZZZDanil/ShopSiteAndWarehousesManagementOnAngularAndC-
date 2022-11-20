using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using WMS_Core.Models;

namespace WMS.Controllers
{
    public static class ItemTypeController
    {
        public static List<ItemTypeModel> GetAllItemTypes()
        {
            HttpClient client = new HttpClient(new HttpClientHandler() { UseProxy = false });

            string query = $"https://localhost:7044/ItemTypeController/ItemType/GetAll";

            Task<HttpResponseMessage> response = client.GetAsync(query);
            var resp = response.Result.Content.ReadAsStringAsync();
            var ttt = resp.Result;

            List<ItemTypeModel> contributors = JsonConvert.DeserializeObject<List<ItemTypeModel>>(resp.Result);
            contributors.ForEach(Console.WriteLine);
            return contributors;
        }
        public static void AddItemType(ItemTypeModel newItemType)
        {

            //db.ItemTypeModels.Add(newItemType);
            //db.SaveChanges();

            //return new EmptyResult();
        }
        public static void UpdateWarehouse(ItemTypeModel newItemType)
        {

            //db.ItemTypeModels.Update(newItemType);
            //db.SaveChanges();

            //return new EmptyResult();
        }
        public static void DeleteWarehouse(int itemTypeId)
        {

            //db.ItemTypeModels.Remove(db.ItemTypeModels.Find(itemTypeId));
            //db.SaveChanges();

            //return new EmptyResult();
        }
    }
}
