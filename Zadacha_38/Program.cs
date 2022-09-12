// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

int a = new Random().Next(1, 20);
double[] array = new double[a];
void FillArray(double[] massiv)
{
    int count = massiv.Length;
    for(int index = 0; index < count; index++)
    {
       massiv [index] = Math.Round(new Random().Next(-100, 101) + new Random().NextDouble(),2);
    }
}

void Sorting (double[] sortarray)
{
   for (int i = 0; i < sortarray.Length-1; i++)
   {
      int minPostion = i;
      for (int j = i +1; j < sortarray.Length; j++)
      {
         if(sortarray[j] < sortarray[minPostion]) minPostion = j;
      }
      double temp = sortarray[i];
      sortarray[i] = sortarray[minPostion];
      sortarray[minPostion] = temp;
   }
}

void Vivod (double[] col)
{
   int caunt = col.Length;
    for(int ind = 0;ind < caunt; ind++)
    {
       if(ind != col.Length - 1) Console.Write($"{col[ind]}, ");
       else Console.WriteLine($"{col[ind]} ");
    }
}

void Difference(double[] cal)
{
    double cant = cal[cal.Length-1] - cal[0];
    Console.WriteLine($"Разница между максимальным и минимальным элементами: {cant}");
}

FillArray(array);
Sorting (array);
Vivod (array);
Difference(array);