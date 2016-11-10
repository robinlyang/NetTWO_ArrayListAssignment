using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NetTWO_ArrayListAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList col = new ArrayList(1);
            string obj = "";
            Console.WriteLine("Enter a name or number");
            do
            {
                obj = Console.ReadLine();
                if(obj == "")
                {
                    obj = null;
                }
                if(obj != null)
                {
                    col.Add(obj);
                }
            } while (obj != null);
            Console.WriteLine("Size: " + col.Count);
            col.Sort();
            for(int x = 0; x < col.Count; x++)
            {
                Console.WriteLine(col[x]);
            }

            Console.ReadLine();
        }
    }
}
