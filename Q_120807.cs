﻿namespace ProgrammersCodingTest
{
    public class Q_120807
    {
        // 일자 : 2024-08-05
        // 문제 : 몫 구하기
        // 문제 설명 : 정수 num1과 num2가 매개변수로 주어집니다.
        //            두 수가 같으면 1 다르면 -1을 retrun하도록 solution 함수를 완성해주세요.

        static void Main1(string[] args)
        {
            int solution(int num1, int num2)
            {
                int answer = 0;

                if (num1 == num2)
                {
                    answer = 1;
                }
                else
                {
                    answer = -1;
                }

                return answer;
            }
            
            Console.WriteLine(solution(1, 2));
        }
    }
}
