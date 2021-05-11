using System;

namespace 용사의_나날
{
    class Program
    {
        static Random random = new Random();


        static void Main(string[] args)
        {
            Console.WriteLine("프롤로그 : 용사가 고액연봉을 받는 시대, \n 용사 대학교를 나오고 대기업 회사에 들어가기 위해 애써보지만\n항상 경험치가 부족하다는 탈락 문자만 받는다.\n경험치를 쌓기 위해 무서운 악마가 나온다는 산을 향하는데...");

            bool quit = false;
            do
            {
                //플레이어 이름 받기 
                Player player = MakePlayer();

            } while (quit == false);
        }

      
        private static Player MakePlayer()
        {
            Console.WriteLine("경험치를 쌓으려면 아무키나 누르십시오.");
            Console.ReadKey();

            Console.WriteLine($"당신의 이름은 무엇입니까?");
            string userName = Console.ReadLine();
            Player player = new Player(userName);
            return player;

        }


    }
}





