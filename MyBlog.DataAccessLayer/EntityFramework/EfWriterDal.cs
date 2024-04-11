using MyBlog.DataAccessLayer.Abstract;
using MyBlog.DataAccessLayer.Repositories;
using MyBlog.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccessLayer.EntityFramework
{
    public class EfWriterDal : GenericRepository<Writer>, IWriterDal
    {
        public int GetWriterCount()
        {
            //yazar sayısını getiren sorgu
            return 0;
        }

    }
}
