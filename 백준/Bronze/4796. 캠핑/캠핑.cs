using System;
using System.Collections.Generic;

namespace Camping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int[]> list = new List<int[]>();
            string input;
            string[] token;
            int[] convertToken;
            int end;
            int pml, vdp, result; // P-L, V/P 저장할 공간
            int p, l, v;
            int num = 0;

            while (true)
            {
                end = 0;
                input = Console.ReadLine();
                // 문자열을 해당 파라미터 기준으로 나눔
                token = input.Split(' '); 

                convertToken = Array.ConvertAll(token, s => int.Parse(s));
                // 입력받은 값이 0,0,0인 경우
                for (int i = 0; i< convertToken.Length; i++)
                {
                    if(convertToken[i] == 0)
                    {
                        end++;
                    }
                    else
                    {
                        break;
                    }
                }
                // while break, 이후 Case Print
                if (end != 3)
                {
                    list.Add(convertToken);
                    continue;
                }
                else
                {
                    break;
                }
            }
            // PrintCase(list);
            foreach (var i in list)
            {
                num++;
                l = i[0];
                p = i[1];
                v = i[2];

                int div = v / p; // 몫
                int remain = v % p; // 나머지

                if(remain < l) // 일정이 더 길다면 그냥 일정 소화
                {
                    result = v - ((p - l) * div);
                }
                else // 남는 공간이 더 크다면 캠핑 일정 소화 후 남은 공간 확보
                {
                    result = v - ((p - l) * div + remain - l);
                }

                Console.WriteLine("Case {0}: {1}", num, result);
            }
        }
    }
}
