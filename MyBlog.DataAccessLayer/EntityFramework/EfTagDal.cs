﻿using MyBlog.DataAccessLayer.Abstract;
using MyBlog.DataAccessLayer.Repositories;
using MyBlog.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccessLayer.EntityFramework
{
    public class EfTagDal:GenericRepository<Tag>,ITagDal
    {
    }
}
