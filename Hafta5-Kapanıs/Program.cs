using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hafta5_Kapanıs
{
    internal class Program
    {
        private static int kapiS;

        static void Main(string[] args)
        {

            Console.WriteLine("Merhaba Araba uretmek ister misiniz? E || H");
            string cevap = Console.ReadLine().ToUpper();
            ArrayList list = new ArrayList();

            if (cevap == "E")
            {

                bool dongu = true;


                do
                {
                    Console.Clear();
                basaDon:

                    Console.WriteLine("Seri numarasını Giriniz");
                    int Serino = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Markasını Giriniz");
                    string Marka = Console.ReadLine();



                    Console.WriteLine("Modelini Giriniz");
                    string model = Console.ReadLine();


                    DateTime dateime = DateTime.Now;


                tekr:

                    try
                    {
                        Console.WriteLine("Kapı sayisini giriniz");
                        int kapiS = Convert.ToInt32(Console.ReadLine());

                        Araba Auretim = new Araba(dateime, Serino, Marka, model, kapiS);
                        list.Add(Auretim);

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Yanlış karakter lutfen sadece rakam giriniz");
                        goto tekr;
                    }








                tekrr:
                    Console.WriteLine("Tekrar Araba uretmek ister misiniz? E || H");
                    string EveyaH = Console.ReadLine().ToUpper();

                    if (EveyaH == "E")
                    {
                        dongu = true;
                        Console.Clear();
                        goto basaDon;
                    }
                    else if (EveyaH == "H")
                    {
                        dongu = false;
                        Console.WriteLine("Bizi seçtiğiniz için teşekkürler");
                        System.Threading.Thread.Sleep(2000);

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Yanlış seçim lütfen E || H den birini seçiniz");
                    }
                    goto tekrr;


                } while (dongu != false);




            }
            else if (cevap == "H")
            {
                Console.WriteLine("Teşekkürler");
            }
            else
            {
                Console.WriteLine("Yanlış seçim lütfen E || H den birini seçiniz");
            }

            Console.Clear();

            Console.WriteLine("Urettiğiniz Arabalar");

            foreach (Araba i in list)
            {
                i.bilgi();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
