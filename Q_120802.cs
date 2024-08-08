using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersCodingTest
{
    public class Q_120802
    {
        // 일자 : 2024-08-08
        // 문제 : 두 수의 합
        // 문제 설명 : 정수 num1과 num2가 주어질 때, num1과 num2의 합을 return하도록 soltuion 함수를 완성해주세요.

        static void Main1(string[] args)
        {
            int solution(int num1, int num2)
            {
                int answer = num1 + num2;                           

                return answer;
            }

            Console.WriteLine(solution(3, 2));
        }
    }
}
