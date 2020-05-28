using System;
using System.Text;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int lastTick = 0;
            const int WAIT_TICK = 1000 / 30;
            const char CIRCLE = '\u25cf';
            while (true)
            {
                #region 프레임 관리 
                int currentTick = System.Environment.TickCount;
                int elapedTick = currentTick - lastTick;
                // 만약에 경과한 시간이 1/30 초보다 작다면
                if (elapedTick < WAIT_TICK)
                {
                    continue;
                }
                lastTick = currentTick;
                #endregion
                // FPS 프레임 (60프레임 OK 30프레임 이하로 NO)

                // 입력

                // 로직


                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        System.Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.Write(CIRCLE);
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
