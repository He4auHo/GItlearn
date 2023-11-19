//Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    int result=Convert.ToInt32(Console.ReadLine());
    return result;
}


void PrintNumbers(int initialValue, int finalValue)
{
    if (initialValue<finalValue)
    {
        return;
    }
    PrintNumbers(initialValue-1,finalValue);
    if (initialValue%2==0){
    Console.Write($"{initialValue}\t");
    }
    
}
int M=ReadInt("введите начальное число диапазона: ");
int N=ReadInt("введите конечное  число диапазона: ");

PrintNumbers(N,M);
