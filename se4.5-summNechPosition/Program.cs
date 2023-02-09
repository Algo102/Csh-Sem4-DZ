// Найти сумму чисел одномерного массива стоящих на нечетной позиции
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
Console.WriteLine("------------");
int summ = 0;
for (int i = 1; i < array.Length; i++)
  if (i % 2 != 0)
  {
    summ = summ + array[i];
    Console.WriteLine($"Элемент № {i}. Значение {array[i]}. Сумма {summ}");
  }
    
Console.WriteLine("------------");
Console.WriteLine("Итого " + summ);
