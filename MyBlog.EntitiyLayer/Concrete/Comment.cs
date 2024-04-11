using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.EntitiyLayer.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
    }
}
