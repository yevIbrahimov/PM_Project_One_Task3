using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace PollAPP
{
	class Manager
	{
		AddPoll polls = new AddPoll();

		public void Manage()
		{
			
			while (true)
			{
				Console.Write("Manage poll - 1, add poll - 2, or exit - 0: ");
				var action = Console.ReadLine();
				while (!Int32.TryParse(action, out int result))
				{
					Console.Write("Please type numbers! Manage poll - 1, add poll - 2, or exit - 0: ");
					action = Console.ReadLine();
				}
				while (action.Trim() == "")
				{
					Console.Write("Please type numbers! Manage poll - 1, add poll - 2, or exit - 0: ");
					action = Console.ReadLine();
				}
				while ( Int32.Parse(action) != 0 && Int32.Parse(action) != 2 && Int32.Parse(action) != 1  )
				{
					Console.Write("Only 0, 1, 2!!! Manage poll - 1, add poll - 2, or exit - 0: ");
					action = Console.ReadLine();
				}
				while (polls.Polls.Count() == 0 && Int32.Parse(action) == 1)
				{
					Console.Write("Nothing to manage, add poll or exit: ");
					action = Console.ReadLine();
				}
				if (Int32.Parse(action) == 0)
				{
					break;
				}
				if (Int32.Parse(action) == 2)
				{
					AddPoll addPoll = new AddPoll();
					addPoll.AddPollMethod();
				}
				string pollName = "";
				if (Int32.Parse(action) == 1)
				{
					pollName = PollName();

					Console.WriteLine("Your actions: 1 - show poll, 2 - delete poll, 3 - remove question, 4 - add question, 5 - show statistics, 0 - exit");
					Console.Write("Choose action: ");
					action = Console.ReadLine();
					action = CheckInput(Convert.ToInt32(action)).ToString() ;

					while (Int32.Parse(action) != 0 && Int32.Parse(action) != 1 && Int32.Parse(action) != 2 &&  Int32.Parse(action) != 3 && Int32.Parse(action) != 4 && Int32.Parse(action) != 5 && action.Trim() == "")
					{
						Console.Write("1 - show poll, 2 - delete poll, 3 - remove question, 4 - add question, 5 - show statistics, 0 - exit: ");
						action = Console.ReadLine();
					}

					if (Int32.Parse(action) == 0)
					{
						break;
					}

					switch (Int32.Parse(action))
					{
						case 1:
							ShowPoll showPoll = new ShowPoll();
							showPoll.ShowPollMethod(pollName);
							break;
						case 2:
							DeletePoll deletePoll = new DeletePoll();
							deletePoll.DeletePollMethod(pollName);
							break;
						case 3:
							DeleteQusetion deleteQusetion = new DeleteQusetion();
							deleteQusetion.RemoveQuestionMethod(pollName);
							break;
						case 4:
							AddQuestion addQuestion = new AddQuestion();
							addQuestion.AddQuestionMethod(pollName);
							break;
						case 5:
							Statistics statistics = new Statistics();
							statistics.StatisticsMethod(pollName);
							break;
					}
				}
			}
		}

		private string PollName()
		{
			AddPoll addPoll = new AddPoll();
			Console.Write("Poll name: ");
			var pollName = Console.ReadLine();
			if (pollName.ToUpper() == "ALL")
			{
				return "ALL";
			}

			var pollNames = from names in addPoll.Polls
							where names.PollName == pollName
							select names;
			if (pollNames.Count() == 0)
			{
				return null;
			}
			return pollName;
		}
		private int CheckInput(int action)
		{
			while (action != 1 && action != 2 && action != 3 && action != 4 && action != 5 && action != 0)
			{
				Console.Write("Just 1, 2, 3, 4, 5, 0! Action: ");
				action = Int32.Parse(Console.ReadLine());
			}
			return action;
		}

	}
}
