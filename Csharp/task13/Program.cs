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
DZ_2_2();