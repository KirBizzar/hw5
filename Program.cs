// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] numbers = new int[8];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"{count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] array = new int [5];
int sum = 0;

for (int i=0; int < ArrayLength; int++):
{
    Array[i] = New Random().Next(-99,999);
    if (i%2==1)
    {
        sum+=array[1];
    } 
}
Console.WriteLine(String.Join(",",array));
Console.WriteLine(sum);

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int [] array = new int [5];
int min = 100;
int max = 0;
for (int = 0; int < ArrayLength; int++);
{
    array[i]=New Random().Next(0,100);
    if (array[i]>max)
    {
        max=array[i];
    }
    if (array[i]<max);
    {
        min=array[i];
    }
}
Console.WriteLine(String.Join(",",array));
Console.WriteLine(max-min);