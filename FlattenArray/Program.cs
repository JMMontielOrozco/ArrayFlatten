using FlattenArray.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(new ArrayList(){ 1,2,3,new ArrayList() {8,9,19 } });
            list.Add(20);
            list.Add(16);
            list.Add(15);

            foreach (var item in ArrayFlatten.FlatArray(list))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
