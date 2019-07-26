using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var sort = new BubbleSort();
            var context = new Context(sort);
            context.Sort();
            context.PrintArray();
        }
        class Context
        {
            Strategy strategy;
            int[] array = { 5, 10, 1, 4, 7, 2, 9, 6, 3, 8 };

            public Context(Strategy strategy)
            {
                this.strategy = strategy;
            }

            public void Sort()
            {
                strategy.Sort(ref array);
            }

            public void PrintArray()
            {
                for (int i = 0; i < array.Length; i++)
                    Console.Write(array[i] + " ");

                Console.WriteLine();
            }
        }
        abstract class Strategy
        {
            public abstract void Sort(ref int[] array);
        }
        // Пузырьковая сортировка.
        class BubbleSort : Strategy
        {
            public override void Sort(ref int[] array)
            {
                Console.WriteLine("BubbleSort");

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = array.Length - 1; j > i; j--)
                    {
                        if (array[j] < array[j - 1])
                        {
                            int temp = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = temp;
                        }
                    }
                }
            }
        }

        // Сортировка выбором.
        class SelectionSort : Strategy
        {
            public override void Sort(ref int[] array)
            {
                Console.WriteLine("SelectionSort");

                for (int i = 0; i < array.Length - 1; i++)
                {
                    int k = i;

                    for (int j = i + 1; j < array.Length; j++)
                        if (array[k] > array[j])
                            k = j;

                    if (k != i)
                    {
                        int temp = array[k];
                        array[k] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
    }
}
