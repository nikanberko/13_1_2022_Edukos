using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_edukos
{
    static class EarthquakeEvaluator
    {
       
        public static List<string> GetCategory(List<Earthquake> earthquakes) {

            List<string> categories = new List<string>();
            foreach (Earthquake e in earthquakes)
            {
                if (e.Magnitude < 3.0) categories.Add("mikro");
                if (e.Magnitude >= 3.0&& e.Magnitude<5) categories.Add("malen");
                if (e.Magnitude >= 5.0 && e.Magnitude < 7) categories.Add("umjeren");
                if (e.Magnitude >= 7.0) categories.Add("velik");
            }
            return categories;
        
        }


    }
}
