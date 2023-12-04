// задача 1
// using System;

// class Program
// {
//     static void Main()
//     {
//         while (true)
//         {
//             Console.Write("Введите целое число (или 'Q' для выхода): ");
//             string input = Console.ReadLine();

//             if (input.ToLower() == "Q")
//             {
//                 Console.WriteLine("Программа завершена.");
//                 break;
//             }

//             if (int.TryParse(input, out int number))
//             {
//                 Console.WriteLine($"Вы ввели число: {number}");
//             }
//             else
//             {
//                 Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'Q' для выхода.");
//             }
//         }
//     }
// }




// Задача 2


// using System;

// class Program
// {
//     static void Main()
//     {
//         // Задаем размер массива
//         int arraySize = 10; // Можете выбрать любой желаемый размер

//         // Создаем объект Random для генерации случайных чисел
//         Random random = new Random();

//         // Создаем массив и заполняем его случайными трехзначными числами
//         int[] myArray = new int[arraySize];
//         for (int i = 0; i < arraySize; i++)
//         {
//             myArray[i] = random.Next(100, 1000);
//         }

//         // Выводим массив
//         Console.WriteLine("Сгенерированный массив:");
//         foreach (var number in myArray)
//         {
//             Console.Write(number + " ");
//         }
//         Console.WriteLine();

//         // Подсчитываем количество четных чисел
//         int evenCount = 0;
//         foreach (var number in myArray)
//         {
//             if (number % 2 == 0)
//             {
//                 evenCount++;
//             }
//         }

//         // Выводим количество четных чисел
//         Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");

//         Console.ReadLine(); // Ждем, чтобы консольное окно не закрылось сразу
//     }
// }

    

// Задача 3

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Пример одномерного массива
//         int[] myArray = { 1, 2, 3, 4, 5 };

//         // Выводим исходный массив
//         Console.WriteLine("Исходный массив:");
//         PrintArray(myArray);

//         // Переворачиваем массив
//         ReverseArray(myArray);

//         // Выводим перевернутый массив
//         Console.WriteLine("Перевернутый массив:");
//         PrintArray(myArray);

//         Console.ReadLine(); // Ждем, чтобы консольное окно не закрылось сразу
//     }

//     // Метод для вывода массива на экран
//     static void PrintArray(int[] arr)
//     {
//         foreach (var element in arr)
//         {
//             Console.Write(element + " ");
//         }
//         Console.WriteLine();
//     }

//     // Метод для переворачивания массива
//     static void ReverseArray(int[] arr)
//     {
//         int length = arr.Length;
//         for (int i = 0; i < length / 2; i++)
//         {
//             // Обмениваем значения между началом и концом массива
//             int temp = arr[i];
//             arr[i] = arr[length - 1 - i];
//             arr[length - 1 - i] = temp;
//         }
//     }
// }