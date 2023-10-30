
double[] array;
array = new double[] { 3, 7.4, 22.3, 2, 78 };
double max=0;double min;double result;
double FindMax(){

      for(int i=0; i<array.Length; i++){
  if (array[i]>max){
    max=array[i];
        }
    }
    return max;
   
}
double FindMin(){
min=max;
      for(int i=0; i<array.Length; i++){
  if (array[i]<min){
    min=array[i];
        }
    }
    return min;
}
    double CalcDifferenceBetweenMaxMin()
    {// Введите свое решение ниже
result=max-min;
return result;

    }
FindMax();
FindMin();
CalcDifferenceBetweenMaxMin();
System.Console.WriteLine(min);
 System.Console.WriteLine(max);
 System.Console.WriteLine(result);