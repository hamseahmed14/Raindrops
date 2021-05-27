using System;
using System.Text;

namespace RaindropsLibrary
{
    public class Raindrops
    {

        public string PlingPlangPlong(int num)
        {
            StringBuilder result = new StringBuilder();
            if (num % 3 == 0)
            {
                result.Append("Pling");
            }
            if (num % 5 == 0)
            {
                result.Append("Plang");
            }
            if (num % 7 == 0)
            {
                result.Append("Plong");
            }
            return result.Length != 0 ? result.ToString() : num.ToString();
        }
    }
}
