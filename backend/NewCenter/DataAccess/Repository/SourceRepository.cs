using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewCenter.Repository;
using NewCenter.Models;
using Microsoft.EntityFrameworkCore;

namespace NewCenter.DataAccess.Repository
{
    public class SourceRepository : BasicRepository<SourceModel>
    {
        public SourceRepository(DbContext context) : base(context)
        {
        }
    }
}
