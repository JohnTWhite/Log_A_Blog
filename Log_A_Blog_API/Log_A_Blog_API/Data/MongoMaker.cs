using Log_A_Blog_API.Models;
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
        public bool saveBlog(BlogFormModel blogFormModel)
        {
            throw new NotImplementedException();
        }
    }
}
