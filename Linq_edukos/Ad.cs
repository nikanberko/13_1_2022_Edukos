using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_edukos
{
    class Ad
    {

        string contents;
        List<string> keywords;
        string title;

        public Ad(string contents, string title)
        {
            this.contents = contents;
            keywords = new List<string>();
            this.title = title;
        }

        public static bool operator ==(Ad lhs, Ad rhs)
        {
            return lhs.title == rhs.title && lhs.keywords == rhs.keywords;
        }
        public static bool operator !=(Ad lhs, Ad rhs)
        {
            return !(lhs == rhs);
        }

        public virtual bool ShowCheck(string word)
        {


            if(title.ToLower().Contains(word.ToLower()) || contents.ToLower().Contains(word.ToLower()) || keywords.ToString().ToLower().Contains(word.ToLower()))
            {
                return true;
            }
            return false;
        }
    }
}
