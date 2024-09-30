using System;

public class Example
{
    public static void Main()
    {
        // 입력 받기
        string[] input = Console.ReadLine().Split(' ');

        // 입력값을 정수로 변환
        int a = Int32.Parse(input[0]);
        int b = Int32.Parse(input[1]);

        // 제한 조건 확인 (1 ≤ a, b ≤ 100)
        if (a >= 1 && a <= 100 && b >= 1 && b <= 100)
        {
            // 계산식 출력
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
        else
        {
            Console.WriteLine("1 ≤ a, b ≤ 100 범위의 숫자를 입력하세요.");
        }
    }
}