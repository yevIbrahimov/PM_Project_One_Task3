using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
				var action = Int32.Parse(Console.ReadLine());
				while (polls.Polls.Count() == 0 && action == 1)
				{
					Console.Write("Nothing to manage, add poll or exit: ");
					action = Int32.Parse(Console.ReadLine());
				}
				while (action!=0 && action != 2 && action != 1)
				{
					Console.Write("Only 0, 1, 2!!! Manage poll - 1, add poll - 2, or exit - 0: ");
					action = Int32.Parse(Console.ReadLine());
				}
				if (action == 0)
				{
					break;
				}
				if (action==2)
				{
					AddPoll addPoll = new AddPoll();
					addPoll.AddPollMethod();
				}
				string pollName = "";
				if (action == 1)
				{
					pollName = PollName();

					Console.WriteLine("Your actions: 1 - show poll, 2 - delete poll, 3 - remove question, 4 - add question, 5 - show statistics, 0 - exit");
					Console.Write("Choose action: ");
					action = Int32.Parse(Console.ReadLine());
					action = CheckInput(action);

					if (action == 0)
					{
						break;
					}

					switch (action)
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
