using NewCenter.Repository;
using NewCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NewCenter.DataAccess.Repository
{
    public class NewsRepository : BasicRepository<NewsModel>
    {
        public NewsRepository(DbContext context) : base(context)
        {
        }
    }
}
