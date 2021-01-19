using System;
using System.Collections.Generic;

namespace PollAPP
{
	class Program
	{
		static void Main(string[] args)
		{
			Welcome welcome = new Welcome();
			welcome.WelcomeMethod();
			Input input = new Input();
			input.InputMethod();
			
		}
	}
}
