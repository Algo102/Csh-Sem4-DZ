// Задать массив, заполнить случайными положительными трёхзначными числами
int ReadInt (string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

void PrintArray(int[] array)
{
  for(int i = 0; i < array.Length; i++)
    Console.Write(array[i]+" ");
   Console.WriteLine();
}


int lengt = ReadInt("Enter the number of elements in the array");

int[] array = new int[lengt];
  for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);

PrintArray(array);