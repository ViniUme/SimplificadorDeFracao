using System;
using System.Linq;

namespace Dec2Bin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("======Simplificador de Fração======");
            Console.WriteLine("===================================");
            Console.WriteLine(" ");

            int[] numbers = new int[2];
            Console.Write("Numerador da fração: ");
            numbers[0] = Convert.ToInt16(Console.ReadLine());

            Console.Write("Denominador da fração: ");
            numbers[1] = Convert.ToInt16(Console.ReadLine());
            
            int[] resto = new int[2];
            int numberMin = numbers.Min();
            while(numberMin != 1){
                resto[0] = numbers[0] % numberMin;
                resto[1] = numbers[1] % numberMin;

                if(resto[0] == 0 && resto[1] == 0){
                    numbers[0] = numbers[0] / numberMin;
                    numbers[1] = numbers[1] / numberMin;
                }
                else{
                    numberMin = numberMin - 1;
                }
            }
            Console.WriteLine(numbers[0] + " / " + numbers[1]);
        }
    }
}