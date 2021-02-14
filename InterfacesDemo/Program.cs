using System;

namespace InterfacesDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			IWorker[] workers = new IWorker[3]
			{
				new Manager(), // liste oluştururken içinde de tanımlanabilirler.
				new Worker(),
				new Robot()
			};

			foreach (var worker in workers)
			{
				worker.Work();
			}

			IEat[] eats = new IEat[2]
			{
				new Manager(), 
				new Worker()
			};

			foreach (var eat in eats)
			{
				eat.Eat();
			}
		}
	}

	interface IWorker
	{
		void Work();
	}
	interface IEat
	{
		void Eat();
	}
	interface ISalary
	{
		void GetSalary();
	}
	// bir class sadece bir classtan kalıtım alabilir ama interfacelerden istediği kadarını alabilir. 
	// eğer bir class ve çeşitli interface birlikte yazılacak ise önce class yazılır sonrasında interface yazılır.
	class Manager : IWorker, IEat, ISalary
	{
		public void Eat()
		{
			Console.WriteLine("yedik");
		}

		public void GetSalary()
		{
			Console.WriteLine("maaş aldık");
		}

		public void Work()
		{
			Console.WriteLine("çalıştık");
		}
	}
	class Worker : IWorker, IEat, ISalary
	{
		public void Eat()
		{
			Console.WriteLine("yedik");
		}

		public void GetSalary()
		{
			Console.WriteLine("maaş aldık");
		}

		public void Work()
		{
			Console.WriteLine("çalıştık");
		}
	}
	class Robot : IWorker
	{
		public void Work()
		{
			Console.WriteLine("çalıştık");
		}
	}
}
