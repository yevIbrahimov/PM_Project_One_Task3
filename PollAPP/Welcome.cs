using System;
using System.Collections.Generic;
using System.Text;

namespace PollAPP
{
	class Welcome
	{
		public void WelcomeMethod()
		{
			Console.Write("Welcome to PollApp!\nYou can manage poll or vote: ");
			var userChoose = Console.ReadLine();

			while (userChoose.ToUpper()!="MANAGE" && userChoose.ToUpper() != "VOTE")
			{
				Console.Write("Only manage or vote: ");
			}

			if (userChoose.ToUpper() == "MANAGE")
			{
				Manager manager = new Manager();
				manager.Manage();
			}
			else
			{

			}
		}
	}
}
