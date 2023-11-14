/*
 * 문제
A-B(https://www.acmicpc.net/problem/1001)
두 정수 A와 B를 입력받은 다음, A-B를 출력하는 프로그램을 작성하시오.

 * 성능
메모리 5736KB, 
시간 100ms
 */
namespace BOJ_1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] token;
            int[] data;
            input = Console.ReadLine();
            token = input.Split(' ');
            data = Array.ConvertAll(token, s => int.Parse(s)); // token의 배열값을 전부 정수형으로 변환 후 data 배열에 저장

            if (data[0] > 0 && data[1] < 10)
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