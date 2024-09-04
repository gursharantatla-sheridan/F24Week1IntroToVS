namespace F24Week1IntroToVS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // area of a circle

            Console.Write("\n\nEnter radius: ");
            //double r = double.Parse(Console.ReadLine());
            double r = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * r * r;

            Console.WriteLine("\nArea = " + area);
        }
    }
}
