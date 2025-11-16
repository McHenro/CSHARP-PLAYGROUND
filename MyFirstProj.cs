
namespace MyFirstProj
{
    class Program
    {
        static void Main (string[] args)
        {
        // double marketPrice  = Checkout(3.23, 4.54, 2.34, 8.9, 4.67);
        // Console.WriteLine("Market Price is: " + marketPrice);
        double temperature = 20;
        string message;
        message = temperature >= 15 ? "Its warm outside" : "Its cold outside";
        Console.WriteLine(message);
        
        }

    }
   
}