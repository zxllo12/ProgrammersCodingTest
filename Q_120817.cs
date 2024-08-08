using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersCodingTest
{
    public class Q_120817
    {
        // 일자 : 2024-08-08
        // 문제 : 배열의 평균값
        // 문제 설명 : 정수 배열 numbers가 매개변수로 주어집니다. numbers의 원소의 평균값을 return하도록 solution 함수를 완성해주세요.

        static void Main1(string[] args)
        {
            double solution(double[] numbers)
            {
                double answer = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    answer += numbers[i];
                }

                answer = answer / numbers.Length;

                return answer;
            }
            double[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(solution(arr));
        }
    }
}
