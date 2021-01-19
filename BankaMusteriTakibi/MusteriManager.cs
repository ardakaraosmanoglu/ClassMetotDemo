using System;
namespace BankaMusteriTakibi
{
    public class MusteriManager
    {
        public void Ekle(Musteriler musteriler)
        {
            Console.WriteLine("Yeni Müşteri Eklendi: " + musteriler.Adi);
        }

        public void Sil(Musteriler musteriler)
        {
            Console.WriteLine(musteriler.KimlikNumarasi + " kimlik numarali müşteri sistemden silindi.");
        }
        
        public void Listele(Musteriler musteriler)
        {
            Console.WriteLine("ID: " + musteriler.Id);
            Console.WriteLine("Kimlık Numarası: " + musteriler.KimlikNumarasi);
            Console.WriteLine("Müşteri Numarası: " + musteriler.MusteriNumarasi);
            Console.WriteLine("Müşteri: " + musteriler.Adi + musteriler.Soyad);
            Console.WriteLine("Cep Telefonu: " + musteriler.CepTelefonNumarasi);
            Console.WriteLine("Ev Adresi" + musteriler.EvAdres);
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
