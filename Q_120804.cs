using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersCodingTest
{
    public class Q_120804
    {
        // 일자 : 2024-08-07
        // 문제 : 두 수의 곱
        // 문제 설명 : 정수 num1, num2가 매개변수 주어집니다.
        //            num1과 num2를 곱한 값을 return 하도록 solution 함수를 완성해주세요.

        static void Main1(string[] args)
        {
            int solution(int num1, int num2)
            {
                int answer = num1 * num2;             

                return answer;
            }

            Console.WriteLine(solution(3, 2));
        }
    }
}
