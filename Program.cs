using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num = rnd.Next(100, 500);
            var number = 6;
            while( number > 4 )
            {
                Console.Clear();
                Console.WriteLine("Hello World!" + num);
                Console.WriteLine("The value of the bill is: " + num + ". Which discount would you like to use?");
                Console.WriteLine("1. Senior citizens");
                Console.WriteLine("2. Veterans");
                Console.WriteLine("3. Minors");
                Console.WriteLine("4. Exit");
                var ans = Console.ReadKey().KeyChar.ToString();
                if (int.TryParse(ans, out int i))
                    number = int.Parse(ans);
                else
                    number = 6;
            }
            var context = new Context();
            switch (number)
            {
                case 1:
                    context.setStrategy(new SeniorCitizenDiscount());
                    break;
                case 2:
                    context.setStrategy(new VeteranDiscount());
                    break;
                case 3:
                    context.setStrategy(new MinorsDiscount());
                    break;
                default:
                    Console.WriteLine("Bye");
                    Console.ReadKey(true);
                    Environment.Exit(0);
                    break;
            }
            var final = Math.Round(context.calculate(num),2);
            var disc = Math.Round((num - final),2);
            Console.WriteLine("\n\nThe total was: "+num+"\nThe discount is: "+disc+"\nThe real total is: "+final);
            Console.ReadKey(true);
        }
    }
}
