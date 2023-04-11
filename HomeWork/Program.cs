/*Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

void GenerateArray(int[] array)
{
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }

}

int GetCountOfEvenNumbers(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0){
            sum++;
        }
    }

    return sum;
}
/*
int[] array = new int[5];

GenerateArray(array);

PrintArray(array);

int Count = GetCountOfEvenNumbers(array);

Console.WriteLine(Count);
*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int GetSumOfOddNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    }
    return sum;
}
/*

int[] array = new int[5];

GenerateArray(array);

PrintArray(array);

int SumOfNumbers = GetSumOfOddNumbers(array);

Console.WriteLine(SumOfNumbers);
*/

/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */


int GetMinNumberOfArray(int[] array)
{
    
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min){
            min = array[i];
        }
    }
    return min;
}

int GetMaxNumberOfArray(int[] array)
{
    
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max){
            max = array[i];
        }
    }
    return max;
}

int[] array = new int[5];

GenerateArray(array);

PrintArray(array);

int minnumber = GetMinNumberOfArray(array);

int maxnumber = GetMaxNumberOfArray(array);

int difference = maxnumber - minnumber;

Console.WriteLine(difference);

