using System;
using System.Collections.Generic;
namespace Jimwell_Rosario
{
    class Program
    {
        static void Main()
        {
          string username, password;
          int ctr = 0;
          Console.Write("\n\nPLEASE ENTER YOU CREDENTIALS TO LOG IN\n");
          Console.Write("-------------------------------------\n\n"); 
         
        do
        {
			Console.Write("Username: ");
			username = Console.ReadLine();
 
			Console.Write("Password: ");
			password = Console.ReadLine();
			
             if(username != "jimwell" || password != "rosario")
             ctr++;
             else
             ctr=1;
     
        }
        while((username != "jimwell" || password != "rosario")  && (ctr != 3));
	 
        if (ctr == 3)
		{
            Console.Write("\nInvalid username or password\n\n");
		}
        else
		{  
            Console.Write("\nLOG IN SUCCESFULLY!\n\n");
			
            Intro();

            List<String> inputList = new List<String>();
			
			while(true){

				ShowMainMenu();
				
				string userInput = GetUserInput();
				
				switch (userInput) {
					
					case "1":
					ViewHouseTypes();
					break;
					
					case "2":
					Console.WriteLine("What unit do you preferred?");
					String addhousetype = Console.ReadLine();
					Console.WriteLine(" ");
					Console.WriteLine("Succesfully");
					Console.WriteLine(" ");
					inputList.Add(addhousetype);
					break;
					
					case "3":
					Console.WriteLine("Enter Choice to remove: ");
					String removehousetype = Console.ReadLine();
					Console.WriteLine(" ");
					Console.WriteLine("Successfully Removed!");
					Console.WriteLine(" ");
					inputList.Remove(removehousetype);
					break;
					
					case "4":
					Console.WriteLine("You Selected:");
					foreach(String housetype in inputList)
					Console.WriteLine(housetype);
					Console.WriteLine("");
					break;
					
					case "x":
					case "X":
					Console.WriteLine("");
					Console.WriteLine("Thank you for trusting JCRZ REALTY dear client");
					Console.WriteLine("CONGRATULATIONS!!!");
					return;
					
				}
			
			}
        }
		}
		static void ShowMainMenu()
		{
		Console.WriteLine("!!!MAIN MENU!!!");
		Console.WriteLine("1 to View Available Units and Their Price");
		Console.WriteLine("2 to Add Choice");
		Console.WriteLine("3 to Remove Choice");
		Console.WriteLine("4 to View Choice");
		Console.WriteLine("x to Buy");
		Console.WriteLine(" ");
		}
		
		static string GetUserInput()
		{
		Console.Write("Input: ");
		string input = (Console.ReadLine());
		return input;
		}
		static void ViewHouseTypes()
		{
					Console.WriteLine("***Available Units***");
					Console.WriteLine("Sora - Single Attached");
					Console.WriteLine("Lot area: 90 sqm (inner unit)");
					Console.WriteLine("Floor Area: 60 sqm");
					Console.WriteLine(" ");
					Console.WriteLine("TCP      | 4,498,972");
					Console.WriteLine("TCP DISC.|   304,683");
					Console.WriteLine("NTCP-    | 4,194,289");
					Console.WriteLine("LOAN Val.| 3,774,860");
					Console.WriteLine("DP       |   419,428");
					Console.WriteLine("RES FEE. |    20,000");
					Console.WriteLine("NET DP   |   379,428");
					Console.WriteLine("EQUITY   |    21,079  for 18 months");
					Console.WriteLine("MRI      |    41,942");
					Console.WriteLine("EQUITY w/ MRI | 23,409  for 18 months");
					Console.WriteLine(" ");
					Console.WriteLine("Yama - Townhouse");
					Console.WriteLine("Lot area: 60 sqm (inner unit)");
					Console.WriteLine("Floor Area: 42 sqm");
					Console.WriteLine("TCP      | 2,422,501");
					Console.WriteLine("TCP DISC |   164,074");
					Console.WriteLine("NTCP     | 2,258,427");
					Console.WriteLine("LOAN val | 2,032,584");
					Console.WriteLine("DP       |   225,842");
					Console.WriteLine("RES FEE. |    10,000");
					Console.WriteLine("NET DP   |   205,842");
					Console.WriteLine("EQUITY   |    11,435  for 18 months");
					Console.WriteLine("MRI      |    22,584");
					Console.WriteLine("EQUITY w/ MRI | 12,690  for 18 months");
					Console.WriteLine(" ");	
		}
		
		static void Intro()
		{
			Console.WriteLine("GOOD DAY Ma'am/Sir. Thank you for Reaching us. I'm Jimwell Rosario Assigned Property Specialist for you.");
            Console.WriteLine("*********WELCOME TO JCRZ REALTY*********");
            Console.WriteLine(" ");
            Console.WriteLine("JCRZ Realty is a real estate marketing company engaged in selling real estate properties in Laguna, Cavite, Batangas & Metro Manila. Established in May 2018 by Reymart Zuniega & Jem Vodka Cellano with 6 years solid real estate experience.");
            Console.WriteLine("The company provides much needed market information, extensive property listings, statistics, experts' industry assessments, events and activities to assist clients make sound decision. With its extensive presence online including all social media platforms. Accredited with the biggest developers in the country.");
            Console.WriteLine(" ");
            Console.WriteLine("MISSION");
            Console.WriteLine("- To have a foundation of constant growth & improvement so that we may empower our clients to achieve their real estate goals, all with the highest caliber of service & support.");
            Console.WriteLine("- To provide income opportunity to filipino community wanting to upgrade their lifestyle & attain financial freedom as well as time freedom.");
            Console.WriteLine(" ");
            Console.WriteLine("VISSION");
            Console.WriteLine("- To develop premier real estate leaders, demand excellence, and deliver results.");
            Console.WriteLine("We are committed to be the preferred & reliable real estate marketing company that ensure sustainable growth & financial independence of our business partners.");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Welome to our new launch project here in Cabuyao Laguna!!!");
            Console.WriteLine("IDESIA CABUYAO Located at Brgy Marinig, Cabuyao Laguna");
            Console.WriteLine("- A community co- designed by the  japanese for the Filipinos.");
            Console.WriteLine("- It is a joint venture partnership between the Philippines P.A properties  and Japan's Hankyu Hanshin Realty Co.");
            Console.WriteLine("- It is a modern asian- inspired  residential development built on traditional  japanese quality and Filipino ingenuity.");
            Console.WriteLine("- Located at The richest municipality in the Philippines where big industries has  established their business.");
            Console.WriteLine(" ");
            Console.WriteLine("AMENITIES:");
            Console.WriteLine("- Reading garden");
            Console.WriteLine("- Togetherness zone");
            Console.WriteLine("- Clubhouse");
            Console.WriteLine("- Swimming pool");
            Console.WriteLine("- Kiddie pool");
            Console.WriteLine("- Picnic area");
            Console.WriteLine("- Wellness zone");
            Console.WriteLine("- Basketball court");
            Console.WriteLine("- Children playground");
            Console.WriteLine("- Jogging path");
            Console.WriteLine("- Parking area");
            Console.WriteLine(" ");
		}
    }
}
