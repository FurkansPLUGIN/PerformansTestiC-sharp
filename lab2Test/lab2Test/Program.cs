using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace lab2Test
{
    class Program
    {
        //birinci soru
        public void fiboFor(int len)
        {
            int a = 0;
            int b = 1; 
            int c = 0;
            Console.Write("{0}", b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }

        }
        public void fiboWhile(int len)
        {
            int bir = 0;
            int iki = 1;
            int yeni = 0;
            int z = 3;
            Console.Write("{0}", iki);
            while (z <= len)
            {
                yeni = bir + iki;
                Console.Write(" " + yeni);
                bir = iki;
                iki = yeni;
                z++;
            }


        }
        public void fiboDoWhile(int len)
        {
            int one = 0;
            int two = 1;
            int news = 0;
            int j = 3;
            Console.Write("{0}", two);
            do
            {
                news = one + two;
                Console.Write(" " + news);
                one = two;
                two = news;
                j++;
            } while (j <= len);


        }


        //ikinci soru
        public int ussuAlma(int taban,  int us)
        {
            int sonuc;
            if (us == 0)
                sonuc = 1;
            else
                sonuc = taban * ussuAlma(taban, us - 1);
            return sonuc;
        }


        //üçüncü soru
        public void Merge(int[] giris, int sol, int orta, int sag)
        {
            int[] solDizi = new int[orta - sol + 1];
            int[] sagDizi = new int[sag - orta];

            Array.Copy(giris, sol, solDizi, 0, orta - sol + 1);
            Array.Copy(giris, orta + 1, sagDizi, 0, sag - orta);

            int i = 0;
            int j = 0;
            for (int k = sol; k < sag + 1; k++)
            {
                if (i == solDizi.Length)
                {
                    giris[k] = sagDizi[j];
                    j++;
                }
                else if (j == sagDizi.Length)
                {
                    giris[k] = solDizi[i];
                    i++;
                }
                else if (solDizi[i] <= sagDizi[j])
                {
                    giris[k] = solDizi[i];
                    i++;
                }
                else
                {
                    giris[k] = sagDizi[j];
                    j++;
                }
            }
        }
        public void MergeSort(int[] giris, int sol, int sag)
        {
            if (sol < sag)
            {
                int middle = (sol + sag) / 2;

                MergeSort(giris, sol, middle);
                MergeSort(giris, middle + 1, sag);

                Merge(giris, sol, middle, sag);
            }
        }
        public static void BucketSort(ref int[] eleman)
        {
            int min = eleman[0];
            int max = eleman[0];

            for (int i = 1; i < eleman.Length; i++)
            {
                if (eleman[i] > max)
                    max = eleman[i];
                if (eleman[i] < min)
                    min = eleman[i];
            }

            List<int>[] bucket = new List<int>[max - min + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            for (int i = 0; i < eleman.Length; i++)
            {
                bucket[eleman[i] - min].Add(eleman[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        eleman[k] = bucket[i][j];
                        k++;
                    }
                }
            }
        }


        //dördüncü soru
        IDictionary<string, string> ISBN_kitap;
        public void kitapBilgileri()
        {
            ISBN_kitap = new Dictionary<string, string>();
            ISBN_kitap.Add("Yüzüklerin Efendisi: Yüzük Kardeşliği", "9789753425");
            ISBN_kitap.Add("Yüzüklerin Efendisi: İki Kule", "9753421818");
            ISBN_kitap.Add("Yüzüklerin Efendisi: Kralın Dönüşü", "9753422024");
            ISBN_kitap.Add("Dune", "605375479X");
            ISBN_kitap.Add("Dune Çocukları", "6053756024");
            ISBN_kitap.Add("Drizzt Efsanesi I:Anayurt", "6053755575");
            ISBN_kitap.Add("Drizzt Efsanesi 2:Sürgün", "6059958133");
            ISBN_kitap.Add("Zaman Çarkı 1: Dünyanın Gözü", "9758725718");
            ISBN_kitap.Add("Zaman Çarkı 2: Büyük Av", "9758725726");
        }
        public void kitapİfElse(string kitapAdı)
        {
            string isbn = "";
            if (kitapAdı == "Yüzüklerin Efendisi: Yüzük Kardeşliği")
            { isbn = ISBN_kitap["Yüzüklerin Efendisi: Yüzük Kardeşliği"]; }
            else if (kitapAdı == "Yüzüklerin Efendisi: İki Kule")
            { isbn = ISBN_kitap["Yüzüklerin Efendisi: İki Kule"]; }
            else if (kitapAdı == "Yüzüklerin Efendisi: Kralın Dönüşü")
            { isbn = ISBN_kitap["Yüzüklerin Efendisi: Kralın Dönüşü"]; }
            else if (kitapAdı == "Dune")
            { isbn = ISBN_kitap["Dune"]; }
            else if (kitapAdı == "Dune Çocukları")
            { isbn = ISBN_kitap["Dune Çocukları"]; }
            else if (kitapAdı == "Drizzt Efsanesi I:Anayurt")
            { isbn = ISBN_kitap["Drizzt Efsanesi I:Anayurt"]; }
            else if (kitapAdı == "Drizzt Efsanesi 2:Sürgün")
            { isbn = ISBN_kitap["Drizzt Efsanesi 2:Sürgün"]; }
            else if (kitapAdı == "Zaman Çarkı 1: Dünyanın Gözü")
            { isbn = ISBN_kitap["Zaman Çarkı 1: Dünyanın Gözü"]; }
            else if (kitapAdı == "Zaman Çarkı 2: Büyük Av") 
            { isbn = ISBN_kitap["Zaman Çarkı 2: Büyük Av"]; }
            else
            {
                isbn = "Kitap adı bulunamadı tekrar deneyin";
            }
            Console.WriteLine("Kitap numarası: " + isbn);
        }
        public void kitapCase(string kitapAdı)
        {
            string isbn = "";
            switch (kitapAdı)
            {
                case "Yüzüklerin Efendisi: Yüzük Kardeşliği":
                    isbn = ISBN_kitap["Yüzüklerin Efendisi: Yüzük Kardeşliği"];
                    break;
                case "Yüzüklerin Efendisi: İki Kule":
                    isbn = ISBN_kitap["Yüzüklerin Efendisi: İki Kule"];
                    break;
                case "Yüzüklerin Efendisi: Kralın Dönüşü":
                    isbn = ISBN_kitap["Yüzüklerin Efendisi: Kralın Dönüşü"];
                    break;
                case "Dune":
                    isbn = ISBN_kitap["Dune"];
                    break;
                case "Dune Çocukları":
                    isbn = ISBN_kitap["Dune Çocukları"];
                    break;
                case "Drizzt Efsanesi I:Anayurt":
                    isbn = ISBN_kitap["Drizzt Efsanesi I:Anayurt"];
                    break;
                case "Drizzt Efsanesi 2:Sürgün":
                    isbn = ISBN_kitap["Drizzt Efsanesi 2:Sürgün"];
                    break;
                case "Zaman Çarkı 1: Dünyanın Gözü":
                    isbn = ISBN_kitap["Zaman Çarkı 1: Dünyanın Gözü"];
                    break;
                case "Zaman Çarkı 2: Büyük Av":
                    isbn = ISBN_kitap["Zaman Çarkı 2: Büyük Av"];
                    break;
                default:
                    isbn = "Kitap adı bulunamadı tekrar deneyin";
                    break;
            }
            Console.WriteLine("Kitap numarası: " + isbn);
        }

        //beşinci soru
        string[] alfabe;
        public void alfabeDegerleri()
        {
            alfabe = new string[] { "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "i", "ı", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z" };

        }
        public void alfabeİfElse(string harf)
        {
            int index = 0;
            if (harf == "a") index = Array.IndexOf(alfabe, "a") + 1;
            else if (harf == "b") index = Array.IndexOf(alfabe, "b") + 1;
            else if (harf == "c") index = Array.IndexOf(alfabe, "c") + 1;
            else if (harf == "ç") index = Array.IndexOf(alfabe, "ç") + 1;
            else if (harf == "d") index = Array.IndexOf(alfabe, "d") + 1;
            else if (harf == "e") index = Array.IndexOf(alfabe, "e") + 1;
            else if (harf == "f") index = Array.IndexOf(alfabe, "f") + 1;
            else if (harf == "g") index = Array.IndexOf(alfabe, "g") + 1;
            else if (harf == "ğ") index = Array.IndexOf(alfabe, "ğ") + 1;
            else if (harf == "h") index = Array.IndexOf(alfabe, "h") + 1;
            else if (harf == "i") index = Array.IndexOf(alfabe, "i") + 1;
            else if (harf == "ı") index = Array.IndexOf(alfabe, "ı") + 1;
            else if (harf == "j") index = Array.IndexOf(alfabe, "j") + 1;
            else if (harf == "k") index = Array.IndexOf(alfabe, "k") + 1;
            else if (harf == "l") index = Array.IndexOf(alfabe, "l") + 1;
            else if (harf == "m") index = Array.IndexOf(alfabe, "m") + 1;
            else if (harf == "n") index = Array.IndexOf(alfabe, "n") + 1;
            else if (harf == "o") index = Array.IndexOf(alfabe, "o") + 1;
            else if (harf == "ö") index = Array.IndexOf(alfabe, "ö") + 1;
            else if (harf == "p") index = Array.IndexOf(alfabe, "p") + 1;
            else if (harf == "r") index = Array.IndexOf(alfabe, "r") + 1;
            else if (harf == "s") index = Array.IndexOf(alfabe, "s") + 1;
            else if (harf == "ş") index = Array.IndexOf(alfabe, "ş") + 1;
            else if (harf == "t") index = Array.IndexOf(alfabe, "t") + 1;
            else if (harf == "u") index = Array.IndexOf(alfabe, "u") + 1;
            else if (harf == "ü") index = Array.IndexOf(alfabe, "ü") + 1;
            else if (harf == "v") index = Array.IndexOf(alfabe, "v") + 1;
            else if (harf == "y") index = Array.IndexOf(alfabe, "y") + 1;
            else if (harf == "z") index = Array.IndexOf(alfabe, "z") + 1;
            else { Console.WriteLine("Girilen bilgiye göre bir veri bulunamadı"); }
            if (index > 0)
            {
                Console.WriteLine("Girilen harfin alfabedki konumu: {0}", index);
            }
           
        }
        public void alfabeSwitchCase(string harf)
        {
            int index = 0;
            switch (harf)
            {
                case "a": index = Array.IndexOf(alfabe, "a") + 1; break;
                case "b": index = Array.IndexOf(alfabe, "b") + 1; break;
                case "c": index = Array.IndexOf(alfabe, "c") + 1; break;
                case "ç": index = Array.IndexOf(alfabe, "ç") + 1; break;
                case "d": index = Array.IndexOf(alfabe, "d") + 1; break;
                case "e": index = Array.IndexOf(alfabe, "e") + 1; break;
                case "f": index = Array.IndexOf(alfabe, "f") + 1; break;
                case "g": index = Array.IndexOf(alfabe, "g") + 1; break;
                case "ğ": index = Array.IndexOf(alfabe, "ğ") + 1; break;
                case "h": index = Array.IndexOf(alfabe, "h") + 1; break;
                case "i": index = Array.IndexOf(alfabe, "i") + 1; break;
                case "ı": index = Array.IndexOf(alfabe, "ı") + 1; break;
                case "j": index = Array.IndexOf(alfabe, "j") + 1; break;
                case "k": index = Array.IndexOf(alfabe, "k") + 1; break;
                case "l": index = Array.IndexOf(alfabe, "l") + 1; break;
                case "m": index = Array.IndexOf(alfabe, "m") + 1; break;
                case "n": index = Array.IndexOf(alfabe, "n") + 1; break;
                case "o": index = Array.IndexOf(alfabe, "o") + 1; break;
                case "ö": index = Array.IndexOf(alfabe, "ö") + 1; break;
                case "p": index = Array.IndexOf(alfabe, "p") + 1; break;
                case "r": index = Array.IndexOf(alfabe, "r") + 1; break;
                case "s": index = Array.IndexOf(alfabe, "s") + 1; break;
                case "ş": index = Array.IndexOf(alfabe, "ş") + 1; break;
                case "t": index = Array.IndexOf(alfabe, "t") + 1; break;
                case "u": index = Array.IndexOf(alfabe, "u") + 1; break;
                case "ü": index = Array.IndexOf(alfabe, "ü") + 1; break;
                case "v": index = Array.IndexOf(alfabe, "v") + 1; break;
                case "y": index = Array.IndexOf(alfabe, "y") + 1; break;
                case "z": index = Array.IndexOf(alfabe, "z") + 1; break;
                default:
                    Console.WriteLine("Girilen bilgiye göre bir veri bulunamadı");
                    break;
            }

            if (index > 0)
            {
                Console.WriteLine("Girilen harfin alfabedki konumu: {0}", index);
            }
        }

        static void Main(string[] args)
        {

            Stopwatch st = new Stopwatch();

            Console.WriteLine("Birinci Soru");
            Console.WriteLine("/////////////////////////////////");
          
            Program pr = new Program();
            //for
            try
            {
                Console.WriteLine("Bir sayı giriniz");
                int fiboLen = Convert.ToInt32(Console.ReadLine());
                st.Start();
                pr.fiboFor(fiboLen);
                st.Stop();
                Console.WriteLine(" Süre: " + st.Elapsed);
                st.Reset();

                Console.WriteLine(" ");

                st.Start();
                pr.fiboWhile(fiboLen);
                st.Stop();
                Console.WriteLine(" Süre: " + st.Elapsed);
                st.Reset();

                Console.WriteLine(" ");

                st.Start();
                pr.fiboDoWhile(fiboLen);
                st.Stop();
                Console.WriteLine(" Süre: " + st.Elapsed);
                st.Reset();

                Console.WriteLine("/////////////////////////////////");
                Console.WriteLine(" ");
            }catch(Exception ex)
            {
                Console.WriteLine("Hatalı giriş: " + ex.Message);
            }
           
            
            Console.WriteLine("İkinci Soru");
            Console.WriteLine("/////////////////////////////////");
            try
            {
                st.Start();
                pr.ussuAlma(2, 4);
                st.Stop();
                Console.WriteLine(" Süre: (öz yinelemeli) " + st.Elapsed);
                Console.WriteLine(" ");

                st.Reset();

                st.Start();
                Math.Pow(2, 4);
                st.Stop();
                Console.WriteLine(" Süre: (pow fonksiyonu) " + st.Elapsed);
            }catch(Exception ex)
            {
                Console.WriteLine("Hatalı giriş: " + ex.Message);
            }
          
            Console.WriteLine("/////////////////////////////////");
            st.Reset();
            Console.WriteLine(" ");

            Console.WriteLine("üçüncü Soru");
            Console.WriteLine("/////////////////////////////////");
            try
            {
                st.Start();
                int[] dizi = new int[10]
                {
                  1, 5, 4, 11, 20, 8, 2, 98, 90, 16
                };

                pr.MergeSort(dizi, 0, dizi.Length - 1);
                Console.WriteLine("Merge Sort ile");
                for (int i = 0; i < dizi.Length; i++)
                    Console.WriteLine(dizi[i]);
                st.Stop();
                Console.WriteLine("Süre: (merge sort) " + st.Elapsed);
                st.Reset();

                Console.WriteLine();

                st.Start();
                int[] dizi1 = new int[10]
               {
                  1, 5, 4, 11, 20, 8, 2, 98, 90, 16
               };
                BucketSort(ref dizi1);
                st.Stop();
                Console.WriteLine("Süre: (bucket sort) " + st.Elapsed);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        

            st.Reset();
            Console.WriteLine("/////////////////////////////////");

            Console.WriteLine("dördüncü Soru");
            Console.WriteLine("/////////////////////////////////");
            try
            {
                pr.kitapBilgileri();
                Console.WriteLine("Bir kitap adı girin");
                string kitapAdı = Console.ReadLine();
                Console.WriteLine();
                st.Start();
                pr.kitapİfElse(kitapAdı);
                st.Stop();

                Console.WriteLine("Süre: (if else için) " + st.Elapsed);
                st.Reset();
                Console.WriteLine();

                st.Start();
                pr.kitapCase(kitapAdı);
                st.Stop();
                Console.WriteLine("Süre: (switch case için) " + st.Elapsed);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
            st.Reset();
            Console.WriteLine("/////////////////////////////////");
            Console.WriteLine();

            Console.WriteLine("beşinci Soru");
            Console.WriteLine("/////////////////////////////////");
            try
            {
                pr.alfabeDegerleri();
               
                Console.WriteLine("Bir harf girin ");
                string harf = Console.ReadLine();
                st.Start();
                pr.alfabeİfElse(harf);
                st.Stop();
                Console.WriteLine("Süre: (if else) " + st.Elapsed);
                Console.WriteLine(); st.Reset();
                st.Start();
                pr.alfabeSwitchCase(harf);
                st.Stop();
                Console.WriteLine("Süre: (switch case) " + st.Elapsed);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            st.Reset();
            Console.ReadKey();
        }
    }
}
