﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region For Döngüsü
			// Döngüler 

			// For(x;y;z)
			//x:başlangı.
			//y:bitiş
			//z:artış-azalış


			//int i;

			//for (i = 1; i<5; i++)
			//{
			//  Console.WriteLine("2");

			// }

			//for (int i = 1; i <=20; i++)
			//{
			//             Console.WriteLine(i);
			//         }


			//for (int i = 3; i<=50; i+=3)
			//{
			//             Console.WriteLine(i);
			//         }


			//Console.Write("Lütfen Ekrana Yazılmasını istediğiniz adedi giriniz: ");
			//int finishValue=int.Parse(Console.ReadLine());

			//for (int i = 1; i <= finishValue; i++)
			//{
			//    Console.WriteLine("Sayı: ");
			//}





			#endregion


			#region For Döngüsü İle Karar Yapıları      

			//for (int i = 1; i <= 100; i++)
			//{
			//    if (i%5 == 0)
			//    {
			//        Console.WriteLine(i);
			//    }
			//}

			//int totalvalue = 0;

			//for (int i = 1; i<=10; i++)
			//{
			//    totalvalue += i;
			//}

			//Console.WriteLine(totalvalue);


			//int totalvalue = 0;

			//for (int i = 1; i<=20; i++)
			//{
			//    if (i%2==0)
			//    {
			//        totalvalue += i;
			//        Console.WriteLine(i);
			//    }
			//}

			//Console.WriteLine(totalvalue);


			//int count = 0;

			//for (int i = 1; i<=50 ; i++)
			//{
			//    if (i%7==0)
			//    {
			//        count++;
			//        Console.WriteLine(i);

			//    }
			//}
			//Console.WriteLine("----");
			//Console.WriteLine(count);


			//int bacterium = 1;

			//for (int i = 0; i<=24; i++)
			//{
			//    bacterium *= 2;
			//    Console.WriteLine(i+ ".Saat Sonunda :"+bacterium);
			//}




			#endregion


			#region While Dögüsü

			//int i = 1;

			//while (i <= 10)
			//{
			//	Console.WriteLine("Merhaba");
			//	i++;
			//}


			//int i = 1;

			//while (i <= 10)
			//{
			//	if (i%3==0)
			//	{
			//                 Console.WriteLine(i);
			//             }

			//	i++;
			//}


			//int i = 1;
			//int sum = 0;

			//while (i <= 10)
			//{
			//	sum += i;
			//	i++;
			//}

			//         Console.WriteLine(sum);








			#endregion


			#region Örnek Sınav Sorusu

			// Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız

			// 456

			//Console.WriteLine("Bir Sayı Giriniz: ");
			//int number = int.Parse(Console.ReadLine());
			//int ones, tens, hundreds;
			//int sum;


			//ones = number % 10;
			//tens = (number % 100) / 10;
			//hundreds = number / 100;

			//         Console.WriteLine("ones: " + ones + " tens: " + tens + " hundreds: " + hundreds);

			//sum = ones + tens + hundreds;

			//         Console.WriteLine("Toplam Sayı: " +sum);

			#endregion

			Console.Read();







		}
	}
}