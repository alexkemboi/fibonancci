using System;
public class Fibonacci{
         public static int[] ComputeSeries(int length){
         int firstNumber = 0;
        int secondNumber = 1;
        int[] series = new int[length];
        series[0] = firstNumber;
        series[1] = secondNumber;
        for(int i=2;i<length;i++){
            series[i] = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = series[i];
        }
        return series;
    }
}
public class Program{
    public static void Main(string [] args){
        int[] series = Fibonacci.ComputeSeries(5);
        foreach(int number in series){
          Console.Write(number+" ");
        }
    }
}