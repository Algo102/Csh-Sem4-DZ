// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int ReadInt (string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

int[] GreatArrayRand(int lengt, int left, int right)
{
  int[] array = new int[lengt];
  for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(left, right+1);
  return array;
}

void PrintArray(int[] array)
{
  for(int i = 0; i < array.Length; i++)
    Console.Write(array[i]+" ");
   Console.WriteLine();
}


int lengt = ReadInt("Enter the number of elements in the array");
int left = ReadInt("Enter the lower value of the element");
int right = ReadInt("Enter the higher value of the element");

int[]array = GreatArrayRand(lengt, left, right);

PrintArray(array);
int max = -99999999;
int min =  99999999;
for(int i = 0; i < array.Length; i++)
  if (array[i]>max) max=array[i];

for(int i = 0; i < array.Length; i++)
    if (array[i]<min) min=array[i];
Console.WriteLine("Максимальный элемент " + max);
Console.WriteLine("Минимальный элемент " + min);

Console.WriteLine("Разница между МАКС и МИН " + (max-min));
