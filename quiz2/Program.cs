using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            müsteriler müsteri1 = new müsteriler();
            müsteri1.ad = "Dogan";
            müsteri1.soyad = "Özyurt";
            müsteri1.tc = 123456;
            müsteri1.hesap = 2000;

            müsteriler müsteri2 = new müsteriler();
            müsteri2.ad = "Kerem";
            müsteri2.soyad = "Karabulut";
            müsteri2.tc = 654321;
            müsteri2.hesap = 2500;

            müsteriler müsteri3 = new müsteriler();
            müsteri3.ad = "Enes";
            müsteri3.soyad = "Özer";
            müsteri3.tc = 142536;
            müsteri3.hesap = 3000;

            müsteriler[] müsteri = new müsteriler[] {müsteri1, müsteri2, müsteri3 };

            

            // MÜŞTERİLERİN LİSTESİ
             foreach (var müsteriler in müsteri)
            {
                Console.WriteLine(müsteriler.ad + " - " + müsteriler.soyad);

                Console.WriteLine(müsteriler.tc + " - " + müsteriler.hesap);
              
            }

            //MÜŞTERİ EKLEME

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(müsteri1);
            Console.WriteLine("--------");

            //MÜŞTERİ SİLME

            musteriManager.Deletion(müsteri3);
           


        }
    }
}
