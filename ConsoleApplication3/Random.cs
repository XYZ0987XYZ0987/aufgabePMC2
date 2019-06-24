using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Random
    {
        public string random(string[] arr)
        {
            System.Random random = new System.Random();
            return arr[random.Next(0, arr.Length)];
        }
    }
}
