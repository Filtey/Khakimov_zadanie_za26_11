using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khakimov_zadanie_za26_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дан массив целых чисел(читается из файла). 
            //    Используя методы LINQ, выбрать 4 элемента,
            //    начиная с шестого и отсортировать их по возрастанию:
            //    (результат вычисления обьявлен переменной r, данные
            //    передаются в переменную i).
            try
            {
                StreamReader sr = File.OpenText("file.txt");

                string[] m = sr.ReadLine().Split(' ');
                int[] mas = new int[m.Length];

                Console.WriteLine("Массив:");
                for (int i = 0; i < m.Length; i++)
                {
                    mas[i] = int.Parse(m[i]);
                    Console.Write(mas[i] + " ");
                }

                List<int> list = mas.Skip(6).ToList();
                list.Sort();
                Console.WriteLine("\nОтсортированный список, начиная с 6 элемента:");
                foreach (int r in list) Console.Write(r+" ");
            }

            catch (FileNotFoundException) { Console.WriteLine("Файл не найден!"); }
            catch (NullReferenceException) { Console.WriteLine("Файл пуст!"); }
            Console.ReadKey();

        }
    }
}
