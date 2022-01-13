using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_edukos
{
    class PictureAD:Ad
    {
        string link;
        string picDescription;

        public PictureAD(string link, string picDescription, string contents, string title):base(contents, title)
        {
            this.link = link;
            this.picDescription = picDescription;
        }
        public override bool ShowCheck(string word)
        {
            return base.ShowCheck(word) && picDescription.ToLower().Contains(word.ToLower()) && link.ToLower().Contains(word.ToLower());

        }
    }
}
