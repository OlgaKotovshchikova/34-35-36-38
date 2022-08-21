using System;

namespace _34_35_36_38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи - 34, 35, 36, 38: ");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            switch (taskNumber)
            {
                case 34:
                    TaskThirtyfour();
                    break;
                case 35:
                    TaskThirtyfive();
                    break;
                case 36:
                    TaskThirtysix();
                    break;
                case 38:
                    TaskThirtyeight();
                    break;
                default:
                    Console.WriteLine("Такой задачи не существует");
                    break;
            }

            #region Задача 34
            /*  Задайте массив заполненный случайными положительными трёхзначными числами.
             *  Напишите программу, которая покажет количество чётных чисел в массиве.
              [345, 897, 568, 234] -> 2*/


            static void TaskThirtyfour()
            {
                int[] array = new int[10];
                Random rand = new Random(); 
               
                int count = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(100, 1000);
                    if (array[i] % 2 == 0)
                    {
                        count++;
                    }
                }
                Console.WriteLine(string.Join(", ", array));
                Console.WriteLine(count);
            }
            #endregion

            #region Задача 35
           /* Задайте одномерный массив из 123 случайных чисел в диапазоне[0, 150]. 
            * Найдите количество элементов массива, значения которых лежат в отрезке[10, 99].
            Пример для массива из 5, а не 123 элементов.В своём решении сделайте для 123
            [5, 18, 123, 6, 2]-> 1
            [1, 2, 3, 6, 2]-> 0
            [10, 11, 12, 13, 14]-> 5*/


            static void TaskThirtyfive()
            {
                int[] array = new int[123];
                Random rand = new Random();
                int count = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(0, 151);
                    if ((array[i] >= 10) && (array[i] <= 99))
                    {
                        count++;
                    }
                }
                Console.WriteLine(string.Join(", ", array));
                Console.WriteLine(count);
            }

            #endregion

            #region Задача 36
            /*Задайте одномерный массив, заполненный случайными числами.Найдите сумму элементов, стоящих на нечётных позициях.
            [3, 7, 23, 12] -> 19
            [-4, -6, 89, 6]-> 0*/


            static void TaskThirtysix()
            {
                int[] array = new int[10];
                Random rand = new Random();
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(1, 10);
                }
                for (int i = 1; i < array.Length; i+=2)
                {
                    sum += array[i];
                }
                Console.WriteLine(string.Join(", ", array));
                Console.WriteLine(sum);
            }
            #endregion

            #region Задача 38
            /*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            [3 7 22 2 78] -> 76*/

            static void TaskThirtyeight()
            {
                double[] array = new double[10];
                Random rand = new Random();
                double res = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Math.Round(rand.NextDouble(), 2);
                }
                double max = array[0];
                double min = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if (max < array[i]) max = array[i];
                    if (min > array[i]) min = array[i];
                }
                res = max - min;
                Console.WriteLine(string.Join(", ", array));
                Console.WriteLine(Math.Round(res, 2));
            }
            #endregion
        }
    }
}
