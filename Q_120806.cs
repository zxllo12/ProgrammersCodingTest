using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersCodingTest
{
    public class Q_120806
    {
        // 일자 : 2024-08-07
        // 문제 : 두 수의 나눗셈
        // 문제 설명 : 정수 num1과 num2가 매개변수로 주어질 때,
        //             num1을 num2로 나눈 값에 1,000을 곱한 후 정수 부분을 return 하도록 soltuion 함수를 완성해주세요.

        static void Main1(string[] args)
        {
            float solution(float num1, float num2)
            {
                float answer = num1 / num2 * 1000;
                
                answer = (int)Math.Floor(answer);

                return answer;
            }

            Console.WriteLine(solution(1, 16));
        }
    }
}
