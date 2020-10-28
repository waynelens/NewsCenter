using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewCenter.Models;
using NewCenter.Repository;

namespace NewCenter.DataAccess.Repository
{
    public class UpvoteRepository:BasicRepository<UpvoteModel>
    {
        public UpvoteRepository(DbContext context) : base(context)
        {
        }

    }
}
