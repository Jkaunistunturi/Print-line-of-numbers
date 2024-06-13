namespace nac
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("How many numbers you want to print?");
            int enterNumber = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i <= enterNumber; i++)
            {
                Console.Write(i);
            }

        }

    }
}
