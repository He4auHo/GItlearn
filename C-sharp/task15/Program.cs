
/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
void task15(){
  //int num=int.Parse(Console.ReadLine());
  int num=Convert.ToInt16(Console.ReadLine());
if(num>5&&num<8){
    Console.WriteLine("да");
  }
  else if(num>0&&num<6){
    Console.WriteLine("нет");}
  else{
    Console.WriteLine("нет такого дня недели");}
}
task15();
