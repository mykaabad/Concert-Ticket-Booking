
using System;

namespace TicketBooking
{
	
	public class menu
	{
		public static string DisplayMenu()
                {
                    Console.WriteLine("- - - - - - - BE THE SUN MANILA - - - - - - - ");
		            Console.WriteLine("SEVENTEEN WORLD TOUR CONCERT TICKET SELLING");
		            Console.WriteLine();
		            
		            Console.WriteLine();Console.WriteLine("Select an action:");
                    Console.WriteLine("Enter '1' to purchased a ticket");
                    Console.WriteLine("Enter '2' to view purchased ticket.");
        
                    Console.WriteLine();
                    Console.Write("USER INPUT:");
                    string userMenuSelection = Console.ReadLine();
                    Console.WriteLine();
        
                    return userMenuSelection;
                }
			
		}
	}

