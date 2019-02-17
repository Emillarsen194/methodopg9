using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodopg9
{
    class Logic
    {
       
        public static int[] WinningCupon(int[] winningCupon)
        {
            Random rng = new Random();
            
            for (int i = 0; i < winningCupon.Length; i++)
            {
                int winningCuponNumbers = rng.Next(1, 20);
                winningCupon[i] = winningCuponNumbers;
            }

            return winningCupon;
        }

        public static void CheckCuponNumbers(int[] winningCupon, int[] usersCupon, int equalnumber)
        {

            for (int i = 0; i < winningCupon.Length; i++)  // checking how many numbers is equal 
            {
                for (int j = 0; j < usersCupon.Length; j++)
                {
                    if (winningCupon[i] == usersCupon[j])
                    {
                        equalnumber++;
                    }
                }
            }

            Prizes(equalnumber);

        }

       public static void Prizes(int equalNumbers)
        {
            switch (equalNumbers) // switch case to pay out the prices 
            {
                case 1:
                    Console.WriteLine("du have " + equalNumbers + " rigtige du vandt ikke noget fordi du kun havde et rigtigt tal bedre held næste gang");
                    break;
                case 2:
                    Console.WriteLine("Tilykke du havde " + equalNumbers + " rigtige du vandt 100 Kroner");
                    break;
                case 3:
                    Console.WriteLine("Tilykke du havde " + equalNumbers + " rigtige du vandt 250 Kroner");
                    break;
                case 4:
                    Console.WriteLine("Tilykke du havde " + equalNumbers + " rigtige du vandt 500 Kroner");
                    break;
                case 5:
                    Console.WriteLine("Tilykke du havde " + equalNumbers + " rigtige du vandt 1250 Kroner");
                    break;
                case 6:
                    Console.WriteLine("Tilykke du havde " + equalNumbers + " rigtige du vandt 5000 Kroner");
                    break;
                case 7:
                    Console.WriteLine("Jaaackpot du havde " + equalNumbers + " rigtige du vandt 100,000 Kroner");
                    break;
            }

            
        }

        

    }
}
