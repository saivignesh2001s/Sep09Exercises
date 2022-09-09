using Sep09;
namespace Sep09Exercises
{
    internal class Program
    {
        public static void Method1()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(i);
                if (i == 3)
                {
                    Console.WriteLine("Thread name for Method1: " + Thread.CurrentThread.Name);
                    Thread.Sleep(1000);
                }
            }
        }
        public static void Method2()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(i);
                if (i == 2)
                {
                    Console.WriteLine("Thread name for Method2: " + Thread.CurrentThread.Name);
                    Thread.Sleep(1000);
                }
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Method1));
            t1.Name = "First Thread";

            Thread t2 = new Thread(new ThreadStart(Method2));
            t2.Name = "Second Thread";

            t2.Priority = ThreadPriority.Highest;
            t1.Priority = ThreadPriority.Highest;
            Console.WriteLine("Thread2 at present" +" "+ t1.IsAlive);
            Console.WriteLine("Thread1 at present" +" "+ t2.IsAlive);
            t2.Start();
            Console.WriteLine("Thread2 at present" + " " + t2.IsAlive);
            Console.WriteLine("Thread1 at present" + " " + t1.IsAlive);
            t1.Start();
            Console.WriteLine("Thread2 at present" +" "+ t1.IsAlive);
            Console.WriteLine("Thread1 at present" +" "+ t2.IsAlive);

            Console.ReadLine();
        }
    }
}
   