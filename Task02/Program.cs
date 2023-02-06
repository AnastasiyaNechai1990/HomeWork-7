/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue+1);
        }    
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t ");    
        }
        Console.WriteLine();    
    }
}

void ElementArray(int[,] arrayOfRandomNumbers, int row, int col)
{
    int elementValue = 0;
    if (row - 1 < arrayOfRandomNumbers.GetLength(1) && col - 1 < arrayOfRandomNumbers.GetLength(0) && row >= 0 && col >= 0)
    {
        elementValue = arrayOfRandomNumbers[row, col];
        Console.WriteLine($"\n Элемент ячейке ({row},{col}) равен {elementValue}");
    }
    else
    {
        Console.WriteLine($"\n Ячейки ({row};{col}) не существует в данном массиве");
    }
}

void Main()
{
    Console.Clear();
    int m = new Random().Next(4, 10);
    int n = new Random().Next(4, 10);
    Console.WriteLine();
    int[,] array = GetArray(m, n, 0, 10);
    PrintArray(array);
    Console.Write("Введите номер строки: ");
    int lineNumber = int.Parse(Console.ReadLine()!);
    Console.Write("Введите номер столбца: ");
    int row = lineNumber; 
    int columnNumber = int.Parse(Console.ReadLine()!);
    int col = columnNumber;
    ElementArray(array, row, col);

}
Main();
