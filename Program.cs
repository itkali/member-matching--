using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Даны две последовательности целых чиселa1, a2, …an и b1, b2, …bnВсе члены последовательностей - различные числа.
            Найти, сколько членов первой последовательности совпадают с членами второй последовательности.*/

            Console.Write("Введите размер массива А: ");
            int sizearr1 = Convert.ToInt32(Console.ReadLine()); // ввод размерности массива A
            Console.Write("Введите размер массива B: ");
            int sizearr2 = Convert.ToInt32(Console.ReadLine()); // ввод размерности массива B
            int[] array_a = new int[sizearr1]; // объявление массива A
            int[] array_b = new int[sizearr2]; // объявление массива B
            int counter = 0; // переменная для подсчета повторений
            Random rnd = new(); // объявление рандома

            Console.WriteLine("Массив А:");
            for (int i = 0; i < array_a.Length; i++) // цикл наполнения массива рандомными числами
            {
                array_a[i] = rnd.Next(50); // генерация и наполнение массива рандомными числами
                Console.Write(array_a[i] + " | "); // вывод массива для удобства
            }

            Console.WriteLine("\nМассив B:");
            for (int i = 0; i < array_b.Length; i++) // цикл наполнения массива рандомными числами
            {
                array_b[i] = rnd.Next(50); // генерация и наполнение массива рандомными числами
                Console.Write(array_b[i] + " | "); // вывод массива для удобства
            }

            for (int i = 0; i < array_a.Length; i++) // цикл сравнивания членов первой последовательности со второй
            {
                for (int j = 0; j < array_b.Length; j++)
                {
                    if (array_a[i] == array_b[j]) // проверка на совпадение
                    {
                        counter++; // увеличение счетчика повторений
                        break; // завершение цикла
                    }
                }
            }
            Console.WriteLine("\n" + counter + " совпадений членов первой последовательности с членами второй последовательности.");
        }
    }
}
