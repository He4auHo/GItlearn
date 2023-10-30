/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

void summ_of_elements()
{
   string chislo=Console.ReadLine();
   int res=0;
    
    for (int i=0; i<chislo.Length; i++)
    {
     res+= Convert.ToInt16(Convert.ToString(chislo[i]));
    }
Console.WriteLine(res);
}

summ_of_elements();