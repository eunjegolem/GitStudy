using System;

namespace baseballgame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomArray = new int[4];
            int input;
            int[] inputArray = new int[4];
            bool inputCheck;
            int chance = 10;
            int strike;
            int ball;

            Console.WriteLine("**********************");
            Console.WriteLine("****4자리 숫자야구****");
            Console.WriteLine("*********0 제외*******");
            Console.WriteLine();

            //난수 생성
            Random rand = new Random();
            for (int i = 0; i < 4; i++)
            {
                randomArray[i] = rand.Next(1, 10);
            }
            //중복 확인
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //중복값이 있을 시에
                    if (i != j && randomArray[i] == randomArray[j])
                    {
                        //난수 입력
                        randomArray[j] = rand.Next(1, 10);
                        //재확인
                        j = 0;
                    }
                }
            }
            Console.Write("{0}{1}{2}{3}", randomArray[3], randomArray[2], randomArray[1], randomArray[0]);
            do
            {
                if (chance == 0)
                {
                    Console.WriteLine("패배했습니다.");
                    break;
                }
                strike = 0;
                ball = 0;
                Console.WriteLine("====={0}번째 기회=====", 11 - chance);
                Console.Write("4자리 숫자를 입력하세요 : ");

                //4자리 숫자 입력 받기
                do
                {
                    inputCheck = int.TryParse(Console.ReadLine(), out input);

                    int dgt = 0;
                    int dgtCheck = input;
                    while (dgtCheck > 0)
                    {
                        dgt++;
                        dgtCheck /= 10;
                    }
                    if (dgt == 4)
                    {
                        //4자리를 배열에 넣기
                        for (int i = 0; i < 4; i++)
                        {
                            inputArray[i] = input % 10;
                            input /= 10;
                        }
                        //중복 체크
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                //중복값이 있을 시에
                                if (i != j && inputArray[i] == inputArray[j])
                                {
                                    inputCheck = false;
                                }
                            }
                        }

                    }
                    else inputCheck = false;


                    if (!inputCheck)
                    {
                        Console.WriteLine("잘못 입력하셨습니다.");
                        Console.Write("4자리 숫자를 입력하세요 : ");
                    }
                } while (!inputCheck);

                for (int i = 0; i < randomArray.Length; i++)
                {
                    for (int j = 0; j < inputArray.Length; j++)
                    {
                        if (randomArray[i] == inputArray[j])
                        {
                            if (i == j) strike++;
                            else ball++;
                        }
                    }
                }
                if (strike == 4)
                {
                    Console.WriteLine("Homerun!!");
                    Console.WriteLine("승리했습니다.");
                }
                else if (strike == 0 && ball == 0)
                {
                    Console.WriteLine("out!!");
                }
                else
                {
                    Console.WriteLine("Strike : {0} Ball : {1}", strike, ball);
                }

                chance--;
            } while (strike != 4);


        }
    }
}
