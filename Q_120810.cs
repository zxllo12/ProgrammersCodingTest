using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersCodingTest
{
    public class Q_120810
    {
        // 일자 : 2024-08-06
        // 문제 : 나머지 구하기
        // 문제 설명 : 정수 num1, num2가 매개변수로 주어질 때,
        //            num1를 num2로 나눈 나머지를 return 하도록 solution 함수를 완성해주세요.

        static void Main1(string[] args)
        {
            int solution(int num1, int num2)
            {
                int answer = num1 % num2;             

                return answer;
            }

            Console.WriteLine(solution(3, 2));
        }
    }
}
