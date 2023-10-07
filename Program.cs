/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
using System.Buffers;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

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
  //Console.WriteLine($"c={c}");//проверка
  //Console.WriteLine($"b={b}");//проверка
  //Console.WriteLine($"a={a}");//проверка
  num=a;
  ar[i]=c;
  //Console.WriteLine($"i={i}");//проверка
  //Console.WriteLine($"ar[{i}]={ar[i]}");//проверка
  i=i-1;
}
while(a>1);
//Console.WriteLine($"{ar[0]}{ar[1]}{ar[2]}");
Console.WriteLine(ar[1]);
} 
//DZ_2_1();



/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
void DZ_2_2(){
int num=int.Parse(Console.ReadLine());
int a,b=0,c=0;
a=num;
int i=2;
int [] ar=new int[3];
do{
  a=num/10;
  b=a*10;
  c=num-b;
  //Console.WriteLine($"c={c}");//проверка
  //Console.WriteLine($"b={b}");//проверка
  //Console.WriteLine($"a={a}");//проверка
  num=a;
  ar[i]=c;
  //Console.WriteLine($"i={i}");//проверка
  //Console.WriteLine($"ar[{i}]={ar[i]}");//проверка
  i=i-1;
}
while(a>1);
//Console.WriteLine($"{ar[0]}{ar[1]}{ar[2]}");
//Console.WriteLine(ar[2]);
  if(ar[0]==0){
    Console.WriteLine("третьей цифры нет");
  }
  else{
    Console.WriteLine(ar[2]);}
}
//DZ_2_2();


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
void DZ_2_3(){
  int num=int.Parse(Console.ReadLine());
if(num>5){
    Console.WriteLine("да");
  }
  else{
    Console.WriteLine("нет");}
}
DZ_2_3();