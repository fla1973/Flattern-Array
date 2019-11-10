using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova
{
    class ManageArray
    {
        static void Main(string[] args)
        {
            Object[] array = new Object[2];
            array[0] = new Object[3];
            ((Object[])(array[0]))[0] = 1;
            ((Object[])(array[0]))[1] = 2;
            ((Object[])(array[0]))[2] = new Object[1];
            ((Object[])(((Object[])(array[0]))[2]))[0] = 3;
            array[1] = 4;

            Console.WriteLine("Input [[1,2,[3]],4]   -->   Result [1, 2, 3, 4]");
            ArrayList result = new ArrayList();

            try
            {
                merge(array, result);
                //  Show the result.

                Console.Write("[");
                foreach (var item in result)
                    Console.Write(item + ", ");
                Console.Write("]");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void merge(Object[] array, ArrayList list)
        {
            for (int i = 0; (i < array.Length); i++)
            {
                if ((array[i] is Object[]))
                {
                    merge(((Object[])(array[i])), list);
                }

                if ((array[i] is int))
                {
                    list.Add(((int)(array[i])));
                }
                else { }
            }

        }

    }
}
