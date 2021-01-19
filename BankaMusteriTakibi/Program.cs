using System;

namespace BankaMusteriTakibi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Musteriler musteri1 = new Musteriler();
            musteri1.Id = 1;
            musteri1.KimlikNumarasi = 84649269537;
            musteri1.MusteriNumarasi = 20012002;
            musteri1.Adi = "Arda";
            musteri1.Soyad = "Karaosmanoğlu";
            musteri1.CepTelefonNumarasi = 533857275827;
            musteri1.EvAdres = "Çaydan Sk., Hamitköy Köyü, 99040, Lefkoşa, KKTC";

            Musteriler musteri2 = new Musteriler();
            musteri2.Id = 1;
            musteri2.KimlikNumarasi = 87532580654;
            musteri2.MusteriNumarasi = 20022004;
            musteri2.Adi = "Ozan Mehmet";
            musteri2.Soyad = "Maviözlü";
            musteri2.CepTelefonNumarasi = 53385626496;
            musteri2.EvAdres = "Atatürk Caddesi no:145, Gönyeli, Lefkoşa, KKTC";

            MusteriManager musterimanager = new MusteriManager();

            Console.WriteLine("---------------Müşteri Ekleme---------------");
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);

            Console.WriteLine("---------------Müşteri Liste---------------");
            musterimanager.Listele(musteri1);
            musterimanager.Listele(musteri2);

            Console.WriteLine("---------------Müşteri Silme---------------");
            musterimanager.Sil(musteri1);
            musterimanager.Sil(musteri2);

        }
    }
}
