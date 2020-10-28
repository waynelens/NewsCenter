using NewCenter.Models;
using NewCenter.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NewCenter.DataAccess.Repository
{
    public class CommentRepository:BasicRepository<CommentModel>
    {
        public CommentRepository(DbContext context) : base(context)
        {

        }
    }
}
