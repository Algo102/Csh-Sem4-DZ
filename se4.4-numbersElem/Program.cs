// В одномерном массиве из 123 чисел найти количество элементов из отрезка включительно [10,99]
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
int start = ReadInt("Enter the beginning of the search range");
int finish = ReadInt("Enter the end of the search range");

int[]array = GreatArrayRand(lengt, left, right);

PrintArray(array);

int count = 0;
for (int i = 0; i < array.Length; i++)
  if (i >= start & i <= finish)
    count++;

Console.WriteLine(count);
