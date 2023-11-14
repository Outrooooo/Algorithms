/*
 * 문제
캠핑(https://www.acmicpc.net/problem/4796)
등산가 김강산은 가족들과 함께 캠핑을 떠났다. 하지만, 캠핑장에는 다음과 같은 경고문이 쓰여 있었다.
캠핑장은 연속하는 20일 중 10일동안만 사용할 수 있습니다.
강산이는 이제 막 28일 휴가를 시작했다. 이번 휴가 기간 동안 강산이는 캠핑장을 며칠동안 사용할 수 있을까?
강산이는 조금 더 일반화해서 문제를 풀려고 한다. 
캠핑장을 연속하는 P일 중, L일동안만 사용할 수 있다. 강산이는 이제 막 V일짜리 휴가를 시작했다. 강산이가 캠핑장을 최대 며칠동안 사용할 수 있을까? (1 < L < P < V)

 * 성능
메모리 6028KB, 
시간 116ms
 */
namespace BOJ_4796
{
    internal class Program
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
                for (int i = 0; i < convertToken.Length; i++)
                {
                    if (convertToken[i] == 0)
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

                if (remain < l) // 일정이 더 길다면 그냥 일정 소화
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