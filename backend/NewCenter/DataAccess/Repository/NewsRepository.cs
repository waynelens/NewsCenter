using NewCenter.Repository;
using NewCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Hangfire.Annotations;
using System.Runtime.InteropServices;

namespace NewCenter.DataAccess.Repository
{
    public class NewsRepository : BasicRepository<NewsModel>, INewsRepository
    {
        public NewsRepository(DbContext context) : base(context)
        {
        }

    }
}
