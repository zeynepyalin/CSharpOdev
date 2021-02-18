using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class UserValidationManager : IUserValidationService
	{
		public bool Validate(Gamer gamer)
		{
			if (gamer.BirthYear == 1998 && gamer.FirstName == "Zepp" && gamer.LastName == "Idk" && gamer.IdentityNumber == 980430 )
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
