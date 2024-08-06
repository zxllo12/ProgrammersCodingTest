using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersCodingTest
{
    public class Q_120820
    {
        // 일자 : 2024-08-06
        // 문제 : 두 수의 곱
        // 문제 설명 : 머쓱이는 선생님이 몇 년도에 태어났는지 궁금해졌습니다.
        //            2022년 기준 선생님의 나이 age가 주어질 때,
        //            선생님의 출생 연도를 return 하는 solution 함수를 완성해주세요

        static void Main(string[] args)
        {
            int solution(int age)
            {
                int answer = 0;

                answer = 2023 - age;

                return answer;
            }

            Console.WriteLine(solution(23));
        }
    }
}
