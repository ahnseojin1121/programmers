using System;

public class Example
{
    public static void Main()
    {
        // 문자열 입력
        Console.Clear();
        string s = Console.ReadLine();

        // 대소문자 변환
        string result = SwapCase(s);

        // 결과 출력
        Console.WriteLine(result);
    }

    static string SwapCase(string str)
    {
        char[] result = new char[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsUpper(str[i]))
            {
                result[i] = char.ToLower(str[i]); // 대문자 -> 소문자
            }
            else if (char.IsLower(str[i]))
            {
                result[i] = char.ToUpper(str[i]); // 소문자 -> 대문자
            }
        }

        return new string(result); // 결과를 문자열로 반환
    }
}