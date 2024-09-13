using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Loading_DataAnnotations_Examples
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogName { get; set; }
        public List<Post> Posts { get; set; }
    }
}
