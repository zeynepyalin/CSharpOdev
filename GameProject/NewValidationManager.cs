using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class NewValidationManager : IUserValidationService
	{
		// yeni e-devlet sistemi gelirse
		public bool Validate(Gamer gamer)
		{
			return true;
		}
	}
}
