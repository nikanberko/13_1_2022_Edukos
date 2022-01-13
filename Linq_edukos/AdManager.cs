using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_edukos
{
    static class AdManager
    {
        public static int GetNumOfAds(List<string> words, List<Ad> ads)
        {  
            int showCounter = 0;
            int numOfAdsToShow = 0;

            foreach(Ad ad in ads)
            {
                foreach(String word in words)
                {
                    if (ad.ShowCheck(word) == true)
                    {
                        showCounter++;
                    }
                   
                }
                if (showCounter > 0) { numOfAdsToShow++;  }

                showCounter = 0;
            }

            if (numOfAdsToShow == 0) throw new ArgumentException($"predano je ovoliko rijeci: {words.Count}");
            return numOfAdsToShow;


        }
    }
}
