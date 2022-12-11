// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// int [] arr= new int[size];
// creatArray(arr);
// PrintArray(arr);
// int x = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] % 2 == 0)
//     {
//         x++;
//     }
// }    
// void creatArray (int [] num)
// {
//    for(int i=0; i< size; i++)
//    {
//         num [i]=new Random().Next(99, 999);
//    }
// }
// void PrintArray(int[] num) 
// {
//     for (int i = 0; i < num.Length; i++)
//     {
//         Console.Write(num[i] + " ");
//     }
//     Console.WriteLine();
// }
// if (x % 10 == 1)
// {
//     Console.WriteLine($"В массиве {x} четное число");
// }
// if (x % 10 == 2 || x % 10 == 3 || x % 10 == 4)
// {
//     Console.WriteLine($"В массиве {x} четных числа");
// }
// else

//     Console.WriteLine($"В массиве {x} четных чисел");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] num = new int[size];
// FillArrayRandomNumbers(num);
// Console.WriteLine("Массив: ");
// PrintArray(num);
// int sum = 0;

// for (int z = 0; z < num.Length; z+=2)
//     sum = sum + num[z];

//     Console.WriteLine($"Всего {num.Length} чисел, сумма элементов на нечётных позициях = {sum}");

// void FillArrayRandomNumbers(int[] num)
// {
//     for(int i = 0; i < num.Length; i++)
//         {
//             num[i] = new Random().Next(1,10);
//         }
// }
// void PrintArray(int[] num)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < num.Length; i++)
//         {
//             Console.Write(num[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] num = new double[size];
// FillArrayRandomNumbers(num);
// Console.WriteLine("Наш массив: ");
// PrintArray(num);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int x = 0; x < num.Length; x++)
// {
//     if (num[x] > max)
//         {
//             max = num[x];
//         }
//     if (num[x] < min)
//         {
//             min = num[x];
//         }
// }

// Console.WriteLine($"Всего {num.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void FillArrayRandomNumbers(double[] num)
// {
//     for(int i = 0; i < num.Length; i++)
//         {
//             num[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(double[] num)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < num.Length; i++)
//         {
//             Console.Write(num[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }












// Console.WriteLine("Hello, World!");
