/* Задача №31.

int[] array = GenerateArray(12);
PrintArray(array);

int sum =CalculateSumPositiveAndNegativeNumbers(array);
Console.WriteLine(sum);



int [] GenerateArray(int length)
{
    int[] array = new int[length];

    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-9, 10);
    }

    return array;
}


void PrintArray(int[] array){

    Console.WriteLine(string.Join(",", array));
}

int CalculateSumPositiveAndNegativeNumbers(int[] array){

    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0){

            sumPositive += array[i];
        
        }
        else{
            sumNegative += array[i];
        }        
    }

    return sumNegative + sumPositive;
}
*/

/* Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

void GenerateArray(int[] array)
{
    

    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 10);
    }

}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

void TurnIntoNegativeOrPositive(int[] array){

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}
/*
int[] array = new int[5];

GenerateArray(array);

PrintArray(array);

TurnIntoNegativeOrPositive(array);

PrintArray(array);

*/
/*
Задача 33: Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет 3; массив [6, 7, 19, 345, 3] -> да

*/


String FindNumberInAraay(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == number){

            return "Да";
        } 
    }
    return "Нет";
}

/*
int[] array = new int[10];


GenerateArray(array);

PrintArray(array);

Console.WriteLine(FindNumberInAraay(array, 5));
*/

/*Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].*/




int FindSumOfSoughtNumbers(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {

        if(array[i] < 100 && array[i] > 9){

            sum++;
        }
        
    }

    return sum;

}

/*
int[] array = new int[123];

GenerateArray(array);

int SumOfNumbers = FindSumOfSoughtNumbers(array);


Console.WriteLine($"Колличество элементов = {SumOfNumbers}");

*/

/*Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

int[] array = new int[5];

GenerateArray(array);

PrintArray(array);

int[] array2 = GetArrayProductOfPairsOfNumbers(array);

PrintArray(array2);

int[] GetArrayProductOfPairsOfNumbers(int[] array)
{
    int[] array2 = new int[array.Length / 2 + array.Length % 2];
    

    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
    {
    
        if(i == (array.Length - 1 - i)){
            
            array2[i] = array[i];
            return array2;
        }
        else{
            array2[i] = array[i] * array[array.Length - 1 - i];
        }
       
    }

    return array2;
}

















