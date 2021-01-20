using System;
using System.Collections.Generic;
using System.Text;

namespace PollAPP
{
	class Welcome
	{
		public void WelcomeMethod()
		{
			Console.Write("\t\tWelcome to PollApp !\n\n");
			Console.WriteLine("\tHere you can be Poll Manager - it is possible to add poll, manage poll or look through statistics ");
			Console.WriteLine("\tWhile managing poll you can show poll, delete poll, add or delete questions in chosen poll");
			Console.WriteLine("\tAlso you can vote in choosen poll. Created by Y. Ibrahimov");
			Console.WriteLine("\tType "Done" after entering question and answer");
			Console.WriteLine("\tYou can exit whenever you want, just type 'exit'\n");
		}
	}
}
