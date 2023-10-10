/*Урок 9. Рекурсия
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

static void natur_v_promezhutke(int na4alnoe, int kone4noe){
kone4noe=Convert.ToInt16(Console.ReadLine());
na4alnoe=1;
int na_pe4at=kone4noe;
if(na_pe4at>na4alnoe)
Console.Write(na_pe4at) ;
}

natur_v_promezhutke (1,1);

