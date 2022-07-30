using System;
using DataLayer;
using System.Collections.Generic;
using TicketBooking;

namespace BusinessLogic
{
	
	public class ticketProcessing
	{
		public static void Main (string [] args)
		{
		    
		    string day;
            string seat;
            string name;
            string seatSection;
            string datePurchased=DateTime.Now.ToString();
            
			
            
            string userSelection = TicketBooking.menu.DisplayMenu();
            
            switch (userSelection)
            {
            
            case "1":
                Console.Write("Which date do you want to attend? (10-09-2022 or 10-10-2022):");
               	day=Console.ReadLine();
               	Console.WriteLine();
               	Console.WriteLine("- - - Mall Of Asia Seat Plan with Price List - - -");
                Console.WriteLine("VIP STANDING - ₱12,500");
                Console.WriteLine("VIP SEATED - ₱12,500");
                Console.WriteLine("LOWER BOX A - ₱10,500");
                Console.WriteLine("LOWER BOX B - ₱8,500");
                Console.WriteLine("UPPER BOX A - ₱5,500");
                Console.WriteLine("UPPER BOX B - ₱4,500");
                Console.WriteLine("UPPER BOX C - ₱3,500");
                Console.WriteLine("GENERAL ADMISSION - ₱2,500");
                
                Console.Write("Choose a seat plan you want to avail: ");
                seat=Console.ReadLine();
                
                if (seat.ToUpper() == "VIP STANDING")
                {
                	Console.Write("Choose a VIP standing section (A, B, C, D):");
                	seatSection=Console.ReadLine();
                }
                else if (seat.ToUpper() == "VIP SEATED")
                {
                	Console.Write("Choose a VIP seated section (201 , 202 , 221 , 222) :");
                	seatSection=Console.ReadLine();
                }
                else if (seat.ToUpper() == "LOWER BOX A")
                {
                	Console.Write("Choose a Lower Box A section (216 , 217 , 218 , 219 , 220) :");
                	seatSection=Console.ReadLine();
                }
                else if (seat.ToUpper() == "LOWER BOX B")
                {
                	Console.Write("Choose a Lower Box B section (203 , 204 , 205 , 206 , 207) :");
                	seatSection=Console.ReadLine();
                }
                else if (seat.ToUpper() == "UPPER BOX A")
                {
                	Console.Write("Choose an Upper Box A section (402 , 401, 421 , 422) :");
                	seatSection=Console.ReadLine();
                }
                else if (seat.ToUpper() == "UPPER BOX B")
                {
                	Console.Write("Choose an Upper Box B section (420B , 420A , 419 , 418 , 417 , 416) :");
                	seatSection=Console.ReadLine();
                }
                else if (seat.ToUpper() == "UPPER BOX C")
                {
                	Console.Write("Choose an Upper Box C section (403A , 403B , 404 , 405 , 406 , 407) :");
                	seatSection=Console.ReadLine();
                }
                else if (seat.ToUpper() == "GENERAL ADMISSION")
                {
                	Console.Write("Choose a General Admission section (501 , 502 , 503 , 504 , 505 , 506 , 507) :");
                	seatSection=Console.ReadLine();
                }
                
                else
                {
                	Console.Write("Sorry. Invalid input.");
                	seatSection=Console.ReadLine();
                	return;
                	
                }
            
                
                Console.Write("Name: ");
                name=Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                
                
                
                Console.WriteLine("- - - - - - - - - - -");
                Console.WriteLine("Please check if all the given information is correct: ");
                Console.WriteLine();
                string ticketInfo = String.Format("Concert Date: {0}\n" + "Name: {1} \n"  + "Seat: {2} \n"  
                + "Seat Section: {3} \n" + "Date Purchased: {4} \n" , day , name , seat , seatSection, datePurchased );
                Console.WriteLine(ticketInfo.ToUpper());
                Console.WriteLine();
                Console.Write("Proceed?: ");
                string proceed = Console.ReadLine();
                
                if (proceed.ToUpper() == "YES")
                {
                	List<string> purchasedInfo = new List<string>();
                	purchasedInfo.Add(ticketInfo.ToUpper());
                	TextFileStream.CreateUpdateFile(true, purchasedInfo);
                	Console.WriteLine("Successful Transaction! ");
                	Console.WriteLine("Please don't forget to bring your ticket on the concert day :) ");
                }
                
                else
                {
                	Console.WriteLine("Sorry for inconvenience. Please try again.");
                }
               
     
                Console.ReadKey();
                    break;   
    		
    		
    		case "2":
    		    Console.WriteLine("Purchased Ticket Information");
                DisplayData();
                break;
                default:
                break;
                }
		}
                
                
            public static void DisplayData()
                {
                    List<string> dataContent = TextFileStream.ReadFile();
                    
                    foreach (var data in dataContent)
		            {
                    	Console.WriteLine(data.ToUpper());
		                data.Equals(dataContent);
		                
		                Console.ReadKey();
					}
				}
	}
}
	

