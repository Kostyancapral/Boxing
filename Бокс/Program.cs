using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    class Fighter
    {
        public int hp=50;
        internal int choose;     
        internal int Attack()
        {
            Random rnd = new Random();
            choose = rnd.Next(1, 4);
            return choose;
        }
        internal int Deffence()
        {
            Random rnd = new Random();
            choose = rnd.Next(1, 4);
            return choose;
        }
    }


    class Player
    {
        public int hp = 50;
        internal int choose;

        internal int Attack()
        {
            string menu = "";
            while (menu != "1" && menu != "2" && menu != "3")
            {
                Console.Clear();
                Console.WriteLine("Делайте ваш выбор");
                Console.WriteLine("1 - удар в голову");
                Console.WriteLine("2 - удар в торс");
                Console.WriteLine("3 - удар по ногам");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        choose = 1;
                        break;
                    case "2":
                        choose = 2;
                        break;
                    case "3":
                        choose = 3;
                        break;
                }
            }
            return choose;
        }
        internal int Deffence()
        {
            string menu = "";
            while (menu != "1" && menu != "2" && menu != "3")
            {
                Console.Clear();
                Console.WriteLine("Делайте ваш выбор");
                Console.WriteLine("1 - защита головы");
                Console.WriteLine("2 - защита торса");
                Console.WriteLine("3 - защита ног");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        choose = 1;
                        break;
                    case "2":
                        choose = 2;
                        break;
                    case "3":
                        choose = 3;
                        break;
                }
            }
            return choose;
        }
    }    
    class Program
    {
        static void Main(string[] args)
        {
            Fighter Comp = new Fighter();
            Player Pl = new Player();

            while (Pl.hp != 0 && Comp.hp != 0)
            {
                Pl.Attack();
                Comp.Deffence();
                if (Pl.choose == Comp.choose) Console.WriteLine("Удар заблокирован");
                else
                {
                    Console.WriteLine("Удар достиг цели =)");
                    Comp.hp -= 10;
                }
                Console.ReadLine();

                Comp.Attack();
                Pl.Deffence();
                if (Pl.choose == Comp.choose) Console.WriteLine("Блок успешен");
                else
                {
                    Console.WriteLine("Вы пропустили удар");
                    Pl.hp -= 10;
                }
                Console.ReadLine();
                Console.WriteLine("Ваша выноливость= " + Pl.hp);
                Console.WriteLine("Выноливость противника= " + Comp.hp);
                Console.ReadLine();
            }
            if (Pl.hp == 0) Console.WriteLine("Вы проиграли");
            else Console.WriteLine("Противник в нокауте");
            Console.ReadLine();
        }
    }
}
