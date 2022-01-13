using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_edukos
{
    interface IFilter
    {
        public Post GetPost(List<Post> posts);
        public List<string> GetTags(List<Post> posts);
            }
}
