using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodopg9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] winningCupon = new int[7];
             
            int[] userCupon = new int[7];
            int equalnumbers = 0;

            int getUserCuponNumbers;


            winningCupon = Logic.WinningCupon(winningCupon);
            ForEachLoopPrintCupons(winningCupon);
            Console.WriteLine();

            //gets user cupon 
            for (int i = 0; i < userCupon.Length; i++)
            {
                Console.WriteLine("hvilket er det første nummer du vil indtaste: ");
                getUserCuponNumbers = int.Parse(Console.ReadLine());
                userCupon[i] = getUserCuponNumbers;
            }


            ForEachLoopPrintCupons(userCupon);
            Console.WriteLine();

            Logic.CheckCuponNumbers(winningCupon, userCupon, equalnumbers);

            

            
           
        }


        public static void ForEachLoopPrintCupons(int[] print)
        {
            foreach (int item in print)
            {
                Console.Write(item + ", ");
            }

        }


    }
}
