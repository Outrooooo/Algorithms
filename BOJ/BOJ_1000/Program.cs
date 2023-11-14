/*
 * 문제
A+B(https://www.acmicpc.net/problem/1000)
두 정수 A와 B를 입력받은 다음, A+B를 출력하는 프로그램을 작성하시오. 

 * 성능
메모리 5728KB, 
시간 140ms
 */
namespace BOJ_1000
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

            Sum(data[0], data[1]);
        }

        static public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}