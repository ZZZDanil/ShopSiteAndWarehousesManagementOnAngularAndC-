using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WMS_Core.Models;
using Newtonsoft.Json;

namespace WMS.Controllers
{
    static class ItemController
    {
        public static void AddItem(ItemModel item, Image img)
        {
            HttpClient client = new HttpClient(new HttpClientHandler()
            {
                UseProxy = false
            });

            ImageConverter imgCon = new ImageConverter();
            byte[] ImageData = { };
            if (img != null)
            {
                ImageData = (byte[])imgCon.ConvertTo(img, typeof(byte[]));
            }

            string query = $"https://localhost:7044/ItemController/Item/Add" +
                $"?newItem.Name={item.Name}" +
                $"&newItem.TypeId={item.TypeId}" +
                $"&newItem.Weight={item.Weight}" +
                $"&newItem.ShelfLife={item.ShelfLife}" +
                $"&newItem.Image={ConvertImageToByteArray(img)}" +
                $"&newItem.About={item.About}" +
                $"&newItem.WarehouseId={item.WarehouseId}" +
                $"&newItem.Price={item.Price}" +
                $"&newItem.Quantity={item.Quantity}" +
                $"&newItem.NewPrice={item.NewPrice}";
            /*
            var values = new Dictionary<string, string>
              {
                  { "thing1", "hello" },
                  { "thing2", "world" },
                  { "image", ConvertImageToByteArray(LoadedImage.Image).ToString() }
              };
            HttpContent content = new FormUrlEncodedContent(values);
            */

            MultipartFormDataContent multipartContent = new MultipartFormDataContent();
            HttpContent contentImage = new ByteArrayContent(ImageToByteArray(img));
            contentImage.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
            multipartContent.Add(contentImage, "itemImage", "fileName");

            var response = client.PostAsync(query, multipartContent);
            var responseString = response.ToString();
            ;
        }

        public static List<ItemModel> GetAllItemsByWarehouse(int warehouse)
        {
            HttpClient client = new HttpClient(new HttpClientHandler()
            {
                UseProxy = false
            });

            string query = $"https://localhost:7044/ItemController/Item/GetItemsByWarehouse" +
                $"?warehouse={warehouse}";


            Task<HttpResponseMessage> response = client.GetAsync(query);
            var resp = response.Result.Content.ReadAsStringAsync();
            List<ItemModel> contributors = JsonConvert.DeserializeObject<List<ItemModel>>(resp.Result);
            contributors.ForEach(Console.WriteLine);
            return contributors;
        }

        private static byte[] ConvertImageToByteArray(System.Drawing.Image imageToConvert)
        {
            byte[] Ret;

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageToConvert.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    Ret = ms.ToArray();
                }
            }
            catch (Exception) { throw; }

            return Ret;
        }
        public static byte[] ImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, imageIn.RawFormat);
            return ms.ToArray();
        }
        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
