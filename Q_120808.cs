using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersCodingTest
{
    public class Q_120808
    {
        // 일자 : 2024-08-08
        // 문제 : 분수의 덧셈
        // 문제 설명 : 첫 번째 분수의 분자와 분모를 뜻하는 numer1, denom1, 두 번째 분수의 분자와 분모를 뜻하는 numer2, denom2가 매개변수로 주어집니다.
        //             두 분수를 더한 값을 기약 분수로 나타냈을 때 분자와 분모를 순서대로 담은 배열을 return 하도록 solution 함수를 완성해보세요.

        static void Main(string[] args)
        {
            int[] solution(int numer1, int denom1, int numer2, int denom2)
            {
                int[] answer = new int[2];

                int max = 0;

                int maxNum = 0;

                answer[0] = numer1 * denom2 + numer2 * denom1;

                answer[1] = denom1 * denom2;

                max = answer[0];

                for (int i = 1; i <= max; i++)
                {
                    if (answer[0] % i == 0 && answer[1] % i == 0)
                    {
                        maxNum = i;
                    }
                }

                answer[0] = answer[0] / maxNum;
                answer[1] = answer[1] / maxNum;

                return answer;
            }

            int[] arr = solution(1, 2, 3, 4);

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
