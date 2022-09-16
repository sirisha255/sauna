namespace sauna
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please enter the tempetature you want in fahreinhet");
            bool temp = false;
            while (!temp)
            {
                // formula to change F to C
                // F = (9/5) * C + 32
                //( C = 5F - 160 / 9 )
                int F = int.Parse(Console.ReadLine());
                int a = (5 * F);
                int b = (160);
                int c = (9);
                int d = ((a - b) / c);
                Console.WriteLine("fahreinhet to celcius = ");
                Console.WriteLine(d);
                if (d == 75)
                {
                    Console.WriteLine("\n you choose the best temperature");
                    temp = true;
                }
                else if (d <= 73)
                {
                    Console.WriteLine("\n please increase the temperature..it is too cold to sauna");

                }
                else if (d >= 77)
                {
                    Console.WriteLine("\n please decrease the temperature.. it is too hot to sauna");
                }
                else if (d <= 73 && d >= 77)
                {
                    Console.WriteLine("\n you have a good temperature to sauna");
                }
            }
            Console.WriteLine(" Thank you for using the sauna temperature setting");
            Console.ReadLine();
        }
    }
}
