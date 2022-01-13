using System;
using System.Collections.Generic;
using System.Linq;
namespace Linq_edukos
{
    class Program
    {
      

        public static void RunDemo()
        {
            Earthquake shallow = new Earthquake(4.56, 2.22);
            Earthquake deep = new Earthquake(4.56, 2.22, DateTime.Now);
            Console.WriteLine(shallow);
        }
        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            words.Add("Nikola");
            words.Add("Pavkovic");

            List<Ad> ads = new List<Ad>();
            ads.Add(new Ad("isdjfpisdjfi", "Nikola"));
            ads.Add(new Ad("Pavkovic", "Nikola"));

            try
            {
                Console.WriteLine(AdManager.GetNumOfAds(words, ads));
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

          
            


        }
    }
}
