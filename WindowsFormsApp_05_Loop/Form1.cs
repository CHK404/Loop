using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_05_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region 반복문

            #region #1 일반 반복문

            /*
             * -어떤 코드를 정해진 횟수만큼 반복 실행할 때 사용
             * 
             * 구조
             * for(초기식; 조건식; 증감식)
             * {
             *      반복할 코드
             * }
             * 
             * 초기식: 변수 선언 혹은 초기화
             * 조건식: 반복할 조건 (ex. true면 계속 진행)
             * 증감식: 변수 값을 변화시켜 반복 실행 제어 -> ++/--
             */

            //Ex1) 0~5 출력
            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------------");
            //Ex2) 5~1출력
            for(int i = 5; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------------");

            //Ex3) 1부터 n까지의 합 구하기
            int n = 10;
            int sum = 0;

            for(int i = 1; i <= n; i++)
            {
                sum += i;
                Console.WriteLine("현재 i의 값: " + i + "\r\n" + "현재 합계: " + sum + "\r\n");
            }

            //Q1) 1 ~ 20 중에 짝수 숫자들의 합
            int num = 20;
            int eSum = 0;

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    eSum += i;
                }
                Console.WriteLine(eSum + "\r\n");
            }

            Console.WriteLine("-----------------------------");

            //Q2) 1부터 100까지의 수중에 3의 배수지만 5의 배수는 아닌수 출력
            //ㄴ 마지막에 총합 출력

            int end = 100;
            int total = 0;
            int count = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 != 0)
                    {
                        Console.WriteLine(i + "\r\n");
                        total += i;
                        count += 1;
                    }
                }
            }
            Console.WriteLine("갯수: " + count + "\r\n");
            Console.WriteLine("총합: " + total + "\r\n");

            Console.WriteLine("-----------------------------");

            //Ex4) 중첩 for문
            for (int i = 1; i <= 3; i++)
            {
                for(int j = 1; j <= 2; j++)
                {
                    Console.WriteLine($"i = {i}, j = {j}");
                }
            }

            Console.WriteLine("-----------------------------");

            //Q3) 구구단 2단~9단 출력

            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    int multi = i * j;
                    Console.WriteLine($"{i} x {j} = {multi}");
                }
            }

            Console.WriteLine("-----------------------------");

            //Q4) 별 찍기
            for (int i = 1; i <= 4; i++)
            {
                Console.Write("\r\n");
                for (int k = 3; k >= i; k--)
                {
                    Console.Write($" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"*");
                }
            }
            #endregion

            #endregion

        }
    }
}
