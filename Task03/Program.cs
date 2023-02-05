/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом 
столбце. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

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
            Console.Write(" {0,6:F0} " ,inArray[i,j]);    
        }
        Console.WriteLine();    
    }
}

double[] ArithmeticMean(int[,] forArithmeticValue)
{
    
    double[] arraySredValues = new double[forArithmeticValue.GetLength(1)];
    
    for (int i = 0; i < forArithmeticValue.GetLength(1); i++)
    {
        double summ = 0;

        for (int j = 0; j < forArithmeticValue.GetLength(0); j++)
        {
            summ += forArithmeticValue[j, i];
                
        }
        arraySredValues[i] = summ / forArithmeticValue.GetLength(0);
        
    }
    return arraySredValues;
}

void PrintNewArray(double[] newArray)
{
    for (int i = 0; i < newArray.Length; i++) 
    {
    Console.Write(" {0,6:F2} ", newArray[i]);
    }
}

void Main()
{
    Console.Clear();
    Console.Write("Введите количество строк: ");
    int m = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество столбцов: ");
    int n = int.Parse(Console.ReadLine()!);

    int[,] array = GetArray(m, n, 0, 10);
    PrintArray(array);
    Console.WriteLine();
    double[] averageValue = ArithmeticMean(array);
    PrintNewArray(averageValue);

}
Main();

