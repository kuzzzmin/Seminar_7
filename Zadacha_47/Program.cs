//Задача 47. Запросите от пользователя размерности двумерного массива. Напишите метод для заполнения массива случайными числами.
//Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). Округлите значения, генерируемые Random до двух знаков после запятой.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.WriteLine("Введите количество строк ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов ");
int N = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[M, N];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}    