using System;
using System.Linq;

public class Example
{
    public static void Main()
    {
        String[] input;

        // 입력 받기 (콘솔 초기화는 제외하였습니다)
        input = Console.ReadLine().Split(' ');

        // 입력된 값에서 문자열과 정수 추출
        String s1 = input[0];
        int a = Int32.Parse(input[1]);

        // 문자열을 a번 반복
        String result = String.Concat(Enumerable.Repeat(s1, a));

        // 결과 출력
        Console.WriteLine(result);
    }
}