using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_6.SacendCalc
{
     class CalcInSameClass
    {
        //static void Main(string[] args)
        //{
        //    int ch;
        //    double Result=0;
        //    do
        //    {
        //        Console.WriteLine($"Welcome to Our Calc V2 , \n " +
        //                          $"pls Choose The Process from List \n" +
        //                          $"1.+ \n" +
        //                          $"2.- \n" +
        //                          $"3.X \n" +
        //                          $"4.÷ \n" +
        //                          $"5.Close The Calc ");
        //        ch = int.Parse(Console.ReadLine());

        //        Console.WriteLine("pls Enter First Number");
        //        double num1 = double.Parse(Console.ReadLine());

        //        Console.WriteLine("pls Enter Secand Number");
        //        double num2 = double.Parse(Console.ReadLine());

        //        switch (ch)
        //        {
        //            case 1:
        //                Result = Static_Add(num1,num2);
        //                break;
        //            case 2:
        //                Result = Static_Sub(num1,num2);
        //                break;
        //            case 3:
        //                Result = Static_Multi(num1,num2);
        //                break;
        //            case 4:
        //                Result = Static_Divi(num1, num2);
        //                break;
        //            case 5:
        //                Console.WriteLine("Exit...");
        //                break;
        //            default:
        //                Console.WriteLine("Invalid Number , Pls Choose From List ");
        //                break;
        //        }
        //        Console.WriteLine($"The Result is : {Result}");

        //     } while (ch != 5);
        //}


     public   static double Static_Add( double Num1,double Num2)
        {
            return Num1 + Num2;
        }
        static double Static_Sub(double Num1, double Num2)
        {
            return Num1 - Num2;
        }
        static double Static_Multi(double Num1, double Num2)
        {
            return Num1 * Num2;
        }
        static double Static_Divi(double Num1, double Num2)
        {
            return Num1 / Num2;
        }

    }
}
