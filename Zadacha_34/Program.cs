/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.*/

int a = new Random().Next(1, 100);
int[] array = new int[a];
void FillArray(int[] massiv)
{
    int count = massiv.Length;
    for(int index = 0; index < count; index++)
    {
       massiv [index] = new Random().Next(100, 999);
    }
}

void Vivod (int[] col)
{
   int caunt = col.Length;
    for(int ind = 0;ind < caunt; ind++)
    {
       if(ind != col.Length - 1) Console.Write($"{col[ind]}, ");
       else Console.WriteLine($"{col[ind]} ");
    }
}

void EvenNumbered(int[] cal)
{
    int cant = cal.Length;
    int even = 0;
    for(int i = 0;i < cant; i++)
    {
       if(cal[i] % 2 == 0) even = even +1;
    }
    Console.WriteLine($"Колличество четных чисел в массиве {even}");
}

FillArray(array);
Vivod (array);
EvenNumbered(array);