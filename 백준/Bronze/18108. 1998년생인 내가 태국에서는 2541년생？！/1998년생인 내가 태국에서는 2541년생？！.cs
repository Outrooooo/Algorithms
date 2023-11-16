namespace TestAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());

            if(year <= 3000 && year >= 1000)
            {
                Console.WriteLine(year - 543);
            }
        }
    }
}