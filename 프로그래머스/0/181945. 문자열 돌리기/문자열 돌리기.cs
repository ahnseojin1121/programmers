using System;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        
        // 문자열의 길이를 저장합니다.
        int length = str.Length;

        // 문자열을 세로로 출력합니다.
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(str[i]);
        }
    }
}