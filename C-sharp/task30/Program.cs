using System;

public class Answer
{
    public static int CountEvenElements(int[] array)
    { 
    // Введите свое решение ниже
int posNumbers=0;
      for(int i=0; i<array.Length; i++){
  if (array[i]%2==0){
    posNumbers+=1;
  }
}
return posNumbers;
    }

    public static void PrintArray(int[] array)
    {
    // Введите свое решение ниже

for(int i=0; i<array.Length-1; i++){
   
  Console.Write(array[i]+"\t");
 
    }
     int a=array.Length-1;
      Console.Write(array[a]); //Тут все менять
      Console.Write("\n");
    }

// Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        Console.WriteLine("Массив:");
        PrintArray(array);
        int evenCount = CountEvenElements(array);
        Console.WriteLine($"Количество четных элементов: {evenCount}");
    }
}