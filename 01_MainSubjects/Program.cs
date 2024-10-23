using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Yazdırma komutları

			//Console.Write("merhaba");
			//Console.WriteLine("selam");


			//Console.WriteLine("***** Yemek Kategorileri *****");
			//Console.WriteLine();
			//Console.WriteLine("1-Çorbalar");
			//Console.WriteLine("2-Ana yemekler");
			//Console.WriteLine("3-Soğuk Başlangıçlar");
			//Console.WriteLine("4-Salatalar");
			//Console.WriteLine("5-Tatlılar");
			//Console.WriteLine("6-içecekler");
			//Console.WriteLine();

			#endregion

			#region String DEĞİŞKENLER

			// String
			// Değişken_Türü Değişken_Adı;

			//string name;
			//name = "Kadir";
			//Console.Write(name);

			string customerName;
			string customerSurname;
			string customerPhone;
			string customerEmail , district ,city;

			customerName = "Ali";
			customerSurname = "Çınar";
			customerPhone = "+9050020020";
			customerEmail = "deneme@gmail.com";
			district = "Kadıköy";
			city = "İstanbul";

            Console.WriteLine("***** Rezervasyon Kartı *****");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Müşteri :"+customerName + " " + customerSurname);
            Console.WriteLine("İetişim: "+customerPhone);
            Console.WriteLine("Email :"+customerEmail);
            Console.WriteLine("Adres :"+district + "/" + city);
			Console.WriteLine("------------------------------------------------");

			customerName = "Ayşegül";
			customerSurname = "Kaya";
			customerPhone = "235235235";
			customerEmail = "test@gmail.com";
			district = "Sapanca";
			city = "Sakarya";

			Console.WriteLine("------------------------------------------------");
			Console.WriteLine("Müşteri :" + customerName + " " + customerSurname);
			Console.WriteLine("İetişim: " + customerPhone);
			Console.WriteLine("Email :" + customerEmail);
			Console.WriteLine("Adres :" + district + "/" + city);
			Console.WriteLine("------------------------------------------------");


			#endregion

			#region Int Değişkenler

			// int 

			//int number = 24;
			//Console.WriteLine(number);

			int hamburgerprice = 300;
			int cokeprice = 35;
			int waterprice = 10;
			int friesprice = 50;
			int pizzaprice = 250;
			int lemonadeprice = 30;

            Console.WriteLine("***** Restorant Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger : " + hamburgerprice + "TL");
			Console.WriteLine("-----Kola : " + cokeprice + "TL");
			Console.WriteLine("-----Su : " + waterprice + "TL");
			Console.WriteLine("-----Kızartma : " + friesprice + "TL");
			Console.WriteLine("-----Pizza : " + pizzaprice + "TL");
			Console.WriteLine("-----Limonata : " + lemonadeprice + "TL");
            Console.WriteLine();
            Console.WriteLine("***** Restorant Menü Fiyatı *****");
			Console.WriteLine();

			int hamburgerCount;
			int cokeCount;
			int waterCount;
			int friesprCount;
			int pizzaCount;
			int lemonadeCount;


			int totalHamburgerprice;
			int totalCokePrice;
			int totalWaterPrice;
			int totalfriesPrice;
			int totalPizzaCount;
			int totalLemonadePrice;


			hamburgerCount = 3;
			cokeCount = 3;
			waterCount = 3;
			friesprCount = 1;
			pizzaCount = 0;
			lemonadeCount = 0;

			totalHamburgerprice = hamburgerCount * hamburgerprice;
			totalCokePrice = cokeCount * cokeprice;
			totalWaterPrice = waterCount * waterprice;
			totalfriesPrice = friesprCount * friesprice;
			totalPizzaCount = pizzaCount * pizzaprice;
			totalLemonadePrice = lemonadeCount * lemonadeprice;

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Hamburger Tutarı : "+ totalHamburgerprice + "TL");
            Console.WriteLine("Cola Tutarı : "+ totalCokePrice + "TL");
            Console.WriteLine("Su Tutarı : "+ totalWaterPrice + "TL");
            Console.WriteLine("Kızartma Tutarı : "+ totalfriesPrice + "TL");
            Console.WriteLine("Pizza Tutarı : " +totalPizzaCount + "TL");
            Console.WriteLine("Limonata Tutarı : "+ totalLemonadePrice + "TL");
            Console.WriteLine();

			int toplam = totalHamburgerprice + totalCokePrice + totalWaterPrice + totalfriesPrice + totalPizzaCount + totalLemonadePrice;


			Console.WriteLine("Toplam Fatura Tutarı : " + toplam);

            #endregion













            Console.ReadKey();





        }
	}
}

//Yazdırma komutları