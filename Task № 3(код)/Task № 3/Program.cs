using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов в массиве:\t");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[num];


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"\nВведите элементы массива под индексом {i}:\t");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Массив у нас теперь такой:");
            Console.Write("[");
            Console.Write(string.Join(",", array) + "]\n");
            Console.WriteLine("Элементы массива кратные 3:");

            List<int> numbers = new List<int>();
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                {
                    numbers.Add(array[i]);
                    
                }
            }
            Console.Write("[");
            Console.Write(string.Join(",", numbers) + "]");
           

        }


    }

}