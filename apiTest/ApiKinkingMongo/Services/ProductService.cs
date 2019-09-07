using ApiKinkingMongo.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiKinkingMongo.Services
{
    public class ProductService
    {
        private readonly IMongoCollection<Product> _products;

        public ProductService(ISettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _products = database.GetCollection<Product>(settings.ProductsCollectionName);
        }

        public List<Product> Get() =>
            _products.Find(p => true).ToList();

        public Product Get(string id) =>
            _products.Find<Product>(p => p.Id == id).FirstOrDefault();

        public Product Create(Product product)
        {
            _products.InsertOne(product);
            return product;
        }

        public void Update(string id, Product product) =>
            _products.ReplaceOne(p => p.Id == id, product);

        public void Remove(Product product) =>
            _products.DeleteOne(p => p.Id == product.Id);

        public void Remove(string id) =>
            _products.DeleteOne(p => p.Id == id);
    }
}
