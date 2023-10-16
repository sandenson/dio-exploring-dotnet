using Newtonsoft.Json;

namespace ExploringExample.Models
{
    public class Sale
    {
        public Sale(int id, string product, decimal price, DateTime date)
        {
            Id = id;
            Product = product;
            Price = price;
            Date = date;
        }

        public int Id { get; set; }

        // serializes "product", "product_name", "product-name", "productname" and "product name"
        // JSON attributes to the "Product" prop, case insensitive
        [JsonProperty("product_name")]
        public string Product { get; set; }
        [JsonProperty("productname")]
        private string ProductName { set => Product = value; }
        [JsonProperty("product-name")]
        private string ProductNameKebab { set => Product = value; }
        [JsonProperty("product name")]
        private string ProductNameSpaced { set => Product = value; }

        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}