namespace class2Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int credits = 102;
            int costs = 5;
            decimal result = credits / (decimal)costs;
            Console.WriteLine("You can send" + " " + result +" " + "sms");
        }
    }
}