using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_edukos
{
    class InfluencerFilter:IFilter
    {
       
        public string Tag { get; set; }

        public InfluencerFilter(string tag)
        {
            Tag = tag;
        }



        public Post GetPost(List<Post> posts)
        {
           Post shortestPost= posts[0];

           foreach(Post post in posts)
            {
                if(post.Text.Length<shortestPost.Text.Length && post.Tags.Contains(Tag))
                {
                    shortestPost = post;
                }
            }
            return shortestPost;
        }

        public List<string> GetTags(List<Post> posts)
        {
            List<string> tags = new List<string>();

            foreach (Post post in posts)
            {
                foreach (post.Tags.Contains(Tag))
                {
                    if(tags.Contains(Tag)==false))
                    tags.Add(Tag);
                }
            }
        }
    }
}
