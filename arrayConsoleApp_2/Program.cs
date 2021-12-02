using System;

namespace arrayConsoleApp_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] isim = { "ali", "mehmet", "nuri"};
            int[] s = new int[5];
            int[] a = new int[4] { 1, 2, 3, 4 };
            int[] b = new int[3];
            b[0] = 5;
            b[1] = 3;
            b[2] = 4;
            */

            /*foreach (int item in b)
            {
                Console.WriteLine(item);
            }*/

            /*
            for (int i = 0; i <b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
            */

            Console.WriteLine("int veri türünde bir dizi oluşturuluyor... Dizi kaç elemanlı olsun?");
            int enterArray = Convert.ToInt32(Console.ReadLine());
            int[] dizim = new int[enterArray];
            Console.WriteLine("Şimdi Dizi Elemanları Girmeye Başlayalım");
            int sayi=0;
            for (int i = 0; i < dizim.Length; i++)
            {
                Console.WriteLine($"{i}.Dizi için int türünde bir veri giriniz: ");
                dizim[i] = Convert.ToInt32(Console.ReadLine());
                sayi += dizim[i];
            }
            double ortalama = Convert.ToDouble(sayi) / Convert.ToDouble(dizim.Length);
            Console.Clear();
            Console.WriteLine("Dizi Oluşturma Tamamlandı..");
            Console.WriteLine($"Dizinin elemanlarının toplamı : {sayi}\nDizinin Elemanlarının ortalaması : {ortalama}");
            foreach (int item in dizim)
            {
                Console.WriteLine(item);
            }
        }
    }
}
