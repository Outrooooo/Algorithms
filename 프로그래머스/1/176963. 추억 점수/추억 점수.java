import java.util.HashMap;

class Solution {
    public int[] solution(String[] name, int[] yearning, String[][] photo) {
        int[] answer = new int[photo.length];
        int sum = 0;
        HashMap<String,Integer> peoples = new HashMap<String,Integer>();
        
        for(int i = 0 ; i< name.length; i++){
            peoples.put(name[i],yearning[i]);
        }
        
        System.out.println(peoples);
        
                
        for(int i = 0; i < photo.length; i++) {
            for(int j = 0; j < photo[i].length; j++) {
                sum += peoples.getOrDefault(photo[i][j], 0);
            }
            System.out.println(sum);
            answer[i] = sum;
            sum=0;
        }
        
        return answer;
    }
}