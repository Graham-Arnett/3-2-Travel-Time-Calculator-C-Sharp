namespace TravelTimeCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Travel Time Calculator");
            String choice;
            do
            {
                //miles input
                Console.Write("Enter miles: ");
                double miles = double.Parse(Console.ReadLine());

                //mph input
                Console.Write("Enter miles per hour: ");
                double mph = double.Parse(Console.ReadLine());

                //define hours
                double hours = miles / mph;

                //cast hours
                int wholeHours = (int)hours;
                int minutes = (int) ((hours - wholeHours) * 60);

                Console.WriteLine("Estimated travel time");
                Console.WriteLine($"Hours: {wholeHours}");
                Console.WriteLine($"Minutes: {minutes}");

                //end choice
                Console.Write("Would you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower().Trim();
            }while(choice == "y");
        }
    }
}
