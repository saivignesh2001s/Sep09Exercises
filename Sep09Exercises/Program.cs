using Sep09;
namespace Sep09Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Without using thread start");
            Thread t1 = new Thread(Ma);
            
            t1.Start();

            
            Console.WriteLine("using parameterised thread start");
            Thread t3 = new Thread(new ThreadStart(Ma));
            t3.Start();
            Console.ReadLine();
        }
        public static void Ma()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(i);
                if (i == 3)
                {
                    Thread.Sleep(1000);
                }
            }
        }
    }
}