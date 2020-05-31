    // Due: Feb 11,2020
   // Program 1
  // Grading ID: S1566
 // Course: 199-75
// This application will be used for estimating the materials and labor costs for carpet sales and installation company. 

using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to the Handy-Dandy Carpet Estimator\n"); //Welcome Statement for the Carpet Estimator

            double Maxwidth;     // maximun width of the carpet
            double Maxlength;   // maximum length of the carpet
            double CarpetPrice;// Price of the carpet
            int Numlayers;    // Number(s) of layer of the carpet
            int firstRoom;   // Number(s) of room

            double Totalcost;        // Total cost of the of the carpet, padding and labor
            double Carpetcost;      // Total cost of the carpet 
            double Paddingcost;    // Padding cost of for the carpet
            double Laborcost;     // Total cost for the labor of the work
            double Totalsqyards; // Total square yards of the carpet
            

            const double firstLabor = 75.00;   //Constant for the first Labor 
            const double persqYard = 2.50;    // Constant for the amount chrged per sq yard
            const double convtsqYard = 9;    // Constant for converting to square yards
            const double carpetExtra = 0.1; // Constant for the extra carpet 
            const double laborPrice = 4.25;// Constant for the Labor price


            Write("Enter the max width of room (in feet):"); // User input the maximun width of the room in feet
            Maxwidth = double.Parse(ReadLine());


            Write("Enter the max length of room (in feet):");  // User input the maximun length of the room in feet
            Maxlength = double.Parse(ReadLine());

            Write("Enter the carpet price (per sq. yard):");    // User input the Price of the Carpet  
            CarpetPrice = double.Parse(ReadLine());

            Write("Enter layers of padding to use (1 or 2):");   // User input the layers of padding
            Numlayers = int.Parse(ReadLine());


            Write("Is this the first room? (1 = YES, 0 = NO):"); // User input the number of rooms
            firstRoom = int.Parse(ReadLine());

            Write("\n"); // New line

            // Calculation Phase >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            Totalsqyards = Maxwidth * Maxlength / convtsqYard; // calculation for the total square yards

            Carpetcost = ((CarpetPrice * Totalsqyards)) * ((1 + carpetExtra)); // calculation for the carpet cost


            Paddingcost = ((persqYard * Totalsqyards)) * ((1 + carpetExtra)) * Numlayers; // calculation for the padding cost

            Laborcost = laborPrice * Totalsqyards + firstLabor * firstRoom; // calculation for the labor cost

            Totalcost = Carpetcost + Paddingcost + Laborcost; // calculation for the Total cost

            // Output Phase >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            WriteLine($"Sq. Yreds Needed:{Totalsqyards,9:F1}"); // output 


            WriteLine($"Carpet Cost:{Carpetcost,15:C}"); // output


            WriteLine($"Padding Cost:{Paddingcost,14:C}"); // output


            WriteLine($"Labor Cost:{Laborcost,16:C}"); // output


            WriteLine($"Total Cost:{Totalcost,16:C}"); // output



        }
    }
}
