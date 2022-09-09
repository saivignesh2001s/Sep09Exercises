using Sep09;
namespace Sep09Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Mutex mutex = new Mutex(false, "Sep09Exercises"))
            {

                if (!mutex.WaitOne(5000,false))
                {
                    Monitor.Enter(mutex);
                    Console.WriteLine("already running....");
                    Console.ReadLine();
                    return;

                }
                else
                {
                    Console.WriteLine("app is running");
                    Console.ReadLine();
                    Monitor.Exit(0);
                }

            }

        }
    }
}
   