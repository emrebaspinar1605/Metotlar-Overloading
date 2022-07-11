using System;

namespace Metotlar_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string sayi="999";
            bool sonuc =int.TryParse(sayi,out number);
            if (sonuc)
            {
                Console.WriteLine("Başarılı, Sayı : "+number);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }
            Metotlar instance = new Metotlar();
            instance.Topla(2,3,out int toplam);
            Console.WriteLine(toplam);
            //Metot aşırı yüklemesi => OverLoading
            
            int ifade = 999;
            instance.EkranaYazdir(ifade.ToString());
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Emre","Başpınar");

            //Method Imzası
            //Method Adı + parametre sayisi + parametre
        }
    }
    class Metotlar
    {
        public void Topla(int a,int b,out int toplam)
        {
            toplam=a+b;
        }
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        } 
         public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        } 
          public void EkranaYazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1+veri2);
        } 
    }
}