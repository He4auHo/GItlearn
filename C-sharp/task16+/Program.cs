
//string num=Convert.ToString(Console.ReadLine());

string num=Console.ReadLine();
if (num.Length==5){
    if (num[0]==num[4]&&num[1]==num[3]){
        //return true;
        Console.WriteLine("палиндром");
    }
    else{
        Console.WriteLine("не палиндром");
    }
}
else{
    Console.WriteLine("не пятизначное");
    //return false;
}
