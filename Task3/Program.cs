using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());  // считываю количество элементов
            string s = Console.ReadLine(); // считываю строку со значениями элементов
            string[] ss = s.Split(); // разделяю элементы строки
            int[] a = new int[p]; // создаю пустой массив чисел
            for (int i = 0; i < p; i++)
            {
                a[i] = int.Parse(ss[i]); // присваиваю элементу массива соответствующий элемент строки
            }

            for (int i = 0; i < p; i++)
            {
                Console.Write(a[i] + " " + a[i] + " "); // вывожу элемент и повторяю его
            }
        }
    }
}
