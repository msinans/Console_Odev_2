using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Odev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilgiler bg = new Bilgiler();
            string adsoyad, meslek, yas;
            Console.WriteLine("İsim Giriniz!: ");
            adsoyad = Console.ReadLine();
            Console.WriteLine("Meslek Giriniz!: ");
            meslek = Console.ReadLine();
            Console.WriteLine("Yaş Giriniz!: ");
            yas = Console.ReadLine();
            bg.bilgi("Ad/Soyad: " + adsoyad, "Meslek: " + meslek, "Yaş: " + yas);
            Console.Read();

        }
    }
}
