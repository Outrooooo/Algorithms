using System;

namespace plus
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] token;
            int[] data;
            input = Console.ReadLine();
            token = input.Split(' ');
            data = Array.ConvertAll(token, s => int.Parse(s)); // token의 배열값을 전부 정수형으로 변환 후 data 배열에 저장

            Sum(data[0], data[1]);

        }

        static public void Sum(int a, int b)
        {
            Console.WriteLine( a + b );
        }
    }
}
