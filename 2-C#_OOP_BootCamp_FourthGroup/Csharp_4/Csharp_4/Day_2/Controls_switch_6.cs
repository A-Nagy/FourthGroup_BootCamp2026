using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_4.Day_2
{
     class Controls_switch_6
    {
        //static void Main(string[] args)
        //{
        //    //## 🧠 Task 1: Day Name by Number

        //    //  **Objective:**
        //    // -Ask the user to enter a number from 1 to 7.
        //    // - Display the corresponding day of the week.

        //    //**Example:**
        //    //-Input: 3 → Output: Tuesday
        //    //- Input: 7 → Output: Saturday
        //    //Console.WriteLine("Pls Enter Number of Day 1 to 7 ");
        //    //int N_day = Convert.ToInt32(Console.ReadLine());

        //    //switch(N_day) 
        //    //{
        //    //    case 1:
        //    //        Console.WriteLine("Sat");
        //    //        break;
        //    //    case 2:
        //    //        Console.WriteLine("Sun");
        //    //        break;
        //    //    case 3:
        //    //        Console.WriteLine("man");
        //    //        break;
        //    //    case 4:
        //    //        Console.WriteLine("tus");
        //    //        break;
        //    //    case 5:
        //    //        Console.WriteLine("we");
        //    //        break;
        //    //    case 6:
        //    //        Console.WriteLine("thur");
        //    //        break;
        //    //    case 7:
        //    //        Console.WriteLine("Fri");
        //    //        break;
        //    //    default:
        //    //        Console.WriteLine("invalid Number"); 
        //    //        break;

        //    //}
        //    /*
        //     * ## 🧠 Task 2: Grade Description by Letter
        //    **Objective:**
        //    - Ask the user to enter a letter grade (A–F).
        //    - Display the corresponding performance description.
        //    **Descriptions:**
        //    - A → Excellent
        //    - B → Very Good
        //    - C → Good
        //    - D → Pass
        //    - F → Failed 
        //     */

        //    Console.WriteLine("Enter your grade letter A - F ");
        //    char grade =Convert.ToChar( Console.ReadLine().ToUpper());
        //    switch (grade) 
        //    {
        //        case 'A':
        //            Console.WriteLine("Excellent"); 
        //            break;
        //        case 'B':
        //            Console.WriteLine("Very Good");
        //            break;
        //        case 'C':
        //            Console.WriteLine("Good");
        //            break;
        //        case 'D':
        //            Console.WriteLine("Pass");
        //            break;
        //        case 'F':
        //            Console.WriteLine("Failed");
        //            break;
        //        default :
        //            Console.WriteLine("invalid letter");
        //            break;
        //    }


        //    /*
        //     ## 🧠 Task 3: Month Days Count

        //        **Objective:**
        //        - Ask the user to enter the month number (1–12).
        //        - Display the number of days in that month.
        //        - 1,3,5,7,8,10,12 => 31
        //        - 4,6,9,11 => 30
        //         **Special Case:**
        //        - February (2) → 28 or 29 days depending on leap year
                          
        //     */
        //    Console.WriteLine("pls Enter Month Number 1 to 12");
        //    int N_Nuber =Convert.ToInt32( Console.ReadLine());
            
        //    switch (N_Nuber) 
        //    {
        //        case 1:
        //        case 3:
        //        case 5:
        //        case 7:
        //        case 8:
        //        case 10:
        //        case 12:
        //            Console.WriteLine("Count Of Days is 31");
        //            break;
        //        case 4:
        //        case 6:
        //        case 9:
        //        case 11:
        //            Console.WriteLine("Count Of Days is 30");
        //            break; 
        //        case 2:
        //            Console.WriteLine("Count Of Days is 31");
        //            break;
        //        default:
        //        Console.WriteLine("invalid Number");
        //        break;

        //    }
        //}
    }
}
