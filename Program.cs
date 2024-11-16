using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp //projeye verdiğimiz isim
{
    internal class Program  // internal --> erişim belirleyici
    {
        static void Main(string[] args)  // komutlarımızı main metotumuzun içine yazacağız.
        {
            #region YazdırmKomutları

            //Console.WriteLine("Gözde Nur Akça");
            //Console.Write("Selam");
            
            // Console.WriteLine("******* Yemek Kategorileri *******");
            // Console.WriteLine();
            // Console.WriteLine("1-Çorbalar");
            // Console.WriteLine("2-Ana Yemekler");
            // Console.WriteLine("3-Soğuk Başlangıçlar");
            // Console.WriteLine("4-Salatalar");
            // Console.WriteLine("5-Tatlılar");
            // Console.WriteLine("6-İçecekler");
            // Console.WriteLine();
            // Console.WriteLine("******* Yemek Kategorileri *******");
            #endregion

            #region StringDeğişkenler
            
            //string
            //değişken türü + değişken adı;
            //değişkenler adlandırılırken araya boşluk bırakılmaz.
            //isimlendirme çeşitleri vardır; camelCase, 
            // string customerName;
            // string customerSurname;
            // string customerPhone;
            // string customerEmail, district, city; // bir satırdan aynı türde birden fazla değişken tanımlayabiliriz.
            //
            // customerName = "Ali";
            // customerSurname = "Çınar";
            // customerPhone = "+90 500 400 30 20";
            // customerEmail = "Ali@Ali.com";
            // district = "Kadıköy";
            // city = "İstanbul";
            //
            // Console.WriteLine("**** Rezervasyon Kartı ****");
            // Console.WriteLine();
            // Console.WriteLine("---------------------------");
            // Console.WriteLine("Müşteri : " +customerName + " " + customerSurname);
            // Console.WriteLine("Müşteri Telefon Numarası : " +customerPhone);
            // Console.WriteLine("Müşteri Email Adresi : " + customerEmail);
            // Console.WriteLine("Müşteri ilçe/il : " +district+ " / " + city);
            // Console.WriteLine("---------------------------");
            // Console.WriteLine();
            //
            // customerName = "Ayşegül";
            // customerSurname = "Kaya";
            // customerPhone = "+90 500 400 80 70";
            // customerEmail = "Ayse@Ayse.com";
            // district = "Sapanca";
            // city = "Sakarya";
            // Console.WriteLine("---------------------------");
            // Console.WriteLine("Müşteri : " +customerName + " " + customerSurname);
            // Console.WriteLine("Müşteri Telefon Numarası : " +customerPhone);
            // Console.WriteLine("Müşteri Email Adresi : " + customerEmail);
            // Console.WriteLine("Müşteri ilçe/il : " +district+ " / " + city);
            // Console.WriteLine("---------------------------");
            #endregion

            #region IntDegiskenler
            // tamsayı türündeki değişkenlerdir.
            // int number = 24;
            // Console.WriteLine(number);
            
            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            int hamburgerPrice = 300;
            int cokePrice = 50;
            int waterPrice = 10;
            int friesPrice = 100;
            int pizzaPrice = 250;
            int lemonadePrice = 30;
            Console.WriteLine("----- Hamburger : " + hamburgerPrice + " TL");
            Console.WriteLine("----- Coke : " + cokePrice + " TL");
            Console.WriteLine("----- Water : " + waterPrice + " TL");
            Console.WriteLine("----- Fries : " + friesPrice + " TL");
            Console.WriteLine("----- Pizza : " + pizzaPrice + " TL");
            Console.WriteLine("----- Lemonade : " + lemonadePrice + " TL");
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;
            
            
            int totalPrice = 0;
            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;
            
            
            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            Console.WriteLine("Hamburger Tutarı : " + totalHamburgerPrice + "TL");
            totalCokePrice = cokeCount * cokePrice;
            Console.WriteLine("Kola Tutarı : " + totalCokePrice + "TL");
            totalWaterPrice = waterCount * waterPrice;
            Console.WriteLine("Su Tutarı : " + totalWaterPrice + "TL");
            totalFriesPrice = friesCount * friesPrice;
            Console.WriteLine("Kızartma Tutarı : " + totalFriesPrice + "TL");
            totalPizzaPrice = pizzaCount * pizzaPrice;
            Console.WriteLine("Pizza Tutarı : " + totalPizzaPrice + "TL");
            totalLemonadePrice= lemonadeCount * lemonadePrice;
            Console.WriteLine("Limonata Tutarı : " + totalLemonadePrice + "TL");
            Console.WriteLine("-----");
            totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice+ totalLemonadePrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL" );
            
            
            #endregion
            
            Console.Read();

        }
    }

}
