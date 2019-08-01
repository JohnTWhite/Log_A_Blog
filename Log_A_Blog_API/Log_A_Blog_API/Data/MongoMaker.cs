using Log_A_Blog_API.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Log_A_Blog_API.Data
{
    public interface IMongoMaker
    {
        bool saveBlog(BlogFormModel blogFormModel);
    }
    public class MongoMaker : IMongoMaker
    {
        IMongoClient _client;
        public MongoMaker(IMongoClient client)
        {
            _client = client;
        }

        public bool saveBlog(BlogFormModel blogFormModel)
        {
            var database = _client.GetDatabase("Blogs");

            if (!database.ListCollectionNames().ToList().Contains("Blog-Form-Table"))
            {
                database.CreateCollection("Blog-Form-Table");
            }

            database.GetCollection<BlogFormModel>("Blog-Form-Table").InsertOne(blogFormModel);

            return true;
        }
    }
}
