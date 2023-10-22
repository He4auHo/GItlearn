/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int A=Convert.ToInt16(Console.ReadLine());
int B=Convert.ToInt16(Console.ReadLine());
int res=1;
for(int i=1;i<=B;i++){
res=res*A;
}
 Console.WriteLine(res);   
