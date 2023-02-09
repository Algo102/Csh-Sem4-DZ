// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
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


int length = ReadInt("Enter the number of elements in the array");
int left = ReadInt("Enter the lower value of the element");
int right = ReadInt("Enter the higher value of the element");

int[]array = GreatArrayRand(length, left, right);

PrintArray(array);

int a = 0;
for (int i = 0; i < length/2; i++)
{
  Console.WriteLine($"{i}) {array[i]} * {array[length-1-a]} = {array[i]*(array[length-1-a])}");
  a++;
}

