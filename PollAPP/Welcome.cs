using System;
using System.Collections.Generic;
using System.Text;

namespace PollAPP
{
	class Welcome
	{
		public void WelcomeMethod()
		{
			Console.Write("Welcome to PollApp!You can exit whenever you want, just type 'exit'\n");
			Console.WriteLine("Here you can be Poll Manager - it is possible to add poll, manage poll or look through ststistics ");
			Console.WriteLine("While managing poll you can show poll, delete poll, add or delete questions in chosen poll");
		}
	}
}
