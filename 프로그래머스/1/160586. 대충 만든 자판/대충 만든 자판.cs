using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        int searchIndex;
        List<int> searchMinimum = new List<int>();

        for(int i=0; i< targets.Length; i++)
        {
            for(int j =0; j < targets[i].Length; j++)
            {
                for(int k =0; k<keymap.Length; k++)
                {
                    // // 탐색 성공 Index이므로 +1
                    // searchMinimum.Add(keymap[k].IndexOf(targets[i][j]) + 1);
                    searchIndex = keymap[k].IndexOf(targets[i][j]);
                    // // 탐색 성공 Index이므로 +1
                    if (searchIndex != -1)
                    {
                        searchMinimum.Add(searchIndex + 1);
                    }
                    else
                    {
                        continue;
                    }
                }
                if(searchMinimum.Count == 0)
                {
                    answer[i] = -1;
                    break;
                }
                else
                {
                    answer[i] += searchMinimum.Min();
                    searchMinimum.Clear();
                }
            }
        }
        return answer;
    }
}