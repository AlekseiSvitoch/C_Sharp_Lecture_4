Console.Clear();
// string[,] table = new string[2, 5]; // у нас будет 2 строки и 5 столбцов
// // table[0, 0]  table[0, 1]  table[0, 2]  table[0, 3]  table[0, 4]   - это первая строка массива
// // table[1, 0]  table[1, 1]  table[1, 2]  table[1, 3]  table[1, 4]   - это вторая строка массива

// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++) // цикло по строкам с кол-вом 2
// {
//     for (int columns = 0; columns < 5; columns++) // цикл по столбцам с кол-вом 5
//     {
//         Console.Write($"-{table[rows, columns]}-");
//     }
// Console.WriteLine(); // принудительный переход на новую строку, чтобы значения выводились красиво
// }


// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // щелкаем циклом строки
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // щелкаем циклом столбцы
//         {
//             Console.Write($"{matr[i, j]} "); // выводим числа через пробел в строчку
//         }
//     Console.WriteLine(); // принудительный переход на новую строку, чтобы значения выводились красиво
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// int[,] matrix = new int[3, 4];
// FillArray(matrix);
// PrintArray(matrix);





//===== Рекурсия. Пример через закрашивание.

// int[,] pic = new int[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++) // щелкаем циклом строки
//     {
//         for (int j = 0; j < image.GetLength(1); j++) // щелкаем циклом столбцы
//         {
//             // Console.Write($"{image[i, j]} "); // выводим числа через пробел в строчку

//             if (image[i,j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//     Console.WriteLine(); // принудительный переход на новую строку, чтобы значения выводились красиво
//     }
// }

// void FillImage(int row, int col)
// {
//     if (pic[row, col] == 0) // задаем условие, при выполнении которого
//     {
//         pic[row, col] = 1; // мы будем красить единицей позицию
//         FillImage(row - 1, col); // делаем шаг вверх, если позиция равна 0, то красим единичкой
//         FillImage(row, col - 1); // делаем шаг влево, если позиция равна 0, то красим единичкой
//         FillImage(row + 1, col); // делаем шаг вниз, если позиция равна 0, то красим единичкой
//         FillImage(row, col + 1); // делаем шаг вправо, если позиция равна 0, то красим единичкой
//     }
// }

// FillImage(13, 13); // указываем случайную точку, от которой идем закрышавать по алгоритму
// PrintImage(pic);





// int Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }

// Console.WriteLine(Factorial(3));





// Числа Фибоначчи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n) // описали функцию вычисления числа Фибоначчи
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 10; i++) // запускаем функцию с расчетом числа Фибоначчи f(10) с помощью цикла
{
    Console.WriteLine(Fibonacci(i));
}