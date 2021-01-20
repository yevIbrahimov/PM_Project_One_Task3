using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PollAPP
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				XMLGetClass jsonGet = new XMLGetClass();
				jsonGet.XMLGetMethod();
				AddPoll poll = new AddPoll();
				Welcome welcome = new Welcome();
				welcome.WelcomeMethod();
				Input input = new Input();
				input.InputMethod();
				XMLAddClass json = new XMLAddClass();
				json.XMLAddMethod();
			}
			catch (Exception e)
			{
				throw new Exception($"ERROR!{e}");
			}
		}
	}
}
