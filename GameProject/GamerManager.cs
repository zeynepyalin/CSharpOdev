using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class GamerManager : IGamerService
	{
		IUserValidationService _userValidationService;
		// gamer manager içerisinde doğrulama servisi kullanacağım demektir.
		public GamerManager(IUserValidationService userValidationService)
		{
			_userValidationService = userValidationService;
		}

		public void Delete(Gamer gamer)
		{
			Console.WriteLine("kayıt silindi");
		}

		public void SignUp(Gamer gamer)
		{
			if (_userValidationService.Validate(gamer) == true)
			{
				Console.WriteLine("kayıt olundu");
			}
			else
			{
				Console.WriteLine("kayıt başarısız");
			}
		}

		public void Update(Gamer gamer)
		{
			Console.WriteLine("kayıt güncellendi");
		}
	}
}
