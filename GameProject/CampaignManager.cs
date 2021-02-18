using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
	class CampaignManager : ICampaignService
	{
		public void CDelete()
		{
			Console.WriteLine("kampanya silindi");
		}

		public void CEnter()
		{
			Console.WriteLine("kampanya girildi");
		}

		public void CUpdate()
		{
			Console.WriteLine("kampanya güncellendi");
		}
	}
}
