/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int A=Convert.ToInt16(Console.ReadLine());
int B=Convert.ToInt16(Console.ReadLine());
int res=1;
for(int i=1;i<=B;i++){
res=res*A;
Console.WriteLine(A);
}
 Console.WriteLine(res);   


/*
int a,b=0,dd=0;
a=num;
int i=2;
int [] ar=new int[3];
do{
  a=num/10;
  b=a*10;
  dd=num-b;
  num=a;
  ar[i]=dd;
  i=i-1;
}
while(a>1);

} 
task10();
*/