using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanConsoleSelf.View
{
    public class HangmanGallows
    {
        public static void DrawGallow(int wrongGuesses)
        {
            //clear screen for new gallow.
            switch (wrongGuesses)
            {
                case 0: Stage0(); break;
                case 1: Stage1(); break;
                case 2: Stage2(); break;
                case 3: Stage3(); break;
                case 4: Stage4(); break;
                case 5: Stage5(); break;
                case 6: Stage6(); break;
                case 7: Stage7(); break;
                case 8: Stage8(); break;
                case 9: Stage9(); break;
                case 10: StageFinal(); break;
            }
        }

        private static void Stage0()
        {
            System.Console.WriteLine("               _______       ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |              ");
            System.Console.WriteLine("              |              ");
            System.Console.WriteLine("              |              ");
            System.Console.WriteLine("              |              ");
            System.Console.WriteLine("              |              ");
            System.Console.WriteLine("              |              ");
            System.Console.WriteLine("              |              ");
            System.Console.WriteLine("        ______|______        ");
        }

        private static void Stage1()
        {

            System.Console.WriteLine("               _______       ");
            System.Console.WriteLine("              |     __|__    ");
            System.Console.WriteLine("              |    /     \\  ");
            System.Console.WriteLine("              |    |     |   ");
            System.Console.WriteLine("              |    \\_____/  ");
            System.Console.WriteLine("              |              ");
            System.Console.WriteLine("              |              ");
            System.Console.WriteLine("              |              ");
            System.Console.WriteLine("              |              ");
            System.Console.WriteLine("        ______|______        ");
        }

        private static void Stage2()
        {
            System.Console.WriteLine("               _______       ");
            System.Console.WriteLine("              |     __|__    ");
            System.Console.WriteLine("              |    /     \\  ");
            System.Console.WriteLine("              |    |     |   ");
            System.Console.WriteLine("              |    \\_____/  ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |              ");
            System.Console.WriteLine("        ______|______        ");
        }

        private static void Stage3()
        {
            System.Console.WriteLine("               _______       ");
            System.Console.WriteLine("              |     __|__    ");
            System.Console.WriteLine("              |    /     \\  ");
            System.Console.WriteLine("              |    |     |   ");
            System.Console.WriteLine("              |    \\_____/  ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |      / \\    ");
            System.Console.WriteLine("        ______|______        ");
        }

        private static void Stage4()
        {
            System.Console.WriteLine("               _______       ");
            System.Console.WriteLine("              |     __|__    ");
            System.Console.WriteLine("              |    /     \\  ");
            System.Console.WriteLine("              |    |     |   ");
            System.Console.WriteLine("              |    \\_____/  ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |      /|\\    ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |      / \\    ");
            System.Console.WriteLine("        ______|______        ");
        }

        private static void Stage5()
        {
            System.Console.WriteLine("               _______       ");
            System.Console.WriteLine("              |     __|__    ");
            System.Console.WriteLine("              |    /     \\  ");
            System.Console.WriteLine("              |   @      |   ");
            System.Console.WriteLine("              |    \\_____/  ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |      /|\\    ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |      / \\    ");
            System.Console.WriteLine("        ______|______        ");
        }

        private static void Stage6()
        {
            System.Console.WriteLine("               _______       ");
            System.Console.WriteLine("              |     __|__    ");
            System.Console.WriteLine("              |    /     \\  ");
            System.Console.WriteLine("              |   @       @  ");
            System.Console.WriteLine("              |    \\_____/  ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |      /|\\    ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |      / \\    ");
            System.Console.WriteLine("        ______|______        ");
        }

        private static void Stage7()
        {
            System.Console.WriteLine("               _______       ");
            System.Console.WriteLine("              |     __|__    ");
            System.Console.WriteLine("              |    /     \\  ");
            System.Console.WriteLine("              |   @   \'   @ ");
            System.Console.WriteLine("              |    \\_____/  ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |      /|\\    ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |      / \\    ");
            System.Console.WriteLine("        ______|______        ");
        }

        private static void Stage8()
        {
            System.Console.WriteLine("               _______       ");
            System.Console.WriteLine("              |     __|__    ");
            System.Console.WriteLine("              |    /     \\  ");
            System.Console.WriteLine("              |   @   \"   @ ");
            System.Console.WriteLine("              |    \\_____/  ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |      /|\\    ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |      / \\    ");
            System.Console.WriteLine("        ______|______        ");
        }
        private static void Stage9()
        {
            System.Console.WriteLine("               _______       ");
            System.Console.WriteLine("              |     __|__    ");
            System.Console.WriteLine("              |    /     \\  ");
            System.Console.WriteLine("              |   @   \"   @ ");
            System.Console.WriteLine("              |    \\__~__/  ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |      /|\\    ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |      / \\    ");
            System.Console.WriteLine("        ______|______        ");
        }

        private static void StageFinal()
        {
            System.Console.WriteLine("               _______       ");
            System.Console.WriteLine("              |     __|__    ");
            System.Console.WriteLine("              |    / x x \\  ");
            System.Console.WriteLine("              |   @   \"   @ ");
            System.Console.WriteLine("              |    \\__~__/  ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |      /|\\    ");
            System.Console.WriteLine("              |       |      ");
            System.Console.WriteLine("              |      / \\    ");
            System.Console.WriteLine("        ______|______        ");
        }
    }
}
