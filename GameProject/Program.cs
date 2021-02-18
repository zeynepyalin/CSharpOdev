using System;

namespace GameProject
{
	class Program
	{
		static void Main(string[] args)
		{
			// sadece newlemek yetmez, özellikle doğrulama istiyor
			GamerManager gamerManager = new GamerManager(new UserValidationManager());
			gamerManager.SignUp(new Gamer
			{
				Id = 1,
				BirthYear=1998,
				FirstName="Zepp",
				LastName="Idk",
				IdentityNumber=980430
			});
			GamerManager gamerManager2 = new GamerManager(new NewValidationManager());
			gamerManager2.SignUp(new Gamer
			{
				Id = 1,
				BirthYear = 1998,
				FirstName = "Zepp",
				LastName = "Idk",
				IdentityNumber = 980430
			});

			Console.WriteLine("Hello World!");
		}
	}
}
