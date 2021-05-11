using System;
using System.Collections.Generic;

namespace 용사의_나날
{
    class Program
    {
        static Random random = new Random();
        

        static void Main(string[] args)
        {
            Console.WriteLine("프롤로그 : 용사가 고액연봉을 받는 시대, \n 용사 대학교를 나오고 대기업 회사에 들어가기 위해 애써보지만\n항상 경험치가 부족하다는 탈락 문자만 받는다.\n경험치를 쌓기 위해 무서운 악마가 나온다는 산을 향하는데...");

           

        }

        //이름 물어보기 
        public  static Player MakePlayer()
        {
            Console.WriteLine("당신의 이름은 무엇인가요?");
            string userName = Console.ReadLine();

            //bool isReset = true;
            //int power = 0, hp = 0;
            ////유저의 이름, 힘, 체력 랜덤으로 할당하기
            //while (isReset)
            //{
            //    power = random.Next(1, 9);
            //    hp = random.Next(4, 9);
            //    Console.Write($"{userName}님은 공격력:{power},체력:{hp}입니다.");
               
            //}

            Player player = new Player(userName);
            return player;
        }



    }

   
}
