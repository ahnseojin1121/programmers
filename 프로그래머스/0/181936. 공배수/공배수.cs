public class Solution
{
    public int solution(int number, int n, int m)
    {
        // number가 n의 배수이면서 m의 배수인지 확인
        if (number % n == 0 && number % m == 0)
        {
            return 1; // 조건을 만족하면 1 반환
        }
        else
        {
            return 0; // 조건을 만족하지 않으면 0 반환
        }
    }
}