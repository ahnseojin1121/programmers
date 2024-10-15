using System;

public class Solution {
    public int solution(int a, int b, bool flag) {
        // flag가 true면 a + b, false면 a - b
        int answer = flag ? a + b : a - b;
        return answer;
    }
}