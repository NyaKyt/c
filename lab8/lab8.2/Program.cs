using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("выберить правильный вариант: ");
            }
            switch (choice)
            {
                case 1:
                    DiskPhone dp = new DiskPhone();
                    dp.disk();
                    break;
                case 2:
                    ButtonPhone bp = new ButtonPhone();
                    bp.disk();
                    break;

            }
           /* Console.WriteLine("Button Phone");
            ButtonPhone bp = new ButtonPhone();
            //bp.RingTone();
            Console.WriteLine();

            Console.WriteLine("Black&White Phone");
            BlackWhitePhone nokia = new BlackWhitePhone();
            nokia.Call();
            nokia.RingTone();
            Console.WriteLine();

            Console.WriteLine("Color Phone");
            ColorScreenPhone samsung = new ColorScreenPhone();
            samsung.Call();
            samsung.SurfTheNet();
            Console.WriteLine();

            Console.WriteLine("iPhone");
            iPhone EightPlus = new iPhone();
            EightPlus.Call();
            EightPlus.SurfTheNet();
            Console.WriteLine();

            Console.WriteLine("Google Glass");
            GoogleGlass coolGlasses = new GoogleGlass();
            coolGlasses.Call();
            coolGlasses.RingTone();
            coolGlasses.SurfTheNet();*/

        }
    }
}
