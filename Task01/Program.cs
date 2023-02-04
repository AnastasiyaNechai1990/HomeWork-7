/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76 

Console.Clear();

double[] GetArray(int size)
{
    double[] r = new double[size];
    for (int i = 0; i < size; i++)
    {
         r[i] = Convert.ToDouble(new Random().Next(100)/10.00);
    }
    return r;
}

double maxNumberArray(double[] array, double[] number)
{
    double max = number[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < number[i])
        {
             max = number[i];
        }
        
    }
    return max;
}
double[] array = GetArray(5);
Console.WriteLine(String.Join("; ", array));
double[] number = array;
double max = maxNumberArray(array, number);


double minNumberArray(double[] array, double[] number2)
{
    double min = number2[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > number2[i])
        {
            min = number2[i];
        }
       
    }
    return min;
}
double[] number2 = array;
double min = minNumberArray(array, number2);
double result = 0;

result = max - min;

Console.WriteLine($"Разница максимального и минимального элементов -> {result:F1}");*/

/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/