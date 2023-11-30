import java.util.HashMap;

class Solution {
    public int solution(int[] bandage, int health, int[][] attacks) {
        int count = 1;
        int max = health;       

        HashMap<Integer, Integer> hashMap = new HashMap<Integer, Integer>();
        
        for(int i = 0; i< attacks.length; i++) {
            if(attacks[i].length != 0) {
                hashMap.put(attacks[i][0], attacks[i][1]);
            }
        }
        
        for(int i=0; i< attacks[attacks.length-1][0] +1 ; i++) {
            if(hashMap.containsKey(i)) {
                if(health > 0) {
                    health -= hashMap.get(i);
                    count = 1;
                    if(health <= 0) {
                        return -1;
                    }
                    continue;
                }
            }
            else {
                if(health < max) {
                    if(count == bandage[0]) {
                        health += bandage[2] + bandage[1];
                        count = 1;
                    }
                    else {
                        health += bandage[1];
                        count++;
                    }
                    
                    if(health > max) {
                        health = max;
                    }
                }
            }
        }
        return health;
    }
}