using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenArray.Core
{
    public class ArrayFlatten
    {

        public static int[] FlatArray(ArrayList entry)
        {
            List<int> result = new List<int>();

            foreach (var element in entry)
            {
                if (element is int)
                {
                    result.Add((int)element);
                }
                else if(element is ArrayList)
                {
                    result.AddRange(FlatArray((ArrayList)element));
                }
                else
                {
                    throw new Exception("Tipo de dato no soportado");
                }

            }
            
            return result.OrderBy(t=>t).ToArray();
        }

    }
}
