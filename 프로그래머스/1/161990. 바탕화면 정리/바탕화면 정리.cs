using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[] { };

        List<int> filePositionX = new List<int>();
        List<int> filePositionY = new List<int>();

        for (int i = 0; i < wallpaper.Length; i++)
        {
            char[] chars = wallpaper[i].ToCharArray();

            for(int j=0;j< chars.Length; j++)
            {
                if (chars[j].ToString().Equals("#"))
                {
                    filePositionX.Add(i);
                    filePositionY.Add(j);
                }
            }
        }

        answer = new int[] { filePositionX.Min(), filePositionY.Min(), filePositionX.Max() + 1, filePositionY.Max() + 1 };

        return answer;
    }
}