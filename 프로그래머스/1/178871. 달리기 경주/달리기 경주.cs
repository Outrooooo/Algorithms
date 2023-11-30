using System.Collections.Generic;
using System.Linq;
using System;

public class Solution {
    public string[] solution(string[] players, string[] callings) {
        Dictionary<string, int> playerDic = new Dictionary<string, int>();

        // 초기 플레이어 순위 Dictionary에 설정
        for (int i = 0; i < players.Length; i++)
        {
            playerDic.Add(players[i], i);
        }

        for(int i = 0; i < callings.Length; i++)
        {
            // 불려진 플레이어의 순위(인덱스)를 가져옴
            int index = playerDic[callings[i]];

            // 추월 당한 플레이어 배열 Swap
            string temp = players[index - 1]; 
            players[index - 1] = players[index];
            players[index] = temp;

            playerDic[callings[i]] -= 1; // 순위 상승
            playerDic[temp] +=1; // 순위 하락

        }
        return players;
    }
}