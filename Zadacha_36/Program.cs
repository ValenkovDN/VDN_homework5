//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int a = new Random().Next(1, 20);
int[] array = new int[a];
void FillArray(int[] massiv)
{
    int count = massiv.Length;
    for(int index = 0; index < count; index++)
    {
       massiv [index] = new Random().Next(-999, 999);
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
       if(i % 2 != 0) even = even +cal[i];
    }
    Console.WriteLine($"Сумма элементов стоящих на нечётных позициях {even}");
}

FillArray(array);
Vivod (array);
EvenNumbered(array);