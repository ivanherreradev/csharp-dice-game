using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieSet
{
    public class Die
    {
        private int[] Numbers { get; set; }

        public Die()
        {
            Numbers = new int[6] { 1, 2, 3, 4, 5, 6 };
        }

        public int Roll()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 6);

            return Numbers[randomNumber];
        }
    }
}
