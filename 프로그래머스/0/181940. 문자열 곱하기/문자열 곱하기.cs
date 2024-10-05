using System;
using System.Linq;

public class Solution {
    public string solution(string my_string, int k) {
        // Enumerable.Repeat을 사용하여 my_string을 k번 반복한 후, 이를 연결하여 반환
        return string.Concat(Enumerable.Repeat(my_string, k));
    }
}