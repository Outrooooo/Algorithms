/*
 * 문제
전자레인지(https://www.acmicpc.net/problem/10162)
3개의 시간조절용 버튼 A B C가 달린 전자레인지가 있다. 각 버튼마다 일정한 시간이 지정되어 있어 해당 버튼을 한번 누를 때마다 그 시간이 동작시간에 더해진다. 버튼 A, B, C에 지정된 시간은 각각 5분, 1분, 10초이다.
냉동음식마다 전자레인지로 요리해야할 시간 T가 초단위로 표시되어 있다. 우리는 A, B, C 3개의 버튼을 적절히 눌러서 그 시간의 합이 정확히 T초가 되도록 해야 한다. 단 버튼 A, B, C를 누른 횟수의 합은 항상 최소가 되어야 한다. 이것을 최소버튼 조작이라고 한다.
만일 요리시간이 100초라고 하면(T=100) B를 1번, C는 4번 누르면 된다. 이와 다르게 C를 10번 눌러도 100초가 되지만 이 경우 10번은 최소 횟수가 아니기 때문이 답이 될 수 없다. 이 경우 B 1번, C 4번, 총 5번이 최소버튼 조작이다. 그리고 T=234와 같이 3개의 버튼으로 시간을 정확히 맞출 수 없는 경우도 있다.
여러분은 주어진 요리시간 T초를 맞추기 위한 최소버튼 조작 방법을 구하는 프로그램을 작성해야 한다.

 * 성능
메모리 5544KB, 
시간 68ms
 */
namespace BOJ_10162
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] buttons = { 300, 60, 10 }; // A B C
            int[] buttonPress = new int[3];

            int InputCookingTime = Convert.ToInt32(Console.ReadLine()); // 초 입력

            for (int i = 0; i < buttons.Length; i++)
            {
                if (InputCookingTime / buttons[i] != 0)
                {
                    buttonPress[i] = InputCookingTime / buttons[i];
                    InputCookingTime = InputCookingTime % buttons[i];
                }
                else
                {
                    continue;
                }
            }

            if (InputCookingTime != 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", buttonPress[0], buttonPress[1], buttonPress[2]);
            }
        }
    }
}