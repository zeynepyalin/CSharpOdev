using System;

namespace AbstractClasses
{
	class Program
	{
		static void Main(string[] args)
		{
			// interface referans typedır ve referans tutar
			// abstract sınıf ise class yapısına ve özelliklerine sahiptir.
			// abstract sınıflar hem tamamlanmış hem tamamlanmamış (sadece imza) operasyonlar içerebilir.
			// abstract sınıflar newlenemez. (çünkü tamamlanmış ve tamamlanmamış fonk içerir, normal classtan da farkı budur)
			// ac'lar constructor içerebilir, kendi başına anlamı yok ama implemente edilen class çalıştırıldığında constructor da çalışacaktır.
			// ac içinde constructor tanımlaması protected (publicle değil) yapılırsa daha mantıklıdır çünkü sadece implemente edildiği yerde çalışacak.
		}
	}
	abstract class MevzuatBase
	{
		// ortak olmayan özellikler imza olarak yazılır.
		public abstract void Degerlendir();
		// ortak olan özellikler açıklamaları ile yazılır.
		public void Kaydet()
		{
			Console.WriteLine("Kaydedildi");
		}
	}
	class AMevzuat:MevzuatBase
	{
		public override void Degerlendir()
		{
			Console.WriteLine("a mevzuatına göre değerlendir");
		}
	}
	class BMevzuat : MevzuatBase
	{
		public override void Degerlendir()
		{
			Console.WriteLine("b mevzuatına göre değerlendir");
		}
	}
	class CustomerManager
	{
		// class içinde birbiriyle ilgili operasyonlar tutar.
		// aynı zamanda birbiriyle ilgili alanları (field) da tutabilirler.
		// ama aynı class içerisinde ikisi birden olmaz.
		public void Add()
		{
			Console.WriteLine("Added");
		}
		public void Delete()
		{
			Console.WriteLine("Deleted");
		}
	}
}
