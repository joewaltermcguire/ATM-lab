using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {

            string[] fruit = new string[6];
            fruit[0] = "mangos";//in the drawer with an index of 0, put "mangos"
            fruit[1] = "apples";
            fruit[2] = "kiwis";
            fruit[3] = "pineapples";
            fruit[4] = "oranges";
            fruit[5] = "papayas";

            
           
                for (int i = 0; i < fruit.Length; i++)
                {
                Console.WriteLine(fruit[i]);
                }
               
           
        }
    }
}
