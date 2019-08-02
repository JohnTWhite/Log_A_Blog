using BlogApi.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi.Data
{
    public interface IMongoMaker
    {
        bool saveBlog(BlogForm blogFormModel);
    }
    public class MongoMaker : IMongoMaker
    {
        IMongoClient _client;
        public MongoMaker(IMongoClient client)
        {
            _client = client;
        }

        public bool saveBlog(BlogForm blogFormModel)
        {
            try
            {
                var database = _client.GetDatabase("Blogs");

                if (!database.ListCollectionNames().ToList().Contains("Blog-Form-Table"))
                {
                    database.CreateCollection("Blog-Form-Table");
                }

                database.GetCollection<BlogForm>("Blog-Form-Table").InsertOne(blogFormModel);
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return true;
        }
    }
}
