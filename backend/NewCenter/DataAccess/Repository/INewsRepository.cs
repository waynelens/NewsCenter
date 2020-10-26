using NewCenter.Models;
using NewCenter.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.DataAccess.Repository
{
    public interface INewsRepository : IBasicRepository<NewsModel>
    {
    }
}
