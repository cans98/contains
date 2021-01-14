using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterative_game
{
    class Program
    {

        static void Main(string[] args)
        {

            string sifre = "cancan9898..";
            Console.WriteLine("sifre giriniz");



            while (true) // kullanıcı doğru şifreyi yazana kadar tekrarlar
            {
                string girilenSifre = Convert.ToString(Console.ReadLine());
                bool b = sifre.Contains(girilenSifre);


                if (b == true)
                {
                    Console.WriteLine("sifre doğru");
                    break;
                }
                else
                {

                    Console.WriteLine("lütfen şifre giriniz");
                    string tekrar = Convert.ToString(Console.ReadLine());
                    girilenSifre = tekrar;

                }

            }


            Console.ReadLine();


        }
    }
}
