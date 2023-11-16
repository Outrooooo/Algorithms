using System;

namespace Minus
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

            if(data[0] > 0 && data[1] < 10)
            {
                Diff(data[0], data[1]);
            }
        }

        static public void Diff(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}
