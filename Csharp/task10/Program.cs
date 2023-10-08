/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
void DZ_2_1()
{ 
int num=int.Parse(Console.ReadLine());
int a,b=0,c=0;
a=num;
int i=2;
int [] ar=new int[3];
do{
  a=num/10;
  b=a*10;
  c=num-b;
  num=a;
  ar[i]=c;
  i=i-1;
}
while(a>1);
Console.WriteLine(ar[1]);
} 
DZ_2_1();


