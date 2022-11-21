// Задача 50. Напишите программу, которая будет принимать от пользователя
// позицию (M, N) двумерного массива и возвращать значение элемента, стоящего в этой позиции. 
// Если такой позиции в массиве нет, то сообщить об этом пользователю. 
// Сгенерировать массив случайным образом. Размерность массива определить самостоятельно.
// Использование методов для заполнения массива обязательно. Остальное можно реализовать в главной программе.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// M = 1, N = 7 -> В массиве отсутствует элемент в такой позиции.

Console.WriteLine("Введите номер строки ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [5, 5];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("Такого элемента нет ");
}
else
{
    Console.WriteLine($" значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}