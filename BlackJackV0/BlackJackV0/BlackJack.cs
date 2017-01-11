using System;
/// <summary>
/// A simple example of Blackjack card game
/// </summary>
namespace JAMK.IT
{
  class BlackJack
  {
    static void Main()
    {
      int myNumber = 17;
      int theirNumber = 0;
      string input;
      System.Console.WriteLine("*** BlackJack! ***");
      while(true)
      {
                System.Console.Write("\nCan you beat my number? Enter any number between 1-21: ");
                //reading and converting 
                while (true)
                {
                    input = System.Console.ReadLine();          // kysytään syöte
                    if (Int32.TryParse(input, out theirNumber) == false)     // onko kokonaisluku, jos ei, niiin....
                    {
                        if (input == "X" || input == "exit")        //poistuu
                        {
                            return;
                        }
                        else  // virheilmoitus
                        {
                            
                            Console.WriteLine("\nIncorrect input");
                            Console.WriteLine("Give integer between 1-21 or X or exit to exit");
                        }

                    } else
                    { 
                        if (theirNumber < 1 || theirNumber > 21)   // Luku ei välillä 1-21:
                        {

                            Console.WriteLine("\nThe given number is out of limits, try again.");
                        }
                        else
                        {
                            break;      // luku on välillä 1 - 21, poistutaan silmukasta.
                        }
                    }

                }
                
                //theirNumber = System.Convert.ToInt32(System.Console.ReadLine());
                //comparing that given umber is valid

                //comparing
                if (theirNumber >= myNumber && theirNumber <= 21)
                {
                    System.Console.WriteLine("\nYou win.");
                }
                else {
                    System.Console.WriteLine("\nYou lose.");
                }
        }
   }
  }
}