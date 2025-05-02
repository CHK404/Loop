using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            Console.WriteLine("-----------------------------");

            //Q5) 별 찍기 2
            for (int i = 1; i <= 7; i+=2)
            {
                Console.Write("\r\n");
                for (int k = 5; k >= i; k-=2)
                {
                    Console.Write($" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"*");
                }
            }



            #endregion

            #region #2 배열 반복문

            /*
             * 배열 반복문을 사용하는 이유
             * 하나하나 출력하기에 비효율적
             * 
             * Length: 배열의 크기
             */

            //[Before]
            string[] fruits = { "사과", "바나나", "포도", "딸기" };
            Console.WriteLine(fruits[0]);
            Console.WriteLine(fruits[1]);
            Console.WriteLine(fruits[2]);
            Console.WriteLine(fruits[3]);
            Console.WriteLine(fruits.Length);

            Console.WriteLine("-----------------------------");

            //[After]
            string[] fruits2 = { "사과", "바나나", "포도", "딸기" };
            for (int i = 0; i < fruits2.Length; i++)
            {
                Console.WriteLine(fruits2[i]);
            }

            Console.WriteLine("-----------------------------");

            //#foreach문 사용
            /*
             * ㄴ 배열의 모든 항목을 처음부터 끝까지 하나씩 꺼내며 반복 실행하는 문법
             * ㄴ 배열을 순회하면서 각 요소에 동일한 작업을 실행할 때 사용
             * ㄴ 순서가 있는 구조 반복에 적합
             * 
             * 구조
             * foreach (자료형 변수명 in 배열이름)
             * {
             *      //배열의 항목 하나씩 사용
             * }
             */

            //위 예제 foreach 버전
            string[] fruits3 = { "사과", "바나나", "포도", "딸기" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            //for문 버전
            int[] scores = { 85, 98, 78, 92, 88 };

            int sum4 = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum4 += scores[i];
            }

            double average = (double)sum4 / scores.Length;

            Console.WriteLine("총합: " + sum4);
            Console.WriteLine("평균: " + average);

            Console.WriteLine("-----------------------------");

            //foreach버전

            int[] scores2 = { 85, 98, 78, 92, 88 };

            int sum5 = 0;
            foreach (int score in scores2)
            {
                sum5 += score;
            }

            double average2 = (double)sum5 / scores2.Length;

            Console.WriteLine("총합: " + sum5);
            Console.WriteLine("평균: " + average2);

            #endregion

            #endregion

            #region While문

            /* 
             * 조건이 참일 동안 반복하는 반복문
             * 조건이 거짓이 될 때 까지 무한 반복
             * 
             * 구조
             * while(조건식)
             * {
             *      조건이 참일 경우 실행할 코드
             * }
             */

            Console.Clear(); //콘솔창 초기화

            int count2 = 0;
            while (count2 < 100)
            {
                Console.WriteLine(count2);
                count2++;
            }

            Console.WriteLine("-----------------------------");

            //ex) 1~5 출력

            int a = 1;

            while (a <= 5)
            {
                Console.WriteLine(a);
                a++;
            }

            //ex) 무한루프

            //bool run = true;
            //while(run)
            //{
            //  Console.WriteLine("무한");
            //}

            //ex) 무한루프2 (벗어나기)

            int idx = 0;
            while (true)
            {
                idx += 2;
                if(idx == 10)
                {
                    break;
                }
                Console.WriteLine($"{idx}");
            }

            Console.WriteLine($"{idx}");
            Console.WriteLine("-----------------------------");

            #endregion

            #region break & continue

            //반복문에서 사용되는 제어문

            //#break
            //ㄴ 반복문을 완전히 중단하고 빠져나온다
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine($"{i}");
            }

            Console.WriteLine("-----------------------------");

            //#continue
            //ㄴ 현재 반복을 중지하고 다음 반복으로 넘어감
            //ㄴ 이번회차 건너뛰기

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine($"{i}");
            }

            #endregion

        }

        //실습: for문/가짜 성적표 만들기
        private void button_submit_Click(object sender, EventArgs e)
        {
            textBox_output.Text = "";
            string input = textBox_input.Text;
            bool toF = int.TryParse(input, out int student);
            if (toF) 
            {
                Random score = new Random();
                int[] arrayScore = new int[student];
                for (int i = 0; i < student; i++)
                {
                    int s = score.Next(100);
                    arrayScore[i] = s;
                    textBox_output.Text += $"학생{i + 1}: {arrayScore[i]}\r\n";
                }
            }
            else
            {
                textBox_output.Text = "땡";
            }
        }
    }
}
