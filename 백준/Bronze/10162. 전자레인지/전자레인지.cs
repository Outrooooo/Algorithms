using System;

namespace oven
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] buttons = { 300, 60, 10 }; // A B C
            int[] buttonPress = new int[3];

            int InputCookingTime = Convert.ToInt32(Console.ReadLine()); // 초 입력

            for(int i = 0; i < buttons.Length; i++)
            {
                if(InputCookingTime / buttons[i] != 0)
                {
                    buttonPress[i] = InputCookingTime / buttons[i];
                    InputCookingTime = InputCookingTime % buttons[i];
                }
                else
                {
                    continue;
                }
            }
            
            if(InputCookingTime != 0)
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
    

    

