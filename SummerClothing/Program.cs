namespace SummerClothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeofday = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            if (degrees >=10 && degrees <= 18)
            {
                if (timeofday == "Morning")
                {
                    outfit = "Swetshirt";
                    shoes = "Sneakers";
                }else if (timeofday == "Afternoon" ||  timeofday == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            {
                 if ( degrees >=18  && degrees <= 24)
                {
                    if (timeofday == "Morning")
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (timeofday == "Afternoon")
                    {
                        outfit = "T-shirt";
                        shoes = "Sandals";
                    }
                    else if (timeofday == "Evening")
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
            
               
                }
            }
                {
                     if (degrees >= 25)
                {

                    if (timeofday == "Morning")
                    {
                        outfit = "T-shirt";
                        shoes = "Sandals";
                    }
                    else if (timeofday == "Afternoon")
                    {
                        outfit = "SwimSuit";
                        shoes = "Barefoot";
                    }
                    else if (timeofday == "Evening")
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                
                }
            }Console.WriteLine($"It`s {degrees} degrees,get you {outfit} and {shoes}.");
            
            
        }
    }
}