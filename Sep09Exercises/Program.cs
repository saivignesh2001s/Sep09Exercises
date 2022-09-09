using Sep09;
namespace Sep09Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Thread t1 = new Thread(Ma);
            t1.Start();
            Thread t3 = new Thread(Man);
            t3.Start("Hello");
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
        public static void Man(object data)
        {
            Console.WriteLine("Parameterised thread start" +" "+data);
        }
    }
}