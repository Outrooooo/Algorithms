using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        int index = 0;

        foreach (int i in section){
            if (i > index)
            {
                answer++;
                index = i + m - 1;
            }
        }
        return answer;
    }
}