using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int index,i;
            string input;
            string[] token;
            int[] time;
            int result = 0;
            int totalTime = 0;

            input = Console.ReadLine();
            index = Convert.ToInt32(input);

            input = Console.ReadLine();
            token = input.Split(' '); // 공백을 기준으로 자른 후 문자열 배열 token
            time = Array.ConvertAll(token, s => int.Parse(s)); // 문자열 배열을 숫자 배열로 변환
            Array.Sort(time); // 오름차 순으로 Time 정렬

            for(i = 0; i < index; i++)
            {
                totalTime += time[i];
                result += totalTime;                
            }
            Console.WriteLine(result);
        }
    }
}
