using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text.RegularExpressions;

namespace kelimelik
{
    class Program
    {
        static void Main(string[] args)
        {

            string dosya_yolu = @"C:\kelime_bulmaca.txt";

            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            string kelimeler_txt = sr.ReadToEnd();
            string[] kelimeler = kelimeler_txt.Split(' ');
            string[] sayılar = Regex.Split(kelimeler_txt, @"\D+");
            foreach (string s in sayılar)
            {
                int sayı;
                if (int.TryParse(s, out sayı))
                {
                    Console.WriteLine(s);
                }
            }
            int kelimeS = kelimeler.Length;
            Console.WriteLine(kelimeS);

            for (int i = 0; i < kelimeS; i++)
            {
                Console.WriteLine(kelimeler[i]);
            }
            Console.WriteLine("Kelimeler yazdırıldı");

            //for (int t = 0; t <= kelimeS-1; t++)
            //{
            //    kelimeler[t].ToCharArray();
            //}


            Console.WriteLine("Girmek istediğiniz harf sayısını girin");
            int harfS = Int32.Parse(Console.ReadLine());        //harfsayisi

            string[] harfler = new string[harfS];
            Console.WriteLine("{0} tane harf gir", harfS);

            for (int i = 0; i < harfS; i++)
            {
                harfler[i] = Console.ReadLine();
            }
            Console.WriteLine("Harfler girildi");



            while (kelimeler_txt != null)
            {
                kelimeler_txt = sr.ReadLine();
            }
            for (int i = 0; i <= kelimeS - 1; i++)
            {
                Console.WriteLine(kelimeler[i]);
            }

            sr.Close(); //okumabitti
            fs.Close(); //dosyapaylaşımıbitti


            int[] ct = new int[kelimeS]; //kelimeicincounterlar

            for (int k = 0; k < kelimeS; k++)
            {

                foreach (string harf in harfler)
                {
                    bool wordContainsLetter = kelimeler[k].Contains(harf);

                    {
                        if (wordContainsLetter == true)
                        {
                            ct[k]++;
                        }
                    }
                    Console.WriteLine(kelimeler[k] + ", " + harf + " harfini iceriyor: " + wordContainsLetter);
                }
            }

            Console.WriteLine("kelime 1den3 e kadar:" + kelimeler[0] + "-" + kelimeler[1] + "-" + kelimeler[2]);

            for (int c = 0; c < kelimeS; c++)
            {
                if (ct[c] >= kelimeler[c].Length)
                {
                    Console.WriteLine("Bu kelimeyi içeriyor: " + kelimeler[c]);
                }
            }

            Console.WriteLine(sayılar[2]);

            ////////////////////////////////


            /*
            string text = "sth like 1234 digits in it";

            var digits = text.ToCharArray().Where(c => Char.IsDigit(c));
            var letters = text.ToCharArray().Where(c => Char.IsLetter(c));
            */


            /*
             * 
            char[] delimiterChars = { ' ', ',', ':', '.', '-','_' , '\r'};
            string text = "say\rhello " +
                "to me";
            string[] words = text.Split(delimiterChars);
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            */

            /*
            string[] bul = new string[5];
            char[] harfler = { 'a', 't', 'a', 'i', 't', 'o', 'n' };
            //at, ata, it, ot,ton
            bul[0] = "ata";
            bul[1] = "at";
            bul[2] = "it";
            bul[3] = "ot";
            bul[4] = "on";
            

            Console.WriteLine("harfleri girin");
            char[] harfler1 = new char[5];
            for (int a = 0; a <= 0; a++)
            {
                harfler1 = bul[a].ToCharArray();
            }
            for (int y = 0; y <= 4; y++)
            {
                Console.WriteLine(harfler1[0]);
            }
            Console.WriteLine(bul[0]);
            char[] yeni = bul[0].ToCharArray();
            Console.WriteLine(yeni);
            */

            ////*************///////////**********///////////////////
            /*
            string sentence = "Mahesh Chand";
            char[] charArr = sentence.ToCharArray();
            foreach (char ch in charArr)
            {
                Console.WriteLine(ch);
            }
            */
            /////*************///////////**********//////////////////

            Console.ReadKey();

        }

    }
}
